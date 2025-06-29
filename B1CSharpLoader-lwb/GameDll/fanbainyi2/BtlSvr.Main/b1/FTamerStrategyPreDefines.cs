using System.Collections.Generic;

namespace b1;

public static class FTamerStrategyPreDefines
{
	public static float DistanceForForceSpawn => TamerStrategyPreDefinesList[DebugConfig.UseDebugTamerConfig].DistanceForForceSpawn;

	public static float AsyncTraceMinEffectRange => TamerStrategyPreDefinesList[DebugConfig.UseDebugTamerConfig].AsyncTraceMinEffectRange;

	public static float AsyncTraceMaxEffectRange => TamerStrategyPreDefinesList[DebugConfig.UseDebugTamerConfig].AsyncTraceMaxEffectRange;

	public static float DistanceForActorBeginPlayMeter => TamerStrategyPreDefinesList[DebugConfig.UseDebugTamerConfig].DistanceForActorBeginPlayMeter;

	public static float DistanceForUnloadMeter => TamerStrategyPreDefinesList[DebugConfig.UseDebugTamerConfig].DistanceForUnloadMeter;

	public static float PreloadDistanceMedium => TamerStrategyPreDefinesList[DebugConfig.UseDebugTamerConfig].PreloadDistanceMedium;

	public static float PreloadDistanceFarthest => TamerStrategyPreDefinesList[DebugConfig.UseDebugTamerConfig].PreloadDistanceFarthest;

	public static float PreloadDistanceLoadMonsterClass => TamerStrategyPreDefinesList[DebugConfig.UseDebugTamerConfig].PreloadDistanceLoadMonsterClass;

	public static float PreloadDistanceUnLoadMonsterClass => TamerStrategyPreDefinesList[DebugConfig.UseDebugTamerConfig].PreloadDistanceUnLoadMonsterClass;

	public static float DistanceForPatrolActorBeginPlayMeter => TamerStrategyPreDefinesList[DebugConfig.UseDebugTamerConfig].DistanceForPatrolActorBeginPlayMeter;

	public static float DistanceForUnloadPatrolUnitMeter => TamerStrategyPreDefinesList[DebugConfig.UseDebugTamerConfig].DistanceForUnloadPatrolUnitMeter;

	public static float ZOffsetSpawnLimitMeter => TamerStrategyPreDefinesList[DebugConfig.UseDebugTamerConfig].ZOffsetSpawnLimitMeter;

	public static float ZOffsetUnloadLimitMeter => TamerStrategyPreDefinesList[DebugConfig.UseDebugTamerConfig].ZOffsetUnloadLimitMeter;

	public static float DefaultDelayDestroyTime => TamerStrategyPreDefinesList[DebugConfig.UseDebugTamerConfig].DefaultDelayDestroyTime;

	private static List<ITamerStrategyPreDefines> TamerStrategyPreDefinesList { get; }

	private static Dictionary<string, ITamerStrategyPreDefines> InstanceHolder { get; }

	private static Dictionary<ETamerStrategyArea, ITamerStrategyPreDefines> AreaMapping { get; }

	static FTamerStrategyPreDefines()
	{
		TamerStrategyPreDefinesList = new List<ITamerStrategyPreDefines>();
		InstanceHolder = new Dictionary<string, ITamerStrategyPreDefines>();
		AreaMapping = new Dictionary<ETamerStrategyArea, ITamerStrategyPreDefines>();
		InitDefines();
	}

	public static void InitDefines()
	{
		TamerStrategyPreDefinesList.Clear();
		AreaMapping.Clear();
		FTamerStrategyPreDefinesFormal instance = GetInstance<FTamerStrategyPreDefinesFormal>();
		TamerStrategyPreDefinesList.Add(GetInstance<FTamerStrategyPreDefinesFormal>());
		TamerStrategyPreDefinesList.Add(GetInstance<FTamerStrategyPreDefinesShort>());
		TamerStrategyPreDefinesList.Add(GetInstance<FTamerStrategyPreDefinesVeryShort>());
		AreaMapping[ETamerStrategyArea.None] = instance;
		AreaMapping[ETamerStrategyArea.SuspendedSculptures] = GetInstance<FTamerStrategyPreDefinesSculptures>();
		AreaMapping[ETamerStrategyArea.Dungeon] = GetInstance<FTamerStrategyPreDefinesDungeon>();
	}

	private static T GetInstance<T>() where T : class, ITamerStrategyPreDefines, new()
	{
		string key = typeof(T).ToString();
		if (InstanceHolder.TryGetValue(key, out var value))
		{
			return value as T;
		}
		T val = new T();
		InstanceHolder[key] = val;
		return val;
	}

	public static void SetTamerStrategyArea(ETamerStrategyArea InArea)
	{
		if (TamerStrategyPreDefinesList.Count != 0)
		{
			TamerStrategyPreDefinesList[0] = AreaMapping[InArea];
		}
	}

	public static void SetTamerStrategyByWorldSetting(FTamerStrategyPreDefinesForLevelOverride DefinesForLevelOverride)
	{
		if (TamerStrategyPreDefinesList.Count != 0)
		{
			FTamerStrategyPreDefinesLevelOverride value = new FTamerStrategyPreDefinesLevelOverride(DefinesForLevelOverride);
			AreaMapping[ETamerStrategyArea.None] = value;
			TamerStrategyPreDefinesList[0] = value;
		}
	}
}
