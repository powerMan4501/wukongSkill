namespace b1;

public class FTamerStrategyPreDefinesFormal : ITamerStrategyPreDefines
{
	public float DistanceForForceSpawn => 20f;

	public float AsyncTraceMinEffectRange => 50f;

	public float AsyncTraceMaxEffectRange => 150f;

	public float DistanceForActorBeginPlayMeter => 50f;

	public float DistanceForUnloadMeter => 180f;

	public float PreloadDistanceMedium => 40f;

	public float PreloadDistanceFarthest => 65f;

	public float PreloadDistanceLoadMonsterClass => 200f;

	public float PreloadDistanceUnLoadMonsterClass => 250f;

	public float DistanceForPatrolActorBeginPlayMeter => 120f;

	public float DistanceForUnloadPatrolUnitMeter => 180f;

	public float ZOffsetSpawnLimitMeter => 50f;

	public float ZOffsetUnloadLimitMeter => 100f;

	public float DefaultDelayDestroyTime => 5f;
}
