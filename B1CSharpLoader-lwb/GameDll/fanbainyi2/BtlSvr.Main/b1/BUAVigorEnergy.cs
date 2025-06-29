using BtlShare;
using UnrealEngine.Engine;

namespace b1;

public class BUAVigorEnergy : BUAttrCostTemplate
{
	public override void DoCostAttrValue(AActor Owner, IBUC_AttrContainer AttrContainer, float AttrCostBase, float AttrCostRatio)
	{
		if (Owner == null || AttrContainer == null)
		{
			return;
		}
		IBUC_SimpleStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>(Owner);
		if (readOnlyData != null)
		{
			float item = GetCostValue(AttrContainer, AttrCostBase, AttrCostRatio).Item2;
			if ((!readOnlyData.HasSimpleState(EBGUSimpleState.VigorEnergyLock) || !(item > 0f)) && (!readOnlyData.HasSimpleState(EBGUSimpleState.CantGainVigorEnergy) || !(item < 0f)))
			{
				BUS_EventCollectionCS.Get(Owner).Evt_IncreaseAttrFloat.Invoke(EBGUAttrFloat.VigorEnergy, 0f - item);
			}
		}
	}

	public override bool IsAttrValueEnough(IBUC_AttrContainer AttrContainer, float AttrCostBase, float AttrCostRatio)
	{
		if (AttrContainer == null)
		{
			return false;
		}
		return AttrContainer.GetFloatValue(EBGUAttrFloat.VigorEnergy) >= GetCostValue(AttrContainer, AttrCostBase, AttrCostRatio).Item2;
	}

	public override (int, float) GetCostValue(IBUC_AttrContainer AttrContainer, float AttrCostBase, float AttrCostRatio)
	{
		if (AttrContainer == null)
		{
			return (0, 0f);
		}
		return (0, AttrCostBase + AttrCostRatio * AttrContainer.GetFloatValMax(EBGUAttrFloat.VigorEnergy));
	}
}
