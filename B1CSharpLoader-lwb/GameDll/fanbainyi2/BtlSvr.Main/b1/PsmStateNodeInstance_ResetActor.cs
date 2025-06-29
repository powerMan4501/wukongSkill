using CommB1;
using Google.Protobuf;

namespace b1;

public class PsmStateNodeInstance_ResetActor : PsmStateNodeInstance
{
	public override string NodeClass => "Process.State.ResetActor";

	private ProcessStateCustom_ResetActor CustomData { get; set; }

	public override void PostCreate()
	{
		CustomData = new ProcessStateCustom_ResetActor();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		TriggerFirstOutput(bFinish: true);
	}
}
