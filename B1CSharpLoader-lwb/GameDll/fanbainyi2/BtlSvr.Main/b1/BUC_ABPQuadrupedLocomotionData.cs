using b1.BGU.BUAnim;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_ABPQuadrupedLocomotionData : IBUC_ABPQuadrupedLocomotionData
{
	private IBUC_SimpleJumpData SimpleJumpData;

	private bool bIsAI;

	public EGaitGroundedState GaitGroundedState { get; set; }

	public float MoveYaw { get; set; }

	public float SpeedRate { get; set; }

	public float JumpSlopeAngleThreshold { get; set; }

	public EMoveSpeedLevel SpeedRateLevel { get; set; }

	public EMoveSpeedLevel JumpSpeedRateLevel { get; set; }

	public bool bMoveBack { get; set; }

	public bool bToStart { get; set; }

	public bool bToTurn { get; set; }

	public bool bToStop { get; set; }

	public bool bInJump { get; set; }

	public bool bSlopeJump { get; set; }

	public EMoveDirectionFive TurnDirection { get; set; }

	public bool bHasRunStartAnim { get; set; }

	public bool bHasRushStartAnim { get; set; }

	public bool bHasRunTurnAnim { get; set; }

	public bool bHasRushTurnAnim { get; set; }

	public bool bHasWalkStopAnim { get; set; }

	public bool bHasRunStopAnim { get; set; }

	public bool bHasRushStopAnim { get; set; }

	public bool bHasRunFallAnim { get; set; }

	public bool bHasRushFallAnim { get; set; }

	public bool bHasRunLandAnim { get; set; }

	public bool bHasRushLandAnim { get; set; }

	public bool bHasSlopeJumpAnim { get; set; }

	public void Init(AActor Owner, BUABPSettingData Setting, IBUC_SimpleJumpData InSimpleJumpData, bool InIsAI)
	{
		SimpleJumpData = InSimpleJumpData;
		bIsAI = InIsAI;
		if (b1.BGU.BUAnim.AbpHelperUtil.ShouldInitABPMoveModeData(Owner, EABPMoveMode.QuadrupedLocomotion, Setting))
		{
			BUABPQuadrupedLocomotionSettingData quadrupedLocomotionSetting = Setting.QuadrupedLocomotionSetting;
			bHasRunStartAnim = quadrupedLocomotionSetting.ASRunStartF != null && quadrupedLocomotionSetting.ASRunStartL != null && quadrupedLocomotionSetting.ASRunStartR != null && quadrupedLocomotionSetting.ASRunStartBL != null && quadrupedLocomotionSetting.ASRunStartBR != null;
			bHasRushStartAnim = quadrupedLocomotionSetting.ASRushStartF != null && quadrupedLocomotionSetting.ASRushStartL != null && quadrupedLocomotionSetting.ASRushStartR != null && quadrupedLocomotionSetting.ASRushStartBL != null && quadrupedLocomotionSetting.ASRushStartBR != null;
			bHasRunTurnAnim = quadrupedLocomotionSetting.ASRunTurnL != null && quadrupedLocomotionSetting.ASRunTurnR != null && quadrupedLocomotionSetting.ASRunTurnBL != null && quadrupedLocomotionSetting.ASRunTurnBR != null;
			bHasRushTurnAnim = quadrupedLocomotionSetting.ASRushTurnL != null && quadrupedLocomotionSetting.ASRushTurnR != null && quadrupedLocomotionSetting.ASRushTurnBL != null && quadrupedLocomotionSetting.ASRushTurnBR != null;
			bHasWalkStopAnim = quadrupedLocomotionSetting.ASWalkStop != null;
			bHasRunStopAnim = quadrupedLocomotionSetting.ASRunStop != null;
			bHasRushStopAnim = quadrupedLocomotionSetting.ASRushStop != null;
			bHasRunFallAnim = quadrupedLocomotionSetting.ASRunFall != null;
			bHasRushFallAnim = quadrupedLocomotionSetting.ASRushFall != null;
			bHasRunLandAnim = quadrupedLocomotionSetting.ASRunLandMove != null && quadrupedLocomotionSetting.ASRunLandStop != null;
			bHasRushLandAnim = quadrupedLocomotionSetting.ASRushLandMove != null && quadrupedLocomotionSetting.ASRushLandStop != null;
			bHasSlopeJumpAnim = quadrupedLocomotionSetting.ASRunJumpSlope != null && quadrupedLocomotionSetting.ASRushJumpSlope != null;
			JumpSlopeAngleThreshold = quadrupedLocomotionSetting.JumpSlopeAngleThreahold;
		}
	}

	public void Update(AActor Owner, IBUC_ABPCharacterData ChrData, IBUC_ABPBasicData BasicData, IBUC_ABPCommonSettingData CommonData, IBUC_ABPCommonLocomotionData LocomotionData, float DeltaTime)
	{
		if (CommonData.FinalABPMoveMode != EABPMoveMode.QuadrupedLocomotion)
		{
			GaitGroundedState = EGaitGroundedState.None;
			MoveYaw = 0f;
			SpeedRate = 0f;
			return;
		}
		bool flag = bInJump;
		bInJump = SimpleJumpData.IsRootMotionJump;
		if (bInJump)
		{
			if (!flag && bHasSlopeJumpAnim && JumpSlopeAngleThreshold > 0f)
			{
				FVector SurfaceNormal_Normalized;
				FRotator a = BGUFunctionLibraryCS.BGUCalcCharacterRotOnSlope(Owner as ACharacter, out SurfaceNormal_Normalized);
				bSlopeJump = MathLib.NormalizedDeltaRotator(a, ChrData.ActorRotation).Pitch >= JumpSlopeAngleThreshold;
			}
			JumpSpeedRateLevel = SpeedRateLevel;
			return;
		}
		FRotator zeroRotator = FRotator.ZeroRotator;
		float target = 0f;
		EGaitGroundedState gaitGroundedState = GaitGroundedState;
		MoveYaw = 0f;
		bToStop = false;
		if (ChrData.MoveAcceleration.IsNearlyZero())
		{
			GaitGroundedState = EGaitGroundedState.Idle;
			if (SpeedRateLevel == EMoveSpeedLevel.Walk && bHasWalkStopAnim)
			{
				bToStop = true;
			}
			if (SpeedRateLevel == EMoveSpeedLevel.Run && bHasRunStopAnim)
			{
				bToStop = true;
			}
			if (SpeedRateLevel == EMoveSpeedLevel.Sprint && bHasRushStopAnim)
			{
				bToStop = true;
			}
			if (bMoveBack)
			{
				bToStop = false;
			}
			return;
		}
		switch (BasicData.MoveSpeedState)
		{
		case EMoveSpeedLevel.Walk:
			GaitGroundedState = EGaitGroundedState.Walk;
			target = 1f;
			break;
		case EMoveSpeedLevel.Run:
			GaitGroundedState = EGaitGroundedState.Run;
			target = 2f;
			break;
		case EMoveSpeedLevel.Sprint:
			GaitGroundedState = EGaitGroundedState.Rush;
			target = 3f;
			break;
		}
		bToStart = false;
		if ((gaitGroundedState == EGaitGroundedState.Idle || gaitGroundedState == EGaitGroundedState.None) && GaitGroundedState != EGaitGroundedState.Idle)
		{
			bool flag2 = false;
			if (GaitGroundedState == EGaitGroundedState.Run && bHasRunStartAnim)
			{
				flag2 = true;
				SpeedRateLevel = EMoveSpeedLevel.Run;
			}
			if (GaitGroundedState == EGaitGroundedState.Rush && bHasRushStartAnim)
			{
				flag2 = true;
				SpeedRateLevel = EMoveSpeedLevel.Sprint;
			}
			if (flag2)
			{
				bToStart = true;
				TurnDirection = LocomotionData.MoveInputDirectionFive;
				return;
			}
		}
		bToTurn = false;
		if (BasicData.Speed > 0.1f && FVector.DotProduct(ChrData.Velocity.GetSafeNormal(), ChrData.MoveAcceleration.GetSafeNormal()) <= -0.5f)
		{
			bool flag3 = false;
			if (SpeedRateLevel == EMoveSpeedLevel.Run && bHasRunTurnAnim)
			{
				flag3 = true;
			}
			if (SpeedRateLevel == EMoveSpeedLevel.Sprint && bHasRushTurnAnim)
			{
				flag3 = true;
			}
			if (flag3)
			{
				bToTurn = true;
				TurnDirection = LocomotionData.MoveInputDirectionFive;
				return;
			}
		}
		zeroRotator = MathLib.NormalizedDeltaRotator(ChrData.MoveAcceleration.Rotation(), ChrData.ActorRotation);
		bMoveBack = !bIsAI && GaitGroundedState == EGaitGroundedState.Walk && FMath.Abs(zeroRotator.Yaw) >= 150f;
		MoveYaw = (bMoveBack ? MathLib.NormalizedDeltaRotator((-ChrData.ActorRotation.GetForwardVector()).Rotation(), ChrData.MoveAcceleration.Rotation()) : zeroRotator).Yaw;
		SpeedRate = FMath.FInterpTo(SpeedRate, target, DeltaTime, 10f);
		SpeedRateLevel = EMoveSpeedLevel.Run;
		if (SpeedRate >= 2.5f)
		{
			SpeedRateLevel = EMoveSpeedLevel.Sprint;
		}
		if (SpeedRate < 1.5f)
		{
			SpeedRateLevel = EMoveSpeedLevel.Walk;
		}
	}
}
