using System.Collections.Generic;
using ArchiveB1;
using b1.Plugins.Calliope;

namespace b1;

public interface IBIC_TaskData
{
	WorldTaskArchiveData TaskArchiveData { get; }

	Dictionary<int, LevelArchiveQuestData> GetTaskArchiveCacheDataDic();

	List<InteractionRecordData> GetInteractionRecordList();

	bool IsPlayerInOverlap(string OverlapGuid, out bool bInnerOverlap);

	bool TryGetCacheNPCShowState(string UnitGuid, out EGsNPCShowState CacheNPCShowState);

	bool TryGetCacheNPCTeamID(string UnitGuid, out int CacheTeamID);

	bool TryGetCacheNPCIdleAnimIdxInfo(string UnitGuid, out int CacheIdleAnimIdx);

	bool TryGetCacheNPCLeisureAnimIndex(string UnitGuid, out int CacheLeisureAnimIndex);

	bool TryGetCacheNPCBuffEventInfoList(string UnitGuid, out List<CacheCPGBuffEventInfo> BuffEventInfoList);
}
