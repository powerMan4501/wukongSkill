using BtlShare;
using CommB1;
using UnrealEngine.Runtime;

namespace b1;

public class FGuardCondition_PlayerAttr : FGuardConditionBase
{
	private FDetectConditionForCheck DetectCondition;

	public override EGuardConditionType ConditionType => EGuardConditionType.PlayerAttr;

	protected override void Clean()
	{
		DetectCondition = null;
	}

	public override bool Initial(CalliopeCustom_TransitionCondition_Guide GuideCondition, PsmNodeInstance InPsmNodeInstance)
	{
		DetectCondition = new FDetectConditionForCheck((EBGUAttrFloat)GuideCondition.AttrFloatType, (EValueCompareOperations)GuideCondition.CompareOperation, GuideCondition.CompareValue, GuideCondition.IsReverseCondition);
		return true;
	}

	protected override void OnTick(float DeltaTime)
	{
		if (!FGuardConditionBase.CommonData.PlayerPawn.IsNullOrDestroyed() && FGuardConditionBase.CommonData.PlayerCheckData != null && FGuardConditionBase.CommonData.PlayerCheckData.CheckDetectCondition(DetectCondition))
		{
			base.QueryState = EQueryState.QuerySuccess;
		}
	}
}
