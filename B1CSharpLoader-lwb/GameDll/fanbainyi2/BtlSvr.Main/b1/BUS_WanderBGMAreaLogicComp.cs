using System.Collections.Generic;
using b1.EventDelDefine;
using BtlShare;
using UnrealEngine.Engine;

namespace b1;

public class BUS_WanderBGMAreaLogicComp : UActorCompBaseCS
{
	private b1.BUC_BGMAreaData BGMAreaData;

	private IBGC_UnrealGameplayData UnrealGameplayData;

	private IBGC_GameBgmMgrData GameBgmMgrData;

	private IBIC_GlobalActorData GlobalActorData;

	private BUC_IntervalTriggerData IntervalTriggerData;

	public override void OnAttach()
	{
		BGMAreaData = RequireWritableData<b1.BUC_BGMAreaData>();
		UnrealGameplayData = RequireReadOnlyGameStateData<IBGC_UnrealGameplayData, BGC_UnrealGameplayData>();
		GameBgmMgrData = RequireReadOnlyGameStateData<IBGC_GameBgmMgrData, BGC_GameBgmMgrData>();
		GlobalActorData = RequireReadonlyGameInstanceData<IBIC_GlobalActorData, BIC_GlobalActorData>();
		IntervalTriggerData = RequireWritableData<BUC_IntervalTriggerData>();
		base.BUSEventCollection.Evt_OnActorEnterArea += new Del_Void_Actor(OnActorEnter);
		base.BUSEventCollection.Evt_OnActorLeaveArea += new Del_Void_Actor(OnActorLeave);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (GameBgmMgrData.HasInit && BGMAreaData.IsPlayerEnteredVolume)
		{
			CheckUpdateBgmInfo();
		}
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		StopBgm();
	}

	private bool CheckUnitAlive(List<FGsActorGuidReference> ObserveUnits, EBGMVolumeConditionSusCountType ConditionSusCountType)
	{
		if (ObserveUnits == null)
		{
			return false;
		}
		foreach (FGsActorGuidReference ObserveUnit in ObserveUnits)
		{
			if (CheckIsUnitAlive(ObserveUnit.ActorGuid))
			{
				switch (ConditionSusCountType)
				{
				case EBGMVolumeConditionSusCountType.Once:
					return true;
				}
			}
			else if (ConditionSusCountType != EBGMVolumeConditionSusCountType.Once && ConditionSusCountType == EBGMVolumeConditionSusCountType.All)
			{
				return false;
			}
		}
		return ConditionSusCountType switch
		{
			EBGMVolumeConditionSusCountType.Once => false, 
			EBGMVolumeConditionSusCountType.All => true, 
			_ => false, 
		};
		bool CheckIsUnitAlive(string UnitGuid)
		{
			if (!GlobalActorData.GetActorAliveState(UnitGuid))
			{
				return false;
			}
			if (GlobalActorData.GetActorResetType(UnitGuid, out var ResetType) && ResetType == EBGUResetType.Destroy)
			{
				return false;
			}
			return true;
		}
	}

	private AActor GetRootMaster(AActor Actor)
	{
		IBUC_MasterData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_MasterData, BUC_MasterData>(Actor);
		if (readOnlyData == null)
		{
			return null;
		}
		AActor masterActor = readOnlyData.GetMasterActor();
		while (Actor != masterActor)
		{
			Actor = masterActor;
			readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_MasterData, BUC_MasterData>(Actor);
			if (readOnlyData == null)
			{
				return null;
			}
			masterActor = readOnlyData.GetMasterActor();
		}
		return masterActor;
	}

	private bool CheckUnitIsInBattle(AActor Unit)
	{
		if (BGUFunctionLibraryCS.BGUIsUnitDead(Unit))
		{
			return false;
		}
		AActor aActor = ((UnrealGameplayData == null) ? UGSE_EngineFuncLib.GetFirstLocalPlayerController(Owner)?.GetControlledPawn() : UnrealGameplayData.GetFirstLocalPlayerController()?.GetControlledPawn());
		if (aActor == null)
		{
			return false;
		}
		IBUC_TargetInfoData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(Unit);
		IBUC_UnitHatredData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_UnitHatredData, BUC_UnitHatredData>(Unit);
		if (readOnlyData == null || unPersistentReadOnlyData == null)
		{
			return false;
		}
		bool flag = false;
		AActor aActor2 = ECSExtension.ToActor(readOnlyData.GetTargetInfo().LockTargetEntity);
		if (aActor2 != null && GetRootMaster(aActor2) != aActor)
		{
			flag = true;
		}
		if (!flag)
		{
			AActor aActor3 = ECSExtension.ToActor(unPersistentReadOnlyData.GetHatredTargetInfo(aActor).HatredTargetEntity);
			if (aActor3 != null && GetRootMaster(aActor3) != aActor)
			{
				flag = true;
			}
		}
		return flag;
	}

	private bool CheckUnitIsInBattle(List<FGsActorGuidReference> ObserveUnits, EBGMVolumeConditionSusCountType ConditionSusCountType)
	{
		if (ObserveUnits == null)
		{
			return false;
		}
		foreach (FGsActorGuidReference ObserveUnit in ObserveUnits)
		{
			if (CheckUnitIsInBattle(BGU_DataUtil.GetActorByGuid(Owner, ObserveUnit.ActorGuid)))
			{
				switch (ConditionSusCountType)
				{
				case EBGMVolumeConditionSusCountType.Once:
					return true;
				}
			}
			else if (ConditionSusCountType != EBGMVolumeConditionSusCountType.Once && ConditionSusCountType == EBGMVolumeConditionSusCountType.All)
			{
				return false;
			}
		}
		return ConditionSusCountType switch
		{
			EBGMVolumeConditionSusCountType.Once => false, 
			EBGMVolumeConditionSusCountType.All => true, 
			_ => false, 
		};
	}

	private bool CheckVolumeConditionSucceed(b1.BGMVolumeConditionGroupInfo ConditionGroupInfo)
	{
		foreach (b1.BGMVolumeConditionInfo condition in ConditionGroupInfo.Conditions)
		{
			bool flag = true;
			switch (condition.Condition)
			{
			case EBGMVolumeConditionType.UnitAlive:
				flag = CheckUnitAlive(condition.Actors, condition.ConditionSusCountType);
				break;
			case EBGMVolumeConditionType.UnitInBattle:
				flag = CheckUnitIsInBattle(condition.Actors, condition.ConditionSusCountType);
				break;
			case EBGMVolumeConditionType.IntervalTriggerActive:
				flag = IntervalTriggerData != null && IntervalTriggerData.bIsActive;
				break;
			}
			if (!(condition.InverseCondition ^ flag))
			{
				return false;
			}
		}
		return true;
	}

	private bool CheckVolumeConditionSucceed(List<b1.BGMVolumeConditionGroupInfo> ConditionGroups)
	{
		foreach (b1.BGMVolumeConditionGroupInfo ConditionGroup in ConditionGroups)
		{
			if (CheckVolumeConditionSucceed(ConditionGroup))
			{
				return true;
			}
		}
		return false;
	}

	private int GetCurrentVolumeInfoIndex()
	{
		if (BGMAreaData.VolumeConditionConfigInfos == null)
		{
			return -1;
		}
		for (int i = 0; i < BGMAreaData.VolumeConditionConfigInfos.Count; i++)
		{
			b1.BGMVolumeConditionConfigInfo bGMVolumeConditionConfigInfo = BGMAreaData.VolumeConditionConfigInfos[i];
			if (CheckVolumeConditionSucceed(bGMVolumeConditionConfigInfo.ConditionGroups))
			{
				return i;
			}
		}
		return -1;
	}

	private BGMVolumeInfo GetVolumeInfoByIndex(int VolumeInfoIndex)
	{
		if (VolumeInfoIndex < 0 || BGMAreaData.VolumeConditionConfigInfos == null || VolumeInfoIndex >= BGMAreaData.VolumeConditionConfigInfos.Count)
		{
			return new BGMVolumeInfo(BGMAreaData.AkEventBegin, BGMAreaData.AkEventStop, BGMAreaData.VolumeBGMConfigDA, BGMAreaData.VolumeGroupConfig);
		}
		return BGMAreaData.VolumeConditionConfigInfos[VolumeInfoIndex].GetVolumeInfo();
	}

	public void OnActorEnter(AActor OtherActor)
	{
		AActor aActor = ((UnrealGameplayData == null) ? UGSE_EngineFuncLib.GetFirstLocalPlayerController(Owner)?.GetControlledPawn() : UnrealGameplayData.GetFirstLocalPlayerController()?.GetControlledPawn());
		if (OtherActor == aActor)
		{
			PlayBgm();
			BGMAreaData.IsPlayerEnteredVolume = true;
			SetCanTick(Val: true);
		}
	}

	public void OnActorLeave(AActor OtherActor)
	{
		AActor aActor = ((UnrealGameplayData == null) ? UGSE_EngineFuncLib.GetFirstLocalPlayerController(Owner)?.GetControlledPawn() : UnrealGameplayData.GetFirstLocalPlayerController()?.GetControlledPawn());
		if (OtherActor == aActor)
		{
			StopBgm();
			BGMAreaData.IsPlayerEnteredVolume = false;
			SetCanTick(Val: false);
		}
	}

	private void PlayBgm()
	{
		AActor owner = Owner;
		BGMAreaData.CurrentVolumeInfoIndex = GetCurrentVolumeInfoIndex();
		BGMVolumeInfo volumeInfoByIndex = GetVolumeInfoByIndex(BGMAreaData.CurrentVolumeInfoIndex);
		base.BGSEventCollection?.Evt_BGS_PlayerEnterBgmVolume.Invoke(owner, volumeInfoByIndex);
	}

	private void CheckUpdateBgmInfo()
	{
		int currentVolumeInfoIndex = GetCurrentVolumeInfoIndex();
		if (BGMAreaData.CurrentVolumeInfoIndex != currentVolumeInfoIndex)
		{
			AActor owner = Owner;
			if (owner != null)
			{
				BGMAreaData.CurrentVolumeInfoIndex = currentVolumeInfoIndex;
				BGMVolumeInfo volumeInfoByIndex = GetVolumeInfoByIndex(BGMAreaData.CurrentVolumeInfoIndex);
				base.BGSEventCollection?.Evt_BGS_BGMVolumeInfoUpdate.Invoke(owner, volumeInfoByIndex);
			}
		}
	}

	private void StopBgm()
	{
		if (base.BGSEventCollection != null && base.BGSEventCollection.HasBeginPlay)
		{
			base.BGSEventCollection.Evt_BGS_PlayerLeaveBgmVolume.Invoke(Owner);
		}
	}
}
