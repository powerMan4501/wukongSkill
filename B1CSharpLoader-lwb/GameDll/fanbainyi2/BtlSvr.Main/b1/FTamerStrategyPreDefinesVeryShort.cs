namespace b1;

public class FTamerStrategyPreDefinesVeryShort : ITamerStrategyPreDefines
{
	public float DistanceForForceSpawn => 1f;

	public float AsyncTraceMinEffectRange => 5f;

	public float AsyncTraceMaxEffectRange => 10f;

	public float DistanceForActorBeginPlayMeter => 5f;

	public float DistanceForUnloadMeter => 15f;

	public float PreloadDistanceMedium => 8f;

	public float PreloadDistanceFarthest => 10f;

	public float PreloadDistanceLoadMonsterClass => 15f;

	public float PreloadDistanceUnLoadMonsterClass => 30f;

	public float DistanceForPatrolActorBeginPlayMeter => 12f;

	public float DistanceForUnloadPatrolUnitMeter => 15f;

	public float ZOffsetSpawnLimitMeter => 10f;

	public float ZOffsetUnloadLimitMeter => 30f;

	public float DefaultDelayDestroyTime => 0.2f;
}
