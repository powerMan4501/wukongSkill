using CommB1;
using Google.Protobuf;

namespace b1;

public class FBehaviorRightNodeInstance_SimpleState : FBehaviorRightNodeInstance
{
	public override string NodeName => B1CalliopeDef.BehaviorNode.SimpleState;

	private BehaviorCustom_SimpleState CustomData { get; set; }

	protected override void PostCreate()
	{
		CustomData = new BehaviorCustom_SimpleState();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	protected override void TriggerInput(string InputPin)
	{
		EBGUSimpleState simpleStateID = (EBGUSimpleState)CustomData.SimpleState;
		bool isAdd = CustomData.IsAdd;
		base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke(simpleStateID, !isAdd);
	}
}
