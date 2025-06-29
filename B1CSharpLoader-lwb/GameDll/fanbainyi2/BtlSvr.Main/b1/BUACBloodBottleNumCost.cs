using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUACBloodBottleNumCost : BUAttrCostTemplate
{
	public override void DoCostAttrValue(AActor Owner, IBUC_AttrContainer AttrContainer, float AttrCostBase, float AttrCostRatio)
	{
		if (!(Owner == null) && AttrContainer != null)
		{
			int item = GetCostValue(AttrContainer, AttrCostBase, AttrCostRatio).Item1;
			if (AttrContainer.GetFloatValue(EBGUAttrFloat.BloodBottomNum) - (float)item < 0f)
			{
				BUS_EventCollectionCS.Get(Owner).Evt_DrinkHpBottomFailed.Invoke();
			}
			else
			{
				BUS_EventCollectionCS.Get(Owner).Evt_IncreaseAttrFloat.Invoke(EBGUAttrFloat.BloodBottomNum, -item);
			}
			if (item > 0)
			{
				BGUFunctionLibraryCS.TriggerGuideNodeFinishEvent(Owner, EGuideNodeFinishType.DrinkBloodBottle);
			}
		}
	}

	public override bool IsAttrValueEnough(IBUC_AttrContainer AttrContainer, float AttrCostBase, float AttrCostRatio)
	{
		if (AttrContainer == null)
		{
			return false;
		}
		return AttrContainer.GetFloatValue(EBGUAttrFloat.BloodBottomNum) >= (float)GetCostValue(AttrContainer, AttrCostBase, AttrCostRatio).Item1;
	}

	public override (int, float) GetCostValue(IBUC_AttrContainer AttrContainer, float AttrCostBase, float AttrCostRatio)
	{
		if (AttrContainer == null)
		{
			return (0, 0f);
		}
		return (FMath.FloorToInt(AttrCostBase + AttrCostRatio * AttrContainer.GetFloatValMax(EBGUAttrFloat.BloodBottomNumMax)), 0f);
	}
}
