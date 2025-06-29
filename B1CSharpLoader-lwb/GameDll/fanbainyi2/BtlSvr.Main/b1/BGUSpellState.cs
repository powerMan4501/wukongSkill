using BtlShare;

namespace b1;

public class BGUSpellState
{
	public int SpellID;

	public float CDTimePercent;

	public bool IsLock;

	public bool IsDisable;

	public EAttrCostType AttrCostType1;

	public float CostValue1;

	public EAttrCostType AttrCostType2;

	public float CostValue2;

	public BGUSpellState()
	{
	}

	public BGUSpellState(int _SpellID)
	{
		SpellID = _SpellID;
	}

	public BGUSpellState(int SpellID, float InCDTimePercent, bool InLock, bool InDisable)
	{
		CDTimePercent = InCDTimePercent;
		IsLock = InLock;
		IsDisable = InDisable;
	}
}
