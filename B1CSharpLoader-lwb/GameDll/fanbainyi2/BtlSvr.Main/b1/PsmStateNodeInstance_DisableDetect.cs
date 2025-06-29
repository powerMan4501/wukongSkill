using CommB1;
using Google.Protobuf;

namespace b1;

public class PsmStateNodeInstance_DisableDetect : PsmStateNodeInstance
{
	public override string NodeClass => "Process.State.DisableDetect";

	private ProcessStateCustom_DisableDetect CustomData { get; set; }

	public override void PostCreate()
	{
		CustomData = new ProcessStateCustom_DisableDetect();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		base.ParentInstance.SetDetectConditionEnabled(CustomData.DetectCondition, bEnable: false);
		TriggerFirstOutput(bFinish: true);
	}
}
