using CommB1;
using Google.Protobuf;

namespace b1;

public class PsmStateNodeInstance_EnterAction : PsmStateNodeInstance
{
	public override string NodeClass => "Process.State.EnterAction";

	private ProcessStateCustom_EnterAction CustomData { get; set; }

	public override void PostCreate()
	{
		CustomData = new ProcessStateCustom_EnterAction();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		if (!CustomData.IsOverrideParent)
		{
			base.ParentInstance.BaseState?.OnEnterAction();
		}
		TriggerFirstOutput(bFinish: true);
	}
}
