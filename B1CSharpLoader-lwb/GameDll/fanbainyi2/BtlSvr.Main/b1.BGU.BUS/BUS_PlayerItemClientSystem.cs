using System.Collections.Generic;
using b1.EventDelDefine;
using CsB1;
using ResB1;

namespace b1.BGU.BUS;

internal class BUS_PlayerItemClientSystem : UActorCompBaseCS
{
	private BUC_PlayerItemData PlayerItemData;

	private IBPC_PlayerRoleData RoleData;

	private BTF_EventCollectionCS BTFEventCollection { get; set; }

	private BPS_GSEventCollection BPSEventCollection { get; set; }

	public override void OnAttach()
	{
		PlayerItemData = RequireWritableData<BUC_PlayerItemData>();
		RoleData = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(OwnerAsCharacterCS.GetController());
		base.BUSEventCollection.Evt_TriggerUseItem += new Del_Void_Int(OnTriggerUseItem);
		base.BUSEventCollection.Evt_TriggerCostItem += new Del_Void(OnTriggerCostItem);
		base.BUSEventCollection.Evt_SetAllowUseSpecialItemMap += new Del_SetAllowUseSpecialItemMap(OnSetAllowUseSpecialItemMap);
		BTFEventCollection = BTF_EventCollectionCS.Get(OwnerAsCharacterCS?.PlayerState);
		BPSEventCollection = BPS_GSEventCollection.Get(OwnerAsCharacterCS?.PlayerState);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (PlayerItemData.CheckTime > 0f)
		{
			PlayerItemData.CheckTime -= DeltaTime;
			if (PlayerItemData.CheckTime <= 0f)
			{
				ResetCurUseItemCacheInfo();
			}
		}
	}

	private void OnSetAllowUseSpecialItemMap(in Dictionary<int, bool> AllowUseSpecialItem)
	{
		if (PlayerItemData == null)
		{
			return;
		}
		if (PlayerItemData.AllowUseSpecialItemMap == null)
		{
			PlayerItemData.AllowUseSpecialItemMap = new Dictionary<int, bool>();
		}
		foreach (KeyValuePair<int, bool> item in AllowUseSpecialItem)
		{
			PlayerItemData.AllowUseSpecialItemMap[item.Key] = item.Value;
		}
	}

	private void OnTriggerUseItem(int ItemId)
	{
		ItemDesc itemDesc = GameDBRuntime.GetItemDesc(ItemId);
		if (itemDesc != null && itemDesc.ItemType == ItemType.Consume)
		{
			ConsumeDesc consumeDesc = GameDBRuntime.GetConsumeDesc(ItemId);
			if (consumeDesc != null && CheckItemNumInBag(ItemId) != 0 && consumeDesc.Type == ConsumeType.Elixir)
			{
				PlayerItemData.CurUseItemId = ItemId;
				PlayerItemData.CheckTime = 1.5f;
			}
		}
	}

	private void OnTriggerCostItem()
	{
		if (PlayerItemData.CurUseItemId > 0)
		{
			ItemDesc itemDesc = GameDBRuntime.GetItemDesc(PlayerItemData.CurUseItemId);
			if (itemDesc != null && itemDesc.ItemType == ItemType.Consume)
			{
				if (CheckItemNumInBag(PlayerItemData.CurUseItemId) == 0)
				{
					return;
				}
				ConsumeDesc consumeDesc = GameDBRuntime.GetConsumeDesc(PlayerItemData.CurUseItemId);
				if (consumeDesc != null)
				{
					int num = 1;
					if (consumeDesc.Type == ConsumeType.Elixir)
					{
						CSMsgBagCostItemListReq cSMsgBagCostItemListReq = new CSMsgBagCostItemListReq();
						cSMsgBagCostItemListReq.Reason = OPReason.ItemUse;
						cSMsgBagCostItemListReq.ItemList.AddRange(new List<ItemOne>
						{
							new ItemOne
							{
								Id = PlayerItemData.CurUseItemId,
								Num = num
							}
						});
						BTFEventCollection?.Evt_BagCostItemListReq(cSMsgBagCostItemListReq, BagCostItemCallBack, OwnerAsCharacterCS.PlayerState, AllPlayer: false);
					}
					BPSEventCollection?.Evt_SetOSSItemChangeData.Invoke(PlayerItemData.CurUseItemId, num, OPReason.PlayerCostItem);
				}
			}
		}
		ResetCurUseItemCacheInfo();
	}

	private void BagCostItemCallBack(MsgErrCode MsgErrCode, CSMsgBagCostItemListReq CSMsgBagCostItemListReq, CSMsgBagCostItemListRes CSMsgBagCostItemListRes)
	{
		if (!B1Global.GIsBossRushMode || MsgErrCode != MsgErrCode.ErrSuccess)
		{
			return;
		}
		foreach (ItemOne item in CSMsgBagCostItemListReq.ItemList)
		{
			BGW_EventCollection.Get(Owner)?.Evt_BossRushRecordItemUse(item);
		}
	}

	private void ResetCurUseItemCacheInfo()
	{
		PlayerItemData.CurUseItemId = 0;
		PlayerItemData.CheckTime = 0f;
	}

	private int CheckItemNumInBag(int ItemId)
	{
		return RoleDataHelper.FindBagItem(RoleData.RoleData.RoleCs, ItemId)?.Num ?? 0;
	}
}
