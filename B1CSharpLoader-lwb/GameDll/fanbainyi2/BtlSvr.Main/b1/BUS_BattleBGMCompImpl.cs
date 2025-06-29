using System.Collections.Generic;
using b1.EventDelDefine;
using b1.Plugins.AkAudio;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_BattleBGMCompImpl : UActorCompBaseCS
{
	private BUC_BattleBGMData BattleBGMData;

	private IBUC_TargetInfoData TargetInfoData;

	private IBUC_TickRateData TickRateData;

	private IBUC_UnitHatredData UnitHatredData;

	private IBUC_UnitStateData UnitStateData;

	private IBUC_AIData AIData;

	private IBGC_LocalPlayerSharedData LocalPlayerSharedData;

	private IBGC_GameBgmMgrData GameBgmMgrData;

	public override void OnAttach()
	{
		BattleBGMData = RequireWritableData<BUC_BattleBGMData>();
		TargetInfoData = RequireReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>();
		TickRateData = RequireReadOnlyData<IBUC_TickRateData, BUC_TickRateData>();
		UnitHatredData = RequireReadOnlyData<IBUC_UnitHatredData, BUC_UnitHatredData>();
		UnitStateData = RequireReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>();
		AIData = RequireReadOnlyData<IBUC_AIData, BUC_AIData>();
		LocalPlayerSharedData = RequireReadOnlyGameStateData<IBGC_LocalPlayerSharedData, BGC_LocalPlayerSharedData>();
		GameBgmMgrData = RequireReadOnlyGameStateData<IBGC_GameBgmMgrData, BGC_GameBgmMgrData>();
		base.BUSEventCollection.Evt_UnitTriggerDead += new Del_UnitTriggerDead(OnUnitTriggerDead);
		base.BUSEventCollection.Evt_ResetActorStatusAfterAll += new Del_Void_ResetActorReason(OnResetActorStatusAfterAll);
		base.BUSEventCollection.Evt_SetUnitBattleBGM += new Del_SetUnitBattleBGM(OnSetUnitBattleBGM);
	}

	public override void PreBeginPlay()
	{
		BattleBGMData.HasTriggerDead = false;
		BattleBGMData.HasPlayBGM = false;
		BattleBGMData.BGMPriority = GetUnitBGMPriority();
	}

	public override void LateBeginPlay()
	{
		BattleBGMData.OwnerEntity = ECSExtension.ToEntity(Owner);
		if (!AIData.IsAI)
		{
			SetCanTick(Val: false);
		}
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		if (base.BGSEventCollection != null && base.BGSEventCollection.HasBeginPlay)
		{
			base.BGSEventCollection.Evt_BGS_TryStopBattleBGM.Invoke(BattleBGMData.OwnerEntity);
		}
	}

	public override int GetTickGroupMask()
	{
		return 8;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (BattleBGMData.bDisableBattleBGM)
		{
			return;
		}
		if (BattleBGMData.BGMPriority == EBGMPriority.MonsterBattleBGM)
		{
			bool flag = true;
			if (!TickRateData.CanTickFor6000Distance())
			{
				TryStopBattleBGM();
				return;
			}
			float DifferenceTimeToLast1000ms;
			float DifferenceTimeToLast500ms;
			float DifferenceTimeToLast200ms;
			float DifferenceTimeToLast100ms;
			if (!TickRateData.CanTickFor3000Distance())
			{
				flag = TickRateData.CanTickFor500msInterval(out DeltaTime, out DifferenceTimeToLast1000ms, out DifferenceTimeToLast500ms, out DifferenceTimeToLast200ms, out DifferenceTimeToLast100ms);
			}
			else if (!TickRateData.CanTickFor1000Distance())
			{
				flag = TickRateData.CanTickFor100msInterval(out DeltaTime, out DifferenceTimeToLast100ms, out DifferenceTimeToLast200ms, out DifferenceTimeToLast500ms, out DifferenceTimeToLast1000ms);
			}
			if (!flag)
			{
				return;
			}
		}
		TickForHasPlayerTarget();
	}

	private void TickForHasPlayerTarget()
	{
		if (Owner == null || UnitStateData.HasState(EBGUUnitState.Dead) || BattleBGMData.HasTriggerDead)
		{
			return;
		}
		AActor firstLocalPlayerPawn = LocalPlayerSharedData.FirstLocalPlayerPawn;
		if (firstLocalPlayerPawn == null)
		{
			return;
		}
		bool flag = false;
		if (TargetInfoData.GetTargetInfo().LockTargetActor == firstLocalPlayerPawn)
		{
			flag = true;
		}
		if (!flag && UnitHatredData.GetHatredTargetInfo(firstLocalPlayerPawn).HatredTargetActor == firstLocalPlayerPawn)
		{
			flag = true;
		}
		bool flag2 = true;
		if (flag)
		{
			if (BattleBGMData.BGMPriority == EBGMPriority.MonsterBattleBGM && BattleBGMData.BGMStopDistance > 0)
			{
				FVector v = BGUFuncLibActorTransformCS.BGUGetActorLocation(firstLocalPlayerPawn);
				FVector v2 = BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner);
				if (FVector.Dist2D(v, v2) > (float)BattleBGMData.BGMStopDistance)
				{
					flag2 = false;
				}
			}
		}
		else
		{
			flag2 = false;
		}
		if (flag2)
		{
			TryPlayBattleBGM();
		}
		else
		{
			TryStopBattleBGM();
		}
	}

	private void TryPlayBattleBGM()
	{
		BattleBGMData.HasPlayBGM = true;
		if (!GameBgmMgrData.TryGetCurrentEntityBattleBgmWrap(BattleBGMData.OwnerEntity, out var BgmWrap) || (!BgmWrap.IsWrapFromDefaultConfig && !BgmWrap.IsWrapEventEqual(BattleBGMData.AkEventBegin, BattleBGMData.AkEventStop, BattleBGMData.ConditionStopEvents)))
		{
			base.BGSEventCollection?.Evt_BGS_TryPlayBattleBGM.Invoke(TryGetValidBGMWrap(BattleBGMData.BGMPriority));
		}
	}

	private void TryStopBattleBGM()
	{
		if (BattleBGMData.HasPlayBGM)
		{
			BattleBGMData.HasPlayBGM = false;
			base.BGSEventCollection?.Evt_BGS_TryStopBattleBGM.Invoke(BattleBGMData.OwnerEntity, EBGMStopCondition.LeaveBattle);
		}
	}

	private BGMWrap TryGetValidBGMWrap(EBGMPriority BGMPriority)
	{
		BGMWrap bGMWrap = new BGMWrap(BattleBGMData.OwnerEntity, BGMPriority, BattleBGMData.AkEventBegin, BattleBGMData.AkEventStop, BattleBGMData.ConditionStopEvents);
		if (!BGMWrap.IsValid(bGMWrap))
		{
			bGMWrap = GameBgmMgrData.GetRandomDefaultBGMWrap(BattleBGMData.OwnerEntity, BGMPriority);
		}
		return bGMWrap;
	}

	private EBGMPriority GetUnitBGMPriority()
	{
		FUStUnitBattleInfoExtendDesc unitBattleInfoExtendDesc = BGW_GameDB.GetUnitBattleInfoExtendDesc(GetFinalBattleInfoExtendID());
		if (unitBattleInfoExtendDesc != null)
		{
			if ((int)unitBattleInfoExtendDesc.QualityType >= 1 && (int)unitBattleInfoExtendDesc.QualityType <= 4)
			{
				return EBGMPriority.MonsterBattleBGM;
			}
			if ((int)unitBattleInfoExtendDesc.QualityType >= 5 && (int)unitBattleInfoExtendDesc.QualityType <= 6)
			{
				return EBGMPriority.EliteBattleBGM;
			}
			if ((int)unitBattleInfoExtendDesc.QualityType >= 7 && (int)unitBattleInfoExtendDesc.QualityType <= 8)
			{
				return EBGMPriority.BossBattleBGM;
			}
		}
		return EBGMPriority.WanderBGM;
	}

	private void OnResetActorStatusAfterAll(EResetActorReason ResetReason)
	{
		base.BGSEventCollection?.Evt_BGS_TryStopBattleBGM.Invoke(BattleBGMData.OwnerEntity, EBGMStopCondition.LeaveBattle);
	}

	private void OnUnitTriggerDead(AActor Attacker, EDeadReason DeadReason, int DmgID)
	{
		BattleBGMData.HasTriggerDead = true;
		if (BattleBGMData.HasPlayBGM)
		{
			BattleBGMData.HasPlayBGM = false;
			base.BGSEventCollection?.Evt_BGS_TryStopBattleBGM.Invoke(BattleBGMData.OwnerEntity);
		}
	}

	private void OnSetUnitBattleBGM(UAkAudioEvent AkEventBegin, UAkAudioEvent AkEventStop, float BGMEventStopTimer, Dictionary<EBGMStopCondition, BGMStopEventInfo> ConditionStopEvents)
	{
		BattleBGMData.AkEventBegin = AkEventBegin;
		BattleBGMData.AkEventStop = AkEventStop;
		BattleBGMData.BGMEventStopTimer = BGMEventStopTimer;
		BattleBGMData.ConditionStopEvents = ConditionStopEvents;
	}
}
