using b1.ECS;

namespace b1;

internal struct FDistanceCheckRequest
{
	public Entity TargetEntity;

	public float TargetDistance;

	public b1.EDistanceCompareType CompareType;

	public b1.EDistanceCheckAxis CheckAxis;

	public float DeltaTime;

	public b1.BUC_DistanceCheckData.Del_DistanceCheck Callback;
}
