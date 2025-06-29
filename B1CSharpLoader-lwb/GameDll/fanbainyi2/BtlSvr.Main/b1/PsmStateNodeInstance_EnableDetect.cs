using CommB1;
using Google.Protobuf;

namespace b1;

public class PsmStateNodeInstance_EnableDetect : PsmStateNodeInstance
{
	public override string NodeClass => "Process.State.EnableDetect";

	private ProcessStateCustom_EnableDetect CustomData { get; set; }

	public override void PostCreate()
	{
		CustomData = new ProcessStateCustom_EnableDetect();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		base.ParentInstance.SetDetectConditionEnabled(CustomData.DetectCondition, bEnable: true);
		TriggerFirstOutput(bFinish: true);
	}
}
