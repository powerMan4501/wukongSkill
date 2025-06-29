using System.Collections.Generic;
using UnrealEngine.Engine;

namespace b1;

public class BUABPQuadrupedLocomotionSettingData : BUABPSettingDataBase
{
	public List<UAnimSequence> AnimIdleList { get; private set; }

	public UBlendSpace BSMove { get; private set; }

	public UBlendSpace BSMoveBack { get; private set; }

	public UAnimSequence ASWalkStop { get; private set; }

	public UAnimSequence ASRunStartF { get; private set; }

	public UAnimSequence ASRunStartL { get; private set; }

	public UAnimSequence ASRunStartR { get; private set; }

	public UAnimSequence ASRunStartBL { get; private set; }

	public UAnimSequence ASRunStartBR { get; private set; }

	public UAnimSequence ASRunTurnStop { get; private set; }

	public UAnimSequence ASRunTurnL { get; private set; }

	public UAnimSequence ASRunTurnR { get; private set; }

	public UAnimSequence ASRunTurnBL { get; private set; }

	public UAnimSequence ASRunTurnBR { get; private set; }

	public UAnimSequence ASRunStop { get; private set; }

	public UAnimSequence ASRushStartF { get; private set; }

	public UAnimSequence ASRushStartL { get; private set; }

	public UAnimSequence ASRushStartR { get; private set; }

	public UAnimSequence ASRushStartBL { get; private set; }

	public UAnimSequence ASRushStartBR { get; private set; }

	public UAnimSequence ASRushTurnStop { get; private set; }

	public UAnimSequence ASRushTurnL { get; private set; }

	public UAnimSequence ASRushTurnR { get; private set; }

	public UAnimSequence ASRushTurnBL { get; private set; }

	public UAnimSequence ASRushTurnBR { get; private set; }

	public UAnimSequence ASRushStop { get; private set; }

	public UAnimSequence ASRunJump { get; private set; }

	public UAnimSequence ASRushJump { get; private set; }

	public UAnimSequence ASRunJumpSlope { get; private set; }

	public UAnimSequence ASRushJumpSlope { get; private set; }

	public float JumpSlopeAngleThreahold { get; private set; }

	public UAnimSequence ASRunFall { get; private set; }

	public UAnimSequence ASRushFall { get; private set; }

	public UAnimSequence ASRunFallSlope { get; private set; }

	public UAnimSequence ASRushFallSlope { get; private set; }

	public UAnimSequence ASRunLandMove { get; private set; }

	public UAnimSequence ASRushLandMove { get; private set; }

	public UAnimSequence ASRunLandMoveSlope { get; private set; }

	public UAnimSequence ASRushLandMoveSlope { get; private set; }

	public UAnimSequence ASRunLandStop { get; private set; }

	public UAnimSequence ASRushLandStop { get; private set; }

	public UAnimSequence ASRunLandStopSlope { get; private set; }

	public UAnimSequence ASRushLandStopSlope { get; private set; }

	public override void InitSettingData(in BGWDataAsset_AbpHumanoidSetting ABPSetting)
	{
		if (!(ABPSetting == null))
		{
			FAnimHumanoidSetting_QuadrupedLocomotion quadrupedLocomotionSetting = ABPSetting.QuadrupedLocomotionSetting;
			AnimIdleList = quadrupedLocomotionSetting.AnimIdleList;
			BSMove = quadrupedLocomotionSetting.BSMove;
			BSMoveBack = quadrupedLocomotionSetting.BSMoveBack;
			ASWalkStop = quadrupedLocomotionSetting.ASWalkStop;
			ASRunStartF = quadrupedLocomotionSetting.ASRunStartF;
			ASRunStartL = quadrupedLocomotionSetting.ASRunStartL;
			ASRunStartR = quadrupedLocomotionSetting.ASRunStartR;
			ASRunStartBL = quadrupedLocomotionSetting.ASRunStartBL;
			ASRunStartBR = quadrupedLocomotionSetting.ASRunStartBR;
			ASRunTurnStop = quadrupedLocomotionSetting.ASRunTurnStop;
			ASRunTurnL = quadrupedLocomotionSetting.ASRunTurnL;
			ASRunTurnR = quadrupedLocomotionSetting.ASRunTurnR;
			ASRunTurnBL = quadrupedLocomotionSetting.ASRunTurnBL;
			ASRunTurnBR = quadrupedLocomotionSetting.ASRunTurnBR;
			ASRunStop = quadrupedLocomotionSetting.ASRunStop;
			ASRushStartF = quadrupedLocomotionSetting.ASRushStartF;
			ASRushStartL = quadrupedLocomotionSetting.ASRushStartL;
			ASRushStartR = quadrupedLocomotionSetting.ASRushStartR;
			ASRushStartBL = quadrupedLocomotionSetting.ASRushStartBL;
			ASRushStartBR = quadrupedLocomotionSetting.ASRushStartBR;
			ASRushTurnStop = quadrupedLocomotionSetting.ASRushTurnStop;
			ASRushTurnL = quadrupedLocomotionSetting.ASRushTurnL;
			ASRushTurnR = quadrupedLocomotionSetting.ASRushTurnR;
			ASRushTurnBL = quadrupedLocomotionSetting.ASRushTurnBL;
			ASRushTurnBR = quadrupedLocomotionSetting.ASRushTurnBR;
			ASRushStop = quadrupedLocomotionSetting.ASRushStop;
			ASRunJump = quadrupedLocomotionSetting.ASRunJump;
			ASRushJump = quadrupedLocomotionSetting.ASRushJump;
			ASRunJumpSlope = quadrupedLocomotionSetting.ASRunJumpSlope;
			ASRushJumpSlope = quadrupedLocomotionSetting.ASRushJumpSlope;
			JumpSlopeAngleThreahold = quadrupedLocomotionSetting.JumpSlopeAngleThreahold;
			ASRunFall = quadrupedLocomotionSetting.ASRunFall;
			ASRushFall = quadrupedLocomotionSetting.ASRushFall;
			ASRunFallSlope = quadrupedLocomotionSetting.ASRunFallSlope;
			ASRushFallSlope = quadrupedLocomotionSetting.ASRushFallSlope;
			ASRunLandMove = quadrupedLocomotionSetting.ASRunLandMove;
			ASRushLandMove = quadrupedLocomotionSetting.ASRushLandMove;
			ASRunLandMoveSlope = quadrupedLocomotionSetting.ASRunLandMoveSlope;
			ASRushLandMoveSlope = quadrupedLocomotionSetting.ASRushLandMoveSlope;
			ASRunLandStop = quadrupedLocomotionSetting.ASRunLandStop;
			ASRushLandStop = quadrupedLocomotionSetting.ASRushLandStop;
			ASRunLandStopSlope = quadrupedLocomotionSetting.ASRunLandStopSlope;
			ASRushLandStopSlope = quadrupedLocomotionSetting.ASRushLandStopSlope;
		}
	}
}
