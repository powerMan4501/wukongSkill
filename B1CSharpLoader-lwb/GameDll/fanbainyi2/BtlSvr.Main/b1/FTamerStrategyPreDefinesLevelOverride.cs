namespace b1;

public class FTamerStrategyPreDefinesLevelOverride : ITamerStrategyPreDefines
{
	public float DistanceForForceSpawn { get; set; }

	public float AsyncTraceMinEffectRange { get; set; }

	public float AsyncTraceMaxEffectRange { get; set; }

	public float DistanceForActorBeginPlayMeter { get; set; }

	public float DistanceForUnloadMeter { get; set; }

	public float PreloadDistanceMedium { get; set; }

	public float PreloadDistanceFarthest { get; set; }

	public float PreloadDistanceLoadMonsterClass { get; set; }

	public float PreloadDistanceUnLoadMonsterClass { get; set; }

	public float DistanceForPatrolActorBeginPlayMeter { get; set; }

	public float DistanceForUnloadPatrolUnitMeter { get; set; }

	public float ZOffsetSpawnLimitMeter { get; set; }

	public float ZOffsetUnloadLimitMeter { get; set; }

	public float DefaultDelayDestroyTime { get; set; }

	public FTamerStrategyPreDefinesLevelOverride(FTamerStrategyPreDefinesForLevelOverride PreDefinesForLevelOverride)
	{
		DistanceForForceSpawn = PreDefinesForLevelOverride.DistanceForForceSpawn;
		AsyncTraceMinEffectRange = PreDefinesForLevelOverride.AsyncTraceMinEffectRange;
		AsyncTraceMaxEffectRange = PreDefinesForLevelOverride.AsyncTraceMaxEffectRange;
		DistanceForActorBeginPlayMeter = PreDefinesForLevelOverride.DistanceForActorBeginPlayMeter;
		DistanceForUnloadMeter = PreDefinesForLevelOverride.DistanceForUnloadMeter;
		PreloadDistanceMedium = PreDefinesForLevelOverride.PreloadDistanceMedium;
		PreloadDistanceFarthest = PreDefinesForLevelOverride.PreloadDistanceFarthest;
		PreloadDistanceLoadMonsterClass = PreDefinesForLevelOverride.PreloadDistanceLoadMonsterClass;
		PreloadDistanceUnLoadMonsterClass = PreDefinesForLevelOverride.PreloadDistanceUnLoadMonsterClass;
		DistanceForPatrolActorBeginPlayMeter = PreDefinesForLevelOverride.DistanceForPatrolActorBeginPlayMeter;
		DistanceForUnloadPatrolUnitMeter = PreDefinesForLevelOverride.DistanceForUnloadPatrolUnitMeter;
		ZOffsetSpawnLimitMeter = PreDefinesForLevelOverride.ZOffsetSpawnLimitMeter;
		ZOffsetUnloadLimitMeter = PreDefinesForLevelOverride.ZOffsetUnloadLimitMeter;
		DefaultDelayDestroyTime = PreDefinesForLevelOverride.DefaultDelayDestroyTime;
	}
}
