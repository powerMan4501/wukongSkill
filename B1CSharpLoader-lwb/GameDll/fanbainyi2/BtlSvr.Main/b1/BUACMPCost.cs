using BtlShare;
using UnrealEngine.Engine;

namespace b1;

public class BUACMPCost : BUAttrCostTemplate
{
	public override void DoCostAttrValue(AActor Owner, IBUC_AttrContainer AttrContainer, float AttrCostBase, float AttrCostRatio)
	{
		if (AttrContainer != null && !(Owner == null))
		{
			IBUC_SimpleStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>(Owner);
			if (readOnlyData == null || !readOnlyData.HasSimpleState(EBGUSimpleState.LockMP))
			{
				BUS_EventCollectionCS.Get(Owner).Evt_IncreaseAttrFloat.Invoke(EBGUAttrFloat.Mp, 0f - GetCostValue(AttrContainer, AttrCostBase, AttrCostRatio).Item2);
			}
		}
	}

	public override bool IsAttrValueEnough(IBUC_AttrContainer AttrContainer, float AttrCostBase, float AttrCostRatio)
	{
		if (AttrContainer == null)
		{
			return false;
		}
		return AttrContainer.GetFloatValue(EBGUAttrFloat.Mp) >= GetCostValue(AttrContainer, AttrCostBase, AttrCostRatio).Item2;
	}

	public override (int, float) GetCostValue(IBUC_AttrContainer AttrContainer, float AttrCostBase, float AttrCostRatio)
	{
		if (AttrContainer == null)
		{
			return (0, 0f);
		}
		return (0, AttrCostBase + AttrCostRatio * AttrContainer.GetFloatValMax(EBGUAttrFloat.Mp));
	}
}
