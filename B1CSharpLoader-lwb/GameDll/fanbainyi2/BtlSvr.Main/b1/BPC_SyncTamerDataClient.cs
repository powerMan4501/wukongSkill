using System.Collections.Generic;
using b1.ECS;

namespace b1;

public class BPC_SyncTamerDataClient : IBPC_TamerSyncData, IPersistentECSData
{
	public List<string> GuidsWaitingActivate = new List<string>();

	public List<string> GuidsWaitingNotifyBackToLoad = new List<string>();

	public List<string> GuidsWaitingNotifyAuthorityDead = new List<string>();

	public Dictionary<string, FUnitSpawnInfo> ClientPendingDynamicTamerSpawnWaitingSpawn = new Dictionary<string, FUnitSpawnInfo>();

	public HashSet<long> ClientAuthWaitingChannelOpen = new HashSet<long>();

	public int ClientDynamicTamerSpawnIdxAlloc;
}
