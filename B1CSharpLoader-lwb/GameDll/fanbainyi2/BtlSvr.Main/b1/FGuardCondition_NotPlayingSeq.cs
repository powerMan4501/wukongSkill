using CommB1;

namespace b1;

public class FGuardCondition_NotPlayingSeq : FGuardConditionBase
{
	public override EGuardConditionType ConditionType => EGuardConditionType.NotPlayingSeq;

	protected override void Clean()
	{
	}

	public override bool Initial(CalliopeCustom_CompositeTransitionCondition_Guide GuideCondition, PsmNodeInstance InPsmNodeInstance)
	{
		return true;
	}

	protected override void OnTick(float DeltaTime)
	{
		if (FGuardConditionBase.CommonData.MovieData == null || !FGuardConditionBase.CommonData.MovieData.IsPlaying())
		{
			base.QueryState = EQueryState.QuerySuccess;
		}
	}
}
