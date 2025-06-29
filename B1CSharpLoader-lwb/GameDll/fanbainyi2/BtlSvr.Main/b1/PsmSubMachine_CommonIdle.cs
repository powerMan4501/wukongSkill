using System.Linq;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

public class PsmSubMachine_CommonIdle : PsmSubMachine_TemplateBase
{
	private class State_Idle : PsmSubMachineState
	{
		public UObject Owner;

		private bool bTeleporting;

		public override void OnEnterAction()
		{
			Owner = GetOwner();
			if (base.ParentSubMachine is PsmSubMachine_CommonIdle psmSubMachine_CommonIdle)
			{
				psmSubMachine_CommonIdle.SetObjStateOnBeginning();
				if (psmSubMachine_CommonIdle.CustomData.ProcessActions.Count > 0)
				{
					BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(Owner);
					bGW_EventCollection.Evt_RegisterIdleProcessAction(psmSubMachine_CommonIdle.CustomData.ProcessActions.ToList(), psmSubMachine_CommonIdle.ParentNodeInstance);
					bGW_EventCollection.Evt_RunIdleProcessActions(psmSubMachine_CommonIdle.ParentNodeInstance);
				}
			}
		}

		public override void OnResetAction()
		{
			Owner = GetOwner();
			if (base.ParentSubMachine is PsmSubMachine_CommonIdle psmSubMachine_CommonIdle)
			{
				psmSubMachine_CommonIdle.SetObjStateOnBeginning();
				BGW_EventCollection.Get(Owner).Evt_ResetRunIdleProcessActions(psmSubMachine_CommonIdle.ParentNodeInstance);
			}
		}

		public override void OnRecoverAction()
		{
			Owner = GetOwner();
			if (base.ParentSubMachine is PsmSubMachine_CommonIdle psmSubMachine_CommonIdle)
			{
				psmSubMachine_CommonIdle.SetObjStateOnBeginning();
				BGW_EventCollection.Get(Owner).Evt_RecoverRunIdleProcessActions(psmSubMachine_CommonIdle.ParentNodeInstance);
			}
		}

		public override void OnExitAction()
		{
			BGW_EventCollection.Get(Owner).Evt_ShutdownIdleProcessActions(base.ParentSubMachine.ParentNodeInstance);
		}
	}

	public override string NodeClass => B1CalliopeDef.ProcessMachineNode.Idle;

	private ProcessCustom_Idle CustomData { get; set; }

	protected override void InitialData(byte[] CustomDataBytes)
	{
		base.InitialData(CustomDataBytes);
		CustomData = new ProcessCustom_Idle();
		CustomData.MergeFrom(CustomDataBytes);
		RegisterStateWithClass(BGW_FlowUtils.CommonProcessTag.State_Idle, typeof(State_Idle));
		RegisterInitialTransition(BGW_FlowUtils.CommonProcessTag.State_Idle);
		base.ManagedSceneObjs.AddRange(CustomData.ManagedObjs);
		base.ManagedNpcUnits.AddRange(CustomData.ManagedNpcUnits);
		base.ManagedInteractors.AddRange(CustomData.ManagedInteractors);
		base.ManagedStreamingLevelStateConfigs.AddRange(CustomData.ManagedStreamingLevelStateConfigs);
		base.ManagedGroupUnits.AddRange(CustomData.ManagedGroupUnits);
	}

	public override void PreStart()
	{
		base.PreStart();
		ClearTerminateGuards();
		foreach (CalliopeCustom_CompositeTransitionCondition_Idle transitionCondition in CustomData.TransitionConditions)
		{
			TransitionGuard guard = new TransitionGuard(transitionCondition, base.ParentNodeInstance);
			RegisterTerminateGuards(guard);
		}
	}
}
