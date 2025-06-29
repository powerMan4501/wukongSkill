using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

public class PsmSubMachine_SaveArchive : PsmSubMachine_TemplateBase
{
	private class State_SaveArchive : PsmSubMachineState
	{
		public override void OnEnterAction()
		{
			if (GetSubMachine<PsmSubMachine_SaveArchive>(out var OutSubMachine))
			{
				OutSubMachine.SetObjStateOnBeginning();
			}
			NotifySelfNext();
		}

		public override void OnResetAction()
		{
			NotifySelfNext();
		}

		private void NotifySelfNext()
		{
			NotifySelf(BGW_FlowUtils.SceneObjCommonEventTag.Next);
		}
	}

	public override string NodeClass => B1CalliopeDef.ProcessMachineNode.SaveArchive;

	private ProcessCustom_SaveArchive CustomData { get; set; }

	protected override string DefaultTerminatePinName => BGW_FlowUtils.PinName.Out.PlainName;

	protected override void InitialData(byte[] CustomDataBytes)
	{
		base.InitialData(CustomDataBytes);
		CustomData = new ProcessCustom_SaveArchive();
		CustomData.MergeFrom(CustomDataBytes);
		base.ManagedSceneObjs.AddRange(CustomData.ManagedObjs);
		base.ManagedNpcUnits.AddRange(CustomData.ManagedNpcUnits);
		base.ManagedInteractors.AddRange(CustomData.ManagedInteractors);
		base.ManagedStreamingLevelStateConfigs.AddRange(CustomData.ManagedStreamingLevelStateConfigs);
		base.ManagedGroupUnits.AddRange(CustomData.ManagedGroupUnits);
		FGameplayTag state_SaveArchive = BGW_FlowUtils.CommonProcessTag.State_SaveArchive;
		RegisterStateWithClass(state_SaveArchive, typeof(State_SaveArchive));
		RegisterInitialTransition(state_SaveArchive);
		RegisterFinalTransition(state_SaveArchive, BGW_FlowUtils.SceneObjCommonEventTag.Next);
	}
}
