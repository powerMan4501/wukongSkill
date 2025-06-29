using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

public class PsmSubMachine_Group : PsmSubMachine_TemplateBase
{
	private class State_GroupActived : PsmSubMachineState
	{
		public override void OnEnterAction()
		{
			if (GetSubMachine<PsmSubMachine_Group>(out var OutSubMachine))
			{
				OutSubMachine.SetObjStateOnBeginning();
				OutSubMachine.StartGroup();
			}
		}

		public override void OnRecoverAction()
		{
			if (GetSubMachine<PsmSubMachine_Group>(out var OutSubMachine))
			{
				OutSubMachine.SetObjStateOnBeginning();
				OutSubMachine.ResetUnits();
				OutSubMachine.StartGroup();
			}
		}
	}

	private class State_GroupFinished : PsmSubMachineState
	{
		public override void OnEnterAction()
		{
			if (GetSubMachine<PsmSubMachine_Group>(out var OutSubMachine))
			{
				OutSubMachine.FinishGroup();
				NotifySelf(BGW_FlowUtils.SceneObjCommonEventTag.Next);
			}
		}
	}

	public override string NodeClass => B1CalliopeDef.ProcessMachineNode.Group;

	protected override string DefaultTerminatePinName => BGW_FlowUtils.PinName.Out.PlainName;

	private ProcessCustom_Group CustomData { get; set; }

	private string GroupName { get; set; }

	protected override void InitialData(byte[] CustomDataBytes)
	{
		base.InitialData(CustomDataBytes);
		CustomData = new ProcessCustom_Group();
		CustomData.MergeFrom(CustomDataBytes);
		GroupName = CustomData.GroupName;
		FGameplayTag state_GroupActived = BGW_FlowUtils.CommonProcessTag.State_GroupActived;
		FGameplayTag state_GroupFinished = BGW_FlowUtils.CommonProcessTag.State_GroupFinished;
		RegisterStateWithClass(state_GroupActived, typeof(State_GroupActived));
		RegisterStateWithClass(state_GroupFinished, typeof(State_GroupFinished));
		RegisterInitialTransition(state_GroupActived);
		RegisterStateTransition(state_GroupActived, BGW_FlowUtils.CommonProcessTag.Event_GroupFinish, state_GroupFinished);
		RegisterFinalTransition(state_GroupActived, BGW_FlowUtils.SceneObjCommonEventTag.Next);
		RegisterFinalTransition(state_GroupFinished, BGW_FlowUtils.SceneObjCommonEventTag.Next);
		base.ManagedSceneObjs.AddRange(CustomData.ManagedObjs);
		base.ManagedNpcUnits.AddRange(CustomData.ManagedNpcUnits);
		base.ManagedInteractors.AddRange(CustomData.ManagedInteractors);
		base.ManagedStreamingLevelStateConfigs.AddRange(CustomData.ManagedStreamingLevelStateConfigs);
		base.ManagedGroupUnits.AddRange(CustomData.ManagedGroupUnits);
	}

	public override void PreStart()
	{
		ClearTerminateGuards();
		foreach (CalliopeCustom_CompositeTransitionCondition_Group transitionCondition in CustomData.TransitionConditions)
		{
			TransitionGuard guard = new TransitionGuard(transitionCondition, base.ParentNodeInstance);
			RegisterTerminateGuards(guard);
		}
		base.PreStart();
	}

	private void ResetUnits()
	{
		foreach (ManagedSceneObjForPsm item in base.ManagedSceneObjsForPsm)
		{
			if (item.ObjType == ManagedSceneObjType.Unit)
			{
				base.BGWEventCollection.Evt_TriggerResetOneActor(item.ObjGuid, EResetActorReason.Rebirth);
			}
		}
	}

	private void StartGroup()
	{
		if (base.ParentNodeInstance != null && base.ParentNodeInstance.ParentInstance != null)
		{
			base.ParentNodeInstance.ParentInstance.StartGroup(GroupName, base.ParentNodeInstance);
		}
	}

	private void FinishGroup()
	{
		if (base.ParentNodeInstance != null && base.ParentNodeInstance.ParentInstance != null)
		{
			base.ParentNodeInstance.TriggerFirstOutput(bFinish: true);
		}
	}

	public override bool IsGroupNode(out string OutGroupName)
	{
		OutGroupName = GroupName;
		return true;
	}
}
