using BtlShare;
using UnrealEngine.Engine;

namespace b1;

public class BUACStaminaCost : BUAttrCostTemplate
{
	public override void DoCostAttrValue(AActor Owner, IBUC_AttrContainer AttrContainer, float AttrCostBase, float AttrCostRatio)
	{
		if (!(Owner == null) && AttrContainer != null)
		{
			IBUC_StaminaData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_StaminaData, BUC_StaminaData>(Owner);
			IBUC_SimpleStateData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>(Owner);
			if (readOnlyData != null && readOnlyData2 != null && !readOnlyData2.HasSimpleState(EBGUSimpleState.StaminaLock))
			{
				BUS_EventCollectionCS.Get(Owner).Evt_IncreaseAttrFloat.Invoke(EBGUAttrFloat.Stamina, 0f - GetCostValue(AttrContainer, AttrCostBase, AttrCostRatio).Item2);
			}
		}
	}

	public override bool IsAttrValueEnough(IBUC_AttrContainer AttrContainer, float AttrCostBase, float AttrCostRatio)
	{
		if (AttrContainer == null)
		{
			return false;
		}
		return AttrContainer.GetFloatValue(EBGUAttrFloat.Stamina) >= GetCostValue(AttrContainer, AttrCostBase, AttrCostRatio).Item2;
	}

	public override (int, float) GetCostValue(IBUC_AttrContainer AttrContainer, float AttrCostBase, float AttrCostRatio)
	{
		if (AttrContainer == null)
		{
			return (0, 0f);
		}
		float num = AttrCostBase + AttrCostRatio * AttrContainer.GetFloatValMax(EBGUAttrFloat.Stamina);
		num *= AttrContainer.GetFloatValue(EBGUAttrFloat.StaminaCostMultiper);
		return (0, num);
	}
}
