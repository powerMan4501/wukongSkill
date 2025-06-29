using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUACSpecialEnergyCost : BUAttrCostTemplate
{
	public override void DoCostAttrValue(AActor Owner, IBUC_AttrContainer AttrContainer, float AttrCostBase, float AttrCostRatio)
	{
		if (!(Owner == null) && AttrContainer != null)
		{
			int item = GetCostValue(AttrContainer, AttrCostBase, AttrCostRatio).Item1;
			if (AttrContainer.GetFloatValue(EBGUAttrFloat.SpecialEnergy) >= (float)item)
			{
				BUS_EventCollectionCS.Get(Owner).Evt_IncreaseAttrFloat.Invoke(EBGUAttrFloat.SpecialEnergy, -item);
			}
		}
	}

	public override bool IsAttrValueEnough(IBUC_AttrContainer AttrContainer, float AttrCostBase, float AttrCostRatio)
	{
		if (AttrContainer == null)
		{
			return false;
		}
		return AttrContainer.GetFloatValue(EBGUAttrFloat.SpecialEnergy) >= (float)GetCostValue(AttrContainer, AttrCostBase, AttrCostRatio).Item1;
	}

	public override (int, float) GetCostValue(IBUC_AttrContainer AttrContainer, float AttrCostBase, float AttrCostRatio)
	{
		if (AttrContainer == null)
		{
			return (0, 0f);
		}
		return (0, FMath.FloorToInt(AttrCostBase + AttrCostRatio * AttrContainer.GetFloatValMax(EBGUAttrFloat.SpecialEnergyMax)));
	}
}
