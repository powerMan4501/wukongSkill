using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGC_BossTraceData : IPersistentECSData
{
	private List<BossTraceInfo> BossTraceList = new List<BossTraceInfo>();

	private AActor CurTrace { get; set; }

	public List<BossTraceInfo> GetBossTraceList()
	{
		return BossTraceList;
	}

	public void SetCurTrace(AActor NewTrace)
	{
		CurTrace = NewTrace;
	}

	public AActor GetCurTrace()
	{
		return CurTrace;
	}

	public void AddBossTraceList(AActor NewTrace)
	{
		BossTraceInfo item = new BossTraceInfo
		{
			TraceCenterPoint = NewTrace,
			TraceFXIDList = new List<int>()
		};
		BossTraceList.Add(item);
	}

	public void ClearBossTraceList(AActor NewTrace)
	{
		BossTraceList.Clear();
	}

	public void ClearButCurTrace(AActor CurTrace, AActor Owner)
	{
		BossTraceInfo item = default(BossTraceInfo);
		foreach (BossTraceInfo bossTrace in BossTraceList)
		{
			if (!(bossTrace.TraceCenterPoint != CurTrace))
			{
				continue;
			}
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Owner);
			if (!(bUS_GSEventCollection != null))
			{
				continue;
			}
			foreach (int traceFXID in bossTrace.TraceFXIDList)
			{
				bUS_GSEventCollection.Evt_RequestDestroyByFXRequestID.Invoke(traceFXID);
			}
			bossTrace.TraceFXIDList.Clear();
			item = bossTrace;
		}
		BossTraceList.Clear();
		BossTraceList.Add(item);
	}

	public void AddFXListForTrace(AActor CurTrace, AActor Owner, List<FTransform> FXList, string EfxPath)
	{
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Owner);
		if (!(bUS_GSEventCollection != null))
		{
			return;
		}
		foreach (BossTraceInfo bossTrace in BossTraceList)
		{
			if (!(bossTrace.TraceCenterPoint == CurTrace))
			{
				continue;
			}
			{
				foreach (FTransform FX in FXList)
				{
					bUS_GSEventCollection.Evt_RequestSpawnFXByDispConfig.Invoke(GSCSResPathUtil.GetBGWDataAsset_B1DBCPath(EfxPath), out var RequestID, null, NeedSetSpawnTransform: true, FX);
					bossTrace.TraceFXIDList.Add(RequestID);
				}
				break;
			}
		}
	}
}
