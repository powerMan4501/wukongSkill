using CommB1;

namespace b1;

public class FGuardCondition_CurrentMap : FGuardConditionBase
{
	private int TargetMapId;

	public override EGuardConditionType ConditionType => EGuardConditionType.CurrentMap;

	protected override void Clean()
	{
	}

	public override bool Initial(CalliopeCustom_TransitionCondition_Guide GuideCondition, PsmNodeInstance InPsmNodeInstance)
	{
		TargetMapId = GuideCondition.MapId;
		return true;
	}

	protected override void OnTick(float DeltaTime)
	{
		int curLevelId = BGUFuncLibMap.GetCurLevelId(base.Owner);
		base.QueryState = ((TargetMapId == curLevelId) ? EQueryState.QuerySuccess : EQueryState.Querying);
	}
}
