using System;
using b1.EventDelDefine;
using UnrealEngine.Runtime;

namespace b1;

public class BossRushNodeInstance_Wait : PsmSubMachine_TemplateBase
{
	private class State_Idle : PsmSubMachineState
	{
		public override void OnEnterAction()
		{
			if (base.ParentSubMachine is BossRushNodeInstance_Wait bossRushNodeInstance_Wait)
			{
				bossRushNodeInstance_Wait.SetObjStateOnBeginning();
				bossRushNodeInstance_Wait.WaitBegin();
			}
		}
	}

	private class State_CountDown : PsmSubMachineState
	{
		public override void OnEnterAction()
		{
			if (base.ParentSubMachine is BossRushNodeInstance_Wait bossRushNodeInstance_Wait)
			{
				bossRushNodeInstance_Wait.CurrentTime = B1Global.GBossRushBattleReadyTime;
				bossRushNodeInstance_Wait.BGWEventCollection.Evt_SetGamePause(EPauseEvent.UIAndBattleInput, bPause: true);
			}
		}

		public override void OnTickAction(float InDeltaTime)
		{
			if (base.ParentSubMachine is BossRushNodeInstance_Wait bossRushNodeInstance_Wait)
			{
				bossRushNodeInstance_Wait.CurrentTime -= InDeltaTime;
				if (bossRushNodeInstance_Wait.CurrentTime <= 0f)
				{
					NotifySelf(PsmSubMachine.Next);
				}
			}
		}

		public override void OnExitAction()
		{
			if (base.ParentSubMachine is BossRushNodeInstance_Wait bossRushNodeInstance_Wait)
			{
				bossRushNodeInstance_Wait.BGWEventCollection.Evt_SetGamePause(EPauseEvent.UIAndBattleInput, bPause: false);
				bossRushNodeInstance_Wait.BGWEventCollection.Evt_BossRushBattleWaitFinished();
			}
		}

		public override void Shutdown()
		{
			if (base.ParentSubMachine is BossRushNodeInstance_Wait bossRushNodeInstance_Wait)
			{
				bossRushNodeInstance_Wait.BGWEventCollection.Evt_SetGamePause(EPauseEvent.UIAndBattleInput, bPause: false);
			}
		}
	}

	public override string NodeClass => B1CalliopeDef.BossRushNode.Wait;

	protected override string DefaultTerminatePinName => BGW_FlowUtils.PinName.Out.PlainName;

	private bool bWaiting { get; set; }

	private float CurrentTime { get; set; }

	protected override void InitialData(byte[] CustomDataBytes)
	{
		base.InitialData(CustomDataBytes);
		FGameplayTag state_Idle = BGW_FlowUtils.CommonProcessTag.State_Idle;
		FGameplayTag state_Countdown = BGW_FlowUtils.CommonProcessTag.State_Countdown;
		RegisterStateWithClass(state_Idle, typeof(State_Idle));
		RegisterStateWithClass(state_Countdown, typeof(State_CountDown));
		RegisterInitialTransition(state_Idle);
		RegisterStateTransition(state_Idle, PsmSubMachine.Next, state_Countdown);
		RegisterFinalTransition(state_Countdown, PsmSubMachine.Next);
	}

	private void WaitBegin()
	{
		if (!bWaiting)
		{
			bWaiting = true;
			BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
			bGWEventCollection.Evt_ReadyBossRushBattle = (Del_Void)Delegate.Combine(bGWEventCollection.Evt_ReadyBossRushBattle, new Del_Void(BossRushBattleReady));
		}
	}

	private void BossRushBattleReady()
	{
		if (bWaiting)
		{
			bWaiting = false;
			BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
			bGWEventCollection.Evt_ReadyBossRushBattle = (Del_Void)Delegate.Remove(bGWEventCollection.Evt_ReadyBossRushBattle, new Del_Void(BossRushBattleReady));
			OnEvent(PsmSubMachine.Next);
		}
	}

	public override void Shutdown()
	{
		if (bWaiting)
		{
			bWaiting = false;
			BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
			bGWEventCollection.Evt_ReadyBossRushBattle = (Del_Void)Delegate.Remove(bGWEventCollection.Evt_ReadyBossRushBattle, new Del_Void(BossRushBattleReady));
		}
		base.Shutdown();
	}
}
