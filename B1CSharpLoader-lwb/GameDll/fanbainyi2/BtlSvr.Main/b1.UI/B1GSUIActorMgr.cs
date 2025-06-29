using System.Collections.Generic;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.UI;

public class B1GSUIActorMgr : GSUIActorMgr
{
	private AActor _curPlayerActor;

	private APlayerController _localPlayerController;

	private AActor CurPlayerActor
	{
		get
		{
			if (_curPlayerActor == null)
			{
				GetCurPlayerActor();
			}
			return _curPlayerActor;
		}
		set
		{
			_curPlayerActor = value;
		}
	}

	private APlayerController LocalPlayerController
	{
		get
		{
			if (_localPlayerController == null)
			{
				GetLocalPlayerController();
			}
			return _localPlayerController;
		}
		set
		{
			_localPlayerController = value;
		}
	}

	public B1GSUIActorMgr()
	{
		RegistGetActor(1, GetCurPlayerActor);
		RegistGetActor(2, GetCurLockTarget);
		RegistGetActor(3, GetEliteActor);
		RegistGetActor(4, GetBossActor);
		RegistGetActor(5, GetLocalPlayerState);
		RegistGetActor(6, GetLocalPlayerController);
		RegistGetActor(7, GetGameState);
		RegistGetActor(8, GetGameMode);
	}

	public override void Init(UObject WorldContext)
	{
		base.Init(WorldContext);
		UpdateCatchActor();
	}

	public static B1GSUIActorMgr Get(UObject Context)
	{
		return BGWGameInstanceCS.GetObject<B1GSUIActorMgr>(Context);
	}

	protected override List<GSBattleDataDStore> InitBattleData(AActor UnitActor)
	{
		List<GSBattleDataDStore> list = new List<GSBattleDataDStore>();
		if (UnitActor.IsNullOrDestroyed())
		{
			return list;
		}
		if (UnitActor is AGameState || UnitActor is AGameMode)
		{
			list.Add(new DS_IBGC_OnlineChallengeData(UnitActor));
			list.Add(new DS_IBGC_OnlineTeammateData(UnitActor));
			list.Add(new DS_IBGC_PlayerGuideData(UnitActor));
			list.Add(new DS_IBGC_GlobalBattleStateData(UnitActor));
		}
		else if (UnitActor is APlayerController || UnitActor is APlayerState)
		{
			list.Add(new DS_IBPC_TransData(UnitActor));
			list.Add(new DS_IBPC_PlayerTagData(UnitActor));
			list.Add(new DS_IBPC_PlayerInteractData(UnitActor));
			list.Add(new DS_IBPC_RebirthPointData(UnitActor));
			list.Add(new DS_IBPC_BattleMainInfoData(UnitActor));
			list.Add(new DS_IBPC_PlayerRoleData(UnitActor));
			list.Add(new DS_IBPC_RoleBaseData(UnitActor));
			list.Add(new DS_IBPC_MapSymbolData(UnitActor));
			list.Add(new DS_IBPC_GeoInfoData(UnitActor));
			list.Add(new DS_IBPC_MapAreaData(UnitActor));
		}
		else
		{
			list.Add(new DS_IBUC_AttrContainer(UnitActor));
			list.Add(new DS_IBUC_ChargeSkillData(UnitActor));
			list.Add(new DS_IBUC_UnitStateData(UnitActor));
			list.Add(new DS_IBUC_InteractData(UnitActor));
			list.Add(new DS_IBUC_SimpleStateData(UnitActor));
			list.Add(new DS_IBUC_SkillInstsData(UnitActor));
			list.Add(new DS_IBUC_ConfigInfoData(UnitActor));
			list.Add(new DS_IBUC_BuffData(UnitActor));
			list.Add(new DS_IBUC_TargetInfoData(UnitActor));
			list.Add(new DS_IBUC_BarSockData(UnitActor));
			list.Add(new DS_IBUC_FallDyingData(UnitActor));
			list.Add(new DS_IBUC_EquipFaBaoData(UnitActor));
			list.Add(new DS_IBUC_PlayerSpellConfData(UnitActor));
			list.Add(new DS_IBUC_BattleStateData(UnitActor));
			list.Add(new DS_IBUC_PotentialEnergyData(UnitActor));
			list.Add(new DS_IBUC_MagicSpellInfoData(UnitActor));
			list.Add(new DS_IBUC_UnitBarInfoData(UnitActor));
			list.Add(new DS_IBUC_AbnormalStateHandlers(UnitActor));
			list.Add(new DS_IBUC_AbnormalStateData(UnitActor));
			list.Add(new DS_IBUC_UIControlData(UnitActor));
			list.Add(new DS_IBUC_SealingSpellData(UnitActor));
			list.Add(new DS_IBUC_LifeSavingData(UnitActor));
			list.Add(new DS_IBUC_CloudMoveData(UnitActor));
			list.Add(new DS_IBUC_TransGuideData(UnitActor));
			list.Add(new DS_IBUC_QiTianDaShengData(UnitActor));
			list.Add(new DS_IBUC_PassiveSkillData(UnitActor));
		}
		return list;
	}

	public T GetBattleData<T>(B1ActorTag ActorTag, bool IsNeedUpdate = false) where T : class
	{
		return GetBattleData<T>((int)ActorTag, IsNeedUpdate);
	}

	public int GetActorResId(B1ActorTag ActorTag, bool IsNeedUpdate = false)
	{
		return GetActorResId((int)ActorTag, IsNeedUpdate);
	}

	private AActor GetCurPlayerActor()
	{
		APlayerController localPlayerController = GetLocalPlayerController();
		if (localPlayerController == null)
		{
			return null;
		}
		return CurPlayerActor = localPlayerController.GetControlledPawn();
	}

	private AActor GetCurLockTarget()
	{
		UnitLockTargetInfo unitLockTargetInfo = BGUFunctionLibraryCS.BGUGetTargetInfo(CurPlayerActor);
		if (unitLockTargetInfo.LockTargetActor != null && unitLockTargetInfo.LockTargetWayType == ELockTargetWayType.Manual)
		{
			return unitLockTargetInfo.LockTargetActor;
		}
		return null;
	}

	private AActor GetBossActor()
	{
		AActor aActor = BGUFunctionLibraryCS.BGUGetTarget(CurPlayerActor);
		if (aActor == null)
		{
			return null;
		}
		FUStUnitBattleInfoExtendDesc unitBattleInfoExtendDesc = BGW_GameDB.GetUnitBattleInfoExtendDesc(BGU_DataUtil.GetFinalBattleInfoExtendID(aActor));
		if (unitBattleInfoExtendDesc != null && unitBattleInfoExtendDesc.BloodBarType == EBGUBloodBarType.BossBar)
		{
			return aActor;
		}
		return null;
	}

	private AActor GetEliteActor()
	{
		AActor aActor = BGUFunctionLibraryCS.BGUGetTarget(CurPlayerActor);
		if (aActor == null)
		{
			return null;
		}
		FUStUnitBattleInfoExtendDesc unitBattleInfoExtendDesc = BGW_GameDB.GetUnitBattleInfoExtendDesc(BGU_DataUtil.GetFinalBattleInfoExtendID(aActor));
		if (unitBattleInfoExtendDesc != null && unitBattleInfoExtendDesc.BloodBarType == EBGUBloodBarType.EliteBar)
		{
			return aActor;
		}
		return null;
	}

	private APlayerState GetLocalPlayerState()
	{
		if (LocalPlayerController == null)
		{
			return null;
		}
		return LocalPlayerController.PlayerState;
	}

	private APlayerController GetLocalPlayerController()
	{
		return LocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext);
	}

	private AActor GetGameState()
	{
		return UGameplayStatics.GetGameState(WorldContext);
	}

	private AActor GetGameMode()
	{
		return UGameplayStatics.GetGameMode(WorldContext);
	}

	protected override void CleraEXData()
	{
	}

	public void Tick(float DeltaTime)
	{
		UpdateCatchActor();
	}

	public void UpdateCatchActor()
	{
		for (int i = 1; i < 9; i++)
		{
			UpdateActor(i);
		}
		UpdateEntityDataMap();
	}

	public override void OnPostLoadMap()
	{
		CurPlayerActor = null;
		LocalPlayerController = null;
	}
}
