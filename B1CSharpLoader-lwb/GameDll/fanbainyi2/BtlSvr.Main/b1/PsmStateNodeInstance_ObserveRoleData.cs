using System;
using System.Collections.Generic;
using ArchiveB1;
using b1.EventDelDefine;
using CommB1;
using Google.Protobuf;
using ResB1;
using UnrealEngine.Engine;

namespace b1;

public class PsmStateNodeInstance_ObserveRoleData : PsmStateNodeInstance, IObserveNodeInstanceForTask
{
	public override string NodeClass => "Process.State.ObserveRoleData";

	private TaskCustom_ObserveRoleData CustomData { get; set; }

	private IBIC_TaskData TaskData { get; set; }

	private int ObserveMinSuccessConditionNum { get; set; }

	private Dictionary<int, OneObserveRoleDataInfo> ObserveRoleDataInfoDic { get; } = new Dictionary<int, OneObserveRoleDataInfo>();

	private bool bEnableObserving { get; set; }

	private int SuccessCount { get; set; }

	private List<int> SuccessIndexList { get; } = new List<int>();

	private Dictionary<int, int> ComsumdItemRecordDic { get; } = new Dictionary<int, int>();

	public override void PostCreate()
	{
		CustomData = new TaskCustom_ObserveRoleData();
		CustomData.MergeFrom(base.Node.NodeData);
		ObserveRoleDataInfoDic.Clear();
		ObserveMinSuccessConditionNum = CustomData.ObserveMinSuccessConditionNum;
		foreach (OneObserveRoleDataInfo observeInfo in CustomData.ObserveInfoList)
		{
			if (!ObserveRoleDataInfoDic.TryGetValue(observeInfo.Index, out var _))
			{
				ObserveRoleDataInfoDic.Add(observeInfo.Index, observeInfo);
			}
		}
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		if (InputPin.Equals(BGW_FlowUtils.PinName.Enable.PlainName))
		{
			StartObserving();
			TriggerOutput(BGW_FlowUtils.PinName.Enabled.PlainName, bFinish: false);
		}
		else if (InputPin.Equals(BGW_FlowUtils.PinName.Disable.PlainName))
		{
			TriggerOutput(BGW_FlowUtils.PinName.Disabled.PlainName, bFinish: true);
		}
	}

	private void StartObserving()
	{
		bEnableObserving = true;
		TaskData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_TaskData, BIC_TaskData>(GetOwner());
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(GetOwner());
		bGW_EventCollection.Evt_TaskGraphNotifyGraph_ItemChange = (BGW_EventCollection.Del_BGW_Void_TaskGraphNotifyGraph_ItemChange)Delegate.Combine(bGW_EventCollection.Evt_TaskGraphNotifyGraph_ItemChange, new BGW_EventCollection.Del_BGW_Void_TaskGraphNotifyGraph_ItemChange(OnNotifyGraph_ItemChange));
		bGW_EventCollection.Evt_TaskGraphNotifyGraph_TaskStage = (BGW_EventCollection.Del_BGW_Void_TaskGraphNotifyGraph_TaskStage)Delegate.Combine(bGW_EventCollection.Evt_TaskGraphNotifyGraph_TaskStage, new BGW_EventCollection.Del_BGW_Void_TaskGraphNotifyGraph_TaskStage(OnNotifyGraph_TaskStage));
		bGW_EventCollection.Evt_BGW_InteractGroup_Complete = (Del_Void_IntInt)Delegate.Combine(bGW_EventCollection.Evt_BGW_InteractGroup_Complete, new Del_Void_IntInt(OnNotifyGraph_Interaction));
		InitItemInfo();
		CheckConditionSuccessInStartObserve();
	}

	private void StopObserving()
	{
		bEnableObserving = false;
		SuccessCount = 0;
		SuccessIndexList.Clear();
		ComsumdItemRecordDic.Clear();
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(GetOwner());
		bGW_EventCollection.Evt_TaskGraphNotifyGraph_ItemChange = (BGW_EventCollection.Del_BGW_Void_TaskGraphNotifyGraph_ItemChange)Delegate.Remove(bGW_EventCollection.Evt_TaskGraphNotifyGraph_ItemChange, new BGW_EventCollection.Del_BGW_Void_TaskGraphNotifyGraph_ItemChange(OnNotifyGraph_ItemChange));
		bGW_EventCollection.Evt_TaskGraphNotifyGraph_TaskStage = (BGW_EventCollection.Del_BGW_Void_TaskGraphNotifyGraph_TaskStage)Delegate.Remove(bGW_EventCollection.Evt_TaskGraphNotifyGraph_TaskStage, new BGW_EventCollection.Del_BGW_Void_TaskGraphNotifyGraph_TaskStage(OnNotifyGraph_TaskStage));
		bGW_EventCollection.Evt_BGW_InteractGroup_Complete = (Del_Void_IntInt)Delegate.Remove(bGW_EventCollection.Evt_BGW_InteractGroup_Complete, new Del_Void_IntInt(OnNotifyGraph_Interaction));
	}

	protected override void Finish()
	{
		StopObserving();
		base.Finish();
	}

	private void InitItemInfo()
	{
		if (ComsumdItemRecordDic.Count != 0)
		{
			return;
		}
		foreach (KeyValuePair<int, OneObserveRoleDataInfo> item in ObserveRoleDataInfoDic)
		{
			OneObserveRoleDataInfo value = item.Value;
			if (value.ObserveType == ObserveRoleDataType.ObserveConsumedItem)
			{
				int num = value.ObserveComsumedItemInfo?.ItemId ?? 0;
				if (num != 0 && !ComsumdItemRecordDic.TryGetValue(num, out var _))
				{
					ComsumdItemRecordDic.Add(num, 0);
				}
			}
		}
	}

	private void HandleConditionSuccess(int SuccessIdx)
	{
		SuccessCount++;
		SuccessIndexList.Add(SuccessIdx);
		if (SuccessCount >= ObserveMinSuccessConditionNum)
		{
			TriggerOutput(BGW_FlowUtils.PinName.Success.PlainName, bFinish: true);
		}
	}

	private void CheckConditionSuccessInStartObserve()
	{
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(GetOwner());
		APawn aPawn = firstLocalPlayerController?.GetControlledPawn();
		if (!(aPawn != null) || !(aPawn.PlayerState != null))
		{
			return;
		}
		IBPC_PlayerRoleData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(firstLocalPlayerController);
		if (readOnlyData == null || readOnlyData.RoleData == null || readOnlyData.RoleData.RoleCs == null)
		{
			return;
		}
		foreach (KeyValuePair<int, OneObserveRoleDataInfo> item in ObserveRoleDataInfoDic)
		{
			int key = item.Key;
			OneObserveRoleDataInfo value = item.Value;
			if (SuccessIndexList.Contains(key))
			{
				continue;
			}
			if (bEnableObserving && value.ObserveType == ObserveRoleDataType.ObserveTaskStage && readOnlyData.RoleData.RoleCs.Task != null)
			{
				foreach (ReadOnlyQuestStageOne quest in readOnlyData.RoleData.RoleCs.Task.QuestList)
				{
					if (value.ObserveTaskStageInfo.Id == quest.Id && value.ObserveTaskStageInfo.Stage == quest.Stage)
					{
						HandleConditionSuccess(key);
						break;
					}
				}
			}
			if (bEnableObserving && value.ObserveType == ObserveRoleDataType.ObserveOwningItem && readOnlyData.RoleData.RoleCs != null && RoleDataHelper.GetBagItemNum(readOnlyData, value.ObserveOwningItemInfo.ItemId) >= value.ObserveOwningItemInfo.Num)
			{
				HandleConditionSuccess(key);
			}
			if (bEnableObserving && value.ObserveType == ObserveRoleDataType.ObserveInteractionRecord && TaskData != null)
			{
				List<InteractionRecordData> interactionRecordList = TaskData.GetInteractionRecordList();
				if (interactionRecordList != null)
				{
					foreach (InteractionRecordData item2 in interactionRecordList)
					{
						if (value.ObserveInteractionRecordInfo.InteractionGroupId == item2.InteractGroupId && value.ObserveInteractionRecordInfo.InteractionStep == item2.InteractStep)
						{
							HandleConditionSuccess(key);
							break;
						}
					}
				}
			}
			if (bEnableObserving && value.ObserveType == ObserveRoleDataType.ObserveOwningHulu && RoleDataHelper.GetBagEquipNumByEquipId(readOnlyData.RoleData.RoleCs, value.ObserveOwningItemInfo.ItemId) > 0)
			{
				HandleConditionSuccess(key);
			}
			if (!bEnableObserving || value.ObserveType != ObserveRoleDataType.ObserveCollection || readOnlyData.RoleData.RoleCs == null)
			{
				continue;
			}
			int commLogicCfgValue = GameDBRuntime.GetCommLogicCfgValue(CommCfgType.YuanShouChengCardId);
			foreach (ReadOnlyMonsterCollection monsterCollection in readOnlyData.RoleData.RoleCs.Collection.MonsterCollectionList)
			{
				if (monsterCollection.Id == commLogicCfgValue)
				{
					HandleConditionSuccess(key);
					break;
				}
			}
		}
	}

	public void OnNotifyGraph_ItemChange(int ItemID, int OldNum, int NewNum)
	{
		if (!bEnableObserving)
		{
			return;
		}
		foreach (KeyValuePair<int, OneObserveRoleDataInfo> item in ObserveRoleDataInfoDic)
		{
			int key = item.Key;
			OneObserveRoleDataInfo value = item.Value;
			if (SuccessIndexList.Contains(key))
			{
				continue;
			}
			if (bEnableObserving && value.ObserveType == ObserveRoleDataType.ObserveOwningItem)
			{
				OwningItemInfo observeOwningItemInfo = value.ObserveOwningItemInfo;
				if (observeOwningItemInfo != null && observeOwningItemInfo.ItemId == ItemID && NewNum >= observeOwningItemInfo.Num)
				{
					HandleConditionSuccess(key);
					break;
				}
			}
			if (!bEnableObserving || value.ObserveType != ObserveRoleDataType.ObserveConsumedItem)
			{
				continue;
			}
			ConsumedItemInfo observeComsumedItemInfo = value.ObserveComsumedItemInfo;
			if (observeComsumedItemInfo == null)
			{
				continue;
			}
			int itemId = observeComsumedItemInfo.ItemId;
			if (!ComsumdItemRecordDic.TryGetValue(itemId, out var value2))
			{
				continue;
			}
			int num = NewNum - OldNum;
			if (num > 0)
			{
				value2 = num + value2;
				ComsumdItemRecordDic[itemId] = value2;
				if (value2 >= observeComsumedItemInfo.Num)
				{
					HandleConditionSuccess(key);
					break;
				}
			}
		}
	}

	public void OnNotifyGraph_TaskStage(int TaskStageID, QuestStage StageState)
	{
		if (!bEnableObserving)
		{
			return;
		}
		foreach (KeyValuePair<int, OneObserveRoleDataInfo> item in ObserveRoleDataInfoDic)
		{
			int key = item.Key;
			OneObserveRoleDataInfo value = item.Value;
			if (!SuccessIndexList.Contains(key) && bEnableObserving && value.ObserveType == ObserveRoleDataType.ObserveTaskStage)
			{
				int id = value.ObserveTaskStageInfo.Id;
				QuestStage stage = value.ObserveTaskStageInfo.Stage;
				if (TaskStageID == id && StageState == stage)
				{
					HandleConditionSuccess(key);
					break;
				}
			}
		}
	}

	public void OnNotifyGraph_Interaction(int InteractionGroupID, int InteractionStep)
	{
		if (!bEnableObserving)
		{
			return;
		}
		foreach (KeyValuePair<int, OneObserveRoleDataInfo> item in ObserveRoleDataInfoDic)
		{
			if (!bEnableObserving)
			{
				break;
			}
			int key = item.Key;
			OneObserveRoleDataInfo value = item.Value;
			if (!SuccessIndexList.Contains(key) && bEnableObserving && value.ObserveType == ObserveRoleDataType.ObserveInteractionRecord)
			{
				int interactionGroupId = value.ObserveInteractionRecordInfo.InteractionGroupId;
				int interactionStep = value.ObserveInteractionRecordInfo.InteractionStep;
				if (InteractionGroupID == interactionGroupId && InteractionStep == interactionStep)
				{
					HandleConditionSuccess(key);
					break;
				}
			}
		}
	}

	public void OnNotifyGraph_GainHulu(int ItemID)
	{
		if (!bEnableObserving)
		{
			return;
		}
		IBPC_PlayerRoleData iBPC_PlayerRoleData = null;
		foreach (KeyValuePair<int, OneObserveRoleDataInfo> item in ObserveRoleDataInfoDic)
		{
			int key = item.Key;
			OneObserveRoleDataInfo value = item.Value;
			if (SuccessIndexList.Contains(key) || !bEnableObserving || value.ObserveType != ObserveRoleDataType.ObserveOwningHulu)
			{
				continue;
			}
			OwningItemInfo observeOwningItemInfo = value.ObserveOwningItemInfo;
			if (observeOwningItemInfo == null || observeOwningItemInfo.ItemId != ItemID)
			{
				continue;
			}
			if (iBPC_PlayerRoleData == null)
			{
				APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(GetOwner());
				APawn aPawn = firstLocalPlayerController?.GetControlledPawn();
				if (aPawn != null && aPawn.PlayerState != null)
				{
					iBPC_PlayerRoleData = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(firstLocalPlayerController);
				}
			}
			if (iBPC_PlayerRoleData != null && iBPC_PlayerRoleData.RoleData != null && iBPC_PlayerRoleData.RoleData.RoleCs != null && RoleDataHelper.GetBagEquipNumByEquipId(iBPC_PlayerRoleData.RoleData.RoleCs, ItemID) > 0)
			{
				HandleConditionSuccess(key);
			}
			break;
		}
	}

	public void OnNotifyGraph_MonsterColletion()
	{
		if (!bEnableObserving)
		{
			return;
		}
		foreach (KeyValuePair<int, OneObserveRoleDataInfo> item in ObserveRoleDataInfoDic)
		{
			int key = item.Key;
			OneObserveRoleDataInfo value = item.Value;
			if (!SuccessIndexList.Contains(key) && bEnableObserving && value.ObserveType == ObserveRoleDataType.ObserveCollection)
			{
				HandleConditionSuccess(key);
			}
		}
	}
}
