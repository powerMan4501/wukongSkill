using CommB1;
using Google.Protobuf;

namespace b1;

public class BehaviorRightNodeInstance_Log : FBehaviorRightNodeInstance
{
	public override string NodeName => B1CalliopeDef.BehaviorNode.Log;

	private BehaviorCustom_Log CustomData { get; set; }

	protected override void PostCreate()
	{
		CustomData = new BehaviorCustom_Log();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	protected override void TriggerInput(string InputPin)
	{
		TriggerOutput(BGW_FlowUtils.PinName.Completed.PlainName);
	}
}
