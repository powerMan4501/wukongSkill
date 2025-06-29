using UnrealEngine.Runtime;

namespace b1;

public interface IBUC_ABPAdvancedMonsterLocomotionData
{
	ELMFreeMode FreeMode { get; }

	ELMLockMode LockMode { get; }

	float MaxAcceleration { get; }

	float BrakingDecelerationWalking { get; }

	float BrakingFriction { get; }

	FRotator TargetRotation { get; }

	bool bSwitchToLock { get; }

	bool bSwitchingLockState { get; }

	float SwitchingLockStateAngle { get; }

	EGaitGroundedState GaitGroundedState { get; }

	EGaitGroundedState MoveGaitGroundedState { get; }

	float VelocityDeltaAngle { get; }

	float VelocityLeanAlpha { get; }

	float AnimRateWalk { get; }

	float AnimRateRun { get; }

	float AnimRateRush { get; }

	float AnimRateRunLock { get; }

	float InputDeltaAngle { get; }

	float WalkStartAngle { get; }

	float RunStartAngle { get; }

	float RushStartAngle { get; }

	float StartAngle { get; }

	ELockMoveDirectionSix VelocityDirection { get; }

	ELockMoveDirectionSix InputDirection { get; }

	ELockMoveDirectionSix LastFrameVelocityDirection { get; }

	ELockMoveDirectionSix LastFrameInputDirection { get; }

	EMoveDirectionFive FreeInputDirection { get; }

	float InputVelocityAngle { get; }

	float MoveLoopPelvisLocationOffset { get; }

	float MoveLoopPelvisAngleOffset { get; }

	float MoveLoopAlpha { get; }

	bool bInFreeTurn { get; }

	void SetupMoveLoop();

	void UpdateMoveLoopAlpha(float DeltaTime);

	void ResetMoveLoopAlpha();
}
