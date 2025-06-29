using CommB1;

namespace b1;

public class FGuardCondition_FinishGuideGroup : FGuardConditionBase
{
	public override EGuardConditionType ConditionType => EGuardConditionType.FinishGuideGroup;

	private int GuideGroupId { get; set; }

	public override bool Initial(CalliopeCustom_TransitionCondition_Guide GuideCondition, PsmNodeInstance InPsmNodeInstance)
	{
		GuideGroupId = GuideCondition.GuideGroupId;
		return true;
	}

	protected override void OnTick(float DeltaTime)
	{
		if (FGuardConditionBase.CommonData.PlayerGuideData.IsGroupGuideCompleted(GuideGroupId))
		{
			base.QueryState = EQueryState.QuerySuccess;
		}
	}

	protected override void Clean()
	{
	}
}
