using BtlShare;
using CommB1;
using Google.Protobuf;

namespace b1;

public class FBehaviorRightNodeInstance_RemoveBuff : FBehaviorRightNodeInstance
{
	public override string NodeName => B1CalliopeDef.BehaviorNode.RemoveBuff;

	private BehaviorCustom_RemoveBuff CustomData { get; set; }

	protected override void PostCreate()
	{
		CustomData = new BehaviorCustom_RemoveBuff();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	protected override void TriggerInput(string InputPin)
	{
		int buffId = CustomData.BuffId;
		int buffLayer = CustomData.BuffLayer;
		bool isTriggerRemoveEffect = CustomData.IsTriggerRemoveEffect;
		base.BUSEventCollection.Evt_BuffRemove.Invoke(buffId, EBuffEffectTriggerType.None, buffLayer, isTriggerRemoveEffect);
	}
}
