using System.Collections.Generic;
using b1.BGW;
using b1.EventDelDefine;
using b1.Plugins.AkAudio;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_ProjectileLaserComp : UActorCompBaseCS
{
	private BUC_ProjectileLaserData ProjectileLaserData;

	private IBUC_MasterData MasterData;

	private IBPC_ListenerMgrData ListenerMgrData;

	private static ETraceTypeQuery TraceType;

	public override void OnAttach()
	{
		ProjectileLaserData = RequireWritableData<BUC_ProjectileLaserData>();
		MasterData = RequireReadOnlyData<IBUC_MasterData, BUC_MasterData>();
		base.BUSEventCollection.Evt_OnProjectileIDChanged += new Del_Void_Int(OnProjectileIDChanged);
		base.BUSEventCollection.Evt_OnProjectileDead += new Del_OnBulletDead(OnProjectileDead);
	}

	public override void OnBeginPlay()
	{
		foreach (UActorComponent item in Owner.GetComponentsByTag(UClass.GetClass<UFXSystemComponent>(), FXParamName.LaserFX_Tag))
		{
			UNiagaraComponent uNiagaraComponent = item as UNiagaraComponent;
			if (uNiagaraComponent != null)
			{
				ProjectileLaserData.LaserNgComps.Add(uNiagaraComponent);
			}
		}
		OnUpdateLaserFX(BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner));
	}

	public override void LateBeginPlay()
	{
		if (ProjectileLaserData.AkEvent_Laser != null)
		{
			UAkComponent AkComp;
			int num = PostAKEvent(ProjectileLaserData.AkEvent_Laser, out AkComp);
			if (num > 0)
			{
				ProjectileLaserData.PlayingID_LaserAudio = num;
				ProjectileLaserData.LaserAudioComp = AkComp;
			}
		}
	}

	private int PostAKEvent(UAkAudioEvent AkEvent, out UAkComponent AkComp)
	{
		AkComp = UAkGameplayStatics.GetAkComponent(Owner.GetRootComponent(), out var _, FName.None, FVector.ZeroVector, EAttachLocation.SnapToTarget);
		if (AkComp != null)
		{
			if (AkComp.GetOcclusionCollisionChannel() != ECollisionChannel.ECC_GameTraceChannel14)
			{
				AkComp.OcclusionCollisionChannel = (EAkCollisionChannel)27;
			}
			return AkComp.PostAkEvent(AkEvent, 0, null, "");
		}
		return 0;
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (ProjectileLaserData.LaserEnable)
		{
			LaserAgeTick(DeltaTime);
			LaserTick(DeltaTime);
		}
	}

	private void LaserAgeTick(float DeltaTime)
	{
		if (ProjectileLaserData.LaserAge >= 0f)
		{
			ProjectileLaserData.LaserAge += DeltaTime;
		}
	}

	private void OnProjectileIDChanged(int ProjetcileID)
	{
		if ((GetOwner() as BGUProjectileBaseActor).IsNullOrDestroyed())
		{
			return;
		}
		FUStBulletExpandDesc bulletExpandDesc = BGW_GameDB.GetBulletExpandDesc(ProjetcileID);
		if (bulletExpandDesc == null)
		{
			return;
		}
		ProjectileLaserData.LaserLengthSpeed = bulletExpandDesc.LaserLengthSpeed;
		if (!string.IsNullOrEmpty(bulletExpandDesc.LaserLengthSpeedCurvePath))
		{
			ProjectileLaserData.LaserLengthSpeedCurve = BGW_PreloadAssetMgr.Get(Owner).TryGetCachedResourceObj<UCurveFloat>(bulletExpandDesc.LaserLengthSpeedCurvePath, ELoadResourceType.SyncLoadAndCache);
			if (ProjectileLaserData.LaserLengthSpeedCurve != null)
			{
				ProjectileLaserData.LaserAge = 0f;
			}
		}
		ProjectileLaserData.LaserEnable = bulletExpandDesc.IsLaserType == EGSYesNo.Yes;
		ProjectileLaserData.LaserMaxLength = bulletExpandDesc.LaserMaxLength;
		ProjectileLaserData.LaserBulletCanThroughChr = bulletExpandDesc.BulletCanThroughBlockage == EGSYesNo.Yes;
	}

	private void LaserTick(float DeltaTime)
	{
		BGUProjectileBaseActor bGUProjectileBaseActor = GetOwner() as BGUProjectileBaseActor;
		if (bGUProjectileBaseActor.IsNullOrDestroyed())
		{
			return;
		}
		FVector actorLocation = bGUProjectileBaseActor.GetActorLocation();
		FVector actorForwardVector = bGUProjectileBaseActor.GetActorForwardVector();
		FVector actorRightVector = bGUProjectileBaseActor.GetActorRightVector();
		FVector actorUpVector = bGUProjectileBaseActor.GetActorUpVector();
		UBoxComponent boxCollisionComp = bGUProjectileBaseActor.GetBoxCollisionComp();
		if (boxCollisionComp == null)
		{
			return;
		}
		FVector fVector = actorLocation;
		FVector fVector2 = fVector + actorForwardVector * ProjectileLaserData.LaserMaxLength;
		FVector fVector3 = fVector2;
		FVector scaledBoxExtent = boxCollisionComp.GetScaledBoxExtent();
		FVector fVector4 = actorRightVector * scaledBoxExtent.Y;
		FVector fVector5 = actorUpVector * scaledBoxExtent.Z;
		float num = ProjectileLaserData.LaserMaxLength;
		int i = 0;
		List<AActor> list = new List<AActor>();
		AActor masterActor = MasterData.GetMasterActor();
		if (masterActor != null)
		{
			list.Add(masterActor);
		}
		bool flag = false;
		if (ProjectileLaserData.LaserBulletCanThroughChr)
		{
			List<int> list2 = new List<int> { (int)ProjectileLaserData.LaserMaxLength };
			BGUFuncLibSelectTargetsCS.SelectUnitsInCircle(bGUProjectileBaseActor, out var OutActors, masterActor, actorLocation, 1, list2);
			foreach (AActor item in OutActors)
			{
				if (!item.IsNullOrDestroyed())
				{
					list.Add(item);
				}
			}
		}
		for (; i <= 3; i++)
		{
			switch (i)
			{
			case 0:
				fVector = actorLocation;
				break;
			case 1:
				fVector = actorLocation + fVector5;
				break;
			case 2:
				fVector = actorLocation - fVector5 + fVector4;
				break;
			case 3:
				fVector = actorLocation - fVector5 - fVector4;
				break;
			}
			fVector2 = fVector + actorForwardVector * ProjectileLaserData.LaserMaxLength;
			if (UBGUSelectUtil.LineTraceSimple(bGUProjectileBaseActor, fVector, fVector2, TraceType, bDebug: false, out var HitResult, list) == 1)
			{
				float num2 = FVector.Dist(HitResult.HitLocation, fVector);
				if (num2 < num)
				{
					num = num2;
					flag = (HitResult.HitActor as BGUCharacterCS).IsNullOrDestroyed();
				}
			}
		}
		num += 20f;
		float num3 = num;
		float curLaserLengthSpeed = GetCurLaserLengthSpeed();
		if (curLaserLengthSpeed != -1f)
		{
			num3 = ((ProjectileLaserData.LaserCurLength >= num) ? num : MathLib.Clamp(ProjectileLaserData.LaserCurLength + curLaserLengthSpeed * DeltaTime, ProjectileLaserData.LaserCurLength, num));
		}
		ProjectileLaserData.LaserCurLength = num3;
		fVector3 = actorLocation + actorForwardVector * num3;
		FVector unscaledBoxExtent = boxCollisionComp.GetUnscaledBoxExtent();
		if (unscaledBoxExtent.X != 0f)
		{
			FVector relativeLocation = boxCollisionComp.RelativeLocation;
			FVector newLocation = new FVector(num3 / 2f, relativeLocation.Y, relativeLocation.Z);
			boxCollisionComp.SetRelativeLocation(newLocation, bSweep: false, out var _, bTeleport: false);
			FVector relativeScale3D = boxCollisionComp.RelativeScale3D;
			FVector relativeScale3D2 = new FVector(num3 / (unscaledBoxExtent.X * 2f), relativeScale3D.Y, relativeScale3D.Z);
			boxCollisionComp.SetRelativeScale3D(relativeScale3D2);
		}
		OnUpdateLaserFX(fVector3);
		OnUpdateLaserAudio(actorLocation, fVector3);
		UpdateHitSceneItemAudio();
		flag = num == num3 && flag;
		ProjectileLaserData.bHasHitSceneItem = flag;
		if (ProjectileLaserData.LastLaserEnd != FVector.ZeroVector)
		{
			FRotator newRot = MathLib.FindLookAtRotation(ProjectileLaserData.LastLaserEnd, fVector3);
			OnUpdateLaserHitSceneItem(flag, fVector3, newRot);
		}
		ProjectileLaserData.LastLaserEnd = fVector3;
	}

	private float GetCurLaserLengthSpeed()
	{
		if (ProjectileLaserData.LaserLengthSpeedCurve != null)
		{
			return ProjectileLaserData.LaserLengthSpeedCurve.GetFloatValue(ProjectileLaserData.LaserAge);
		}
		return ProjectileLaserData.LaserLengthSpeed;
	}

	private void OnUpdateLaserFX(FVector LaserEndPos)
	{
		foreach (UNiagaraComponent laserNgComp in ProjectileLaserData.LaserNgComps)
		{
			if (!laserNgComp.IsNullOrDestroyed())
			{
				laserNgComp.SetNiagaraVariableVec3(FXParamName.LaserFX_ParamName, LaserEndPos);
			}
		}
	}

	private void OnUpdateLaserHitSceneItem(bool HasHitSceneItem, FVector NewPos, FRotator NewRot)
	{
		AActor owner = GetOwner();
		if (owner.IsNullOrDestroyed())
		{
			return;
		}
		foreach (UActorComponent item in owner.GetComponentsByTag(UClass.GetClass<UFXSystemComponent>(), FXParamName.LaserHitItemFX_Tag))
		{
			UNiagaraComponent uNiagaraComponent = item as UNiagaraComponent;
			if (uNiagaraComponent != null)
			{
				uNiagaraComponent.SetNiagaraVariableBool(FXParamName.LaserHasHitItem_ParamName, HasHitSceneItem);
				if (HasHitSceneItem)
				{
					uNiagaraComponent.SetWorldLocation(NewPos, bSweep: false, out var SweepHitResult, bTeleport: false);
					uNiagaraComponent.SetWorldRotation(NewRot, bSweep: false, out SweepHitResult, bTeleport: false);
				}
			}
		}
	}

	private List<UNiagaraComponent> GetFXComp_HitSceneItem()
	{
		if (!ProjectileLaserData.HitSceneItemNgComps_Initted)
		{
			foreach (UActorComponent item in Owner.GetComponentsByTag(UClass.GetClass<UNiagaraComponent>(), FXParamName.LaserHitItemFX_Tag))
			{
				ProjectileLaserData.NgComps_HitSceneItem.Add(item as UNiagaraComponent);
			}
			ProjectileLaserData.HitSceneItemNgComps_Initted = true;
		}
		return ProjectileLaserData.NgComps_HitSceneItem;
	}

	private void OnUpdateLaserAudio(FVector LaserStartPos, FVector LaserEndPos)
	{
		if (ProjectileLaserData.LaserAudioComp == null || ProjectileLaserData.bDead)
		{
			return;
		}
		if (ListenerMgrData == null)
		{
			APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(Owner);
			if (firstLocalPlayerController != null)
			{
				ListenerMgrData = BGU_DataUtil.GetPlayerControlReadonlyData<IBPC_ListenerMgrData, BPC_ListenerMgrData>(firstLocalPlayerController);
			}
		}
		if (ListenerMgrData != null)
		{
			FVector listenerPos = ListenerMgrData.GetListenerPos();
			FVector closestPos = GetClosestPos(LaserStartPos, LaserEndPos, listenerPos);
			ProjectileLaserData.LaserAudioComp.SetWorldLocation(closestPos, bSweep: false, out var _, bTeleport: false);
			if (ProjectileLaserData.bDrawDebug)
			{
				USystemLibrary.DrawDebugSphere(Owner, closestPos, 50f, 12, FLinearColor.Green, 0.5f, 1f);
			}
		}
	}

	public FVector GetClosestPos(FVector Pos_LaserStart, FVector Pos_LaserEnd, FVector Pos_Listener)
	{
		FVector fVector = Pos_LaserEnd - Pos_LaserStart;
		FVector a = Pos_Listener - Pos_LaserStart;
		float num = fVector.X * fVector.X + fVector.Y * fVector.Y + fVector.Z * fVector.Z;
		if (num <= 1f)
		{
			return Pos_LaserStart;
		}
		float num2 = FVector.DotProduct(a, fVector) / num;
		if (num2 < 0f)
		{
			return Pos_LaserStart;
		}
		if (num2 > 1f)
		{
			return Pos_LaserEnd;
		}
		return Pos_LaserStart + fVector * num2;
	}

	public void UpdateHitSceneItemAudio()
	{
		if (ProjectileLaserData.AkEvent_LaserHitItem == null || ProjectileLaserData.bDead)
		{
			return;
		}
		if (ProjectileLaserData.bHasHitSceneItem && ProjectileLaserData.HitItemAudioComp == null)
		{
			UAkComponent AkComp;
			int num = PostAKEvent(ProjectileLaserData.AkEvent_LaserHitItem, out AkComp);
			if (num > 0)
			{
				ProjectileLaserData.PlayingID_LaserHitItem = num;
				ProjectileLaserData.HitItemAudioComp = AkComp;
			}
		}
		if (!(ProjectileLaserData.HitItemAudioComp != null))
		{
			return;
		}
		if (ProjectileLaserData.PlayingID_LaserHitItem > 0 && !ProjectileLaserData.bHasHitSceneItem)
		{
			FadeOutAudio_HitItem();
		}
		else if (ProjectileLaserData.PlayingID_LaserHitItem <= 0 && ProjectileLaserData.bHasHitSceneItem)
		{
			ProjectileLaserData.PlayingID_LaserHitItem = ProjectileLaserData.HitItemAudioComp.PostAkEvent(ProjectileLaserData.AkEvent_LaserHitItem, 0, null, "");
		}
		if (ProjectileLaserData.PlayingID_LaserHitItem > 0)
		{
			ProjectileLaserData.HitItemAudioComp.SetWorldLocation(ProjectileLaserData.LastLaserEnd, bSweep: false, out var _, bTeleport: false);
			if (ProjectileLaserData.bDrawDebug)
			{
				USystemLibrary.DrawDebugSphere(Owner, ProjectileLaserData.LastLaserEnd, 25f, 12, FLinearColor.Blue, 0.5f, 1f);
			}
		}
	}

	private void FadeOutAudio_HitItem()
	{
		if (ProjectileLaserData.PlayingID_LaserHitItem > 0)
		{
			UBGUFunctionLibAK.BGUAKStopPlayingID(ProjectileLaserData.PlayingID_LaserHitItem, 200, 4);
			ProjectileLaserData.PlayingID_LaserHitItem = 0;
		}
	}

	private void OnProjectileDead(EBGUBulletDestroyReason Reason)
	{
		ProjectileLaserData.bDead = true;
		if (ProjectileLaserData.PlayingID_LaserAudio > 0)
		{
			UBGUFunctionLibAK.BGUAKStopPlayingID(ProjectileLaserData.PlayingID_LaserAudio, ProjectileLaserData.FadeOut_AkEvent_LaserEnd, 4);
		}
		ProjectileLaserData.LaserAudioComp = null;
		FadeOutAudio_HitItem();
	}
}
