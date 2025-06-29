using UnrealEngine.Runtime;

namespace b1;

public struct CollisionUpdateInfo
{
	public ulong RequestID;

	public float TotalTime;

	public float CurrTime;

	public bool NeedUpdateRadius;

	public bool NeedSetRelaLocForScale;

	public bool NeedUpdateScale;

	public FVector RollbackLocation;

	public float RollbackRadius;

	public float RollbackHalfHeight;
}
