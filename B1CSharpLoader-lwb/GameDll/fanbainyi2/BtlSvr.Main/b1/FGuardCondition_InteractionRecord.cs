using System.Collections.Generic;
using ArchiveB1;
using CommB1;

namespace b1;

public class FGuardCondition_InteractionRecord : FGuardConditionBase
{
	private int InteractionGroupID { get; set; }

	private int InteractionStep { get; set; }

	private IBIC_TaskData TaskData { get; set; }

	public override EGuardConditionType ConditionType => EGuardConditionType.InteractionRecord;

	protected override void Clean()
	{
		InteractionGroupID = 0;
		InteractionStep = 0;
	}

	public override bool Initial(CalliopeCustom_TransitionCondition_Idle IdleCondition, PsmNodeInstance InPsmNodeInstance)
	{
		InteractionGroupID = IdleCondition.InteractGroupId;
		InteractionStep = IdleCondition.InteractStep;
		return true;
	}

	protected override void Start()
	{
		TaskData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_TaskData, BIC_TaskData>(base.Owner);
	}

	protected override void OnTick(float DeltaTime)
	{
		List<InteractionRecordData> list = TaskData?.GetInteractionRecordList();
		if (list == null)
		{
			return;
		}
		foreach (InteractionRecordData item in list)
		{
			if (InteractionGroupID == item.InteractGroupId && InteractionStep <= item.InteractStep)
			{
				base.QueryState = EQueryState.QuerySuccess;
				break;
			}
		}
	}
}
