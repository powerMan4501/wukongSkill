using CommB1;
using CsB1;
using Diana.Common;
using Google.Protobuf;
using ResB1;

namespace b1;

public class TaskNodeInstance_PushTaskStage : QuestNodeInstance
{
	private TaskCustom_PushTaskStageState CustomData { get; set; }

	protected override void PostCreate()
	{
		CustomData = new TaskCustom_PushTaskStageState();
		CustomData.MergeFrom(base.Node.NodeData);
		base.ParentInstance.ReferenceTaskStageList.Add(CustomData.TaskStageId);
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		DoPushTaskStage(CustomData.TaskStageId, CustomData.IsPushToEnd);
	}

	public override byte[] GetNodeCustomData()
	{
		return new byte[0];
	}

	public override void SetNodeCustomData(byte[] CustomData)
	{
	}

	public override void RecoverActiveState()
	{
		DoPushTaskStage(CustomData.TaskStageId, CustomData.IsPushToEnd);
	}

	private void DoPushTaskStage(int TaskStageID, bool IsPushToEnd)
	{
		ABGUCharacter PlayerCharacter = UGSE_EngineFuncLib.GetFirstLocalPlayerController(base.Owner)?.GetControlledPawn() as ABGUCharacter;
		BTF_EventCollectionCS bTF_EventCollectionCS = BTF_EventCollectionCS.Get(PlayerCharacter?.PlayerState);
		if (bTF_EventCollectionCS == null)
		{
			return;
		}
		QuestStage TargetStageState = ((!IsPushToEnd) ? QuestStage.Activated : QuestStage.Finished);
		bTF_EventCollectionCS.Evt_TaskChangeQuestStageReq(new CSMsgTaskChangeQuestStageReq
		{
			QuestId = TaskStageID,
			QuestStage = TargetStageState
		}, delegate(MsgErrCode ErrCode, CSMsgTaskChangeQuestStageReq Req, CSMsgTaskChangeQuestStageRes Res)
		{
			bool flag = false;
			if (ErrCode == MsgErrCode.ErrSuccess)
			{
				IBPC_PlayerRoleData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(UGSE_EngineFuncLib.GetFirstLocalPlayerController(base.Owner));
				if (readOnlyData?.RoleData?.RoleCs?.Task?.QuestList != null)
				{
					foreach (ReadOnlyQuestStageOne quest in readOnlyData.RoleData.RoleCs.Task.QuestList)
					{
						if (quest.Id == TaskStageID && quest.Stage >= TargetStageState)
						{
							flag = true;
							break;
						}
					}
				}
			}
			else if (TaskStageID != 2004601)
			{
				GSEUtil.Ensure(Condition: false, $"推进任务阶段{TaskStageID}:{TargetStageState}失败，RPC返回错误码:{ErrCode}");
			}
			if (flag)
			{
				BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(base.Owner);
				if (bGW_EventCollection != null)
				{
					bGW_EventCollection.Evt_PushTaskStageStateSuccess(TaskStageID, TargetStageState);
					BGW_GameArchiveMgr.Get(base.Owner).MarkSaveArchive(EArchiveSaveSource.PushTaskStageSuccess, $"推进任务阶段 {TaskStageID} -> {TargetStageState}");
					if (DebugConfig.IsOpenBattleInfoTool)
					{
						BGUFunctionLibraryCS.LogBattleInfo(PlayerCharacter, EBattleInfoType.TaskStage, $"<character>【任务阶段】</><effect>任务阶段推进，任务阶段ID是：</><action>{TaskStageID}</><effect>，推进的状态是：</><action>{TargetStageState}</>");
					}
				}
			}
			else if (TaskStageID != 2004601)
			{
				GSEUtil.Ensure(Condition: false, $"推进任务阶段{TaskStageID}:{TargetStageState}失败，角色数据不符合预期");
			}
			TriggerFirstOutput(bFinish: true);
		});
	}
}
