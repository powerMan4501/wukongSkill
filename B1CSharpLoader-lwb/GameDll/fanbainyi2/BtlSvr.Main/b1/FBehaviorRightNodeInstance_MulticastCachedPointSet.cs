using CommB1;
using Google.Protobuf;

namespace b1;

public class FBehaviorRightNodeInstance_MulticastCachedPointSet : FBehaviorRightNodeInstance
{
	public override string NodeName => B1CalliopeDef.BehaviorNode.MulticastCachedPointSet;

	public BehaviorCustom_MulticastCachedPointSet CustomData { get; set; }

	protected override void PostCreate()
	{
		CustomData = new BehaviorCustom_MulticastCachedPointSet();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	protected override void TriggerInput(string InputPin)
	{
		base.BUSEventCollection.Evt_MulticastCachedPointSet.Invoke(CustomData.RequestId);
	}
}
