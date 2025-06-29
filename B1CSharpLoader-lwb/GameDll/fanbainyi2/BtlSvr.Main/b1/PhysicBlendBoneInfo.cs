using UnrealEngine.Runtime;

namespace b1;

public class PhysicBlendBoneInfo
{
	public FName BoneName;

	public float TargetBlendWeight;

	public float FromBlendWeight;

	public float CurBlendWeight;

	public float BlendInSpd;

	public float BlendOutSpd;

	public float CurrentTime;

	public float TotalTime;

	public float BlendInTimer;

	public float TotalBlendInTime;

	public float BlendOutTimer;

	public float TotalBlendOutTime;
}
