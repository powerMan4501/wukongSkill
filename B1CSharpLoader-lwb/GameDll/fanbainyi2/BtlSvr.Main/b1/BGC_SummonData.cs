using System.Collections.Generic;
using b1.ECS;
using b1.Plugins.Calliope;
using UnrealEngine.Engine;

namespace b1;

public class BGC_SummonData : IBGC_SummonData, IPersistentECSData
{
	public Dictionary<FCalliopeGuid, FSummonInstance> SummonInstances { get; } = new Dictionary<FCalliopeGuid, FSummonInstance>();

	public Dictionary<string, List<FSummonInstance>> SummonerSummonInstances { get; } = new Dictionary<string, List<FSummonInstance>>();

	public FSummonSystemContext SystemContext { get; set; }

	public Dictionary<string, string> HatchTargetTemp { get; } = new Dictionary<string, string>();

	public AActor GetSummonerFirstServantActor(AActor Summoner)
	{
		string actorGuid = BGU_DataUtil.GetActorGuid(Summoner);
		return GetSummonerFirstServantActor(actorGuid);
	}

	public AActor GetSummonerFirstServantActor(string SummonerGuid)
	{
		if (SummonerSummonInstances.TryGetValue(SummonerGuid, out var value))
		{
			foreach (FSummonInstance item in value)
			{
				foreach (FServantInstanceBase servantInstance in item.ServantInstances)
				{
					if (servantInstance.ActualPhase == EServantPhase.Unit)
					{
						return servantInstance.GetMonsterActor();
					}
				}
			}
		}
		return null;
	}

	public int GetSummonerAllServantActors(AActor Summoner, out List<AActor> ServantActors)
	{
		string actorGuid = BGU_DataUtil.GetActorGuid(Summoner);
		return GetSummonerAllServantActors(actorGuid, out ServantActors);
	}

	public int GetSummonerAllServantActors(string SummonerGuid, out List<AActor> ServantActors)
	{
		ServantActors = new List<AActor>();
		if (SummonerSummonInstances.TryGetValue(SummonerGuid, out var value))
		{
			foreach (FSummonInstance item in value)
			{
				foreach (FServantInstanceBase servantInstance in item.ServantInstances)
				{
					if (servantInstance.ActualPhase == EServantPhase.Unit)
					{
						ServantActors.Add(servantInstance.GetMonsterActor());
					}
				}
			}
		}
		return ServantActors.Count;
	}

	public int GetSummonerAllServantCount(AActor Summoner, List<int> ResIDList = null)
	{
		string actorGuid = BGU_DataUtil.GetActorGuid(Summoner);
		return GetSummonerAllServantCount(actorGuid, ResIDList);
	}

	public int GetSummonerAllServantCount(string SummonerGuid, List<int> ResIDList = null)
	{
		int num = 0;
		if (SummonerSummonInstances.TryGetValue(SummonerGuid, out var value))
		{
			foreach (FSummonInstance item in value)
			{
				foreach (FServantInstanceBase servantInstance in item.ServantInstances)
				{
					if (servantInstance.ActualPhase == EServantPhase.Unit && (ResIDList == null || ResIDList.Contains(servantInstance.ServantResId)))
					{
						num++;
					}
				}
			}
		}
		return num;
	}

	public void GetSummonInstancesBySummoner(string SummonerGuid, out List<FSummonInstance> OutSummonInstances)
	{
		if (!SummonerSummonInstances.TryGetValue(SummonerGuid, out OutSummonInstances))
		{
			OutSummonInstances = new List<FSummonInstance>();
			SummonerSummonInstances[SummonerGuid] = OutSummonInstances;
		}
	}

	public bool TryGetHatchTargetGUID_ThenClear(string SummonGuid, out string TargetGuid)
	{
		if (HatchTargetTemp.TryGetValue(SummonGuid, out TargetGuid))
		{
			HatchTargetTemp.Remove(SummonGuid);
			return true;
		}
		return false;
	}
}
