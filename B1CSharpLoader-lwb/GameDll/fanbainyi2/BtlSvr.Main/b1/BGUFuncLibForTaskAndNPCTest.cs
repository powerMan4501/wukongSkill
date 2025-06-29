using System.Text;
using BtlB1;
using CommB1;
using CsB1;
using Diana.Common;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public static class BGUFuncLibForTaskAndNPCTest
{
	private static readonly string TASK_STAGE_STATE_Default = "未激活";

	private static readonly string TASK_STAGE_STATE_Active = "激活未完成";

	private static readonly string TASK_STAGE_STATE_Finish = "已完成";

	public static void TryPushTaskStageStateForTest(UObject WorldContext, int TaskStageID, int IsPushToEnd)
	{
		if (BGW_GameDB.GetTaskStageDesc(TaskStageID) == null)
		{
			return;
		}
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext);
		APawn Player = firstLocalPlayerController?.GetControlledPawn();
		if (!(Player != null) || !(Player.PlayerState != null))
		{
			return;
		}
		IBPC_PlayerRoleData PlayerRoleData = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(firstLocalPlayerController);
		if (PlayerRoleData == null || PlayerRoleData.RoleData == null || PlayerRoleData.RoleData.RoleCs == null || PlayerRoleData.RoleData.RoleCs.Task == null)
		{
			return;
		}
		bool flag = true;
		QuestStage TargetStageState = ((IsPushToEnd != 1) ? QuestStage.Activated : QuestStage.Finished);
		if (GetExistTaskStageState(TaskStageID, PlayerRoleData.RoleData.RoleCs.Task.QuestList, out var Result))
		{
			if (Result == QuestStage.Finished)
			{
				flag = false;
			}
			else if (IsPushToEnd == 0)
			{
				switch (Result)
				{
				case QuestStage.Default:
					TargetStageState = QuestStage.Activated;
					break;
				case QuestStage.Activated:
					TargetStageState = QuestStage.Finished;
					break;
				}
			}
		}
		if (!flag)
		{
			return;
		}
		BTF_EventCollectionCS.Get((Player as ABGUCharacter).PlayerState)?.Evt_TaskChangeQuestStageReq(new CSMsgTaskChangeQuestStageReq
		{
			QuestId = TaskStageID,
			QuestStage = TargetStageState
		}, delegate(MsgErrCode ErrCode, CSMsgTaskChangeQuestStageReq Req, CSMsgTaskChangeQuestStageRes Res)
		{
			bool flag2 = false;
			if (ErrCode == MsgErrCode.ErrSuccess)
			{
				APlayerController firstLocalPlayerController2 = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext);
				PlayerRoleData = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(firstLocalPlayerController2);
				if (PlayerRoleData != null && PlayerRoleData.RoleData != null && PlayerRoleData.RoleData.RoleCs != null && PlayerRoleData.RoleData.RoleCs.Task != null && PlayerRoleData.RoleData.RoleCs.Task.QuestList != null)
				{
					foreach (ReadOnlyQuestStageOne quest in PlayerRoleData.RoleData.RoleCs.Task.QuestList)
					{
						if (quest.Id == TaskStageID && quest.Stage == TargetStageState)
						{
							flag2 = true;
							break;
						}
					}
				}
			}
			if (flag2)
			{
				BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(WorldContext);
				if (bGW_EventCollection != null)
				{
					flag2 = true;
					bGW_EventCollection.Evt_PushTaskStageStateSuccess(TaskStageID, TargetStageState);
					if (DebugConfig.IsOpenBattleInfoTool)
					{
						Player = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext)?.GetControlledPawn();
						if (Player != null)
						{
							BGUFunctionLibraryCS.LogBattleInfo(Player, EBattleInfoType.TaskStage, $"<character>【GM任务阶段】</><effect>任务阶段推进，任务阶段ID是：</><action>{TaskStageID}</><effect>，推进的状态是：</><action>{TargetStageState}</>");
						}
					}
				}
			}
		});
	}

	public static void ShowTaskStageState(UObject WorldContext, int TaskLineID = 0)
	{
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext);
		APawn aPawn = firstLocalPlayerController?.GetControlledPawn();
		if (!(aPawn != null) || !(aPawn.PlayerState != null))
		{
			return;
		}
		IBPC_PlayerRoleData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(firstLocalPlayerController);
		if (readOnlyData == null || readOnlyData.RoleData == null || readOnlyData.RoleData.RoleCs == null || readOnlyData.RoleData.RoleCs.Task == null)
		{
			return;
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("[ShowTaskState]");
		stringBuilder.AppendLine("[ShowTaskState]=================打印任务阶段状态——Begin=================");
		bool flag = true;
		if (TaskLineID != 0)
		{
			stringBuilder.AppendLine($"[ShowTaskState]指定任务线ID = {TaskLineID}");
			if (BGW_GameDB.GetTaskLineDesc(TaskLineID) == null)
			{
				flag = false;
				stringBuilder.AppendLine("[ShowTaskState]任务线不存在！！！");
			}
		}
		else
		{
			stringBuilder.AppendLine("[ShowTaskState]全部任务线");
		}
		if (flag)
		{
			foreach (ReadOnlyQuestStageOne quest in readOnlyData.RoleData.RoleCs.Task.QuestList)
			{
				string text = "错误的任务阶段ID！！！";
				FUStTaskStageDesc taskStageDesc = BGW_GameDB.GetTaskStageDesc(quest.Id);
				if (taskStageDesc != null)
				{
					text = taskStageDesc.Describe;
				}
				if (TaskLineID <= 0 || (taskStageDesc != null && TaskLineID == taskStageDesc.BelongsToLineID))
				{
					string text2 = ((quest.Stage == QuestStage.Default) ? TASK_STAGE_STATE_Default : ((quest.Stage == QuestStage.Activated) ? TASK_STAGE_STATE_Active : TASK_STAGE_STATE_Finish));
					stringBuilder.AppendLine($"[ShowTaskState]阶段ID = {quest.Id}, 描述 = {text}, 归属任务线ID = {taskStageDesc.BelongsToLineID}, 状态 = {text2}");
				}
			}
		}
		stringBuilder.AppendLine("[ShowTaskState]=================打印任务阶段状态——End=================");
	}

	public static bool GetExistTaskStageState(int TaskStageID, ReadOnlyQuestStageOneList TaskStageList, out QuestStage Result)
	{
		Result = QuestStage.Activated;
		bool result = false;
		foreach (ReadOnlyQuestStageOne TaskStage in TaskStageList)
		{
			if (TaskStage.Id == TaskStageID)
			{
				Result = TaskStage.Stage;
				result = true;
				break;
			}
		}
		return result;
	}
}
