using CommB1;
using Google.Protobuf;

namespace b1;

public class PsmNodeInstance_Junction : PsmNodeInstance
{
	public override string[] SupportNodeClasses => new string[1] { B1CalliopeDef.ProcessMachineNode.Junction };

	private ProcessCustom_Junction CustomData { get; set; }

	public override void PostCreate()
	{
		CustomData = new ProcessCustom_Junction();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	protected override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		Finish();
		base.ParentInstance.JunctionToState(CustomData.JunctionState, base.CurrentGroupName);
	}

	public override void RecoverActiveState()
	{
		Finish();
		base.ParentInstance.JunctionToState(CustomData.JunctionState, base.CurrentGroupName);
	}
}
