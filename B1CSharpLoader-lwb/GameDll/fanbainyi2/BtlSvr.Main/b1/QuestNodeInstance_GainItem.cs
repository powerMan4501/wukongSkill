using CommB1;
using CsB1;
using Google.Protobuf;
using ResB1;

namespace b1;

public class QuestNodeInstance_GainItem : QuestNodeInstance
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
		ItemOne item = new ItemOne
		{
			Id = CustomData.ItemId,
			Num = CustomData.Count
		};
		BTF_EventCollectionCS bTF_EventCollectionCS = BTF_EventCollectionCS.Get((UGSE_EngineFuncLib.GetFirstLocalPlayerController(base.Owner).GetControlledPawn() as ABGUCharacter).PlayerState);
		CSMsgBagGainItemListReq bagGainItemList = new CSMsgBagGainItemListReq
		{
			Reason = OPReason.CqgGainItem,
			ItemList = { item }
		};
		bTF_EventCollectionCS.Evt_BagGainItemListReq(bagGainItemList, GainItemCallBack);
		TriggerFirstOutput(bFinish: true);
	}

	private void GainItemCallBack(MsgErrCode ErrCode, CSMsgBagGainItemListReq Req, CSMsgBagGainItemListRes Res)
	{
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
		ItemOne item = new ItemOne
		{
			Id = CustomData.ItemId,
			Num = CustomData.Count
		};
		BTF_EventCollectionCS bTF_EventCollectionCS = BTF_EventCollectionCS.Get((UGSE_EngineFuncLib.GetFirstLocalPlayerController(base.Owner).GetControlledPawn() as ABGUCharacter).PlayerState);
		CSMsgBagGainItemListReq bagGainItemList = new CSMsgBagGainItemListReq
		{
			ItemList = { item },
			Reason = OPReason.CqgGainItem
		};
		bTF_EventCollectionCS.Evt_BagGainItemListReq(bagGainItemList, GainItemCallBack);
		TriggerFirstOutput(bFinish: true);
	}
}
