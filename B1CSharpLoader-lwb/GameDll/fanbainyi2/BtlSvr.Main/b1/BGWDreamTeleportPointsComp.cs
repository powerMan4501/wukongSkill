using System;
using b1.BGW;
using b1.EventDelDefine;
using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDreamTeleportPointsComp")]
public class BGWDreamTeleportPointsComp : GameInstanceSystemBaseUObj
{
	private BIC_DreamTeleportData DreamTeleportData;

	private BGW_EventCollection EventCollection;

	private IBIC_LevelData LevelData;

	private BIC_TeleportStateData TeleportStateData;

	private static bool OnAfterTeleportMontageEnded_IsValid;

	private static IntPtr OnAfterTeleportMontageEnded_FunctionAddress;

	private static int OnAfterTeleportMontageEnded_ParamsSize;

	private static bool OnBeforeTeleportMontageEnded_IsValid;

	private static IntPtr OnBeforeTeleportMontageEnded_FunctionAddress;

	private static int OnBeforeTeleportMontageEnded_ParamsSize;

	public override void OnAttach()
	{
		LevelData = RequireReadonlyGameInstanceData<IBIC_LevelData, BIC_LevelData>();
		DreamTeleportData = RequireWritableGameInstanceData<BIC_DreamTeleportData>();
		TeleportStateData = RequireWritableGameInstanceData<BIC_TeleportStateData>();
		EventCollection = BGW_EventCollection.Get(this);
		if (EventCollection != null)
		{
			BGW_EventCollection eventCollection = EventCollection;
			eventCollection.Evt_RequestDreamTeleport = (Del_Void_DreamTeleport)Delegate.Combine(eventCollection.Evt_RequestDreamTeleport, new Del_Void_DreamTeleport(OnRequestDreamTeleport));
			BGW_EventCollection eventCollection2 = EventCollection;
			eventCollection2.Evt_OpenLevelFinished = (Del_Void)Delegate.Combine(eventCollection2.Evt_OpenLevelFinished, new Del_Void(OnOpenLevelFinished));
		}
	}

	private void OnRequestDreamTeleport(FDreamTeleportInfo InDreamTeleportInfo)
	{
		LogInfo("Request dream teleport");
		DreamTeleportData.DreamTeleportCache = InDreamTeleportInfo;
		if (!string.IsNullOrEmpty(DreamTeleportData.DreamTeleportCache.BeforeTeleportMontagePath))
		{
			ACharacter playerCharacter = UGameplayStatics.GetPlayerCharacter(this, 0);
			if (playerCharacter != null && playerCharacter.Mesh.GetAnimInstance() != null)
			{
				UAnimMontage uAnimMontage = BGW_PreloadAssetMgr.Get(this).TryGetCachedResourceObj<UAnimMontage>(DreamTeleportData.DreamTeleportCache.BeforeTeleportMontagePath, ELoadResourceType.SyncLoadAndCache);
				if (uAnimMontage != null)
				{
					LogInfo("Try to play before teleport montage: " + DreamTeleportData.DreamTeleportCache.BeforeTeleportMontagePath);
					float num = BGUFuncLibAnim.BGUActorTryPlayMontage(playerCharacter, uAnimMontage, FName.None);
					(FTimerManager.PIEWorld ?? FTimerManager.GameInstance).SetTimer(time: Math.Max(0.5f, num - 0.5f), obj: this, functionName: B1GlobalFNames.OnBeforeTeleportMontageEnded, looping: false, firstDelay: -1f);
					return;
				}
			}
		}
		OnBeforeTeleportMontageEnded();
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BGWDreamTeleportPointsComp:OnBeforeTeleportMontageEnded")]
	public void OnBeforeTeleportMontageEnded()
	{
		ACharacter playerCharacter = UGameplayStatics.GetPlayerCharacter(this, 0);
		if (EventCollection != null)
		{
			if (playerCharacter != null && DreamTeleportData.DreamTeleportCache.bDropTeleportPoint)
			{
				FTeleportInfo fTeleportInfo = new FTeleportInfo();
				fTeleportInfo.TeleportID = new FName(DreamTeleportData.DreamTeleportCache.DroppedTeleportPointId);
				fTeleportInfo.bUseTeleportRotation = true;
				fTeleportInfo.Location = playerCharacter.GetActorLocation();
				fTeleportInfo.Rotation = playerCharacter.GetActorRotation();
				fTeleportInfo.bOverrideLevelStreamingVolume = false;
				fTeleportInfo.bEnsureRequireLevel = true;
				fTeleportInfo.IsAsyncLoading = true;
				foreach (ULevelStreaming item in UBGWFunctionLibrary.BGWGetAllStreamingLevels(playerCharacter))
				{
					if (item.IsLevelLoaded())
					{
						fTeleportInfo.RequireLevelNames.Add(new FName(UBGWFunctionLibrary.GetLevelStreamingAssetName(item)));
					}
				}
				LogInfo($"Teleport Info:\n{fTeleportInfo}");
				EventCollection.Evt_RegisterTeleport(fTeleportInfo, bNeedSave: true);
			}
			OnDreamTeleport();
		}
		else
		{
			OnDreamTeleportFinished();
		}
	}

	private void OnDreamTeleport()
	{
		ACharacter playerCharacter = UBGUFunctionLibrary.GetPlayerCharacter(this);
		DreamTeleportData.bDreamTeleportWaitOpenLevelFinish = true;
		BGW_EventCollection eventCollection = EventCollection;
		eventCollection.Evt_LoadingBeginFadeAway = (Del_Void)Delegate.Combine(eventCollection.Evt_LoadingBeginFadeAway, new Del_Void(OnDreamTeleportFinished));
		if (DreamTeleportData.DreamTeleportCache.TargetLevelID > 0 || !DreamTeleportData.DreamTeleportCache.bTeleportToOtherLevel)
		{
			if (GSEUtil.Ensure(DreamTeleportData.DreamTeleportCache.bTeleportToOtherLevel || (!DreamTeleportData.DreamTeleportCache.bTeleportToOtherLevel && !string.IsNullOrEmpty(DreamTeleportData.DreamTeleportCache.TeleportName)), $"梦境传送不符合规范：bTeleportToOtherLevel for {DreamTeleportData.DreamTeleportCache.bTeleportToOtherLevel}," + "TeleportName for " + DreamTeleportData.DreamTeleportCache.TeleportName))
			{
				int num = (DreamTeleportData.DreamTeleportCache.bTeleportToOtherLevel ? DreamTeleportData.DreamTeleportCache.TargetLevelID : BGUFuncLibMap.GetCurLevelId(this));
				LogInfo($"Target level id: {num} and teleport name: {DreamTeleportData.DreamTeleportCache.TeleportName}");
				BPS_EventCollectionCS.GetLocal(playerCharacter).Evt_BPS_TeleportTo.Invoke(ETeleportTypeV2.Dream, new TeleportParam_Dream
				{
					LevelId = num,
					TeleportPointName = new FName(DreamTeleportData.DreamTeleportCache.TeleportName),
					RebirthPointId = DreamTeleportData.DreamTeleportCache.TargetRebirthPointId,
					LoadingScreenType = DreamTeleportData.DreamTeleportCache.LoadingScreenType
				}, EPlayerTeleportReason.Dream);
			}
		}
		else
		{
			FUStRebirthPointDesc rebirthPointDesc = BGW_GameDB.GetRebirthPointDesc(DreamTeleportData.DreamTeleportCache.TargetRebirthPointId);
			if (GSEUtil.Ensure(rebirthPointDesc != null, $"目标复活点ID未在表中，请查看传送节点！目标复活点：{DreamTeleportData.DreamTeleportCache.TargetRebirthPointId}"))
			{
				LogInfo($"Target level id: {rebirthPointDesc.MapID} and target rebirth point id: {DreamTeleportData.DreamTeleportCache.TargetRebirthPointId}");
				BPS_EventCollectionCS.GetLocal(playerCharacter).Evt_BPS_TeleportTo.Invoke(ETeleportTypeV2.Dream, new TeleportParam_Dream
				{
					LevelId = rebirthPointDesc.MapID,
					TeleportPointName = new FName(DreamTeleportData.DreamTeleportCache.TeleportName),
					RebirthPointId = DreamTeleportData.DreamTeleportCache.TargetRebirthPointId,
					LoadingScreenType = DreamTeleportData.DreamTeleportCache.LoadingScreenType
				}, EPlayerTeleportReason.Dream);
			}
		}
	}

	private void OnOpenLevelFinished()
	{
	}

	private void OnDreamTeleportFinished()
	{
		LogInfo("Dream teleport finished");
		if (EventCollection != null)
		{
			BGW_EventCollection eventCollection = EventCollection;
			eventCollection.Evt_LoadingBeginFadeAway = (Del_Void)Delegate.Remove(eventCollection.Evt_LoadingBeginFadeAway, new Del_Void(OnDreamTeleportFinished));
			PlayAfterDreamTeleportMontage();
		}
	}

	private void PlayAfterDreamTeleportMontage()
	{
		if (!string.IsNullOrEmpty(DreamTeleportData.DreamTeleportCache.AfterTeleportMontagePath))
		{
			ACharacter playerCharacter = UGameplayStatics.GetPlayerCharacter(this, 0);
			if (playerCharacter != null && playerCharacter.Mesh.GetAnimInstance() != null)
			{
				UAnimMontage uAnimMontage = BGW_PreloadAssetMgr.Get(this).TryGetCachedResourceObj<UAnimMontage>(DreamTeleportData.DreamTeleportCache.AfterTeleportMontagePath, ELoadResourceType.SyncLoadAndCache);
				if (uAnimMontage != null)
				{
					LogInfo("Try to play after teleport montage: " + DreamTeleportData.DreamTeleportCache.AfterTeleportMontagePath);
					float num = BGUFuncLibAnim.BGUActorTryPlayMontage(playerCharacter, uAnimMontage, FName.None);
					(FTimerManager.PIEWorld ?? FTimerManager.GameInstance).SetTimer(time: Math.Max(0.5f, num - 0.5f), obj: this, functionName: B1GlobalFNames.OnAfterTeleportMontageEnded, looping: false, firstDelay: -1f);
					return;
				}
			}
		}
		OnAfterTeleportMontageEnded();
	}

	private void LogInfo(string Msg)
	{
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BGWDreamTeleportPointsComp:OnAfterTeleportMontageEnded")]
	public void OnAfterTeleportMontageEnded()
	{
		if (DreamTeleportData.DreamTeleportCache != null)
		{
			_ = DreamTeleportData.DreamTeleportCache.bSaveArchiveAfterTeleport;
			DreamTeleportData.DreamTeleportCache.BeforeTeleportMontagePath = null;
			DreamTeleportData.DreamTeleportCache.AfterTeleportMontagePath = null;
			DreamTeleportData.DreamTeleportCache = null;
			EventCollection.Evt_DreamTeleportFinished();
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BGWDreamTeleportPointsComp:OnAfterTeleportMontageEnded")]
	private static void OnAfterTeleportMontageEnded__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGWDreamTeleportPointsComp bGWDreamTeleportPointsComp = GCHelper.Find<BGWDreamTeleportPointsComp>(obj);
		bGWDreamTeleportPointsComp.OnAfterTeleportMontageEnded();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGWDreamTeleportPointsComp:OnBeforeTeleportMontageEnded")]
	private static void OnBeforeTeleportMontageEnded__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGWDreamTeleportPointsComp bGWDreamTeleportPointsComp = GCHelper.Find<BGWDreamTeleportPointsComp>(obj);
		bGWDreamTeleportPointsComp.OnBeforeTeleportMontageEnded();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BGWDreamTeleportPointsComp");
		OnAfterTeleportMontageEnded_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnAfterTeleportMontageEnded");
		OnAfterTeleportMontageEnded_ParamsSize = NativeReflection.GetFunctionParamsSize(OnAfterTeleportMontageEnded_FunctionAddress);
		OnAfterTeleportMontageEnded_IsValid = OnAfterTeleportMontageEnded_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGWDreamTeleportPointsComp:OnAfterTeleportMontageEnded", OnAfterTeleportMontageEnded_IsValid);
		OnBeforeTeleportMontageEnded_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnBeforeTeleportMontageEnded");
		OnBeforeTeleportMontageEnded_ParamsSize = NativeReflection.GetFunctionParamsSize(OnBeforeTeleportMontageEnded_FunctionAddress);
		OnBeforeTeleportMontageEnded_IsValid = OnBeforeTeleportMontageEnded_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGWDreamTeleportPointsComp:OnBeforeTeleportMontageEnded", OnBeforeTeleportMontageEnded_IsValid);
	}

	static BGWDreamTeleportPointsComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDreamTeleportPointsComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDreamTeleportPointsComp));
	}
}
