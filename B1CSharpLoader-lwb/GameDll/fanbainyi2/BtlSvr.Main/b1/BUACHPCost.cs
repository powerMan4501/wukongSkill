using BtlShare;
using UnrealEngine.Engine;

namespace b1;

public class BUACHPCost : BUAttrCostTemplate
{
	public override void DoCostAttrValue(AActor Owner, IBUC_AttrContainer AttrContainer, float AttrCostBase, float AttrCostRatio)
	{
		if (AttrContainer != null && !(Owner == null))
		{
			BUS_EventCollectionCS.Get(Owner).Evt_IncreaseAttrFloat.Invoke(EBGUAttrFloat.Hp, 0f - GetCostValue(AttrContainer, AttrCostBase, AttrCostRatio).Item2);
		}
	}

	public override bool IsAttrValueEnough(IBUC_AttrContainer AttrContainer, float AttrCostBase, float AttrCostRatio)
	{
		if (AttrContainer == null)
		{
			return false;
		}
		return AttrContainer.GetFloatValue(EBGUAttrFloat.Hp) >= GetCostValue(AttrContainer, AttrCostBase, AttrCostRatio).Item2;
	}

	public override (int, float) GetCostValue(IBUC_AttrContainer AttrContainer, float AttrCostBase, float AttrCostRatio)
	{
		if (AttrContainer == null)
		{
			return (0, 0f);
		}
		return (0, AttrCostBase + AttrCostRatio * AttrContainer.GetFloatValMax(EBGUAttrFloat.Hp));
	}
}
