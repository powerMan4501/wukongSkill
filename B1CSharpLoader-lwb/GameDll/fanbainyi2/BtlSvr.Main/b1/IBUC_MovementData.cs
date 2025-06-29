using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public interface IBUC_MovementData
{
	bool bWalkOnDitch { get; }

	FRotator TargetRot { get; }

	bool bInputMoving { get; }

	float AMScaleMaxRate { get; }

	bool bEnableWalk { get; }

	bool IsSpiderMoveReached { get; }

	EBGUMoveAIType MoveAIType { get; }

	bool IsCloudMoveVerticalLift { get; }

	float VelocityAccelerationDegree { get; }

	bool IsAMCalcSpeedRate { get; }

	bool IsAMPause { get; }

	float AMSpeedRate { get; }

	float AMCaleSpeedRateTime { get; }

	int AMSpeedRateNotifyStateID { get; }

	int NavWalkOptLevel { get; }

	float NavWalkOptimizeDistanceLevel1 { get; }

	float NavWalkOptimizeDistanceLevel2 { get; }

	bool bCanUseSurfaceTypeFromMovementComp { get; }

	FVector CurFloorNormal { get; }

	FVector CurFloorHitPoint { get; }

	ESceneItemSurfaceType CurSurfaceType { get; }

	FVector GetCurrentWorldInputVec(ACharacter OwnerChr);

	bool IsMoveModeActive(EBGUMoveMode MoveMode);

	EBGUMoveMode GetMoveType();

	void GetRotateInfo(out FVector TargetPos, out float RotateSpeed);

	void GetInterpolationMoveTarget(out FVector TargetPos, out FRotator TargetRotator);

	bool CanUseSurfaceTypeFromMovementComp();
}
