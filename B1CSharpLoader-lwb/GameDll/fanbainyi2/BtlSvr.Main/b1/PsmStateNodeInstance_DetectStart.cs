using CommB1;
using Google.Protobuf;

namespace b1;

public class PsmStateNodeInstance_DetectStart : PsmStateNodeInstance
{
	public override string NodeClass => "Process.State.DetectStart";

	private ProcessStateCustom_DetectStart CustomData { get; set; }

	public override void PostCreate()
	{
		CustomData = new ProcessStateCustom_DetectStart();
		CustomData.MergeFrom(base.Node.NodeData);
		base.ParentInstance.RegisterDetectStartNode(CustomData.DetectCondition, this);
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		if (InputPin.Equals(BGW_FlowUtils.PinName.Enable.PlainName))
		{
			TriggerOutput(BGW_FlowUtils.PinName.Enabled.PlainName, bFinish: true);
		}
		else if (InputPin.Equals(BGW_FlowUtils.PinName.Disable.PlainName))
		{
			TriggerOutput(BGW_FlowUtils.PinName.Disabled.PlainName, bFinish: true);
		}
	}
}
