using System.Collections.Generic;
using System.Linq;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1;

public class BGC_TamerData : IBGC_TamerData, IPersistentECSData
{
	protected Dictionary<string, TamerCharacterNameAllocator> TamerSpawnedCharacterNameCache = new Dictionary<string, TamerCharacterNameAllocator>();

	public Dictionary<string, TamerStrategyBase> RemotePlayerStrategy = new Dictionary<string, TamerStrategyBase>();

	public HashSet<string> CurrentSpawnedTamers = new HashSet<string>();

	public const int FallingCheckCountLimit = 5;

	public const float Tick1000ms = 1f;

	private TStrongObjectPtr<UTamerAsyncLineTraceManager> LineTraceManagerPtr = new TStrongObjectPtr<UTamerAsyncLineTraceManager>();

	public bool bInitialized { get; set; }

	public bool bEnableTamerStrategy { get; set; }

	public bool bAllowSpawnUnitInBossRushMode { get; set; }

	public Dictionary<string, FTamerRef> UnitGuid2Tamer { get; } = new Dictionary<string, FTamerRef>();

	public Dictionary<string, Dictionary<string, FTamerRef>> GroupGuid2TamerDict { get; } = new Dictionary<string, Dictionary<string, FTamerRef>>();

	public Dictionary<ETamerType, List<FTamerRef>> TamerType2Tamer { get; } = new Dictionary<ETamerType, List<FTamerRef>>();

	public Dictionary<string, FServantReq> ServantTamerReqCache { get; } = new Dictionary<string, FServantReq>();

	public Dictionary<ETamerType, TamerStrategyBase> TamerStrategyMap { get; } = new Dictionary<ETamerType, TamerStrategyBase>();

	public Dictionary<string, ETamerSpawnRule> WaitingRuleTamers { get; } = new Dictionary<string, ETamerSpawnRule>();

	public Queue<string> FallingCheckQueue { get; } = new Queue<string>();

	public float TickTimeFor1000ms { get; set; }

	public UTamerAsyncLineTraceManager LineTraceManager
	{
		get
		{
			return LineTraceManagerPtr.Get();
		}
		set
		{
			LineTraceManagerPtr.Set(value);
		}
	}

	public void RemoveTamerCharacterNameAllocator(string TamerGUID)
	{
		TamerSpawnedCharacterNameCache.Remove(TamerGUID);
	}

	public TamerCharacterNameAllocator GetOrAllocTamerCharacterNameAllocator(string TamerGUID)
	{
		if (!TamerSpawnedCharacterNameCache.TryGetValue(TamerGUID, out var value))
		{
			string text = TamerGUID.Replace(".", "___");
			value = new TamerCharacterNameAllocator
			{
				GUID = text,
				AllocIdx = 0
			};
			TamerSpawnedCharacterNameCache[TamerGUID] = value;
			if (TamerGUID != text)
			{
				if (TamerSpawnedCharacterNameCache.ContainsKey(text))
				{
					BGW_LogUtil.LogError("TamerGUID:" + TamerGUID + " Conflict!!!");
				}
				TamerSpawnedCharacterNameCache[text] = value;
			}
		}
		return value;
	}

	public bool TryGetTamerEntityRef(string UnitGuid, out FTamerRef OutTamerRef)
	{
		if (UnitGuid2Tamer.TryGetValue(UnitGuid, out OutTamerRef))
		{
			return true;
		}
		string key = UnitGuid.Replace("___", ".");
		return UnitGuid2Tamer.TryGetValue(key, out OutTamerRef);
	}

	public bool GetTamerType(string UnitGuid, out ETamerType OutTamerType)
	{
		OutTamerType = ETamerType.None;
		if (UnitGuid2Tamer.TryGetValue(UnitGuid, out var value))
		{
			OutTamerType = value.TamerType;
			return true;
		}
		return false;
	}

	public TamerStrategyBase GetRemotePlayerTamerStrategy(string PlayUID)
	{
		RemotePlayerStrategy.TryGetValue(PlayUID, out var value);
		return value;
	}

	public bool IsUnitSpawnFinished(string UnitGuid)
	{
		if (UnitGuid2Tamer.TryGetValue(UnitGuid, out var value) && value.Phase == ETamerPhase.Spawned)
		{
			return true;
		}
		return false;
	}

	public bool GetAllMonsterGuidByResID(int InResId, out List<string> OutResult)
	{
		OutResult = new List<string>();
		foreach (KeyValuePair<string, FTamerRef> item in UnitGuid2Tamer)
		{
			if (item.Value.ResID == InResId)
			{
				OutResult.Add(item.Key);
			}
		}
		return OutResult.Count > 0;
	}

	public bool GetAllMonsterGuidByGroupGuid(string GroupGuid, out Dictionary<string, FTamerRef> OutResult)
	{
		OutResult = null;
		if (GroupGuid2TamerDict.TryGetValue(GroupGuid, out OutResult))
		{
			if (OutResult != null)
			{
				return OutResult.Count > 0;
			}
			return false;
		}
		return false;
	}

	public void GetSpawnedMonsterList(out List<string> OutMonsterList)
	{
		OutMonsterList = CurrentSpawnedTamers.ToList();
	}

	public bool GetTamerServantReqCacheAndRemove(string TamerGuid, out FServantReq? OutReq)
	{
		if (ServantTamerReqCache.ContainsKey(TamerGuid))
		{
			OutReq = ServantTamerReqCache[TamerGuid];
			ServantTamerReqCache.Remove(TamerGuid);
			return true;
		}
		OutReq = null;
		return false;
	}

	public TamerStrategyBase GetTamerStrategy(FTamerRef InTamerRef)
	{
		return TamerStrategyMap[InTamerRef.TamerType];
	}
}
