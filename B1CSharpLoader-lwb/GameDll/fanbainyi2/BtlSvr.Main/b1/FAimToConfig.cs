using UnrealEngine.Runtime;

namespace b1;

public struct FAimToConfig
{
	public bool bEnableDebug;

	public FName WeaponBoneName;

	public FVector AimAxis;

	public EAimToType AimToType;

	public FName TargetSocketName;

	public float BlendInTime;

	public float BlendOutTime;

	public float TraceSpd;

	public float DegreesConstraint;

	public float TotalTime;

	public void Reset()
	{
		bEnableDebug = false;
		WeaponBoneName = FName.None;
		AimAxis = FVector.ZeroVector;
		AimToType = EAimToType.None;
		TargetSocketName = FName.None;
		BlendInTime = 0f;
		BlendOutTime = 0f;
		TraceSpd = 0f;
		DegreesConstraint = 0f;
		TotalTime = 0f;
	}
}
