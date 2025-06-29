using b1.EventDelDefine;
using BtlB1;
using CommB1;
using CsB1;
using ResB1;
using UnrealEngine.Engine;

namespace b1.BGU.BUS;

internal class BUS_PlayerItemSystem : UActorCompBaseCS
{
	private IBPC_PlayerRoleData RoleData;

	private IBUC_SimpleStateData SimpleStateData;

	private BPS_GSEventCollection BPSEventCollection;

	public override void OnAttach()
	{
		RoleData = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(OwnerAsCharacterCS.GetController());
		SimpleStateData = RequireReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>();
		if (base.BUSEventCollection != null)
		{
			base.BUSEventCollection.Evt_TriggerItemEffectReal += new Del_TriggerItemEffectReal(OnTriggerItemEffectReal);
			base.BUSEventCollection.Evt_TriggerHuluEffect += new Del_Void(OnTriggerHuluEffect);
			base.BUSEventCollection.Evt_TriggerWinePartner += new Del_Void_Int(OnTriggerWinePartner);
			base.BUSEventCollection.Evt_GSItemTeleportTriggerPrepare += new Del_Void(OnItemTeleportTriggerPrepare);
			base.BUSEventCollection.Evt_GSItemTeleportTrigger += new Del_GSItemTeleportTrigger(OnItemTeleportTrigger);
		}
		APawn aPawn = Owner as APawn;
		if (aPawn != null)
		{
			BPSEventCollection = BPS_EventCollectionCS.Get(aPawn.PlayerState);
		}
	}

	private void TriggerHuluEffect(int HuluId)
	{
		HuluDesc huluDesc = GameDBRuntime.GetHuluDesc(HuluId);
		if (huluDesc == null)
		{
			return;
		}
		foreach (int buff in huluDesc.BuffList)
		{
			base.BUSEventCollection.Evt_BuffAdd.Invoke(buff, GetOwner(), GetOwner(), 0f, EBuffSourceType.PlayerItem);
		}
	}

	private void TriggerItemEffect(int ConsumeId)
	{
		ConsumeDesc consumeDesc = GameDBRuntime.GetConsumeDesc(ConsumeId);
		if (consumeDesc == null)
		{
			return;
		}
		foreach (ConsumeEffect item in consumeDesc.ConsumeEffect)
		{
			if (item.EffectType == ConsumeEffectType.Buff)
			{
				base.BUSEventCollection.Evt_BuffAdd.Invoke(item.EffectId, GetOwner(), GetOwner(), 0f, EBuffSourceType.PlayerItem);
			}
		}
	}

	private void TriggerWinePartnerEffect(IBPC_PlayerRoleData PlayerRoleData, int WineId, int TriggerId)
	{
		foreach (ReadOnlyRoleWine wine in PlayerRoleData.RoleData.RoleCs.Bag.WineList)
		{
			if (wine.WineId != WineId)
			{
				continue;
			}
			foreach (ReadOnlyWinePartner item in wine.ItemList)
			{
				ConsumeDesc consumeDesc = GameDBRuntime.GetConsumeDesc(item.ItemId);
				if (consumeDesc != null && consumeDesc.WinePartnerTrigger == TriggerId)
				{
					TriggerItemEffect(item.ItemId);
				}
			}
		}
	}

	private void OnTriggerHuluEffect()
	{
		IBPC_PlayerRoleData roleData = RoleData;
		ReadOnlyRoleEquip wearEquipByPosition = RoleDataHelper.GetWearEquipByPosition(roleData.RoleData.RoleCs, EquipPosition.Hulu);
		if (wearEquipByPosition != null)
		{
			int wineId = roleData.RoleData.RoleCs.Actor.Wear.WineId;
			TriggerHuluEffect(wearEquipByPosition.EquipId);
			TriggerItemEffect(wineId);
			base.BUSEventCollection.Evt_OnTriggerHuluEffectSuccess.Invoke();
		}
	}

	private void OnTriggerWinePartner(int TriggerId)
	{
		IBPC_PlayerRoleData roleData = RoleData;
		if (RoleDataHelper.GetWearEquipByPosition(roleData.RoleData.RoleCs, EquipPosition.Hulu) != null)
		{
			int wineId = roleData.RoleData.RoleCs.Actor.Wear.WineId;
			TriggerWinePartnerEffect(roleData, wineId, TriggerId);
		}
	}

	private void OnTriggerItemEffectReal(int ItemId, OPReason OPReason)
	{
		ItemDesc itemDesc = GameDBRuntime.GetItemDesc(ItemId);
		if (itemDesc != null)
		{
			if (itemDesc.ItemType == ItemType.Consume)
			{
				TriggerItemEffect(ItemId);
			}
			if (RoleData != null && RoleData.RoleData.RoleCs.Base != null)
			{
				base.BGSEventCollection?.Evt_BGS_UseItemScreenMsg.Invoke(RoleData.RoleData.RoleCs.Base.Name, ItemId);
				base.BUSEventCollection.Evt_OnUseItemSuccess.Invoke();
			}
		}
	}

	private void OnItemTeleportTriggerPrepare()
	{
		BTF_EventCollectionCS bTF_EventCollectionCS = BTF_EventCollectionCS.Get((Owner as BGUCharacterCS)?.PlayerState);
		if (SimpleStateData != null)
		{
			bool flag = !SimpleStateData.HasSimpleState(EBGUSimpleState.PlayerDeadNoPunish);
			bTF_EventCollectionCS?.Evt_ActorOnPlayerDeathReq(new CSMsgActorOnPlayerDeathReq
			{
				IsPunish = (flag ? YesNoType.Yes : YesNoType.No)
			}, null);
		}
	}

	private void OnItemTeleportTrigger(BANItemTeleportType ItemTeleportType, int TargetRebirthPointId)
	{
		switch (ItemTeleportType)
		{
		case BANItemTeleportType.TeleportTargetRebirthPointId:
			BPSEventCollection?.Evt_BPS_TeleportTo.Invoke(ETeleportTypeV2.RebirthPoint, new TeleportParam_RebirthPoint
			{
				RebirthPointId = TargetRebirthPointId,
				RebirthType = ERebirthType.RebirthPoint
			}, EPlayerTeleportReason.ItemTeleport);
			break;
		case BANItemTeleportType.RebirthPointTeleport:
			base.BUSEventCollection?.Evt_UnitRebirth_ByItem.Invoke(ERebirthType.RebirthPoint);
			break;
		}
	}
}
