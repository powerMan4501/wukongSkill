using b1.EventDelDefine;
using CommB1;
using ResB1;
using UnrealEngine.Engine;

namespace b1;

public class FGuardCondition_TaskStage : FGuardConditionBase
{
	private int TaskStageID { get; set; }

	private QuestStage TaskStageStatus { get; set; }

	private BPS_GSEventCollection BPSEventCollection { get; set; }

	public override EGuardConditionType ConditionType => EGuardConditionType.TaskStage;

	protected override void Start()
	{
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(base.Owner);
		BPSEventCollection = BPS_EventCollectionCS.Get(firstLocalPlayerController);
		if (BPSEventCollection != null)
		{
			BPSEventCollection.Evt_ChangePlayerTaskStage += new Del_ChangePlayerTaskStage(OnChangePlayerTaskStage);
		}
		IBPC_PlayerRoleData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(firstLocalPlayerController);
		if (readOnlyData == null || readOnlyData.RoleData == null || readOnlyData.RoleData.RoleCs == null || readOnlyData.RoleData.RoleCs.Task == null || readOnlyData.RoleData.RoleCs.Task.QuestList == null)
		{
			return;
		}
		bool flag = false;
		foreach (ReadOnlyQuestStageOne quest in readOnlyData.RoleData.RoleCs.Task.QuestList)
		{
			if (quest.Id == TaskStageID)
			{
				flag = true;
				if (quest.Stage == TaskStageStatus)
				{
					base.QueryState = EQueryState.QuerySuccess;
				}
				break;
			}
		}
		if (!flag && TaskStageStatus == QuestStage.Default)
		{
			base.QueryState = EQueryState.QuerySuccess;
		}
	}

	protected override void OnPlayerControllerAttach()
	{
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(base.Owner);
		BPSEventCollection = BPS_EventCollectionCS.Get(firstLocalPlayerController);
		if (BPSEventCollection != null)
		{
			BPSEventCollection.Evt_ChangePlayerTaskStage += new Del_ChangePlayerTaskStage(OnChangePlayerTaskStage);
		}
	}

	protected override void Stop()
	{
		if (BPSEventCollection != null)
		{
			BPSEventCollection.Evt_ChangePlayerTaskStage -= new Del_ChangePlayerTaskStage(OnChangePlayerTaskStage);
		}
	}

	protected override void Clean()
	{
		TaskStageID = 0;
		TaskStageStatus = QuestStage.Default;
	}

	public override bool Initial(CalliopeCustom_TransitionCondition_Idle IdleCondition, PsmNodeInstance InPsmNodeInstance)
	{
		TaskStageID = InPsmNodeInstance.ParentInstance.ConvertParamID2IntParam(IdleCondition.TaskStageId);
		TaskStageStatus = (QuestStage)IdleCondition.TaskStageStatus;
		if (TaskStageStatus == QuestStage.Default)
		{
			TaskStageStatus = QuestStage.Finished;
		}
		return true;
	}

	public override bool Initial(CalliopeCustom_TransitionCondition_Group GroupCondition, PsmNodeInstance InPsmNodeInstance)
	{
		TaskStageID = InPsmNodeInstance.ParentInstance.ConvertParamID2IntParam(GroupCondition.TaskStageId);
		TaskStageStatus = (QuestStage)GroupCondition.TaskStageStatus;
		if (TaskStageStatus == QuestStage.Default)
		{
			TaskStageStatus = QuestStage.Finished;
		}
		return true;
	}

	public override bool Initial(CalliopeCustom_TransitionCondition_Guide GuideCondition, PsmNodeInstance InPsmNodeInstance)
	{
		TaskStageID = InPsmNodeInstance.ParentInstance.ConvertParamID2IntParam(GuideCondition.TaskStageId);
		TaskStageStatus = (QuestStage)GuideCondition.TaskStageStatus;
		if (TaskStageStatus == QuestStage.Default)
		{
			TaskStageStatus = QuestStage.Finished;
		}
		return true;
	}

	public override bool Initial(CalliopeCustom_TransitionCondition_State StateCondition)
	{
		TaskStageID = StateCondition.TaskStageId;
		TaskStageStatus = (QuestStage)StateCondition.TaskStageStatus;
		if (TaskStageStatus == QuestStage.Default)
		{
			TaskStageStatus = QuestStage.Finished;
		}
		return true;
	}

	private void OnChangePlayerTaskStage(int _TaskStageID, QuestStage Stage)
	{
		if (TaskStageID == _TaskStageID && TaskStageStatus == Stage)
		{
			base.QueryState = EQueryState.QuerySuccess;
		}
	}
}
