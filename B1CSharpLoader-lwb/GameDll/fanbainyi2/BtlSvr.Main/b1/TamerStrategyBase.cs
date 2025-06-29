using System;
using System.Collections.Generic;
using System.Linq;
using BtlShare;
using UnrealEngine.Engine;

namespace b1;

public abstract class TamerStrategyBase
{
	protected const int CountLimitPerFrame = 1;

	protected const int SpawnCountLimitPerFrame = 1;

	protected const int UnloadCountLimitPerFrame = 10;

	public static int CurrentFrameHandleCount;

	protected AActor Owner { get; set; }

	public UTamerAsyncLineTraceManager LineTraceManager { get; set; }

	protected Dictionary<ETamerPhase, HashSet<FTamerRef>> TamersSortByPhase { get; } = new Dictionary<ETamerPhase, HashSet<FTamerRef>>();

	public bool bCanBack2Load { get; set; } = true;

	protected float LogTime { get; set; }

	protected float LogIntervalSecond { get; set; } = 1f;

	public int CurrentFrameDelayDestroyCount { get; set; }

	public HashSet<FTamerRef> NeedUnregisterTamers { get; } = new HashSet<FTamerRef>();

	protected bool bUseOnlyList { get; set; }

	public void Initial(AActor InOwner, UTamerAsyncLineTraceManager InLineTraceManager)
	{
		Owner = InOwner;
		LineTraceManager = InLineTraceManager;
		foreach (ETamerPhase item in Enum.GetValues(typeof(ETamerPhase)).Cast<ETamerPhase>())
		{
			TamersSortByPhase.Add(item, new HashSet<FTamerRef>());
		}
		PostInitial();
	}

	protected virtual void PostInitial()
	{
	}

	public virtual void BeginPlay()
	{
	}

	public virtual void OnTick(float DeltaTime)
	{
	}

	public virtual void OnAfterAnimTick(float DeltaTime)
	{
	}

	public int GetTamersByPhase(ETamerPhase InPhase, out List<FTamerRef> OutTamerRefList)
	{
		if (TamersSortByPhase.TryGetValue(InPhase, out var value))
		{
			OutTamerRefList = value.ToList();
			return value.Count;
		}
		OutTamerRefList = new List<FTamerRef>();
		return 0;
	}

	public int GetSpawnTamerCount()
	{
		return TamersSortByPhase[ETamerPhase.Spawned]?.Count ?? 0;
	}

	public void AddTamer(FTamerRef InTamer)
	{
		TamersSortByPhase[InTamer.Phase].Add(InTamer);
		PostAddTamer(InTamer);
	}

	public void RemoveTamerWithoutPostRemoveTamer(FTamerRef InTamer)
	{
		TamersSortByPhase[InTamer.Phase].Remove(InTamer);
	}

	public void RemoveTamer(FTamerRef InTamer)
	{
		TamersSortByPhase[InTamer.Phase].Remove(InTamer);
		PostRemoveTamer(InTamer);
	}

	public bool ContainsTamer(FTamerRef InTamer)
	{
		return TamersSortByPhase[InTamer.Phase].Contains(InTamer);
	}

	public void OnTamerPhaseChanged(FTamerRef InTamer, ETamerPhase OldPhase, ETamerPhase NewPhase)
	{
		if (OldPhase != NewPhase)
		{
			if (TamersSortByPhase[OldPhase].Remove(InTamer))
			{
				TamersSortByPhase[NewPhase].Add(InTamer);
			}
			PostTamerPhaseChanged(InTamer, OldPhase, NewPhase);
		}
	}

	protected virtual void PostAddTamer(FTamerRef InTamer)
	{
	}

	protected virtual void PostRemoveTamer(FTamerRef InTamer)
	{
	}

	protected virtual void PostTamerPhaseChanged(FTamerRef InTamer, ETamerPhase OldPhase, ETamerPhase NewPhase)
	{
	}

	public virtual void OnTamerUnitDead(FTamerRef InTamer, EDeadReason InDeadReason)
	{
	}

	public void EnableOnlyMode()
	{
		bUseOnlyList = true;
	}

	public void DisableOnlyMode()
	{
		bUseOnlyList = false;
	}

	public virtual void Destroy()
	{
		Owner = null;
		LineTraceManager = null;
		TamersSortByPhase.Clear();
	}
}
