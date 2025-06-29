using System.Collections.Generic;
using b1.Plugins.Calliope;

namespace b1;

public class FSummonInstance
{
	public FSummonReq SummonReq;

	public FCalliopeGuid SummonInstanceID => SummonReq.SummonGuid;

	public string SummonerGuid { get; set; }

	public List<FServantReq> ServantReqList { get; } = new List<FServantReq>();

	public List<FServantInstanceBase> ServantInstances { get; } = new List<FServantInstanceBase>();

	public FSummonProcessorData SummonProcessorData { get; } = new FSummonProcessorData();

	public FSummonSystemContext SystemContext { get; set; }

	public int BeKilledCount { get; set; }

	public bool bSummonEnd { get; set; }

	public bool IsDestroyWhenSummonerDead { get; set; }

	public FSummonInstance(FSummonReq InReq)
	{
		SummonReq = InReq;
		IsDestroyWhenSummonerDead = InReq.SpawnConfigWrap.IsDestroyWhenSummonerDead;
		SummonerGuid = BGU_DataUtil.GetActorGuid(InReq.Summoner);
	}

	public int Init(FSummonSystemContext InSystemContext)
	{
		if (SummonReq.Summoner == null)
		{
			return 1;
		}
		SystemContext = InSystemContext;
		SummonerGuid = BGU_DataUtil.GetActorGuid(SummonReq.Summoner);
		return 0;
	}

	public void DoSummon()
	{
		FSummonProcessorBase.DoSummon(this);
	}

	public void ShutdownSummon()
	{
		DoSummonEnd();
	}

	public void TriggerAllServantLifeOver()
	{
		foreach (FServantInstanceBase servantInstance in ServantInstances)
		{
			servantInstance.AliveTime = 0f;
		}
	}

	public void OnTick(float InDeltaTime)
	{
		if (!SummonProcessorData.bSummoning)
		{
			if (SummonReq.bUseContinuousRefresh)
			{
				ContinuousSummonTick(InDeltaTime);
			}
			else
			{
				OneTimeSummonTick(InDeltaTime);
			}
		}
	}

	private void OneTimeSummonTick(float InDeltaTime)
	{
		bool flag = true;
		foreach (FServantInstanceBase servantInstance in ServantInstances)
		{
			if (servantInstance.ActualPhase != EServantPhase.Destroyed)
			{
				flag = false;
			}
		}
		if (flag)
		{
			DoSummonEnd();
		}
	}

	private void ContinuousSummonTick(float InDeltaTime)
	{
	}

	private void DoSummonEnd()
	{
		if (bSummonEnd)
		{
			return;
		}
		foreach (FServantInstanceBase servantInstance in ServantInstances)
		{
			servantInstance.DestroyServantTamer();
		}
		ServantInstances.Clear();
		bSummonEnd = true;
	}

	public void NotifyServantBeKilled(FServantInstanceBase ServantInstance)
	{
		BeKilledCount++;
		SystemContext.BGWEventCollection.Evt_BGW_OnSummonBeKilled(this);
	}
}
