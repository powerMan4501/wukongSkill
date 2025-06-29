using System;
using System.Collections.Generic;
using ArchiveB1;
using b1.EventDelDefine;
using Google.Protobuf;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGS_QuestSystem : GameModeSystemBase
{
	private bool IsPuase;

	public float DelayTimeSeconds { get; set; }

	private float CurrentTimeSeconds { get; set; }

	private BGC_QuestData QuestData { get; set; }

	private IBIC_LevelData LevelData { get; set; }

	private IBIC_MovieData MovieData { get; set; }

	public override void OnAttach()
	{
		base.OnAttach();
		QuestData = RequireWritableGameStateData<BGC_QuestData>();
		LevelData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_LevelData, BIC_LevelData>(Owner);
		MovieData = RequireReadonlyGameInstanceData<IBIC_MovieData, BIC_MovieData>();
		base.BGSEventCollection.Evt_BGS_RecordLastNotifyGraph += new Del_Void_StringGameplayTag(OnRecordLastNotifyGraph);
		base.BGSEventCollection.Evt_BGS_StartObserve += new Del_Void_IObserveNodeInstanceString(OnStartObserve);
		base.BGSEventCollection.Evt_BGS_StopObserve += new Del_Void_IObserveNodeInstance(OnStopObserve);
		base.BGSEventCollection.Evt_BGS_NotifyGraph += new Del_Void_StringGameplayTag(OnNotifyGraph);
		base.BGSEventCollection.Evt_BGS_SerializeQuestArchiveData += new Del_Void(OnSerializeArchiveData);
		base.BGSEventCollection.Evt_BGS_PauseQuestSystem += new Del_Void_Bool(OnPauseQuestSystem);
		base.BGSEventCollection.Evt_BGS_SwitchRootQuestGraph += new Del_Void_String(OnSwitchRootQuestGraph);
	}

	public override void OnBeginPlay()
	{
		string text = null;
		int currentLevelID = LevelData.CurrentLevelID;
		if (currentLevelID > 0)
		{
			LevelDesc levelDesc = GameDBRuntime.FastGetLevelDesc(currentLevelID);
			if (levelDesc != null)
			{
				text = levelDesc.RootQuestGraphPath;
			}
		}
		if (string.IsNullOrEmpty(text))
		{
			UWorld worldFromObj = UGSE_EngineFuncLib.GetWorldFromObj(Owner);
			if (worldFromObj == null)
			{
				return;
			}
			BGW_WorldSettings bGW_WorldSettings = worldFromObj.GetWorldSettings().Cast<BGW_WorldSettings>();
			if (bGW_WorldSettings == null)
			{
				return;
			}
			text = bGW_WorldSettings.RootQuestGraph?.GetPathName();
		}
		OnSwitchRootQuestGraph(text);
	}

	private void OnSwitchRootQuestGraph(string RootQuestGraphPath)
	{
		DelayTimeSeconds = 1f;
		CurrentTimeSeconds = 0f;
		QuestData.RootInstance = QuestInstance.Create(RootQuestGraphPath, ECalliopeAssetType.Quest, Owner);
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		QuestData.RootInstance?.Shutdown();
	}

	public override float GetAccumulatedDeltaTime()
	{
		if (!HasBegunPlay())
		{
			return -1f;
		}
		if (LevelData == null || LevelData.bOpeningLevel)
		{
			return -1f;
		}
		return 0f;
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (IsPuase)
		{
			return;
		}
		if (CurrentTimeSeconds <= DelayTimeSeconds)
		{
			CurrentTimeSeconds += DeltaTime;
			if (CurrentTimeSeconds > DelayTimeSeconds)
			{
				StartQuestInstance();
			}
		}
		else
		{
			QuestData.RootInstance?.OnGraphTick(DeltaTime);
		}
	}

	private void OnPauseQuestSystem(bool IsPause)
	{
		IsPuase = IsPause;
	}

	private void StartQuestInstance()
	{
		QuestInstance rootInstance = QuestData.RootInstance;
		if (rootInstance == null)
		{
			return;
		}
		if (LevelData.IsValidLevel())
		{
			LevelArchiveQuestData levelArchiveQuestData = LevelData.GetCurrentLevelDetailArchiveData()?.QuestData;
			if (levelArchiveQuestData != null)
			{
				rootInstance.OnGraphRecover(levelArchiveQuestData);
			}
			else
			{
				QuestData.RootInstance?.OnGraphStart();
			}
		}
		else
		{
			QuestData.RootInstance?.OnGraphStart();
		}
	}

	private void OnRecordLastNotifyGraph(string ActorGuid, FGameplayTag NotifyTag)
	{
		QuestData.LastNotifyGraphRecord[NotifyTag] = ActorGuid;
	}

	private void OnSerializeArchiveData()
	{
		if (CurrentTimeSeconds <= DelayTimeSeconds)
		{
			StartQuestInstance();
		}
		LevelArchiveDetailData currentLevelDetailArchiveData = LevelData.GetCurrentLevelDetailArchiveData();
		if (currentLevelDetailArchiveData != null && QuestData.RootInstance != null)
		{
			LevelArchiveQuestData levelArchiveQuestData = currentLevelDetailArchiveData.QuestData;
			if (levelArchiveQuestData == null)
			{
				levelArchiveQuestData = (currentLevelDetailArchiveData.QuestData = new LevelArchiveQuestData
				{
					IsDataValid = true,
					IsRootGraph = true,
					ParentNodeGuid = Guid.Empty.ToString(),
					ActivationState = ActivationState.Active
				});
			}
			SyncQuest2Archive(QuestData.RootInstance, levelArchiveQuestData);
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
			Guid nodeGuid = NodeInstance.Node.NodeGuid;
			LevelArchiveQuestNodeData levelArchiveQuestNodeData = new LevelArchiveQuestNodeData();
			levelArchiveQuestNodeData.IsDataValid = true;
			levelArchiveQuestNodeData.UniqueId = nodeGuid.ToString();
			levelArchiveQuestNodeData.ParentGuid = Archive.ParentNodeGuid;
			if (NodeInstance is IObserveNodeInstance key && QuestData.ObservingNodeMultiMap.TryGetValue(key, out var value))
			{
				levelArchiveQuestNodeData.ObserveActorGuid.Clear();
				levelArchiveQuestNodeData.ObserveActorGuid.AddRange(value);
			}
			Archive.Nodes.Add(levelArchiveQuestNodeData);
			SyncQuestNode2Archive(in NodeInstance, levelArchiveQuestNodeData);
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
		if (!QuestData.ObservingActorNodeMultiMap.ContainsKey(ObserveActorGuid))
		{
			return;
		}
		foreach (IObserveNodeInstance item in new List<IObserveNodeInstance>(QuestData.ObservingActorNodeMultiMap[ObserveActorGuid]))
		{
			item.OnNotifyGraph(ObserveActorGuid, NotifyTag);
		}
	}

	private void OnStartObserve(IObserveNodeInstance NodeInstance, string ObserveActorGuid)
	{
		QuestData.ObservingNodeMultiMap.Add(NodeInstance, ObserveActorGuid);
		QuestData.ObservingActorNodeMultiMap.Add(ObserveActorGuid, NodeInstance);
		AActor actorByGuid = BGU_DataUtil.GetActorByGuid(Owner, ObserveActorGuid);
		if (actorByGuid != null)
		{
			BUS_EventCollectionCS.Get(actorByGuid).Evt_NotifyStartObserve.Invoke();
		}
	}

	private void OnStopObserve(IObserveNodeInstance NodeInstance)
	{
		if (!QuestData.ObservingNodeMultiMap.ContainsKey(NodeInstance))
		{
			return;
		}
		foreach (string item in QuestData.ObservingNodeMultiMap[NodeInstance])
		{
			QuestData.ObservingActorNodeMultiMap.Remove(item, NodeInstance);
		}
		QuestData.ObservingNodeMultiMap.Remove(NodeInstance);
	}
}
