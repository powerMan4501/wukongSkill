using System.Collections.Generic;
using b1.Plugins.Calliope;

namespace b1;

public class NPCCacheInfo
{
	public int CacheTeamID;

	public int CacheIdleAnimIdx;

	public int CacheLeisureAnimIndex;

	public EGsNPCShowState CacheShowState;

	public List<CacheCPGBuffEventInfo> CacheBuffInfo;
}
