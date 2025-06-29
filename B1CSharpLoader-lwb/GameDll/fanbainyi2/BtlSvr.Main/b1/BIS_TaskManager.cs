using System;
using System.Collections.Generic;
using ArchiveB1;
using b1.EventDelDefine;
using b1.Plugins.Calliope;
using BtlB1;
using BtlShare;
using Google.Protobuf;
using OssB1;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BIS_TaskManager")]
public class BIS_TaskManager : GameInstanceSystemBaseUObj, ICheckGraphDataQueryable
{
	public override bool bTickEnabled => true;

	private BGW_EventCollection EventCollection { get; set; }

	private BIC_TaskData TaskData { get; set; }

	public override void OnAttach()
	{
		TaskData = RequireWritableGameInstanceData<BIC_TaskData>();
		EventCollection = BGW_EventCollection.Get(base.Owner);
		if (EventCollection != null)
		{
			BGW_EventCollection eventCollection = EventCollection;
			eventCollection.Evt_PlayerDelayBeginPlayFinished = (Del_Void)Delegate.Combine(eventCollection.Evt_PlayerDelayBeginPlayFinished, new Del_Void(OnPlayerDelayBeginPlayFinished));
			BGW_EventCollection eventCollection2 = EventCollection;
			eventCollection2.Evt_RequestUpdateTaskArchiveData = (Del_Void)Delegate.Combine(eventCollection2.Evt_RequestUpdateTaskArchiveData, new Del_Void(OnSerializeArchiveData));
			BGW_EventCollection eventCollection3 = EventCollection;
			eventCollection3.Evt_RecoverTaskArchiveData = (BGW_EventCollection.Del_BGW_Void_TaskArchiveData)Delegate.Combine(eventCollection3.Evt_RecoverTaskArchiveData, new BGW_EventCollection.Del_BGW_Void_TaskArchiveData(OnRecoverTaskArchiveData));
			BGW_EventCollection eventCollection4 = EventCollection;
			eventCollection4.Evt_PushTaskStageStateSuccess = (BGW_EventCollection.Del_BGW_Void_PushTaskStageStateSuccess)Delegate.Combine(eventCollection4.Evt_PushTaskStageStateSuccess, new BGW_EventCollection.Del_BGW_Void_PushTaskStageStateSuccess(OnPushTaskStageStateSuccess));
			BGW_EventCollection eventCollection5 = EventCollection;
			eventCollection5.Evt_BGW_InteractGroup_Complete = (Del_Void_IntInt)Delegate.Combine(eventCollection5.Evt_BGW_InteractGroup_Complete, new Del_Void_IntInt(OnInteractComplete));
			BGW_EventCollection eventCollection6 = EventCollection;
			eventCollection6.Evt_TaskGraphNotifyGraph = (BGW_EventCollection.Del_BGW_Void_TaskGraphNotifyGraph)Delegate.Combine(eventCollection6.Evt_TaskGraphNotifyGraph, new BGW_EventCollection.Del_BGW_Void_TaskGraphNotifyGraph(OnNotifyGraph));
			BGW_EventCollection eventCollection7 = EventCollection;
			eventCollection7.Evt_TaskGraphStartObserve = (BGW_EventCollection.Del_BGW_Void_TaskGraphIObserveNodeInstanceString)Delegate.Combine(eventCollection7.Evt_TaskGraphStartObserve, new BGW_EventCollection.Del_BGW_Void_TaskGraphIObserveNodeInstanceString(OnStartObserve));
			BGW_EventCollection eventCollection8 = EventCollection;
			eventCollection8.Evt_TaskGraphStopObserve = (BGW_EventCollection.Del_BGW_Void_TaskGraphIObserveNodeInstance)Delegate.Combine(eventCollection8.Evt_TaskGraphStopObserve, new BGW_EventCollection.Del_BGW_Void_TaskGraphIObserveNodeInstance(OnStopObserve));
			BGW_EventCollection eventCollection9 = EventCollection;
			eventCollection9.Evt_TaskGraphStartObserveForTask = (BGW_EventCollection.Del_BGW_Void_TaskGraphIObserveNodeForTaskInstance)Delegate.Combine(eventCollection9.Evt_TaskGraphStartObserveForTask, new BGW_EventCollection.Del_BGW_Void_TaskGraphIObserveNodeForTaskInstance(OnStartObserveForTask));
			BGW_EventCollection eventCollection10 = EventCollection;
			eventCollection10.Evt_TaskGraphStopObserveForTask = (BGW_EventCollection.Del_BGW_Void_TaskGraphIObserveNodeForTaskInstance)Delegate.Combine(eventCollection10.Evt_TaskGraphStopObserveForTask, new BGW_EventCollection.Del_BGW_Void_TaskGraphIObserveNodeForTaskInstance(OnStopObserveForTask));
			BGW_EventCollection eventCollection11 = EventCollection;
			eventCollection11.Evt_TaskGraphNotifyGraph_ItemChange = (BGW_EventCollection.Del_BGW_Void_TaskGraphNotifyGraph_ItemChange)Delegate.Combine(eventCollection11.Evt_TaskGraphNotifyGraph_ItemChange, new BGW_EventCollection.Del_BGW_Void_TaskGraphNotifyGraph_ItemChange(OnNotifyGraph_ItemChange));
			BGW_EventCollection eventCollection12 = EventCollection;
			eventCollection12.Evt_TaskGraphNotifyGraph_MonsterCollectionFull = (Del_Void)Delegate.Combine(eventCollection12.Evt_TaskGraphNotifyGraph_MonsterCollectionFull, new Del_Void(OnNotifyGraph_MonsterCollection));
			BGW_EventCollection eventCollection13 = EventCollection;
			eventCollection13.Evt_BGS_PlayerEnterOverlap = (Del_Void_String)Delegate.Combine(eventCollection13.Evt_BGS_PlayerEnterOverlap, new Del_Void_String(OnPlayerEnterOverlap));
			BGW_EventCollection eventCollection14 = EventCollection;
			eventCollection14.Evt_BGS_PlayerLeaveOverlap = (Del_Void_String)Delegate.Combine(eventCollection14.Evt_BGS_PlayerLeaveOverlap, new Del_Void_String(OnPlayerLeaveOverlap));
			BGW_EventCollection eventCollection15 = EventCollection;
			eventCollection15.Evt_BGW_CacheNPCInfo = (BGW_EventCollection.Del_BGW_CacheNPCInfo)Delegate.Combine(eventCollection15.Evt_BGW_CacheNPCInfo, new BGW_EventCollection.Del_BGW_CacheNPCInfo(OnCacheNPCInfo));
			BGW_EventCollection eventCollection16 = EventCollection;
			eventCollection16.Evt_ResetGameInstanceData = (BGW_EventCollection.Del_BGW_ResetGameInstanceData)Delegate.Combine(eventCollection16.Evt_ResetGameInstanceData, new BGW_EventCollection.Del_BGW_ResetGameInstanceData(OnReSetGameData));
			BGW_EventCollection eventCollection17 = EventCollection;
			eventCollection17.Evt_ClearAllGameData = (Del_Void)Delegate.Combine(eventCollection17.Evt_ClearAllGameData, new Del_Void(ClearGameData));
		}
	}

	public static BIS_TaskManager Get(UObject WorldCtx)
	{
		return BGWGameInstanceCS.GetObject<BIS_TaskManager>(WorldCtx);
	}

	public override void OnInit()
	{
		TaskData.bInitialTaskGraphs = false;
		TaskData.TaskArchiveCacheData.Clear();
	}

	public override void OnShutdown()
	{
		base.OnShutdown();
		foreach (KeyValuePair<int, QuestInstance> taskGraphInstance in TaskData.TaskGraphInstances)
		{
			taskGraphInstance.Value?.Shutdown();
		}
		TaskData.TaskGraphInstances.Clear();
	}

	public override int GetTickGroupMask()
	{
		return 8;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (TickGroup == 8 && !IsNetClient())
		{
			UpdateForTaskGraph(DeltaTime);
		}
	}

	private bool IsNetClient()
	{
		return BGW_GameArchiveMgr.IsNetClient(base.Owner);
	}

	private void OnReSetGameData(EGameInstanceResetType ResetType)
	{
		TaskData.bInitialTaskGraphs = false;
		ClearTaskData();
	}

	private void ClearGameData()
	{
		ClearTaskData();
	}

	private void ClearTaskData()
	{
		foreach (KeyValuePair<int, QuestInstance> taskGraphInstance in TaskData.TaskGraphInstances)
		{
			taskGraphInstance.Value.Shutdown();
		}
		TaskData.ObservingActorNodeMultiMap.Clear();
		TaskData.ObservingNodeMultiMap.Clear();
		TaskData.ObservingNodeForTaskList.Clear();
		TaskData.TaskGraphInstances.Clear();
		TaskData.TaskArchiveCacheData.Clear();
		TaskData.InteractionRecordList.Clear();
		TaskData.OverlapsPlayerInside.Clear();
		TaskData.NPCCacheInfoDic.Clear();
	}

	private void UpdateForTaskGraph(float DeltaTime)
	{
		foreach (KeyValuePair<int, QuestInstance> taskGraphInstance in TaskData.TaskGraphInstances)
		{
			taskGraphInstance.Value?.OnGraphTick(DeltaTime);
		}
	}

	private void OnSerializeArchiveData()
	{
		WorldTaskArchiveData worldTaskArchiveData = new WorldTaskArchiveData();
		foreach (KeyValuePair<int, QuestInstance> taskGraphInstance in TaskData.TaskGraphInstances)
		{
			LevelArchiveQuestData levelArchiveQuestData = new LevelArchiveQuestData
			{
				IsDataValid = true,
				IsRootGraph = true,
				ParentNodeGuid = Guid.Empty.ToString(),
				ActivationState = ActivationState.Active
			};
			if (taskGraphInstance.Value != null)
			{
				SyncQuest2Archive(taskGraphInstance.Value, levelArchiveQuestData);
				worldTaskArchiveData.TaskGraphDataInfoList.Add(new TaskGraphDataInfo
				{
					TaskLineId = taskGraphInstance.Key,
					TaskGraphData = levelArchiveQuestData
				});
			}
		}
		foreach (InteractionRecordData interactionRecord in TaskData.GetInteractionRecordList())
		{
			worldTaskArchiveData.InteractionRecordList.Add(new InteractionRecordData
			{
				InteractGroupId = interactionRecord.InteractGroupId,
				InteractStep = interactionRecord.InteractStep
			});
		}
		TaskData.TaskArchiveData = worldTaskArchiveData;
	}

	private void OnRecoverTaskArchiveData(WorldTaskArchiveData InWorldTaskArchiveData)
	{
		if (!TaskData.bInitialTaskGraphs)
		{
			foreach (TaskGraphDataInfo taskGraphDataInfo in InWorldTaskArchiveData.TaskGraphDataInfoList)
			{
				if (!TaskData.TaskArchiveCacheData.TryGetValue(taskGraphDataInfo.TaskLineId, out var _))
				{
					TaskData.TaskArchiveCacheData.Add(taskGraphDataInfo.TaskLineId, taskGraphDataInfo.TaskGraphData);
				}
			}
		}
		TaskData.InteractionRecordList.Clear();
		foreach (InteractionRecordData interactionRecord in InWorldTaskArchiveData.InteractionRecordList)
		{
			TaskData.InteractionRecordList.Add(interactionRecord);
		}
	}

	public virtual void CheckGraphDataQueryable(out Dictionary<string, List<string>> UnsafeNodeInfoDic)
	{
		UnsafeNodeInfoDic = new Dictionary<string, List<string>>();
		Dictionary<int, FUStTaskLineDesc> allTaskLineDesc = BGW_GameDB.GetAllTaskLineDesc();
		if (TaskData.TaskGraphInstances.Count == 0)
		{
			foreach (KeyValuePair<int, FUStTaskLineDesc> item in allTaskLineDesc)
			{
				FUStTaskLineDesc value = item.Value;
				if (!TaskData.TaskGraphInstances.TryGetValue(value.ID, out var _))
				{
					QuestInstance questInstance = QuestInstance.Create(value.TaskGraphAssetPath, ECalliopeAssetType.Task, base.Owner);
					if (questInstance != null)
					{
						TaskData.TaskGraphInstances.Add(value.ID, questInstance);
					}
				}
			}
		}
		foreach (KeyValuePair<int, QuestInstance> taskGraphInstance in TaskData.TaskGraphInstances)
		{
			QuestInstance value3 = taskGraphInstance.Value;
			string taskGraphAssetPath = allTaskLineDesc[taskGraphInstance.Key].TaskGraphAssetPath;
			int num = taskGraphAssetPath.LastIndexOf('.');
			string key = taskGraphAssetPath.Substring(num + 1);
			foreach (QuestNodeInstance value4 in value3.NodeInstances.Values)
			{
				if (!value4.CheckNodeQueryable(out var ErrorMassager))
				{
					if (UnsafeNodeInfoDic.ContainsKey(key))
					{
						UnsafeNodeInfoDic[key].Add(value4.Node.NodeClass + "存在风险，原因可能是：" + ErrorMassager + "\n");
						continue;
					}
					List<string> list = new List<string>();
					list.Add(value4.Node.NodeClass + "存在风险，原因可能是：" + ErrorMassager + "\n");
					UnsafeNodeInfoDic.Add(key, list);
				}
			}
		}
	}

	private void SyncQuest2Archive(in QuestInstance Instance, LevelArchiveQuestData Archive)
	{
		if (Instance is QuestSubInstance questSubInstance)
		{
			Archive.ActivationState = questSubInstance.SubGraphNode.ActivationState;
		}
		Archive.Nodes.Clear();
		foreach (QuestNodeInstance value2 in Instance.NodeInstances.Values)
		{
			QuestNodeInstance NodeInstance = value2;
			if (NodeInstance.Node != null)
			{
				Guid nodeGuid = NodeInstance.Node.NodeGuid;
				LevelArchiveQuestNodeData levelArchiveQuestNodeData = new LevelArchiveQuestNodeData
				{
					IsDataValid = true,
					UniqueId = nodeGuid.ToString(),
					ParentGuid = Archive.ParentNodeGuid,
					NodeTemplateName = NodeInstance.Node.NodeClass,
					NodeGraphName = Instance.TemplateAsset.AssetPath
				};
				if (NodeInstance is IObserveNodeInstance key && TaskData.ObservingNodeMultiMap.TryGetValue(key, out var value))
				{
					levelArchiveQuestNodeData.ObserveActorGuid.Clear();
					levelArchiveQuestNodeData.ObserveActorGuid.AddRange(value);
				}
				Archive.Nodes.Add(levelArchiveQuestNodeData);
				SyncQuestNode2Archive(in NodeInstance, levelArchiveQuestNodeData);
			}
		}
		Archive.SubGraphData.Clear();
		foreach (QuestSubInstance value3 in Instance.SubInstances.Values)
		{
			if (value3 != null && value3.SubGraphNode != null)
			{
				LevelArchiveQuestData levelArchiveQuestData = new LevelArchiveQuestData
				{
					IsDataValid = true,
					IsRootGraph = false,
					AssetName = value3.Graph.GraphClass,
					ParentNodeGuid = value3.SubGraphNode.Node.NodeGuid.ToString(),
					ActivationState = value3.SubGraphNode.ActivationState
				};
				Archive.SubGraphData.Add(levelArchiveQuestData);
				QuestInstance Instance2 = value3;
				SyncQuest2Archive(in Instance2, levelArchiveQuestData);
			}
		}
	}

	private void SyncQuestNode2Archive(in QuestNodeInstance NodeInstance, LevelArchiveQuestNodeData NodeArchive)
	{
		NodeArchive.ActivationState = NodeInstance.ActivationState;
		if (NodeInstance.GetNodeCustomData() != null)
		{
			NodeArchive.CustomData = ByteString.CopyFrom(NodeInstance.GetNodeCustomData());
		}
	}

	private void OnNotifyGraph(string ObserveActorGuid, FGameplayTag NotifyTag)
	{
		if (!TaskData.ObservingActorNodeMultiMap.TryGetValue(ObserveActorGuid, out var value))
		{
			return;
		}
		foreach (IObserveNodeInstance item in new List<IObserveNodeInstance>(value))
		{
			item.OnNotifyGraph(ObserveActorGuid, NotifyTag);
		}
	}

	private void OnNotifyGraph_ItemChange(int ItemID, int OldNum, int NewNum)
	{
		for (int num = TaskData.ObservingNodeForTaskList.Count - 1; num >= 0; num--)
		{
			IObserveNodeInstanceForTask observeNodeInstanceForTask = TaskData.ObservingNodeForTaskList[num];
			if (observeNodeInstanceForTask != null)
			{
				observeNodeInstanceForTask.OnNotifyGraph_ItemChange(ItemID, OldNum, NewNum);
				observeNodeInstanceForTask.OnNotifyGraph_GainHulu(ItemID);
			}
		}
	}

	private void OnNotifyGraph_MonsterCollection()
	{
		for (int num = TaskData.ObservingNodeForTaskList.Count - 1; num >= 0; num--)
		{
			TaskData.ObservingNodeForTaskList[num]?.OnNotifyGraph_MonsterColletion();
		}
	}

	private void OnNotifyGraph_TaskStage(int TaskStageID, QuestStage StageState)
	{
		if (EventCollection != null)
		{
			EventCollection.Evt_TaskGraphNotifyGraph_TaskStage(TaskStageID, StageState);
		}
		for (int num = TaskData.ObservingNodeForTaskList.Count - 1; num >= 0; num--)
		{
			TaskData.ObservingNodeForTaskList[num]?.OnNotifyGraph_TaskStage(TaskStageID, StageState);
		}
	}

	private void OnNotifyGraph_Interaction(int InteractionGroupID, int InteractionStep)
	{
		for (int num = TaskData.ObservingNodeForTaskList.Count - 1; num >= 0; num--)
		{
			TaskData.ObservingNodeForTaskList[num]?.OnNotifyGraph_Interaction(InteractionGroupID, InteractionStep);
		}
	}

	private void OnPlayerEnterOverlap(string OverlapGuid)
	{
		if (TaskData.OverlapsPlayerInside.ContainsKey(OverlapGuid))
		{
			TaskData.OverlapsPlayerInside[OverlapGuid] = true;
		}
		else
		{
			TaskData.OverlapsPlayerInside.Add(OverlapGuid, value: true);
		}
	}

	private void OnPlayerLeaveOverlap(string OverlapGuid)
	{
		if (TaskData.OverlapsPlayerInside.ContainsKey(OverlapGuid))
		{
			TaskData.OverlapsPlayerInside[OverlapGuid] = false;
		}
		else
		{
			TaskData.OverlapsPlayerInside.Add(OverlapGuid, value: false);
		}
	}

	private void OnStartObserveForTask(IObserveNodeInstanceForTask NodeInstance)
	{
		if (!TaskData.ObservingNodeForTaskList.Contains(NodeInstance))
		{
			TaskData.ObservingNodeForTaskList.Add(NodeInstance);
		}
	}

	private void OnStopObserveForTask(IObserveNodeInstanceForTask NodeInstance)
	{
		if (TaskData.ObservingNodeForTaskList.Contains(NodeInstance))
		{
			TaskData.ObservingNodeForTaskList.Remove(NodeInstance);
		}
	}

	private void OnStartObserve(IObserveNodeInstance NodeInstance, string ObserveActorGuid)
	{
		TaskData.ObservingNodeMultiMap.Add(NodeInstance, ObserveActorGuid);
		TaskData.ObservingActorNodeMultiMap.Add(ObserveActorGuid, NodeInstance);
		AActor actorByGuid = BGU_DataUtil.GetActorByGuid(base.Owner, ObserveActorGuid);
		if (actorByGuid != null)
		{
			BUS_EventCollectionCS.Get(actorByGuid).Evt_NotifyStartObserve.Invoke();
		}
	}

	private void OnStopObserve(IObserveNodeInstance NodeInstance)
	{
		if (!TaskData.ObservingNodeMultiMap.ContainsKey(NodeInstance))
		{
			return;
		}
		foreach (string item in TaskData.ObservingNodeMultiMap[NodeInstance])
		{
			TaskData.ObservingActorNodeMultiMap.Remove(item, NodeInstance);
		}
		TaskData.ObservingNodeMultiMap.Remove(NodeInstance);
	}

	private void OnPushTaskStageStateSuccess(int TaskStageID, QuestStage StageState)
	{
		FUStTaskStageDesc taskStageDesc = BGW_GameDB.GetTaskStageDesc(TaskStageID);
		if (taskStageDesc == null)
		{
			return;
		}
		OnNotifyGraph_TaskStage(TaskStageID, StageState);
		if (BGW_GameDB.GetTaskLineDesc(taskStageDesc.BelongsToLineID) == null)
		{
			return;
		}
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(this);
		APawn aPawn = firstLocalPlayerController?.GetControlledPawn();
		if (aPawn != null && aPawn.PlayerState != null)
		{
			IBPC_RoleBaseData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBPC_RoleBaseData, BPC_RoleBaseData>(firstLocalPlayerController.PlayerState);
			if (readOnlyData != null)
			{
				TaskStageState stageState = ((StageState != QuestStage.Activated) ? TaskStageState.End : TaskStageState.Begin);
				BGS_GSEventCollection.Get(this).Evt_BGS_OnTaskStageChange.Invoke(readOnlyData.RoleId, taskStageDesc.BelongsToLineID, TaskStageID, stageState, taskStageDesc.Describe);
			}
		}
	}

	private void OnInteractComplete(int GroupID, int Step)
	{
		bool flag = true;
		for (int i = 0; i < TaskData.InteractionRecordList.Count; i++)
		{
			if (TaskData.InteractionRecordList[i].InteractGroupId == GroupID)
			{
				flag = false;
				if (TaskData.InteractionRecordList[i].InteractStep < Step)
				{
					TaskData.InteractionRecordList[i].InteractStep = Step;
				}
				break;
			}
		}
		if (flag)
		{
			TaskData.InteractionRecordList.Add(new InteractionRecordData
			{
				InteractGroupId = GroupID,
				InteractStep = Step
			});
			BGW_GameArchiveMgr.Get(base.Owner).MarkDelaySaveArchive(EArchiveDelaySaveSource.TaskInteractRecordChanged, $"GroupID:{GroupID} Step:{Step}");
		}
		BGW_EventCollection.Get(this).Evt_TaskGraphNotifyGraph_InteractionEnd(GroupID, Step);
		OnNotifyGraph_Interaction(GroupID, Step);
	}

	private void OnCacheNPCInfo(string UnitGuid, int TeamID, int IdleAMIdx, int LeisureAnimIndex, int InteractGroupID, EGsNPCShowState NPCShowState, List<NPCBuffInfo> NPCBuffInfoList)
	{
		EventCollection.Evt_SendUpdateInteractGroup(UnitGuid, InteractGroupID);
		bool flag = false;
		BUS_GSEventCollection bUS_GSEventCollection = null;
		AActor actorByGuid = BGU_DataUtil.GetActorByGuid(this, UnitGuid);
		if (actorByGuid != null)
		{
			bUS_GSEventCollection = BUS_EventCollectionCS.Get(actorByGuid);
			if (bUS_GSEventCollection != null)
			{
				flag = true;
			}
		}
		NPCCacheInfo nPCCacheInfo = new NPCCacheInfo
		{
			CacheTeamID = TeamID,
			CacheIdleAnimIdx = IdleAMIdx,
			CacheLeisureAnimIndex = LeisureAnimIndex,
			CacheShowState = NPCShowState,
			CacheBuffInfo = new List<CacheCPGBuffEventInfo>()
		};
		List<CacheCPGBuffEventInfo> list = new List<CacheCPGBuffEventInfo>();
		List<CacheCPGBuffEventInfo> list2 = new List<CacheCPGBuffEventInfo>();
		if (NPCBuffInfoList != null)
		{
			foreach (NPCBuffInfo NPCBuffInfo in NPCBuffInfoList)
			{
				bool bTriggerRemoveEffect = NPCBuffInfo.BuffID == 500581;
				CacheCPGBuffEventInfo item = new CacheCPGBuffEventInfo
				{
					BuffID = NPCBuffInfo.BuffID,
					IsAdd = NPCBuffInfo.bIsAdd,
					BuffLayer = 1,
					BuffDuration = -1,
					bTriggerRemoveEffect = bTriggerRemoveEffect
				};
				nPCCacheInfo.CacheBuffInfo.Add(item);
				if (flag)
				{
					if (NPCBuffInfo.bIsAdd)
					{
						list.Add(item);
					}
					else
					{
						list2.Add(item);
					}
				}
			}
		}
		bool flag2 = true;
		if (!TaskData.NPCCacheInfoDic.TryGetValue(UnitGuid, out var _))
		{
			TaskData.NPCCacheInfoDic.Add(UnitGuid, nPCCacheInfo);
		}
		else
		{
			NPCCacheInfo nPCCacheInfo2 = TaskData.NPCCacheInfoDic[UnitGuid];
			flag2 = nPCCacheInfo.CacheLeisureAnimIndex != nPCCacheInfo2.CacheLeisureAnimIndex;
			TaskData.NPCCacheInfoDic[UnitGuid] = nPCCacheInfo;
		}
		if (!flag)
		{
			return;
		}
		if (actorByGuid is BGUCharacterCS bGUCharacterCS)
		{
			bGUCharacterCS.SetTeamIDInCS(nPCCacheInfo.CacheTeamID);
			BGUFuncLibAICS.SearchTargetSP(bGUCharacterCS);
		}
		bUS_GSEventCollection.Evt_ChangeIdleAnimByIdx.Invoke(nPCCacheInfo.CacheIdleAnimIdx);
		bUS_GSEventCollection.Evt_ChangeNPCState.Invoke(nPCCacheInfo.CacheShowState);
		if (flag2)
		{
			bUS_GSEventCollection.Evt_ChangeLeisureAnimByIdx.Invoke(nPCCacheInfo.CacheLeisureAnimIndex);
		}
		foreach (CacheCPGBuffEventInfo item2 in list2)
		{
			bUS_GSEventCollection.Evt_BuffRemove.Invoke(item2.BuffID, EBuffEffectTriggerType.None, item2.BuffLayer, item2.bTriggerRemoveEffect);
		}
		foreach (CacheCPGBuffEventInfo item3 in list)
		{
			bUS_GSEventCollection.Evt_BuffAdd.Invoke(item3.BuffID, actorByGuid, actorByGuid, item3.BuffDuration, EBuffSourceType.TaskManager);
		}
	}

	private void OnPlayerDelayBeginPlayFinished()
	{
		if (DebugConfig.EnablePlaneMoveMode || IsNetClient() || B1Global.GIsBossRushMode || TaskData.bInitialTaskGraphs)
		{
			return;
		}
		TaskData.bInitialTaskGraphs = true;
		foreach (KeyValuePair<int, FUStTaskLineDesc> item in BGW_GameDB.GetAllTaskLineDesc())
		{
			FUStTaskLineDesc value = item.Value;
			if (!TaskData.TaskGraphInstances.TryGetValue(value.ID, out var _))
			{
				QuestInstance questInstance = QuestInstance.Create(value.TaskGraphAssetPath, ECalliopeAssetType.Task, base.Owner);
				if (questInstance != null)
				{
					TaskData.TaskGraphInstances.Add(value.ID, questInstance);
				}
			}
		}
		foreach (KeyValuePair<int, QuestInstance> taskGraphInstance in TaskData.TaskGraphInstances)
		{
			QuestInstance value3 = taskGraphInstance.Value;
			if (value3 != null)
			{
				if (TaskData.TaskArchiveCacheData.TryGetValue(taskGraphInstance.Key, out var value4))
				{
					value3.OnGraphRecover(value4);
				}
				else
				{
					value3.OnGraphStart();
				}
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BIS_TaskManager");
	}

	static BIS_TaskManager()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BIS_TaskManager)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BIS_TaskManager));
	}
}
