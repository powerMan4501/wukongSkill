namespace b1;

public class FTamerStrategyPreDefinesSculptures : ITamerStrategyPreDefines
{
	public float DistanceForForceSpawn => 5f;

	public float DistanceForActorBeginPlayMeter => 20f;

	public float AsyncTraceMinEffectRange => 20f;

	public float AsyncTraceMaxEffectRange => 60f;

	public float DistanceForUnloadMeter => 70f;

	public float PreloadDistanceMedium => 40f;

	public float PreloadDistanceFarthest => 65f;

	public float PreloadDistanceLoadMonsterClass => 200f;

	public float PreloadDistanceUnLoadMonsterClass => 300f;

	public float DistanceForPatrolActorBeginPlayMeter => 120f;

	public float DistanceForUnloadPatrolUnitMeter => 200f;

	public float ZOffsetSpawnLimitMeter => 15f;

	public float ZOffsetUnloadLimitMeter => 20f;

	public float DefaultDelayDestroyTime => 3f;
}
