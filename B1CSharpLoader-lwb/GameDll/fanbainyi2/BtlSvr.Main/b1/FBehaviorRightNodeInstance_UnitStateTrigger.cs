using CommB1;
using Google.Protobuf;

namespace b1;

public class FBehaviorRightNodeInstance_UnitStateTrigger : FBehaviorRightNodeInstance
{
	public override string NodeName => B1CalliopeDef.BehaviorNode.UnitStateTrigger;

	private BehaviorCustom_UnitStateTrigger CustomData { get; set; }

	protected override void PostCreate()
	{
		CustomData = new BehaviorCustom_UnitStateTrigger();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	protected override void TriggerInput(string InputPin)
	{
		EBUStateTrigger triggerID = (EBUStateTrigger)CustomData.UnitStateTrigger;
		float time = CustomData.Time;
		base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(triggerID, time);
	}
}
