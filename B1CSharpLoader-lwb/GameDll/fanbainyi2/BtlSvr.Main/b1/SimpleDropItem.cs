using CsB1;
using GSDispLib;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class SimpleDropItem
{
	private float Timer;

	public BGP_PlayerControllerCS PlayerCtrl;

	public bool isFinish;

	public uint DBCID;

	public UBGWDropItemTemplete DropTemplete;

	private ItemOne DropItemOne;

	private DropReason DropReason;

	public int GamePlayDispReqID = -1;

	public SimpleDropItem(BGP_PlayerControllerCS InPlayerCtrl, float Timer, ItemOne DropItemOne, DropReason DropReason)
	{
		this.Timer = Timer;
		PlayerCtrl = InPlayerCtrl;
		this.DropItemOne = DropItemOne;
		this.DropReason = DropReason;
	}

	public void TickPicking(float DeltaTime)
	{
		if (isFinish)
		{
			return;
		}
		Timer -= DeltaTime;
		if (Timer <= 0f)
		{
			isFinish = true;
			TriggerDropItemEffect();
			if (!PlayerCtrl.IsNullOrDestroyed() && !PlayerCtrl.GetControlledPawn().IsNullOrDestroyed() && !(DropTemplete == null) && DropTemplete.DAPickedSign != null)
			{
				BUS_DispLibEventCollection.Get(PlayerCtrl.GetControlledPawn())?.Evt_RequestApplyOneDBCDataAsset(DropTemplete.DAPickedSign, out var _, PlayerCtrl.GetControlledPawn().GetComponentByClass<USkeletalMeshComponent>(), FVector.ZeroVector, DBCTransformParam.Default, DBCSetCallbackParams.Default, PlayerCtrl.GetControlledPawn().GetUniqueID());
			}
		}
	}

	private void TriggerDropItemEffect()
	{
		BTF_EventCollectionCS bTF_EventCollectionCS = BTF_EventCollectionCS.Get(PlayerCtrl.PlayerState);
		if (bTF_EventCollectionCS == null)
		{
			BGW_LogUtil.LogError("BTFEventCollection Error : BTFEventCollection is Null");
		}
		CSMsgBagGainItemListReq cSMsgBagGainItemListReq = new CSMsgBagGainItemListReq
		{
			ItemList = { DropItemOne },
			Reason = OPReason.UnitDropPickUp
		};
		if (DropReason == DropReason.Collection)
		{
			cSMsgBagGainItemListReq.Reason = OPReason.PlayerCollectItem;
		}
		bTF_EventCollectionCS.Evt_BagGainItemListReq(cSMsgBagGainItemListReq, GainItemCallBack);
	}

	private void GainItemCallBack(MsgErrCode ErrCode, CSMsgBagGainItemListReq Req, CSMsgBagGainItemListRes Res)
	{
	}

	public void StopDropping()
	{
		Timer = 0f;
		DropTemplete = null;
	}
}
