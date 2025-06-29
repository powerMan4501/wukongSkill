using CommB1;

namespace b1;

public class FGuardCondition_CheckTimeInOverlap : FGuardConditionBase
{
	private string OverlapGuid { get; set; }

	private float Timer_InArea { get; set; }

	public float InBox_Remaining { get; set; }

	private IBIC_TaskData TaskData { get; set; }

	public override EGuardConditionType ConditionType => EGuardConditionType.CheckTimeInOverlap;

	protected override void Clean()
	{
		OverlapGuid = "";
		Timer_InArea = 0f;
	}

	public override bool Initial(CalliopeCustom_TransitionCondition_Idle IdleCondition, PsmNodeInstance InPsmNodeInstance)
	{
		OverlapGuid = InPsmNodeInstance.ParentInstance.ConvertParamID2StringParam(IdleCondition.OverlapGuid);
		Timer_InArea = IdleCondition.InAreaTimer;
		return true;
	}

	protected override void Start()
	{
		TaskData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_TaskData, BIC_TaskData>(base.Owner);
		InBox_Remaining = Timer_InArea;
	}

	protected override void OnTick(float DeltaTime)
	{
		if (TaskData != null && TaskData.IsPlayerInOverlap(OverlapGuid, out var bInnerOverlap) && bInnerOverlap)
		{
			InBox_Remaining -= DeltaTime;
			if (InBox_Remaining < 0f)
			{
				base.QueryState = EQueryState.QuerySuccess;
			}
		}
	}
}
