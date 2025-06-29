using System;
using System.Collections.Generic;
using ArchiveB1;
using CommB1;
using Google.Protobuf;
using ResB1;
using UnrealEngine.Engine;

namespace b1;

public class TaskNodeInstance_ObserveRoleData : QuestNodeInstance, IObserveNodeInstanceForTask
{
	private TaskCustom_ObserveRoleData CustomData { get; set; }

	private IBIC_TaskData TaskData { get; set; }

	private int ObserveMinSuccessConditionNum { get; set; }

	private Dictionary<int, OneObserveRoleDataInfo> ObserveRoleDataInfoDic { get; } = new Dictionary<int, OneObserveRoleDataInfo>();

	private bool bEnableObserving { get; set; }

	private int SuccessCount { get; set; }

	private List<int> SuccessIndexList { get; } = new List<int>();

	private Dictionary<int, int> ComsumdItemRecordDic { get; } = new Dictionary<int, int>();

	protected override void PostCreate()
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

	public override byte[] GetNodeCustomData()
	{
		List<byte> list = new List<byte>();
		list.AddRange(BitConverter.GetBytes(SuccessCount));
		list.AddRange(BitConverter.GetBytes(SuccessIndexList.Count));
		foreach (int successIndex in SuccessIndexList)
		{
			list.AddRange(BitConverter.GetBytes(successIndex));
		}
		list.AddRange(BitConverter.GetBytes(ComsumdItemRecordDic.Count));
		foreach (KeyValuePair<int, int> item in ComsumdItemRecordDic)
		{
			int key = item.Key;
			int value = item.Value;
			list.AddRange(BitConverter.GetBytes(key));
			list.AddRange(BitConverter.GetBytes(value));
		}
		return list.ToArray();
	}

	public override void SetNodeCustomData(byte[] CustomData)
	{
		SuccessCount = 0;
		SuccessIndexList.Clear();
		int num = 0;
		SuccessCount = BitConverter.ToInt32(CustomData, num);
		num += 4;
		int num2 = BitConverter.ToInt32(CustomData, num);
		num += 4;
		for (int i = 0; i < num2; i++)
		{
			int item = BitConverter.ToInt32(CustomData, num);
			num += 4;
			SuccessIndexList.Add(item);
		}
		int num3 = BitConverter.ToInt32(CustomData, num);
		num += 4;
		for (int j = 0; j < num3; j++)
		{
			int key = BitConverter.ToInt32(CustomData, num);
			num += 4;
			int value = BitConverter.ToInt32(CustomData, num);
			num += 4;
			if (!ComsumdItemRecordDic.TryGetValue(key, out var _))
			{
				ComsumdItemRecordDic.Add(key, value);
			}
		}
	}

	public override void RecoverActiveState()
	{
		StartObserving();
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
		TaskData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_TaskData, BIC_TaskData>(base.Owner);
		BGW_EventCollection.Get(base.Owner).Evt_TaskGraphStartObserveForTask(this);
		InitItemInfo();
		CheckConditionSuccessInStartObserve();
	}

	private void StopObserving()
	{
		BGW_EventCollection.Get(base.Owner).Evt_TaskGraphStopObserveForTask(this);
		bEnableObserving = false;
		SuccessCount = 0;
		SuccessIndexList.Clear();
		ComsumdItemRecordDic.Clear();
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
		MarkNodeArchiveDataDirty();
	}

	private void CheckConditionSuccessInStartObserve()
	{
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(base.Owner);
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
						if (value.ObserveInteractionRecordInfo.InteractionGroupId == item2.InteractGroupId && value.ObserveInteractionRecordInfo.InteractionStep >= item2.InteractStep)
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
				MarkNodeArchiveDataDirty();
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
				if (InteractionGroupID == interactionGroupId && InteractionStep >= interactionStep)
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
				APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(base.Owner);
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
