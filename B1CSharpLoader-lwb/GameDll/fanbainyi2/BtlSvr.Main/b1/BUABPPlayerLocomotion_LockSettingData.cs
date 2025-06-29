using UnrealEngine.Engine;

namespace b1;

public class BUABPPlayerLocomotion_LockSettingData
{
	public UCurveVector LockMovementCurve { get; private set; }

	public UAnimSequence ASLockWalkLoopFwd { get; private set; }

	public UAnimSequence ASLockWalkLoopBwd { get; private set; }

	public UAnimSequence ASLockWalkLoopLeftF { get; private set; }

	public UAnimSequence ASLockWalkLoopRightF { get; private set; }

	public UAnimSequence ASLockWalkLoopLeftB { get; private set; }

	public UAnimSequence ASLockWalkLoopRightB { get; private set; }

	public UAnimSequence ASLockWalkLoopLeftFAdd { get; private set; }

	public UAnimSequence ASLockWalkLoopRightFAdd { get; private set; }

	public UAnimSequence ASLockRunLoopFwd { get; private set; }

	public UAnimSequence ASLockRunLoopLeftF { get; private set; }

	public UAnimSequence ASLockRunLoopLeftB { get; private set; }

	public UAnimSequence ASLockRunLoopLeftFAdd { get; private set; }

	public UAnimSequence ASLockRunLoopRightF { get; private set; }

	public UAnimSequence ASLockRunLoopRightB { get; private set; }

	public UAnimSequence ASLockRunLoopRightFAdd { get; private set; }

	public UAnimSequence ASLockRunLoopBwd { get; private set; }

	public UBlendSpace BSLockWalkStartFwd { get; private set; }

	public UBlendSpace BSLockWalkStartBwd { get; private set; }

	public UAnimSequence ASLockWalkStartFwdL { get; private set; }

	public UAnimSequence ASLockWalkStartFwdR { get; private set; }

	public UAnimSequence ASLockWalkStartBwdL { get; private set; }

	public UAnimSequence ASLockWalkStartBwdR { get; private set; }

	public UAnimSequence ASLockWalkStartLeftF { get; private set; }

	public UAnimSequence ASLockWalkStartLeftB { get; private set; }

	public UAnimSequence ASLockWalkStartRightF { get; private set; }

	public UAnimSequence ASLockWalkStartRightB { get; private set; }

	public UBlendSpace BSLockRunStartFwd { get; private set; }

	public UBlendSpace BSLockRunStartBwd { get; private set; }

	public UAnimSequence ASLockRunStartFwdL { get; private set; }

	public UAnimSequence ASLockRunStartFwdR { get; private set; }

	public UAnimSequence ASLockRunStartBwdL { get; private set; }

	public UAnimSequence ASLockRunStartBwdR { get; private set; }

	public UAnimSequence ASLockRunStartLeftF { get; private set; }

	public UAnimSequence ASLockRunStartLeftB { get; private set; }

	public UAnimSequence ASLockRunStartRightF { get; private set; }

	public UAnimSequence ASLockRunStartRightB { get; private set; }

	public UBlendSpace BSLockWalkTurnF2B { get; private set; }

	public UBlendSpace BSLockWalkTurnB2F { get; private set; }

	public UBlendSpace BSLockWalkTurnFR2BL { get; private set; }

	public UBlendSpace BSLockWalkTurnBR2FL { get; private set; }

	public UBlendSpace BSLockWalkTurnBL2FR { get; private set; }

	public UBlendSpace BSLockWalkTurnFL2BR { get; private set; }

	public UBlendSpace BSLockWalkTurnFR2FL { get; private set; }

	public UBlendSpace BSLockWalkTurnFL2FR { get; private set; }

	public UBlendSpace BSLockWalkTurnBL2FL { get; private set; }

	public UBlendSpace BSLockWalkTurnFL2BL { get; private set; }

	public UBlendSpace BSLockWalkTurnBR2FR { get; private set; }

	public UBlendSpace BSLockWalkTurnFR2BR { get; private set; }

	public UBlendSpace BSLockRunTurnF2B { get; private set; }

	public UBlendSpace BSLockRunTurnB2F { get; private set; }

	public UBlendSpace BSLockRunTurnBR2FL { get; private set; }

	public UBlendSpace BSLockRunTurnFR2FL { get; private set; }

	public UBlendSpace BSLockRunTurnBL2FL { get; private set; }

	public UBlendSpace BSLockRunTurnFR2BL { get; private set; }

	public UBlendSpace BSLockRunTurnFL2BL { get; private set; }

	public UBlendSpace BSLockRunTurnFL2FR { get; private set; }

	public UBlendSpace BSLockRunTurnBL2FR { get; private set; }

	public UBlendSpace BSLockRunTurnBR2FR { get; private set; }

	public UBlendSpace BSLockRunTurnFL2BR { get; private set; }

	public UBlendSpace BSLockRunTurnFR2BR { get; private set; }

	public UBlendSpace BSLockTurnFRFromFRBL { get; private set; }

	public UBlendSpace BSLockTurnFRFromFLBR { get; private set; }

	public UBlendSpace BSLockTurnBRFromFRBL { get; private set; }

	public UBlendSpace BSLockTurnBRFromFLBR { get; private set; }

	public UBlendSpace BSLockTurnBLFromFRBL { get; private set; }

	public UBlendSpace BSLockTurnBLFromFLBR { get; private set; }

	public UBlendSpace BSLockTurnFLFromFRBL { get; private set; }

	public UBlendSpace BSLockTurnFLFromFLBR { get; private set; }

	public UBlendSpace BSLockTurnStopFL { get; private set; }

	public UBlendSpace BSLockTurnStopFR { get; private set; }

	public UBlendSpace BSLockTurnStopBL { get; private set; }

	public UBlendSpace BSLockTurnStopBR { get; private set; }

	public UAnimSequence ASLockWalkStopFwd { get; private set; }

	public UAnimSequence ASLockWalkStopBwd { get; private set; }

	public UAnimSequence ASLockWalkStopLeftF { get; private set; }

	public UAnimSequence ASLockWalkStopLeftB { get; private set; }

	public UAnimSequence ASLockWalkStopRightF { get; private set; }

	public UAnimSequence ASLockWalkStopRightB { get; private set; }

	public UAnimSequence ASLockWalkStopFL45 { get; private set; }

	public UAnimSequence ASLockWalkStopFR45 { get; private set; }

	public UAnimSequence ASLockWalkStopBL45 { get; private set; }

	public UAnimSequence ASLockWalkStopBR45 { get; private set; }

	public UAnimSequence ASLockRunStopFwdL { get; private set; }

	public UAnimSequence ASLockRunStopFwdR { get; private set; }

	public UAnimSequence ASLockRunStopLeftF { get; private set; }

	public UAnimSequence ASLockRunStopLeftB { get; private set; }

	public UAnimSequence ASLockRunStopRightF { get; private set; }

	public UAnimSequence ASLockRunStopRightB { get; private set; }

	public UAnimSequence ASLockRunStopBwdL { get; private set; }

	public UAnimSequence ASLockRunStopBwdR { get; private set; }

	public BUABPPlayerLocomotion_LockSettingData(in FAnimHumanoidSetting_PlayerLocomotion_Lock Setting)
	{
		LockMovementCurve = Setting.LockMovementCurve;
		ASLockWalkLoopFwd = Setting.ASLockWalkLoopFwd;
		ASLockWalkLoopBwd = Setting.ASLockWalkLoopBwd;
		ASLockWalkLoopLeftF = Setting.ASLockWalkLoopLeftF;
		ASLockWalkLoopRightF = Setting.ASLockWalkLoopRightF;
		ASLockWalkLoopLeftB = Setting.ASLockWalkLoopLeftB;
		ASLockWalkLoopRightB = Setting.ASLockWalkLoopRightB;
		ASLockWalkLoopLeftFAdd = Setting.ASLockWalkLoopLeftFAdd;
		ASLockWalkLoopRightFAdd = Setting.ASLockWalkLoopRightFAdd;
		ASLockRunLoopFwd = Setting.ASLockRunLoopFwd;
		ASLockRunLoopLeftF = Setting.ASLockRunLoopLeftF;
		ASLockRunLoopLeftB = Setting.ASLockRunLoopLeftB;
		ASLockRunLoopLeftFAdd = Setting.ASLockRunLoopLeftFAdd;
		ASLockRunLoopRightF = Setting.ASLockRunLoopRightF;
		ASLockRunLoopRightB = Setting.ASLockRunLoopRightB;
		ASLockRunLoopRightFAdd = Setting.ASLockRunLoopRightFAdd;
		ASLockRunLoopBwd = Setting.ASLockRunLoopBwd;
		BSLockWalkStartFwd = Setting.BSLockWalkStartFwd;
		BSLockWalkStartBwd = Setting.BSLockWalkStartBwd;
		ASLockWalkStartFwdL = Setting.ASLockWalkStartFwdL;
		ASLockWalkStartFwdR = Setting.ASLockWalkStartFwdR;
		ASLockWalkStartBwdL = Setting.ASLockWalkStartBwdL;
		ASLockWalkStartBwdR = Setting.ASLockWalkStartBwdR;
		ASLockWalkStartLeftF = Setting.ASLockWalkStartLeftF;
		ASLockWalkStartLeftB = Setting.ASLockWalkStartLeftB;
		ASLockWalkStartRightF = Setting.ASLockWalkStartRightF;
		ASLockWalkStartRightB = Setting.ASLockWalkStartRightB;
		BSLockRunStartFwd = Setting.BSLockRunStartFwd;
		BSLockRunStartBwd = Setting.BSLockRunStartBwd;
		ASLockRunStartFwdL = Setting.ASLockRunStartFwdL;
		ASLockRunStartFwdR = Setting.ASLockRunStartFwdR;
		ASLockRunStartBwdL = Setting.ASLockRunStartBwdL;
		ASLockRunStartBwdR = Setting.ASLockRunStartBwdR;
		ASLockRunStartLeftF = Setting.ASLockRunStartLeftF;
		ASLockRunStartLeftB = Setting.ASLockRunStartLeftB;
		ASLockRunStartRightF = Setting.ASLockRunStartRightF;
		ASLockRunStartRightB = Setting.ASLockRunStartRightB;
		BSLockWalkTurnF2B = Setting.BSLockWalkTurnF2B;
		BSLockWalkTurnB2F = Setting.BSLockWalkTurnB2F;
		BSLockWalkTurnFR2BL = Setting.BSLockWalkTurnFR2BL;
		BSLockWalkTurnBR2FL = Setting.BSLockWalkTurnBR2FL;
		BSLockWalkTurnBL2FR = Setting.BSLockWalkTurnBL2FR;
		BSLockWalkTurnFL2BR = Setting.BSLockWalkTurnFL2BR;
		BSLockWalkTurnFR2FL = Setting.BSLockWalkTurnFR2FL;
		BSLockWalkTurnFL2FR = Setting.BSLockWalkTurnFL2FR;
		BSLockWalkTurnBL2FL = Setting.BSLockWalkTurnBL2FL;
		BSLockWalkTurnFL2BL = Setting.BSLockWalkTurnFL2BL;
		BSLockWalkTurnBR2FR = Setting.BSLockWalkTurnBR2FR;
		BSLockWalkTurnFR2BR = Setting.BSLockWalkTurnFR2BR;
		BSLockRunTurnF2B = Setting.BSLockRunTurnF2B;
		BSLockRunTurnB2F = Setting.BSLockRunTurnB2F;
		BSLockRunTurnBR2FL = Setting.BSLockRunTurnBR2FL;
		BSLockRunTurnFR2FL = Setting.BSLockRunTurnFR2FL;
		BSLockRunTurnBL2FL = Setting.BSLockRunTurnBL2FL;
		BSLockRunTurnFR2BL = Setting.BSLockRunTurnFR2BL;
		BSLockRunTurnFL2BL = Setting.BSLockRunTurnFL2BL;
		BSLockRunTurnFL2FR = Setting.BSLockRunTurnFL2FR;
		BSLockRunTurnBL2FR = Setting.BSLockRunTurnBL2FR;
		BSLockRunTurnBR2FR = Setting.BSLockRunTurnBR2FR;
		BSLockRunTurnFL2BR = Setting.BSLockRunTurnFL2BR;
		BSLockRunTurnFR2BR = Setting.BSLockRunTurnFR2BR;
		BSLockTurnFRFromFRBL = Setting.BSLockTurnFRFromFRBL;
		BSLockTurnFRFromFLBR = Setting.BSLockTurnFRFromFLBR;
		BSLockTurnBRFromFRBL = Setting.BSLockTurnBRFromFRBL;
		BSLockTurnBRFromFLBR = Setting.BSLockTurnBRFromFLBR;
		BSLockTurnBLFromFRBL = Setting.BSLockTurnBLFromFRBL;
		BSLockTurnBLFromFLBR = Setting.BSLockTurnBLFromFLBR;
		BSLockTurnFLFromFRBL = Setting.BSLockTurnFLFromFRBL;
		BSLockTurnFLFromFLBR = Setting.BSLockTurnFLFromFLBR;
		BSLockTurnStopFL = Setting.BSLockTurnStopFL;
		BSLockTurnStopFR = Setting.BSLockTurnStopFR;
		BSLockTurnStopBL = Setting.BSLockTurnStopBL;
		BSLockTurnStopBR = Setting.BSLockTurnStopBR;
		ASLockWalkStopFwd = Setting.ASLockWalkStopFwd;
		ASLockWalkStopBwd = Setting.ASLockWalkStopBwd;
		ASLockWalkStopLeftF = Setting.ASLockWalkStopLeftF;
		ASLockWalkStopLeftB = Setting.ASLockWalkStopLeftB;
		ASLockWalkStopRightF = Setting.ASLockWalkStopRightF;
		ASLockWalkStopRightB = Setting.ASLockWalkStopRightB;
		ASLockWalkStopFL45 = Setting.ASLockWalkStopFL45;
		ASLockWalkStopFR45 = Setting.ASLockWalkStopFR45;
		ASLockWalkStopBL45 = Setting.ASLockWalkStopBL45;
		ASLockWalkStopBR45 = Setting.ASLockWalkStopBR45;
		ASLockRunStopFwdL = Setting.ASLockRunStopFwdL;
		ASLockRunStopFwdR = Setting.ASLockRunStopFwdR;
		ASLockRunStopLeftF = Setting.ASLockRunStopLeftF;
		ASLockRunStopLeftB = Setting.ASLockRunStopLeftB;
		ASLockRunStopRightF = Setting.ASLockRunStopRightF;
		ASLockRunStopRightB = Setting.ASLockRunStopRightB;
		ASLockRunStopBwdL = Setting.ASLockRunStopBwdL;
		ASLockRunStopBwdR = Setting.ASLockRunStopBwdR;
	}
}
