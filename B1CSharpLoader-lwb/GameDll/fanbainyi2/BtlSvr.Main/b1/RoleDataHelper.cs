using System.Collections.Generic;
using ArchiveB1;
using BtlB1;
using CommB1;
using OssB1;
using ResB1;
using UnrealEngine.Runtime;

namespace b1;

public static class RoleDataHelper
{
	public static bool HasItem(IBPC_PlayerRoleData I_RoleData, int ItmeId)
	{
		if (I_RoleData != null && I_RoleData.RoleData != null && I_RoleData.RoleData.RoleCs != null)
		{
			return HasItem(I_RoleData.RoleData.RoleCs, ItmeId);
		}
		return false;
	}

	public static bool HasItem(ReadOnlyRoleDataCS roleDataCS, int ItmeId)
	{
		return GetBagItemNum(roleDataCS, ItmeId) > 0;
	}

	public static int GetBagItemNum(IBPC_PlayerRoleData I_RoleData, int ItemId)
	{
		if (I_RoleData != null && I_RoleData.RoleData != null && I_RoleData.RoleData.RoleCs != null)
		{
			return GetBagItemNum(I_RoleData.RoleData.RoleCs, ItemId);
		}
		return 0;
	}

	public static int GetBagItemNum(ReadOnlyRoleDataCS roleDataCS, int ItemId)
	{
		switch (GameDBRuntime.GetItemTypeById(ItemId))
		{
		case ItemType.Spirit:
			return (int)GetBagMoneyNum(roleDataCS, MoneyType.Spirit);
		case ItemType.Exp:
			return roleDataCS.Actor.Progress.Xp;
		case ItemType.Equip:
			return GetBagEquipNumByEquipId(roleDataCS, ItemId);
		case ItemType.AttrItem:
			return GetAttrItemNum(roleDataCS, ItemId);
		case ItemType.Spell:
			if (IsSpellExist(roleDataCS, ItemId))
			{
				return 1;
			}
			return 0;
		case ItemType.TalentPoint:
			return roleDataCS.Actor.Progress.TalenPoint;
		case ItemType.Legacy:
			if (IsLegacyExist(roleDataCS, ItemId))
			{
				return 1;
			}
			return 0;
		case ItemType.SoulSkill:
			return GetBagSoulSkillNumBySoulSkillId(roleDataCS, ItemId);
		default:
		{
			ReadOnlyRoleItem readOnlyRoleItem = FindBagItem(roleDataCS, ItemId);
			if (readOnlyRoleItem != null)
			{
				return readOnlyRoleItem.Num;
			}
			if (FindBagWine(roleDataCS, ItemId) != null)
			{
				return 1;
			}
			return 0;
		}
		}
	}

	public static bool HasEquip(IBPC_PlayerRoleData I_RoleData, int EquipId)
	{
		if (I_RoleData != null && I_RoleData.RoleData != null && I_RoleData.RoleData.RoleCs != null)
		{
			return HasEquip(I_RoleData.RoleData.RoleCs, EquipId);
		}
		return false;
	}

	public static bool HasEquip(ReadOnlyRoleDataCS roleDataCS, int EquipId)
	{
		for (int i = 0; i < roleDataCS.Bag.EquipList.Count; i++)
		{
			if (roleDataCS.Bag.EquipList[i].EquipId == EquipId)
			{
				return true;
			}
		}
		return false;
	}

	public static ReadOnlyRoleItem FindBagItem(ReadOnlyRoleDataCS roleDataCS, int ItmeId)
	{
		for (int i = 0; i < roleDataCS.Bag.ItemList.Count; i++)
		{
			if (roleDataCS.Bag.ItemList[i].ItemId == ItmeId)
			{
				return roleDataCS.Bag.ItemList[i];
			}
		}
		return null;
	}

	public static ReadOnlyRoleEquip FindBagEquipByUid(ReadOnlyRoleDataCS roleDataCS, ulong EquipUid)
	{
		for (int i = 0; i < roleDataCS.Bag.EquipList.Count; i++)
		{
			if (roleDataCS.Bag.EquipList[i].Uid == EquipUid)
			{
				return roleDataCS.Bag.EquipList[i];
			}
		}
		return null;
	}

	public static ReadOnlyRoleWine FindBagWine(ReadOnlyRoleDataCS roleDataCS, int WineId)
	{
		for (int i = 0; i < roleDataCS.Bag.WineList.Count; i++)
		{
			if (roleDataCS.Bag.WineList[i].WineId == WineId)
			{
				return roleDataCS.Bag.WineList[i];
			}
		}
		return null;
	}

	public static int GetBagEquipNumByEquipId(ReadOnlyRoleDataCS roleDataCS, int EquipId)
	{
		int num = 0;
		for (int i = 0; i < roleDataCS.Bag.EquipList.Count; i++)
		{
			if (roleDataCS.Bag.EquipList[i].EquipId == EquipId)
			{
				num++;
			}
		}
		return num;
	}

	public static int GetBagSoulSkillNumBySoulSkillId(ReadOnlyRoleDataCS roleDataCS, int SoulSkilId)
	{
		int num = 0;
		for (int i = 0; i < roleDataCS.Bag.SoulSkillList.Count; i++)
		{
			if (SoulSkilId == roleDataCS.Bag.SoulSkillList[i].SoulSkillId)
			{
				num++;
			}
		}
		return num;
	}

	public static long GetBagMoneyNum(ReadOnlyRoleDataCS roleDataCS, MoneyType moneyType)
	{
		for (int i = 0; i < roleDataCS.Bag.MoneyList.Count; i++)
		{
			if (roleDataCS.Bag.MoneyList[i].MoneyType == moneyType)
			{
				return roleDataCS.Bag.MoneyList[i].MoneyValue;
			}
		}
		return 0L;
	}

	public static ulong GetWearEquipUidByPosition(ReadOnlyRoleDataCS roleDataCS, EquipPosition equipPosition)
	{
		for (int i = 0; i < roleDataCS.Actor.Wear.EquipList.Count; i++)
		{
			if (roleDataCS.Actor.Wear.EquipList[i].Position == equipPosition)
			{
				return roleDataCS.Actor.Wear.EquipList[i].Uid;
			}
		}
		return 0uL;
	}

	public static ReadOnlyRoleEquip GetWearEquipByPosition(ReadOnlyRoleDataCS roleDataCS, EquipPosition equipPosition)
	{
		ulong wearEquipUidByPosition = GetWearEquipUidByPosition(roleDataCS, equipPosition);
		if (wearEquipUidByPosition != 0)
		{
			return FindBagEquipByUid(roleDataCS, wearEquipUidByPosition);
		}
		return null;
	}

	public static Stance GetStance(ReadOnlyRoleDataCS roleDataCS)
	{
		return roleDataCS.Actor.Wear.Stance;
	}

	public static ReadOnlyRoleEquip FindCurWearWeapon(ReadOnlyRoleDataCS roleDataCS)
	{
		return GetWearEquipByPosition(roleDataCS, EquipPosition.Weapon);
	}

	public static void PlayerInfoRoleAddItem(PlayerInfoRole playerInfoRole, int ItemId, int ItemNum)
	{
		foreach (Item item2 in playerInfoRole.Items)
		{
			if (item2.Id == ItemId)
			{
				item2.Num += ItemNum;
				return;
			}
		}
		int itemTypeById = (int)GameDBRuntime.GetItemTypeById(ItemId);
		Item item = new Item
		{
			Id = ItemId,
			Num = ItemNum,
			Type = itemTypeById
		};
		playerInfoRole.Items.Add(item);
	}

	public static bool IsLegacyExist(ReadOnlyRoleDataCS RoleData, int LegacyId)
	{
		foreach (ReadOnlyLegacyAbility legacy in RoleData.Actor.Progress.LegacyList)
		{
			if (legacy.LegacyId == LegacyId)
			{
				return true;
			}
		}
		return false;
	}

	public static bool IsSpellExist(ReadOnlyRoleDataCS RoleData, int SpellId)
	{
		foreach (int spell in RoleData.Actor.Progress.SpellList)
		{
			if (spell == SpellId)
			{
				return true;
			}
		}
		return false;
	}

	public static bool IsTalentExist(ReadOnlyRoleDataCS RoleData, int TalentId)
	{
		foreach (ReadOnlyTalentOne talen in RoleData.Actor.Progress.TalenList)
		{
			if (talen.Id == TalentId)
			{
				return true;
			}
		}
		return false;
	}

	public static int GetAttrItemNum(ReadOnlyRoleDataCS RoleData, int ItemId)
	{
		foreach (ReadOnlyAttrItem attr in RoleData.Bag.AttrList)
		{
			if (attr.Id == ItemId)
			{
				return attr.Num;
			}
		}
		return 0;
	}

	public static void FillOssPlayerRoleInfoPb(ReadOnlyRoleData RoleData, PlayerInfoRole playerInfoRole, UObject WorldCtx)
	{
		foreach (ReadOnlyRoleItem item in RoleData.RoleCs.Bag.ItemList)
		{
			PlayerInfoRoleAddItem(playerInfoRole, item.ItemId, item.Num + item.StoreNum);
		}
		foreach (ReadOnlyRoleMoney money in RoleData.RoleCs.Bag.MoneyList)
		{
			PlayerInfoRoleAddItem(playerInfoRole, GameDBRuntime.GetSpiritItemId(money.MoneyType), (int)money.MoneyValue);
		}
		new Dictionary<int, int>();
		foreach (ReadOnlyRoleEquip equip in RoleData.RoleCs.Bag.EquipList)
		{
			PlayerInfoRoleAddItem(playerInfoRole, equip.EquipId, 1);
		}
		foreach (ReadOnlyAttrItem attr in RoleData.RoleCs.Bag.AttrList)
		{
			PlayerInfoRoleAddItem(playerInfoRole, attr.Id, attr.Num);
		}
		foreach (ReadOnlyRoleWine wine in RoleData.RoleCs.Bag.WineList)
		{
			PlayerInfoRoleAddItem(playerInfoRole, wine.WineId, 1);
		}
		PlayerInfoRoleAddItem(playerInfoRole, GameDBRuntime.GetItemIdByType(ItemType.TalentPoint), RoleData.RoleCs.Actor.Progress.TalenPoint);
		foreach (int spell in RoleData.RoleCs.Actor.Progress.SpellList)
		{
			PlayerInfoRoleAddItem(playerInfoRole, spell, 1);
		}
		foreach (ReadOnlyLegacyAbility legacy in RoleData.RoleCs.Actor.Progress.LegacyList)
		{
			PlayerInfoRoleAddItem(playerInfoRole, legacy.LegacyId, 1);
		}
		foreach (ReadOnlyRoleSoulSkill soulSkill in RoleData.RoleCs.Bag.SoulSkillList)
		{
			PlayerInfoRoleAddItem(playerInfoRole, soulSkill.SoulSkillId, 1);
		}
		int currentArchiveId = BGW_GameArchiveMgr.Get(WorldCtx).CurrentArchiveId;
		ArchiveSummaryData archiveSummaryInfo = BGW_GameArchiveMgr.Get(WorldCtx).GetArchiveSummaryInfo(currentArchiveId);
		if (archiveSummaryInfo != null)
		{
			playerInfoRole.Recs.Add(GenOssArchiveInfo(archiveSummaryInfo));
		}
	}

	public static RecLen GenOssArchiveInfo(ArchiveSummaryData ArchiveSummaryInfo)
	{
		return GenOssArchiveInfo((int)ArchiveSummaryInfo.GameTotalTime, ArchiveSummaryInfo.ArchiveUid, ArchiveSummaryInfo.DataSize / 1024, $"{ArchiveSummaryInfo.ReadArchiveResult}");
	}

	public static RecLen GenOssArchiveInfo(int GameTotalTime, string ArchiveUid, int FileSizeKb, string ArchiveStatus)
	{
		return new RecLen
		{
			PlayTime = GameTotalTime,
			ArchiveUid = ArchiveUid,
			FileSizeKb = FileSizeKb,
			ArchiveStatus = ArchiveStatus
		};
	}

	public static void FillOssPlayerRoleInfo(ReadOnlyRoleData RoleData, PlayerInfoRole playerInfoRole, UObject WorldCtx)
	{
		FillOssPlayerRoleInfoPb(RoleData, playerInfoRole, WorldCtx);
	}

	public static void FillOssPlayerWearInfoPb(ReadOnlyRoleData RoleData, PlayerInfoWear playerWearInfo)
	{
		foreach (ReadOnlyWearEquip equip2 in RoleData.RoleCs.Actor.Wear.EquipList)
		{
			if (equip2.Id != 0)
			{
				Equip equip = new Equip();
				equip.Pos = (int)equip2.Position;
				equip.Id = equip2.Id;
				playerWearInfo.Equips.Add(equip);
			}
		}
		foreach (ReadOnlySpellItem spell2 in RoleData.RoleCs.Actor.Wear.SpellList)
		{
			if (spell2.SpellId != 0)
			{
				Spell spell = new Spell();
				spell.Tp = (int)spell2.Type;
				spell.Id = spell2.SpellId;
				playerWearInfo.Spells.Add(spell);
			}
		}
		foreach (ReadOnlyShortcutItem shortcuts in RoleData.RoleCs.Actor.Wear.ShortcutsList)
		{
			if (shortcuts.ItemId == 0)
			{
				continue;
			}
			Item item = new Item();
			item.Id = shortcuts.ItemId;
			foreach (ReadOnlyRoleItem item2 in RoleData.RoleCs.Bag.ItemList)
			{
				if (item2.ItemId == item.Id)
				{
					item.Num = item2.Num;
					break;
				}
			}
			playerWearInfo.Items.Add(item);
		}
		foreach (ReadOnlyTalentOne talen in RoleData.RoleCs.Actor.Progress.TalenList)
		{
			playerWearInfo.Gens.Add(new Genius
			{
				Id = talen.Id,
				Level = talen.Level
			});
		}
		foreach (ReadOnlyLegacyAbility legacy2 in RoleData.RoleCs.Actor.Progress.LegacyList)
		{
			Legacy legacy = new Legacy
			{
				LegacyId = legacy2.LegacyId
			};
			foreach (ReadOnlyLegacyTalent talent in legacy2.TalentList)
			{
				if (talent.IsActive)
				{
					legacy.TalentIdList.Add(talent.TalentId);
				}
			}
			playerWearInfo.Legacies.Add(legacy);
		}
		if (playerWearInfo.Wine == null)
		{
			playerWearInfo.Wine = new Wine();
		}
		playerWearInfo.Wine.Id = RoleData.RoleCs.Actor.Wear.WineId;
		foreach (ReadOnlyRoleWine wine in RoleData.RoleCs.Bag.WineList)
		{
			if (wine.WineId != playerWearInfo.Wine.Id)
			{
				continue;
			}
			foreach (ReadOnlyWinePartner item3 in wine.ItemList)
			{
				playerWearInfo.Wine.WinePartnerList.Add(new WinePartnerSlot
				{
					SlotIndex = item3.Pos,
					Id = item3.ItemId
				});
			}
			break;
		}
		if (playerWearInfo.Accessory == null)
		{
			playerWearInfo.Accessory = new Accessory();
		}
		foreach (ReadOnlyAccessoryProp item4 in RoleData.RoleCs.Actor.Wear.WearAccessory.Accessorylist)
		{
			playerWearInfo.Accessory.AccessorySlot.Add(new AccessorySlot
			{
				Id = item4.Id,
				SlotIndex = item4.Pos
			});
		}
		playerWearInfo.SoulSkill = RoleData.RoleCs.Actor.Wear.WearSoulSkill.SoulSkillId;
	}

	public static void FillOssPlayerWearInfo(ReadOnlyRoleData RoleData, PlayerInfoWear playerWearInfo)
	{
		FillOssPlayerWearInfoPb(RoleData, playerWearInfo);
	}
}
