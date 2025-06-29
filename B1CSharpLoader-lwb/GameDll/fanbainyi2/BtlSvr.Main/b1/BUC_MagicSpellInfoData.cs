using System.Collections.Generic;
using b1.ECS;
using BtlShare;

namespace b1;

public class BUC_MagicSpellInfoData : IBUC_MagicSpellInfoData, IPersistentECSData
{
	public List<BGUSpellState> SpellStateList { get; set; } = new List<BGUSpellState>();

	public List<BGUSpellState> AllSpellStateList { get; set; } = new List<BGUSpellState>();

	public bool GetMagicSpellInfo(int SpellID, out bool IsLock, out bool IsDisable, out float CDTimePercent)
	{
		BGUSpellState bGUSpellState = SpellStateList.Find((BGUSpellState State) => State.SpellID == SpellID);
		IsLock = false;
		IsDisable = false;
		CDTimePercent = -1f;
		if (bGUSpellState != null && bGUSpellState.SpellID != 0)
		{
			IsLock = bGUSpellState.IsLock;
			IsDisable = bGUSpellState.IsDisable;
			CDTimePercent = bGUSpellState.CDTimePercent;
			return true;
		}
		return false;
	}

	public bool GetAllMagicSpellInfo(int SpellID, out bool IsLock, out bool IsDisable, out float CDTimePercent)
	{
		BGUSpellState bGUSpellState = AllSpellStateList.Find((BGUSpellState State) => State.SpellID == SpellID);
		IsLock = false;
		IsDisable = false;
		CDTimePercent = -1f;
		if (bGUSpellState != null && bGUSpellState.SpellID != 0)
		{
			IsLock = bGUSpellState.IsLock;
			IsDisable = bGUSpellState.IsDisable;
			CDTimePercent = bGUSpellState.CDTimePercent;
			return true;
		}
		return false;
	}

	public bool GetAllMagicSpellCost(int SpellID, out EAttrCostType AttrCostType1, out float CostValue1, out EAttrCostType AttrCostType2, out float CostValue2)
	{
		BGUSpellState bGUSpellState = AllSpellStateList.Find((BGUSpellState State) => State.SpellID == SpellID);
		AttrCostType1 = EAttrCostType.None;
		CostValue1 = 0f;
		AttrCostType2 = EAttrCostType.None;
		CostValue2 = 0f;
		if (bGUSpellState != null && bGUSpellState.SpellID != 0)
		{
			AttrCostType1 = bGUSpellState.AttrCostType1;
			CostValue1 = bGUSpellState.CostValue1;
			AttrCostType2 = bGUSpellState.AttrCostType2;
			CostValue2 = bGUSpellState.CostValue2;
			return true;
		}
		return false;
	}
}
