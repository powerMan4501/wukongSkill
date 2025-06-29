using ArchiveB1;
using CommB1;
using Google.Protobuf;
using Google.Protobuf.Collections;
using ResB1;
using UnrealEngine.Engine;

namespace b1;

public class TaskNodeInstance_QueryCompoundCondition : QuestNodeInstance
{
	private TaskCustom_QueryCompoundCondition CustomData { get; set; }

	private IBIC_TaskData TaskData { get; set; }

	protected override void PostCreate()
	{
		CustomData = new TaskCustom_QueryCompoundCondition();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		if (CheckConditions())
		{
			TriggerOutput(BGW_FlowUtils.PinName.Success.PlainName, bFinish: true);
		}
		else
		{
			TriggerOutput(BGW_FlowUtils.PinName.Failed.PlainName, bFinish: true);
		}
	}

	private bool CheckConditions()
	{
		LogicRelationType conditionRelationType = CustomData.ConditionRelationType;
		bool flag = conditionRelationType == LogicRelationType.LogicRelationAnd;
		RepeatedField<OneQueryCompoundConditionInfo> conditionInfoList = CustomData.ConditionInfoList;
		TaskData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_TaskData, BIC_TaskData>(base.Owner);
		foreach (OneQueryCompoundConditionInfo item in conditionInfoList)
		{
			bool flag2 = true;
			switch (item.ConditionType)
			{
			case QueryCompoundConditionType.QueryTaskStageInfo:
				flag2 = CheckTaskStageCondition(item.QueryTaskStageInfo);
				break;
			case QueryCompoundConditionType.QueryInteraRecordInfo:
				flag2 = CheckQueryInteraRecordInfo(item.QueryInteractionRecordInfo);
				break;
			case QueryCompoundConditionType.QueryUnitInfo:
				flag2 = CheckUnitStatusCondition(item.QueryUnitStatusInfo);
				break;
			case QueryCompoundConditionType.QueryOwningItemInfo:
				flag2 = CheckOwningItemCondition(item.QueryOwningItemInfo);
				break;
			}
			flag2 = (item.IsReverseCondition ? (!flag2) : flag2);
			if (conditionRelationType == LogicRelationType.LogicRelationAnd)
			{
				if (!flag2)
				{
					flag = false;
					break;
				}
			}
			else if (flag2)
			{
				flag = true;
				break;
			}
		}
		if (!CustomData.IsReverseCondition)
		{
			return flag;
		}
		return !flag;
	}

	private bool CheckTaskStageCondition(QuestStageOne QueryTaskStageInfo)
	{
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(base.Owner);
		APawn aPawn = firstLocalPlayerController?.GetControlledPawn();
		if (aPawn != null && aPawn.PlayerState != null)
		{
			IBPC_PlayerRoleData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(firstLocalPlayerController);
			if (readOnlyData != null && readOnlyData.RoleData != null && readOnlyData.RoleData.RoleCs != null && readOnlyData.RoleData.RoleCs.Task != null)
			{
				foreach (ReadOnlyQuestStageOne quest in readOnlyData.RoleData.RoleCs.Task.QuestList)
				{
					int id = quest.Id;
					QuestStage stage = quest.Stage;
					if (QueryTaskStageInfo.Id == id && QueryTaskStageInfo.Stage == stage)
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	private bool CheckQueryInteraRecordInfo(InteractionRecordInfo QueryInteractionRecordInfo)
	{
		if (TaskData != null)
		{
			foreach (InteractionRecordData interactionRecord in TaskData.GetInteractionRecordList())
			{
				int interactGroupId = interactionRecord.InteractGroupId;
				int interactStep = interactionRecord.InteractStep;
				if (QueryInteractionRecordInfo.InteractionGroupId == interactGroupId && QueryInteractionRecordInfo.InteractionStep <= interactStep)
				{
					return true;
				}
			}
		}
		return false;
	}

	private bool CheckOwningItemCondition(OwningItemInfo QueryOwningItemInfo)
	{
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(base.Owner);
		APawn aPawn = firstLocalPlayerController?.GetControlledPawn();
		if (aPawn != null && aPawn.PlayerState != null && RoleDataHelper.GetBagItemNum(BGU_DataUtil.GetReadOnlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(firstLocalPlayerController), QueryOwningItemInfo.ItemId) >= QueryOwningItemInfo.Num)
		{
			return true;
		}
		return false;
	}

	private bool CheckUnitStatusCondition(UnitStatusInfo QueryUnitStatusInfo)
	{
		return false;
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
		if (CheckConditions())
		{
			TriggerOutput(BGW_FlowUtils.PinName.Success.PlainName, bFinish: true);
		}
		else
		{
			TriggerOutput(BGW_FlowUtils.PinName.Failed.PlainName, bFinish: true);
		}
	}
}
