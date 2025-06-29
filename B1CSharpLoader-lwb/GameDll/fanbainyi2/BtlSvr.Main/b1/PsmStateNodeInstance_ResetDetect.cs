using CommB1;
using Google.Protobuf;

namespace b1;

public class PsmStateNodeInstance_ResetDetect : PsmStateNodeInstance
{
	public override string NodeClass => "Process.State.ResetDetect";

	private ProcessStateCustom_ResetDetect CustomData { get; set; }

	public override void PostCreate()
	{
		CustomData = new ProcessStateCustom_ResetDetect();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		base.ParentInstance.SetDetectConditionEnabled(CustomData.DetectCondition, bEnable: false);
		base.ParentInstance.SetDetectConditionEnabled(CustomData.DetectCondition, bEnable: true);
		TriggerFirstOutput(bFinish: true);
	}
}
