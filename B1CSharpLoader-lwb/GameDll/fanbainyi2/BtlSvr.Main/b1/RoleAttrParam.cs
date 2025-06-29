using System.Collections.Generic;
using ArchiveB1;

namespace b1;

public class RoleAttrParam
{
	private List<RoleEquip> equipList = new List<RoleEquip>();

	private List<AttrItem> attrItemList = new List<AttrItem>();

	private List<TalentOne> talentList = new List<TalentOne>();

	private List<int> wearSpellList = new List<int>();

	private int WearSoulSkillId;

	public List<RoleEquip> GetEquipList()
	{
		return equipList;
	}

	public void ClearEquipList()
	{
		equipList.Clear();
	}

	public List<AttrItem> GetAttrItemList()
	{
		return attrItemList;
	}

	public List<TalentOne> GetTalentList()
	{
		return talentList;
	}

	public List<int> GetSpellList()
	{
		return wearSpellList;
	}

	public int GetWearSoulSkillId()
	{
		return WearSoulSkillId;
	}

	public RoleAttrParam Clone()
	{
		RoleAttrParam roleAttrParam = new RoleAttrParam();
		roleAttrParam.equipList.AddRange(equipList);
		roleAttrParam.attrItemList.AddRange(attrItemList);
		roleAttrParam.talentList.AddRange(talentList);
		roleAttrParam.wearSpellList.AddRange(wearSpellList);
		roleAttrParam.WearSoulSkillId = WearSoulSkillId;
		return roleAttrParam;
	}

	public void AddEquip(RoleEquip equip)
	{
		equipList.Add(equip.Clone());
	}

	public void AddTalentList(TalentOne talentOne)
	{
		talentList.Add(talentOne.Clone());
	}

	public void AddAttrItem(AttrItem attrItem)
	{
		attrItemList.Add(attrItem.Clone());
	}

	public void AddSpellId(int spellId)
	{
		wearSpellList.Add(spellId);
	}

	public void SetWearSoulSkill(int soulSkillId)
	{
		WearSoulSkillId = soulSkillId;
	}
}
