using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
internal class BUS_GateStateMachineComp : BUS_StateMachineCompBase
{
	public class OpenState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.DynamicObstacleTag.State_Disabled;

		public override void OnInitialize()
		{
			base.OnInitialize();
			base.EventTransitDictionary.Add(BGW_FlowUtils.DynamicObstacleTag.Event_DisabledToEnabled, BGW_FlowUtils.DynamicObstacleTag.State_DisabledToEnabled);
			base.EventTransitDictionary.Add(BGW_FlowUtils.DynamicObstacleTag.Event_Enable, BGW_FlowUtils.DynamicObstacleTag.State_Enabled);
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			if (InOwner is b1.BUS_GateStateMachineComp bUS_GateStateMachineComp)
			{
				bUS_GateStateMachineComp.OnEnter_OpenState();
			}
		}

		public override void OnRecoverAction(BUS_StateMachineCompBase InOwner)
		{
			base.OnRecoverAction(InOwner);
			if (InOwner is b1.BUS_GateStateMachineComp bUS_GateStateMachineComp)
			{
				bUS_GateStateMachineComp.OnResetToOpenState();
			}
		}

		public override void OnInitialAction(BUS_StateMachineCompBase InOwner)
		{
			OnRecoverAction(InOwner);
		}
	}

	public class OpenToCloseState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.DynamicObstacleTag.State_DisabledToEnabled;

		public override void OnInitialize()
		{
			base.OnInitialize();
			base.EventTransitDictionary.Add(BGW_FlowUtils.DynamicObstacleTag.Event_AchievePermanent, BGW_FlowUtils.DynamicObstacleTag.State_Enabled);
			base.EventTransitDictionary.Add(BGW_FlowUtils.DynamicObstacleTag.Event_Disable, BGW_FlowUtils.DynamicObstacleTag.State_Disabled);
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			if (InOwner is b1.BUS_GateStateMachineComp bUS_GateStateMachineComp && !bUS_GateStateMachineComp.IsManualStateControl())
			{
				BUS_EventCollectionCS.Get(bUS_GateStateMachineComp)?.Evt_SceneObjTransitByEvent.Invoke(BGW_FlowUtils.DynamicObstacleTag.Event_AchievePermanent);
			}
		}

		public override void OnRecoverAction(BUS_StateMachineCompBase InOwner)
		{
			base.OnRecoverAction(InOwner);
			if (InOwner is b1.BUS_GateStateMachineComp bUS_GateStateMachineComp)
			{
				bUS_GateStateMachineComp.OnResetToOpenState();
				BUS_EventCollectionCS.Get(InOwner)?.Evt_SceneObjTransitByEvent.Invoke(BGW_FlowUtils.DynamicObstacleTag.Event_Enable);
			}
		}

		public override void OnInitialAction(BUS_StateMachineCompBase InOwner)
		{
			OnRecoverAction(InOwner);
		}
	}

	public class CloseState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.DynamicObstacleTag.State_Enabled;

		public override void OnInitialize()
		{
			base.OnInitialize();
			base.EventTransitDictionary.Add(BGW_FlowUtils.DynamicObstacleTag.Event_EnabledToDisable, BGW_FlowUtils.DynamicObstacleTag.State_EnabledToDisable);
			base.EventTransitDictionary.Add(BGW_FlowUtils.DynamicObstacleTag.Event_Disable, BGW_FlowUtils.DynamicObstacleTag.State_Disabled);
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			if (InOwner is b1.BUS_GateStateMachineComp bUS_GateStateMachineComp)
			{
				bUS_GateStateMachineComp.OnEnter_CloseState();
			}
		}

		public override void OnRecoverAction(BUS_StateMachineCompBase InOwner)
		{
			base.OnRecoverAction(InOwner);
			if (InOwner is b1.BUS_GateStateMachineComp bUS_GateStateMachineComp)
			{
				bUS_GateStateMachineComp.OnResetToCloseState();
			}
		}

		public override void OnInitialAction(BUS_StateMachineCompBase InOwner)
		{
			OnRecoverAction(InOwner);
		}
	}

	public class CloseToOpenState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.DynamicObstacleTag.State_EnabledToDisable;

		public override void OnInitialize()
		{
			base.OnInitialize();
			base.EventTransitDictionary.Add(BGW_FlowUtils.DynamicObstacleTag.Event_AchievePermanent, BGW_FlowUtils.DynamicObstacleTag.State_Disabled);
			base.EventTransitDictionary.Add(BGW_FlowUtils.DynamicObstacleTag.Event_Enable, BGW_FlowUtils.DynamicObstacleTag.State_Enabled);
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			if (InOwner is b1.BUS_GateStateMachineComp bUS_GateStateMachineComp && !bUS_GateStateMachineComp.IsManualStateControl())
			{
				BUS_EventCollectionCS.Get(bUS_GateStateMachineComp)?.Evt_SceneObjTransitByEvent.Invoke(BGW_FlowUtils.DynamicObstacleTag.Event_AchievePermanent);
			}
		}

		public override void OnRecoverAction(BUS_StateMachineCompBase InOwner)
		{
			base.OnRecoverAction(InOwner);
			if (InOwner is b1.BUS_GateStateMachineComp bUS_GateStateMachineComp)
			{
				bUS_GateStateMachineComp.OnResetToCloseState();
				BUS_EventCollectionCS.Get(InOwner)?.Evt_SceneObjTransitByEvent.Invoke(BGW_FlowUtils.DynamicObstacleTag.Event_Disable);
			}
		}

		public override void OnInitialAction(BUS_StateMachineCompBase InOwner)
		{
			OnRecoverAction(InOwner);
		}
	}

	private b1.BUC_GateStateMachineData GateStateMachineData;

	private GSStateBase GSOpenState;

	private GSStateBase GSOpenToCloseState;

	private GSStateBase GSCloseState;

	private GSStateBase GSCloseToOpenState;

	public override void OnAttach()
	{
		base.OnAttach();
		GSOpenState = AddState(typeof(OpenState), 0);
		GSOpenToCloseState = AddState(typeof(OpenToCloseState), 1);
		GSCloseState = AddState(typeof(CloseState), 2);
		GSCloseToOpenState = AddState(typeof(CloseToOpenState), 3);
		GateStateMachineData = RequireWritableData<b1.BUC_GateStateMachineData>();
		base.InitialState = (GateStateMachineData.StartWithClosed ? GSCloseState : GSOpenState);
	}

	protected override void OnReset()
	{
		base.OnReset();
	}

	private void OnResetActorSpawn(string ActorGuid)
	{
		OnReset();
	}

	protected override bool IsIgnoreSavedState()
	{
		return false;
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
	}

	public bool IsManualStateControl()
	{
		return GateStateMachineData.ManualStateControl;
	}

	public void OnEnter_CloseState()
	{
		base.BUSEventCollection.Evt_GateStateMachineClose.Invoke();
		NotifyGraph(BGW_FlowUtils.CommonTag.GateClose);
		BGUGateStateMachineActor bGUGateStateMachineActor = GetOwner() as BGUGateStateMachineActor;
		if (!(bGUGateStateMachineActor == null))
		{
			bGUGateStateMachineActor.OnGateClose();
		}
	}

	public void OnEnter_OpenState()
	{
		base.BUSEventCollection.Evt_GateStateMachineOpen.Invoke();
		NotifyGraph(BGW_FlowUtils.CommonTag.GateOpen);
		BGUGateStateMachineActor bGUGateStateMachineActor = GetOwner() as BGUGateStateMachineActor;
		if (!(bGUGateStateMachineActor == null))
		{
			bGUGateStateMachineActor.OnGateOpen();
		}
	}

	public void OnResetToOpenState()
	{
		base.BUSEventCollection.Evt_GateStateMachineResetToOpen.Invoke();
		BGUGateStateMachineActor bGUGateStateMachineActor = GetOwner() as BGUGateStateMachineActor;
		if (!(bGUGateStateMachineActor == null))
		{
			bGUGateStateMachineActor.OnResetToGateOpen();
		}
	}

	public void OnResetToCloseState()
	{
		base.BUSEventCollection.Evt_GateStateMachineResetToClose.Invoke();
		BGUGateStateMachineActor bGUGateStateMachineActor = GetOwner() as BGUGateStateMachineActor;
		if (!(bGUGateStateMachineActor == null))
		{
			bGUGateStateMachineActor.OnResetToGateClose();
		}
	}
}
