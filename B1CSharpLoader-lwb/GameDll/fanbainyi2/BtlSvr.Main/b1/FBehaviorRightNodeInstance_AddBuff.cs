using CommB1;
using Google.Protobuf;

namespace b1;

public class FBehaviorRightNodeInstance_AddBuff : FBehaviorRightNodeInstance
{
	public override string NodeName => B1CalliopeDef.BehaviorNode.AddBuff;

	private BehaviorCustom_AddBuff CustomData { get; set; }

	protected override void PostCreate()
	{
		CustomData = new BehaviorCustom_AddBuff();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	protected override void TriggerInput(string InputPin)
	{
		int buffId = CustomData.BuffId;
		int buffLayer = CustomData.BuffLayer;
		int buffDuration = CustomData.BuffDuration;
		for (int i = 0; i < buffLayer; i++)
		{
			base.BUSEventCollection.Evt_BuffAdd.Invoke(buffId, base.Owner, base.Owner, buffDuration, EBuffSourceType.BehaviorGraph);
		}
	}
}
