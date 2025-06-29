using System.Collections.Generic;
using ArchiveB1;
using b1.Plugins.Calliope;

namespace b1;

public class BIC_TaskData : IBIC_TaskData
{
	public bool bInitialTaskGraphs { get; set; }

	public MultiMap<string, IObserveNodeInstance> ObservingActorNodeMultiMap { get; } = new MultiMap<string, IObserveNodeInstance>();

	public MultiMap<IObserveNodeInstance, string> ObservingNodeMultiMap { get; } = new MultiMap<IObserveNodeInstance, string>();

	public List<IObserveNodeInstanceForTask> ObservingNodeForTaskList { get; } = new List<IObserveNodeInstanceForTask>();

	public WorldTaskArchiveData TaskArchiveData { get; set; }

	public Dictionary<int, QuestInstance> TaskGraphInstances { get; } = new Dictionary<int, QuestInstance>();

	public Dictionary<int, LevelArchiveQuestData> TaskArchiveCacheData { get; } = new Dictionary<int, LevelArchiveQuestData>();

	public List<InteractionRecordData> InteractionRecordList { get; } = new List<InteractionRecordData>();

	public Dictionary<string, NPCCacheInfo> NPCCacheInfoDic { get; } = new Dictionary<string, NPCCacheInfo>();

	public Dictionary<string, bool> OverlapsPlayerInside { get; } = new Dictionary<string, bool>();

	public Dictionary<int, LevelArchiveQuestData> GetTaskArchiveCacheDataDic()
	{
		return TaskArchiveCacheData;
	}

	public List<InteractionRecordData> GetInteractionRecordList()
	{
		return InteractionRecordList;
	}

	public bool IsPlayerInOverlap(string OverlapGuid, out bool bInnerOverlap)
	{
		return OverlapsPlayerInside.TryGetValue(OverlapGuid, out bInnerOverlap);
	}

	public bool TryGetCacheNPCShowState(string UnitGuid, out EGsNPCShowState CacheNPCShowState)
	{
		CacheNPCShowState = EGsNPCShowState.Hide;
		if (NPCCacheInfoDic.TryGetValue(UnitGuid, out var value))
		{
			CacheNPCShowState = value.CacheShowState;
			return true;
		}
		return false;
	}

	public bool TryGetCacheNPCTeamID(string UnitGuid, out int CacheTeamID)
	{
		CacheTeamID = 0;
		if (NPCCacheInfoDic.TryGetValue(UnitGuid, out var value))
		{
			CacheTeamID = value.CacheTeamID;
			return true;
		}
		return false;
	}

	public bool TryGetCacheNPCIdleAnimIdxInfo(string UnitGuid, out int CacheIdleAnimIdx)
	{
		CacheIdleAnimIdx = 0;
		if (NPCCacheInfoDic.TryGetValue(UnitGuid, out var value))
		{
			CacheIdleAnimIdx = value.CacheIdleAnimIdx;
			return true;
		}
		return false;
	}

	public bool TryGetCacheNPCLeisureAnimIndex(string UnitGuid, out int CacheLeisureAnimIndex)
	{
		CacheLeisureAnimIndex = -1;
		if (NPCCacheInfoDic.TryGetValue(UnitGuid, out var value))
		{
			CacheLeisureAnimIndex = value.CacheLeisureAnimIndex;
			return true;
		}
		return false;
	}

	public bool TryGetCacheNPCBuffEventInfoList(string UnitGuid, out List<CacheCPGBuffEventInfo> BuffEventInfoList)
	{
		BuffEventInfoList = new List<CacheCPGBuffEventInfo>();
		if (NPCCacheInfoDic.TryGetValue(UnitGuid, out var value))
		{
			BuffEventInfoList = value.CacheBuffInfo;
			return true;
		}
		return false;
	}
}
