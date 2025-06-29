using System.Collections.Generic;
using UnrealEngine.Engine;

namespace b1;

public interface IBGC_SummonData
{
	AActor GetSummonerFirstServantActor(AActor Summoner);

	AActor GetSummonerFirstServantActor(string SummonerGuid);

	int GetSummonerAllServantActors(AActor Summoner, out List<AActor> ServantActors);

	int GetSummonerAllServantActors(string SummonerGuid, out List<AActor> ServantActors);

	int GetSummonerAllServantCount(AActor Summoner, List<int> ResIDList = null);

	int GetSummonerAllServantCount(string SummonerGuid, List<int> ResIDList = null);

	void GetSummonInstancesBySummoner(string SummonerGuid, out List<FSummonInstance> OutSummonInstances);

	bool TryGetHatchTargetGUID_ThenClear(string SummonGuid, out string TargetGuid);
}
