using System.Collections.Generic;
using b1.BGW;

namespace b1;

public class FTamerStrategyResult
{
	private readonly Dictionary<FTamerRef, float> TamerDelayDestroyTimesInternal = new Dictionary<FTamerRef, float>();

	public List<FTamerRef> IncrementalSpawnTamers { get; } = new List<FTamerRef>();

	public List<FTamerRef> Back2LoadNoDelayTamers { get; } = new List<FTamerRef>();

	public List<FTamerRef> Back2LoadTamers { get; } = new List<FTamerRef>();

	public Dictionary<FTamerRef, EUnitPreloadLevel> PreloadTamers { get; } = new Dictionary<FTamerRef, EUnitPreloadLevel>();

	public Dictionary<FTamerRef, ETamerPreloadLevel> PreloadTamersForMonsterClass { get; } = new Dictionary<FTamerRef, ETamerPreloadLevel>();

	public IReadOnlyDictionary<FTamerRef, float> TamerDelayDestroyTimes => TamerDelayDestroyTimesInternal;

	public Dictionary<FTamerRef, bool> ChangeLODDictionary { get; } = new Dictionary<FTamerRef, bool>();

	public List<FTamerRef> BlockingSpawnTamerList { get; } = new List<FTamerRef>();

	public List<int> NeedLineTraceTamers { get; } = new List<int>();

	public void MarkTamerDelayDestroyTime(FTamerRef TamerRef, float Time)
	{
		TamerDelayDestroyTimesInternal[TamerRef] = Time;
		TamerRef.DelayDestroyTime = Time;
	}

	public void RemoveDelayDestroyTamer(FTamerRef TamerRef)
	{
		TamerDelayDestroyTimesInternal.Remove(TamerRef);
		TamerRef.DelayDestroyTime = -1f;
	}

	public void Cleanup()
	{
		IncrementalSpawnTamers.Clear();
		Back2LoadNoDelayTamers.Clear();
		Back2LoadTamers.Clear();
		PreloadTamers.Clear();
		PreloadTamersForMonsterClass.Clear();
		ChangeLODDictionary.Clear();
		BlockingSpawnTamerList.Clear();
		NeedLineTraceTamers.Clear();
	}
}
