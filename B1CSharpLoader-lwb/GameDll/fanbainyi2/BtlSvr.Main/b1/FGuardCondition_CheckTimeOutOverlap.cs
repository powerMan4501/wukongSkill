using CommB1;

namespace b1;

public class FGuardCondition_CheckTimeOutOverlap : FGuardConditionBase
{
	private string OverlapGuid { get; set; }

	private float Timer_OutArea { get; set; }

	public float OutBox_Remaining { get; set; }

	private IBIC_TaskData TaskData { get; set; }

	public override EGuardConditionType ConditionType => EGuardConditionType.CheckTimeOutOverlap;

	protected override void Clean()
	{
		OverlapGuid = "";
		Timer_OutArea = 0f;
	}

	public override bool Initial(CalliopeCustom_TransitionCondition_Idle IdleCondition, PsmNodeInstance InPsmNodeInstance)
	{
		OverlapGuid = InPsmNodeInstance.ParentInstance.ConvertParamID2StringParam(IdleCondition.OverlapGuid);
		Timer_OutArea = IdleCondition.OutAreaTimer;
		return true;
	}

	protected override void Start()
	{
		TaskData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_TaskData, BIC_TaskData>(base.Owner);
		OutBox_Remaining = Timer_OutArea;
	}

	protected override void OnTick(float DeltaTime)
	{
		if (TaskData != null && TaskData.IsPlayerInOverlap(OverlapGuid, out var bInnerOverlap) && !bInnerOverlap)
		{
			OutBox_Remaining -= DeltaTime;
			if (OutBox_Remaining < 0f)
			{
				base.QueryState = EQueryState.QuerySuccess;
			}
		}
	}
}
