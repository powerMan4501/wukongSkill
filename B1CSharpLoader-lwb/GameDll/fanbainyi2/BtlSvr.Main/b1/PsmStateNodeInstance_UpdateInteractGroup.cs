using CommB1;
using Google.Protobuf;

namespace b1;

public class PsmStateNodeInstance_UpdateInteractGroup : PsmStateNodeInstance
{
	public override string NodeClass => "Process.State.UpdateInteractGroup";

	private ProcessStateCustom_UpdateInteractGroup CustomData { get; set; }

	public override void PostCreate()
	{
		CustomData = new ProcessStateCustom_UpdateInteractGroup();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		int interactGroupId = CustomData.InteractGroupId;
		string unitGuid = CustomData.UnitGuid;
		BGW_EventCollection.Get(GetOwner()).Evt_SendUpdateInteractGroup(unitGuid, interactGroupId);
		TriggerFirstOutput(bFinish: true);
	}
}
