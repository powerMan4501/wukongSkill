using CommB1;
using GurCalliopeState;

namespace b1;

public class FGuardCondition_CompositeOr : FGuardConditionBase
{
	public override EGuardConditionType ConditionType => EGuardConditionType.CompositeOr;

	protected override void Clean()
	{
	}

	public override bool Initial(CalliopeCustom_CompositeTransitionCondition_Battle BattleCondition, PsmNodeInstance InPsmNodeInstance)
	{
		if (BattleCondition.ConditionalRelation != 1)
		{
			return false;
		}
		foreach (CalliopeCustom_TransitionCondition_Battle condition in BattleCondition.Conditions)
		{
			base.SubConditions.Add(FGuardConditionFactory.New(condition, InPsmNodeInstance));
		}
		return true;
	}

	public override bool Initial(CalliopeCustom_CompositeTransitionCondition_Idle IdleCondition, PsmNodeInstance InPsmNodeInstance)
	{
		if (IdleCondition.ConditionalRelation != 1)
		{
			return false;
		}
		foreach (CalliopeCustom_TransitionCondition_Idle condition in IdleCondition.Conditions)
		{
			base.SubConditions.Add(FGuardConditionFactory.New(condition, InPsmNodeInstance));
		}
		return true;
	}

	public override bool Initial(CalliopeCustom_CompositeTransitionCondition_Group GroupCondition, PsmNodeInstance InPsmNodeInstance)
	{
		if (GroupCondition.ConditionalRelation != 1)
		{
			return false;
		}
		foreach (CalliopeCustom_TransitionCondition_Group condition in GroupCondition.Conditions)
		{
			base.SubConditions.Add(FGuardConditionFactory.New(condition, InPsmNodeInstance));
		}
		return true;
	}

	public override bool Initial(CalliopeCustom_CompositeTransitionCondition_Guide GuideCondition, PsmNodeInstance InPsmNodeInstance)
	{
		if (GuideCondition.ConditionalRelation != 1)
		{
			return false;
		}
		foreach (CalliopeCustom_TransitionCondition_Guide condition in GuideCondition.Conditions)
		{
			base.SubConditions.Add(FGuardConditionFactory.New(condition, InPsmNodeInstance));
		}
		return true;
	}

	public override bool Initial(CalliopeCustom_DetectUnitCondition DetectUnitCondition)
	{
		if (DetectUnitCondition.ConditionalRelation != 1)
		{
			return false;
		}
		foreach (CalliopeCustom_DetectCondition condition in DetectUnitCondition.Conditions)
		{
			base.SubConditions.Add(FGuardConditionFactory.New((EDetectedUnitType)DetectUnitCondition.UnitType, DetectUnitCondition.SmartUnitGuid, condition));
		}
		return true;
	}

	public override bool TryQuickFinishCondition()
	{
		foreach (FGuardConditionBase subCondition in base.SubConditions)
		{
			if (subCondition.TryQuickFinishCondition())
			{
				return true;
			}
		}
		return false;
	}
}
