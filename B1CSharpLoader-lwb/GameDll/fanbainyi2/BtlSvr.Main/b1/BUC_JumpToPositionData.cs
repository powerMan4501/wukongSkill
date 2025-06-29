using UnrealEngine.Runtime;

namespace b1;

public class BUC_JumpToPositionData
{
	public float Height;

	public bool CalibrationTrans;

	public bool bResetSceneItemOnFinish;

	public bool CurrentJumping;

	public FVector OriginLocation;

	public FVector TargetLocation;

	public FRotator TargetRotation;

	public float CurTime;

	public float TotalDuration;

	public float ZMaxVarDis;
}
