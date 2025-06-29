using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public interface IBUC_ABPPlayerLocomotionData
{
	UCurveVector FreeMovementCurve { get; }

	ELockMoveDirectionSix LockMoveDirection { get; }

	ELockMoveDirectionSix LastLockMoveDirection { get; }

	FRotator TargetRotation { get; }

	float FreeAdditiveMovingLeanX { get; }

	float FreeAdditiveMovingLeanY { get; }

	float FreeAdditiveMovingLeanAlpha { get; }

	bool bSwitchToLock { get; }

	bool bSwitchingLockState { get; }

	bool bShouldWaitRotateFinished { get; }

	EMoveDirection TargetLockMoveDirection { get; }

	float TargetLockMoveDeltaAngle { get; }

	ELockMoveDirectionSix LockMoveDirectionStart { get; }

	ELockMoveDirectionSix LockMoveDirectionStop { get; }

	FVector4 InputBlendAlpha { get; }

	FVector4 VelocityBlendAlpha { get; }

	FVector4 VelocityBlendAlphaStop { get; }

	FVector LastFallingVelocity { get; }

	int RandomIdleIndex { get; }

	EGaitGroundedState GaitGroundedState { get; }

	EGaitGroundedState LastMoveGaitGroundedState { get; }

	float CurveMoveSpeedScale { get; }

	float VelocityDeltaAngleWalk { get; }

	float VelocityDeltaAngleRun { get; }

	float VelocityDeltaAngleRush { get; }

	float AnimRateWalk { get; }

	float AnimRateRun { get; }

	float AnimRateRush { get; }

	float AnimRateRunLock { get; }

	float InputDeltaAngle { get; }

	float SlopeAngle { get; }

	float FreeAdditiveMovingLeanSmoothX { get; }

	float FreeAdditiveMovingLeanSmoothY { get; }

	float WalkStartAngle { get; }

	float RunStartAngle { get; }

	float RushStartAngle { get; }

	float StopFreeTimer { get; }

	float VelocityDeltaAngleWhenTurn { get; }

	float VelocityDeltaAngleWhenTurnLast { get; }

	float VelocityDeltaAngle { get; }

	ELockMoveDirectionSix LockTurnStopDir { get; }

	bool bLockMoveFromTurnStop { get; }

	bool bInLockMoveState { get; }

	ELockMoveDirectionSix MaxAnimWeightLockMoveDir { get; }

	bool bInSequenceTransition { get; }

	bool bSequenceTransitionFromWalk { get; }

	bool bSequenceTransitionFromRun { get; }

	bool bSequenceTransitionFromRush { get; }

	bool bInFreeTurn { get; }

	void AfterSequenceTransition();
}
