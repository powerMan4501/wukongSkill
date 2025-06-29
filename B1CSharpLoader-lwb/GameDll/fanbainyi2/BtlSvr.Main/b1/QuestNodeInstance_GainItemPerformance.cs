using b1.UI;
using CommB1;
using Google.Protobuf;

namespace b1;

public class QuestNodeInstance_GainItemPerformance : QuestNodeInstance
{
	private QuestCustom_GainItem CustomData { get; set; }

	protected override void PostCreate()
	{
		CustomData = new QuestCustom_GainItem();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		TriggerPerformance();
		TriggerFirstOutput(bFinish: true);
	}

	private void TriggerPerformance()
	{
		BGS_EventCollectionCS.Get(UGSE_EngineFuncLib.GetFirstLocalPlayerController(base.Owner).GetControlledPawn()).Evt_OnItemDropToUI.Invoke(new FDropItem(CustomData.ItemId, CustomData.Count, EItemTag.BAG));
	}

	public override byte[] GetNodeCustomData()
	{
		return null;
	}

	public override void SetNodeCustomData(byte[] CustomData)
	{
	}

	public override void RecoverActiveState()
	{
		TriggerPerformance();
		TriggerFirstOutput(bFinish: true);
	}
}
