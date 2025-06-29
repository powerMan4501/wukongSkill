namespace b1;

public interface IBUC_ABPQuadrupedLocomotionData
{
	EGaitGroundedState GaitGroundedState { get; }

	float MoveYaw { get; }

	float SpeedRate { get; }

	EMoveSpeedLevel SpeedRateLevel { get; }

	EMoveSpeedLevel JumpSpeedRateLevel { get; }

	bool bMoveBack { get; }

	bool bToStart { get; }

	bool bToTurn { get; }

	bool bToStop { get; }

	bool bInJump { get; }

	bool bSlopeJump { get; }

	EMoveDirectionFive TurnDirection { get; }

	bool bHasRunFallAnim { get; }

	bool bHasRushFallAnim { get; }

	bool bHasRunLandAnim { get; }

	bool bHasRushLandAnim { get; }
}
