using UnrealEngine.Engine;

namespace b1;

public class BUABPPlayerLocomotion_FreeSettingData
{
	public UCurveVector FreeMovementCurve { get; private set; }

	public UBlendSpace BSFreeAdditiveMovingLean { get; private set; }

	public UBlendSpace BSWalkLoopFwd { get; private set; }

	public UBlendSpace BSRunLoopFwd { get; private set; }

	public UBlendSpace BSRunLoopAdditive { get; private set; }

	public UBlendSpace BSRunLoopRotationAdditive { get; private set; }

	public UBlendSpace BSRushLoopFwd { get; private set; }

	public UBlendSpace BSRushLoopLean { get; private set; }

	public UAnimSequence ASWalkStartBwdL { get; private set; }

	public UAnimSequence ASWalkStartLeft { get; private set; }

	public UAnimSequence ASWalkStartFwd { get; private set; }

	public UAnimSequence ASWalkStartRight { get; private set; }

	public UAnimSequence ASWalkStartBwdR { get; private set; }

	public UAnimSequence ASWalkTurnBwdL { get; private set; }

	public UAnimSequence ASWalkTurnLeft { get; private set; }

	public UAnimSequence ASWalkTurnRight { get; private set; }

	public UAnimSequence ASWalkTurnBwdR { get; private set; }

	public UAnimSequence ASFreeWalkStop { get; private set; }

	public UAnimSequence ASRunStartBwdL { get; private set; }

	public UAnimSequence ASRunStartLeft { get; private set; }

	public UAnimSequence ASRunStartFwd { get; private set; }

	public UAnimSequence ASRunStartRight { get; private set; }

	public UAnimSequence ASRunStartBwdR { get; private set; }

	public UAnimSequence ASRunTurnBwdL { get; private set; }

	public UAnimSequence ASRunTurnLeft { get; private set; }

	public UAnimSequence ASRunTurnFwdL { get; private set; }

	public UAnimSequence ASRunTurnFwdR { get; private set; }

	public UAnimSequence ASRunTurnRight { get; private set; }

	public UAnimSequence ASRunTurnBwdR { get; private set; }

	public UAnimSequence ASRunTurnFwdFallingVelocityAdditive { get; private set; }

	public UAnimSequence ASRunTurnFwdSpeedAdditive { get; private set; }

	public UAnimSequence ASRunTurnBwdFallingVelocityAdditive { get; private set; }

	public UAnimSequence ASFreeRunStop { get; private set; }

	public UAnimSequence ASFreeSprintStartBwdL { get; private set; }

	public UAnimSequence ASFreeSprintStartLeft { get; private set; }

	public UAnimSequence ASFreeSprintStartFwd { get; private set; }

	public UAnimSequence ASFreeSprintStartRight { get; private set; }

	public UAnimSequence ASFreeSprintStartBwdR { get; private set; }

	public UAnimSequence ASFreeSprintTurnBwdL { get; private set; }

	public UAnimSequence ASFreeSprintTurnLeft { get; private set; }

	public UAnimSequence ASFreeSprintTurnRight { get; private set; }

	public UAnimSequence ASFreeSprintTurnBwdR { get; private set; }

	public UAnimSequence ASFreeSprintStop { get; private set; }

	public float SprintStopSlopeAngleThreshold { get; private set; }

	public UAnimSequence ASFreeSprintStopSlopeUp { get; private set; }

	public BUABPPlayerLocomotion_FreeSettingData(in FAnimHumanoidSetting_PlayerLocomotion_Free Setting)
	{
		FreeMovementCurve = Setting.FreeMovementCurve;
		BSFreeAdditiveMovingLean = Setting.BSFreeAdditiveMovingLean;
		BSWalkLoopFwd = Setting.BSWalkLoopFwd;
		BSRunLoopFwd = Setting.BSRunLoopFwd;
		BSRunLoopAdditive = Setting.BSRunLoopAdditive;
		BSRunLoopRotationAdditive = Setting.BSRunLoopRotationAdditive;
		BSRushLoopFwd = Setting.BSRushLoopFwd;
		BSRushLoopLean = Setting.BSRushLoopLean;
		ASWalkStartBwdL = Setting.ASWalkStartBwdL;
		ASWalkStartLeft = Setting.ASWalkStartLeft;
		ASWalkStartFwd = Setting.ASWalkStartFwd;
		ASWalkStartRight = Setting.ASWalkStartRight;
		ASWalkStartBwdR = Setting.ASWalkStartBwdR;
		ASWalkTurnBwdL = Setting.ASWalkTurnBwdL;
		ASWalkTurnLeft = Setting.ASWalkTurnLeft;
		ASWalkTurnRight = Setting.ASWalkTurnRight;
		ASWalkTurnBwdR = Setting.ASWalkTurnBwdR;
		ASFreeWalkStop = Setting.ASFreeWalkStop;
		ASRunStartBwdL = Setting.ASRunStartBwdL;
		ASRunStartLeft = Setting.ASRunStartLeft;
		ASRunStartFwd = Setting.ASRunStartFwd;
		ASRunStartRight = Setting.ASRunStartRight;
		ASRunStartBwdR = Setting.ASRunStartBwdR;
		ASRunTurnBwdL = Setting.ASRunTurnBwdL;
		ASRunTurnLeft = Setting.ASRunTurnLeft;
		ASRunTurnFwdL = Setting.ASRunTurnFwdL;
		ASRunTurnFwdR = Setting.ASRunTurnFwdR;
		ASRunTurnRight = Setting.ASRunTurnRight;
		ASRunTurnBwdR = Setting.ASRunTurnBwdR;
		ASRunTurnFwdFallingVelocityAdditive = Setting.ASRunTurnFwdFallingVelocityAdditive;
		ASRunTurnFwdSpeedAdditive = Setting.ASRunTurnFwdSpeedAdditive;
		ASRunTurnBwdFallingVelocityAdditive = Setting.ASRunTurnBwdFallingVelocityAdditive;
		ASFreeRunStop = Setting.ASFreeRunStop;
		ASFreeSprintStartBwdL = Setting.ASFreeSprintStartBwdL;
		ASFreeSprintStartLeft = Setting.ASFreeSprintStartLeft;
		ASFreeSprintStartFwd = Setting.ASFreeSprintStartFwd;
		ASFreeSprintStartRight = Setting.ASFreeSprintStartRight;
		ASFreeSprintStartBwdR = Setting.ASFreeSprintStartBwdR;
		ASFreeSprintTurnBwdL = Setting.ASFreeSprintTurnBwdL;
		ASFreeSprintTurnLeft = Setting.ASFreeSprintTurnLeft;
		ASFreeSprintTurnRight = Setting.ASFreeSprintTurnRight;
		ASFreeSprintTurnBwdR = Setting.ASFreeSprintTurnBwdR;
		ASFreeSprintStop = Setting.ASFreeSprintStop;
		SprintStopSlopeAngleThreshold = Setting.SprintStopSlopeAngleThreshold;
		ASFreeSprintStopSlopeUp = Setting.ASFreeSprintStopSlopeUp;
	}
}
