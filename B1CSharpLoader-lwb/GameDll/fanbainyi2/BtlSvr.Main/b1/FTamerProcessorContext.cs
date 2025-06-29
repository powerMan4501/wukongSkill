using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class FTamerProcessorContext
{
	private const int MinSkipScore = 2;

	public int CountLimitPerFrame { get; set; }

	public float DeltaTime { get; set; }

	public AActor Owner { get; set; }

	public bool bUseOnlyList { get; set; }

	public Dictionary<ETamerPhase, List<FTamerRef>> TamersSortByPhase { get; } = new Dictionary<ETamerPhase, List<FTamerRef>>();

	public bool bCanBack2Load { get; set; } = true;

	public FTamerStrategyResult Result { get; } = new FTamerStrategyResult();

	public FTamerRef CurrentProcessedTamer { get; set; }

	public List<FVector2D> AllPlayerLocation2Ds { get; } = new List<FVector2D>();

	public List<float> AllPlayerLocationZs { get; } = new List<float>();

	public Dictionary<int, bool> TamerVisibleDictionary { get; } = new Dictionary<int, bool>();

	public bool CanBreakProcessChain()
	{
		if (Result.IncrementalSpawnTamers.Count >= CountLimitPerFrame)
		{
			return CurrentProcessedTamer.LastScore < 2f;
		}
		return false;
	}

	public void Cleanup()
	{
		Result.Cleanup();
		CurrentProcessedTamer = null;
		AllPlayerLocation2Ds.Clear();
		AllPlayerLocationZs.Clear();
		bCanBack2Load = true;
		foreach (KeyValuePair<ETamerPhase, List<FTamerRef>> item in TamersSortByPhase)
		{
			item.Value.Clear();
		}
	}
}
