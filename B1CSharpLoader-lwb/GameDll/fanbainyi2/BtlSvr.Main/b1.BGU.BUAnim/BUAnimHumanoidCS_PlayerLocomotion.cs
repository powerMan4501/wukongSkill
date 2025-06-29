using System;
using System.Collections.Generic;
using UnrealEngine.AnimGraphRuntime;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGU.BUAnim;

[Blueprintable]
[Abstract]
[UClass]
[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion")]
public class BUAnimHumanoidCS_PlayerLocomotion : BUAnimHumanoidCS_LinkedInstanceBase
{
	private IBUC_ABPBasicData BasicData;

	private IBUC_ABPCharacterData ChrData;

	private IBUC_ABPPlayerLocomotionData PlayerLocomotionData;

	private IBUC_ABPCommonSettingData CommonData;

	private List<UAnimSequence> AnimIdleList = new List<UAnimSequence>();

	private UAnimSequence ASSequenceTransitionMoveFromWalkLFoot;

	private UAnimSequence ASSequenceTransitionMoveFromWalkRFoot;

	private UAnimSequence ASSequenceTransitionMoveFromRunLFoot;

	private UAnimSequence ASSequenceTransitionMoveFromRunRFoot;

	private UAnimSequence ASSequenceTransitionMoveFromRushLFoot;

	private UAnimSequence ASSequenceTransitionMoveFromRushRFoot;

	private EGaitGroundedState GaitGroundedState;

	private EGaitGroundedState LastMoveGaitGroundedState;

	private EGaitGroundedState LastFrameGaitGroundedState;

	private readonly FVector2D FRRange = new FVector2D(0.0, 90.0);

	private readonly FVector2D BRRange = new FVector2D(90.0, 180.0);

	private readonly FVector2D FLRange = new FVector2D(0.0, -90.0);

	private readonly FVector2D BLRange = new FVector2D(-90.0, -180.0);

	private readonly FVector2D InverseFRRange = new FVector2D(90.0, 0.0);

	private readonly FVector2D InverseBRRange = new FVector2D(180.0, 90.0);

	private readonly FVector2D InverseFLRange = new FVector2D(-90.0, 0.0);

	private readonly FVector2D InverseBLRange = new FVector2D(-180.0, -90.0);

	private readonly FVector2D AlphaRange = new FVector2D(0.0, 1.0);

	private readonly FVector2D AlphaRange1 = new FVector2D(0.20000000298023224, 1.0);

	private readonly FVector2D StrideWarpingAccelerationRange = new FVector2D(0.0, 140.0);

	private float SprintStopSlopeAngleThreshold;

	private static bool BSFreeAdditiveMovingLean_IsValid;

	private static int BSFreeAdditiveMovingLean_Offset;

	private static bool FreeAdditiveMovingLeanX_IsValid;

	private static int FreeAdditiveMovingLeanX_Offset;

	private static bool FreeAdditiveMovingLeanY_IsValid;

	private static int FreeAdditiveMovingLeanY_Offset;

	private static bool FreeAdditiveMovingLeanAlpha_IsValid;

	private static int FreeAdditiveMovingLeanAlpha_Offset;

	private static bool ASFreeSprintStartF_IsValid;

	private static int ASFreeSprintStartF_Offset;

	private static bool ASFreeSprintStartL_IsValid;

	private static int ASFreeSprintStartL_Offset;

	private static bool ASFreeSprintStartR_IsValid;

	private static int ASFreeSprintStartR_Offset;

	private static bool ASFreeSprintStartBwdL_IsValid;

	private static int ASFreeSprintStartBwdL_Offset;

	private static bool ASFreeSprintStartBwdR_IsValid;

	private static int ASFreeSprintStartBwdR_Offset;

	private static bool ASFreeSprintTurnL_IsValid;

	private static int ASFreeSprintTurnL_Offset;

	private static bool ASFreeSprintTurnR_IsValid;

	private static int ASFreeSprintTurnR_Offset;

	private static bool ASFreeSprintTurnBwdL_IsValid;

	private static int ASFreeSprintTurnBwdL_Offset;

	private static bool ASFreeSprintTurnBwdR_IsValid;

	private static int ASFreeSprintTurnBwdR_Offset;

	private static bool ASFreeRunStop_IsValid;

	private static int ASFreeRunStop_Offset;

	private static bool ASFreeSprintStop_IsValid;

	private static int ASFreeSprintStop_Offset;

	private static bool ASFreeSprintStopSlopeUp_IsValid;

	private static int ASFreeSprintStopSlopeUp_Offset;

	private static bool BSLockWalkTurnF2B_IsValid;

	private static int BSLockWalkTurnF2B_Offset;

	private static bool BSLockWalkTurnB2F_IsValid;

	private static int BSLockWalkTurnB2F_Offset;

	private static bool BSLockRunTurnF2B_IsValid;

	private static int BSLockRunTurnF2B_Offset;

	private static bool BSLockRunTurnB2F_IsValid;

	private static int BSLockRunTurnB2F_Offset;

	private static bool BSWalkLoopFwd_IsValid;

	private static int BSWalkLoopFwd_Offset;

	private static bool VelocityDeltaAngle_IsValid;

	private static int VelocityDeltaAngle_Offset;

	private static bool VelocityDeltaAngleWalk_IsValid;

	private static int VelocityDeltaAngleWalk_Offset;

	private static bool VelocityDeltaAngleRun_IsValid;

	private static int VelocityDeltaAngleRun_Offset;

	private static bool VelocityDeltaAngleRush_IsValid;

	private static int VelocityDeltaAngleRush_Offset;

	private static bool SlopeAngle_IsValid;

	private static int SlopeAngle_Offset;

	private static bool BSRunLoopFwd_IsValid;

	private static int BSRunLoopFwd_Offset;

	private static bool AnimRateWalk_IsValid;

	private static int AnimRateWalk_Offset;

	private static bool AnimRateRun_IsValid;

	private static int AnimRateRun_Offset;

	private static bool AnimRateRush_IsValid;

	private static int AnimRateRush_Offset;

	private static bool AnimRateRunLock_IsValid;

	private static int AnimRateRunLock_Offset;

	private static bool BSRunLoopAdditive_IsValid;

	private static int BSRunLoopAdditive_Offset;

	private static bool BSRunLoopRotationAdditive_IsValid;

	private static int BSRunLoopRotationAdditive_Offset;

	private static bool FreeAdditiveMovingLeanSmoothX_IsValid;

	private static int FreeAdditiveMovingLeanSmoothX_Offset;

	private static bool FreeAdditiveMovingLeanSmoothY_IsValid;

	private static int FreeAdditiveMovingLeanSmoothY_Offset;

	private static bool BSRushLoopFwd_IsValid;

	private static int BSRushLoopFwd_Offset;

	private static bool BSRushLoopLean_IsValid;

	private static int BSRushLoopLean_Offset;

	private static bool ASWalkStartBwdL_IsValid;

	private static int ASWalkStartBwdL_Offset;

	private static bool ASWalkStartLeft_IsValid;

	private static int ASWalkStartLeft_Offset;

	private static bool ASWalkStartFwd_IsValid;

	private static int ASWalkStartFwd_Offset;

	private static bool ASWalkStartRight_IsValid;

	private static int ASWalkStartRight_Offset;

	private static bool ASWalkStartBwdR_IsValid;

	private static int ASWalkStartBwdR_Offset;

	private static bool ASWalkTurnBwdL_IsValid;

	private static int ASWalkTurnBwdL_Offset;

	private static bool ASWalkTurnLeft_IsValid;

	private static int ASWalkTurnLeft_Offset;

	private static bool ASWalkTurnRight_IsValid;

	private static int ASWalkTurnRight_Offset;

	private static bool ASWalkTurnBwdR_IsValid;

	private static int ASWalkTurnBwdR_Offset;

	private static bool WalkStartAngle_IsValid;

	private static int WalkStartAngle_Offset;

	private static bool ASRunStartBwdL_IsValid;

	private static int ASRunStartBwdL_Offset;

	private static bool ASRunStartLeft_IsValid;

	private static int ASRunStartLeft_Offset;

	private static bool ASRunStartFwd_IsValid;

	private static int ASRunStartFwd_Offset;

	private static bool ASRunStartRight_IsValid;

	private static int ASRunStartRight_Offset;

	private static bool ASRunStartBwdR_IsValid;

	private static int ASRunStartBwdR_Offset;

	private static bool ASRunTurnBwdL_IsValid;

	private static int ASRunTurnBwdL_Offset;

	private static bool ASRunTurnLeft_IsValid;

	private static int ASRunTurnLeft_Offset;

	private static bool ASRunTurnRight_IsValid;

	private static int ASRunTurnRight_Offset;

	private static bool ASRunTurnBwdR_IsValid;

	private static int ASRunTurnBwdR_Offset;

	private static bool ASRunTurnBwdFallingVelocityAdditive_IsValid;

	private static int ASRunTurnBwdFallingVelocityAdditive_Offset;

	private static bool ASRunTurnBwdFallingVelocityAdditiveAlpha_IsValid;

	private static int ASRunTurnBwdFallingVelocityAdditiveAlpha_Offset;

	private static bool ASRunTurnFwdL_IsValid;

	private static int ASRunTurnFwdL_Offset;

	private static bool ASRunTurnFwdR_IsValid;

	private static int ASRunTurnFwdR_Offset;

	private static bool ASRunTurnFwdFallingVelocityAdditive_IsValid;

	private static int ASRunTurnFwdFallingVelocityAdditive_Offset;

	private static bool ASRunTurnFwdFallingVelocityAdditiveAlpha_IsValid;

	private static int ASRunTurnFwdFallingVelocityAdditiveAlpha_Offset;

	private static bool ASRunTurnFwdSpeedAdditive_IsValid;

	private static int ASRunTurnFwdSpeedAdditive_Offset;

	private static bool ASRunTurnFwdSpeedAdditiveAlpha_IsValid;

	private static int ASRunTurnFwdSpeedAdditiveAlpha_Offset;

	private static bool RunStartAngle_IsValid;

	private static int RunStartAngle_Offset;

	private static bool RushStartAngle_IsValid;

	private static int RushStartAngle_Offset;

	private static bool ASFreeWalkStop_IsValid;

	private static int ASFreeWalkStop_Offset;

	private static bool BSLockWalkStartFwd_IsValid;

	private static int BSLockWalkStartFwd_Offset;

	private static bool BSLockWalkStartBwd_IsValid;

	private static int BSLockWalkStartBwd_Offset;

	private static bool ASLockWalkStartFwdL_IsValid;

	private static int ASLockWalkStartFwdL_Offset;

	private static bool ASLockWalkStartFwdR_IsValid;

	private static int ASLockWalkStartFwdR_Offset;

	private static bool ASLockWalkStartBwdL_IsValid;

	private static int ASLockWalkStartBwdL_Offset;

	private static bool ASLockWalkStartBwdR_IsValid;

	private static int ASLockWalkStartBwdR_Offset;

	private static bool ASLockWalkStartLeftF_IsValid;

	private static int ASLockWalkStartLeftF_Offset;

	private static bool ASLockWalkStartLeftB_IsValid;

	private static int ASLockWalkStartLeftB_Offset;

	private static bool ASLockWalkStartRightF_IsValid;

	private static int ASLockWalkStartRightF_Offset;

	private static bool ASLockWalkStartRightB_IsValid;

	private static int ASLockWalkStartRightB_Offset;

	private static bool BSLockRunStartFwd_IsValid;

	private static int BSLockRunStartFwd_Offset;

	private static bool BSLockRunStartBwd_IsValid;

	private static int BSLockRunStartBwd_Offset;

	private static bool ASLockRunStartFwdL_IsValid;

	private static int ASLockRunStartFwdL_Offset;

	private static bool ASLockRunStartFwdR_IsValid;

	private static int ASLockRunStartFwdR_Offset;

	private static bool ASLockRunStartBwdL_IsValid;

	private static int ASLockRunStartBwdL_Offset;

	private static bool ASLockRunStartBwdR_IsValid;

	private static int ASLockRunStartBwdR_Offset;

	private static bool ASLockRunStartLeftF_IsValid;

	private static int ASLockRunStartLeftF_Offset;

	private static bool ASLockRunStartLeftB_IsValid;

	private static int ASLockRunStartLeftB_Offset;

	private static bool ASLockRunStartRightF_IsValid;

	private static int ASLockRunStartRightF_Offset;

	private static bool ASLockRunStartRightB_IsValid;

	private static int ASLockRunStartRightB_Offset;

	private static bool BSLockTurnFRFromFRBL_IsValid;

	private static int BSLockTurnFRFromFRBL_Offset;

	private static bool BSLockTurnFRFromFLBR_IsValid;

	private static int BSLockTurnFRFromFLBR_Offset;

	private static bool BSLockTurnBRFromFRBL_IsValid;

	private static int BSLockTurnBRFromFRBL_Offset;

	private static bool BSLockTurnBRFromFLBR_IsValid;

	private static int BSLockTurnBRFromFLBR_Offset;

	private static bool BSLockTurnBLFromFRBL_IsValid;

	private static int BSLockTurnBLFromFRBL_Offset;

	private static bool BSLockTurnBLFromFLBR_IsValid;

	private static int BSLockTurnBLFromFLBR_Offset;

	private static bool BSLockTurnFLFromFRBL_IsValid;

	private static int BSLockTurnFLFromFRBL_Offset;

	private static bool BSLockTurnFLFromFLBR_IsValid;

	private static int BSLockTurnFLFromFLBR_Offset;

	private static bool LockTurnToAlphaFR_IsValid;

	private static int LockTurnToAlphaFR_Offset;

	private static bool LockTurnToAlphaBR_IsValid;

	private static int LockTurnToAlphaBR_Offset;

	private static bool LockTurnToAlphaBL_IsValid;

	private static int LockTurnToAlphaBL_Offset;

	private static bool LockTurnToAlphaFL_IsValid;

	private static int LockTurnToAlphaFL_Offset;

	private static bool LockTurnFromAlphaFR_IsValid;

	private static int LockTurnFromAlphaFR_Offset;

	private static bool LockTurnFromAlphaBR_IsValid;

	private static int LockTurnFromAlphaBR_Offset;

	private static bool LockTurnFromAlphaBL_IsValid;

	private static int LockTurnFromAlphaBL_Offset;

	private static bool LockTurnFromAlphaFL_IsValid;

	private static int LockTurnFromAlphaFL_Offset;

	private static bool ASLockWalkLoopFwd_IsValid;

	private static int ASLockWalkLoopFwd_Offset;

	private static bool ASLockWalkLoopBwd_IsValid;

	private static int ASLockWalkLoopBwd_Offset;

	private static bool ASLockWalkLoopLeftF_IsValid;

	private static int ASLockWalkLoopLeftF_Offset;

	private static bool ASLockWalkLoopRightF_IsValid;

	private static int ASLockWalkLoopRightF_Offset;

	private static bool ASLockWalkLoopLeftB_IsValid;

	private static int ASLockWalkLoopLeftB_Offset;

	private static bool ASLockWalkLoopRightB_IsValid;

	private static int ASLockWalkLoopRightB_Offset;

	private static bool ASLockWalkLoopLeftFAdd_IsValid;

	private static int ASLockWalkLoopLeftFAdd_Offset;

	private static bool ASLockWalkLoopRightFAdd_IsValid;

	private static int ASLockWalkLoopRightFAdd_Offset;

	private static bool ASLockRunLoopFwd_IsValid;

	private static int ASLockRunLoopFwd_Offset;

	private static bool ASLockRunLoopBwd_IsValid;

	private static int ASLockRunLoopBwd_Offset;

	private static bool ASLockRunLoopLeftF_IsValid;

	private static int ASLockRunLoopLeftF_Offset;

	private static bool ASLockRunLoopRightF_IsValid;

	private static int ASLockRunLoopRightF_Offset;

	private static bool ASLockRunLoopLeftB_IsValid;

	private static int ASLockRunLoopLeftB_Offset;

	private static bool ASLockRunLoopRightB_IsValid;

	private static int ASLockRunLoopRightB_Offset;

	private static bool ASLockRunLoopLeftFAdd_IsValid;

	private static int ASLockRunLoopLeftFAdd_Offset;

	private static bool ASLockRunLoopRightFAdd_IsValid;

	private static int ASLockRunLoopRightFAdd_Offset;

	private static bool BSLockWalkTurnFR2BL_IsValid;

	private static int BSLockWalkTurnFR2BL_Offset;

	private static bool BSLockWalkTurnBR2FL_IsValid;

	private static int BSLockWalkTurnBR2FL_Offset;

	private static bool BSLockWalkTurnBL2FR_IsValid;

	private static int BSLockWalkTurnBL2FR_Offset;

	private static bool BSLockWalkTurnFL2BR_IsValid;

	private static int BSLockWalkTurnFL2BR_Offset;

	private static bool BSLockWalkTurnFR2FL_IsValid;

	private static int BSLockWalkTurnFR2FL_Offset;

	private static bool BSLockWalkTurnFL2FR_IsValid;

	private static int BSLockWalkTurnFL2FR_Offset;

	private static bool BSLockWalkTurnBL2FL_IsValid;

	private static int BSLockWalkTurnBL2FL_Offset;

	private static bool BSLockWalkTurnFL2BL_IsValid;

	private static int BSLockWalkTurnFL2BL_Offset;

	private static bool BSLockWalkTurnBR2FR_IsValid;

	private static int BSLockWalkTurnBR2FR_Offset;

	private static bool BSLockWalkTurnFR2BR_IsValid;

	private static int BSLockWalkTurnFR2BR_Offset;

	private static bool BSLockRunTurnFR2BL_IsValid;

	private static int BSLockRunTurnFR2BL_Offset;

	private static bool BSLockRunTurnBR2FL_IsValid;

	private static int BSLockRunTurnBR2FL_Offset;

	private static bool BSLockRunTurnBL2FR_IsValid;

	private static int BSLockRunTurnBL2FR_Offset;

	private static bool BSLockRunTurnFL2BR_IsValid;

	private static int BSLockRunTurnFL2BR_Offset;

	private static bool BSLockRunTurnFR2FL_IsValid;

	private static int BSLockRunTurnFR2FL_Offset;

	private static bool BSLockRunTurnFL2FR_IsValid;

	private static int BSLockRunTurnFL2FR_Offset;

	private static bool BSLockRunTurnBL2FL_IsValid;

	private static int BSLockRunTurnBL2FL_Offset;

	private static bool BSLockRunTurnFL2BL_IsValid;

	private static int BSLockRunTurnFL2BL_Offset;

	private static bool BSLockRunTurnBR2FR_IsValid;

	private static int BSLockRunTurnBR2FR_Offset;

	private static bool BSLockRunTurnFR2BR_IsValid;

	private static int BSLockRunTurnFR2BR_Offset;

	private static bool BSLockTurnStopFL_IsValid;

	private static int BSLockTurnStopFL_Offset;

	private static bool BSLockTurnStopFR_IsValid;

	private static int BSLockTurnStopFR_Offset;

	private static bool BSLockTurnStopBL_IsValid;

	private static int BSLockTurnStopBL_Offset;

	private static bool BSLockTurnStopBR_IsValid;

	private static int BSLockTurnStopBR_Offset;

	private static bool LockTurnStopAlphaFR_IsValid;

	private static int LockTurnStopAlphaFR_Offset;

	private static bool LockTurnStopAlphaBR_IsValid;

	private static int LockTurnStopAlphaBR_Offset;

	private static bool LockTurnStopAlphaBL_IsValid;

	private static int LockTurnStopAlphaBL_Offset;

	private static bool LockTurnStopAlphaFL_IsValid;

	private static int LockTurnStopAlphaFL_Offset;

	private static bool ASLockWalkStopFwd_IsValid;

	private static int ASLockWalkStopFwd_Offset;

	private static bool ASLockWalkStopBwd_IsValid;

	private static int ASLockWalkStopBwd_Offset;

	private static bool ASLockWalkStopLeftF_IsValid;

	private static int ASLockWalkStopLeftF_Offset;

	private static bool ASLockWalkStopLeftB_IsValid;

	private static int ASLockWalkStopLeftB_Offset;

	private static bool ASLockWalkStopRightF_IsValid;

	private static int ASLockWalkStopRightF_Offset;

	private static bool ASLockWalkStopRightB_IsValid;

	private static int ASLockWalkStopRightB_Offset;

	private static bool ASLockWalkStopFL45_IsValid;

	private static int ASLockWalkStopFL45_Offset;

	private static bool ASLockWalkStopFR45_IsValid;

	private static int ASLockWalkStopFR45_Offset;

	private static bool ASLockWalkStopBL45_IsValid;

	private static int ASLockWalkStopBL45_Offset;

	private static bool ASLockWalkStopBR45_IsValid;

	private static int ASLockWalkStopBR45_Offset;

	private static bool ASLockRunStopFwdL_IsValid;

	private static int ASLockRunStopFwdL_Offset;

	private static bool ASLockRunStopFwdR_IsValid;

	private static int ASLockRunStopFwdR_Offset;

	private static bool ASLockRunStopBwdL_IsValid;

	private static int ASLockRunStopBwdL_Offset;

	private static bool ASLockRunStopBwdR_IsValid;

	private static int ASLockRunStopBwdR_Offset;

	private static bool ASLockRunStopLeftF_IsValid;

	private static int ASLockRunStopLeftF_Offset;

	private static bool ASLockRunStopLeftB_IsValid;

	private static int ASLockRunStopLeftB_Offset;

	private static bool ASLockRunStopRightF_IsValid;

	private static int ASLockRunStopRightF_Offset;

	private static bool ASLockRunStopRightB_IsValid;

	private static int ASLockRunStopRightB_Offset;

	private static bool AnimIdle_IsValid;

	private static int AnimIdle_Offset;

	private static bool MoveSpeedLevel_IsValid;

	private static int MoveSpeedLevel_Offset;

	private static FFieldAddress MoveSpeedLevel_PropertyAddress;

	private static bool MoveSpeedState_IsValid;

	private static int MoveSpeedState_Offset;

	private static FFieldAddress MoveSpeedState_PropertyAddress;

	private static bool InputBlendAlpha_IsValid;

	private static int InputBlendAlpha_Offset;

	private static bool VelocityBlendAlpha_IsValid;

	private static int VelocityBlendAlpha_Offset;

	private static bool VelocityBlendAlphaStop_IsValid;

	private static int VelocityBlendAlphaStop_Offset;

	private static bool bLandingMove_IsValid;

	private static int bLandingMove_Offset;

	private static FFieldAddress bLandingMove_PropertyAddress;

	private static bool LastFallingVelocity_IsValid;

	private static int LastFallingVelocity_Offset;

	private static bool RandomIdleIndex_IsValid;

	private static int RandomIdleIndex_Offset;

	private static bool MoveLoopSpeedState_IsValid;

	private static int MoveLoopSpeedState_Offset;

	private static bool MaxSpeed_IsValid;

	private static int MaxSpeed_Offset;

	private static bool CurveMoveSpeedScale_IsValid;

	private static int CurveMoveSpeedScale_Offset;

	private static bool TargetLockMoveDeltaAngle_IsValid;

	private static int TargetLockMoveDeltaAngle_Offset;

	private static bool InputDeltaAngle_IsValid;

	private static int InputDeltaAngle_Offset;

	private static bool InputDeltaAngleBackward_IsValid;

	private static int InputDeltaAngleBackward_Offset;

	private static bool StrideWarpingSpeed_IsValid;

	private static int StrideWarpingSpeed_Offset;

	private static bool StrideWarpingAlpha_IsValid;

	private static int StrideWarpingAlpha_Offset;

	private static bool bSwitchToLock_IsValid;

	private static int bSwitchToLock_Offset;

	private static FFieldAddress bSwitchToLock_PropertyAddress;

	private static bool bLockMoveF_IsValid;

	private static int bLockMoveF_Offset;

	private static FFieldAddress bLockMoveF_PropertyAddress;

	private static bool bLockMoveB_IsValid;

	private static int bLockMoveB_Offset;

	private static FFieldAddress bLockMoveB_PropertyAddress;

	private static bool bLockMoveL_IsValid;

	private static int bLockMoveL_Offset;

	private static FFieldAddress bLockMoveL_PropertyAddress;

	private static bool bLockMoveR_IsValid;

	private static int bLockMoveR_Offset;

	private static FFieldAddress bLockMoveR_PropertyAddress;

	private static bool bFreeTurn_IsValid;

	private static int bFreeTurn_Offset;

	private static FFieldAddress bFreeTurn_PropertyAddress;

	private static bool bWalkFreeBwdL_IsValid;

	private static int bWalkFreeBwdL_Offset;

	private static FFieldAddress bWalkFreeBwdL_PropertyAddress;

	private static bool bWalkFreeLeft_IsValid;

	private static int bWalkFreeLeft_Offset;

	private static FFieldAddress bWalkFreeLeft_PropertyAddress;

	private static bool bWalkFreeRight_IsValid;

	private static int bWalkFreeRight_Offset;

	private static FFieldAddress bWalkFreeRight_PropertyAddress;

	private static bool bWalkFreeBwdR_IsValid;

	private static int bWalkFreeBwdR_Offset;

	private static FFieldAddress bWalkFreeBwdR_PropertyAddress;

	private static bool bRunFreeBwdL_IsValid;

	private static int bRunFreeBwdL_Offset;

	private static FFieldAddress bRunFreeBwdL_PropertyAddress;

	private static bool bRunFreeTurnLeft_IsValid;

	private static int bRunFreeTurnLeft_Offset;

	private static FFieldAddress bRunFreeTurnLeft_PropertyAddress;

	private static bool bRunFreeTurnRight_IsValid;

	private static int bRunFreeTurnRight_Offset;

	private static FFieldAddress bRunFreeTurnRight_PropertyAddress;

	private static bool bRunFreeStartLeft_IsValid;

	private static int bRunFreeStartLeft_Offset;

	private static FFieldAddress bRunFreeStartLeft_PropertyAddress;

	private static bool bRunFreeStartRight_IsValid;

	private static int bRunFreeStartRight_Offset;

	private static FFieldAddress bRunFreeStartRight_PropertyAddress;

	private static bool bRunFreeBwdR_IsValid;

	private static int bRunFreeBwdR_Offset;

	private static FFieldAddress bRunFreeBwdR_PropertyAddress;

	private static bool bRunFreeTurnFwdL_IsValid;

	private static int bRunFreeTurnFwdL_Offset;

	private static FFieldAddress bRunFreeTurnFwdL_PropertyAddress;

	private static bool bRunFreeTurnLandFwdL_IsValid;

	private static int bRunFreeTurnLandFwdL_Offset;

	private static FFieldAddress bRunFreeTurnLandFwdL_PropertyAddress;

	private static bool bRunFreeTurnLandFwdR_IsValid;

	private static int bRunFreeTurnLandFwdR_Offset;

	private static FFieldAddress bRunFreeTurnLandFwdR_PropertyAddress;

	private static bool bRushFreeBwdL_IsValid;

	private static int bRushFreeBwdL_Offset;

	private static FFieldAddress bRushFreeBwdL_PropertyAddress;

	private static bool bRushFreeLeft_IsValid;

	private static int bRushFreeLeft_Offset;

	private static FFieldAddress bRushFreeLeft_PropertyAddress;

	private static bool bRushFreeRight_IsValid;

	private static int bRushFreeRight_Offset;

	private static FFieldAddress bRushFreeRight_PropertyAddress;

	private static bool bRushFreeBwdR_IsValid;

	private static int bRushFreeBwdR_Offset;

	private static FFieldAddress bRushFreeBwdR_PropertyAddress;

	private static bool bLastRush_IsValid;

	private static int bLastRush_Offset;

	private static FFieldAddress bLastRush_PropertyAddress;

	private static bool bLastRun_IsValid;

	private static int bLastRun_Offset;

	private static FFieldAddress bLastRun_PropertyAddress;

	private static bool bLeftFootFront_IsValid;

	private static int bLeftFootFront_Offset;

	private static FFieldAddress bLeftFootFront_PropertyAddress;

	private static bool bRunStop_IsValid;

	private static int bRunStop_Offset;

	private static FFieldAddress bRunStop_PropertyAddress;

	private static bool bRushStop_IsValid;

	private static int bRushStop_Offset;

	private static FFieldAddress bRushStop_PropertyAddress;

	private static bool bToStop_IsValid;

	private static int bToStop_Offset;

	private static FFieldAddress bToStop_PropertyAddress;

	private static bool bToTurnStop_IsValid;

	private static int bToTurnStop_Offset;

	private static FFieldAddress bToTurnStop_PropertyAddress;

	private static bool bIdleToWalk_IsValid;

	private static int bIdleToWalk_Offset;

	private static FFieldAddress bIdleToWalk_PropertyAddress;

	private static bool bRunToWalk_IsValid;

	private static int bRunToWalk_Offset;

	private static FFieldAddress bRunToWalk_PropertyAddress;

	private static bool bToRun_IsValid;

	private static int bToRun_Offset;

	private static FFieldAddress bToRun_PropertyAddress;

	private static bool bToRush_IsValid;

	private static int bToRush_Offset;

	private static FFieldAddress bToRush_PropertyAddress;

	private static bool bLockMoveFromTurnStopFR_IsValid;

	private static int bLockMoveFromTurnStopFR_Offset;

	private static FFieldAddress bLockMoveFromTurnStopFR_PropertyAddress;

	private static bool bLockMoveFromTurnStopBR_IsValid;

	private static int bLockMoveFromTurnStopBR_Offset;

	private static FFieldAddress bLockMoveFromTurnStopBR_PropertyAddress;

	private static bool bLockMoveFromTurnStopBL_IsValid;

	private static int bLockMoveFromTurnStopBL_Offset;

	private static FFieldAddress bLockMoveFromTurnStopBL_PropertyAddress;

	private static bool bLockMoveFromTurnStopFL_IsValid;

	private static int bLockMoveFromTurnStopFL_Offset;

	private static FFieldAddress bLockMoveFromTurnStopFL_PropertyAddress;

	private static bool bLockMoveTransFromFwd_IsValid;

	private static int bLockMoveTransFromFwd_Offset;

	private static FFieldAddress bLockMoveTransFromFwd_PropertyAddress;

	private static bool bLockMoveTransFromBwd_IsValid;

	private static int bLockMoveTransFromBwd_Offset;

	private static FFieldAddress bLockMoveTransFromBwd_PropertyAddress;

	private static bool bLockMoveTransFromFL_IsValid;

	private static int bLockMoveTransFromFL_Offset;

	private static FFieldAddress bLockMoveTransFromFL_PropertyAddress;

	private static bool bLockMoveTransFromFR_IsValid;

	private static int bLockMoveTransFromFR_Offset;

	private static FFieldAddress bLockMoveTransFromFR_PropertyAddress;

	private static bool bLockMoveTransFromBL_IsValid;

	private static int bLockMoveTransFromBL_Offset;

	private static FFieldAddress bLockMoveTransFromBL_PropertyAddress;

	private static bool bLockMoveTransFromBR_IsValid;

	private static int bLockMoveTransFromBR_Offset;

	private static FFieldAddress bLockMoveTransFromBR_PropertyAddress;

	private static bool bLockMoveFromTurnStop_IsValid;

	private static int bLockMoveFromTurnStop_Offset;

	private static FFieldAddress bLockMoveFromTurnStop_PropertyAddress;

	private static bool bInLockMoveState_IsValid;

	private static int bInLockMoveState_Offset;

	private static FFieldAddress bInLockMoveState_PropertyAddress;

	private static bool bLockMoveTurnStart_IsValid;

	private static int bLockMoveTurnStart_Offset;

	private static FFieldAddress bLockMoveTurnStart_PropertyAddress;

	private static bool bLockMoveToFwdLoop_IsValid;

	private static int bLockMoveToFwdLoop_Offset;

	private static FFieldAddress bLockMoveToFwdLoop_PropertyAddress;

	private static bool bLockMoveToBwdLoop_IsValid;

	private static int bLockMoveToBwdLoop_Offset;

	private static FFieldAddress bLockMoveToBwdLoop_PropertyAddress;

	private static bool bLockMoveToFLLoop_IsValid;

	private static int bLockMoveToFLLoop_Offset;

	private static FFieldAddress bLockMoveToFLLoop_PropertyAddress;

	private static bool bLockMoveToBLLoop_IsValid;

	private static int bLockMoveToBLLoop_Offset;

	private static FFieldAddress bLockMoveToBLLoop_PropertyAddress;

	private static bool bLockMoveToFRLoop_IsValid;

	private static int bLockMoveToFRLoop_Offset;

	private static FFieldAddress bLockMoveToFRLoop_PropertyAddress;

	private static bool bLockMoveToBRLoop_IsValid;

	private static int bLockMoveToBRLoop_Offset;

	private static FFieldAddress bLockMoveToBRLoop_PropertyAddress;

	private static bool bLockMoveStartFwd_IsValid;

	private static int bLockMoveStartFwd_Offset;

	private static FFieldAddress bLockMoveStartFwd_PropertyAddress;

	private static bool bLockMoveStartBwd_IsValid;

	private static int bLockMoveStartBwd_Offset;

	private static FFieldAddress bLockMoveStartBwd_PropertyAddress;

	private static bool bLockMoveStartFL_IsValid;

	private static int bLockMoveStartFL_Offset;

	private static FFieldAddress bLockMoveStartFL_PropertyAddress;

	private static bool bLockMoveStartFR_IsValid;

	private static int bLockMoveStartFR_Offset;

	private static FFieldAddress bLockMoveStartFR_PropertyAddress;

	private static bool bLockMoveStartBL_IsValid;

	private static int bLockMoveStartBL_Offset;

	private static FFieldAddress bLockMoveStartBL_PropertyAddress;

	private static bool bLockMoveStartBR_IsValid;

	private static int bLockMoveStartBR_Offset;

	private static FFieldAddress bLockMoveStartBR_PropertyAddress;

	private static bool bLockMoveFRToFwd_IsValid;

	private static int bLockMoveFRToFwd_Offset;

	private static FFieldAddress bLockMoveFRToFwd_PropertyAddress;

	private static bool bLockMoveFRToFL_IsValid;

	private static int bLockMoveFRToFL_Offset;

	private static FFieldAddress bLockMoveFRToFL_PropertyAddress;

	private static bool bLockMoveBRToBwd_IsValid;

	private static int bLockMoveBRToBwd_Offset;

	private static FFieldAddress bLockMoveBRToBwd_PropertyAddress;

	private static bool bLockMoveBLToBwd_IsValid;

	private static int bLockMoveBLToBwd_Offset;

	private static FFieldAddress bLockMoveBLToBwd_PropertyAddress;

	private static bool bLockMoveFLToFwd_IsValid;

	private static int bLockMoveFLToFwd_Offset;

	private static FFieldAddress bLockMoveFLToFwd_PropertyAddress;

	private static bool bLockMoveFLToFR_IsValid;

	private static int bLockMoveFLToFR_Offset;

	private static FFieldAddress bLockMoveFLToFR_PropertyAddress;

	private static bool bLockMoveToTurnStopFR_IsValid;

	private static int bLockMoveToTurnStopFR_Offset;

	private static FFieldAddress bLockMoveToTurnStopFR_PropertyAddress;

	private static bool bLockMoveToTurnStopBR_IsValid;

	private static int bLockMoveToTurnStopBR_Offset;

	private static FFieldAddress bLockMoveToTurnStopBR_PropertyAddress;

	private static bool bLockMoveToTurnStopBL_IsValid;

	private static int bLockMoveToTurnStopBL_Offset;

	private static FFieldAddress bLockMoveToTurnStopBL_PropertyAddress;

	private static bool bLockMoveToTurnStopFL_IsValid;

	private static int bLockMoveToTurnStopFL_Offset;

	private static FFieldAddress bLockMoveToTurnStopFL_PropertyAddress;

	private static bool bLockWalk_IsValid;

	private static int bLockWalk_Offset;

	private static FFieldAddress bLockWalk_PropertyAddress;

	private static bool bLockRun_IsValid;

	private static int bLockRun_Offset;

	private static FFieldAddress bLockRun_PropertyAddress;

	private static bool bLockStopFwd_IsValid;

	private static int bLockStopFwd_Offset;

	private static FFieldAddress bLockStopFwd_PropertyAddress;

	private static bool bLockStopBwd_IsValid;

	private static int bLockStopBwd_Offset;

	private static FFieldAddress bLockStopBwd_PropertyAddress;

	private static bool bLockStopLeft_IsValid;

	private static int bLockStopLeft_Offset;

	private static FFieldAddress bLockStopLeft_PropertyAddress;

	private static bool bLockStopRight_IsValid;

	private static int bLockStopRight_Offset;

	private static FFieldAddress bLockStopRight_PropertyAddress;

	private static bool bLockStopFL_IsValid;

	private static int bLockStopFL_Offset;

	private static FFieldAddress bLockStopFL_PropertyAddress;

	private static bool bLockStopFR_IsValid;

	private static int bLockStopFR_Offset;

	private static FFieldAddress bLockStopFR_PropertyAddress;

	private static bool bLockStopBL_IsValid;

	private static int bLockStopBL_Offset;

	private static FFieldAddress bLockStopBL_PropertyAddress;

	private static bool bLockStopBR_IsValid;

	private static int bLockStopBR_Offset;

	private static FFieldAddress bLockStopBR_PropertyAddress;

	private static bool bInSequenceTransition_IsValid;

	private static int bInSequenceTransition_Offset;

	private static FFieldAddress bInSequenceTransition_PropertyAddress;

	private static bool bToSequenceTransitionMove_IsValid;

	private static int bToSequenceTransitionMove_Offset;

	private static FFieldAddress bToSequenceTransitionMove_PropertyAddress;

	private static bool bSequenceTransitionFromWalk_IsValid;

	private static int bSequenceTransitionFromWalk_Offset;

	private static FFieldAddress bSequenceTransitionFromWalk_PropertyAddress;

	private static bool bSequenceTransitionFromRun_IsValid;

	private static int bSequenceTransitionFromRun_Offset;

	private static FFieldAddress bSequenceTransitionFromRun_PropertyAddress;

	private static bool bSequenceTransitionFromRush_IsValid;

	private static int bSequenceTransitionFromRush_Offset;

	private static FFieldAddress bSequenceTransitionFromRush_PropertyAddress;

	private static bool OnLeftSeqMove_IsValid;

	private static IntPtr OnLeftSeqMove_FunctionAddress;

	private static int OnLeftSeqMove_ParamsSize;

	private static bool OnEnterSeqMove_IsValid;

	private static IntPtr OnEnterSeqMove_FunctionAddress;

	private static int OnEnterSeqMove_ParamsSize;

	private static bool SetUpRushStopAnim_IsValid;

	private static IntPtr SetUpRushStopAnim_FunctionAddress;

	private static int SetUpRushStopAnim_ParamsSize;

	private static bool SetUpRushStopAnim_Context_IsValid;

	private static int SetUpRushStopAnim_Context_Offset;

	private static FFieldAddress SetUpRushStopAnim_Context_PropertyAddress;

	private static bool SetUpRushStopAnim_Node_IsValid;

	private static int SetUpRushStopAnim_Node_Offset;

	private static FFieldAddress SetUpRushStopAnim_Node_PropertyAddress;

	private static bool GetRandomIdleAnim_IsValid;

	private static IntPtr GetRandomIdleAnim_FunctionAddress;

	private static int GetRandomIdleAnim_ParamsSize;

	private static bool GetRandomIdleAnim_Context_IsValid;

	private static int GetRandomIdleAnim_Context_Offset;

	private static FFieldAddress GetRandomIdleAnim_Context_PropertyAddress;

	private static bool GetRandomIdleAnim_Node_IsValid;

	private static int GetRandomIdleAnim_Node_Offset;

	private static FFieldAddress GetRandomIdleAnim_Node_PropertyAddress;

	private static bool SetupSequenceTransitionAnim_IsValid;

	private static IntPtr SetupSequenceTransitionAnim_FunctionAddress;

	private static int SetupSequenceTransitionAnim_ParamsSize;

	private static bool SetupSequenceTransitionAnim_Context_IsValid;

	private static int SetupSequenceTransitionAnim_Context_Offset;

	private static FFieldAddress SetupSequenceTransitionAnim_Context_PropertyAddress;

	private static bool SetupSequenceTransitionAnim_Node_IsValid;

	private static int SetupSequenceTransitionAnim_Node_Offset;

	private static FFieldAddress SetupSequenceTransitionAnim_Node_PropertyAddress;

	[Category("PlayerLocomotion_Free")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSFreeAdditiveMovingLean")]
	public UBlendSpace BSFreeAdditiveMovingLean
	{
		get
		{
			CheckDestroyed();
			if (!BSFreeAdditiveMovingLean_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSFreeAdditiveMovingLean");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSFreeAdditiveMovingLean_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSFreeAdditiveMovingLean_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSFreeAdditiveMovingLean");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSFreeAdditiveMovingLean_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("PlayerLocomotion_Free")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:FreeAdditiveMovingLeanX")]
	public float FreeAdditiveMovingLeanX
	{
		get
		{
			CheckDestroyed();
			if (!FreeAdditiveMovingLeanX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:FreeAdditiveMovingLeanX");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FreeAdditiveMovingLeanX_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FreeAdditiveMovingLeanX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:FreeAdditiveMovingLeanX");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FreeAdditiveMovingLeanX_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion_Free")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:FreeAdditiveMovingLeanY")]
	public float FreeAdditiveMovingLeanY
	{
		get
		{
			CheckDestroyed();
			if (!FreeAdditiveMovingLeanY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:FreeAdditiveMovingLeanY");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FreeAdditiveMovingLeanY_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FreeAdditiveMovingLeanY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:FreeAdditiveMovingLeanY");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FreeAdditiveMovingLeanY_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion_Free")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:FreeAdditiveMovingLeanAlpha")]
	public float FreeAdditiveMovingLeanAlpha
	{
		get
		{
			CheckDestroyed();
			if (!FreeAdditiveMovingLeanAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:FreeAdditiveMovingLeanAlpha");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FreeAdditiveMovingLeanAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FreeAdditiveMovingLeanAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:FreeAdditiveMovingLeanAlpha");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FreeAdditiveMovingLeanAlpha_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("PlayerLocomotion_Free_Start")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASFreeSprintStartF")]
	public UAnimSequence ASFreeSprintStartF
	{
		get
		{
			CheckDestroyed();
			if (!ASFreeSprintStartF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASFreeSprintStartF");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASFreeSprintStartF_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASFreeSprintStartF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASFreeSprintStartF");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASFreeSprintStartF_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion_Free_Start")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASFreeSprintStartL")]
	public UAnimSequence ASFreeSprintStartL
	{
		get
		{
			CheckDestroyed();
			if (!ASFreeSprintStartL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASFreeSprintStartL");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASFreeSprintStartL_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASFreeSprintStartL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASFreeSprintStartL");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASFreeSprintStartL_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion_Free_Start")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASFreeSprintStartR")]
	public UAnimSequence ASFreeSprintStartR
	{
		get
		{
			CheckDestroyed();
			if (!ASFreeSprintStartR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASFreeSprintStartR");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASFreeSprintStartR_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASFreeSprintStartR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASFreeSprintStartR");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASFreeSprintStartR_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion_Free_Start")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASFreeSprintStartBwdL")]
	public UAnimSequence ASFreeSprintStartBwdL
	{
		get
		{
			CheckDestroyed();
			if (!ASFreeSprintStartBwdL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASFreeSprintStartBwdL");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASFreeSprintStartBwdL_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASFreeSprintStartBwdL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASFreeSprintStartBwdL");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASFreeSprintStartBwdL_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion_Free_Start")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASFreeSprintStartBwdR")]
	public UAnimSequence ASFreeSprintStartBwdR
	{
		get
		{
			CheckDestroyed();
			if (!ASFreeSprintStartBwdR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASFreeSprintStartBwdR");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASFreeSprintStartBwdR_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASFreeSprintStartBwdR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASFreeSprintStartBwdR");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASFreeSprintStartBwdR_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("PlayerLocomotion_Free_Turn")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASFreeSprintTurnL")]
	public UAnimSequence ASFreeSprintTurnL
	{
		get
		{
			CheckDestroyed();
			if (!ASFreeSprintTurnL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASFreeSprintTurnL");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASFreeSprintTurnL_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASFreeSprintTurnL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASFreeSprintTurnL");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASFreeSprintTurnL_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("PlayerLocomotion_Free_Turn")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASFreeSprintTurnR")]
	public UAnimSequence ASFreeSprintTurnR
	{
		get
		{
			CheckDestroyed();
			if (!ASFreeSprintTurnR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASFreeSprintTurnR");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASFreeSprintTurnR_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASFreeSprintTurnR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASFreeSprintTurnR");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASFreeSprintTurnR_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("PlayerLocomotion_Free_Turn")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASFreeSprintTurnBwdL")]
	public UAnimSequence ASFreeSprintTurnBwdL
	{
		get
		{
			CheckDestroyed();
			if (!ASFreeSprintTurnBwdL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASFreeSprintTurnBwdL");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASFreeSprintTurnBwdL_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASFreeSprintTurnBwdL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASFreeSprintTurnBwdL");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASFreeSprintTurnBwdL_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("PlayerLocomotion_Free_Turn")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASFreeSprintTurnBwdR")]
	public UAnimSequence ASFreeSprintTurnBwdR
	{
		get
		{
			CheckDestroyed();
			if (!ASFreeSprintTurnBwdR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASFreeSprintTurnBwdR");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASFreeSprintTurnBwdR_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASFreeSprintTurnBwdR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASFreeSprintTurnBwdR");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASFreeSprintTurnBwdR_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("PlayerLocomotion_Free_Stop")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASFreeRunStop")]
	public UAnimSequence ASFreeRunStop
	{
		get
		{
			CheckDestroyed();
			if (!ASFreeRunStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASFreeRunStop");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASFreeRunStop_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASFreeRunStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASFreeRunStop");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASFreeRunStop_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("PlayerLocomotion_Free_Stop")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASFreeSprintStop")]
	public UAnimSequence ASFreeSprintStop
	{
		get
		{
			CheckDestroyed();
			if (!ASFreeSprintStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASFreeSprintStop");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASFreeSprintStop_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASFreeSprintStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASFreeSprintStop");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASFreeSprintStop_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("PlayerLocomotion_Free_Stop")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASFreeSprintStopSlopeUp")]
	public UAnimSequence ASFreeSprintStopSlopeUp
	{
		get
		{
			CheckDestroyed();
			if (!ASFreeSprintStopSlopeUp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASFreeSprintStopSlopeUp");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASFreeSprintStopSlopeUp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASFreeSprintStopSlopeUp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASFreeSprintStopSlopeUp");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASFreeSprintStopSlopeUp_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion_Lock_Turn")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockWalkTurnF2B")]
	public UBlendSpace BSLockWalkTurnF2B
	{
		get
		{
			CheckDestroyed();
			if (!BSLockWalkTurnF2B_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockWalkTurnF2B");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSLockWalkTurnF2B_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSLockWalkTurnF2B_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockWalkTurnF2B");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSLockWalkTurnF2B_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion_Lock_Turn")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockWalkTurnB2F")]
	public UBlendSpace BSLockWalkTurnB2F
	{
		get
		{
			CheckDestroyed();
			if (!BSLockWalkTurnB2F_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockWalkTurnB2F");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSLockWalkTurnB2F_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSLockWalkTurnB2F_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockWalkTurnB2F");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSLockWalkTurnB2F_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion_Lock_Turn")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockRunTurnF2B")]
	public UBlendSpace BSLockRunTurnF2B
	{
		get
		{
			CheckDestroyed();
			if (!BSLockRunTurnF2B_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockRunTurnF2B");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSLockRunTurnF2B_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSLockRunTurnF2B_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockRunTurnF2B");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSLockRunTurnF2B_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion_Lock_Turn")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockRunTurnB2F")]
	public UBlendSpace BSLockRunTurnB2F
	{
		get
		{
			CheckDestroyed();
			if (!BSLockRunTurnB2F_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockRunTurnB2F");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSLockRunTurnB2F_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSLockRunTurnB2F_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockRunTurnB2F");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSLockRunTurnB2F_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSWalkLoopFwd")]
	public UBlendSpace BSWalkLoopFwd
	{
		get
		{
			CheckDestroyed();
			if (!BSWalkLoopFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSWalkLoopFwd");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSWalkLoopFwd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSWalkLoopFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSWalkLoopFwd");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSWalkLoopFwd_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("PlayerLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:VelocityDeltaAngle")]
	public float VelocityDeltaAngle
	{
		get
		{
			CheckDestroyed();
			if (!VelocityDeltaAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:VelocityDeltaAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, VelocityDeltaAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VelocityDeltaAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:VelocityDeltaAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, VelocityDeltaAngle_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:VelocityDeltaAngleWalk")]
	public float VelocityDeltaAngleWalk
	{
		get
		{
			CheckDestroyed();
			if (!VelocityDeltaAngleWalk_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:VelocityDeltaAngleWalk");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, VelocityDeltaAngleWalk_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VelocityDeltaAngleWalk_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:VelocityDeltaAngleWalk");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, VelocityDeltaAngleWalk_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("PlayerLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:VelocityDeltaAngleRun")]
	public float VelocityDeltaAngleRun
	{
		get
		{
			CheckDestroyed();
			if (!VelocityDeltaAngleRun_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:VelocityDeltaAngleRun");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, VelocityDeltaAngleRun_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VelocityDeltaAngleRun_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:VelocityDeltaAngleRun");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, VelocityDeltaAngleRun_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("PlayerLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:VelocityDeltaAngleRush")]
	public float VelocityDeltaAngleRush
	{
		get
		{
			CheckDestroyed();
			if (!VelocityDeltaAngleRush_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:VelocityDeltaAngleRush");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, VelocityDeltaAngleRush_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VelocityDeltaAngleRush_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:VelocityDeltaAngleRush");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, VelocityDeltaAngleRush_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("PlayerLocomotion")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:SlopeAngle")]
	public float SlopeAngle
	{
		get
		{
			CheckDestroyed();
			if (!SlopeAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:SlopeAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SlopeAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SlopeAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:SlopeAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SlopeAngle_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSRunLoopFwd")]
	public UBlendSpace BSRunLoopFwd
	{
		get
		{
			CheckDestroyed();
			if (!BSRunLoopFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSRunLoopFwd");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSRunLoopFwd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSRunLoopFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSRunLoopFwd");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSRunLoopFwd_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:AnimRateWalk")]
	public float AnimRateWalk
	{
		get
		{
			CheckDestroyed();
			if (!AnimRateWalk_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:AnimRateWalk");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AnimRateWalk_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimRateWalk_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:AnimRateWalk");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AnimRateWalk_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("PlayerLocomotion")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:AnimRateRun")]
	public float AnimRateRun
	{
		get
		{
			CheckDestroyed();
			if (!AnimRateRun_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:AnimRateRun");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AnimRateRun_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimRateRun_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:AnimRateRun");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AnimRateRun_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:AnimRateRush")]
	public float AnimRateRush
	{
		get
		{
			CheckDestroyed();
			if (!AnimRateRush_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:AnimRateRush");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AnimRateRush_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimRateRush_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:AnimRateRush");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AnimRateRush_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:AnimRateRunLock")]
	public float AnimRateRunLock
	{
		get
		{
			CheckDestroyed();
			if (!AnimRateRunLock_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:AnimRateRunLock");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AnimRateRunLock_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimRateRunLock_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:AnimRateRunLock");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AnimRateRunLock_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("PlayerLocomotion")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSRunLoopAdditive")]
	public UBlendSpace BSRunLoopAdditive
	{
		get
		{
			CheckDestroyed();
			if (!BSRunLoopAdditive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSRunLoopAdditive");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSRunLoopAdditive_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSRunLoopAdditive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSRunLoopAdditive");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSRunLoopAdditive_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("PlayerLocomotion")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSRunLoopRotationAdditive")]
	public UBlendSpace BSRunLoopRotationAdditive
	{
		get
		{
			CheckDestroyed();
			if (!BSRunLoopRotationAdditive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSRunLoopRotationAdditive");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSRunLoopRotationAdditive_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSRunLoopRotationAdditive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSRunLoopRotationAdditive");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSRunLoopRotationAdditive_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("PlayerLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:FreeAdditiveMovingLeanSmoothX")]
	public float FreeAdditiveMovingLeanSmoothX
	{
		get
		{
			CheckDestroyed();
			if (!FreeAdditiveMovingLeanSmoothX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:FreeAdditiveMovingLeanSmoothX");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FreeAdditiveMovingLeanSmoothX_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FreeAdditiveMovingLeanSmoothX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:FreeAdditiveMovingLeanSmoothX");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FreeAdditiveMovingLeanSmoothX_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("PlayerLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:FreeAdditiveMovingLeanSmoothY")]
	public float FreeAdditiveMovingLeanSmoothY
	{
		get
		{
			CheckDestroyed();
			if (!FreeAdditiveMovingLeanSmoothY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:FreeAdditiveMovingLeanSmoothY");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FreeAdditiveMovingLeanSmoothY_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FreeAdditiveMovingLeanSmoothY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:FreeAdditiveMovingLeanSmoothY");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FreeAdditiveMovingLeanSmoothY_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("PlayerLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSRushLoopFwd")]
	public UBlendSpace BSRushLoopFwd
	{
		get
		{
			CheckDestroyed();
			if (!BSRushLoopFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSRushLoopFwd");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSRushLoopFwd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSRushLoopFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSRushLoopFwd");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSRushLoopFwd_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSRushLoopLean")]
	public UBlendSpace BSRushLoopLean
	{
		get
		{
			CheckDestroyed();
			if (!BSRushLoopLean_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSRushLoopLean");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSRushLoopLean_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSRushLoopLean_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSRushLoopLean");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSRushLoopLean_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASWalkStartBwdL")]
	public UAnimSequence ASWalkStartBwdL
	{
		get
		{
			CheckDestroyed();
			if (!ASWalkStartBwdL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASWalkStartBwdL");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASWalkStartBwdL_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASWalkStartBwdL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASWalkStartBwdL");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASWalkStartBwdL_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("PlayerLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASWalkStartLeft")]
	public UAnimSequence ASWalkStartLeft
	{
		get
		{
			CheckDestroyed();
			if (!ASWalkStartLeft_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASWalkStartLeft");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASWalkStartLeft_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASWalkStartLeft_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASWalkStartLeft");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASWalkStartLeft_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("PlayerLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASWalkStartFwd")]
	public UAnimSequence ASWalkStartFwd
	{
		get
		{
			CheckDestroyed();
			if (!ASWalkStartFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASWalkStartFwd");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASWalkStartFwd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASWalkStartFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASWalkStartFwd");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASWalkStartFwd_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASWalkStartRight")]
	public UAnimSequence ASWalkStartRight
	{
		get
		{
			CheckDestroyed();
			if (!ASWalkStartRight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASWalkStartRight");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASWalkStartRight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASWalkStartRight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASWalkStartRight");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASWalkStartRight_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("PlayerLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASWalkStartBwdR")]
	public UAnimSequence ASWalkStartBwdR
	{
		get
		{
			CheckDestroyed();
			if (!ASWalkStartBwdR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASWalkStartBwdR");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASWalkStartBwdR_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASWalkStartBwdR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASWalkStartBwdR");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASWalkStartBwdR_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("PlayerLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASWalkTurnBwdL")]
	public UAnimSequence ASWalkTurnBwdL
	{
		get
		{
			CheckDestroyed();
			if (!ASWalkTurnBwdL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASWalkTurnBwdL");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASWalkTurnBwdL_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASWalkTurnBwdL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASWalkTurnBwdL");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASWalkTurnBwdL_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASWalkTurnLeft")]
	public UAnimSequence ASWalkTurnLeft
	{
		get
		{
			CheckDestroyed();
			if (!ASWalkTurnLeft_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASWalkTurnLeft");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASWalkTurnLeft_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASWalkTurnLeft_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASWalkTurnLeft");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASWalkTurnLeft_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASWalkTurnRight")]
	public UAnimSequence ASWalkTurnRight
	{
		get
		{
			CheckDestroyed();
			if (!ASWalkTurnRight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASWalkTurnRight");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASWalkTurnRight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASWalkTurnRight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASWalkTurnRight");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASWalkTurnRight_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASWalkTurnBwdR")]
	public UAnimSequence ASWalkTurnBwdR
	{
		get
		{
			CheckDestroyed();
			if (!ASWalkTurnBwdR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASWalkTurnBwdR");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASWalkTurnBwdR_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASWalkTurnBwdR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASWalkTurnBwdR");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASWalkTurnBwdR_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("PlayerLocomotion")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:WalkStartAngle")]
	public float WalkStartAngle
	{
		get
		{
			CheckDestroyed();
			if (!WalkStartAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:WalkStartAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, WalkStartAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WalkStartAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:WalkStartAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, WalkStartAngle_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("PlayerLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASRunStartBwdL")]
	public UAnimSequence ASRunStartBwdL
	{
		get
		{
			CheckDestroyed();
			if (!ASRunStartBwdL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASRunStartBwdL");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunStartBwdL_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunStartBwdL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASRunStartBwdL");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunStartBwdL_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("PlayerLocomotion")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASRunStartLeft")]
	public UAnimSequence ASRunStartLeft
	{
		get
		{
			CheckDestroyed();
			if (!ASRunStartLeft_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASRunStartLeft");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunStartLeft_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunStartLeft_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASRunStartLeft");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunStartLeft_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASRunStartFwd")]
	public UAnimSequence ASRunStartFwd
	{
		get
		{
			CheckDestroyed();
			if (!ASRunStartFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASRunStartFwd");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunStartFwd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunStartFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASRunStartFwd");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunStartFwd_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASRunStartRight")]
	public UAnimSequence ASRunStartRight
	{
		get
		{
			CheckDestroyed();
			if (!ASRunStartRight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASRunStartRight");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunStartRight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunStartRight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASRunStartRight");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunStartRight_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("PlayerLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASRunStartBwdR")]
	public UAnimSequence ASRunStartBwdR
	{
		get
		{
			CheckDestroyed();
			if (!ASRunStartBwdR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASRunStartBwdR");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunStartBwdR_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunStartBwdR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASRunStartBwdR");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunStartBwdR_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASRunTurnBwdL")]
	public UAnimSequence ASRunTurnBwdL
	{
		get
		{
			CheckDestroyed();
			if (!ASRunTurnBwdL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASRunTurnBwdL");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunTurnBwdL_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunTurnBwdL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASRunTurnBwdL");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunTurnBwdL_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("PlayerLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASRunTurnLeft")]
	public UAnimSequence ASRunTurnLeft
	{
		get
		{
			CheckDestroyed();
			if (!ASRunTurnLeft_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASRunTurnLeft");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunTurnLeft_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunTurnLeft_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASRunTurnLeft");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunTurnLeft_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("PlayerLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASRunTurnRight")]
	public UAnimSequence ASRunTurnRight
	{
		get
		{
			CheckDestroyed();
			if (!ASRunTurnRight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASRunTurnRight");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunTurnRight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunTurnRight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASRunTurnRight");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunTurnRight_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("PlayerLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASRunTurnBwdR")]
	public UAnimSequence ASRunTurnBwdR
	{
		get
		{
			CheckDestroyed();
			if (!ASRunTurnBwdR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASRunTurnBwdR");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunTurnBwdR_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunTurnBwdR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASRunTurnBwdR");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunTurnBwdR_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASRunTurnBwdFallingVelocityAdditive")]
	public UAnimSequence ASRunTurnBwdFallingVelocityAdditive
	{
		get
		{
			CheckDestroyed();
			if (!ASRunTurnBwdFallingVelocityAdditive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASRunTurnBwdFallingVelocityAdditive");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunTurnBwdFallingVelocityAdditive_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunTurnBwdFallingVelocityAdditive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASRunTurnBwdFallingVelocityAdditive");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunTurnBwdFallingVelocityAdditive_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASRunTurnBwdFallingVelocityAdditiveAlpha")]
	public float ASRunTurnBwdFallingVelocityAdditiveAlpha
	{
		get
		{
			CheckDestroyed();
			if (!ASRunTurnBwdFallingVelocityAdditiveAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASRunTurnBwdFallingVelocityAdditiveAlpha");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ASRunTurnBwdFallingVelocityAdditiveAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunTurnBwdFallingVelocityAdditiveAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASRunTurnBwdFallingVelocityAdditiveAlpha");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ASRunTurnBwdFallingVelocityAdditiveAlpha_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASRunTurnFwdL")]
	public UAnimSequence ASRunTurnFwdL
	{
		get
		{
			CheckDestroyed();
			if (!ASRunTurnFwdL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASRunTurnFwdL");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunTurnFwdL_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunTurnFwdL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASRunTurnFwdL");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunTurnFwdL_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("PlayerLocomotion")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASRunTurnFwdR")]
	public UAnimSequence ASRunTurnFwdR
	{
		get
		{
			CheckDestroyed();
			if (!ASRunTurnFwdR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASRunTurnFwdR");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunTurnFwdR_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunTurnFwdR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASRunTurnFwdR");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunTurnFwdR_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASRunTurnFwdFallingVelocityAdditive")]
	public UAnimSequence ASRunTurnFwdFallingVelocityAdditive
	{
		get
		{
			CheckDestroyed();
			if (!ASRunTurnFwdFallingVelocityAdditive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASRunTurnFwdFallingVelocityAdditive");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunTurnFwdFallingVelocityAdditive_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunTurnFwdFallingVelocityAdditive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASRunTurnFwdFallingVelocityAdditive");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunTurnFwdFallingVelocityAdditive_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASRunTurnFwdFallingVelocityAdditiveAlpha")]
	public float ASRunTurnFwdFallingVelocityAdditiveAlpha
	{
		get
		{
			CheckDestroyed();
			if (!ASRunTurnFwdFallingVelocityAdditiveAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASRunTurnFwdFallingVelocityAdditiveAlpha");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ASRunTurnFwdFallingVelocityAdditiveAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunTurnFwdFallingVelocityAdditiveAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASRunTurnFwdFallingVelocityAdditiveAlpha");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ASRunTurnFwdFallingVelocityAdditiveAlpha_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASRunTurnFwdSpeedAdditive")]
	public UAnimSequence ASRunTurnFwdSpeedAdditive
	{
		get
		{
			CheckDestroyed();
			if (!ASRunTurnFwdSpeedAdditive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASRunTurnFwdSpeedAdditive");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunTurnFwdSpeedAdditive_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunTurnFwdSpeedAdditive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASRunTurnFwdSpeedAdditive");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunTurnFwdSpeedAdditive_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("PlayerLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASRunTurnFwdSpeedAdditiveAlpha")]
	public float ASRunTurnFwdSpeedAdditiveAlpha
	{
		get
		{
			CheckDestroyed();
			if (!ASRunTurnFwdSpeedAdditiveAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASRunTurnFwdSpeedAdditiveAlpha");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ASRunTurnFwdSpeedAdditiveAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunTurnFwdSpeedAdditiveAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASRunTurnFwdSpeedAdditiveAlpha");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ASRunTurnFwdSpeedAdditiveAlpha_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:RunStartAngle")]
	public float RunStartAngle
	{
		get
		{
			CheckDestroyed();
			if (!RunStartAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:RunStartAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RunStartAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RunStartAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:RunStartAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RunStartAngle_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("PlayerLocomotion")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:RushStartAngle")]
	public float RushStartAngle
	{
		get
		{
			CheckDestroyed();
			if (!RushStartAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:RushStartAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RushStartAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RushStartAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:RushStartAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RushStartAngle_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("PlayerLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASFreeWalkStop")]
	public UAnimSequence ASFreeWalkStop
	{
		get
		{
			CheckDestroyed();
			if (!ASFreeWalkStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASFreeWalkStop");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASFreeWalkStop_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASFreeWalkStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASFreeWalkStop");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASFreeWalkStop_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("PlayerLocomotion")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockWalkStartFwd")]
	public UBlendSpace BSLockWalkStartFwd
	{
		get
		{
			CheckDestroyed();
			if (!BSLockWalkStartFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockWalkStartFwd");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSLockWalkStartFwd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSLockWalkStartFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockWalkStartFwd");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSLockWalkStartFwd_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("PlayerLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockWalkStartBwd")]
	public UBlendSpace BSLockWalkStartBwd
	{
		get
		{
			CheckDestroyed();
			if (!BSLockWalkStartBwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockWalkStartBwd");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSLockWalkStartBwd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSLockWalkStartBwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockWalkStartBwd");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSLockWalkStartBwd_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("PlayerLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkStartFwdL")]
	public UAnimSequence ASLockWalkStartFwdL
	{
		get
		{
			CheckDestroyed();
			if (!ASLockWalkStartFwdL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkStartFwdL");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASLockWalkStartFwdL_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASLockWalkStartFwdL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkStartFwdL");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASLockWalkStartFwdL_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkStartFwdR")]
	public UAnimSequence ASLockWalkStartFwdR
	{
		get
		{
			CheckDestroyed();
			if (!ASLockWalkStartFwdR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkStartFwdR");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASLockWalkStartFwdR_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASLockWalkStartFwdR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkStartFwdR");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASLockWalkStartFwdR_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("PlayerLocomotion")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkStartBwdL")]
	public UAnimSequence ASLockWalkStartBwdL
	{
		get
		{
			CheckDestroyed();
			if (!ASLockWalkStartBwdL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkStartBwdL");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASLockWalkStartBwdL_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASLockWalkStartBwdL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkStartBwdL");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASLockWalkStartBwdL_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkStartBwdR")]
	public UAnimSequence ASLockWalkStartBwdR
	{
		get
		{
			CheckDestroyed();
			if (!ASLockWalkStartBwdR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkStartBwdR");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASLockWalkStartBwdR_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASLockWalkStartBwdR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkStartBwdR");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASLockWalkStartBwdR_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("PlayerLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkStartLeftF")]
	public UAnimSequence ASLockWalkStartLeftF
	{
		get
		{
			CheckDestroyed();
			if (!ASLockWalkStartLeftF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkStartLeftF");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASLockWalkStartLeftF_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASLockWalkStartLeftF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkStartLeftF");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASLockWalkStartLeftF_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkStartLeftB")]
	public UAnimSequence ASLockWalkStartLeftB
	{
		get
		{
			CheckDestroyed();
			if (!ASLockWalkStartLeftB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkStartLeftB");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASLockWalkStartLeftB_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASLockWalkStartLeftB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkStartLeftB");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASLockWalkStartLeftB_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("PlayerLocomotion")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkStartRightF")]
	public UAnimSequence ASLockWalkStartRightF
	{
		get
		{
			CheckDestroyed();
			if (!ASLockWalkStartRightF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkStartRightF");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASLockWalkStartRightF_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASLockWalkStartRightF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkStartRightF");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASLockWalkStartRightF_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("PlayerLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkStartRightB")]
	public UAnimSequence ASLockWalkStartRightB
	{
		get
		{
			CheckDestroyed();
			if (!ASLockWalkStartRightB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkStartRightB");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASLockWalkStartRightB_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASLockWalkStartRightB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkStartRightB");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASLockWalkStartRightB_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockRunStartFwd")]
	public UBlendSpace BSLockRunStartFwd
	{
		get
		{
			CheckDestroyed();
			if (!BSLockRunStartFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockRunStartFwd");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSLockRunStartFwd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSLockRunStartFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockRunStartFwd");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSLockRunStartFwd_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("PlayerLocomotion")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockRunStartBwd")]
	public UBlendSpace BSLockRunStartBwd
	{
		get
		{
			CheckDestroyed();
			if (!BSLockRunStartBwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockRunStartBwd");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSLockRunStartBwd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSLockRunStartBwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockRunStartBwd");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSLockRunStartBwd_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunStartFwdL")]
	public UAnimSequence ASLockRunStartFwdL
	{
		get
		{
			CheckDestroyed();
			if (!ASLockRunStartFwdL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunStartFwdL");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASLockRunStartFwdL_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASLockRunStartFwdL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunStartFwdL");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASLockRunStartFwdL_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("PlayerLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunStartFwdR")]
	public UAnimSequence ASLockRunStartFwdR
	{
		get
		{
			CheckDestroyed();
			if (!ASLockRunStartFwdR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunStartFwdR");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASLockRunStartFwdR_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASLockRunStartFwdR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunStartFwdR");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASLockRunStartFwdR_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunStartBwdL")]
	public UAnimSequence ASLockRunStartBwdL
	{
		get
		{
			CheckDestroyed();
			if (!ASLockRunStartBwdL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunStartBwdL");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASLockRunStartBwdL_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASLockRunStartBwdL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunStartBwdL");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASLockRunStartBwdL_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("PlayerLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunStartBwdR")]
	public UAnimSequence ASLockRunStartBwdR
	{
		get
		{
			CheckDestroyed();
			if (!ASLockRunStartBwdR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunStartBwdR");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASLockRunStartBwdR_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASLockRunStartBwdR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunStartBwdR");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASLockRunStartBwdR_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("PlayerLocomotion")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunStartLeftF")]
	public UAnimSequence ASLockRunStartLeftF
	{
		get
		{
			CheckDestroyed();
			if (!ASLockRunStartLeftF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunStartLeftF");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASLockRunStartLeftF_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASLockRunStartLeftF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunStartLeftF");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASLockRunStartLeftF_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunStartLeftB")]
	public UAnimSequence ASLockRunStartLeftB
	{
		get
		{
			CheckDestroyed();
			if (!ASLockRunStartLeftB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunStartLeftB");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASLockRunStartLeftB_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASLockRunStartLeftB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunStartLeftB");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASLockRunStartLeftB_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("PlayerLocomotion")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunStartRightF")]
	public UAnimSequence ASLockRunStartRightF
	{
		get
		{
			CheckDestroyed();
			if (!ASLockRunStartRightF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunStartRightF");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASLockRunStartRightF_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASLockRunStartRightF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunStartRightF");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASLockRunStartRightF_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunStartRightB")]
	public UAnimSequence ASLockRunStartRightB
	{
		get
		{
			CheckDestroyed();
			if (!ASLockRunStartRightB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunStartRightB");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASLockRunStartRightB_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASLockRunStartRightB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunStartRightB");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASLockRunStartRightB_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockTurnFRFromFRBL")]
	public UBlendSpace BSLockTurnFRFromFRBL
	{
		get
		{
			CheckDestroyed();
			if (!BSLockTurnFRFromFRBL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockTurnFRFromFRBL");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSLockTurnFRFromFRBL_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSLockTurnFRFromFRBL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockTurnFRFromFRBL");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSLockTurnFRFromFRBL_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("PlayerLocomotion")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockTurnFRFromFLBR")]
	public UBlendSpace BSLockTurnFRFromFLBR
	{
		get
		{
			CheckDestroyed();
			if (!BSLockTurnFRFromFLBR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockTurnFRFromFLBR");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSLockTurnFRFromFLBR_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSLockTurnFRFromFLBR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockTurnFRFromFLBR");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSLockTurnFRFromFLBR_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("PlayerLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockTurnBRFromFRBL")]
	public UBlendSpace BSLockTurnBRFromFRBL
	{
		get
		{
			CheckDestroyed();
			if (!BSLockTurnBRFromFRBL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockTurnBRFromFRBL");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSLockTurnBRFromFRBL_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSLockTurnBRFromFRBL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockTurnBRFromFRBL");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSLockTurnBRFromFRBL_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockTurnBRFromFLBR")]
	public UBlendSpace BSLockTurnBRFromFLBR
	{
		get
		{
			CheckDestroyed();
			if (!BSLockTurnBRFromFLBR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockTurnBRFromFLBR");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSLockTurnBRFromFLBR_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSLockTurnBRFromFLBR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockTurnBRFromFLBR");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSLockTurnBRFromFLBR_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("PlayerLocomotion")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockTurnBLFromFRBL")]
	public UBlendSpace BSLockTurnBLFromFRBL
	{
		get
		{
			CheckDestroyed();
			if (!BSLockTurnBLFromFRBL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockTurnBLFromFRBL");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSLockTurnBLFromFRBL_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSLockTurnBLFromFRBL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockTurnBLFromFRBL");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSLockTurnBLFromFRBL_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("PlayerLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockTurnBLFromFLBR")]
	public UBlendSpace BSLockTurnBLFromFLBR
	{
		get
		{
			CheckDestroyed();
			if (!BSLockTurnBLFromFLBR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockTurnBLFromFLBR");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSLockTurnBLFromFLBR_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSLockTurnBLFromFLBR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockTurnBLFromFLBR");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSLockTurnBLFromFLBR_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("PlayerLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockTurnFLFromFRBL")]
	public UBlendSpace BSLockTurnFLFromFRBL
	{
		get
		{
			CheckDestroyed();
			if (!BSLockTurnFLFromFRBL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockTurnFLFromFRBL");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSLockTurnFLFromFRBL_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSLockTurnFLFromFRBL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockTurnFLFromFRBL");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSLockTurnFLFromFRBL_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("PlayerLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockTurnFLFromFLBR")]
	public UBlendSpace BSLockTurnFLFromFLBR
	{
		get
		{
			CheckDestroyed();
			if (!BSLockTurnFLFromFLBR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockTurnFLFromFLBR");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSLockTurnFLFromFLBR_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSLockTurnFLFromFLBR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockTurnFLFromFLBR");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSLockTurnFLFromFLBR_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("PlayerLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:LockTurnToAlphaFR")]
	public float LockTurnToAlphaFR
	{
		get
		{
			CheckDestroyed();
			if (!LockTurnToAlphaFR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:LockTurnToAlphaFR");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LockTurnToAlphaFR_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LockTurnToAlphaFR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:LockTurnToAlphaFR");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LockTurnToAlphaFR_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("PlayerLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:LockTurnToAlphaBR")]
	public float LockTurnToAlphaBR
	{
		get
		{
			CheckDestroyed();
			if (!LockTurnToAlphaBR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:LockTurnToAlphaBR");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LockTurnToAlphaBR_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LockTurnToAlphaBR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:LockTurnToAlphaBR");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LockTurnToAlphaBR_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:LockTurnToAlphaBL")]
	public float LockTurnToAlphaBL
	{
		get
		{
			CheckDestroyed();
			if (!LockTurnToAlphaBL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:LockTurnToAlphaBL");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LockTurnToAlphaBL_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LockTurnToAlphaBL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:LockTurnToAlphaBL");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LockTurnToAlphaBL_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("PlayerLocomotion")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:LockTurnToAlphaFL")]
	public float LockTurnToAlphaFL
	{
		get
		{
			CheckDestroyed();
			if (!LockTurnToAlphaFL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:LockTurnToAlphaFL");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LockTurnToAlphaFL_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LockTurnToAlphaFL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:LockTurnToAlphaFL");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LockTurnToAlphaFL_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:LockTurnFromAlphaFR")]
	public float LockTurnFromAlphaFR
	{
		get
		{
			CheckDestroyed();
			if (!LockTurnFromAlphaFR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:LockTurnFromAlphaFR");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LockTurnFromAlphaFR_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LockTurnFromAlphaFR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:LockTurnFromAlphaFR");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LockTurnFromAlphaFR_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("PlayerLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:LockTurnFromAlphaBR")]
	public float LockTurnFromAlphaBR
	{
		get
		{
			CheckDestroyed();
			if (!LockTurnFromAlphaBR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:LockTurnFromAlphaBR");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LockTurnFromAlphaBR_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LockTurnFromAlphaBR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:LockTurnFromAlphaBR");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LockTurnFromAlphaBR_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("PlayerLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:LockTurnFromAlphaBL")]
	public float LockTurnFromAlphaBL
	{
		get
		{
			CheckDestroyed();
			if (!LockTurnFromAlphaBL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:LockTurnFromAlphaBL");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LockTurnFromAlphaBL_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LockTurnFromAlphaBL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:LockTurnFromAlphaBL");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LockTurnFromAlphaBL_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:LockTurnFromAlphaFL")]
	public float LockTurnFromAlphaFL
	{
		get
		{
			CheckDestroyed();
			if (!LockTurnFromAlphaFL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:LockTurnFromAlphaFL");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LockTurnFromAlphaFL_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LockTurnFromAlphaFL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:LockTurnFromAlphaFL");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LockTurnFromAlphaFL_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("PlayerLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkLoopFwd")]
	public UAnimSequence ASLockWalkLoopFwd
	{
		get
		{
			CheckDestroyed();
			if (!ASLockWalkLoopFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkLoopFwd");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASLockWalkLoopFwd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASLockWalkLoopFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkLoopFwd");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASLockWalkLoopFwd_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("PlayerLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkLoopBwd")]
	public UAnimSequence ASLockWalkLoopBwd
	{
		get
		{
			CheckDestroyed();
			if (!ASLockWalkLoopBwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkLoopBwd");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASLockWalkLoopBwd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASLockWalkLoopBwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkLoopBwd");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASLockWalkLoopBwd_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("PlayerLocomotion")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkLoopLeftF")]
	public UAnimSequence ASLockWalkLoopLeftF
	{
		get
		{
			CheckDestroyed();
			if (!ASLockWalkLoopLeftF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkLoopLeftF");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASLockWalkLoopLeftF_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASLockWalkLoopLeftF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkLoopLeftF");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASLockWalkLoopLeftF_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkLoopRightF")]
	public UAnimSequence ASLockWalkLoopRightF
	{
		get
		{
			CheckDestroyed();
			if (!ASLockWalkLoopRightF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkLoopRightF");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASLockWalkLoopRightF_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASLockWalkLoopRightF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkLoopRightF");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASLockWalkLoopRightF_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkLoopLeftB")]
	public UAnimSequence ASLockWalkLoopLeftB
	{
		get
		{
			CheckDestroyed();
			if (!ASLockWalkLoopLeftB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkLoopLeftB");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASLockWalkLoopLeftB_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASLockWalkLoopLeftB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkLoopLeftB");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASLockWalkLoopLeftB_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkLoopRightB")]
	public UAnimSequence ASLockWalkLoopRightB
	{
		get
		{
			CheckDestroyed();
			if (!ASLockWalkLoopRightB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkLoopRightB");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASLockWalkLoopRightB_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASLockWalkLoopRightB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkLoopRightB");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASLockWalkLoopRightB_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("PlayerLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkLoopLeftFAdd")]
	public UAnimSequence ASLockWalkLoopLeftFAdd
	{
		get
		{
			CheckDestroyed();
			if (!ASLockWalkLoopLeftFAdd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkLoopLeftFAdd");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASLockWalkLoopLeftFAdd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASLockWalkLoopLeftFAdd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkLoopLeftFAdd");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASLockWalkLoopLeftFAdd_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("PlayerLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkLoopRightFAdd")]
	public UAnimSequence ASLockWalkLoopRightFAdd
	{
		get
		{
			CheckDestroyed();
			if (!ASLockWalkLoopRightFAdd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkLoopRightFAdd");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASLockWalkLoopRightFAdd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASLockWalkLoopRightFAdd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkLoopRightFAdd");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASLockWalkLoopRightFAdd_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("PlayerLocomotion")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunLoopFwd")]
	public UAnimSequence ASLockRunLoopFwd
	{
		get
		{
			CheckDestroyed();
			if (!ASLockRunLoopFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunLoopFwd");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASLockRunLoopFwd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASLockRunLoopFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunLoopFwd");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASLockRunLoopFwd_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("PlayerLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunLoopBwd")]
	public UAnimSequence ASLockRunLoopBwd
	{
		get
		{
			CheckDestroyed();
			if (!ASLockRunLoopBwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunLoopBwd");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASLockRunLoopBwd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASLockRunLoopBwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunLoopBwd");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASLockRunLoopBwd_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunLoopLeftF")]
	public UAnimSequence ASLockRunLoopLeftF
	{
		get
		{
			CheckDestroyed();
			if (!ASLockRunLoopLeftF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunLoopLeftF");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASLockRunLoopLeftF_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASLockRunLoopLeftF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunLoopLeftF");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASLockRunLoopLeftF_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunLoopRightF")]
	public UAnimSequence ASLockRunLoopRightF
	{
		get
		{
			CheckDestroyed();
			if (!ASLockRunLoopRightF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunLoopRightF");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASLockRunLoopRightF_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASLockRunLoopRightF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunLoopRightF");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASLockRunLoopRightF_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("PlayerLocomotion")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunLoopLeftB")]
	public UAnimSequence ASLockRunLoopLeftB
	{
		get
		{
			CheckDestroyed();
			if (!ASLockRunLoopLeftB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunLoopLeftB");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASLockRunLoopLeftB_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASLockRunLoopLeftB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunLoopLeftB");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASLockRunLoopLeftB_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("PlayerLocomotion")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunLoopRightB")]
	public UAnimSequence ASLockRunLoopRightB
	{
		get
		{
			CheckDestroyed();
			if (!ASLockRunLoopRightB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunLoopRightB");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASLockRunLoopRightB_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASLockRunLoopRightB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunLoopRightB");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASLockRunLoopRightB_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("PlayerLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunLoopLeftFAdd")]
	public UAnimSequence ASLockRunLoopLeftFAdd
	{
		get
		{
			CheckDestroyed();
			if (!ASLockRunLoopLeftFAdd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunLoopLeftFAdd");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASLockRunLoopLeftFAdd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASLockRunLoopLeftFAdd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunLoopLeftFAdd");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASLockRunLoopLeftFAdd_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunLoopRightFAdd")]
	public UAnimSequence ASLockRunLoopRightFAdd
	{
		get
		{
			CheckDestroyed();
			if (!ASLockRunLoopRightFAdd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunLoopRightFAdd");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASLockRunLoopRightFAdd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASLockRunLoopRightFAdd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunLoopRightFAdd");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASLockRunLoopRightFAdd_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("PlayerLocomotion")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockWalkTurnFR2BL")]
	public UBlendSpace BSLockWalkTurnFR2BL
	{
		get
		{
			CheckDestroyed();
			if (!BSLockWalkTurnFR2BL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockWalkTurnFR2BL");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSLockWalkTurnFR2BL_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSLockWalkTurnFR2BL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockWalkTurnFR2BL");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSLockWalkTurnFR2BL_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("PlayerLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockWalkTurnBR2FL")]
	public UBlendSpace BSLockWalkTurnBR2FL
	{
		get
		{
			CheckDestroyed();
			if (!BSLockWalkTurnBR2FL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockWalkTurnBR2FL");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSLockWalkTurnBR2FL_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSLockWalkTurnBR2FL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockWalkTurnBR2FL");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSLockWalkTurnBR2FL_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockWalkTurnBL2FR")]
	public UBlendSpace BSLockWalkTurnBL2FR
	{
		get
		{
			CheckDestroyed();
			if (!BSLockWalkTurnBL2FR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockWalkTurnBL2FR");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSLockWalkTurnBL2FR_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSLockWalkTurnBL2FR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockWalkTurnBL2FR");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSLockWalkTurnBL2FR_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("PlayerLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockWalkTurnFL2BR")]
	public UBlendSpace BSLockWalkTurnFL2BR
	{
		get
		{
			CheckDestroyed();
			if (!BSLockWalkTurnFL2BR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockWalkTurnFL2BR");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSLockWalkTurnFL2BR_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSLockWalkTurnFL2BR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockWalkTurnFL2BR");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSLockWalkTurnFL2BR_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("PlayerLocomotion")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockWalkTurnFR2FL")]
	public UBlendSpace BSLockWalkTurnFR2FL
	{
		get
		{
			CheckDestroyed();
			if (!BSLockWalkTurnFR2FL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockWalkTurnFR2FL");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSLockWalkTurnFR2FL_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSLockWalkTurnFR2FL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockWalkTurnFR2FL");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSLockWalkTurnFR2FL_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockWalkTurnFL2FR")]
	public UBlendSpace BSLockWalkTurnFL2FR
	{
		get
		{
			CheckDestroyed();
			if (!BSLockWalkTurnFL2FR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockWalkTurnFL2FR");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSLockWalkTurnFL2FR_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSLockWalkTurnFL2FR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockWalkTurnFL2FR");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSLockWalkTurnFL2FR_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockWalkTurnBL2FL")]
	public UBlendSpace BSLockWalkTurnBL2FL
	{
		get
		{
			CheckDestroyed();
			if (!BSLockWalkTurnBL2FL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockWalkTurnBL2FL");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSLockWalkTurnBL2FL_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSLockWalkTurnBL2FL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockWalkTurnBL2FL");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSLockWalkTurnBL2FL_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockWalkTurnFL2BL")]
	public UBlendSpace BSLockWalkTurnFL2BL
	{
		get
		{
			CheckDestroyed();
			if (!BSLockWalkTurnFL2BL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockWalkTurnFL2BL");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSLockWalkTurnFL2BL_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSLockWalkTurnFL2BL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockWalkTurnFL2BL");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSLockWalkTurnFL2BL_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("PlayerLocomotion")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockWalkTurnBR2FR")]
	public UBlendSpace BSLockWalkTurnBR2FR
	{
		get
		{
			CheckDestroyed();
			if (!BSLockWalkTurnBR2FR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockWalkTurnBR2FR");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSLockWalkTurnBR2FR_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSLockWalkTurnBR2FR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockWalkTurnBR2FR");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSLockWalkTurnBR2FR_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("PlayerLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockWalkTurnFR2BR")]
	public UBlendSpace BSLockWalkTurnFR2BR
	{
		get
		{
			CheckDestroyed();
			if (!BSLockWalkTurnFR2BR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockWalkTurnFR2BR");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSLockWalkTurnFR2BR_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSLockWalkTurnFR2BR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockWalkTurnFR2BR");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSLockWalkTurnFR2BR_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockRunTurnFR2BL")]
	public UBlendSpace BSLockRunTurnFR2BL
	{
		get
		{
			CheckDestroyed();
			if (!BSLockRunTurnFR2BL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockRunTurnFR2BL");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSLockRunTurnFR2BL_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSLockRunTurnFR2BL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockRunTurnFR2BL");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSLockRunTurnFR2BL_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("PlayerLocomotion")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockRunTurnBR2FL")]
	public UBlendSpace BSLockRunTurnBR2FL
	{
		get
		{
			CheckDestroyed();
			if (!BSLockRunTurnBR2FL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockRunTurnBR2FL");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSLockRunTurnBR2FL_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSLockRunTurnBR2FL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockRunTurnBR2FL");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSLockRunTurnBR2FL_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("PlayerLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockRunTurnBL2FR")]
	public UBlendSpace BSLockRunTurnBL2FR
	{
		get
		{
			CheckDestroyed();
			if (!BSLockRunTurnBL2FR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockRunTurnBL2FR");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSLockRunTurnBL2FR_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSLockRunTurnBL2FR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockRunTurnBL2FR");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSLockRunTurnBL2FR_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("PlayerLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockRunTurnFL2BR")]
	public UBlendSpace BSLockRunTurnFL2BR
	{
		get
		{
			CheckDestroyed();
			if (!BSLockRunTurnFL2BR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockRunTurnFL2BR");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSLockRunTurnFL2BR_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSLockRunTurnFL2BR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockRunTurnFL2BR");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSLockRunTurnFL2BR_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockRunTurnFR2FL")]
	public UBlendSpace BSLockRunTurnFR2FL
	{
		get
		{
			CheckDestroyed();
			if (!BSLockRunTurnFR2FL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockRunTurnFR2FL");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSLockRunTurnFR2FL_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSLockRunTurnFR2FL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockRunTurnFR2FL");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSLockRunTurnFR2FL_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("PlayerLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockRunTurnFL2FR")]
	public UBlendSpace BSLockRunTurnFL2FR
	{
		get
		{
			CheckDestroyed();
			if (!BSLockRunTurnFL2FR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockRunTurnFL2FR");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSLockRunTurnFL2FR_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSLockRunTurnFL2FR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockRunTurnFL2FR");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSLockRunTurnFL2FR_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("PlayerLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockRunTurnBL2FL")]
	public UBlendSpace BSLockRunTurnBL2FL
	{
		get
		{
			CheckDestroyed();
			if (!BSLockRunTurnBL2FL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockRunTurnBL2FL");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSLockRunTurnBL2FL_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSLockRunTurnBL2FL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockRunTurnBL2FL");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSLockRunTurnBL2FL_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("PlayerLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockRunTurnFL2BL")]
	public UBlendSpace BSLockRunTurnFL2BL
	{
		get
		{
			CheckDestroyed();
			if (!BSLockRunTurnFL2BL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockRunTurnFL2BL");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSLockRunTurnFL2BL_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSLockRunTurnFL2BL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockRunTurnFL2BL");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSLockRunTurnFL2BL_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockRunTurnBR2FR")]
	public UBlendSpace BSLockRunTurnBR2FR
	{
		get
		{
			CheckDestroyed();
			if (!BSLockRunTurnBR2FR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockRunTurnBR2FR");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSLockRunTurnBR2FR_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSLockRunTurnBR2FR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockRunTurnBR2FR");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSLockRunTurnBR2FR_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("PlayerLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockRunTurnFR2BR")]
	public UBlendSpace BSLockRunTurnFR2BR
	{
		get
		{
			CheckDestroyed();
			if (!BSLockRunTurnFR2BR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockRunTurnFR2BR");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSLockRunTurnFR2BR_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSLockRunTurnFR2BR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockRunTurnFR2BR");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSLockRunTurnFR2BR_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("PlayerLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockTurnStopFL")]
	public UBlendSpace BSLockTurnStopFL
	{
		get
		{
			CheckDestroyed();
			if (!BSLockTurnStopFL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockTurnStopFL");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSLockTurnStopFL_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSLockTurnStopFL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockTurnStopFL");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSLockTurnStopFL_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("PlayerLocomotion")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockTurnStopFR")]
	public UBlendSpace BSLockTurnStopFR
	{
		get
		{
			CheckDestroyed();
			if (!BSLockTurnStopFR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockTurnStopFR");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSLockTurnStopFR_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSLockTurnStopFR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockTurnStopFR");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSLockTurnStopFR_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("PlayerLocomotion")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockTurnStopBL")]
	public UBlendSpace BSLockTurnStopBL
	{
		get
		{
			CheckDestroyed();
			if (!BSLockTurnStopBL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockTurnStopBL");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSLockTurnStopBL_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSLockTurnStopBL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockTurnStopBL");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSLockTurnStopBL_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("PlayerLocomotion")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockTurnStopBR")]
	public UBlendSpace BSLockTurnStopBR
	{
		get
		{
			CheckDestroyed();
			if (!BSLockTurnStopBR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockTurnStopBR");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSLockTurnStopBR_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSLockTurnStopBR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:BSLockTurnStopBR");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSLockTurnStopBR_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:LockTurnStopAlphaFR")]
	public float LockTurnStopAlphaFR
	{
		get
		{
			CheckDestroyed();
			if (!LockTurnStopAlphaFR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:LockTurnStopAlphaFR");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LockTurnStopAlphaFR_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LockTurnStopAlphaFR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:LockTurnStopAlphaFR");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LockTurnStopAlphaFR_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:LockTurnStopAlphaBR")]
	public float LockTurnStopAlphaBR
	{
		get
		{
			CheckDestroyed();
			if (!LockTurnStopAlphaBR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:LockTurnStopAlphaBR");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LockTurnStopAlphaBR_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LockTurnStopAlphaBR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:LockTurnStopAlphaBR");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LockTurnStopAlphaBR_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("PlayerLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:LockTurnStopAlphaBL")]
	public float LockTurnStopAlphaBL
	{
		get
		{
			CheckDestroyed();
			if (!LockTurnStopAlphaBL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:LockTurnStopAlphaBL");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LockTurnStopAlphaBL_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LockTurnStopAlphaBL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:LockTurnStopAlphaBL");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LockTurnStopAlphaBL_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:LockTurnStopAlphaFL")]
	public float LockTurnStopAlphaFL
	{
		get
		{
			CheckDestroyed();
			if (!LockTurnStopAlphaFL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:LockTurnStopAlphaFL");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LockTurnStopAlphaFL_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LockTurnStopAlphaFL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:LockTurnStopAlphaFL");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LockTurnStopAlphaFL_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkStopFwd")]
	public UAnimSequence ASLockWalkStopFwd
	{
		get
		{
			CheckDestroyed();
			if (!ASLockWalkStopFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkStopFwd");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASLockWalkStopFwd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASLockWalkStopFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkStopFwd");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASLockWalkStopFwd_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("PlayerLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkStopBwd")]
	public UAnimSequence ASLockWalkStopBwd
	{
		get
		{
			CheckDestroyed();
			if (!ASLockWalkStopBwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkStopBwd");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASLockWalkStopBwd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASLockWalkStopBwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkStopBwd");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASLockWalkStopBwd_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("PlayerLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkStopLeftF")]
	public UAnimSequence ASLockWalkStopLeftF
	{
		get
		{
			CheckDestroyed();
			if (!ASLockWalkStopLeftF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkStopLeftF");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASLockWalkStopLeftF_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASLockWalkStopLeftF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkStopLeftF");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASLockWalkStopLeftF_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("PlayerLocomotion")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkStopLeftB")]
	public UAnimSequence ASLockWalkStopLeftB
	{
		get
		{
			CheckDestroyed();
			if (!ASLockWalkStopLeftB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkStopLeftB");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASLockWalkStopLeftB_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASLockWalkStopLeftB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkStopLeftB");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASLockWalkStopLeftB_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("PlayerLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkStopRightF")]
	public UAnimSequence ASLockWalkStopRightF
	{
		get
		{
			CheckDestroyed();
			if (!ASLockWalkStopRightF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkStopRightF");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASLockWalkStopRightF_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASLockWalkStopRightF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkStopRightF");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASLockWalkStopRightF_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkStopRightB")]
	public UAnimSequence ASLockWalkStopRightB
	{
		get
		{
			CheckDestroyed();
			if (!ASLockWalkStopRightB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkStopRightB");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASLockWalkStopRightB_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASLockWalkStopRightB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkStopRightB");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASLockWalkStopRightB_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkStopFL45")]
	public UAnimSequence ASLockWalkStopFL45
	{
		get
		{
			CheckDestroyed();
			if (!ASLockWalkStopFL45_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkStopFL45");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASLockWalkStopFL45_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASLockWalkStopFL45_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkStopFL45");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASLockWalkStopFL45_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("PlayerLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkStopFR45")]
	public UAnimSequence ASLockWalkStopFR45
	{
		get
		{
			CheckDestroyed();
			if (!ASLockWalkStopFR45_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkStopFR45");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASLockWalkStopFR45_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASLockWalkStopFR45_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkStopFR45");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASLockWalkStopFR45_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkStopBL45")]
	public UAnimSequence ASLockWalkStopBL45
	{
		get
		{
			CheckDestroyed();
			if (!ASLockWalkStopBL45_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkStopBL45");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASLockWalkStopBL45_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASLockWalkStopBL45_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkStopBL45");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASLockWalkStopBL45_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("PlayerLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkStopBR45")]
	public UAnimSequence ASLockWalkStopBR45
	{
		get
		{
			CheckDestroyed();
			if (!ASLockWalkStopBR45_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkStopBR45");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASLockWalkStopBR45_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASLockWalkStopBR45_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockWalkStopBR45");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASLockWalkStopBR45_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("PlayerLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunStopFwdL")]
	public UAnimSequence ASLockRunStopFwdL
	{
		get
		{
			CheckDestroyed();
			if (!ASLockRunStopFwdL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunStopFwdL");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASLockRunStopFwdL_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASLockRunStopFwdL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunStopFwdL");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASLockRunStopFwdL_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("PlayerLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunStopFwdR")]
	public UAnimSequence ASLockRunStopFwdR
	{
		get
		{
			CheckDestroyed();
			if (!ASLockRunStopFwdR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunStopFwdR");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASLockRunStopFwdR_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASLockRunStopFwdR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunStopFwdR");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASLockRunStopFwdR_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("PlayerLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunStopBwdL")]
	public UAnimSequence ASLockRunStopBwdL
	{
		get
		{
			CheckDestroyed();
			if (!ASLockRunStopBwdL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunStopBwdL");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASLockRunStopBwdL_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASLockRunStopBwdL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunStopBwdL");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASLockRunStopBwdL_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("PlayerLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunStopBwdR")]
	public UAnimSequence ASLockRunStopBwdR
	{
		get
		{
			CheckDestroyed();
			if (!ASLockRunStopBwdR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunStopBwdR");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASLockRunStopBwdR_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASLockRunStopBwdR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunStopBwdR");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASLockRunStopBwdR_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("PlayerLocomotion")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunStopLeftF")]
	public UAnimSequence ASLockRunStopLeftF
	{
		get
		{
			CheckDestroyed();
			if (!ASLockRunStopLeftF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunStopLeftF");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASLockRunStopLeftF_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASLockRunStopLeftF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunStopLeftF");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASLockRunStopLeftF_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("PlayerLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunStopLeftB")]
	public UAnimSequence ASLockRunStopLeftB
	{
		get
		{
			CheckDestroyed();
			if (!ASLockRunStopLeftB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunStopLeftB");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASLockRunStopLeftB_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASLockRunStopLeftB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunStopLeftB");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASLockRunStopLeftB_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("PlayerLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunStopRightF")]
	public UAnimSequence ASLockRunStopRightF
	{
		get
		{
			CheckDestroyed();
			if (!ASLockRunStopRightF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunStopRightF");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASLockRunStopRightF_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASLockRunStopRightF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunStopRightF");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASLockRunStopRightF_Offset), value);
			}
		}
	}

	[Category("PlayerLocomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunStopRightB")]
	public UAnimSequence ASLockRunStopRightB
	{
		get
		{
			CheckDestroyed();
			if (!ASLockRunStopRightB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunStopRightB");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASLockRunStopRightB_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASLockRunStopRightB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:ASLockRunStopRightB");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASLockRunStopRightB_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Common")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:AnimIdle")]
	public UAnimSequence AnimIdle
	{
		get
		{
			CheckDestroyed();
			if (!AnimIdle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:AnimIdle");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, AnimIdle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimIdle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:AnimIdle");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, AnimIdle_Offset), value);
			}
		}
	}

	[Category("Common")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:MoveSpeedLevel")]
	public EMoveSpeedLevel MoveSpeedLevel
	{
		get
		{
			CheckDestroyed();
			if (!MoveSpeedLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:MoveSpeedLevel");
				return EMoveSpeedLevel.Walk;
			}
			return EnumMarshaler<EMoveSpeedLevel>.FromNative(IntPtr.Add(base.Address, MoveSpeedLevel_Offset), 0, MoveSpeedLevel_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MoveSpeedLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:MoveSpeedLevel");
			}
			else
			{
				EnumMarshaler<EMoveSpeedLevel>.ToNative(IntPtr.Add(base.Address, MoveSpeedLevel_Offset), 0, MoveSpeedLevel_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Common")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:MoveSpeedState")]
	public EMoveSpeedLevel MoveSpeedState
	{
		get
		{
			CheckDestroyed();
			if (!MoveSpeedState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:MoveSpeedState");
				return EMoveSpeedLevel.Walk;
			}
			return EnumMarshaler<EMoveSpeedLevel>.FromNative(IntPtr.Add(base.Address, MoveSpeedState_Offset), 0, MoveSpeedState_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MoveSpeedState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:MoveSpeedState");
			}
			else
			{
				EnumMarshaler<EMoveSpeedLevel>.ToNative(IntPtr.Add(base.Address, MoveSpeedState_Offset), 0, MoveSpeedState_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Common")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:InputBlendAlpha")]
	public FVector4 InputBlendAlpha
	{
		get
		{
			CheckDestroyed();
			if (!InputBlendAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:InputBlendAlpha");
				return default(FVector4);
			}
			return BlittableTypeMarshaler<FVector4>.FromNative(IntPtr.Add(base.Address, InputBlendAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InputBlendAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:InputBlendAlpha");
			}
			else
			{
				BlittableTypeMarshaler<FVector4>.ToNative(IntPtr.Add(base.Address, InputBlendAlpha_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("Common")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:VelocityBlendAlpha")]
	public FVector4 VelocityBlendAlpha
	{
		get
		{
			CheckDestroyed();
			if (!VelocityBlendAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:VelocityBlendAlpha");
				return default(FVector4);
			}
			return BlittableTypeMarshaler<FVector4>.FromNative(IntPtr.Add(base.Address, VelocityBlendAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VelocityBlendAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:VelocityBlendAlpha");
			}
			else
			{
				BlittableTypeMarshaler<FVector4>.ToNative(IntPtr.Add(base.Address, VelocityBlendAlpha_Offset), value);
			}
		}
	}

	[Category("Common")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:VelocityBlendAlphaStop")]
	public FVector4 VelocityBlendAlphaStop
	{
		get
		{
			CheckDestroyed();
			if (!VelocityBlendAlphaStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:VelocityBlendAlphaStop");
				return default(FVector4);
			}
			return BlittableTypeMarshaler<FVector4>.FromNative(IntPtr.Add(base.Address, VelocityBlendAlphaStop_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VelocityBlendAlphaStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:VelocityBlendAlphaStop");
			}
			else
			{
				BlittableTypeMarshaler<FVector4>.ToNative(IntPtr.Add(base.Address, VelocityBlendAlphaStop_Offset), value);
			}
		}
	}

	[Category("Common")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLandingMove")]
	public bool bLandingMove
	{
		get
		{
			CheckDestroyed();
			if (!bLandingMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLandingMove");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLandingMove_Offset), 0, bLandingMove_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLandingMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLandingMove");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLandingMove_Offset), 0, bLandingMove_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[Category("Common")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:LastFallingVelocity")]
	public FVector LastFallingVelocity
	{
		get
		{
			CheckDestroyed();
			if (!LastFallingVelocity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:LastFallingVelocity");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, LastFallingVelocity_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LastFallingVelocity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:LastFallingVelocity");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, LastFallingVelocity_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Common")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:RandomIdleIndex")]
	public int RandomIdleIndex
	{
		get
		{
			CheckDestroyed();
			if (!RandomIdleIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:RandomIdleIndex");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, RandomIdleIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RandomIdleIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:RandomIdleIndex");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, RandomIdleIndex_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Common")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:MoveLoopSpeedState")]
	public float MoveLoopSpeedState
	{
		get
		{
			CheckDestroyed();
			if (!MoveLoopSpeedState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:MoveLoopSpeedState");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MoveLoopSpeedState_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MoveLoopSpeedState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:MoveLoopSpeedState");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MoveLoopSpeedState_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("Common")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:MaxSpeed")]
	public float MaxSpeed
	{
		get
		{
			CheckDestroyed();
			if (!MaxSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:MaxSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:MaxSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxSpeed_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Common")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:CurveMoveSpeedScale")]
	public float CurveMoveSpeedScale
	{
		get
		{
			CheckDestroyed();
			if (!CurveMoveSpeedScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:CurveMoveSpeedScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CurveMoveSpeedScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CurveMoveSpeedScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:CurveMoveSpeedScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CurveMoveSpeedScale_Offset), value);
			}
		}
	}

	[Category("Common")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:TargetLockMoveDeltaAngle")]
	public float TargetLockMoveDeltaAngle
	{
		get
		{
			CheckDestroyed();
			if (!TargetLockMoveDeltaAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:TargetLockMoveDeltaAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TargetLockMoveDeltaAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TargetLockMoveDeltaAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:TargetLockMoveDeltaAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TargetLockMoveDeltaAngle_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("Common")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:InputDeltaAngle")]
	public float InputDeltaAngle
	{
		get
		{
			CheckDestroyed();
			if (!InputDeltaAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:InputDeltaAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, InputDeltaAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InputDeltaAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:InputDeltaAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, InputDeltaAngle_Offset), value);
			}
		}
	}

	[Category("Common")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:InputDeltaAngleBackward")]
	public float InputDeltaAngleBackward
	{
		get
		{
			CheckDestroyed();
			if (!InputDeltaAngleBackward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:InputDeltaAngleBackward");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, InputDeltaAngleBackward_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InputDeltaAngleBackward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:InputDeltaAngleBackward");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, InputDeltaAngleBackward_Offset), value);
			}
		}
	}

	[Category("Common")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:StrideWarpingSpeed")]
	public float StrideWarpingSpeed
	{
		get
		{
			CheckDestroyed();
			if (!StrideWarpingSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:StrideWarpingSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, StrideWarpingSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StrideWarpingSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:StrideWarpingSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, StrideWarpingSpeed_Offset), value);
			}
		}
	}

	[Category("Common")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:StrideWarpingAlpha")]
	public float StrideWarpingAlpha
	{
		get
		{
			CheckDestroyed();
			if (!StrideWarpingAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:StrideWarpingAlpha");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, StrideWarpingAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StrideWarpingAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:StrideWarpingAlpha");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, StrideWarpingAlpha_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("Trans")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bSwitchToLock")]
	public bool bSwitchToLock
	{
		get
		{
			CheckDestroyed();
			if (!bSwitchToLock_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bSwitchToLock");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bSwitchToLock_Offset), 0, bSwitchToLock_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bSwitchToLock_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bSwitchToLock");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bSwitchToLock_Offset), 0, bSwitchToLock_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[Category("Trans")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveF")]
	public bool bLockMoveF
	{
		get
		{
			CheckDestroyed();
			if (!bLockMoveF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveF");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockMoveF_Offset), 0, bLockMoveF_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockMoveF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveF");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockMoveF_Offset), 0, bLockMoveF_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trans")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveB")]
	public bool bLockMoveB
	{
		get
		{
			CheckDestroyed();
			if (!bLockMoveB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveB");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockMoveB_Offset), 0, bLockMoveB_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockMoveB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveB");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockMoveB_Offset), 0, bLockMoveB_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveL")]
	public bool bLockMoveL
	{
		get
		{
			CheckDestroyed();
			if (!bLockMoveL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveL");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockMoveL_Offset), 0, bLockMoveL_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockMoveL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveL");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockMoveL_Offset), 0, bLockMoveL_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trans")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveR")]
	public bool bLockMoveR
	{
		get
		{
			CheckDestroyed();
			if (!bLockMoveR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveR");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockMoveR_Offset), 0, bLockMoveR_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockMoveR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveR");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockMoveR_Offset), 0, bLockMoveR_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bFreeTurn")]
	public bool bFreeTurn
	{
		get
		{
			CheckDestroyed();
			if (!bFreeTurn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bFreeTurn");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bFreeTurn_Offset), 0, bFreeTurn_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bFreeTurn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bFreeTurn");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bFreeTurn_Offset), 0, bFreeTurn_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trans")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bWalkFreeBwdL")]
	public bool bWalkFreeBwdL
	{
		get
		{
			CheckDestroyed();
			if (!bWalkFreeBwdL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bWalkFreeBwdL");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bWalkFreeBwdL_Offset), 0, bWalkFreeBwdL_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bWalkFreeBwdL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bWalkFreeBwdL");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bWalkFreeBwdL_Offset), 0, bWalkFreeBwdL_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bWalkFreeLeft")]
	public bool bWalkFreeLeft
	{
		get
		{
			CheckDestroyed();
			if (!bWalkFreeLeft_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bWalkFreeLeft");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bWalkFreeLeft_Offset), 0, bWalkFreeLeft_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bWalkFreeLeft_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bWalkFreeLeft");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bWalkFreeLeft_Offset), 0, bWalkFreeLeft_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bWalkFreeRight")]
	public bool bWalkFreeRight
	{
		get
		{
			CheckDestroyed();
			if (!bWalkFreeRight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bWalkFreeRight");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bWalkFreeRight_Offset), 0, bWalkFreeRight_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bWalkFreeRight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bWalkFreeRight");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bWalkFreeRight_Offset), 0, bWalkFreeRight_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trans")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bWalkFreeBwdR")]
	public bool bWalkFreeBwdR
	{
		get
		{
			CheckDestroyed();
			if (!bWalkFreeBwdR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bWalkFreeBwdR");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bWalkFreeBwdR_Offset), 0, bWalkFreeBwdR_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bWalkFreeBwdR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bWalkFreeBwdR");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bWalkFreeBwdR_Offset), 0, bWalkFreeBwdR_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[Category("Trans")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bRunFreeBwdL")]
	public bool bRunFreeBwdL
	{
		get
		{
			CheckDestroyed();
			if (!bRunFreeBwdL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bRunFreeBwdL");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bRunFreeBwdL_Offset), 0, bRunFreeBwdL_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bRunFreeBwdL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bRunFreeBwdL");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bRunFreeBwdL_Offset), 0, bRunFreeBwdL_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("Trans")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bRunFreeTurnLeft")]
	public bool bRunFreeTurnLeft
	{
		get
		{
			CheckDestroyed();
			if (!bRunFreeTurnLeft_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bRunFreeTurnLeft");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bRunFreeTurnLeft_Offset), 0, bRunFreeTurnLeft_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bRunFreeTurnLeft_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bRunFreeTurnLeft");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bRunFreeTurnLeft_Offset), 0, bRunFreeTurnLeft_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bRunFreeTurnRight")]
	public bool bRunFreeTurnRight
	{
		get
		{
			CheckDestroyed();
			if (!bRunFreeTurnRight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bRunFreeTurnRight");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bRunFreeTurnRight_Offset), 0, bRunFreeTurnRight_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bRunFreeTurnRight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bRunFreeTurnRight");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bRunFreeTurnRight_Offset), 0, bRunFreeTurnRight_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bRunFreeStartLeft")]
	public bool bRunFreeStartLeft
	{
		get
		{
			CheckDestroyed();
			if (!bRunFreeStartLeft_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bRunFreeStartLeft");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bRunFreeStartLeft_Offset), 0, bRunFreeStartLeft_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bRunFreeStartLeft_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bRunFreeStartLeft");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bRunFreeStartLeft_Offset), 0, bRunFreeStartLeft_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bRunFreeStartRight")]
	public bool bRunFreeStartRight
	{
		get
		{
			CheckDestroyed();
			if (!bRunFreeStartRight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bRunFreeStartRight");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bRunFreeStartRight_Offset), 0, bRunFreeStartRight_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bRunFreeStartRight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bRunFreeStartRight");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bRunFreeStartRight_Offset), 0, bRunFreeStartRight_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bRunFreeBwdR")]
	public bool bRunFreeBwdR
	{
		get
		{
			CheckDestroyed();
			if (!bRunFreeBwdR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bRunFreeBwdR");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bRunFreeBwdR_Offset), 0, bRunFreeBwdR_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bRunFreeBwdR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bRunFreeBwdR");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bRunFreeBwdR_Offset), 0, bRunFreeBwdR_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bRunFreeTurnFwdL")]
	public bool bRunFreeTurnFwdL
	{
		get
		{
			CheckDestroyed();
			if (!bRunFreeTurnFwdL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bRunFreeTurnFwdL");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bRunFreeTurnFwdL_Offset), 0, bRunFreeTurnFwdL_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bRunFreeTurnFwdL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bRunFreeTurnFwdL");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bRunFreeTurnFwdL_Offset), 0, bRunFreeTurnFwdL_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trans")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bRunFreeTurnLandFwdL")]
	public bool bRunFreeTurnLandFwdL
	{
		get
		{
			CheckDestroyed();
			if (!bRunFreeTurnLandFwdL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bRunFreeTurnLandFwdL");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bRunFreeTurnLandFwdL_Offset), 0, bRunFreeTurnLandFwdL_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bRunFreeTurnLandFwdL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bRunFreeTurnLandFwdL");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bRunFreeTurnLandFwdL_Offset), 0, bRunFreeTurnLandFwdL_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[Category("Trans")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bRunFreeTurnLandFwdR")]
	public bool bRunFreeTurnLandFwdR
	{
		get
		{
			CheckDestroyed();
			if (!bRunFreeTurnLandFwdR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bRunFreeTurnLandFwdR");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bRunFreeTurnLandFwdR_Offset), 0, bRunFreeTurnLandFwdR_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bRunFreeTurnLandFwdR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bRunFreeTurnLandFwdR");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bRunFreeTurnLandFwdR_Offset), 0, bRunFreeTurnLandFwdR_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trans")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bRushFreeBwdL")]
	public bool bRushFreeBwdL
	{
		get
		{
			CheckDestroyed();
			if (!bRushFreeBwdL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bRushFreeBwdL");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bRushFreeBwdL_Offset), 0, bRushFreeBwdL_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bRushFreeBwdL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bRushFreeBwdL");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bRushFreeBwdL_Offset), 0, bRushFreeBwdL_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("Trans")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bRushFreeLeft")]
	public bool bRushFreeLeft
	{
		get
		{
			CheckDestroyed();
			if (!bRushFreeLeft_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bRushFreeLeft");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bRushFreeLeft_Offset), 0, bRushFreeLeft_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bRushFreeLeft_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bRushFreeLeft");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bRushFreeLeft_Offset), 0, bRushFreeLeft_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trans")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bRushFreeRight")]
	public bool bRushFreeRight
	{
		get
		{
			CheckDestroyed();
			if (!bRushFreeRight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bRushFreeRight");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bRushFreeRight_Offset), 0, bRushFreeRight_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bRushFreeRight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bRushFreeRight");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bRushFreeRight_Offset), 0, bRushFreeRight_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bRushFreeBwdR")]
	public bool bRushFreeBwdR
	{
		get
		{
			CheckDestroyed();
			if (!bRushFreeBwdR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bRushFreeBwdR");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bRushFreeBwdR_Offset), 0, bRushFreeBwdR_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bRushFreeBwdR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bRushFreeBwdR");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bRushFreeBwdR_Offset), 0, bRushFreeBwdR_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[Category("Trans")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLastRush")]
	public bool bLastRush
	{
		get
		{
			CheckDestroyed();
			if (!bLastRush_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLastRush");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLastRush_Offset), 0, bLastRush_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLastRush_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLastRush");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLastRush_Offset), 0, bLastRush_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trans")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLastRun")]
	public bool bLastRun
	{
		get
		{
			CheckDestroyed();
			if (!bLastRun_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLastRun");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLastRun_Offset), 0, bLastRun_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLastRun_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLastRun");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLastRun_Offset), 0, bLastRun_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("Trans")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLeftFootFront")]
	public bool bLeftFootFront
	{
		get
		{
			CheckDestroyed();
			if (!bLeftFootFront_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLeftFootFront");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLeftFootFront_Offset), 0, bLeftFootFront_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLeftFootFront_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLeftFootFront");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLeftFootFront_Offset), 0, bLeftFootFront_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bRunStop")]
	public bool bRunStop
	{
		get
		{
			CheckDestroyed();
			if (!bRunStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bRunStop");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bRunStop_Offset), 0, bRunStop_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bRunStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bRunStop");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bRunStop_Offset), 0, bRunStop_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trans")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bRushStop")]
	public bool bRushStop
	{
		get
		{
			CheckDestroyed();
			if (!bRushStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bRushStop");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bRushStop_Offset), 0, bRushStop_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bRushStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bRushStop");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bRushStop_Offset), 0, bRushStop_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bToStop")]
	public bool bToStop
	{
		get
		{
			CheckDestroyed();
			if (!bToStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bToStop");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bToStop_Offset), 0, bToStop_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bToStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bToStop");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bToStop_Offset), 0, bToStop_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bToTurnStop")]
	public bool bToTurnStop
	{
		get
		{
			CheckDestroyed();
			if (!bToTurnStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bToTurnStop");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bToTurnStop_Offset), 0, bToTurnStop_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bToTurnStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bToTurnStop");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bToTurnStop_Offset), 0, bToTurnStop_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bIdleToWalk")]
	public bool bIdleToWalk
	{
		get
		{
			CheckDestroyed();
			if (!bIdleToWalk_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bIdleToWalk");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bIdleToWalk_Offset), 0, bIdleToWalk_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bIdleToWalk_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bIdleToWalk");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bIdleToWalk_Offset), 0, bIdleToWalk_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bRunToWalk")]
	public bool bRunToWalk
	{
		get
		{
			CheckDestroyed();
			if (!bRunToWalk_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bRunToWalk");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bRunToWalk_Offset), 0, bRunToWalk_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bRunToWalk_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bRunToWalk");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bRunToWalk_Offset), 0, bRunToWalk_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[Category("Trans")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bToRun")]
	public bool bToRun
	{
		get
		{
			CheckDestroyed();
			if (!bToRun_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bToRun");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bToRun_Offset), 0, bToRun_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bToRun_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bToRun");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bToRun_Offset), 0, bToRun_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("Trans")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bToRush")]
	public bool bToRush
	{
		get
		{
			CheckDestroyed();
			if (!bToRush_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bToRush");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bToRush_Offset), 0, bToRush_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bToRush_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bToRush");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bToRush_Offset), 0, bToRush_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveFromTurnStopFR")]
	public bool bLockMoveFromTurnStopFR
	{
		get
		{
			CheckDestroyed();
			if (!bLockMoveFromTurnStopFR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveFromTurnStopFR");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockMoveFromTurnStopFR_Offset), 0, bLockMoveFromTurnStopFR_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockMoveFromTurnStopFR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveFromTurnStopFR");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockMoveFromTurnStopFR_Offset), 0, bLockMoveFromTurnStopFR_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveFromTurnStopBR")]
	public bool bLockMoveFromTurnStopBR
	{
		get
		{
			CheckDestroyed();
			if (!bLockMoveFromTurnStopBR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveFromTurnStopBR");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockMoveFromTurnStopBR_Offset), 0, bLockMoveFromTurnStopBR_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockMoveFromTurnStopBR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveFromTurnStopBR");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockMoveFromTurnStopBR_Offset), 0, bLockMoveFromTurnStopBR_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveFromTurnStopBL")]
	public bool bLockMoveFromTurnStopBL
	{
		get
		{
			CheckDestroyed();
			if (!bLockMoveFromTurnStopBL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveFromTurnStopBL");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockMoveFromTurnStopBL_Offset), 0, bLockMoveFromTurnStopBL_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockMoveFromTurnStopBL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveFromTurnStopBL");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockMoveFromTurnStopBL_Offset), 0, bLockMoveFromTurnStopBL_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[Category("Trans")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveFromTurnStopFL")]
	public bool bLockMoveFromTurnStopFL
	{
		get
		{
			CheckDestroyed();
			if (!bLockMoveFromTurnStopFL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveFromTurnStopFL");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockMoveFromTurnStopFL_Offset), 0, bLockMoveFromTurnStopFL_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockMoveFromTurnStopFL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveFromTurnStopFL");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockMoveFromTurnStopFL_Offset), 0, bLockMoveFromTurnStopFL_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trans")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveTransFromFwd")]
	public bool bLockMoveTransFromFwd
	{
		get
		{
			CheckDestroyed();
			if (!bLockMoveTransFromFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveTransFromFwd");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockMoveTransFromFwd_Offset), 0, bLockMoveTransFromFwd_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockMoveTransFromFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveTransFromFwd");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockMoveTransFromFwd_Offset), 0, bLockMoveTransFromFwd_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trans")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveTransFromBwd")]
	public bool bLockMoveTransFromBwd
	{
		get
		{
			CheckDestroyed();
			if (!bLockMoveTransFromBwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveTransFromBwd");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockMoveTransFromBwd_Offset), 0, bLockMoveTransFromBwd_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockMoveTransFromBwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveTransFromBwd");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockMoveTransFromBwd_Offset), 0, bLockMoveTransFromBwd_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[Category("Trans")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveTransFromFL")]
	public bool bLockMoveTransFromFL
	{
		get
		{
			CheckDestroyed();
			if (!bLockMoveTransFromFL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveTransFromFL");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockMoveTransFromFL_Offset), 0, bLockMoveTransFromFL_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockMoveTransFromFL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveTransFromFL");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockMoveTransFromFL_Offset), 0, bLockMoveTransFromFL_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveTransFromFR")]
	public bool bLockMoveTransFromFR
	{
		get
		{
			CheckDestroyed();
			if (!bLockMoveTransFromFR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveTransFromFR");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockMoveTransFromFR_Offset), 0, bLockMoveTransFromFR_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockMoveTransFromFR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveTransFromFR");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockMoveTransFromFR_Offset), 0, bLockMoveTransFromFR_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trans")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveTransFromBL")]
	public bool bLockMoveTransFromBL
	{
		get
		{
			CheckDestroyed();
			if (!bLockMoveTransFromBL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveTransFromBL");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockMoveTransFromBL_Offset), 0, bLockMoveTransFromBL_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockMoveTransFromBL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveTransFromBL");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockMoveTransFromBL_Offset), 0, bLockMoveTransFromBL_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveTransFromBR")]
	public bool bLockMoveTransFromBR
	{
		get
		{
			CheckDestroyed();
			if (!bLockMoveTransFromBR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveTransFromBR");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockMoveTransFromBR_Offset), 0, bLockMoveTransFromBR_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockMoveTransFromBR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveTransFromBR");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockMoveTransFromBR_Offset), 0, bLockMoveTransFromBR_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveFromTurnStop")]
	public bool bLockMoveFromTurnStop
	{
		get
		{
			CheckDestroyed();
			if (!bLockMoveFromTurnStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveFromTurnStop");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockMoveFromTurnStop_Offset), 0, bLockMoveFromTurnStop_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockMoveFromTurnStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveFromTurnStop");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockMoveFromTurnStop_Offset), 0, bLockMoveFromTurnStop_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("Trans")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bInLockMoveState")]
	public bool bInLockMoveState
	{
		get
		{
			CheckDestroyed();
			if (!bInLockMoveState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bInLockMoveState");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bInLockMoveState_Offset), 0, bInLockMoveState_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bInLockMoveState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bInLockMoveState");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bInLockMoveState_Offset), 0, bInLockMoveState_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trans")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveTurnStart")]
	public bool bLockMoveTurnStart
	{
		get
		{
			CheckDestroyed();
			if (!bLockMoveTurnStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveTurnStart");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockMoveTurnStart_Offset), 0, bLockMoveTurnStart_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockMoveTurnStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveTurnStart");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockMoveTurnStart_Offset), 0, bLockMoveTurnStart_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveToFwdLoop")]
	public bool bLockMoveToFwdLoop
	{
		get
		{
			CheckDestroyed();
			if (!bLockMoveToFwdLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveToFwdLoop");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockMoveToFwdLoop_Offset), 0, bLockMoveToFwdLoop_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockMoveToFwdLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveToFwdLoop");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockMoveToFwdLoop_Offset), 0, bLockMoveToFwdLoop_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("Trans")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveToBwdLoop")]
	public bool bLockMoveToBwdLoop
	{
		get
		{
			CheckDestroyed();
			if (!bLockMoveToBwdLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveToBwdLoop");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockMoveToBwdLoop_Offset), 0, bLockMoveToBwdLoop_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockMoveToBwdLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveToBwdLoop");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockMoveToBwdLoop_Offset), 0, bLockMoveToBwdLoop_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trans")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveToFLLoop")]
	public bool bLockMoveToFLLoop
	{
		get
		{
			CheckDestroyed();
			if (!bLockMoveToFLLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveToFLLoop");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockMoveToFLLoop_Offset), 0, bLockMoveToFLLoop_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockMoveToFLLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveToFLLoop");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockMoveToFLLoop_Offset), 0, bLockMoveToFLLoop_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trans")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveToBLLoop")]
	public bool bLockMoveToBLLoop
	{
		get
		{
			CheckDestroyed();
			if (!bLockMoveToBLLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveToBLLoop");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockMoveToBLLoop_Offset), 0, bLockMoveToBLLoop_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockMoveToBLLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveToBLLoop");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockMoveToBLLoop_Offset), 0, bLockMoveToBLLoop_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trans")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveToFRLoop")]
	public bool bLockMoveToFRLoop
	{
		get
		{
			CheckDestroyed();
			if (!bLockMoveToFRLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveToFRLoop");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockMoveToFRLoop_Offset), 0, bLockMoveToFRLoop_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockMoveToFRLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveToFRLoop");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockMoveToFRLoop_Offset), 0, bLockMoveToFRLoop_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveToBRLoop")]
	public bool bLockMoveToBRLoop
	{
		get
		{
			CheckDestroyed();
			if (!bLockMoveToBRLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveToBRLoop");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockMoveToBRLoop_Offset), 0, bLockMoveToBRLoop_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockMoveToBRLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveToBRLoop");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockMoveToBRLoop_Offset), 0, bLockMoveToBRLoop_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("Trans")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveStartFwd")]
	public bool bLockMoveStartFwd
	{
		get
		{
			CheckDestroyed();
			if (!bLockMoveStartFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveStartFwd");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockMoveStartFwd_Offset), 0, bLockMoveStartFwd_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockMoveStartFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveStartFwd");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockMoveStartFwd_Offset), 0, bLockMoveStartFwd_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveStartBwd")]
	public bool bLockMoveStartBwd
	{
		get
		{
			CheckDestroyed();
			if (!bLockMoveStartBwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveStartBwd");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockMoveStartBwd_Offset), 0, bLockMoveStartBwd_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockMoveStartBwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveStartBwd");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockMoveStartBwd_Offset), 0, bLockMoveStartBwd_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveStartFL")]
	public bool bLockMoveStartFL
	{
		get
		{
			CheckDestroyed();
			if (!bLockMoveStartFL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveStartFL");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockMoveStartFL_Offset), 0, bLockMoveStartFL_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockMoveStartFL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveStartFL");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockMoveStartFL_Offset), 0, bLockMoveStartFL_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trans")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveStartFR")]
	public bool bLockMoveStartFR
	{
		get
		{
			CheckDestroyed();
			if (!bLockMoveStartFR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveStartFR");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockMoveStartFR_Offset), 0, bLockMoveStartFR_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockMoveStartFR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveStartFR");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockMoveStartFR_Offset), 0, bLockMoveStartFR_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveStartBL")]
	public bool bLockMoveStartBL
	{
		get
		{
			CheckDestroyed();
			if (!bLockMoveStartBL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveStartBL");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockMoveStartBL_Offset), 0, bLockMoveStartBL_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockMoveStartBL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveStartBL");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockMoveStartBL_Offset), 0, bLockMoveStartBL_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveStartBR")]
	public bool bLockMoveStartBR
	{
		get
		{
			CheckDestroyed();
			if (!bLockMoveStartBR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveStartBR");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockMoveStartBR_Offset), 0, bLockMoveStartBR_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockMoveStartBR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveStartBR");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockMoveStartBR_Offset), 0, bLockMoveStartBR_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trans")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveFRToFwd")]
	public bool bLockMoveFRToFwd
	{
		get
		{
			CheckDestroyed();
			if (!bLockMoveFRToFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveFRToFwd");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockMoveFRToFwd_Offset), 0, bLockMoveFRToFwd_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockMoveFRToFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveFRToFwd");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockMoveFRToFwd_Offset), 0, bLockMoveFRToFwd_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("Trans")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveFRToFL")]
	public bool bLockMoveFRToFL
	{
		get
		{
			CheckDestroyed();
			if (!bLockMoveFRToFL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveFRToFL");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockMoveFRToFL_Offset), 0, bLockMoveFRToFL_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockMoveFRToFL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveFRToFL");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockMoveFRToFL_Offset), 0, bLockMoveFRToFL_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveBRToBwd")]
	public bool bLockMoveBRToBwd
	{
		get
		{
			CheckDestroyed();
			if (!bLockMoveBRToBwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveBRToBwd");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockMoveBRToBwd_Offset), 0, bLockMoveBRToBwd_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockMoveBRToBwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveBRToBwd");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockMoveBRToBwd_Offset), 0, bLockMoveBRToBwd_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveBLToBwd")]
	public bool bLockMoveBLToBwd
	{
		get
		{
			CheckDestroyed();
			if (!bLockMoveBLToBwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveBLToBwd");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockMoveBLToBwd_Offset), 0, bLockMoveBLToBwd_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockMoveBLToBwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveBLToBwd");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockMoveBLToBwd_Offset), 0, bLockMoveBLToBwd_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveFLToFwd")]
	public bool bLockMoveFLToFwd
	{
		get
		{
			CheckDestroyed();
			if (!bLockMoveFLToFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveFLToFwd");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockMoveFLToFwd_Offset), 0, bLockMoveFLToFwd_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockMoveFLToFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveFLToFwd");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockMoveFLToFwd_Offset), 0, bLockMoveFLToFwd_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveFLToFR")]
	public bool bLockMoveFLToFR
	{
		get
		{
			CheckDestroyed();
			if (!bLockMoveFLToFR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveFLToFR");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockMoveFLToFR_Offset), 0, bLockMoveFLToFR_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockMoveFLToFR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveFLToFR");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockMoveFLToFR_Offset), 0, bLockMoveFLToFR_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveToTurnStopFR")]
	public bool bLockMoveToTurnStopFR
	{
		get
		{
			CheckDestroyed();
			if (!bLockMoveToTurnStopFR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveToTurnStopFR");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockMoveToTurnStopFR_Offset), 0, bLockMoveToTurnStopFR_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockMoveToTurnStopFR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveToTurnStopFR");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockMoveToTurnStopFR_Offset), 0, bLockMoveToTurnStopFR_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trans")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveToTurnStopBR")]
	public bool bLockMoveToTurnStopBR
	{
		get
		{
			CheckDestroyed();
			if (!bLockMoveToTurnStopBR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveToTurnStopBR");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockMoveToTurnStopBR_Offset), 0, bLockMoveToTurnStopBR_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockMoveToTurnStopBR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveToTurnStopBR");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockMoveToTurnStopBR_Offset), 0, bLockMoveToTurnStopBR_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trans")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveToTurnStopBL")]
	public bool bLockMoveToTurnStopBL
	{
		get
		{
			CheckDestroyed();
			if (!bLockMoveToTurnStopBL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveToTurnStopBL");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockMoveToTurnStopBL_Offset), 0, bLockMoveToTurnStopBL_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockMoveToTurnStopBL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveToTurnStopBL");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockMoveToTurnStopBL_Offset), 0, bLockMoveToTurnStopBL_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveToTurnStopFL")]
	public bool bLockMoveToTurnStopFL
	{
		get
		{
			CheckDestroyed();
			if (!bLockMoveToTurnStopFL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveToTurnStopFL");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockMoveToTurnStopFL_Offset), 0, bLockMoveToTurnStopFL_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockMoveToTurnStopFL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockMoveToTurnStopFL");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockMoveToTurnStopFL_Offset), 0, bLockMoveToTurnStopFL_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trans")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockWalk")]
	public bool bLockWalk
	{
		get
		{
			CheckDestroyed();
			if (!bLockWalk_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockWalk");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockWalk_Offset), 0, bLockWalk_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockWalk_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockWalk");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockWalk_Offset), 0, bLockWalk_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockRun")]
	public bool bLockRun
	{
		get
		{
			CheckDestroyed();
			if (!bLockRun_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockRun");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockRun_Offset), 0, bLockRun_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockRun_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockRun");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockRun_Offset), 0, bLockRun_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trans")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockStopFwd")]
	public bool bLockStopFwd
	{
		get
		{
			CheckDestroyed();
			if (!bLockStopFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockStopFwd");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockStopFwd_Offset), 0, bLockStopFwd_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockStopFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockStopFwd");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockStopFwd_Offset), 0, bLockStopFwd_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockStopBwd")]
	public bool bLockStopBwd
	{
		get
		{
			CheckDestroyed();
			if (!bLockStopBwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockStopBwd");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockStopBwd_Offset), 0, bLockStopBwd_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockStopBwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockStopBwd");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockStopBwd_Offset), 0, bLockStopBwd_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockStopLeft")]
	public bool bLockStopLeft
	{
		get
		{
			CheckDestroyed();
			if (!bLockStopLeft_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockStopLeft");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockStopLeft_Offset), 0, bLockStopLeft_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockStopLeft_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockStopLeft");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockStopLeft_Offset), 0, bLockStopLeft_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockStopRight")]
	public bool bLockStopRight
	{
		get
		{
			CheckDestroyed();
			if (!bLockStopRight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockStopRight");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockStopRight_Offset), 0, bLockStopRight_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockStopRight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockStopRight");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockStopRight_Offset), 0, bLockStopRight_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("Trans")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockStopFL")]
	public bool bLockStopFL
	{
		get
		{
			CheckDestroyed();
			if (!bLockStopFL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockStopFL");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockStopFL_Offset), 0, bLockStopFL_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockStopFL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockStopFL");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockStopFL_Offset), 0, bLockStopFL_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trans")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockStopFR")]
	public bool bLockStopFR
	{
		get
		{
			CheckDestroyed();
			if (!bLockStopFR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockStopFR");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockStopFR_Offset), 0, bLockStopFR_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockStopFR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockStopFR");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockStopFR_Offset), 0, bLockStopFR_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trans")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockStopBL")]
	public bool bLockStopBL
	{
		get
		{
			CheckDestroyed();
			if (!bLockStopBL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockStopBL");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockStopBL_Offset), 0, bLockStopBL_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockStopBL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockStopBL");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockStopBL_Offset), 0, bLockStopBL_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockStopBR")]
	public bool bLockStopBR
	{
		get
		{
			CheckDestroyed();
			if (!bLockStopBR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockStopBR");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockStopBR_Offset), 0, bLockStopBR_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockStopBR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bLockStopBR");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockStopBR_Offset), 0, bLockStopBR_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bInSequenceTransition")]
	public bool bInSequenceTransition
	{
		get
		{
			CheckDestroyed();
			if (!bInSequenceTransition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bInSequenceTransition");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bInSequenceTransition_Offset), 0, bInSequenceTransition_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bInSequenceTransition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bInSequenceTransition");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bInSequenceTransition_Offset), 0, bInSequenceTransition_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("Trans")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bToSequenceTransitionMove")]
	public bool bToSequenceTransitionMove
	{
		get
		{
			CheckDestroyed();
			if (!bToSequenceTransitionMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bToSequenceTransitionMove");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bToSequenceTransitionMove_Offset), 0, bToSequenceTransitionMove_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bToSequenceTransitionMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bToSequenceTransitionMove");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bToSequenceTransitionMove_Offset), 0, bToSequenceTransitionMove_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trans")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bSequenceTransitionFromWalk")]
	public bool bSequenceTransitionFromWalk
	{
		get
		{
			CheckDestroyed();
			if (!bSequenceTransitionFromWalk_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bSequenceTransitionFromWalk");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bSequenceTransitionFromWalk_Offset), 0, bSequenceTransitionFromWalk_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bSequenceTransitionFromWalk_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bSequenceTransitionFromWalk");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bSequenceTransitionFromWalk_Offset), 0, bSequenceTransitionFromWalk_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("Trans")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bSequenceTransitionFromRun")]
	public bool bSequenceTransitionFromRun
	{
		get
		{
			CheckDestroyed();
			if (!bSequenceTransitionFromRun_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bSequenceTransitionFromRun");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bSequenceTransitionFromRun_Offset), 0, bSequenceTransitionFromRun_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bSequenceTransitionFromRun_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bSequenceTransitionFromRun");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bSequenceTransitionFromRun_Offset), 0, bSequenceTransitionFromRun_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("Trans")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bSequenceTransitionFromRush")]
	public bool bSequenceTransitionFromRush
	{
		get
		{
			CheckDestroyed();
			if (!bSequenceTransitionFromRush_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bSequenceTransitionFromRush");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bSequenceTransitionFromRush_Offset), 0, bSequenceTransitionFromRush_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bSequenceTransitionFromRush_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:bSequenceTransitionFromRush");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bSequenceTransitionFromRush_Offset), 0, bSequenceTransitionFromRush_PropertyAddress.Address, value);
			}
		}
	}

	protected override void OnInitABPSetting()
	{
		if (!this.IsNullOrDestroyed())
		{
			BUABPSettingData aBPSettingData = TopAnimInst.ABPSettingData;
			if (aBPSettingData != null && b1.BGU.BUAnim.AbpHelperUtil.ShouldInitABPMoveModeData(Owner, EABPMoveMode.PlayerLocomotion, aBPSettingData))
			{
				InitPlayerLocomotionSetting(aBPSettingData.PlayerLocomotionSetting);
				InitData();
			}
		}
	}

	private void InitPlayerLocomotionSetting(BUABPPlayerLocomotionSettingData Setting)
	{
		AnimIdleList = Setting.ASIdleList;
		ASSequenceTransitionMoveFromWalkLFoot = Setting.ASSequenceTransitionMoveFromWalkLFoot;
		ASSequenceTransitionMoveFromWalkRFoot = Setting.ASSequenceTransitionMoveFromWalkRFoot;
		ASSequenceTransitionMoveFromRunLFoot = Setting.ASSequenceTransitionMoveFromRunLFoot;
		ASSequenceTransitionMoveFromRunRFoot = Setting.ASSequenceTransitionMoveFromRunRFoot;
		ASSequenceTransitionMoveFromRushLFoot = Setting.ASSequenceTransitionMoveFromRushLFoot;
		ASSequenceTransitionMoveFromRushRFoot = Setting.ASSequenceTransitionMoveFromRushRFoot;
		InitPlayerLocomotionFreeSetting(Setting.Free);
		InitPlayerLocomotionLockSetting(Setting.Lock);
	}

	private void InitPlayerLocomotionFreeSetting(BUABPPlayerLocomotion_FreeSettingData Setting)
	{
		BSFreeAdditiveMovingLean = Setting.BSFreeAdditiveMovingLean;
		BSWalkLoopFwd = Setting.BSWalkLoopFwd;
		BSRunLoopFwd = Setting.BSRunLoopFwd;
		BSRunLoopAdditive = Setting.BSRunLoopAdditive;
		BSRunLoopRotationAdditive = Setting.BSRunLoopRotationAdditive;
		BSRushLoopFwd = Setting.BSRushLoopFwd;
		BSRushLoopLean = Setting.BSRushLoopLean;
		ASWalkStartBwdL = Setting.ASWalkStartBwdL;
		ASWalkStartBwdR = Setting.ASWalkStartBwdR;
		ASWalkStartLeft = Setting.ASWalkStartLeft;
		ASWalkStartRight = Setting.ASWalkStartRight;
		ASWalkStartFwd = Setting.ASWalkStartFwd;
		ASWalkTurnBwdL = Setting.ASWalkTurnBwdL;
		ASWalkTurnBwdR = Setting.ASWalkTurnBwdR;
		ASWalkTurnLeft = Setting.ASWalkTurnLeft;
		ASWalkTurnRight = Setting.ASWalkTurnRight;
		ASFreeWalkStop = Setting.ASFreeWalkStop;
		ASRunStartBwdL = Setting.ASRunStartBwdL;
		ASRunStartBwdR = Setting.ASRunStartBwdR;
		ASRunStartLeft = Setting.ASRunStartLeft;
		ASRunStartRight = Setting.ASRunStartRight;
		ASRunStartFwd = Setting.ASRunStartFwd;
		ASRunTurnBwdL = Setting.ASRunTurnBwdL;
		ASRunTurnBwdR = Setting.ASRunTurnBwdR;
		ASRunTurnLeft = Setting.ASRunTurnLeft;
		ASRunTurnRight = Setting.ASRunTurnRight;
		ASRunTurnFwdL = Setting.ASRunTurnFwdL;
		ASRunTurnFwdR = Setting.ASRunTurnFwdR;
		ASRunTurnFwdFallingVelocityAdditive = Setting.ASRunTurnFwdFallingVelocityAdditive;
		ASRunTurnFwdSpeedAdditive = Setting.ASRunTurnFwdSpeedAdditive;
		ASRunTurnBwdFallingVelocityAdditive = Setting.ASRunTurnBwdFallingVelocityAdditive;
		ASFreeRunStop = Setting.ASFreeRunStop;
		ASFreeSprintStartBwdL = Setting.ASFreeSprintStartBwdL;
		ASFreeSprintStartBwdR = Setting.ASFreeSprintStartBwdR;
		ASFreeSprintStartL = Setting.ASFreeSprintStartLeft;
		ASFreeSprintStartR = Setting.ASFreeSprintStartRight;
		ASFreeSprintStartF = Setting.ASFreeSprintStartFwd;
		ASFreeSprintTurnBwdL = Setting.ASFreeSprintTurnBwdL;
		ASFreeSprintTurnBwdR = Setting.ASFreeSprintTurnBwdR;
		ASFreeSprintTurnL = Setting.ASFreeSprintTurnLeft;
		ASFreeSprintTurnR = Setting.ASFreeSprintTurnRight;
		ASFreeSprintStop = Setting.ASFreeSprintStop;
		ASFreeSprintStopSlopeUp = Setting.ASFreeSprintStopSlopeUp;
		SprintStopSlopeAngleThreshold = Setting.SprintStopSlopeAngleThreshold;
	}

	private void InitPlayerLocomotionLockSetting(BUABPPlayerLocomotion_LockSettingData Setting)
	{
		ASLockWalkLoopFwd = Setting.ASLockWalkLoopFwd;
		ASLockWalkLoopLeftF = Setting.ASLockWalkLoopLeftF;
		ASLockWalkLoopLeftB = Setting.ASLockWalkLoopLeftB;
		ASLockWalkLoopLeftFAdd = Setting.ASLockWalkLoopLeftFAdd;
		ASLockWalkLoopRightF = Setting.ASLockWalkLoopRightF;
		ASLockWalkLoopRightB = Setting.ASLockWalkLoopRightB;
		ASLockWalkLoopRightFAdd = Setting.ASLockWalkLoopRightFAdd;
		ASLockWalkLoopBwd = Setting.ASLockWalkLoopBwd;
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
		BSLockWalkTurnBR2FL = Setting.BSLockWalkTurnBR2FL;
		BSLockWalkTurnFR2FL = Setting.BSLockWalkTurnFR2FL;
		BSLockWalkTurnBL2FL = Setting.BSLockWalkTurnBL2FL;
		BSLockWalkTurnFR2BL = Setting.BSLockWalkTurnFR2BL;
		BSLockWalkTurnFL2BL = Setting.BSLockWalkTurnFL2BL;
		BSLockWalkTurnFL2FR = Setting.BSLockWalkTurnFL2FR;
		BSLockWalkTurnBL2FR = Setting.BSLockWalkTurnBL2FR;
		BSLockWalkTurnBR2FR = Setting.BSLockWalkTurnBR2FR;
		BSLockWalkTurnFL2BR = Setting.BSLockWalkTurnFL2BR;
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
		BSLockTurnStopBR = Setting.BSLockTurnStopBR;
		BSLockTurnStopBL = Setting.BSLockTurnStopBL;
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

	protected override void LinkedGraphInitializeAnimation()
	{
		ACharacter aCharacter = Owner as ACharacter;
		if (aCharacter != null)
		{
			if (TopAnimInst != null && TopAnimInst.ABPSettingData != null)
			{
				AnimIdle = TopAnimInst.ABPSettingData.CommonSetting.AnimSeqIdle;
			}
			CommonData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_ABPCommonSettingData, BUC_ABPCommonSettingData>(aCharacter);
			if (CommonData != null)
			{
				AnimIdle = CommonData.AnimIdle;
				AnimIdleList = CommonData.ExtendAnimIdleList;
			}
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(aCharacter);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_CachePlayerLocomotionAnimInst.Invoke(this);
			}
		}
	}

	protected override void LinkedGraphThreadUpdateAnimation(float DeltaTimeX)
	{
		UpdateData(DeltaTimeX);
	}

	private void InitBUCData()
	{
		if (!(Owner == null) && ECSExtension.IsECSActor(Owner))
		{
			BasicData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPBasicData, BUC_ABPBasicData>(Owner);
			ChrData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPCharacterData, BUC_ABPCharacterData>(Owner);
			PlayerLocomotionData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPPlayerLocomotionData, BUC_ABPPlayerLocomotionData>(Owner);
			CommonData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPCommonSettingData, BUC_ABPCommonSettingData>(Owner);
		}
	}

	private void InitData()
	{
		InitBUCData();
		GaitGroundedState = EGaitGroundedState.None;
		LastMoveGaitGroundedState = EGaitGroundedState.None;
		LastFrameGaitGroundedState = EGaitGroundedState.None;
		if (CommonData != null)
		{
			AnimIdle = CommonData.AnimIdle;
			AnimIdleList = CommonData.ExtendAnimIdleList;
		}
	}

	private void UpdateData(float DeltaTime)
	{
		if (CommonData == null || CommonData.FinalABPMoveMode != EABPMoveMode.PlayerLocomotion)
		{
			return;
		}
		if (CommonData != null)
		{
			AnimIdle = CommonData.AnimIdle;
			if (AnimIdleList != CommonData.ExtendAnimIdleList)
			{
				AnimIdleList = CommonData.ExtendAnimIdleList;
			}
		}
		float num = 0f;
		float num2 = 0f;
		float num3 = 0f;
		float num4 = 0f;
		bool flag = false;
		FVector fVector = FVector.ZeroVector;
		if (BasicData != null)
		{
			MoveSpeedLevel = BasicData.MoveSpeedLevel;
			MoveSpeedState = BasicData.MoveSpeedState;
			num = BasicData.Speed;
			num2 = BasicData.JogBaseSpeed;
			num3 = BasicData.SprintSpeed;
		}
		if (ChrData != null)
		{
			bLandingMove = ChrData.IsLandingMove;
			bLeftFootFront = ChrData.IsLeftFootFront();
			fVector = ChrData.MoveAcceleration;
			MaxSpeed = ChrData.MaxSpeed;
		}
		if (PlayerLocomotionData != null)
		{
			RandomIdleIndex = PlayerLocomotionData.RandomIdleIndex;
			FreeAdditiveMovingLeanX = PlayerLocomotionData.FreeAdditiveMovingLeanX;
			FreeAdditiveMovingLeanY = PlayerLocomotionData.FreeAdditiveMovingLeanY;
			FreeAdditiveMovingLeanAlpha = PlayerLocomotionData.FreeAdditiveMovingLeanAlpha;
			InputBlendAlpha = PlayerLocomotionData.InputBlendAlpha;
			VelocityBlendAlpha = PlayerLocomotionData.VelocityBlendAlpha;
			VelocityBlendAlphaStop = PlayerLocomotionData.VelocityBlendAlphaStop;
			bSwitchToLock = PlayerLocomotionData.bSwitchToLock;
			flag = PlayerLocomotionData.bShouldWaitRotateFinished;
			VelocityDeltaAngle = PlayerLocomotionData.VelocityDeltaAngle;
			VelocityDeltaAngleWalk = PlayerLocomotionData.VelocityDeltaAngleWalk;
			VelocityDeltaAngleRun = PlayerLocomotionData.VelocityDeltaAngleRun;
			VelocityDeltaAngleRush = PlayerLocomotionData.VelocityDeltaAngleRush;
			AnimRateWalk = PlayerLocomotionData.AnimRateWalk;
			AnimRateRun = PlayerLocomotionData.AnimRateRun;
			AnimRateRush = PlayerLocomotionData.AnimRateRush;
			AnimRateRunLock = PlayerLocomotionData.AnimRateRunLock;
			SlopeAngle = PlayerLocomotionData.SlopeAngle;
			FreeAdditiveMovingLeanSmoothX = PlayerLocomotionData.FreeAdditiveMovingLeanSmoothX;
			FreeAdditiveMovingLeanSmoothY = PlayerLocomotionData.FreeAdditiveMovingLeanSmoothY;
			WalkStartAngle = PlayerLocomotionData.WalkStartAngle;
			RunStartAngle = PlayerLocomotionData.RunStartAngle;
			RushStartAngle = PlayerLocomotionData.RushStartAngle;
			num4 = PlayerLocomotionData.StopFreeTimer;
			CurveMoveSpeedScale = PlayerLocomotionData.CurveMoveSpeedScale;
			TargetLockMoveDeltaAngle = PlayerLocomotionData.TargetLockMoveDeltaAngle;
			InputDeltaAngle = PlayerLocomotionData.InputDeltaAngle;
			InputDeltaAngleBackward = ((InputDeltaAngle > 0f) ? FMath.GetMappedRangeValueClamped(BRRange, InverseFRRange, InputDeltaAngle) : FMath.GetMappedRangeValueClamped(BLRange, InverseFLRange, InputDeltaAngle));
			LastFrameGaitGroundedState = GaitGroundedState;
			GaitGroundedState = PlayerLocomotionData.GaitGroundedState;
			LastMoveGaitGroundedState = PlayerLocomotionData.LastMoveGaitGroundedState;
			bInSequenceTransition = PlayerLocomotionData.bInSequenceTransition;
			bSequenceTransitionFromWalk = PlayerLocomotionData.bSequenceTransitionFromWalk;
			bSequenceTransitionFromRun = PlayerLocomotionData.bSequenceTransitionFromRun;
			bSequenceTransitionFromRush = PlayerLocomotionData.bSequenceTransitionFromRush;
			bToSequenceTransitionMove = bSequenceTransitionFromWalk || bSequenceTransitionFromRun || bSequenceTransitionFromRush;
			LockTurnFromAlphaFR = FMath.GetMappedRangeValueClamped(FRRange, AlphaRange, PlayerLocomotionData.VelocityDeltaAngleWhenTurn);
			LockTurnFromAlphaBR = FMath.GetMappedRangeValueClamped(InverseBRRange, AlphaRange, PlayerLocomotionData.VelocityDeltaAngleWhenTurn);
			LockTurnFromAlphaBL = FMath.GetMappedRangeValueClamped(InverseBLRange, AlphaRange, PlayerLocomotionData.VelocityDeltaAngleWhenTurn);
			LockTurnFromAlphaFL = FMath.GetMappedRangeValueClamped(FLRange, AlphaRange, PlayerLocomotionData.VelocityDeltaAngleWhenTurn);
			LockTurnToAlphaFR = FMath.GetMappedRangeValueClamped(FRRange, AlphaRange, PlayerLocomotionData.TargetLockMoveDeltaAngle);
			LockTurnToAlphaBR = FMath.GetMappedRangeValueClamped(InverseBRRange, AlphaRange, (PlayerLocomotionData.TargetLockMoveDeltaAngle < 0f) ? 180f : PlayerLocomotionData.TargetLockMoveDeltaAngle);
			LockTurnToAlphaBL = FMath.GetMappedRangeValueClamped(InverseBLRange, AlphaRange, (PlayerLocomotionData.TargetLockMoveDeltaAngle > 0f) ? (-180f) : PlayerLocomotionData.TargetLockMoveDeltaAngle);
			LockTurnToAlphaFL = FMath.GetMappedRangeValueClamped(FLRange, AlphaRange, PlayerLocomotionData.TargetLockMoveDeltaAngle);
			LockTurnStopAlphaFR = FMath.GetMappedRangeValueClamped(FRRange, AlphaRange, PlayerLocomotionData.VelocityDeltaAngleWhenTurnLast);
			LockTurnStopAlphaBR = FMath.GetMappedRangeValueClamped(InverseBRRange, AlphaRange, (PlayerLocomotionData.VelocityDeltaAngleWhenTurnLast < 0f) ? 180f : PlayerLocomotionData.VelocityDeltaAngleWhenTurnLast);
			LockTurnStopAlphaBL = FMath.GetMappedRangeValueClamped(InverseBLRange, AlphaRange, (PlayerLocomotionData.VelocityDeltaAngleWhenTurnLast > 0f) ? (-180f) : PlayerLocomotionData.VelocityDeltaAngleWhenTurnLast);
			LockTurnStopAlphaFL = FMath.GetMappedRangeValueClamped(FLRange, AlphaRange, PlayerLocomotionData.VelocityDeltaAngleWhenTurnLast);
			bLockMoveFromTurnStopFR = PlayerLocomotionData.LockTurnStopDir == ELockMoveDirectionSix.FR;
			bLockMoveFromTurnStopBR = PlayerLocomotionData.LockTurnStopDir == ELockMoveDirectionSix.BR;
			bLockMoveFromTurnStopBL = PlayerLocomotionData.LockTurnStopDir == ELockMoveDirectionSix.BL;
			bLockMoveFromTurnStopFL = PlayerLocomotionData.LockTurnStopDir == ELockMoveDirectionSix.FL;
			bLockMoveTransFromFwd = PlayerLocomotionData.LockMoveDirection == ELockMoveDirectionSix.F;
			bLockMoveTransFromBwd = PlayerLocomotionData.LockMoveDirection == ELockMoveDirectionSix.B;
			bLockMoveTransFromFL = PlayerLocomotionData.LockMoveDirection == ELockMoveDirectionSix.FL;
			bLockMoveTransFromFR = PlayerLocomotionData.LockMoveDirection == ELockMoveDirectionSix.FR;
			bLockMoveTransFromBL = PlayerLocomotionData.LockMoveDirection == ELockMoveDirectionSix.BL;
			bLockMoveTransFromBR = PlayerLocomotionData.LockMoveDirection == ELockMoveDirectionSix.BR;
			bLockMoveStartFwd = PlayerLocomotionData.LockMoveDirectionStart == ELockMoveDirectionSix.F;
			bLockMoveStartBwd = PlayerLocomotionData.LockMoveDirectionStart == ELockMoveDirectionSix.B;
			bLockMoveStartFL = PlayerLocomotionData.LockMoveDirectionStart == ELockMoveDirectionSix.FL;
			bLockMoveStartFR = PlayerLocomotionData.LockMoveDirectionStart == ELockMoveDirectionSix.FR;
			bLockMoveStartBL = PlayerLocomotionData.LockMoveDirectionStart == ELockMoveDirectionSix.BL;
			bLockMoveStartBR = PlayerLocomotionData.LockMoveDirectionStart == ELockMoveDirectionSix.BR;
			bLockMoveF = PlayerLocomotionData.TargetLockMoveDirection == EMoveDirection.Forward;
			bLockMoveB = PlayerLocomotionData.TargetLockMoveDirection == EMoveDirection.Backward;
			bLockMoveL = PlayerLocomotionData.TargetLockMoveDirection == EMoveDirection.Left;
			bLockMoveR = PlayerLocomotionData.TargetLockMoveDirection == EMoveDirection.Right;
			bLockMoveFromTurnStop = PlayerLocomotionData.bLockMoveFromTurnStop;
			bInLockMoveState = PlayerLocomotionData.bInLockMoveState;
			bLockMoveTurnStart = bLockMoveFromTurnStop && !bInLockMoveState;
			bLockMoveToFwdLoop = bInLockMoveState && !bLockMoveTransFromBwd;
			bLockMoveToBwdLoop = bInLockMoveState && !bLockMoveTransFromFwd;
			bool flag2 = (bLockMoveToFRLoop = bInLockMoveState && bLockMoveTransFromFwd);
			bLockMoveToFLLoop = flag2;
			bLockMoveToBLLoop = bInLockMoveState && !bLockMoveTransFromFR;
			bLockMoveToBRLoop = bInLockMoveState && !bLockMoveTransFromFL;
			bLockMoveFRToFwd = bLockMoveF && bInLockMoveState && bLockMoveTransFromBR;
			bLockMoveFRToFL = bLockMoveL && TargetLockMoveDeltaAngle > -95f;
			bLockMoveBRToBwd = bLockMoveB && bInLockMoveState && bLockMoveTransFromFR;
			bLockMoveBLToBwd = bLockMoveB && bInLockMoveState && bLockMoveTransFromFL;
			bLockMoveFLToFwd = bLockMoveF && bInLockMoveState && bLockMoveTransFromBL;
			bLockMoveFLToFR = bLockMoveR && TargetLockMoveDeltaAngle < 95f;
			bLockMoveToTurnStopFR = (bLockMoveTransFromFwd && PlayerLocomotionData.LockMoveDirectionStop == ELockMoveDirectionSix.FR) || (bLockMoveTransFromFR && TargetLockMoveDeltaAngle >= 0f);
			bLockMoveToTurnStopFL = (bLockMoveTransFromFwd && PlayerLocomotionData.LockMoveDirectionStop == ELockMoveDirectionSix.FL) || (bLockMoveTransFromFL && TargetLockMoveDeltaAngle <= 0f);
			bLockMoveToTurnStopBR = (bLockMoveTransFromBwd && PlayerLocomotionData.LockMoveDirectionStop == ELockMoveDirectionSix.BR) || (bLockMoveTransFromBR && TargetLockMoveDeltaAngle >= 0f);
			bLockMoveToTurnStopBL = (bLockMoveTransFromBwd && PlayerLocomotionData.LockMoveDirectionStop == ELockMoveDirectionSix.BL) || (bLockMoveTransFromBL && TargetLockMoveDeltaAngle <= 0f);
			float num5 = FMath.Abs(VelocityDeltaAngle);
			bLockStopFwd = num5 <= 22.5f;
			bLockStopBwd = num5 >= 157.5f;
			bLockStopLeft = -112.5f <= VelocityDeltaAngle && VelocityDeltaAngle <= -67.5f;
			bLockStopRight = 67.5f <= VelocityDeltaAngle && VelocityDeltaAngle <= 112.5f;
			bLockStopFL = -67.5f < VelocityDeltaAngle && VelocityDeltaAngle < -22.5f;
			bLockStopFR = 22.5f < VelocityDeltaAngle && VelocityDeltaAngle < 67.5f;
			bLockStopBL = -157.5f < VelocityDeltaAngle && VelocityDeltaAngle < -112.5f;
			bLockStopBR = 112.5f < VelocityDeltaAngle && VelocityDeltaAngle < 157.5f;
			LastFallingVelocity = PlayerLocomotionData.LastFallingVelocity;
		}
		bFreeTurn = num4 > 0f && num4 < 0.3f;
		bWalkFreeBwdL = -180f <= WalkStartAngle && WalkStartAngle < -135f;
		bWalkFreeLeft = -135f <= WalkStartAngle && WalkStartAngle < -45f;
		bWalkFreeRight = 45f < WalkStartAngle && WalkStartAngle <= 135f;
		bWalkFreeBwdR = 135f < WalkStartAngle && WalkStartAngle <= 180f;
		bRunFreeBwdL = -180f <= RunStartAngle && RunStartAngle < -135f;
		bRunFreeTurnLeft = -135f <= RunStartAngle && RunStartAngle < -60f;
		bRunFreeTurnRight = 60f < RunStartAngle && RunStartAngle <= 135f;
		bRunFreeStartLeft = -135f <= RunStartAngle && RunStartAngle < -45f;
		bRunFreeStartRight = 45f < RunStartAngle && RunStartAngle <= 135f;
		bRunFreeBwdR = 135f < RunStartAngle && RunStartAngle <= 180f;
		bRunFreeTurnFwdL = !bLeftFootFront;
		bRunFreeTurnLandFwdL = !bLeftFootFront && bLandingMove;
		bRunFreeTurnLandFwdR = bLeftFootFront && bLandingMove;
		bRushFreeBwdL = -180f <= RushStartAngle && RushStartAngle < -135f;
		bRushFreeLeft = -135f <= RushStartAngle && RushStartAngle < -45f;
		bRushFreeRight = 45f < RushStartAngle && RushStartAngle <= 135f;
		bRushFreeBwdR = 135f < RushStartAngle && RushStartAngle <= 180f;
		bLastRun = LastFrameGaitGroundedState == EGaitGroundedState.Run;
		bLastRush = LastFrameGaitGroundedState == EGaitGroundedState.Rush;
		bRunStop = LastMoveGaitGroundedState == EGaitGroundedState.Run || MoveSpeedLevel != EMoveSpeedLevel.Walk;
		bRushStop = LastMoveGaitGroundedState == EGaitGroundedState.Rush && MoveSpeedLevel != EMoveSpeedLevel.Walk;
		bToStop = (GaitGroundedState == EGaitGroundedState.Idle || GaitGroundedState == EGaitGroundedState.None) && !flag && !bInSequenceTransition;
		bToTurnStop = bToStop && bRunStop;
		bIdleToWalk = GaitGroundedState == EGaitGroundedState.Walk;
		bRunToWalk = bIdleToWalk && MoveSpeedLevel == EMoveSpeedLevel.Walk;
		bToRun = GaitGroundedState == EGaitGroundedState.Run;
		bToRush = GaitGroundedState == EGaitGroundedState.Rush;
		StrideWarpingSpeed = num;
		StrideWarpingAlpha = FMath.GetMappedRangeValueClamped(StrideWarpingAccelerationRange, AlphaRange, fVector.Size());
		if (GaitGroundedState != EGaitGroundedState.None && GaitGroundedState != EGaitGroundedState.Idle)
		{
			bLockWalk = GaitGroundedState == EGaitGroundedState.Walk;
			MoveLoopSpeedState = FMath.FInterpTo(MoveLoopSpeedState, (float)(int)GaitGroundedState - 1f, DeltaTime, 6f);
		}
		bLockRun = !bLockWalk;
		if (bToStop && !bToTurnStop)
		{
			bLockMoveFromTurnStopFR = bLockMoveToTurnStopFR;
			bLockMoveFromTurnStopFL = bLockMoveToTurnStopFL;
			bLockMoveFromTurnStopBR = bLockMoveToTurnStopBR;
			bLockMoveFromTurnStopBL = bLockMoveToTurnStopBL;
		}
		ASRunTurnBwdFallingVelocityAdditiveAlpha = FMath.GetMappedRangeValueClamped(new FVector2D(-600.0, -3000.0), AlphaRange1, LastFallingVelocity.Z);
		ASRunTurnFwdFallingVelocityAdditiveAlpha = FMath.GetMappedRangeValueClamped(new FVector2D(-400.0, -1500.0), AlphaRange1, LastFallingVelocity.Z);
		ASRunTurnFwdSpeedAdditiveAlpha = FMath.GetMappedRangeValueClamped(new FVector2D(num2, num3), new FVector2D(1.0, 0.10000000149011612), num);
	}

	[UFunction]
	[Category("Thread Safe")]
	[UMeta(MDClass.BlueprintThreadSafe)]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:GetRandomIdleAnim")]
	private void GetRandomIdleAnim(ref FAnimUpdateContext Context, ref FAnimNodeReference Node)
	{
		USequencePlayerLibrary.ConvertToSequencePlayerPure(Node, out var SequencePlayer, out var Result);
		if (Result)
		{
			UAnimSequence uAnimSequence = null;
			if (AnimIdleList.Count == 0)
			{
				uAnimSequence = AnimIdle;
			}
			else
			{
				int index = FMath.RandRange(0, AnimIdleList.Count - 1);
				uAnimSequence = AnimIdleList[index];
			}
			USequencePlayerLibrary.SetSequence(SequencePlayer, uAnimSequence);
		}
	}

	[UFunction]
	[BlueprintCallable]
	[Category("Thread Safe")]
	[UMeta(MDClass.BlueprintThreadSafe)]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:SetupSequenceTransitionAnim")]
	private void SetupSequenceTransitionAnim(ref FAnimUpdateContext Context, ref FAnimNodeReference Node)
	{
		USequencePlayerLibrary.ConvertToSequencePlayerPure(Node, out var SequencePlayer, out var Result);
		if (!Result || ChrData == null || PlayerLocomotionData == null)
		{
			return;
		}
		UAnimSequence sequence = null;
		if (ChrData.IsNextLeftFootStep())
		{
			if (bSequenceTransitionFromWalk)
			{
				sequence = ASSequenceTransitionMoveFromWalkRFoot;
			}
			else if (bSequenceTransitionFromRun)
			{
				sequence = ASSequenceTransitionMoveFromRunRFoot;
			}
			else if (bSequenceTransitionFromRush)
			{
				sequence = ASSequenceTransitionMoveFromRushRFoot;
			}
		}
		else if (bSequenceTransitionFromWalk)
		{
			sequence = ASSequenceTransitionMoveFromWalkLFoot;
		}
		else if (bSequenceTransitionFromRun)
		{
			sequence = ASSequenceTransitionMoveFromRunLFoot;
		}
		else if (bSequenceTransitionFromRush)
		{
			sequence = ASSequenceTransitionMoveFromRushLFoot;
		}
		USequencePlayerLibrary.SetSequence(SequencePlayer, sequence);
		PlayerLocomotionData.AfterSequenceTransition();
	}

	[UMeta(MDClass.BlueprintThreadSafe)]
	[BlueprintCallable]
	[UFunction]
	[Category("Thread Safe")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:SetUpRushStopAnim")]
	private void SetUpRushStopAnim(ref FAnimUpdateContext Context, ref FAnimNodeReference Node)
	{
		USequencePlayerLibrary.ConvertToSequencePlayerPure(Node, out var SequencePlayer, out var Result);
		if (Result)
		{
			UAnimSequence sequence = ASFreeSprintStop;
			if (PlayerLocomotionData != null && SprintStopSlopeAngleThreshold > 0f)
			{
				sequence = ((PlayerLocomotionData.SlopeAngle >= SprintStopSlopeAngleThreshold) ? ASFreeSprintStopSlopeUp : ASFreeSprintStop);
			}
			USequencePlayerLibrary.SetSequence(SequencePlayer, sequence);
		}
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:OnEnterSeqMove")]
	private void OnEnterSeqMove()
	{
		BGS_EventCollectionCS.Get(Owner).Evt_BGS_EnterSeqMove.Invoke();
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:OnLeftSeqMove")]
	private void OnLeftSeqMove()
	{
		BGS_EventCollectionCS.Get(Owner).Evt_BGS_LeftSeqMove.Invoke();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:OnLeftSeqMove")]
	private static void OnLeftSeqMove__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_PlayerLocomotion bUAnimHumanoidCS_PlayerLocomotion = GCHelper.Find<BUAnimHumanoidCS_PlayerLocomotion>(obj);
		bUAnimHumanoidCS_PlayerLocomotion.OnLeftSeqMove();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:OnEnterSeqMove")]
	private static void OnEnterSeqMove__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_PlayerLocomotion bUAnimHumanoidCS_PlayerLocomotion = GCHelper.Find<BUAnimHumanoidCS_PlayerLocomotion>(obj);
		bUAnimHumanoidCS_PlayerLocomotion.OnEnterSeqMove();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:SetUpRushStopAnim")]
	private static void SetUpRushStopAnim__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_PlayerLocomotion bUAnimHumanoidCS_PlayerLocomotion = GCHelper.Find<BUAnimHumanoidCS_PlayerLocomotion>(obj);
		FAnimUpdateContext Context = StructAsClassMarshaler<FAnimUpdateContext>.FromNative(IntPtr.Add(buffer, SetUpRushStopAnim_Context_Offset));
		FAnimNodeReference Node = StructAsClassMarshaler<FAnimNodeReference>.FromNative(IntPtr.Add(buffer, SetUpRushStopAnim_Node_Offset));
		bUAnimHumanoidCS_PlayerLocomotion.SetUpRushStopAnim(ref Context, ref Node);
		StructAsClassMarshaler<FAnimUpdateContext>.ToNative(IntPtr.Add(buffer, SetUpRushStopAnim_Context_Offset), Context);
		StructAsClassMarshaler<FAnimNodeReference>.ToNative(IntPtr.Add(buffer, SetUpRushStopAnim_Node_Offset), Node);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:GetRandomIdleAnim")]
	private static void GetRandomIdleAnim__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_PlayerLocomotion bUAnimHumanoidCS_PlayerLocomotion = GCHelper.Find<BUAnimHumanoidCS_PlayerLocomotion>(obj);
		FAnimUpdateContext Context = StructAsClassMarshaler<FAnimUpdateContext>.FromNative(IntPtr.Add(buffer, GetRandomIdleAnim_Context_Offset));
		FAnimNodeReference Node = StructAsClassMarshaler<FAnimNodeReference>.FromNative(IntPtr.Add(buffer, GetRandomIdleAnim_Node_Offset));
		bUAnimHumanoidCS_PlayerLocomotion.GetRandomIdleAnim(ref Context, ref Node);
		StructAsClassMarshaler<FAnimUpdateContext>.ToNative(IntPtr.Add(buffer, GetRandomIdleAnim_Context_Offset), Context);
		StructAsClassMarshaler<FAnimNodeReference>.ToNative(IntPtr.Add(buffer, GetRandomIdleAnim_Node_Offset), Node);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:SetupSequenceTransitionAnim")]
	private static void SetupSequenceTransitionAnim__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_PlayerLocomotion bUAnimHumanoidCS_PlayerLocomotion = GCHelper.Find<BUAnimHumanoidCS_PlayerLocomotion>(obj);
		FAnimUpdateContext Context = StructAsClassMarshaler<FAnimUpdateContext>.FromNative(IntPtr.Add(buffer, SetupSequenceTransitionAnim_Context_Offset));
		FAnimNodeReference Node = StructAsClassMarshaler<FAnimNodeReference>.FromNative(IntPtr.Add(buffer, SetupSequenceTransitionAnim_Node_Offset));
		bUAnimHumanoidCS_PlayerLocomotion.SetupSequenceTransitionAnim(ref Context, ref Node);
		StructAsClassMarshaler<FAnimUpdateContext>.ToNative(IntPtr.Add(buffer, SetupSequenceTransitionAnim_Context_Offset), Context);
		StructAsClassMarshaler<FAnimNodeReference>.ToNative(IntPtr.Add(buffer, SetupSequenceTransitionAnim_Node_Offset), Node);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion");
		BSFreeAdditiveMovingLean_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSFreeAdditiveMovingLean");
		BSFreeAdditiveMovingLean_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSFreeAdditiveMovingLean", Classes.FObjectProperty);
		FreeAdditiveMovingLeanX_Offset = NativeReflection.GetPropertyOffset(intPtr, "FreeAdditiveMovingLeanX");
		FreeAdditiveMovingLeanX_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FreeAdditiveMovingLeanX", Classes.FFloatProperty);
		FreeAdditiveMovingLeanY_Offset = NativeReflection.GetPropertyOffset(intPtr, "FreeAdditiveMovingLeanY");
		FreeAdditiveMovingLeanY_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FreeAdditiveMovingLeanY", Classes.FFloatProperty);
		FreeAdditiveMovingLeanAlpha_Offset = NativeReflection.GetPropertyOffset(intPtr, "FreeAdditiveMovingLeanAlpha");
		FreeAdditiveMovingLeanAlpha_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FreeAdditiveMovingLeanAlpha", Classes.FFloatProperty);
		ASFreeSprintStartF_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASFreeSprintStartF");
		ASFreeSprintStartF_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASFreeSprintStartF", Classes.FObjectProperty);
		ASFreeSprintStartL_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASFreeSprintStartL");
		ASFreeSprintStartL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASFreeSprintStartL", Classes.FObjectProperty);
		ASFreeSprintStartR_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASFreeSprintStartR");
		ASFreeSprintStartR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASFreeSprintStartR", Classes.FObjectProperty);
		ASFreeSprintStartBwdL_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASFreeSprintStartBwdL");
		ASFreeSprintStartBwdL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASFreeSprintStartBwdL", Classes.FObjectProperty);
		ASFreeSprintStartBwdR_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASFreeSprintStartBwdR");
		ASFreeSprintStartBwdR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASFreeSprintStartBwdR", Classes.FObjectProperty);
		ASFreeSprintTurnL_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASFreeSprintTurnL");
		ASFreeSprintTurnL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASFreeSprintTurnL", Classes.FObjectProperty);
		ASFreeSprintTurnR_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASFreeSprintTurnR");
		ASFreeSprintTurnR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASFreeSprintTurnR", Classes.FObjectProperty);
		ASFreeSprintTurnBwdL_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASFreeSprintTurnBwdL");
		ASFreeSprintTurnBwdL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASFreeSprintTurnBwdL", Classes.FObjectProperty);
		ASFreeSprintTurnBwdR_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASFreeSprintTurnBwdR");
		ASFreeSprintTurnBwdR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASFreeSprintTurnBwdR", Classes.FObjectProperty);
		ASFreeRunStop_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASFreeRunStop");
		ASFreeRunStop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASFreeRunStop", Classes.FObjectProperty);
		ASFreeSprintStop_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASFreeSprintStop");
		ASFreeSprintStop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASFreeSprintStop", Classes.FObjectProperty);
		ASFreeSprintStopSlopeUp_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASFreeSprintStopSlopeUp");
		ASFreeSprintStopSlopeUp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASFreeSprintStopSlopeUp", Classes.FObjectProperty);
		BSLockWalkTurnF2B_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSLockWalkTurnF2B");
		BSLockWalkTurnF2B_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSLockWalkTurnF2B", Classes.FObjectProperty);
		BSLockWalkTurnB2F_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSLockWalkTurnB2F");
		BSLockWalkTurnB2F_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSLockWalkTurnB2F", Classes.FObjectProperty);
		BSLockRunTurnF2B_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSLockRunTurnF2B");
		BSLockRunTurnF2B_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSLockRunTurnF2B", Classes.FObjectProperty);
		BSLockRunTurnB2F_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSLockRunTurnB2F");
		BSLockRunTurnB2F_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSLockRunTurnB2F", Classes.FObjectProperty);
		BSWalkLoopFwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSWalkLoopFwd");
		BSWalkLoopFwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSWalkLoopFwd", Classes.FObjectProperty);
		VelocityDeltaAngle_Offset = NativeReflection.GetPropertyOffset(intPtr, "VelocityDeltaAngle");
		VelocityDeltaAngle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "VelocityDeltaAngle", Classes.FFloatProperty);
		VelocityDeltaAngleWalk_Offset = NativeReflection.GetPropertyOffset(intPtr, "VelocityDeltaAngleWalk");
		VelocityDeltaAngleWalk_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "VelocityDeltaAngleWalk", Classes.FFloatProperty);
		VelocityDeltaAngleRun_Offset = NativeReflection.GetPropertyOffset(intPtr, "VelocityDeltaAngleRun");
		VelocityDeltaAngleRun_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "VelocityDeltaAngleRun", Classes.FFloatProperty);
		VelocityDeltaAngleRush_Offset = NativeReflection.GetPropertyOffset(intPtr, "VelocityDeltaAngleRush");
		VelocityDeltaAngleRush_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "VelocityDeltaAngleRush", Classes.FFloatProperty);
		SlopeAngle_Offset = NativeReflection.GetPropertyOffset(intPtr, "SlopeAngle");
		SlopeAngle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SlopeAngle", Classes.FFloatProperty);
		BSRunLoopFwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSRunLoopFwd");
		BSRunLoopFwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSRunLoopFwd", Classes.FObjectProperty);
		AnimRateWalk_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimRateWalk");
		AnimRateWalk_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimRateWalk", Classes.FFloatProperty);
		AnimRateRun_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimRateRun");
		AnimRateRun_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimRateRun", Classes.FFloatProperty);
		AnimRateRush_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimRateRush");
		AnimRateRush_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimRateRush", Classes.FFloatProperty);
		AnimRateRunLock_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimRateRunLock");
		AnimRateRunLock_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimRateRunLock", Classes.FFloatProperty);
		BSRunLoopAdditive_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSRunLoopAdditive");
		BSRunLoopAdditive_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSRunLoopAdditive", Classes.FObjectProperty);
		BSRunLoopRotationAdditive_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSRunLoopRotationAdditive");
		BSRunLoopRotationAdditive_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSRunLoopRotationAdditive", Classes.FObjectProperty);
		FreeAdditiveMovingLeanSmoothX_Offset = NativeReflection.GetPropertyOffset(intPtr, "FreeAdditiveMovingLeanSmoothX");
		FreeAdditiveMovingLeanSmoothX_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FreeAdditiveMovingLeanSmoothX", Classes.FFloatProperty);
		FreeAdditiveMovingLeanSmoothY_Offset = NativeReflection.GetPropertyOffset(intPtr, "FreeAdditiveMovingLeanSmoothY");
		FreeAdditiveMovingLeanSmoothY_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FreeAdditiveMovingLeanSmoothY", Classes.FFloatProperty);
		BSRushLoopFwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSRushLoopFwd");
		BSRushLoopFwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSRushLoopFwd", Classes.FObjectProperty);
		BSRushLoopLean_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSRushLoopLean");
		BSRushLoopLean_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSRushLoopLean", Classes.FObjectProperty);
		ASWalkStartBwdL_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASWalkStartBwdL");
		ASWalkStartBwdL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASWalkStartBwdL", Classes.FObjectProperty);
		ASWalkStartLeft_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASWalkStartLeft");
		ASWalkStartLeft_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASWalkStartLeft", Classes.FObjectProperty);
		ASWalkStartFwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASWalkStartFwd");
		ASWalkStartFwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASWalkStartFwd", Classes.FObjectProperty);
		ASWalkStartRight_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASWalkStartRight");
		ASWalkStartRight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASWalkStartRight", Classes.FObjectProperty);
		ASWalkStartBwdR_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASWalkStartBwdR");
		ASWalkStartBwdR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASWalkStartBwdR", Classes.FObjectProperty);
		ASWalkTurnBwdL_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASWalkTurnBwdL");
		ASWalkTurnBwdL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASWalkTurnBwdL", Classes.FObjectProperty);
		ASWalkTurnLeft_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASWalkTurnLeft");
		ASWalkTurnLeft_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASWalkTurnLeft", Classes.FObjectProperty);
		ASWalkTurnRight_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASWalkTurnRight");
		ASWalkTurnRight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASWalkTurnRight", Classes.FObjectProperty);
		ASWalkTurnBwdR_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASWalkTurnBwdR");
		ASWalkTurnBwdR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASWalkTurnBwdR", Classes.FObjectProperty);
		WalkStartAngle_Offset = NativeReflection.GetPropertyOffset(intPtr, "WalkStartAngle");
		WalkStartAngle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WalkStartAngle", Classes.FFloatProperty);
		ASRunStartBwdL_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunStartBwdL");
		ASRunStartBwdL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunStartBwdL", Classes.FObjectProperty);
		ASRunStartLeft_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunStartLeft");
		ASRunStartLeft_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunStartLeft", Classes.FObjectProperty);
		ASRunStartFwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunStartFwd");
		ASRunStartFwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunStartFwd", Classes.FObjectProperty);
		ASRunStartRight_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunStartRight");
		ASRunStartRight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunStartRight", Classes.FObjectProperty);
		ASRunStartBwdR_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunStartBwdR");
		ASRunStartBwdR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunStartBwdR", Classes.FObjectProperty);
		ASRunTurnBwdL_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunTurnBwdL");
		ASRunTurnBwdL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunTurnBwdL", Classes.FObjectProperty);
		ASRunTurnLeft_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunTurnLeft");
		ASRunTurnLeft_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunTurnLeft", Classes.FObjectProperty);
		ASRunTurnRight_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunTurnRight");
		ASRunTurnRight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunTurnRight", Classes.FObjectProperty);
		ASRunTurnBwdR_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunTurnBwdR");
		ASRunTurnBwdR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunTurnBwdR", Classes.FObjectProperty);
		ASRunTurnBwdFallingVelocityAdditive_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunTurnBwdFallingVelocityAdditive");
		ASRunTurnBwdFallingVelocityAdditive_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunTurnBwdFallingVelocityAdditive", Classes.FObjectProperty);
		ASRunTurnBwdFallingVelocityAdditiveAlpha_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunTurnBwdFallingVelocityAdditiveAlpha");
		ASRunTurnBwdFallingVelocityAdditiveAlpha_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunTurnBwdFallingVelocityAdditiveAlpha", Classes.FFloatProperty);
		ASRunTurnFwdL_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunTurnFwdL");
		ASRunTurnFwdL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunTurnFwdL", Classes.FObjectProperty);
		ASRunTurnFwdR_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunTurnFwdR");
		ASRunTurnFwdR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunTurnFwdR", Classes.FObjectProperty);
		ASRunTurnFwdFallingVelocityAdditive_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunTurnFwdFallingVelocityAdditive");
		ASRunTurnFwdFallingVelocityAdditive_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunTurnFwdFallingVelocityAdditive", Classes.FObjectProperty);
		ASRunTurnFwdFallingVelocityAdditiveAlpha_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunTurnFwdFallingVelocityAdditiveAlpha");
		ASRunTurnFwdFallingVelocityAdditiveAlpha_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunTurnFwdFallingVelocityAdditiveAlpha", Classes.FFloatProperty);
		ASRunTurnFwdSpeedAdditive_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunTurnFwdSpeedAdditive");
		ASRunTurnFwdSpeedAdditive_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunTurnFwdSpeedAdditive", Classes.FObjectProperty);
		ASRunTurnFwdSpeedAdditiveAlpha_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunTurnFwdSpeedAdditiveAlpha");
		ASRunTurnFwdSpeedAdditiveAlpha_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunTurnFwdSpeedAdditiveAlpha", Classes.FFloatProperty);
		RunStartAngle_Offset = NativeReflection.GetPropertyOffset(intPtr, "RunStartAngle");
		RunStartAngle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RunStartAngle", Classes.FFloatProperty);
		RushStartAngle_Offset = NativeReflection.GetPropertyOffset(intPtr, "RushStartAngle");
		RushStartAngle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RushStartAngle", Classes.FFloatProperty);
		ASFreeWalkStop_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASFreeWalkStop");
		ASFreeWalkStop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASFreeWalkStop", Classes.FObjectProperty);
		BSLockWalkStartFwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSLockWalkStartFwd");
		BSLockWalkStartFwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSLockWalkStartFwd", Classes.FObjectProperty);
		BSLockWalkStartBwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSLockWalkStartBwd");
		BSLockWalkStartBwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSLockWalkStartBwd", Classes.FObjectProperty);
		ASLockWalkStartFwdL_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockWalkStartFwdL");
		ASLockWalkStartFwdL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockWalkStartFwdL", Classes.FObjectProperty);
		ASLockWalkStartFwdR_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockWalkStartFwdR");
		ASLockWalkStartFwdR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockWalkStartFwdR", Classes.FObjectProperty);
		ASLockWalkStartBwdL_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockWalkStartBwdL");
		ASLockWalkStartBwdL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockWalkStartBwdL", Classes.FObjectProperty);
		ASLockWalkStartBwdR_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockWalkStartBwdR");
		ASLockWalkStartBwdR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockWalkStartBwdR", Classes.FObjectProperty);
		ASLockWalkStartLeftF_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockWalkStartLeftF");
		ASLockWalkStartLeftF_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockWalkStartLeftF", Classes.FObjectProperty);
		ASLockWalkStartLeftB_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockWalkStartLeftB");
		ASLockWalkStartLeftB_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockWalkStartLeftB", Classes.FObjectProperty);
		ASLockWalkStartRightF_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockWalkStartRightF");
		ASLockWalkStartRightF_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockWalkStartRightF", Classes.FObjectProperty);
		ASLockWalkStartRightB_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockWalkStartRightB");
		ASLockWalkStartRightB_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockWalkStartRightB", Classes.FObjectProperty);
		BSLockRunStartFwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSLockRunStartFwd");
		BSLockRunStartFwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSLockRunStartFwd", Classes.FObjectProperty);
		BSLockRunStartBwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSLockRunStartBwd");
		BSLockRunStartBwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSLockRunStartBwd", Classes.FObjectProperty);
		ASLockRunStartFwdL_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockRunStartFwdL");
		ASLockRunStartFwdL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockRunStartFwdL", Classes.FObjectProperty);
		ASLockRunStartFwdR_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockRunStartFwdR");
		ASLockRunStartFwdR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockRunStartFwdR", Classes.FObjectProperty);
		ASLockRunStartBwdL_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockRunStartBwdL");
		ASLockRunStartBwdL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockRunStartBwdL", Classes.FObjectProperty);
		ASLockRunStartBwdR_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockRunStartBwdR");
		ASLockRunStartBwdR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockRunStartBwdR", Classes.FObjectProperty);
		ASLockRunStartLeftF_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockRunStartLeftF");
		ASLockRunStartLeftF_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockRunStartLeftF", Classes.FObjectProperty);
		ASLockRunStartLeftB_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockRunStartLeftB");
		ASLockRunStartLeftB_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockRunStartLeftB", Classes.FObjectProperty);
		ASLockRunStartRightF_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockRunStartRightF");
		ASLockRunStartRightF_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockRunStartRightF", Classes.FObjectProperty);
		ASLockRunStartRightB_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockRunStartRightB");
		ASLockRunStartRightB_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockRunStartRightB", Classes.FObjectProperty);
		BSLockTurnFRFromFRBL_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSLockTurnFRFromFRBL");
		BSLockTurnFRFromFRBL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSLockTurnFRFromFRBL", Classes.FObjectProperty);
		BSLockTurnFRFromFLBR_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSLockTurnFRFromFLBR");
		BSLockTurnFRFromFLBR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSLockTurnFRFromFLBR", Classes.FObjectProperty);
		BSLockTurnBRFromFRBL_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSLockTurnBRFromFRBL");
		BSLockTurnBRFromFRBL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSLockTurnBRFromFRBL", Classes.FObjectProperty);
		BSLockTurnBRFromFLBR_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSLockTurnBRFromFLBR");
		BSLockTurnBRFromFLBR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSLockTurnBRFromFLBR", Classes.FObjectProperty);
		BSLockTurnBLFromFRBL_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSLockTurnBLFromFRBL");
		BSLockTurnBLFromFRBL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSLockTurnBLFromFRBL", Classes.FObjectProperty);
		BSLockTurnBLFromFLBR_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSLockTurnBLFromFLBR");
		BSLockTurnBLFromFLBR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSLockTurnBLFromFLBR", Classes.FObjectProperty);
		BSLockTurnFLFromFRBL_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSLockTurnFLFromFRBL");
		BSLockTurnFLFromFRBL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSLockTurnFLFromFRBL", Classes.FObjectProperty);
		BSLockTurnFLFromFLBR_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSLockTurnFLFromFLBR");
		BSLockTurnFLFromFLBR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSLockTurnFLFromFLBR", Classes.FObjectProperty);
		LockTurnToAlphaFR_Offset = NativeReflection.GetPropertyOffset(intPtr, "LockTurnToAlphaFR");
		LockTurnToAlphaFR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LockTurnToAlphaFR", Classes.FFloatProperty);
		LockTurnToAlphaBR_Offset = NativeReflection.GetPropertyOffset(intPtr, "LockTurnToAlphaBR");
		LockTurnToAlphaBR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LockTurnToAlphaBR", Classes.FFloatProperty);
		LockTurnToAlphaBL_Offset = NativeReflection.GetPropertyOffset(intPtr, "LockTurnToAlphaBL");
		LockTurnToAlphaBL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LockTurnToAlphaBL", Classes.FFloatProperty);
		LockTurnToAlphaFL_Offset = NativeReflection.GetPropertyOffset(intPtr, "LockTurnToAlphaFL");
		LockTurnToAlphaFL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LockTurnToAlphaFL", Classes.FFloatProperty);
		LockTurnFromAlphaFR_Offset = NativeReflection.GetPropertyOffset(intPtr, "LockTurnFromAlphaFR");
		LockTurnFromAlphaFR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LockTurnFromAlphaFR", Classes.FFloatProperty);
		LockTurnFromAlphaBR_Offset = NativeReflection.GetPropertyOffset(intPtr, "LockTurnFromAlphaBR");
		LockTurnFromAlphaBR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LockTurnFromAlphaBR", Classes.FFloatProperty);
		LockTurnFromAlphaBL_Offset = NativeReflection.GetPropertyOffset(intPtr, "LockTurnFromAlphaBL");
		LockTurnFromAlphaBL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LockTurnFromAlphaBL", Classes.FFloatProperty);
		LockTurnFromAlphaFL_Offset = NativeReflection.GetPropertyOffset(intPtr, "LockTurnFromAlphaFL");
		LockTurnFromAlphaFL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LockTurnFromAlphaFL", Classes.FFloatProperty);
		ASLockWalkLoopFwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockWalkLoopFwd");
		ASLockWalkLoopFwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockWalkLoopFwd", Classes.FObjectProperty);
		ASLockWalkLoopBwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockWalkLoopBwd");
		ASLockWalkLoopBwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockWalkLoopBwd", Classes.FObjectProperty);
		ASLockWalkLoopLeftF_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockWalkLoopLeftF");
		ASLockWalkLoopLeftF_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockWalkLoopLeftF", Classes.FObjectProperty);
		ASLockWalkLoopRightF_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockWalkLoopRightF");
		ASLockWalkLoopRightF_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockWalkLoopRightF", Classes.FObjectProperty);
		ASLockWalkLoopLeftB_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockWalkLoopLeftB");
		ASLockWalkLoopLeftB_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockWalkLoopLeftB", Classes.FObjectProperty);
		ASLockWalkLoopRightB_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockWalkLoopRightB");
		ASLockWalkLoopRightB_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockWalkLoopRightB", Classes.FObjectProperty);
		ASLockWalkLoopLeftFAdd_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockWalkLoopLeftFAdd");
		ASLockWalkLoopLeftFAdd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockWalkLoopLeftFAdd", Classes.FObjectProperty);
		ASLockWalkLoopRightFAdd_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockWalkLoopRightFAdd");
		ASLockWalkLoopRightFAdd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockWalkLoopRightFAdd", Classes.FObjectProperty);
		ASLockRunLoopFwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockRunLoopFwd");
		ASLockRunLoopFwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockRunLoopFwd", Classes.FObjectProperty);
		ASLockRunLoopBwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockRunLoopBwd");
		ASLockRunLoopBwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockRunLoopBwd", Classes.FObjectProperty);
		ASLockRunLoopLeftF_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockRunLoopLeftF");
		ASLockRunLoopLeftF_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockRunLoopLeftF", Classes.FObjectProperty);
		ASLockRunLoopRightF_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockRunLoopRightF");
		ASLockRunLoopRightF_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockRunLoopRightF", Classes.FObjectProperty);
		ASLockRunLoopLeftB_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockRunLoopLeftB");
		ASLockRunLoopLeftB_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockRunLoopLeftB", Classes.FObjectProperty);
		ASLockRunLoopRightB_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockRunLoopRightB");
		ASLockRunLoopRightB_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockRunLoopRightB", Classes.FObjectProperty);
		ASLockRunLoopLeftFAdd_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockRunLoopLeftFAdd");
		ASLockRunLoopLeftFAdd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockRunLoopLeftFAdd", Classes.FObjectProperty);
		ASLockRunLoopRightFAdd_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockRunLoopRightFAdd");
		ASLockRunLoopRightFAdd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockRunLoopRightFAdd", Classes.FObjectProperty);
		BSLockWalkTurnFR2BL_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSLockWalkTurnFR2BL");
		BSLockWalkTurnFR2BL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSLockWalkTurnFR2BL", Classes.FObjectProperty);
		BSLockWalkTurnBR2FL_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSLockWalkTurnBR2FL");
		BSLockWalkTurnBR2FL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSLockWalkTurnBR2FL", Classes.FObjectProperty);
		BSLockWalkTurnBL2FR_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSLockWalkTurnBL2FR");
		BSLockWalkTurnBL2FR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSLockWalkTurnBL2FR", Classes.FObjectProperty);
		BSLockWalkTurnFL2BR_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSLockWalkTurnFL2BR");
		BSLockWalkTurnFL2BR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSLockWalkTurnFL2BR", Classes.FObjectProperty);
		BSLockWalkTurnFR2FL_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSLockWalkTurnFR2FL");
		BSLockWalkTurnFR2FL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSLockWalkTurnFR2FL", Classes.FObjectProperty);
		BSLockWalkTurnFL2FR_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSLockWalkTurnFL2FR");
		BSLockWalkTurnFL2FR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSLockWalkTurnFL2FR", Classes.FObjectProperty);
		BSLockWalkTurnBL2FL_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSLockWalkTurnBL2FL");
		BSLockWalkTurnBL2FL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSLockWalkTurnBL2FL", Classes.FObjectProperty);
		BSLockWalkTurnFL2BL_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSLockWalkTurnFL2BL");
		BSLockWalkTurnFL2BL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSLockWalkTurnFL2BL", Classes.FObjectProperty);
		BSLockWalkTurnBR2FR_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSLockWalkTurnBR2FR");
		BSLockWalkTurnBR2FR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSLockWalkTurnBR2FR", Classes.FObjectProperty);
		BSLockWalkTurnFR2BR_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSLockWalkTurnFR2BR");
		BSLockWalkTurnFR2BR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSLockWalkTurnFR2BR", Classes.FObjectProperty);
		BSLockRunTurnFR2BL_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSLockRunTurnFR2BL");
		BSLockRunTurnFR2BL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSLockRunTurnFR2BL", Classes.FObjectProperty);
		BSLockRunTurnBR2FL_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSLockRunTurnBR2FL");
		BSLockRunTurnBR2FL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSLockRunTurnBR2FL", Classes.FObjectProperty);
		BSLockRunTurnBL2FR_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSLockRunTurnBL2FR");
		BSLockRunTurnBL2FR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSLockRunTurnBL2FR", Classes.FObjectProperty);
		BSLockRunTurnFL2BR_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSLockRunTurnFL2BR");
		BSLockRunTurnFL2BR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSLockRunTurnFL2BR", Classes.FObjectProperty);
		BSLockRunTurnFR2FL_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSLockRunTurnFR2FL");
		BSLockRunTurnFR2FL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSLockRunTurnFR2FL", Classes.FObjectProperty);
		BSLockRunTurnFL2FR_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSLockRunTurnFL2FR");
		BSLockRunTurnFL2FR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSLockRunTurnFL2FR", Classes.FObjectProperty);
		BSLockRunTurnBL2FL_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSLockRunTurnBL2FL");
		BSLockRunTurnBL2FL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSLockRunTurnBL2FL", Classes.FObjectProperty);
		BSLockRunTurnFL2BL_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSLockRunTurnFL2BL");
		BSLockRunTurnFL2BL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSLockRunTurnFL2BL", Classes.FObjectProperty);
		BSLockRunTurnBR2FR_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSLockRunTurnBR2FR");
		BSLockRunTurnBR2FR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSLockRunTurnBR2FR", Classes.FObjectProperty);
		BSLockRunTurnFR2BR_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSLockRunTurnFR2BR");
		BSLockRunTurnFR2BR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSLockRunTurnFR2BR", Classes.FObjectProperty);
		BSLockTurnStopFL_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSLockTurnStopFL");
		BSLockTurnStopFL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSLockTurnStopFL", Classes.FObjectProperty);
		BSLockTurnStopFR_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSLockTurnStopFR");
		BSLockTurnStopFR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSLockTurnStopFR", Classes.FObjectProperty);
		BSLockTurnStopBL_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSLockTurnStopBL");
		BSLockTurnStopBL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSLockTurnStopBL", Classes.FObjectProperty);
		BSLockTurnStopBR_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSLockTurnStopBR");
		BSLockTurnStopBR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSLockTurnStopBR", Classes.FObjectProperty);
		LockTurnStopAlphaFR_Offset = NativeReflection.GetPropertyOffset(intPtr, "LockTurnStopAlphaFR");
		LockTurnStopAlphaFR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LockTurnStopAlphaFR", Classes.FFloatProperty);
		LockTurnStopAlphaBR_Offset = NativeReflection.GetPropertyOffset(intPtr, "LockTurnStopAlphaBR");
		LockTurnStopAlphaBR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LockTurnStopAlphaBR", Classes.FFloatProperty);
		LockTurnStopAlphaBL_Offset = NativeReflection.GetPropertyOffset(intPtr, "LockTurnStopAlphaBL");
		LockTurnStopAlphaBL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LockTurnStopAlphaBL", Classes.FFloatProperty);
		LockTurnStopAlphaFL_Offset = NativeReflection.GetPropertyOffset(intPtr, "LockTurnStopAlphaFL");
		LockTurnStopAlphaFL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LockTurnStopAlphaFL", Classes.FFloatProperty);
		ASLockWalkStopFwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockWalkStopFwd");
		ASLockWalkStopFwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockWalkStopFwd", Classes.FObjectProperty);
		ASLockWalkStopBwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockWalkStopBwd");
		ASLockWalkStopBwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockWalkStopBwd", Classes.FObjectProperty);
		ASLockWalkStopLeftF_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockWalkStopLeftF");
		ASLockWalkStopLeftF_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockWalkStopLeftF", Classes.FObjectProperty);
		ASLockWalkStopLeftB_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockWalkStopLeftB");
		ASLockWalkStopLeftB_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockWalkStopLeftB", Classes.FObjectProperty);
		ASLockWalkStopRightF_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockWalkStopRightF");
		ASLockWalkStopRightF_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockWalkStopRightF", Classes.FObjectProperty);
		ASLockWalkStopRightB_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockWalkStopRightB");
		ASLockWalkStopRightB_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockWalkStopRightB", Classes.FObjectProperty);
		ASLockWalkStopFL45_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockWalkStopFL45");
		ASLockWalkStopFL45_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockWalkStopFL45", Classes.FObjectProperty);
		ASLockWalkStopFR45_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockWalkStopFR45");
		ASLockWalkStopFR45_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockWalkStopFR45", Classes.FObjectProperty);
		ASLockWalkStopBL45_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockWalkStopBL45");
		ASLockWalkStopBL45_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockWalkStopBL45", Classes.FObjectProperty);
		ASLockWalkStopBR45_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockWalkStopBR45");
		ASLockWalkStopBR45_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockWalkStopBR45", Classes.FObjectProperty);
		ASLockRunStopFwdL_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockRunStopFwdL");
		ASLockRunStopFwdL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockRunStopFwdL", Classes.FObjectProperty);
		ASLockRunStopFwdR_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockRunStopFwdR");
		ASLockRunStopFwdR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockRunStopFwdR", Classes.FObjectProperty);
		ASLockRunStopBwdL_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockRunStopBwdL");
		ASLockRunStopBwdL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockRunStopBwdL", Classes.FObjectProperty);
		ASLockRunStopBwdR_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockRunStopBwdR");
		ASLockRunStopBwdR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockRunStopBwdR", Classes.FObjectProperty);
		ASLockRunStopLeftF_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockRunStopLeftF");
		ASLockRunStopLeftF_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockRunStopLeftF", Classes.FObjectProperty);
		ASLockRunStopLeftB_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockRunStopLeftB");
		ASLockRunStopLeftB_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockRunStopLeftB", Classes.FObjectProperty);
		ASLockRunStopRightF_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockRunStopRightF");
		ASLockRunStopRightF_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockRunStopRightF", Classes.FObjectProperty);
		ASLockRunStopRightB_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockRunStopRightB");
		ASLockRunStopRightB_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockRunStopRightB", Classes.FObjectProperty);
		AnimIdle_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimIdle");
		AnimIdle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimIdle", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref MoveSpeedLevel_PropertyAddress, intPtr, "MoveSpeedLevel");
		MoveSpeedLevel_Offset = NativeReflection.GetPropertyOffset(intPtr, "MoveSpeedLevel");
		MoveSpeedLevel_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MoveSpeedLevel", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref MoveSpeedState_PropertyAddress, intPtr, "MoveSpeedState");
		MoveSpeedState_Offset = NativeReflection.GetPropertyOffset(intPtr, "MoveSpeedState");
		MoveSpeedState_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MoveSpeedState", Classes.FEnumProperty);
		InputBlendAlpha_Offset = NativeReflection.GetPropertyOffset(intPtr, "InputBlendAlpha");
		InputBlendAlpha_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InputBlendAlpha", Classes.FStructProperty);
		VelocityBlendAlpha_Offset = NativeReflection.GetPropertyOffset(intPtr, "VelocityBlendAlpha");
		VelocityBlendAlpha_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "VelocityBlendAlpha", Classes.FStructProperty);
		VelocityBlendAlphaStop_Offset = NativeReflection.GetPropertyOffset(intPtr, "VelocityBlendAlphaStop");
		VelocityBlendAlphaStop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "VelocityBlendAlphaStop", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref bLandingMove_PropertyAddress, intPtr, "bLandingMove");
		bLandingMove_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLandingMove");
		bLandingMove_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLandingMove", Classes.FBoolProperty);
		LastFallingVelocity_Offset = NativeReflection.GetPropertyOffset(intPtr, "LastFallingVelocity");
		LastFallingVelocity_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LastFallingVelocity", Classes.FStructProperty);
		RandomIdleIndex_Offset = NativeReflection.GetPropertyOffset(intPtr, "RandomIdleIndex");
		RandomIdleIndex_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RandomIdleIndex", Classes.FIntProperty);
		MoveLoopSpeedState_Offset = NativeReflection.GetPropertyOffset(intPtr, "MoveLoopSpeedState");
		MoveLoopSpeedState_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MoveLoopSpeedState", Classes.FFloatProperty);
		MaxSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "MaxSpeed");
		MaxSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MaxSpeed", Classes.FFloatProperty);
		CurveMoveSpeedScale_Offset = NativeReflection.GetPropertyOffset(intPtr, "CurveMoveSpeedScale");
		CurveMoveSpeedScale_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CurveMoveSpeedScale", Classes.FFloatProperty);
		TargetLockMoveDeltaAngle_Offset = NativeReflection.GetPropertyOffset(intPtr, "TargetLockMoveDeltaAngle");
		TargetLockMoveDeltaAngle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TargetLockMoveDeltaAngle", Classes.FFloatProperty);
		InputDeltaAngle_Offset = NativeReflection.GetPropertyOffset(intPtr, "InputDeltaAngle");
		InputDeltaAngle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InputDeltaAngle", Classes.FFloatProperty);
		InputDeltaAngleBackward_Offset = NativeReflection.GetPropertyOffset(intPtr, "InputDeltaAngleBackward");
		InputDeltaAngleBackward_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InputDeltaAngleBackward", Classes.FFloatProperty);
		StrideWarpingSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "StrideWarpingSpeed");
		StrideWarpingSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StrideWarpingSpeed", Classes.FFloatProperty);
		StrideWarpingAlpha_Offset = NativeReflection.GetPropertyOffset(intPtr, "StrideWarpingAlpha");
		StrideWarpingAlpha_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StrideWarpingAlpha", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bSwitchToLock_PropertyAddress, intPtr, "bSwitchToLock");
		bSwitchToLock_Offset = NativeReflection.GetPropertyOffset(intPtr, "bSwitchToLock");
		bSwitchToLock_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bSwitchToLock", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockMoveF_PropertyAddress, intPtr, "bLockMoveF");
		bLockMoveF_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLockMoveF");
		bLockMoveF_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLockMoveF", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockMoveB_PropertyAddress, intPtr, "bLockMoveB");
		bLockMoveB_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLockMoveB");
		bLockMoveB_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLockMoveB", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockMoveL_PropertyAddress, intPtr, "bLockMoveL");
		bLockMoveL_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLockMoveL");
		bLockMoveL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLockMoveL", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockMoveR_PropertyAddress, intPtr, "bLockMoveR");
		bLockMoveR_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLockMoveR");
		bLockMoveR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLockMoveR", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bFreeTurn_PropertyAddress, intPtr, "bFreeTurn");
		bFreeTurn_Offset = NativeReflection.GetPropertyOffset(intPtr, "bFreeTurn");
		bFreeTurn_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bFreeTurn", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bWalkFreeBwdL_PropertyAddress, intPtr, "bWalkFreeBwdL");
		bWalkFreeBwdL_Offset = NativeReflection.GetPropertyOffset(intPtr, "bWalkFreeBwdL");
		bWalkFreeBwdL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bWalkFreeBwdL", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bWalkFreeLeft_PropertyAddress, intPtr, "bWalkFreeLeft");
		bWalkFreeLeft_Offset = NativeReflection.GetPropertyOffset(intPtr, "bWalkFreeLeft");
		bWalkFreeLeft_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bWalkFreeLeft", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bWalkFreeRight_PropertyAddress, intPtr, "bWalkFreeRight");
		bWalkFreeRight_Offset = NativeReflection.GetPropertyOffset(intPtr, "bWalkFreeRight");
		bWalkFreeRight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bWalkFreeRight", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bWalkFreeBwdR_PropertyAddress, intPtr, "bWalkFreeBwdR");
		bWalkFreeBwdR_Offset = NativeReflection.GetPropertyOffset(intPtr, "bWalkFreeBwdR");
		bWalkFreeBwdR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bWalkFreeBwdR", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bRunFreeBwdL_PropertyAddress, intPtr, "bRunFreeBwdL");
		bRunFreeBwdL_Offset = NativeReflection.GetPropertyOffset(intPtr, "bRunFreeBwdL");
		bRunFreeBwdL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bRunFreeBwdL", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bRunFreeTurnLeft_PropertyAddress, intPtr, "bRunFreeTurnLeft");
		bRunFreeTurnLeft_Offset = NativeReflection.GetPropertyOffset(intPtr, "bRunFreeTurnLeft");
		bRunFreeTurnLeft_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bRunFreeTurnLeft", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bRunFreeTurnRight_PropertyAddress, intPtr, "bRunFreeTurnRight");
		bRunFreeTurnRight_Offset = NativeReflection.GetPropertyOffset(intPtr, "bRunFreeTurnRight");
		bRunFreeTurnRight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bRunFreeTurnRight", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bRunFreeStartLeft_PropertyAddress, intPtr, "bRunFreeStartLeft");
		bRunFreeStartLeft_Offset = NativeReflection.GetPropertyOffset(intPtr, "bRunFreeStartLeft");
		bRunFreeStartLeft_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bRunFreeStartLeft", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bRunFreeStartRight_PropertyAddress, intPtr, "bRunFreeStartRight");
		bRunFreeStartRight_Offset = NativeReflection.GetPropertyOffset(intPtr, "bRunFreeStartRight");
		bRunFreeStartRight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bRunFreeStartRight", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bRunFreeBwdR_PropertyAddress, intPtr, "bRunFreeBwdR");
		bRunFreeBwdR_Offset = NativeReflection.GetPropertyOffset(intPtr, "bRunFreeBwdR");
		bRunFreeBwdR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bRunFreeBwdR", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bRunFreeTurnFwdL_PropertyAddress, intPtr, "bRunFreeTurnFwdL");
		bRunFreeTurnFwdL_Offset = NativeReflection.GetPropertyOffset(intPtr, "bRunFreeTurnFwdL");
		bRunFreeTurnFwdL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bRunFreeTurnFwdL", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bRunFreeTurnLandFwdL_PropertyAddress, intPtr, "bRunFreeTurnLandFwdL");
		bRunFreeTurnLandFwdL_Offset = NativeReflection.GetPropertyOffset(intPtr, "bRunFreeTurnLandFwdL");
		bRunFreeTurnLandFwdL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bRunFreeTurnLandFwdL", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bRunFreeTurnLandFwdR_PropertyAddress, intPtr, "bRunFreeTurnLandFwdR");
		bRunFreeTurnLandFwdR_Offset = NativeReflection.GetPropertyOffset(intPtr, "bRunFreeTurnLandFwdR");
		bRunFreeTurnLandFwdR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bRunFreeTurnLandFwdR", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bRushFreeBwdL_PropertyAddress, intPtr, "bRushFreeBwdL");
		bRushFreeBwdL_Offset = NativeReflection.GetPropertyOffset(intPtr, "bRushFreeBwdL");
		bRushFreeBwdL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bRushFreeBwdL", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bRushFreeLeft_PropertyAddress, intPtr, "bRushFreeLeft");
		bRushFreeLeft_Offset = NativeReflection.GetPropertyOffset(intPtr, "bRushFreeLeft");
		bRushFreeLeft_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bRushFreeLeft", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bRushFreeRight_PropertyAddress, intPtr, "bRushFreeRight");
		bRushFreeRight_Offset = NativeReflection.GetPropertyOffset(intPtr, "bRushFreeRight");
		bRushFreeRight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bRushFreeRight", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bRushFreeBwdR_PropertyAddress, intPtr, "bRushFreeBwdR");
		bRushFreeBwdR_Offset = NativeReflection.GetPropertyOffset(intPtr, "bRushFreeBwdR");
		bRushFreeBwdR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bRushFreeBwdR", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLastRush_PropertyAddress, intPtr, "bLastRush");
		bLastRush_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLastRush");
		bLastRush_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLastRush", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLastRun_PropertyAddress, intPtr, "bLastRun");
		bLastRun_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLastRun");
		bLastRun_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLastRun", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLeftFootFront_PropertyAddress, intPtr, "bLeftFootFront");
		bLeftFootFront_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLeftFootFront");
		bLeftFootFront_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLeftFootFront", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bRunStop_PropertyAddress, intPtr, "bRunStop");
		bRunStop_Offset = NativeReflection.GetPropertyOffset(intPtr, "bRunStop");
		bRunStop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bRunStop", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bRushStop_PropertyAddress, intPtr, "bRushStop");
		bRushStop_Offset = NativeReflection.GetPropertyOffset(intPtr, "bRushStop");
		bRushStop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bRushStop", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bToStop_PropertyAddress, intPtr, "bToStop");
		bToStop_Offset = NativeReflection.GetPropertyOffset(intPtr, "bToStop");
		bToStop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bToStop", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bToTurnStop_PropertyAddress, intPtr, "bToTurnStop");
		bToTurnStop_Offset = NativeReflection.GetPropertyOffset(intPtr, "bToTurnStop");
		bToTurnStop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bToTurnStop", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bIdleToWalk_PropertyAddress, intPtr, "bIdleToWalk");
		bIdleToWalk_Offset = NativeReflection.GetPropertyOffset(intPtr, "bIdleToWalk");
		bIdleToWalk_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bIdleToWalk", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bRunToWalk_PropertyAddress, intPtr, "bRunToWalk");
		bRunToWalk_Offset = NativeReflection.GetPropertyOffset(intPtr, "bRunToWalk");
		bRunToWalk_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bRunToWalk", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bToRun_PropertyAddress, intPtr, "bToRun");
		bToRun_Offset = NativeReflection.GetPropertyOffset(intPtr, "bToRun");
		bToRun_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bToRun", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bToRush_PropertyAddress, intPtr, "bToRush");
		bToRush_Offset = NativeReflection.GetPropertyOffset(intPtr, "bToRush");
		bToRush_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bToRush", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockMoveFromTurnStopFR_PropertyAddress, intPtr, "bLockMoveFromTurnStopFR");
		bLockMoveFromTurnStopFR_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLockMoveFromTurnStopFR");
		bLockMoveFromTurnStopFR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLockMoveFromTurnStopFR", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockMoveFromTurnStopBR_PropertyAddress, intPtr, "bLockMoveFromTurnStopBR");
		bLockMoveFromTurnStopBR_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLockMoveFromTurnStopBR");
		bLockMoveFromTurnStopBR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLockMoveFromTurnStopBR", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockMoveFromTurnStopBL_PropertyAddress, intPtr, "bLockMoveFromTurnStopBL");
		bLockMoveFromTurnStopBL_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLockMoveFromTurnStopBL");
		bLockMoveFromTurnStopBL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLockMoveFromTurnStopBL", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockMoveFromTurnStopFL_PropertyAddress, intPtr, "bLockMoveFromTurnStopFL");
		bLockMoveFromTurnStopFL_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLockMoveFromTurnStopFL");
		bLockMoveFromTurnStopFL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLockMoveFromTurnStopFL", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockMoveTransFromFwd_PropertyAddress, intPtr, "bLockMoveTransFromFwd");
		bLockMoveTransFromFwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLockMoveTransFromFwd");
		bLockMoveTransFromFwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLockMoveTransFromFwd", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockMoveTransFromBwd_PropertyAddress, intPtr, "bLockMoveTransFromBwd");
		bLockMoveTransFromBwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLockMoveTransFromBwd");
		bLockMoveTransFromBwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLockMoveTransFromBwd", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockMoveTransFromFL_PropertyAddress, intPtr, "bLockMoveTransFromFL");
		bLockMoveTransFromFL_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLockMoveTransFromFL");
		bLockMoveTransFromFL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLockMoveTransFromFL", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockMoveTransFromFR_PropertyAddress, intPtr, "bLockMoveTransFromFR");
		bLockMoveTransFromFR_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLockMoveTransFromFR");
		bLockMoveTransFromFR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLockMoveTransFromFR", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockMoveTransFromBL_PropertyAddress, intPtr, "bLockMoveTransFromBL");
		bLockMoveTransFromBL_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLockMoveTransFromBL");
		bLockMoveTransFromBL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLockMoveTransFromBL", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockMoveTransFromBR_PropertyAddress, intPtr, "bLockMoveTransFromBR");
		bLockMoveTransFromBR_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLockMoveTransFromBR");
		bLockMoveTransFromBR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLockMoveTransFromBR", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockMoveFromTurnStop_PropertyAddress, intPtr, "bLockMoveFromTurnStop");
		bLockMoveFromTurnStop_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLockMoveFromTurnStop");
		bLockMoveFromTurnStop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLockMoveFromTurnStop", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bInLockMoveState_PropertyAddress, intPtr, "bInLockMoveState");
		bInLockMoveState_Offset = NativeReflection.GetPropertyOffset(intPtr, "bInLockMoveState");
		bInLockMoveState_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bInLockMoveState", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockMoveTurnStart_PropertyAddress, intPtr, "bLockMoveTurnStart");
		bLockMoveTurnStart_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLockMoveTurnStart");
		bLockMoveTurnStart_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLockMoveTurnStart", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockMoveToFwdLoop_PropertyAddress, intPtr, "bLockMoveToFwdLoop");
		bLockMoveToFwdLoop_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLockMoveToFwdLoop");
		bLockMoveToFwdLoop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLockMoveToFwdLoop", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockMoveToBwdLoop_PropertyAddress, intPtr, "bLockMoveToBwdLoop");
		bLockMoveToBwdLoop_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLockMoveToBwdLoop");
		bLockMoveToBwdLoop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLockMoveToBwdLoop", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockMoveToFLLoop_PropertyAddress, intPtr, "bLockMoveToFLLoop");
		bLockMoveToFLLoop_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLockMoveToFLLoop");
		bLockMoveToFLLoop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLockMoveToFLLoop", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockMoveToBLLoop_PropertyAddress, intPtr, "bLockMoveToBLLoop");
		bLockMoveToBLLoop_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLockMoveToBLLoop");
		bLockMoveToBLLoop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLockMoveToBLLoop", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockMoveToFRLoop_PropertyAddress, intPtr, "bLockMoveToFRLoop");
		bLockMoveToFRLoop_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLockMoveToFRLoop");
		bLockMoveToFRLoop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLockMoveToFRLoop", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockMoveToBRLoop_PropertyAddress, intPtr, "bLockMoveToBRLoop");
		bLockMoveToBRLoop_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLockMoveToBRLoop");
		bLockMoveToBRLoop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLockMoveToBRLoop", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockMoveStartFwd_PropertyAddress, intPtr, "bLockMoveStartFwd");
		bLockMoveStartFwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLockMoveStartFwd");
		bLockMoveStartFwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLockMoveStartFwd", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockMoveStartBwd_PropertyAddress, intPtr, "bLockMoveStartBwd");
		bLockMoveStartBwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLockMoveStartBwd");
		bLockMoveStartBwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLockMoveStartBwd", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockMoveStartFL_PropertyAddress, intPtr, "bLockMoveStartFL");
		bLockMoveStartFL_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLockMoveStartFL");
		bLockMoveStartFL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLockMoveStartFL", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockMoveStartFR_PropertyAddress, intPtr, "bLockMoveStartFR");
		bLockMoveStartFR_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLockMoveStartFR");
		bLockMoveStartFR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLockMoveStartFR", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockMoveStartBL_PropertyAddress, intPtr, "bLockMoveStartBL");
		bLockMoveStartBL_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLockMoveStartBL");
		bLockMoveStartBL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLockMoveStartBL", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockMoveStartBR_PropertyAddress, intPtr, "bLockMoveStartBR");
		bLockMoveStartBR_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLockMoveStartBR");
		bLockMoveStartBR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLockMoveStartBR", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockMoveFRToFwd_PropertyAddress, intPtr, "bLockMoveFRToFwd");
		bLockMoveFRToFwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLockMoveFRToFwd");
		bLockMoveFRToFwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLockMoveFRToFwd", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockMoveFRToFL_PropertyAddress, intPtr, "bLockMoveFRToFL");
		bLockMoveFRToFL_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLockMoveFRToFL");
		bLockMoveFRToFL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLockMoveFRToFL", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockMoveBRToBwd_PropertyAddress, intPtr, "bLockMoveBRToBwd");
		bLockMoveBRToBwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLockMoveBRToBwd");
		bLockMoveBRToBwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLockMoveBRToBwd", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockMoveBLToBwd_PropertyAddress, intPtr, "bLockMoveBLToBwd");
		bLockMoveBLToBwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLockMoveBLToBwd");
		bLockMoveBLToBwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLockMoveBLToBwd", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockMoveFLToFwd_PropertyAddress, intPtr, "bLockMoveFLToFwd");
		bLockMoveFLToFwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLockMoveFLToFwd");
		bLockMoveFLToFwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLockMoveFLToFwd", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockMoveFLToFR_PropertyAddress, intPtr, "bLockMoveFLToFR");
		bLockMoveFLToFR_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLockMoveFLToFR");
		bLockMoveFLToFR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLockMoveFLToFR", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockMoveToTurnStopFR_PropertyAddress, intPtr, "bLockMoveToTurnStopFR");
		bLockMoveToTurnStopFR_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLockMoveToTurnStopFR");
		bLockMoveToTurnStopFR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLockMoveToTurnStopFR", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockMoveToTurnStopBR_PropertyAddress, intPtr, "bLockMoveToTurnStopBR");
		bLockMoveToTurnStopBR_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLockMoveToTurnStopBR");
		bLockMoveToTurnStopBR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLockMoveToTurnStopBR", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockMoveToTurnStopBL_PropertyAddress, intPtr, "bLockMoveToTurnStopBL");
		bLockMoveToTurnStopBL_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLockMoveToTurnStopBL");
		bLockMoveToTurnStopBL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLockMoveToTurnStopBL", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockMoveToTurnStopFL_PropertyAddress, intPtr, "bLockMoveToTurnStopFL");
		bLockMoveToTurnStopFL_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLockMoveToTurnStopFL");
		bLockMoveToTurnStopFL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLockMoveToTurnStopFL", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockWalk_PropertyAddress, intPtr, "bLockWalk");
		bLockWalk_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLockWalk");
		bLockWalk_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLockWalk", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockRun_PropertyAddress, intPtr, "bLockRun");
		bLockRun_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLockRun");
		bLockRun_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLockRun", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockStopFwd_PropertyAddress, intPtr, "bLockStopFwd");
		bLockStopFwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLockStopFwd");
		bLockStopFwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLockStopFwd", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockStopBwd_PropertyAddress, intPtr, "bLockStopBwd");
		bLockStopBwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLockStopBwd");
		bLockStopBwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLockStopBwd", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockStopLeft_PropertyAddress, intPtr, "bLockStopLeft");
		bLockStopLeft_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLockStopLeft");
		bLockStopLeft_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLockStopLeft", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockStopRight_PropertyAddress, intPtr, "bLockStopRight");
		bLockStopRight_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLockStopRight");
		bLockStopRight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLockStopRight", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockStopFL_PropertyAddress, intPtr, "bLockStopFL");
		bLockStopFL_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLockStopFL");
		bLockStopFL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLockStopFL", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockStopFR_PropertyAddress, intPtr, "bLockStopFR");
		bLockStopFR_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLockStopFR");
		bLockStopFR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLockStopFR", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockStopBL_PropertyAddress, intPtr, "bLockStopBL");
		bLockStopBL_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLockStopBL");
		bLockStopBL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLockStopBL", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockStopBR_PropertyAddress, intPtr, "bLockStopBR");
		bLockStopBR_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLockStopBR");
		bLockStopBR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLockStopBR", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bInSequenceTransition_PropertyAddress, intPtr, "bInSequenceTransition");
		bInSequenceTransition_Offset = NativeReflection.GetPropertyOffset(intPtr, "bInSequenceTransition");
		bInSequenceTransition_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bInSequenceTransition", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bToSequenceTransitionMove_PropertyAddress, intPtr, "bToSequenceTransitionMove");
		bToSequenceTransitionMove_Offset = NativeReflection.GetPropertyOffset(intPtr, "bToSequenceTransitionMove");
		bToSequenceTransitionMove_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bToSequenceTransitionMove", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bSequenceTransitionFromWalk_PropertyAddress, intPtr, "bSequenceTransitionFromWalk");
		bSequenceTransitionFromWalk_Offset = NativeReflection.GetPropertyOffset(intPtr, "bSequenceTransitionFromWalk");
		bSequenceTransitionFromWalk_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bSequenceTransitionFromWalk", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bSequenceTransitionFromRun_PropertyAddress, intPtr, "bSequenceTransitionFromRun");
		bSequenceTransitionFromRun_Offset = NativeReflection.GetPropertyOffset(intPtr, "bSequenceTransitionFromRun");
		bSequenceTransitionFromRun_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bSequenceTransitionFromRun", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bSequenceTransitionFromRush_PropertyAddress, intPtr, "bSequenceTransitionFromRush");
		bSequenceTransitionFromRush_Offset = NativeReflection.GetPropertyOffset(intPtr, "bSequenceTransitionFromRush");
		bSequenceTransitionFromRush_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bSequenceTransitionFromRush", Classes.FBoolProperty);
		OnLeftSeqMove_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnLeftSeqMove");
		OnLeftSeqMove_ParamsSize = NativeReflection.GetFunctionParamsSize(OnLeftSeqMove_FunctionAddress);
		OnLeftSeqMove_IsValid = OnLeftSeqMove_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:OnLeftSeqMove", OnLeftSeqMove_IsValid);
		OnEnterSeqMove_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnEnterSeqMove");
		OnEnterSeqMove_ParamsSize = NativeReflection.GetFunctionParamsSize(OnEnterSeqMove_FunctionAddress);
		OnEnterSeqMove_IsValid = OnEnterSeqMove_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:OnEnterSeqMove", OnEnterSeqMove_IsValid);
		SetUpRushStopAnim_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetUpRushStopAnim");
		SetUpRushStopAnim_ParamsSize = NativeReflection.GetFunctionParamsSize(SetUpRushStopAnim_FunctionAddress);
		NativeReflection.GetPropertyRef(ref SetUpRushStopAnim_Context_PropertyAddress, SetUpRushStopAnim_FunctionAddress, "Context");
		SetUpRushStopAnim_Context_Offset = NativeReflection.GetPropertyOffset(SetUpRushStopAnim_FunctionAddress, "Context");
		SetUpRushStopAnim_Context_IsValid = NativeReflection.ValidatePropertyClass(SetUpRushStopAnim_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref SetUpRushStopAnim_Node_PropertyAddress, SetUpRushStopAnim_FunctionAddress, "Node");
		SetUpRushStopAnim_Node_Offset = NativeReflection.GetPropertyOffset(SetUpRushStopAnim_FunctionAddress, "Node");
		SetUpRushStopAnim_Node_IsValid = NativeReflection.ValidatePropertyClass(SetUpRushStopAnim_FunctionAddress, "Node", Classes.FStructProperty);
		SetUpRushStopAnim_IsValid = SetUpRushStopAnim_FunctionAddress != IntPtr.Zero && SetUpRushStopAnim_Context_IsValid && SetUpRushStopAnim_Node_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:SetUpRushStopAnim", SetUpRushStopAnim_IsValid);
		GetRandomIdleAnim_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetRandomIdleAnim");
		GetRandomIdleAnim_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRandomIdleAnim_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetRandomIdleAnim_Context_PropertyAddress, GetRandomIdleAnim_FunctionAddress, "Context");
		GetRandomIdleAnim_Context_Offset = NativeReflection.GetPropertyOffset(GetRandomIdleAnim_FunctionAddress, "Context");
		GetRandomIdleAnim_Context_IsValid = NativeReflection.ValidatePropertyClass(GetRandomIdleAnim_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref GetRandomIdleAnim_Node_PropertyAddress, GetRandomIdleAnim_FunctionAddress, "Node");
		GetRandomIdleAnim_Node_Offset = NativeReflection.GetPropertyOffset(GetRandomIdleAnim_FunctionAddress, "Node");
		GetRandomIdleAnim_Node_IsValid = NativeReflection.ValidatePropertyClass(GetRandomIdleAnim_FunctionAddress, "Node", Classes.FStructProperty);
		GetRandomIdleAnim_IsValid = GetRandomIdleAnim_FunctionAddress != IntPtr.Zero && GetRandomIdleAnim_Context_IsValid && GetRandomIdleAnim_Node_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:GetRandomIdleAnim", GetRandomIdleAnim_IsValid);
		SetupSequenceTransitionAnim_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetupSequenceTransitionAnim");
		SetupSequenceTransitionAnim_ParamsSize = NativeReflection.GetFunctionParamsSize(SetupSequenceTransitionAnim_FunctionAddress);
		NativeReflection.GetPropertyRef(ref SetupSequenceTransitionAnim_Context_PropertyAddress, SetupSequenceTransitionAnim_FunctionAddress, "Context");
		SetupSequenceTransitionAnim_Context_Offset = NativeReflection.GetPropertyOffset(SetupSequenceTransitionAnim_FunctionAddress, "Context");
		SetupSequenceTransitionAnim_Context_IsValid = NativeReflection.ValidatePropertyClass(SetupSequenceTransitionAnim_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref SetupSequenceTransitionAnim_Node_PropertyAddress, SetupSequenceTransitionAnim_FunctionAddress, "Node");
		SetupSequenceTransitionAnim_Node_Offset = NativeReflection.GetPropertyOffset(SetupSequenceTransitionAnim_FunctionAddress, "Node");
		SetupSequenceTransitionAnim_Node_IsValid = NativeReflection.ValidatePropertyClass(SetupSequenceTransitionAnim_FunctionAddress, "Node", Classes.FStructProperty);
		SetupSequenceTransitionAnim_IsValid = SetupSequenceTransitionAnim_FunctionAddress != IntPtr.Zero && SetupSequenceTransitionAnim_Context_IsValid && SetupSequenceTransitionAnim_Node_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_PlayerLocomotion:SetupSequenceTransitionAnim", SetupSequenceTransitionAnim_IsValid);
	}

	static BUAnimHumanoidCS_PlayerLocomotion()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUAnimHumanoidCS_PlayerLocomotion)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUAnimHumanoidCS_PlayerLocomotion));
	}
}
