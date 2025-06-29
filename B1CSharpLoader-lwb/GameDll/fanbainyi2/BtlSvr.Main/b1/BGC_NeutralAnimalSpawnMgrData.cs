using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGC_NeutralAnimalSpawnMgrData : IBGC_NeutralAnimalSpawnMgrData, IPersistentECSData
{
	public bool bCloudMoveFlag;

	public List<FTreeInfo> TreeArray = new List<FTreeInfo>();

	public FTreeBirdSpawnConfig TreeBirdSpawnConfig;

	public FVector LastRefreshTreePos;

	public float Timer_TreeBird = -1f;

	public List<AActor> TreeBirdSpawnnerList = new List<AActor>();

	public BGWDataAsset_SplineBirdSpawnConfig SplineBirdSpawnConfig;

	public bool IsSplineBirdSpawnConfigSetted;

	public float SplineBirdRefreshCoolDown;

	public List<FSplineInfo> SplineArray = new List<FSplineInfo>();

	public Dictionary<string, float> SplineTriggerTimeCached = new Dictionary<string, float>();

	public List<AActor> CurActiveSplineBirdArray = new List<AActor>();

	public Dictionary<string, List<string>> AreaAnimalsMap = new Dictionary<string, List<string>>();

	public List<string> AreaGuidList_NeedDestroyIntoSeq = new List<string>();

	public int MAXCOUNT_BPANIMAL;

	public float DISTCHECK_DISTLIMIT;

	public float DISTCHECK_INTERVAL;

	public float DistCheck_IntervalTimer;

	public Queue<string> DistCheck_Queue = new Queue<string>();

	public bool bLastBPAnimalSpawnReqSuccess { get; set; }

	public bool BPAnimalSpawnPause { get; set; }

	public int GetCurBPAnimalCount()
	{
		int num = 0;
		foreach (KeyValuePair<string, List<string>> item in AreaAnimalsMap)
		{
			num += item.Value.Count;
		}
		return num;
	}

	public int GetBPRemainSpawnSize()
	{
		return MAXCOUNT_BPANIMAL - GetCurBPAnimalCount();
	}

	public bool CanSpawnBPAnimal()
	{
		if (GetCurBPAnimalCount() >= MAXCOUNT_BPANIMAL)
		{
			return false;
		}
		return true;
	}

	public int GetCurAreaBPAnimalNum(string AreaGuid)
	{
		if (AreaAnimalsMap.TryGetValue(AreaGuid, out var value))
		{
			return value.Count;
		}
		return 0;
	}

	public BGC_NeutralAnimalSpawnMgrData()
	{
		DistCheck_IntervalTimer = DISTCHECK_INTERVAL;
	}

	public void InitBPAnimalOPTConfig()
	{
		if (BGW_GameDB.GetGlobalConfigByAlias(B1GlobalConfigFNames.BPAnimal_MaxNum, out var ConfigInfo))
		{
			MAXCOUNT_BPANIMAL = ((ConfigInfo.IntValue > 0) ? ConfigInfo.IntValue : 10);
		}
		else
		{
			MAXCOUNT_BPANIMAL = 10;
		}
		if (BGW_GameDB.GetGlobalConfigByAlias(B1GlobalConfigFNames.BPAnimal_DestroyDist, out var ConfigInfo2))
		{
			DISTCHECK_DISTLIMIT = ((ConfigInfo2.FloatValue > 1000f) ? ConfigInfo2.FloatValue : 10000f);
		}
		else
		{
			DISTCHECK_DISTLIMIT = 10000f;
		}
		DISTCHECK_INTERVAL = 3f / (float)MAXCOUNT_BPANIMAL;
		DistCheck_IntervalTimer = DISTCHECK_INTERVAL;
	}
}
