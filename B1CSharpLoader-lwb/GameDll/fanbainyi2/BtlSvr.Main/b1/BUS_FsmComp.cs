using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_FsmComp : UActorCompBaseCS
{
	private IBUC_TickRateData TickRateData;

	private BUC_FsmData FsmData { get; set; }

	private IBUC_FollowPartnerData FollowPartnerData { get; set; }

	public override void OnAttach()
	{
		base.OnAttach();
		FsmData = RequireWritableData<BUC_FsmData>();
		TickRateData = RequireReadOnlyData<IBUC_TickRateData, BUC_TickRateData>();
		FollowPartnerData = RequireReadOnlyData<IBUC_FollowPartnerData, b1.BUC_FollowPartnerData>();
		base.BUSEventCollection.Evt_ResetActorStatusPre += new Del_Void_ResetActorReason(OnResetActorStatusPre);
		base.BUSEventCollection.Evt_TriggerFsmEvent += new Del_Void_GameplayTag(OnTriggerFsmEvent);
		base.BUSEventCollection.Evt_FSMEventTrigger += new Del_Void_FsmEvent(OnFsmEventTrigger);
		base.BUSEventCollection.Evt_AIPauseFsm += new Del_Void_Bool(OnAIPauseFsm);
		base.BUSEventCollection.Evt_AIPauseFsmInstance += new Del_Void_Bool(OnAIPauseFsmInstance);
	}

	public override void PreBeginPlay()
	{
		FsmData.RelationActorName = Owner.GetPathName();
		FsmData.bFsmPaused = false;
		FsmData.bFsmInstancePaused = false;
		FsmData.Instances.Clear();
		foreach (string templatePath in FsmData.TemplatePaths)
		{
			FsmInstance fsmInstance = FsmInstance.Create(templatePath, Owner);
			if (fsmInstance != null)
			{
				FsmData.Instances.Add(fsmInstance);
				fsmInstance.Start();
			}
		}
		FsmInstance fsmInstance2 = FsmInstance.Create(FsmData.PhaseTemplatePath, Owner);
		if (fsmInstance2 != null)
		{
			fsmInstance2.MarkAsPhaseInstance(IsRoot: true);
			FsmData.Instances.Add(fsmInstance2);
			fsmInstance2.Start();
		}
	}

	public override int GetTickGroupMask()
	{
		return 128;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		bool bFsmPaused = FsmData.bFsmPaused;
		if (!FsmData.bFsmInstancePaused)
		{
			FsmData.bUpdatingCurrentStates = true;
			UpdateForFsmInstance(DeltaTime, bFsmPaused);
			FsmData.bUpdatingCurrentStates = false;
		}
		if (TickRateData.CanTickFor200msInterval(out var AccumulatedDeltaTime, out var _, out var _, out var _, out var _) && !bFsmPaused)
		{
			base.BUSEventCollection.Evt_UpdateFsmSolver.Invoke(AccumulatedDeltaTime);
			if (FollowPartnerData != null && FollowPartnerData.CanTickIdleDisp())
			{
				base.BUSEventCollection.Evt_UpdateFollowPartnerIdleDisp.Invoke(AccumulatedDeltaTime);
			}
		}
		base.BUSEventCollection.Evt_UpdateCBG.Invoke(DeltaTime);
	}

	private void UpdateForFsmInstance(float DeltaTime, bool bOnlyTickPhaseComp)
	{
		for (int i = 0; i < FsmData.Instances.Count; i++)
		{
			FsmInstance fsmInstance = FsmData.Instances[i];
			if (!bOnlyTickPhaseComp)
			{
				fsmInstance.OnTick(DeltaTime);
			}
			else if (fsmInstance.PhaseComp != null)
			{
				fsmInstance.OnTick(DeltaTime);
			}
		}
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		for (int i = 0; i < FsmData.Instances.Count; i++)
		{
			FsmData.Instances[i].Shutdown();
		}
		base.OnEndPlay(EndPlayReason);
	}

	private void OnTriggerFsmEvent(FGameplayTag EventTag)
	{
		if (FsmData.bFsmInstancePaused || !UGameplayTagLibrary.MatchesTag(EventTag, BGW_FlowUtils.NormalAIFsmEventTag.Validation, bExactMatch: false))
		{
			return;
		}
		for (int i = 0; i < FsmData.Instances.Count; i++)
		{
			if (FsmData.Instances[i].PhaseComp == null)
			{
				FsmData.Instances[i].OnEvent(EventTag);
			}
		}
	}

	private void OnFsmEventTrigger(EBGUFSMEventName EventId)
	{
		if (!FsmData.bFsmInstancePaused)
		{
			FGameplayTag fGameplayTag;
			switch (EventId)
			{
			default:
				return;
			case EBGUFSMEventName.FSM_EVENT_LIFE_STANDBY:
				fGameplayTag = BGW_FlowUtils.NormalAIFsmEventTag.LifeTimeStandby;
				break;
			case EBGUFSMEventName.FSM_EVENT_LIFE_HASTARGET:
				fGameplayTag = BGW_FlowUtils.NormalAIFsmEventTag.LifeTimeHasTarget;
				break;
			case EBGUFSMEventName.FSM_EVENT_LIFE_GOHOME:
				fGameplayTag = BGW_FlowUtils.NormalAIFsmEventTag.LifeTimeGoHome;
				break;
			case EBGUFSMEventName.FSM_EVENT_LIFE_DIE:
				fGameplayTag = BGW_FlowUtils.NormalAIFsmEventTag.LifeTimeDie;
				break;
			case EBGUFSMEventName.FSM_EVENT_BATTLE_BEHIT:
				fGameplayTag = BGW_FlowUtils.NormalAIFsmEventTag.AIBattleBeHit;
				break;
			case EBGUFSMEventName.FSM_EVENT_BATTLE_ATTACK:
				fGameplayTag = BGW_FlowUtils.NormalAIFsmEventTag.AIBattleAttack;
				break;
			case EBGUFSMEventName.FSM_EVENT_BATTLE_WANDER:
				fGameplayTag = BGW_FlowUtils.NormalAIFsmEventTag.AIBattleWander;
				break;
			case EBGUFSMEventName.FSM_EVENT_BATTLE_STALEMATE:
				fGameplayTag = BGW_FlowUtils.NormalAIFsmEventTag.LifeTimeIntoStalemate;
				break;
			case EBGUFSMEventName.FSM_EVENT_LIFE_GAZEANDSURROUND:
				fGameplayTag = BGW_FlowUtils.NormalAIFsmEventTag.LifeTimeGazeAndSurround;
				break;
			case EBGUFSMEventName.FSM_EVENT_LIFE_REVIVE:
			case EBGUFSMEventName.FSM_EVENT_NONCOMBAT_WARNNING:
			case EBGUFSMEventName.FSM_EVENT_NONCOMBAT_IDLE:
			case EBGUFSMEventName.FSM_EVENT_LIFE_ARRIVEHOME:
				return;
			}
			if (GameplayTagExtension.IsValid(fGameplayTag))
			{
				OnTriggerFsmEvent(fGameplayTag);
			}
		}
	}

	private void OnAIPauseFsm(bool IsPause)
	{
		FsmData.bFsmPaused = IsPause;
	}

	private void OnAIPauseFsmInstance(bool IsPause)
	{
		FsmData.bFsmInstancePaused = IsPause;
		if (FsmData.bFsmInstancePaused)
		{
			for (int i = 0; i < FsmData.Instances.Count; i++)
			{
				FsmData.Instances[i].OnClearCacheEvent();
			}
		}
	}

	private void OnResetActorStatusPre(EResetActorReason ResetReason)
	{
		foreach (FsmInstance instance in FsmData.Instances)
		{
			instance.OnEvent(BGW_FlowUtils.NormalAIFsmEventTag.CommonReset);
			instance.PhaseComp?.OnResetActorStatusPre(ResetReason);
		}
	}
}
