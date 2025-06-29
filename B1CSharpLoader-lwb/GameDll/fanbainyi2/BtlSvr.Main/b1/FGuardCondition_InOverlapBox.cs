using CommB1;

namespace b1;

public class FGuardCondition_InOverlapBox : FGuardConditionBase
{
	private string OverlapGuid { get; set; }

	private IBIC_TaskData TaskData { get; set; }

	public override EGuardConditionType ConditionType => EGuardConditionType.InOverlapBox;

	protected override void Clean()
	{
		OverlapGuid = "";
	}

	public override bool Initial(CalliopeCustom_TransitionCondition_Idle IdleCondition, PsmNodeInstance InPsmNodeInstance)
	{
		OverlapGuid = InPsmNodeInstance.ParentInstance.ConvertParamID2StringParam(IdleCondition.OverlapGuid);
		return true;
	}

	public override bool Initial(CalliopeCustom_TransitionCondition_Battle BattleCondition, PsmNodeInstance InPsmNodeInstance)
	{
		OverlapGuid = InPsmNodeInstance.ParentInstance.ConvertParamID2StringParam(BattleCondition.OverlapGuid);
		return true;
	}

	public override bool Initial(CalliopeCustom_TransitionCondition_Group GroupCondition, PsmNodeInstance InPsmNodeInstance)
	{
		OverlapGuid = InPsmNodeInstance.ParentInstance.ConvertParamID2StringParam(GroupCondition.OverlapGuid);
		return true;
	}

	public override bool Initial(CalliopeCustom_TransitionCondition_Guide GuideCondition, PsmNodeInstance InPsmNodeInstance)
	{
		OverlapGuid = InPsmNodeInstance.ParentInstance.ConvertParamID2StringParam(GuideCondition.OverlapGuid);
		return true;
	}

	protected override void Start()
	{
		TaskData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_TaskData, BIC_TaskData>(base.Owner);
	}

	protected override void OnTick(float DeltaTime)
	{
		if (TaskData != null && TaskData.IsPlayerInOverlap(OverlapGuid, out var bInnerOverlap))
		{
			if (bInnerOverlap)
			{
				base.QueryState = EQueryState.QuerySuccess;
			}
			else
			{
				base.QueryState = EQueryState.QueryFailure;
			}
		}
	}
}
