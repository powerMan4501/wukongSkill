namespace b1;

public interface ITamerStrategyPreDefines
{
	float DistanceForForceSpawn { get; }

	float AsyncTraceMinEffectRange { get; }

	float AsyncTraceMaxEffectRange { get; }

	float DistanceForActorBeginPlayMeter { get; }

	float DistanceForUnloadMeter { get; }

	float PreloadDistanceMedium { get; }

	float PreloadDistanceFarthest { get; }

	float PreloadDistanceLoadMonsterClass { get; }

	float PreloadDistanceUnLoadMonsterClass { get; }

	float DistanceForPatrolActorBeginPlayMeter { get; }

	float DistanceForUnloadPatrolUnitMeter { get; }

	float ZOffsetSpawnLimitMeter { get; }

	float ZOffsetUnloadLimitMeter { get; }

	float DefaultDelayDestroyTime { get; }
}
