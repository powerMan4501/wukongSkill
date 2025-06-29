using System.Collections.Generic;
using System.Linq;
using b1.BGW;
using b1.Localization;
using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

public class BPS_NavigationSystem : PlayerControllerSystemBase
{
	private BPC_RebirthPointData RBPData;

	private Dictionary<FUStRebirthPointDesc, AActor> RBPNeedNav = new Dictionary<FUStRebirthPointDesc, AActor>();

	private TStrongObjectPtr<BGWDataAsset_RebirthPointNavigation> _RBPNaviConfig = new TStrongObjectPtr<BGWDataAsset_RebirthPointNavigation>();

	private TStrongObjectPtr<AActor> _NavigationEffectActor = new TStrongObjectPtr<AActor>();

	private NavigationSoundHelper SoundHelper_FXSync;

	private NavigationSoundHelper SoundHelper_Resident;

	private float Timer;

	private float Timer_ResidentSound;

	private IBGC_MovieData MovieData;

	private BGWDataAsset_RebirthPointNavigation RBPNaviConfig
	{
		get
		{
			if (_RBPNaviConfig.Get() == null)
			{
				string path = "BGWDataAsset_RebirthPointNavigation'/Game/00Main/Design/Config/DA_rebirthpoint_navigation.DA_rebirthpoint_navigation'";
				BGWDataAsset_RebirthPointNavigation newValue = BGW_PreloadAssetMgr.Get(Owner).TryGetCachedResourceObj<BGWDataAsset_RebirthPointNavigation>(path, ELoadResourceType.SyncLoadAndCache);
				_RBPNaviConfig.Set(newValue);
			}
			return _RBPNaviConfig.Get();
		}
	}

	private AActor NavigationEffectActor
	{
		get
		{
			if (_NavigationEffectActor.Get() == null)
			{
				_NavigationEffectActor.Set(BGU_UnrealWorldUtil.SpawnActor(Owner.World, RBPNaviConfig.Template.Value));
			}
			return _NavigationEffectActor.Get();
		}
	}

	public override void OnAttach()
	{
		base.OnAttach();
		RBPData = RequireWritableLocalPlayerControlData<BPC_RebirthPointData>();
		MovieData = RequireReadOnlyGameStateData<IBGC_MovieData, BGC_MovieData>();
	}

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
		SoundHelper_FXSync = new NavigationSoundHelper(NavigationSoundHelper.ESoundType.FXSync);
		SoundHelper_Resident = new NavigationSoundHelper(NavigationSoundHelper.ESoundType.Resident);
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		SoundHelper_FXSync?.StopNavigationSound("OnEndPlay", GetOwner());
		SoundHelper_Resident?.StopNavigationSound("OnEndPlay", GetOwner());
		SoundHelper_FXSync = null;
		SoundHelper_Resident = null;
		base.OnEndPlay(EndPlayReason);
		_RBPNaviConfig.Delete();
		_NavigationEffectActor.Delete();
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		Timer += DeltaTime;
		if (Timer > RBPNaviConfig.RefreshInterval)
		{
			Timer = 0f;
			UpdateNavigationEffect();
		}
		Timer_ResidentSound += DeltaTime;
		if (Timer_ResidentSound > RBPNaviConfig.RefreshInterval_ResidentSound)
		{
			Timer_ResidentSound = 0f;
			UpdateResidentRebirthPointSound();
		}
	}

	private void UpdateNavigationEffect()
	{
		APawn controlledPawn = base.PlayerController.GetControlledPawn();
		if (controlledPawn.IsNullOrDestroyed() || RBPData == null)
		{
			SoundHelper_FXSync?.StopNavigationSound("Pawn.IsNullOrDestroyed() || RBPData == null", GetOwner());
			return;
		}
		USplineComponent componentByClass = NavigationEffectActor.GetComponentByClass<USplineComponent>();
		UNiagaraComponent uNiagaraComponent = NavigationEffectActor.GetComponentsByTag(UClass.GetClass<UNiagaraComponent>(), new FName("GuideFx"))[0] as UNiagaraComponent;
		if (componentByClass.IsNullOrDestroyed() || uNiagaraComponent.IsNullOrDestroyed())
		{
			SoundHelper_FXSync?.StopNavigationSound("SplineComp.IsNullOrDestroyed() || NiaComp.IsNullOrDestroyed()", GetOwner());
			return;
		}
		BUC_BattleStateData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_BattleStateData>(base.PlayerController.GetControlledPawn());
		if (unPersistentReadOnlyData != null && unPersistentReadOnlyData.IsUnitInBattle())
		{
			ResetNavigationEffect(componentByClass, uNiagaraComponent);
			BUS_EventCollectionCS.Get(controlledPawn).Evt_UpdateDebugUIInfo.Invoke("Navigation", "<Normal_Red>禁止导航 战斗中</>");
			return;
		}
		if (MovieData != null && MovieData.IsPlaying())
		{
			ResetNavigationEffect(componentByClass, uNiagaraComponent);
			BUS_EventCollectionCS.Get(controlledPawn).Evt_UpdateDebugUIInfo.Invoke("Navigation", "<Normal_Red>禁止导航 Seq中</>");
			return;
		}
		KeyValuePair<FUStRebirthPointDesc, AActor> keyValuePair = default(KeyValuePair<FUStRebirthPointDesc, AActor>);
		FVector actorLocation = controlledPawn.GetActorLocation();
		NavigationEffectActor.SetActorLocation(actorLocation, bSweep: false, out var _, bTeleport: true);
		RBPNeedNav.Clear();
		foreach (KeyValuePair<int, AActor> item in RBPData.RegisteredRebirthPointIDActorMap)
		{
			if (!RBPData.IsRebirthPointActived(item.Key))
			{
				FUStRebirthPointDesc rebirthPointDesc = BGW_GameDB.GetRebirthPointDesc(item.Key);
				if (rebirthPointDesc != null)
				{
					RBPNeedNav.Add(rebirthPointDesc, item.Value);
				}
			}
		}
		IOrderedEnumerable<KeyValuePair<FUStRebirthPointDesc, AActor>> orderedEnumerable = RBPNeedNav.OrderByDescending(delegate(KeyValuePair<FUStRebirthPointDesc, AActor> RBP)
		{
			KeyValuePair<FUStRebirthPointDesc, AActor> keyValuePair2 = RBP;
			return keyValuePair2.Key.NavigationPriority;
		});
		foreach (KeyValuePair<FUStRebirthPointDesc, AActor> item2 in orderedEnumerable)
		{
			if (!item2.Value.IsNullOrDestroyed())
			{
				FVector actorLocation2 = item2.Value.GetActorLocation();
				if (!(MathLib.Abs(actorLocation2.Z - actorLocation.Z) > (float)item2.Key.NavigationAxisZRange) && FVector.Dist(actorLocation2, actorLocation) < (float)item2.Key.NavigationRange)
				{
					keyValuePair = item2;
					break;
				}
			}
		}
		if (DebugConfig.Navigation)
		{
			if (keyValuePair.Key != null)
			{
				BUS_EventCollectionCS.Get(controlledPawn).Evt_UpdateDebugUITitle.Invoke("Navigation", $"正在引导 <Normal_Green>{keyValuePair.Key.Name.ToFText()}</>");
				BUS_EventCollectionCS.Get(controlledPawn).Evt_UpdateDebugUIInfo.Invoke("Navigation", $"引导线总长度为 = {componentByClass.GetSplineLength()}");
				BUS_EventCollectionCS.Get(controlledPawn).Evt_UpdateDebugUIInfo.Invoke("Navigation", $"引导线结点数量 = {componentByClass.GetNumberOfSplinePoints()}", 1);
			}
			else
			{
				BUS_EventCollectionCS.Get(controlledPawn).Evt_UpdateDebugUITitle.Invoke("Navigation", "<Normal_Red>无目标 停止导航</>");
			}
			BUS_EventCollectionCS.Get(controlledPawn).Evt_UpdateDebugUILamp.Invoke("Navigation", B1GlobalFSlateColor.Yellow);
			for (int num = 0; num < orderedEnumerable.Count(); num++)
			{
				FVector actorLocation3 = orderedEnumerable.ElementAt(num).Value.GetActorLocation();
				int num2 = (int)FVector.Dist(actorLocation3, actorLocation);
				string text = ((num2 > orderedEnumerable.ElementAt(num).Key.NavigationRange) ? "Normal_Red" : "Normal_Green");
				int num3 = (int)(actorLocation.Z - actorLocation3.Z);
				string text2 = ((MathLib.Abs(num3) > (float)orderedEnumerable.ElementAt(num).Key.NavigationAxisZRange) ? "Normal_Red" : "Normal_Green");
				BUS_EventCollectionCS.Get(controlledPawn).Evt_UpdateDebugUIKeyValuePair.Invoke("Navigation", $"{num}_{orderedEnumerable.ElementAt(num).Key.Name.ToFText()}", $"<{text}>{num2}</> <{text2}>{num3}</>");
			}
		}
		if (keyValuePair.Value.IsNullOrDestroyed())
		{
			ResetNavigationEffect(componentByClass, uNiagaraComponent);
			BUS_EventCollectionCS.Get(controlledPawn).Evt_UpdateDebugUITitle.Invoke("Navigation", "<Normal_Red>禁止导航 无目标</>");
			return;
		}
		FVector actorLocation4 = keyValuePair.Value.GetActorLocation();
		bool flag = UGSE_EngineFuncLib.TestPathSync(base.PlayerController, actorLocation4);
		List<FVector> list = null;
		if (flag)
		{
			list = UGSE_EngineFuncLib.FindPathSync(base.PlayerController, actorLocation4);
			if (FVector.Dist(actorLocation4, list.Last()) > 500f)
			{
				list = null;
			}
		}
		if (list != null)
		{
			if (list.Count < 2)
			{
				ResetNavigationEffect(componentByClass, uNiagaraComponent);
				BUS_EventCollectionCS.Get(controlledPawn).Evt_UpdateDebugUITitle.Invoke("Navigation", "<Normal_Red>禁止导航 距离目标过近</>");
				return;
			}
			if (list.Count > RBPNaviConfig.EFXNodeMaxNum)
			{
				list.RemoveRange(RBPNaviConfig.EFXNodeMaxNum, list.Count - RBPNaviConfig.EFXNodeMaxNum);
			}
			FVector safeNormal2D = (actorLocation - BGUFuncLibActorTransformCS.BGUGetActorLocation(base.PlayerController.PlayerCameraManager)).GetSafeNormal2D();
			FVector fVector = safeNormal2D.RotateAngleAxis(90.0, FVector.UpVector);
			FVector a = safeNormal2D.RotateAngleAxis(-45.0, FVector.UpVector);
			FVector a2 = safeNormal2D.RotateAngleAxis(45.0, FVector.UpVector);
			FVector safeNormal2D2 = (list[1] - actorLocation).GetSafeNormal2D();
			float num4 = FVector.DotProduct(a, safeNormal2D2);
			float num5 = FVector.DotProduct(a2, safeNormal2D2);
			FVector zeroVector = FVector.ZeroVector;
			FVector zeroVector2 = FVector.ZeroVector;
			if (num4 <= 0f && num5 > 0f)
			{
				zeroVector += safeNormal2D;
				zeroVector2 -= fVector;
			}
			else if (num4 <= 0f && num5 <= 0f)
			{
				zeroVector += safeNormal2D;
				zeroVector2 -= fVector;
			}
			else if (num4 > 0f && num5 > 0f)
			{
				zeroVector -= safeNormal2D;
				zeroVector2 -= fVector;
			}
			else if (num4 > 0f && num5 <= 0f)
			{
				zeroVector += safeNormal2D;
				zeroVector2 += fVector;
			}
			zeroVector *= (double)RBPNaviConfig.EFXNodeOffsetFirst.X;
			zeroVector2 *= (double)RBPNaviConfig.EFXNodeOffsetFirst.Y;
			list[0] += zeroVector;
			list[0] += zeroVector2;
			for (int num6 = 0; num6 < list.Count; num6++)
			{
				list[num6] += RBPNaviConfig.EFXNodeOffsetAll;
			}
			list.Reverse();
			componentByClass.SetSplinePoints(list, ESplineCoordinateSpace.World);
			uNiagaraComponent.SetNiagaraVariableFloat("User.SplineLength", componentByClass.GetSplineLength());
			if (componentByClass.GetSplineLength() > (float)RBPNaviConfig.EFXMinDir)
			{
				uNiagaraComponent.Deactivate();
				uNiagaraComponent.SetVariableBool(B1GlobalFNames.User_GS_EfxStop, InValue: false);
				uNiagaraComponent.Activate();
				SoundHelper_FXSync?.PlayNavigationSound(keyValuePair.Key, keyValuePair.Value);
			}
			else
			{
				ResetNavigationEffect(componentByClass, uNiagaraComponent);
				BUS_EventCollectionCS.Get(controlledPawn).Evt_UpdateDebugUITitle.Invoke("Navigation", "<Normal_Red>禁止导航 距离目标过近</>");
			}
			if (DebugConfig.Navigation)
			{
				for (int num7 = 0; num7 < list.Count - 1; num7++)
				{
					U3DebugUtil.U3DrawDebugLine(Owner.World, list[num7], list[num7 + 1], FColor.DarkOrange, bPersistentLines: false, 1f, 0, 10f);
				}
			}
		}
		else
		{
			ResetNavigationEffect(componentByClass, uNiagaraComponent);
		}
		BUS_EventCollectionCS.Get(controlledPawn).Evt_UpdateDebugUILamp.Invoke("Navigation", flag ? B1GlobalFSlateColor.Green : B1GlobalFSlateColor.Red);
	}

	private void UpdateResidentRebirthPointSound()
	{
		APawn controlledPawn = base.PlayerController.GetControlledPawn();
		if (controlledPawn.IsNullOrDestroyed() || RBPData == null)
		{
			SoundHelper_Resident?.StopNavigationSound("Pawn.IsNullOrDestroyed() || RBPData == null", GetOwner());
			return;
		}
		BUC_BattleStateData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_BattleStateData>(controlledPawn);
		if (unPersistentReadOnlyData != null && unPersistentReadOnlyData.IsUnitInBattle())
		{
			SoundHelper_Resident?.StopNavigationSound("UnitInBattle", GetOwner());
			return;
		}
		if (MovieData != null && MovieData.IsPlaying())
		{
			SoundHelper_Resident?.StopNavigationSound("Movie IsPlaying", GetOwner());
			return;
		}
		KeyValuePair<FUStRebirthPointDesc, AActor> keyValuePair = default(KeyValuePair<FUStRebirthPointDesc, AActor>);
		FVector actorLocation = controlledPawn.GetActorLocation();
		Dictionary<FUStRebirthPointDesc, AActor> dictionary = new Dictionary<FUStRebirthPointDesc, AActor>();
		foreach (KeyValuePair<int, AActor> item in RBPData.RegisteredRebirthPointIDActorMap)
		{
			FUStRebirthPointDesc rebirthPointDesc = BGW_GameDB.GetRebirthPointDesc(item.Key);
			if (rebirthPointDesc != null && !item.Value.IsNullOrDestroyed())
			{
				dictionary.Add(rebirthPointDesc, item.Value);
			}
		}
		foreach (KeyValuePair<FUStRebirthPointDesc, AActor> item2 in dictionary.OrderByDescending(delegate(KeyValuePair<FUStRebirthPointDesc, AActor> RBP)
		{
			KeyValuePair<FUStRebirthPointDesc, AActor> keyValuePair2 = RBP;
			return keyValuePair2.Key.NavigationPriority;
		}))
		{
			if (!item2.Value.IsNullOrDestroyed())
			{
				FVector actorLocation2 = item2.Value.GetActorLocation();
				if (!(MathLib.Abs(actorLocation2.Z - actorLocation.Z) > (float)item2.Key.NavigationAxisZRange) && FVector.Dist(actorLocation2, actorLocation) < (float)item2.Key.NavigationRange)
				{
					keyValuePair = item2;
					break;
				}
			}
		}
		if (keyValuePair.Value.IsNullOrDestroyed())
		{
			SoundHelper_Resident?.StopNavigationSound("TargetRBP IsNullOrDestroyed", GetOwner());
		}
		else
		{
			SoundHelper_Resident?.PlayNavigationSound(keyValuePair.Key, keyValuePair.Value);
		}
	}

	private void ResetNavigationEffect(USplineComponent SplineComp, UNiagaraComponent NiaComp)
	{
		NiaComp.SetVariableBool(B1GlobalFNames.User_GS_EfxStop, InValue: true);
		NiaComp.Deactivate();
		SoundHelper_FXSync?.StopNavigationSound("ResetNavigationEffect", GetOwner());
	}
}
