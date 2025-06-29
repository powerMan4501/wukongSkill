using System.Collections.Generic;
using System.Linq;
using ArchiveB1;
using b1.AutoQA;
using BtlB1;
using BtlShare;
using CommB1;
using Google.Protobuf.Collections;
using ResB1;
using UnrealEngine.Runtime;

namespace b1;

public static class RoleAttrHelper
{
	public static void FillEquipAttrDescAttrList(EffectAttrDict AttrDict, EquipAttrDesc equipAttrDesc, List<EBGUAttrFloat> BlackList)
	{
		AttrDict.AddAttrCfgList(equipAttrDesc.Attr, BlackList);
	}

	private static void FillEquipEffectAttr(EffectAttrDict AttrDict, int effectAttrId, List<EBGUAttrFloat> BlackList = null)
	{
		if (effectAttrId > 0)
		{
			EquipAttrDesc equipAttrDesc = GameDBRuntime.GetEquipAttrDesc(effectAttrId);
			if (equipAttrDesc != null)
			{
				FillEquipAttrDescAttrList(AttrDict, equipAttrDesc, BlackList);
			}
		}
	}

	private static void FillRoleEquipAttr(EffectAttrDict AttrDict, RoleEquip equip)
	{
		EquipDesc equipDesc = GameDBRuntime.GetEquipDesc(equip.EquipId);
		if (equipDesc != null)
		{
			FillEquipEffectAttr(AttrDict, equipDesc.AttrEffectId);
		}
	}

	private static void FillRoleTalentAttr(EffectAttrDict AttrDict, TalentOne talentOne, List<EBGUAttrFloat> BlackList)
	{
		TalentLevelUpCfg talentLevelUpCfg = GameDBRuntime.GetTalentLevelUpCfg(talentOne.Id, talentOne.Level);
		if (talentLevelUpCfg != null && talentLevelUpCfg.AttrEffectId > 0)
		{
			FillEquipEffectAttr(AttrDict, talentLevelUpCfg.AttrEffectId, BlackList);
		}
	}

	private static void FillRoleAttrItemAttr(EffectAttrDict AttrDict, AttrItem attrItem, List<EBGUAttrFloat> BlackList)
	{
		if (attrItem.Num < 1)
		{
			return;
		}
		AttrItemDesc attrItemDesc = GameDBRuntime.GetAttrItemDesc(attrItem.Id);
		if (attrItemDesc == null)
		{
			return;
		}
		foreach (EffectAttrCfg attr in attrItemDesc.Attrs)
		{
			EffectAttrCfg effectAttrCfg = attr.Clone();
			if (BlackList == null || !BlackList.Contains(effectAttrCfg.Type))
			{
				effectAttrCfg.Value *= attrItem.Num;
				AttrDict.AddAttrCfg(effectAttrCfg);
			}
		}
	}

	private static void FillRoleSoulSkillAttr(EffectAttrDict AttrDict, int SoulSkillId)
	{
		SoulSkillDesc soulSkillDesc = GameDBRuntime.GetSoulSkillDesc(SoulSkillId);
		if (soulSkillDesc != null && soulSkillDesc.AttrEffectId > 0)
		{
			FillEquipEffectAttr(AttrDict, soulSkillDesc.AttrEffectId);
		}
	}

	private static void FillEquipSuitAttr(EffectAttrDict AttrDict, List<RoleEquip> equipList)
	{
		Dictionary<int, int> suitDict = CalcEquipSuitList(equipList);
		foreach (FUStSuitInfo item in GetSuitInfo(suitDict))
		{
			if (item.AttrEffectID > 0)
			{
				FillEquipEffectAttr(AttrDict, item.AttrEffectID);
			}
		}
		foreach (int item2 in CalRedSuitIdList(suitDict, equipList))
		{
			FUStSuitDesc suitDesc = BGW_GameDB.GetSuitDesc(item2);
			if (suitDesc != null && suitDesc.RedQualityInfo.AttrEffectID > 0)
			{
				FillEquipEffectAttr(AttrDict, suitDesc.RedQualityInfo.AttrEffectID);
			}
		}
	}

	private static void FillRoleEquipListAttr(EffectAttrDict AttrDict, List<RoleEquip> equipList)
	{
		foreach (RoleEquip equip in equipList)
		{
			FillRoleEquipAttr(AttrDict, equip);
		}
		FillEquipSuitAttr(AttrDict, equipList);
	}

	private static void FillRoleTalentListAttr(int CurrentResId, EffectAttrDict AttrDict, List<TalentOne> talentList, List<int> WearSpell, List<EBGUAttrFloat> BlackList)
	{
		foreach (TalentOne talent in talentList)
		{
			if ((!GameDBRuntime.IsSpellOnlyTalent(talent.Id, out var SpellId) || WearSpell.Contains(SpellId)) && GameDBRuntime.IsTalentEffectiveForUnit(talent.Id, CurrentResId))
			{
				FillRoleTalentAttr(AttrDict, talent, BlackList);
			}
		}
	}

	public static RoleEquip FindBagEquipByUid(RoleBag roleBag, ulong Uid)
	{
		for (int i = 0; i < roleBag.EquipList.Count; i++)
		{
			if (roleBag.EquipList[i].Uid == Uid)
			{
				return roleBag.EquipList[i];
			}
		}
		return null;
	}

	public static void FillRoleAttrCalcParam(RoleAttrParam param, RoleDataCS roleDataCS)
	{
		foreach (AttrItem attr in roleDataCS.Bag.AttrList)
		{
			param.AddAttrItem(attr);
		}
		foreach (WearEquip equip in roleDataCS.Actor.Wear.EquipList)
		{
			if (equip.Id > 0)
			{
				RoleEquip roleEquip = FindBagEquipByUid(roleDataCS.Bag, equip.Uid);
				if (roleEquip != null)
				{
					param.AddEquip(roleEquip);
				}
			}
		}
		foreach (AccessoryProp item in roleDataCS.Actor.Wear.WearAccessory.Accessorylist)
		{
			RoleEquip roleEquip2 = FindBagEquipByUid(roleDataCS.Bag, item.Uid);
			if (roleEquip2 != null)
			{
				param.AddEquip(roleEquip2);
			}
		}
		for (int i = 0; i < roleDataCS.Actor.Progress.TalenList.Count; i++)
		{
			param.AddTalentList(roleDataCS.Actor.Progress.TalenList[i]);
		}
		foreach (SpellItem spell in roleDataCS.Actor.Wear.SpellList)
		{
			if (spell.SpellId > 0)
			{
				param.AddSpellId(spell.SpellId);
			}
		}
		if (roleDataCS.Actor.Wear.WearSoulSkill.SoulSkillId > 0)
		{
			param.SetWearSoulSkill(roleDataCS.Actor.Wear.WearSoulSkill.SoulSkillId);
		}
	}

	public static EffectAttrList CalcEquipAttrByAttrId(int AttrId)
	{
		EffectAttrDict effectAttrDict = new EffectAttrDict();
		FillEquipEffectAttr(effectAttrDict, AttrId);
		return effectAttrDict.Export();
	}

	public static Dictionary<int, int> CalcEquipSuitList(List<int> equipIdList)
	{
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		foreach (int equipId in equipIdList)
		{
			if (equipId == 0)
			{
				continue;
			}
			EquipDesc equipDesc = GameDBRuntime.GetEquipDesc(equipId);
			if (equipDesc != null && equipDesc.SuitId != 0)
			{
				if (dictionary.ContainsKey(equipDesc.SuitId))
				{
					dictionary[equipDesc.SuitId]++;
				}
				else
				{
					dictionary[equipDesc.SuitId] = 1;
				}
			}
		}
		return dictionary;
	}

	public static Dictionary<int, int> CalcEquipSuitList(List<RoleEquip> equipList)
	{
		List<int> list = new List<int>();
		foreach (RoleEquip equip in equipList)
		{
			list.Add(equip.EquipId);
		}
		return CalcEquipSuitList(list);
	}

	public static Dictionary<int, int> CalcEquipSuitList(RepeatedField<WearEquip> equipList)
	{
		List<int> list = new List<int>();
		foreach (WearEquip equip in equipList)
		{
			list.Add(equip.Id);
		}
		return CalcEquipSuitList(list);
	}

	public static List<FUStSuitInfo> GetSuitInfo(Dictionary<int, int> suitDict)
	{
		List<FUStSuitInfo> list = new List<FUStSuitInfo>();
		foreach (KeyValuePair<int, int> item in suitDict)
		{
			int key = item.Key;
			int value = item.Value;
			FUStSuitDesc suitDesc = BGW_GameDB.GetSuitDesc(key);
			if (suitDesc == null)
			{
				continue;
			}
			foreach (FUStSuitInfo item2 in suitDesc.SuitInfo)
			{
				if (value >= item2.TriggerNum)
				{
					list.Add(item2);
				}
			}
		}
		return list;
	}

	public static List<int> CalRedSuitIdList(Dictionary<int, int> SuitDict, List<int> EquipList)
	{
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, int> item in SuitDict)
		{
			List<int> redQualityEquipIdListBySuitId = GameDBRuntime.GetRedQualityEquipIdListBySuitId(item.Key);
			if (redQualityEquipIdListBySuitId.Count != item.Value)
			{
				continue;
			}
			bool flag = true;
			foreach (int SuitEquipId in redQualityEquipIdListBySuitId)
			{
				if (!EquipList.Any((int EquipId) => EquipId == SuitEquipId))
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				list.Add(item.Key);
			}
		}
		return list;
	}

	public static List<int> CalRedSuitIdList(Dictionary<int, int> SuitDict, List<RoleEquip> equipList)
	{
		List<int> list = new List<int>();
		foreach (RoleEquip equip in equipList)
		{
			list.Add(equip.EquipId);
		}
		return CalRedSuitIdList(SuitDict, list);
	}

	public static List<int> CalRedSuitIdList(Dictionary<int, int> SuitDict, RepeatedField<WearEquip> equipList)
	{
		List<int> list = new List<int>();
		foreach (WearEquip equip in equipList)
		{
			list.Add(equip.Id);
		}
		return CalRedSuitIdList(SuitDict, list);
	}

	public static Dictionary<int, int> CalcEquipSuitTalentList(List<RoleEquip> equipList)
	{
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		foreach (RoleEquip equip in equipList)
		{
			EquipDesc equipDesc = GameDBRuntime.GetEquipDesc(equip.EquipId);
			if (equipDesc == null)
			{
				continue;
			}
			int equipEffectId = equipDesc.EquipEffectId;
			if (equipEffectId > 0)
			{
				if (!dictionary.ContainsKey(equipEffectId))
				{
					dictionary[equipEffectId] = 1;
				}
				else if (equipDesc.EquipPosition == EquipPosition.Accessory)
				{
					dictionary[equipEffectId]++;
				}
			}
		}
		Dictionary<int, int> suitDict = CalcEquipSuitList(equipList);
		foreach (FUStSuitInfo item in GetSuitInfo(suitDict))
		{
			if (item.SuitEffectID > 0 && !dictionary.ContainsKey(item.SuitEffectID))
			{
				dictionary[item.SuitEffectID] = 1;
			}
		}
		foreach (int item2 in CalRedSuitIdList(suitDict, equipList))
		{
			FUStSuitDesc suitDesc = BGW_GameDB.GetSuitDesc(item2);
			if (suitDesc != null && suitDesc.RedQualityInfo.TalentID != 0 && !dictionary.ContainsKey(suitDesc.RedQualityInfo.TalentID))
			{
				dictionary[suitDesc.RedQualityInfo.TalentID] = 1;
			}
		}
		return dictionary;
	}

	public static void FillRoleExtAttr(UObject WorldContext, int CurrentResId, EffectAttrDict AttrDict, RoleAttrParam param)
	{
		if (WorldContext.IsNullOrDestroyed())
		{
			return;
		}
		List<EBGUAttrFloat> list = new List<EBGUAttrFloat>();
		if (B1Global.GIsBossRushMode)
		{
			IBIC_BossRushData gameInstanceReadonlyData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_BossRushData, BIC_BossRushData>(WorldContext);
			if (gameInstanceReadonlyData != null && (gameInstanceReadonlyData.BossRushType == EBossRushType.BossIterations || gameInstanceReadonlyData.BossRushType == EBossRushType.IterationsPractise))
			{
				foreach (int debuff in gameInstanceReadonlyData.BossRushBattleData.DebuffList)
				{
					BossRushDebuffDesc bossRushDebuffDesc = GameDBRuntime.GetBossRushDebuffDesc(debuff);
					if (bossRushDebuffDesc == null)
					{
						continue;
					}
					Dictionary<int, float> bossRushAttrOverrides = BGW_GameDB.GetBossRushAttrOverrides(bossRushDebuffDesc.DebuffId);
					if (bossRushAttrOverrides == null)
					{
						continue;
					}
					foreach (KeyValuePair<int, float> item in bossRushAttrOverrides)
					{
						ListExtensions.AddUnique(list, (EBGUAttrFloat)item.Key);
					}
				}
			}
		}
		FillRoleEquipListAttr(AttrDict, param.GetEquipList());
		foreach (AttrItem attrItem in param.GetAttrItemList())
		{
			FillRoleAttrItemAttr(AttrDict, attrItem, list);
		}
		FillRoleTalentListAttr(CurrentResId, AttrDict, param.GetTalentList(), param.GetSpellList(), list);
		if (param.GetWearSoulSkillId() > 0)
		{
			FillRoleSoulSkillAttr(AttrDict, param.GetWearSoulSkillId());
		}
	}
}
