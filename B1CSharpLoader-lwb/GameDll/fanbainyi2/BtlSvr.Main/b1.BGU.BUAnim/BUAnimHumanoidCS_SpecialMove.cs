using System;
using System.Collections.Generic;
using UnrealEngine.AnimGraphRuntime;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGU.BUAnim;

[Blueprintable]
[UClass]
[Abstract]
[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove")]
public class BUAnimHumanoidCS_SpecialMove : BUAnimHumanoidCS_LinkedInstanceBase
{
	private IBUC_ABPCommonSettingData CommonData;

	private IBUC_ABPJumpV2Data JumpV2Data;

	private b1.IBUC_ABPGlideMoveData GlideMoveData;

	private IBUC_ABPBasicData BasicData;

	private IBUC_ABPCharacterData ChrData;

	private IBUC_ABPSpecialMoveData SpecialMoveData;

	private IBUC_ABPParkourMoveData ParkourMoveData;

	private IBUC_ABPSplineMoveData SplineMoveData;

	private IBUC_ABPPlayerLocomotionData PlayerLocomotionData;

	private IBUC_ABPMonsterLocomotionData MonsterLocomotionData;

	private IBUC_ABPAdvancedMonsterLocomotionData AdvancedMonsterLocomotionData;

	private IBUC_ABPCloudLocomotionData CloudMoveData;

	private bool bEnableGlideAnim;

	private bool bEnableParkourAnim;

	private ELockMoveDirectionSix JumpMoveDir;

	private readonly FVector2D LandPredictionTraceOffsetInput = new FVector2D(0.0, -4000.0);

	private readonly FVector2D LandPredictionTraceOffsetOutput = new FVector2D(100.0, 3000.0);

	private readonly FVector2D LandAdditiveAlphaInput = new FVector2D(-50.0, -1200.0);

	private readonly FVector2D CommonAlphaOutput = new FVector2D(0.0, 1.0);

	private static bool bHasMoveInput_IsValid;

	private static int bHasMoveInput_Offset;

	private static FFieldAddress bHasMoveInput_PropertyAddress;

	private static bool bHasPlayerInput_IsValid;

	private static int bHasPlayerInput_Offset;

	private static FFieldAddress bHasPlayerInput_PropertyAddress;

	private static bool Speed_IsValid;

	private static int Speed_Offset;

	private static bool MappedSpeed_IsValid;

	private static int MappedSpeed_Offset;

	private static bool SpecialMovementMode_IsValid;

	private static int SpecialMovementMode_Offset;

	private static FFieldAddress SpecialMovementMode_PropertyAddress;

	private static bool LastSpecialMovementMode_IsValid;

	private static int LastSpecialMovementMode_Offset;

	private static FFieldAddress LastSpecialMovementMode_PropertyAddress;

	private static bool bGroundMoving_IsValid;

	private static int bGroundMoving_Offset;

	private static FFieldAddress bGroundMoving_PropertyAddress;

	private static bool MaxAnimWeightLockMoveDir_IsValid;

	private static int MaxAnimWeightLockMoveDir_Offset;

	private static FFieldAddress MaxAnimWeightLockMoveDir_PropertyAddress;

	private static bool ASGlideStartGroundFlatSlow_IsValid;

	private static int ASGlideStartGroundFlatSlow_Offset;

	private static bool ASGlideStartGroundFlatFast_IsValid;

	private static int ASGlideStartGroundFlatFast_Offset;

	private static bool ASGlideStartGroundSteepSlow_IsValid;

	private static int ASGlideStartGroundSteepSlow_Offset;

	private static bool ASGlideStartGroundSteepFast_IsValid;

	private static int ASGlideStartGroundSteepFast_Offset;

	private static bool ASGlideStartAirFlatSlow_IsValid;

	private static int ASGlideStartAirFlatSlow_Offset;

	private static bool ASGlideStartAirFlatFast_IsValid;

	private static int ASGlideStartAirFlatFast_Offset;

	private static bool ASGlideStartAirSteepSlow_IsValid;

	private static int ASGlideStartAirSteepSlow_Offset;

	private static bool ASGlideStartAirSteepFast_IsValid;

	private static int ASGlideStartAirSteepFast_Offset;

	private static bool ASGlideStartBackAirFlat_IsValid;

	private static int ASGlideStartBackAirFlat_Offset;

	private static bool ASGlideStartBackAirSteep_IsValid;

	private static int ASGlideStartBackAirSteep_Offset;

	private static bool GlideStartSpeedBlendAlpha_IsValid;

	private static int GlideStartSpeedBlendAlpha_Offset;

	private static bool ASGlideLoopSteep_IsValid;

	private static int ASGlideLoopSteep_Offset;

	private static bool BSGlideLoopSteepAdditive_IsValid;

	private static int BSGlideLoopSteepAdditive_Offset;

	private static bool ASGlideLoopFlatSlow_IsValid;

	private static int ASGlideLoopFlatSlow_Offset;

	private static bool ASGlideLoopFlatFast_IsValid;

	private static int ASGlideLoopFlatFast_Offset;

	private static bool BSGlideLoopFlatSlowDirAdditive_IsValid;

	private static int BSGlideLoopFlatSlowDirAdditive_Offset;

	private static bool BSGlideLoopFlatFastDirAdditive_IsValid;

	private static int BSGlideLoopFlatFastDirAdditive_Offset;

	private static bool GlideLoopDirAdditiveX_IsValid;

	private static int GlideLoopDirAdditiveX_Offset;

	private static bool GlideLoopDirAdditiveY_IsValid;

	private static int GlideLoopDirAdditiveY_Offset;

	private static bool BSGlideLoopFlatVerticalInputAdditive_IsValid;

	private static int BSGlideLoopFlatVerticalInputAdditive_Offset;

	private static bool BSGlideLoopFlatVerticalInputAdditiveY_IsValid;

	private static int BSGlideLoopFlatVerticalInputAdditiveY_Offset;

	private static bool GlideLoopSpeedBlendAlpha_IsValid;

	private static int GlideLoopSpeedBlendAlpha_Offset;

	private static bool BSGlideLoopFlatHorizonalInputAdditive_IsValid;

	private static int BSGlideLoopFlatHorizonalInputAdditive_Offset;

	private static bool BSGlideLoopFlatHorizonalInputAdditiveX_IsValid;

	private static int BSGlideLoopFlatHorizonalInputAdditiveX_Offset;

	private static bool ASGlideLoopFlatRotationLeftAdditive_IsValid;

	private static int ASGlideLoopFlatRotationLeftAdditive_Offset;

	private static bool ASGlideLoopFlatRotationRightAdditive_IsValid;

	private static int ASGlideLoopFlatRotationRightAdditive_Offset;

	private static bool ASGlideEndSlow_IsValid;

	private static int ASGlideEndSlow_Offset;

	private static bool ASGlideEndFast_IsValid;

	private static int ASGlideEndFast_Offset;

	private static bool bGlideMoving_IsValid;

	private static int bGlideMoving_Offset;

	private static FFieldAddress bGlideMoving_PropertyAddress;

	private static bool bParkourMoving_IsValid;

	private static int bParkourMoving_Offset;

	private static FFieldAddress bParkourMoving_PropertyAddress;

	private static bool ASParkourLowClimbStart_IsValid;

	private static int ASParkourLowClimbStart_Offset;

	private static bool ASParkourLowClimbGetUp_IsValid;

	private static int ASParkourLowClimbGetUp_Offset;

	private static bool ASParkourLowClimbFallLoop_IsValid;

	private static int ASParkourLowClimbFallLoop_Offset;

	private static bool ASParkourLowClimbLand_IsValid;

	private static int ASParkourLowClimbLand_Offset;

	private static bool ASParkourLowClimbLandMove_IsValid;

	private static int ASParkourLowClimbLandMove_Offset;

	private static bool ASParkourNormalClimbStart_IsValid;

	private static int ASParkourNormalClimbStart_Offset;

	private static bool ASParkourNormalClimbGetUp_IsValid;

	private static int ASParkourNormalClimbGetUp_Offset;

	private static bool ASParkourNormalClimbFallLoop_IsValid;

	private static int ASParkourNormalClimbFallLoop_Offset;

	private static bool ASParkourNormalClimbLand_IsValid;

	private static int ASParkourNormalClimbLand_Offset;

	private static bool ASParkourNormalClimbLandMove_IsValid;

	private static int ASParkourNormalClimbLandMove_Offset;

	private static bool ASParkourHighClimbStart_IsValid;

	private static int ASParkourHighClimbStart_Offset;

	private static bool ASParkourHighClimbGetUp_IsValid;

	private static int ASParkourHighClimbGetUp_Offset;

	private static bool ASParkourHighClimbFallLoop_IsValid;

	private static int ASParkourHighClimbFallLoop_Offset;

	private static bool ASParkourHighClimbLand_IsValid;

	private static int ASParkourHighClimbLand_Offset;

	private static bool ASParkourHighClimbLandMove_IsValid;

	private static int ASParkourHighClimbLandMove_Offset;

	private static bool ASParkourLowAcrossStart_IsValid;

	private static int ASParkourLowAcrossStart_Offset;

	private static bool ASParkourLowAcrossThrough_IsValid;

	private static int ASParkourLowAcrossThrough_Offset;

	private static bool ASParkourLowAcrossFallLoop_IsValid;

	private static int ASParkourLowAcrossFallLoop_Offset;

	private static bool ASParkourLowAcrossLand_IsValid;

	private static int ASParkourLowAcrossLand_Offset;

	private static bool ASParkourLowAcrossLandMove_IsValid;

	private static int ASParkourLowAcrossLandMove_Offset;

	private static bool ASParkourNormalAcrossStart_IsValid;

	private static int ASParkourNormalAcrossStart_Offset;

	private static bool ASParkourNormalAcrossThrough_IsValid;

	private static int ASParkourNormalAcrossThrough_Offset;

	private static bool ASParkourNormalAcrossFallLoop_IsValid;

	private static int ASParkourNormalAcrossFallLoop_Offset;

	private static bool ASParkourNormalAcrossLand_IsValid;

	private static int ASParkourNormalAcrossLand_Offset;

	private static bool ASParkourNormalAcrossLandMove_IsValid;

	private static int ASParkourNormalAcrossLandMove_Offset;

	private static bool ASParkourHighAcrossStart_IsValid;

	private static int ASParkourHighAcrossStart_Offset;

	private static bool ASParkourHighAcrossThrough_IsValid;

	private static int ASParkourHighAcrossThrough_Offset;

	private static bool ASParkourHighAcrossFallLoop_IsValid;

	private static int ASParkourHighAcrossFallLoop_Offset;

	private static bool ASParkourHighAcrossLand_IsValid;

	private static int ASParkourHighAcrossLand_Offset;

	private static bool ASParkourHighAcrossLandMove_IsValid;

	private static int ASParkourHighAcrossLandMove_Offset;

	private static bool ASStrideUpLeftFootLow_IsValid;

	private static int ASStrideUpLeftFootLow_Offset;

	private static bool ASStrideUpRightFootLow_IsValid;

	private static int ASStrideUpRightFootLow_Offset;

	private static bool ASStrideUpLeftFootHigh_IsValid;

	private static int ASStrideUpLeftFootHigh_Offset;

	private static bool ASStrideUpRightFootHigh_IsValid;

	private static int ASStrideUpRightFootHigh_Offset;

	private static bool ASStrideUpLeftFootFall_IsValid;

	private static int ASStrideUpLeftFootFall_Offset;

	private static bool ASStrideUpRightFootFall_IsValid;

	private static int ASStrideUpRightFootFall_Offset;

	private static bool ASStrideUpLeftFootEnd_IsValid;

	private static int ASStrideUpLeftFootEnd_Offset;

	private static bool ASStrideUpRightFootEnd_IsValid;

	private static int ASStrideUpRightFootEnd_Offset;

	private static bool ASStrideUpLeftFootLandMove_IsValid;

	private static int ASStrideUpLeftFootLandMove_Offset;

	private static bool ASStrideUpRightFootLandMove_IsValid;

	private static int ASStrideUpRightFootLandMove_Offset;

	private static bool ASStrideDownLeftFoot_IsValid;

	private static int ASStrideDownLeftFoot_Offset;

	private static bool ASStrideDownRightFoot_IsValid;

	private static int ASStrideDownRightFoot_Offset;

	private static bool ASStrideDownLeftFootFall_IsValid;

	private static int ASStrideDownLeftFootFall_Offset;

	private static bool ASStrideDownRightFootFall_IsValid;

	private static int ASStrideDownRightFootFall_Offset;

	private static bool ASStrideDownLeftFootEnd_IsValid;

	private static int ASStrideDownLeftFootEnd_Offset;

	private static bool ASStrideDownRightFootEnd_IsValid;

	private static int ASStrideDownRightFootEnd_Offset;

	private static bool ASStrideDownLeftFootLandMove_IsValid;

	private static int ASStrideDownLeftFootLandMove_Offset;

	private static bool ASStrideDownRightFootLandMove_IsValid;

	private static int ASStrideDownRightFootLandMove_Offset;

	private static bool bIsInAir_IsValid;

	private static int bIsInAir_Offset;

	private static FFieldAddress bIsInAir_PropertyAddress;

	private static bool bAirMoving_IsValid;

	private static int bAirMoving_Offset;

	private static FFieldAddress bAirMoving_PropertyAddress;

	private static bool StartJumpDir_IsValid;

	private static int StartJumpDir_Offset;

	private static FFieldAddress StartJumpDir_PropertyAddress;

	private static bool bIsJumpStartFast_IsValid;

	private static int bIsJumpStartFast_Offset;

	private static FFieldAddress bIsJumpStartFast_PropertyAddress;

	private static bool bInJump_IsValid;

	private static int bInJump_Offset;

	private static FFieldAddress bInJump_PropertyAddress;

	private static bool bIsLittleFall_IsValid;

	private static int bIsLittleFall_Offset;

	private static FFieldAddress bIsLittleFall_PropertyAddress;

	private static bool bHasFallAnimAsset_IsValid;

	private static int bHasFallAnimAsset_Offset;

	private static FFieldAddress bHasFallAnimAsset_PropertyAddress;

	private static bool StartJumpSpdState_IsValid;

	private static int StartJumpSpdState_Offset;

	private static FFieldAddress StartJumpSpdState_PropertyAddress;

	private static bool BSJumpStart_F_IsValid;

	private static int BSJumpStart_F_Offset;

	private static bool BSJumpStart_B_IsValid;

	private static int BSJumpStart_B_Offset;

	private static bool BSJumpLoop_F_IsValid;

	private static int BSJumpLoop_F_Offset;

	private static bool BSJumpLoop_B_IsValid;

	private static int BSJumpLoop_B_Offset;

	private static bool BSJumpAdditiveLean_IsValid;

	private static int BSJumpAdditiveLean_Offset;

	private static bool BSJumpAdditiveRot_IsValid;

	private static int BSJumpAdditiveRot_Offset;

	private static bool AnimGroundJumpStart_IsValid;

	private static int AnimGroundJumpStart_Offset;

	private static bool AnimJumpStart_N_IsValid;

	private static int AnimJumpStart_N_Offset;

	private static bool AnimJumpStart_F_IsValid;

	private static int AnimJumpStart_F_Offset;

	private static bool AnimJumpStart_L_IsValid;

	private static int AnimJumpStart_L_Offset;

	private static bool AnimJumpStart_R_IsValid;

	private static int AnimJumpStart_R_Offset;

	private static bool AnimJumpStart_B_IsValid;

	private static int AnimJumpStart_B_Offset;

	private static bool AnimGlideJumpStart_IsValid;

	private static int AnimGlideJumpStart_Offset;

	private static bool AnimFallStart_IsValid;

	private static int AnimFallStart_Offset;

	private static bool AnimFallStart_N_IsValid;

	private static int AnimFallStart_N_Offset;

	private static bool AnimFallStart_F_IsValid;

	private static int AnimFallStart_F_Offset;

	private static bool AnimFallStart_L_IsValid;

	private static int AnimFallStart_L_Offset;

	private static bool AnimFallStart_R_IsValid;

	private static int AnimFallStart_R_Offset;

	private static bool AnimFallStart_B_IsValid;

	private static int AnimFallStart_B_Offset;

	private static bool AnimFallLoop_IsValid;

	private static int AnimFallLoop_Offset;

	private static bool FallHeightType_IsValid;

	private static int FallHeightType_Offset;

	private static FFieldAddress FallHeightType_PropertyAddress;

	private static bool FallHeight_IsValid;

	private static int FallHeight_Offset;

	private static bool AnimLand_F_Low_IsValid;

	private static int AnimLand_F_Low_Offset;

	private static bool AnimLand_F_Mid_IsValid;

	private static int AnimLand_F_Mid_Offset;

	private static bool AnimLand_F_High_IsValid;

	private static int AnimLand_F_High_Offset;

	private static bool AnimLand_L_IsValid;

	private static int AnimLand_L_Offset;

	private static bool AnimLand_R_IsValid;

	private static int AnimLand_R_Offset;

	private static bool AnimLand_B_IsValid;

	private static int AnimLand_B_Offset;

	private static bool bIsInLandCantMoveTime_IsValid;

	private static int bIsInLandCantMoveTime_Offset;

	private static FFieldAddress bIsInLandCantMoveTime_PropertyAddress;

	private static bool StartMoveAfterJump_IsValid;

	private static int StartMoveAfterJump_Offset;

	private static bool AddtiveMoveAfterJump_F_IsValid;

	private static int AddtiveMoveAfterJump_F_Offset;

	private static bool AddtiveMoveAfterJump_B_IsValid;

	private static int AddtiveMoveAfterJump_B_Offset;

	private static bool AddtiveMoveAfterJump_L_IsValid;

	private static int AddtiveMoveAfterJump_L_Offset;

	private static bool AddtiveMoveAfterJump_R_IsValid;

	private static int AddtiveMoveAfterJump_R_Offset;

	private static bool AdditiveMoveAfterJumpFAlpha_IsValid;

	private static int AdditiveMoveAfterJumpFAlpha_Offset;

	private static bool AdditiveMoveAfterJumpBAlpha_IsValid;

	private static int AdditiveMoveAfterJumpBAlpha_Offset;

	private static bool AdditiveMoveAfterJumpLAlpha_IsValid;

	private static int AdditiveMoveAfterJumpLAlpha_Offset;

	private static bool AdditiveMoveAfterJumpRAlpha_IsValid;

	private static int AdditiveMoveAfterJumpRAlpha_Offset;

	private static bool BSJumpAdditiveLeanX_IsValid;

	private static int BSJumpAdditiveLeanX_Offset;

	private static bool BSJumpAdditiveLeanY_IsValid;

	private static int BSJumpAdditiveLeanY_Offset;

	private static bool LandPredictionAlpha_IsValid;

	private static int LandPredictionAlpha_Offset;

	private static bool BSJumpAdditiveRotX_IsValid;

	private static int BSJumpAdditiveRotX_Offset;

	private static bool BSJumpAdditiveRotY_IsValid;

	private static int BSJumpAdditiveRotY_Offset;

	private static bool LandAdditiveAlpha_IsValid;

	private static int LandAdditiveAlpha_Offset;

	private static bool VelocityDeltaAngle_IsValid;

	private static int VelocityDeltaAngle_Offset;

	private static bool VelocityDeltaAngleTrans_IsValid;

	private static int VelocityDeltaAngleTrans_Offset;

	private static bool bSplineMoving_IsValid;

	private static int bSplineMoving_Offset;

	private static FFieldAddress bSplineMoving_PropertyAddress;

	private static bool bSplineMoveForward_IsValid;

	private static int bSplineMoveForward_Offset;

	private static FFieldAddress bSplineMoveForward_PropertyAddress;

	private static bool bSplineMoveSharpturn_IsValid;

	private static int bSplineMoveSharpturn_Offset;

	private static FFieldAddress bSplineMoveSharpturn_PropertyAddress;

	private static bool bSplineMoveReSharpturn_IsValid;

	private static int bSplineMoveReSharpturn_Offset;

	private static FFieldAddress bSplineMoveReSharpturn_PropertyAddress;

	private static bool bSplineMoveCanExitSharpturn_IsValid;

	private static int bSplineMoveCanExitSharpturn_Offset;

	private static FFieldAddress bSplineMoveCanExitSharpturn_PropertyAddress;

	private static bool bSplineMoveStopToStart_IsValid;

	private static int bSplineMoveStopToStart_Offset;

	private static FFieldAddress bSplineMoveStopToStart_PropertyAddress;

	private static bool bSplineMoveStopToLoop_IsValid;

	private static int bSplineMoveStopToLoop_Offset;

	private static FFieldAddress bSplineMoveStopToLoop_PropertyAddress;

	private static bool SharpturnAngle_IsValid;

	private static int SharpturnAngle_Offset;

	private static bool ASSplineMoveIdleForward_IsValid;

	private static int ASSplineMoveIdleForward_Offset;

	private static bool ASSplineMoveIdleBackward_IsValid;

	private static int ASSplineMoveIdleBackward_Offset;

	private static bool ASSplineMoveStartForward_IsValid;

	private static int ASSplineMoveStartForward_Offset;

	private static bool ASSplineMoveStartBackward_IsValid;

	private static int ASSplineMoveStartBackward_Offset;

	private static bool ASSplineMoveLoopForward_IsValid;

	private static int ASSplineMoveLoopForward_Offset;

	private static bool ASSplineMoveLoopBackward_IsValid;

	private static int ASSplineMoveLoopBackward_Offset;

	private static bool ASSplineMoveStopForward_IsValid;

	private static int ASSplineMoveStopForward_Offset;

	private static bool ASSplineMoveStopBackward_IsValid;

	private static int ASSplineMoveStopBackward_Offset;

	private static bool ASSplineMoveTurnF2B_IsValid;

	private static int ASSplineMoveTurnF2B_Offset;

	private static bool ASSplineMoveTurnB2F_IsValid;

	private static int ASSplineMoveTurnB2F_Offset;

	private static bool AnimCloudFallStart_IsValid;

	private static int AnimCloudFallStart_Offset;

	private static bool AnimCloudFallLoop_IsValid;

	private static int AnimCloudFallLoop_Offset;

	private static bool bGlideEndToGroundMove_IsValid;

	private static int bGlideEndToGroundMove_Offset;

	private static FFieldAddress bGlideEndToGroundMove_PropertyAddress;

	private static bool bAirStartGlide_IsValid;

	private static int bAirStartGlide_Offset;

	private static FFieldAddress bAirStartGlide_PropertyAddress;

	private static bool bGlideFlat_IsValid;

	private static int bGlideFlat_Offset;

	private static FFieldAddress bGlideFlat_PropertyAddress;

	private static bool bGlideSteep_IsValid;

	private static int bGlideSteep_Offset;

	private static FFieldAddress bGlideSteep_PropertyAddress;

	private static bool bGlideStartFront_IsValid;

	private static int bGlideStartFront_Offset;

	private static FFieldAddress bGlideStartFront_PropertyAddress;

	private static bool bGlideStartBack_IsValid;

	private static int bGlideStartBack_Offset;

	private static FFieldAddress bGlideStartBack_PropertyAddress;

	private static bool bGlideLoopRotationLeft_IsValid;

	private static int bGlideLoopRotationLeft_Offset;

	private static FFieldAddress bGlideLoopRotationLeft_PropertyAddress;

	private static bool bGlideLoopRotationRight_IsValid;

	private static int bGlideLoopRotationRight_Offset;

	private static FFieldAddress bGlideLoopRotationRight_PropertyAddress;

	private static bool bGlideEndSlow_IsValid;

	private static int bGlideEndSlow_Offset;

	private static FFieldAddress bGlideEndSlow_PropertyAddress;

	private static bool bGlideEndFast_IsValid;

	private static int bGlideEndFast_Offset;

	private static FFieldAddress bGlideEndFast_PropertyAddress;

	private static bool bToFall_IsValid;

	private static int bToFall_Offset;

	private static FFieldAddress bToFall_PropertyAddress;

	private static bool bToGroundJumpStart_IsValid;

	private static int bToGroundJumpStart_Offset;

	private static FFieldAddress bToGroundJumpStart_PropertyAddress;

	private static bool bToGroundJumpStartFwd_IsValid;

	private static int bToGroundJumpStartFwd_Offset;

	private static FFieldAddress bToGroundJumpStartFwd_PropertyAddress;

	private static bool bToGroundJumpStartBwd_IsValid;

	private static int bToGroundJumpStartBwd_Offset;

	private static FFieldAddress bToGroundJumpStartBwd_PropertyAddress;

	private static bool bToGlideJumpStart_IsValid;

	private static int bToGlideJumpStart_Offset;

	private static FFieldAddress bToGlideJumpStart_PropertyAddress;

	private static bool bToLandAdditive_IsValid;

	private static int bToLandAdditive_Offset;

	private static FFieldAddress bToLandAdditive_PropertyAddress;

	private static bool bStride_IsValid;

	private static int bStride_Offset;

	private static FFieldAddress bStride_PropertyAddress;

	private static bool bStrideJump_IsValid;

	private static int bStrideJump_Offset;

	private static FFieldAddress bStrideJump_PropertyAddress;

	private static bool bStrideUpJump_IsValid;

	private static int bStrideUpJump_Offset;

	private static FFieldAddress bStrideUpJump_PropertyAddress;

	private static bool bStrideDownJump_IsValid;

	private static int bStrideDownJump_Offset;

	private static FFieldAddress bStrideDownJump_PropertyAddress;

	private static bool bStrideUp_IsValid;

	private static int bStrideUp_Offset;

	private static FFieldAddress bStrideUp_PropertyAddress;

	private static bool bStrideDown_IsValid;

	private static int bStrideDown_Offset;

	private static FFieldAddress bStrideDown_PropertyAddress;

	private static bool bStrideUpLand_IsValid;

	private static int bStrideUpLand_Offset;

	private static FFieldAddress bStrideUpLand_PropertyAddress;

	private static bool bStrideDownLand_IsValid;

	private static int bStrideDownLand_Offset;

	private static FFieldAddress bStrideDownLand_PropertyAddress;

	private static bool bStrideUpHigh_IsValid;

	private static int bStrideUpHigh_Offset;

	private static FFieldAddress bStrideUpHigh_PropertyAddress;

	private static bool bStrideUpLow_IsValid;

	private static int bStrideUpLow_Offset;

	private static FFieldAddress bStrideUpLow_PropertyAddress;

	private static bool bCloudFall_IsValid;

	private static int bCloudFall_Offset;

	private static FFieldAddress bCloudFall_PropertyAddress;

	private static bool bLeaveGlideMoving_IsValid;

	private static int bLeaveGlideMoving_Offset;

	private static FFieldAddress bLeaveGlideMoving_PropertyAddress;

	private static bool bParkourClimb_IsValid;

	private static int bParkourClimb_Offset;

	private static FFieldAddress bParkourClimb_PropertyAddress;

	private static bool bParkourAcross_IsValid;

	private static int bParkourAcross_Offset;

	private static FFieldAddress bParkourAcross_PropertyAddress;

	private static bool bParkourLow_IsValid;

	private static int bParkourLow_Offset;

	private static FFieldAddress bParkourLow_PropertyAddress;

	private static bool bParkourNormal_IsValid;

	private static int bParkourNormal_Offset;

	private static FFieldAddress bParkourNormal_PropertyAddress;

	private static bool bParkourHigh_IsValid;

	private static int bParkourHigh_Offset;

	private static FFieldAddress bParkourHigh_PropertyAddress;

	private static bool bParkourFall_IsValid;

	private static int bParkourFall_Offset;

	private static FFieldAddress bParkourFall_PropertyAddress;

	private static bool bLandAnimToGround_IsValid;

	private static int bLandAnimToGround_Offset;

	private static FFieldAddress bLandAnimToGround_PropertyAddress;

	private static bool bLockMoveJumpF_IsValid;

	private static int bLockMoveJumpF_Offset;

	private static FFieldAddress bLockMoveJumpF_PropertyAddress;

	private static bool bLockMoveJumpFL_IsValid;

	private static int bLockMoveJumpFL_Offset;

	private static FFieldAddress bLockMoveJumpFL_PropertyAddress;

	private static bool bLockMoveJumpFR_IsValid;

	private static int bLockMoveJumpFR_Offset;

	private static FFieldAddress bLockMoveJumpFR_PropertyAddress;

	private static bool bLockMoveJumpBL_IsValid;

	private static int bLockMoveJumpBL_Offset;

	private static FFieldAddress bLockMoveJumpBL_PropertyAddress;

	private static bool bLockMoveJumpBR_IsValid;

	private static int bLockMoveJumpBR_Offset;

	private static FFieldAddress bLockMoveJumpBR_PropertyAddress;

	private static bool bLockMoveJumpB_IsValid;

	private static int bLockMoveJumpB_Offset;

	private static FFieldAddress bLockMoveJumpB_PropertyAddress;

	private static bool bToStride_IsValid;

	private static int bToStride_Offset;

	private static FFieldAddress bToStride_PropertyAddress;

	private static bool bStrideContinue_IsValid;

	private static int bStrideContinue_Offset;

	private static FFieldAddress bStrideContinue_PropertyAddress;

	private static bool bLeftFootFront_IsValid;

	private static int bLeftFootFront_Offset;

	private static FFieldAddress bLeftFootFront_PropertyAddress;

	private static bool bToLandAnim_IsValid;

	private static int bToLandAnim_Offset;

	private static FFieldAddress bToLandAnim_PropertyAddress;

	private static bool bToLandMove_IsValid;

	private static int bToLandMove_Offset;

	private static FFieldAddress bToLandMove_PropertyAddress;

	private static bool bSwitchToLock_IsValid;

	private static int bSwitchToLock_Offset;

	private static FFieldAddress bSwitchToLock_PropertyAddress;

	private static bool SetupLandAnim_IsValid;

	private static IntPtr SetupLandAnim_FunctionAddress;

	private static int SetupLandAnim_ParamsSize;

	private static bool SetupLandAnim_Context_IsValid;

	private static int SetupLandAnim_Context_Offset;

	private static FFieldAddress SetupLandAnim_Context_PropertyAddress;

	private static bool SetupLandAnim_Node_IsValid;

	private static int SetupLandAnim_Node_Offset;

	private static FFieldAddress SetupLandAnim_Node_PropertyAddress;

	private static bool GetAnimCloudLand_IsValid;

	private static IntPtr GetAnimCloudLand_FunctionAddress;

	private static int GetAnimCloudLand_ParamsSize;

	private static bool GetAnimCloudLand_AnimCloudLand_IsValid;

	private static int GetAnimCloudLand_AnimCloudLand_Offset;

	private static bool UpdateGroundJump_IsValid;

	private static IntPtr UpdateGroundJump_FunctionAddress;

	private static int UpdateGroundJump_ParamsSize;

	private static bool UpdateGroundJump_Context_IsValid;

	private static int UpdateGroundJump_Context_Offset;

	private static FFieldAddress UpdateGroundJump_Context_PropertyAddress;

	private static bool UpdateGroundJump_Node_IsValid;

	private static int UpdateGroundJump_Node_Offset;

	private static FFieldAddress UpdateGroundJump_Node_PropertyAddress;

	private static bool UpdateGroundAdditive_IsValid;

	private static IntPtr UpdateGroundAdditive_FunctionAddress;

	private static int UpdateGroundAdditive_ParamsSize;

	private static bool UpdateGroundAdditive_Context_IsValid;

	private static int UpdateGroundAdditive_Context_Offset;

	private static FFieldAddress UpdateGroundAdditive_Context_PropertyAddress;

	private static bool UpdateGroundAdditive_Node_IsValid;

	private static int UpdateGroundAdditive_Node_Offset;

	private static FFieldAddress UpdateGroundAdditive_Node_PropertyAddress;

	[UProperty]
	[BlueprintReadOnly]
	[Category("Basic")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bHasMoveInput")]
	public bool bHasMoveInput
	{
		get
		{
			CheckDestroyed();
			if (!bHasMoveInput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bHasMoveInput");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bHasMoveInput_Offset), 0, bHasMoveInput_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bHasMoveInput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bHasMoveInput");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bHasMoveInput_Offset), 0, bHasMoveInput_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Basic")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bHasPlayerInput")]
	public bool bHasPlayerInput
	{
		get
		{
			CheckDestroyed();
			if (!bHasPlayerInput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bHasPlayerInput");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bHasPlayerInput_Offset), 0, bHasPlayerInput_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bHasPlayerInput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bHasPlayerInput");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bHasPlayerInput_Offset), 0, bHasPlayerInput_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Basic")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:Speed")]
	public float Speed
	{
		get
		{
			CheckDestroyed();
			if (!Speed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:Speed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Speed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Speed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:Speed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Speed_Offset), value);
			}
		}
	}

	[Category("Basic")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:MappedSpeed")]
	public float MappedSpeed
	{
		get
		{
			CheckDestroyed();
			if (!MappedSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:MappedSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MappedSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MappedSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:MappedSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MappedSpeed_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("Special Move")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:SpecialMovementMode")]
	public ESpecialMovementMode SpecialMovementMode
	{
		get
		{
			CheckDestroyed();
			if (!SpecialMovementMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:SpecialMovementMode");
				return ESpecialMovementMode.GroundMove;
			}
			return EnumMarshaler<ESpecialMovementMode>.FromNative(IntPtr.Add(base.Address, SpecialMovementMode_Offset), 0, SpecialMovementMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SpecialMovementMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:SpecialMovementMode");
			}
			else
			{
				EnumMarshaler<ESpecialMovementMode>.ToNative(IntPtr.Add(base.Address, SpecialMovementMode_Offset), 0, SpecialMovementMode_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Special Move")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:LastSpecialMovementMode")]
	public ESpecialMovementMode LastSpecialMovementMode
	{
		get
		{
			CheckDestroyed();
			if (!LastSpecialMovementMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:LastSpecialMovementMode");
				return ESpecialMovementMode.GroundMove;
			}
			return EnumMarshaler<ESpecialMovementMode>.FromNative(IntPtr.Add(base.Address, LastSpecialMovementMode_Offset), 0, LastSpecialMovementMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!LastSpecialMovementMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:LastSpecialMovementMode");
			}
			else
			{
				EnumMarshaler<ESpecialMovementMode>.ToNative(IntPtr.Add(base.Address, LastSpecialMovementMode_Offset), 0, LastSpecialMovementMode_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("Ground Move")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bGroundMoving")]
	public bool bGroundMoving
	{
		get
		{
			CheckDestroyed();
			if (!bGroundMoving_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bGroundMoving");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bGroundMoving_Offset), 0, bGroundMoving_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bGroundMoving_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bGroundMoving");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bGroundMoving_Offset), 0, bGroundMoving_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Ground Move")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:MaxAnimWeightLockMoveDir")]
	public ELockMoveDirectionSix MaxAnimWeightLockMoveDir
	{
		get
		{
			CheckDestroyed();
			if (!MaxAnimWeightLockMoveDir_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:MaxAnimWeightLockMoveDir");
				return ELockMoveDirectionSix.None;
			}
			return EnumMarshaler<ELockMoveDirectionSix>.FromNative(IntPtr.Add(base.Address, MaxAnimWeightLockMoveDir_Offset), 0, MaxAnimWeightLockMoveDir_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MaxAnimWeightLockMoveDir_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:MaxAnimWeightLockMoveDir");
			}
			else
			{
				EnumMarshaler<ELockMoveDirectionSix>.ToNative(IntPtr.Add(base.Address, MaxAnimWeightLockMoveDir_Offset), 0, MaxAnimWeightLockMoveDir_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Glide | Start")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASGlideStartGroundFlatSlow")]
	public UAnimSequence ASGlideStartGroundFlatSlow
	{
		get
		{
			CheckDestroyed();
			if (!ASGlideStartGroundFlatSlow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASGlideStartGroundFlatSlow");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASGlideStartGroundFlatSlow_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASGlideStartGroundFlatSlow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASGlideStartGroundFlatSlow");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASGlideStartGroundFlatSlow_Offset), value);
			}
		}
	}

	[Category("Glide | Start")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASGlideStartGroundFlatFast")]
	public UAnimSequence ASGlideStartGroundFlatFast
	{
		get
		{
			CheckDestroyed();
			if (!ASGlideStartGroundFlatFast_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASGlideStartGroundFlatFast");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASGlideStartGroundFlatFast_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASGlideStartGroundFlatFast_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASGlideStartGroundFlatFast");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASGlideStartGroundFlatFast_Offset), value);
			}
		}
	}

	[Category("Glide | Start")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASGlideStartGroundSteepSlow")]
	public UAnimSequence ASGlideStartGroundSteepSlow
	{
		get
		{
			CheckDestroyed();
			if (!ASGlideStartGroundSteepSlow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASGlideStartGroundSteepSlow");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASGlideStartGroundSteepSlow_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASGlideStartGroundSteepSlow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASGlideStartGroundSteepSlow");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASGlideStartGroundSteepSlow_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Glide | Start")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASGlideStartGroundSteepFast")]
	public UAnimSequence ASGlideStartGroundSteepFast
	{
		get
		{
			CheckDestroyed();
			if (!ASGlideStartGroundSteepFast_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASGlideStartGroundSteepFast");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASGlideStartGroundSteepFast_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASGlideStartGroundSteepFast_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASGlideStartGroundSteepFast");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASGlideStartGroundSteepFast_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Glide | Start")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASGlideStartAirFlatSlow")]
	public UAnimSequence ASGlideStartAirFlatSlow
	{
		get
		{
			CheckDestroyed();
			if (!ASGlideStartAirFlatSlow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASGlideStartAirFlatSlow");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASGlideStartAirFlatSlow_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASGlideStartAirFlatSlow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASGlideStartAirFlatSlow");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASGlideStartAirFlatSlow_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Glide | Start")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASGlideStartAirFlatFast")]
	public UAnimSequence ASGlideStartAirFlatFast
	{
		get
		{
			CheckDestroyed();
			if (!ASGlideStartAirFlatFast_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASGlideStartAirFlatFast");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASGlideStartAirFlatFast_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASGlideStartAirFlatFast_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASGlideStartAirFlatFast");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASGlideStartAirFlatFast_Offset), value);
			}
		}
	}

	[Category("Glide | Start")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASGlideStartAirSteepSlow")]
	public UAnimSequence ASGlideStartAirSteepSlow
	{
		get
		{
			CheckDestroyed();
			if (!ASGlideStartAirSteepSlow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASGlideStartAirSteepSlow");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASGlideStartAirSteepSlow_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASGlideStartAirSteepSlow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASGlideStartAirSteepSlow");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASGlideStartAirSteepSlow_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("Glide | Start")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASGlideStartAirSteepFast")]
	public UAnimSequence ASGlideStartAirSteepFast
	{
		get
		{
			CheckDestroyed();
			if (!ASGlideStartAirSteepFast_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASGlideStartAirSteepFast");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASGlideStartAirSteepFast_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASGlideStartAirSteepFast_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASGlideStartAirSteepFast");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASGlideStartAirSteepFast_Offset), value);
			}
		}
	}

	[Category("Glide | Start")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASGlideStartBackAirFlat")]
	public UAnimSequence ASGlideStartBackAirFlat
	{
		get
		{
			CheckDestroyed();
			if (!ASGlideStartBackAirFlat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASGlideStartBackAirFlat");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASGlideStartBackAirFlat_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASGlideStartBackAirFlat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASGlideStartBackAirFlat");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASGlideStartBackAirFlat_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("Glide | Start")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASGlideStartBackAirSteep")]
	public UAnimSequence ASGlideStartBackAirSteep
	{
		get
		{
			CheckDestroyed();
			if (!ASGlideStartBackAirSteep_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASGlideStartBackAirSteep");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASGlideStartBackAirSteep_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASGlideStartBackAirSteep_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASGlideStartBackAirSteep");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASGlideStartBackAirSteep_Offset), value);
			}
		}
	}

	[Category("Glide | Start")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:GlideStartSpeedBlendAlpha")]
	public float GlideStartSpeedBlendAlpha
	{
		get
		{
			CheckDestroyed();
			if (!GlideStartSpeedBlendAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:GlideStartSpeedBlendAlpha");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, GlideStartSpeedBlendAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GlideStartSpeedBlendAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:GlideStartSpeedBlendAlpha");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, GlideStartSpeedBlendAlpha_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Glide | Loop")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASGlideLoopSteep")]
	public UAnimSequence ASGlideLoopSteep
	{
		get
		{
			CheckDestroyed();
			if (!ASGlideLoopSteep_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASGlideLoopSteep");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASGlideLoopSteep_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASGlideLoopSteep_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASGlideLoopSteep");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASGlideLoopSteep_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("Glide | Loop")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:BSGlideLoopSteepAdditive")]
	public UBlendSpace BSGlideLoopSteepAdditive
	{
		get
		{
			CheckDestroyed();
			if (!BSGlideLoopSteepAdditive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:BSGlideLoopSteepAdditive");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSGlideLoopSteepAdditive_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSGlideLoopSteepAdditive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:BSGlideLoopSteepAdditive");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSGlideLoopSteepAdditive_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Glide | Loop")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASGlideLoopFlatSlow")]
	public UAnimSequence ASGlideLoopFlatSlow
	{
		get
		{
			CheckDestroyed();
			if (!ASGlideLoopFlatSlow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASGlideLoopFlatSlow");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASGlideLoopFlatSlow_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASGlideLoopFlatSlow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASGlideLoopFlatSlow");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASGlideLoopFlatSlow_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Glide | Loop")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASGlideLoopFlatFast")]
	public UAnimSequence ASGlideLoopFlatFast
	{
		get
		{
			CheckDestroyed();
			if (!ASGlideLoopFlatFast_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASGlideLoopFlatFast");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASGlideLoopFlatFast_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASGlideLoopFlatFast_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASGlideLoopFlatFast");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASGlideLoopFlatFast_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Glide | Loop")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:BSGlideLoopFlatSlowDirAdditive")]
	public UBlendSpace BSGlideLoopFlatSlowDirAdditive
	{
		get
		{
			CheckDestroyed();
			if (!BSGlideLoopFlatSlowDirAdditive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:BSGlideLoopFlatSlowDirAdditive");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSGlideLoopFlatSlowDirAdditive_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSGlideLoopFlatSlowDirAdditive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:BSGlideLoopFlatSlowDirAdditive");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSGlideLoopFlatSlowDirAdditive_Offset), value);
			}
		}
	}

	[Category("Glide | Loop")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:BSGlideLoopFlatFastDirAdditive")]
	public UBlendSpace BSGlideLoopFlatFastDirAdditive
	{
		get
		{
			CheckDestroyed();
			if (!BSGlideLoopFlatFastDirAdditive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:BSGlideLoopFlatFastDirAdditive");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSGlideLoopFlatFastDirAdditive_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSGlideLoopFlatFastDirAdditive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:BSGlideLoopFlatFastDirAdditive");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSGlideLoopFlatFastDirAdditive_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("Glide | Loop")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:GlideLoopDirAdditiveX")]
	public float GlideLoopDirAdditiveX
	{
		get
		{
			CheckDestroyed();
			if (!GlideLoopDirAdditiveX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:GlideLoopDirAdditiveX");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, GlideLoopDirAdditiveX_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GlideLoopDirAdditiveX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:GlideLoopDirAdditiveX");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, GlideLoopDirAdditiveX_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Glide | Loop")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:GlideLoopDirAdditiveY")]
	public float GlideLoopDirAdditiveY
	{
		get
		{
			CheckDestroyed();
			if (!GlideLoopDirAdditiveY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:GlideLoopDirAdditiveY");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, GlideLoopDirAdditiveY_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GlideLoopDirAdditiveY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:GlideLoopDirAdditiveY");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, GlideLoopDirAdditiveY_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Glide | Loop")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:BSGlideLoopFlatVerticalInputAdditive")]
	public UBlendSpace BSGlideLoopFlatVerticalInputAdditive
	{
		get
		{
			CheckDestroyed();
			if (!BSGlideLoopFlatVerticalInputAdditive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:BSGlideLoopFlatVerticalInputAdditive");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSGlideLoopFlatVerticalInputAdditive_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSGlideLoopFlatVerticalInputAdditive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:BSGlideLoopFlatVerticalInputAdditive");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSGlideLoopFlatVerticalInputAdditive_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("Glide | Loop")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:BSGlideLoopFlatVerticalInputAdditiveY")]
	public float BSGlideLoopFlatVerticalInputAdditiveY
	{
		get
		{
			CheckDestroyed();
			if (!BSGlideLoopFlatVerticalInputAdditiveY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:BSGlideLoopFlatVerticalInputAdditiveY");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BSGlideLoopFlatVerticalInputAdditiveY_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSGlideLoopFlatVerticalInputAdditiveY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:BSGlideLoopFlatVerticalInputAdditiveY");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BSGlideLoopFlatVerticalInputAdditiveY_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Glide | Loop")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:GlideLoopSpeedBlendAlpha")]
	public float GlideLoopSpeedBlendAlpha
	{
		get
		{
			CheckDestroyed();
			if (!GlideLoopSpeedBlendAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:GlideLoopSpeedBlendAlpha");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, GlideLoopSpeedBlendAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GlideLoopSpeedBlendAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:GlideLoopSpeedBlendAlpha");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, GlideLoopSpeedBlendAlpha_Offset), value);
			}
		}
	}

	[Category("Glide | Loop")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:BSGlideLoopFlatHorizonalInputAdditive")]
	public UBlendSpace BSGlideLoopFlatHorizonalInputAdditive
	{
		get
		{
			CheckDestroyed();
			if (!BSGlideLoopFlatHorizonalInputAdditive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:BSGlideLoopFlatHorizonalInputAdditive");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSGlideLoopFlatHorizonalInputAdditive_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSGlideLoopFlatHorizonalInputAdditive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:BSGlideLoopFlatHorizonalInputAdditive");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSGlideLoopFlatHorizonalInputAdditive_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Glide | Loop")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:BSGlideLoopFlatHorizonalInputAdditiveX")]
	public float BSGlideLoopFlatHorizonalInputAdditiveX
	{
		get
		{
			CheckDestroyed();
			if (!BSGlideLoopFlatHorizonalInputAdditiveX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:BSGlideLoopFlatHorizonalInputAdditiveX");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BSGlideLoopFlatHorizonalInputAdditiveX_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSGlideLoopFlatHorizonalInputAdditiveX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:BSGlideLoopFlatHorizonalInputAdditiveX");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BSGlideLoopFlatHorizonalInputAdditiveX_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("Glide | Loop")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASGlideLoopFlatRotationLeftAdditive")]
	public UAnimSequence ASGlideLoopFlatRotationLeftAdditive
	{
		get
		{
			CheckDestroyed();
			if (!ASGlideLoopFlatRotationLeftAdditive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASGlideLoopFlatRotationLeftAdditive");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASGlideLoopFlatRotationLeftAdditive_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASGlideLoopFlatRotationLeftAdditive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASGlideLoopFlatRotationLeftAdditive");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASGlideLoopFlatRotationLeftAdditive_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Glide | Loop")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASGlideLoopFlatRotationRightAdditive")]
	public UAnimSequence ASGlideLoopFlatRotationRightAdditive
	{
		get
		{
			CheckDestroyed();
			if (!ASGlideLoopFlatRotationRightAdditive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASGlideLoopFlatRotationRightAdditive");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASGlideLoopFlatRotationRightAdditive_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASGlideLoopFlatRotationRightAdditive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASGlideLoopFlatRotationRightAdditive");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASGlideLoopFlatRotationRightAdditive_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Glide | End")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASGlideEndSlow")]
	public UAnimSequence ASGlideEndSlow
	{
		get
		{
			CheckDestroyed();
			if (!ASGlideEndSlow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASGlideEndSlow");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASGlideEndSlow_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASGlideEndSlow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASGlideEndSlow");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASGlideEndSlow_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Glide | End")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASGlideEndFast")]
	public UAnimSequence ASGlideEndFast
	{
		get
		{
			CheckDestroyed();
			if (!ASGlideEndFast_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASGlideEndFast");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASGlideEndFast_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASGlideEndFast_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASGlideEndFast");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASGlideEndFast_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Glide")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bGlideMoving")]
	public bool bGlideMoving
	{
		get
		{
			CheckDestroyed();
			if (!bGlideMoving_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bGlideMoving");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bGlideMoving_Offset), 0, bGlideMoving_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bGlideMoving_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bGlideMoving");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bGlideMoving_Offset), 0, bGlideMoving_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Parkour")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bParkourMoving")]
	public bool bParkourMoving
	{
		get
		{
			CheckDestroyed();
			if (!bParkourMoving_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bParkourMoving");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bParkourMoving_Offset), 0, bParkourMoving_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bParkourMoving_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bParkourMoving");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bParkourMoving_Offset), 0, bParkourMoving_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Parkour")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourLowClimbStart")]
	public UAnimSequence ASParkourLowClimbStart
	{
		get
		{
			CheckDestroyed();
			if (!ASParkourLowClimbStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourLowClimbStart");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASParkourLowClimbStart_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASParkourLowClimbStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourLowClimbStart");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASParkourLowClimbStart_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("Parkour")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourLowClimbGetUp")]
	public UAnimSequence ASParkourLowClimbGetUp
	{
		get
		{
			CheckDestroyed();
			if (!ASParkourLowClimbGetUp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourLowClimbGetUp");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASParkourLowClimbGetUp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASParkourLowClimbGetUp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourLowClimbGetUp");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASParkourLowClimbGetUp_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Parkour")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourLowClimbFallLoop")]
	public UAnimSequence ASParkourLowClimbFallLoop
	{
		get
		{
			CheckDestroyed();
			if (!ASParkourLowClimbFallLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourLowClimbFallLoop");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASParkourLowClimbFallLoop_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASParkourLowClimbFallLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourLowClimbFallLoop");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASParkourLowClimbFallLoop_Offset), value);
			}
		}
	}

	[Category("Parkour")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourLowClimbLand")]
	public UAnimSequence ASParkourLowClimbLand
	{
		get
		{
			CheckDestroyed();
			if (!ASParkourLowClimbLand_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourLowClimbLand");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASParkourLowClimbLand_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASParkourLowClimbLand_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourLowClimbLand");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASParkourLowClimbLand_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("Parkour")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourLowClimbLandMove")]
	public UAnimSequence ASParkourLowClimbLandMove
	{
		get
		{
			CheckDestroyed();
			if (!ASParkourLowClimbLandMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourLowClimbLandMove");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASParkourLowClimbLandMove_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASParkourLowClimbLandMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourLowClimbLandMove");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASParkourLowClimbLandMove_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Parkour")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourNormalClimbStart")]
	public UAnimSequence ASParkourNormalClimbStart
	{
		get
		{
			CheckDestroyed();
			if (!ASParkourNormalClimbStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourNormalClimbStart");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASParkourNormalClimbStart_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASParkourNormalClimbStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourNormalClimbStart");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASParkourNormalClimbStart_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Parkour")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourNormalClimbGetUp")]
	public UAnimSequence ASParkourNormalClimbGetUp
	{
		get
		{
			CheckDestroyed();
			if (!ASParkourNormalClimbGetUp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourNormalClimbGetUp");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASParkourNormalClimbGetUp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASParkourNormalClimbGetUp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourNormalClimbGetUp");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASParkourNormalClimbGetUp_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("Parkour")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourNormalClimbFallLoop")]
	public UAnimSequence ASParkourNormalClimbFallLoop
	{
		get
		{
			CheckDestroyed();
			if (!ASParkourNormalClimbFallLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourNormalClimbFallLoop");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASParkourNormalClimbFallLoop_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASParkourNormalClimbFallLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourNormalClimbFallLoop");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASParkourNormalClimbFallLoop_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("Parkour")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourNormalClimbLand")]
	public UAnimSequence ASParkourNormalClimbLand
	{
		get
		{
			CheckDestroyed();
			if (!ASParkourNormalClimbLand_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourNormalClimbLand");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASParkourNormalClimbLand_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASParkourNormalClimbLand_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourNormalClimbLand");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASParkourNormalClimbLand_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("Parkour")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourNormalClimbLandMove")]
	public UAnimSequence ASParkourNormalClimbLandMove
	{
		get
		{
			CheckDestroyed();
			if (!ASParkourNormalClimbLandMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourNormalClimbLandMove");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASParkourNormalClimbLandMove_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASParkourNormalClimbLandMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourNormalClimbLandMove");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASParkourNormalClimbLandMove_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("Parkour")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourHighClimbStart")]
	public UAnimSequence ASParkourHighClimbStart
	{
		get
		{
			CheckDestroyed();
			if (!ASParkourHighClimbStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourHighClimbStart");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASParkourHighClimbStart_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASParkourHighClimbStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourHighClimbStart");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASParkourHighClimbStart_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("Parkour")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourHighClimbGetUp")]
	public UAnimSequence ASParkourHighClimbGetUp
	{
		get
		{
			CheckDestroyed();
			if (!ASParkourHighClimbGetUp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourHighClimbGetUp");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASParkourHighClimbGetUp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASParkourHighClimbGetUp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourHighClimbGetUp");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASParkourHighClimbGetUp_Offset), value);
			}
		}
	}

	[Category("Parkour")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourHighClimbFallLoop")]
	public UAnimSequence ASParkourHighClimbFallLoop
	{
		get
		{
			CheckDestroyed();
			if (!ASParkourHighClimbFallLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourHighClimbFallLoop");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASParkourHighClimbFallLoop_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASParkourHighClimbFallLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourHighClimbFallLoop");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASParkourHighClimbFallLoop_Offset), value);
			}
		}
	}

	[Category("Parkour")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourHighClimbLand")]
	public UAnimSequence ASParkourHighClimbLand
	{
		get
		{
			CheckDestroyed();
			if (!ASParkourHighClimbLand_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourHighClimbLand");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASParkourHighClimbLand_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASParkourHighClimbLand_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourHighClimbLand");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASParkourHighClimbLand_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("Parkour")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourHighClimbLandMove")]
	public UAnimSequence ASParkourHighClimbLandMove
	{
		get
		{
			CheckDestroyed();
			if (!ASParkourHighClimbLandMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourHighClimbLandMove");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASParkourHighClimbLandMove_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASParkourHighClimbLandMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourHighClimbLandMove");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASParkourHighClimbLandMove_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("Parkour")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourLowAcrossStart")]
	public UAnimSequence ASParkourLowAcrossStart
	{
		get
		{
			CheckDestroyed();
			if (!ASParkourLowAcrossStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourLowAcrossStart");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASParkourLowAcrossStart_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASParkourLowAcrossStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourLowAcrossStart");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASParkourLowAcrossStart_Offset), value);
			}
		}
	}

	[Category("Parkour")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourLowAcrossThrough")]
	public UAnimSequence ASParkourLowAcrossThrough
	{
		get
		{
			CheckDestroyed();
			if (!ASParkourLowAcrossThrough_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourLowAcrossThrough");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASParkourLowAcrossThrough_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASParkourLowAcrossThrough_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourLowAcrossThrough");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASParkourLowAcrossThrough_Offset), value);
			}
		}
	}

	[Category("Parkour")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourLowAcrossFallLoop")]
	public UAnimSequence ASParkourLowAcrossFallLoop
	{
		get
		{
			CheckDestroyed();
			if (!ASParkourLowAcrossFallLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourLowAcrossFallLoop");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASParkourLowAcrossFallLoop_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASParkourLowAcrossFallLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourLowAcrossFallLoop");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASParkourLowAcrossFallLoop_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("Parkour")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourLowAcrossLand")]
	public UAnimSequence ASParkourLowAcrossLand
	{
		get
		{
			CheckDestroyed();
			if (!ASParkourLowAcrossLand_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourLowAcrossLand");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASParkourLowAcrossLand_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASParkourLowAcrossLand_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourLowAcrossLand");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASParkourLowAcrossLand_Offset), value);
			}
		}
	}

	[Category("Parkour")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourLowAcrossLandMove")]
	public UAnimSequence ASParkourLowAcrossLandMove
	{
		get
		{
			CheckDestroyed();
			if (!ASParkourLowAcrossLandMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourLowAcrossLandMove");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASParkourLowAcrossLandMove_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASParkourLowAcrossLandMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourLowAcrossLandMove");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASParkourLowAcrossLandMove_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("Parkour")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourNormalAcrossStart")]
	public UAnimSequence ASParkourNormalAcrossStart
	{
		get
		{
			CheckDestroyed();
			if (!ASParkourNormalAcrossStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourNormalAcrossStart");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASParkourNormalAcrossStart_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASParkourNormalAcrossStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourNormalAcrossStart");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASParkourNormalAcrossStart_Offset), value);
			}
		}
	}

	[Category("Parkour")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourNormalAcrossThrough")]
	public UAnimSequence ASParkourNormalAcrossThrough
	{
		get
		{
			CheckDestroyed();
			if (!ASParkourNormalAcrossThrough_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourNormalAcrossThrough");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASParkourNormalAcrossThrough_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASParkourNormalAcrossThrough_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourNormalAcrossThrough");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASParkourNormalAcrossThrough_Offset), value);
			}
		}
	}

	[Category("Parkour")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourNormalAcrossFallLoop")]
	public UAnimSequence ASParkourNormalAcrossFallLoop
	{
		get
		{
			CheckDestroyed();
			if (!ASParkourNormalAcrossFallLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourNormalAcrossFallLoop");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASParkourNormalAcrossFallLoop_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASParkourNormalAcrossFallLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourNormalAcrossFallLoop");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASParkourNormalAcrossFallLoop_Offset), value);
			}
		}
	}

	[Category("Parkour")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourNormalAcrossLand")]
	public UAnimSequence ASParkourNormalAcrossLand
	{
		get
		{
			CheckDestroyed();
			if (!ASParkourNormalAcrossLand_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourNormalAcrossLand");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASParkourNormalAcrossLand_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASParkourNormalAcrossLand_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourNormalAcrossLand");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASParkourNormalAcrossLand_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Parkour")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourNormalAcrossLandMove")]
	public UAnimSequence ASParkourNormalAcrossLandMove
	{
		get
		{
			CheckDestroyed();
			if (!ASParkourNormalAcrossLandMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourNormalAcrossLandMove");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASParkourNormalAcrossLandMove_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASParkourNormalAcrossLandMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourNormalAcrossLandMove");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASParkourNormalAcrossLandMove_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Parkour")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourHighAcrossStart")]
	public UAnimSequence ASParkourHighAcrossStart
	{
		get
		{
			CheckDestroyed();
			if (!ASParkourHighAcrossStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourHighAcrossStart");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASParkourHighAcrossStart_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASParkourHighAcrossStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourHighAcrossStart");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASParkourHighAcrossStart_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("Parkour")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourHighAcrossThrough")]
	public UAnimSequence ASParkourHighAcrossThrough
	{
		get
		{
			CheckDestroyed();
			if (!ASParkourHighAcrossThrough_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourHighAcrossThrough");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASParkourHighAcrossThrough_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASParkourHighAcrossThrough_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourHighAcrossThrough");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASParkourHighAcrossThrough_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Parkour")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourHighAcrossFallLoop")]
	public UAnimSequence ASParkourHighAcrossFallLoop
	{
		get
		{
			CheckDestroyed();
			if (!ASParkourHighAcrossFallLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourHighAcrossFallLoop");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASParkourHighAcrossFallLoop_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASParkourHighAcrossFallLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourHighAcrossFallLoop");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASParkourHighAcrossFallLoop_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Parkour")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourHighAcrossLand")]
	public UAnimSequence ASParkourHighAcrossLand
	{
		get
		{
			CheckDestroyed();
			if (!ASParkourHighAcrossLand_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourHighAcrossLand");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASParkourHighAcrossLand_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASParkourHighAcrossLand_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourHighAcrossLand");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASParkourHighAcrossLand_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("Parkour")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourHighAcrossLandMove")]
	public UAnimSequence ASParkourHighAcrossLandMove
	{
		get
		{
			CheckDestroyed();
			if (!ASParkourHighAcrossLandMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourHighAcrossLandMove");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASParkourHighAcrossLandMove_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASParkourHighAcrossLandMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASParkourHighAcrossLandMove");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASParkourHighAcrossLandMove_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("Stride")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASStrideUpLeftFootLow")]
	public UAnimSequence ASStrideUpLeftFootLow
	{
		get
		{
			CheckDestroyed();
			if (!ASStrideUpLeftFootLow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASStrideUpLeftFootLow");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASStrideUpLeftFootLow_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASStrideUpLeftFootLow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASStrideUpLeftFootLow");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASStrideUpLeftFootLow_Offset), value);
			}
		}
	}

	[Category("Stride")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASStrideUpRightFootLow")]
	public UAnimSequence ASStrideUpRightFootLow
	{
		get
		{
			CheckDestroyed();
			if (!ASStrideUpRightFootLow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASStrideUpRightFootLow");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASStrideUpRightFootLow_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASStrideUpRightFootLow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASStrideUpRightFootLow");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASStrideUpRightFootLow_Offset), value);
			}
		}
	}

	[Category("Stride")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASStrideUpLeftFootHigh")]
	public UAnimSequence ASStrideUpLeftFootHigh
	{
		get
		{
			CheckDestroyed();
			if (!ASStrideUpLeftFootHigh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASStrideUpLeftFootHigh");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASStrideUpLeftFootHigh_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASStrideUpLeftFootHigh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASStrideUpLeftFootHigh");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASStrideUpLeftFootHigh_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("Stride")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASStrideUpRightFootHigh")]
	public UAnimSequence ASStrideUpRightFootHigh
	{
		get
		{
			CheckDestroyed();
			if (!ASStrideUpRightFootHigh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASStrideUpRightFootHigh");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASStrideUpRightFootHigh_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASStrideUpRightFootHigh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASStrideUpRightFootHigh");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASStrideUpRightFootHigh_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("Stride")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASStrideUpLeftFootFall")]
	public UAnimSequence ASStrideUpLeftFootFall
	{
		get
		{
			CheckDestroyed();
			if (!ASStrideUpLeftFootFall_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASStrideUpLeftFootFall");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASStrideUpLeftFootFall_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASStrideUpLeftFootFall_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASStrideUpLeftFootFall");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASStrideUpLeftFootFall_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("Stride")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASStrideUpRightFootFall")]
	public UAnimSequence ASStrideUpRightFootFall
	{
		get
		{
			CheckDestroyed();
			if (!ASStrideUpRightFootFall_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASStrideUpRightFootFall");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASStrideUpRightFootFall_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASStrideUpRightFootFall_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASStrideUpRightFootFall");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASStrideUpRightFootFall_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Stride")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASStrideUpLeftFootEnd")]
	public UAnimSequence ASStrideUpLeftFootEnd
	{
		get
		{
			CheckDestroyed();
			if (!ASStrideUpLeftFootEnd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASStrideUpLeftFootEnd");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASStrideUpLeftFootEnd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASStrideUpLeftFootEnd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASStrideUpLeftFootEnd");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASStrideUpLeftFootEnd_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Stride")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASStrideUpRightFootEnd")]
	public UAnimSequence ASStrideUpRightFootEnd
	{
		get
		{
			CheckDestroyed();
			if (!ASStrideUpRightFootEnd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASStrideUpRightFootEnd");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASStrideUpRightFootEnd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASStrideUpRightFootEnd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASStrideUpRightFootEnd");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASStrideUpRightFootEnd_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("Stride")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASStrideUpLeftFootLandMove")]
	public UAnimSequence ASStrideUpLeftFootLandMove
	{
		get
		{
			CheckDestroyed();
			if (!ASStrideUpLeftFootLandMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASStrideUpLeftFootLandMove");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASStrideUpLeftFootLandMove_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASStrideUpLeftFootLandMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASStrideUpLeftFootLandMove");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASStrideUpLeftFootLandMove_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Stride")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASStrideUpRightFootLandMove")]
	public UAnimSequence ASStrideUpRightFootLandMove
	{
		get
		{
			CheckDestroyed();
			if (!ASStrideUpRightFootLandMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASStrideUpRightFootLandMove");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASStrideUpRightFootLandMove_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASStrideUpRightFootLandMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASStrideUpRightFootLandMove");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASStrideUpRightFootLandMove_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("Stride")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASStrideDownLeftFoot")]
	public UAnimSequence ASStrideDownLeftFoot
	{
		get
		{
			CheckDestroyed();
			if (!ASStrideDownLeftFoot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASStrideDownLeftFoot");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASStrideDownLeftFoot_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASStrideDownLeftFoot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASStrideDownLeftFoot");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASStrideDownLeftFoot_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Stride")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASStrideDownRightFoot")]
	public UAnimSequence ASStrideDownRightFoot
	{
		get
		{
			CheckDestroyed();
			if (!ASStrideDownRightFoot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASStrideDownRightFoot");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASStrideDownRightFoot_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASStrideDownRightFoot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASStrideDownRightFoot");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASStrideDownRightFoot_Offset), value);
			}
		}
	}

	[Category("Stride")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASStrideDownLeftFootFall")]
	public UAnimSequence ASStrideDownLeftFootFall
	{
		get
		{
			CheckDestroyed();
			if (!ASStrideDownLeftFootFall_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASStrideDownLeftFootFall");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASStrideDownLeftFootFall_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASStrideDownLeftFootFall_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASStrideDownLeftFootFall");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASStrideDownLeftFootFall_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("Stride")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASStrideDownRightFootFall")]
	public UAnimSequence ASStrideDownRightFootFall
	{
		get
		{
			CheckDestroyed();
			if (!ASStrideDownRightFootFall_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASStrideDownRightFootFall");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASStrideDownRightFootFall_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASStrideDownRightFootFall_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASStrideDownRightFootFall");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASStrideDownRightFootFall_Offset), value);
			}
		}
	}

	[Category("Stride")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASStrideDownLeftFootEnd")]
	public UAnimSequence ASStrideDownLeftFootEnd
	{
		get
		{
			CheckDestroyed();
			if (!ASStrideDownLeftFootEnd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASStrideDownLeftFootEnd");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASStrideDownLeftFootEnd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASStrideDownLeftFootEnd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASStrideDownLeftFootEnd");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASStrideDownLeftFootEnd_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("Stride")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASStrideDownRightFootEnd")]
	public UAnimSequence ASStrideDownRightFootEnd
	{
		get
		{
			CheckDestroyed();
			if (!ASStrideDownRightFootEnd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASStrideDownRightFootEnd");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASStrideDownRightFootEnd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASStrideDownRightFootEnd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASStrideDownRightFootEnd");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASStrideDownRightFootEnd_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("Stride")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASStrideDownLeftFootLandMove")]
	public UAnimSequence ASStrideDownLeftFootLandMove
	{
		get
		{
			CheckDestroyed();
			if (!ASStrideDownLeftFootLandMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASStrideDownLeftFootLandMove");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASStrideDownLeftFootLandMove_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASStrideDownLeftFootLandMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASStrideDownLeftFootLandMove");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASStrideDownLeftFootLandMove_Offset), value);
			}
		}
	}

	[Category("Stride")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASStrideDownRightFootLandMove")]
	public UAnimSequence ASStrideDownRightFootLandMove
	{
		get
		{
			CheckDestroyed();
			if (!ASStrideDownRightFootLandMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASStrideDownRightFootLandMove");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASStrideDownRightFootLandMove_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASStrideDownRightFootLandMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASStrideDownRightFootLandMove");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASStrideDownRightFootLandMove_Offset), value);
			}
		}
	}

	[Category("Jump")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bIsInAir")]
	public bool bIsInAir
	{
		get
		{
			CheckDestroyed();
			if (!bIsInAir_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bIsInAir");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bIsInAir_Offset), 0, bIsInAir_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bIsInAir_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bIsInAir");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bIsInAir_Offset), 0, bIsInAir_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Jump")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bAirMoving")]
	public bool bAirMoving
	{
		get
		{
			CheckDestroyed();
			if (!bAirMoving_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bAirMoving");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bAirMoving_Offset), 0, bAirMoving_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bAirMoving_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bAirMoving");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bAirMoving_Offset), 0, bAirMoving_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Jump")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:StartJumpDir")]
	public ESkillDirection StartJumpDir
	{
		get
		{
			CheckDestroyed();
			if (!StartJumpDir_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:StartJumpDir");
				return ESkillDirection.None;
			}
			return EnumMarshaler<ESkillDirection>.FromNative(IntPtr.Add(base.Address, StartJumpDir_Offset), 0, StartJumpDir_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!StartJumpDir_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:StartJumpDir");
			}
			else
			{
				EnumMarshaler<ESkillDirection>.ToNative(IntPtr.Add(base.Address, StartJumpDir_Offset), 0, StartJumpDir_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Jump")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bIsJumpStartFast")]
	public bool bIsJumpStartFast
	{
		get
		{
			CheckDestroyed();
			if (!bIsJumpStartFast_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bIsJumpStartFast");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bIsJumpStartFast_Offset), 0, bIsJumpStartFast_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bIsJumpStartFast_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bIsJumpStartFast");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bIsJumpStartFast_Offset), 0, bIsJumpStartFast_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Jump")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bInJump")]
	public bool bInJump
	{
		get
		{
			CheckDestroyed();
			if (!bInJump_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bInJump");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bInJump_Offset), 0, bInJump_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bInJump_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bInJump");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bInJump_Offset), 0, bInJump_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Jump")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bIsLittleFall")]
	public bool bIsLittleFall
	{
		get
		{
			CheckDestroyed();
			if (!bIsLittleFall_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bIsLittleFall");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bIsLittleFall_Offset), 0, bIsLittleFall_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bIsLittleFall_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bIsLittleFall");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bIsLittleFall_Offset), 0, bIsLittleFall_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Jump")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bHasFallAnimAsset")]
	public bool bHasFallAnimAsset
	{
		get
		{
			CheckDestroyed();
			if (!bHasFallAnimAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bHasFallAnimAsset");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bHasFallAnimAsset_Offset), 0, bHasFallAnimAsset_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bHasFallAnimAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bHasFallAnimAsset");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bHasFallAnimAsset_Offset), 0, bHasFallAnimAsset_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("Jump")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:StartJumpSpdState")]
	private EStartJumpSpdState StartJumpSpdState
	{
		get
		{
			CheckDestroyed();
			if (!StartJumpSpdState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:StartJumpSpdState");
				return EStartJumpSpdState.StartJumpSpdState_Zero;
			}
			return EnumMarshaler<EStartJumpSpdState>.FromNative(IntPtr.Add(base.Address, StartJumpSpdState_Offset), 0, StartJumpSpdState_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!StartJumpSpdState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:StartJumpSpdState");
			}
			else
			{
				EnumMarshaler<EStartJumpSpdState>.ToNative(IntPtr.Add(base.Address, StartJumpSpdState_Offset), 0, StartJumpSpdState_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("Jump")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:BSJumpStart_F")]
	public UBlendSpace BSJumpStart_F
	{
		get
		{
			CheckDestroyed();
			if (!BSJumpStart_F_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:BSJumpStart_F");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSJumpStart_F_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSJumpStart_F_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:BSJumpStart_F");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSJumpStart_F_Offset), value);
			}
		}
	}

	[Category("Jump")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:BSJumpStart_B")]
	public UBlendSpace BSJumpStart_B
	{
		get
		{
			CheckDestroyed();
			if (!BSJumpStart_B_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:BSJumpStart_B");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSJumpStart_B_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSJumpStart_B_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:BSJumpStart_B");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSJumpStart_B_Offset), value);
			}
		}
	}

	[Category("Jump")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:BSJumpLoop_F")]
	public UBlendSpace BSJumpLoop_F
	{
		get
		{
			CheckDestroyed();
			if (!BSJumpLoop_F_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:BSJumpLoop_F");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSJumpLoop_F_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSJumpLoop_F_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:BSJumpLoop_F");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSJumpLoop_F_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("Jump")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:BSJumpLoop_B")]
	public UBlendSpace BSJumpLoop_B
	{
		get
		{
			CheckDestroyed();
			if (!BSJumpLoop_B_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:BSJumpLoop_B");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSJumpLoop_B_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSJumpLoop_B_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:BSJumpLoop_B");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSJumpLoop_B_Offset), value);
			}
		}
	}

	[Category("Jump")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:BSJumpAdditiveLean")]
	public UBlendSpace BSJumpAdditiveLean
	{
		get
		{
			CheckDestroyed();
			if (!BSJumpAdditiveLean_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:BSJumpAdditiveLean");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSJumpAdditiveLean_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSJumpAdditiveLean_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:BSJumpAdditiveLean");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSJumpAdditiveLean_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("Jump")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:BSJumpAdditiveRot")]
	public UBlendSpace BSJumpAdditiveRot
	{
		get
		{
			CheckDestroyed();
			if (!BSJumpAdditiveRot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:BSJumpAdditiveRot");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSJumpAdditiveRot_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSJumpAdditiveRot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:BSJumpAdditiveRot");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSJumpAdditiveRot_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Jump")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimGroundJumpStart")]
	public UAnimSequence AnimGroundJumpStart
	{
		get
		{
			CheckDestroyed();
			if (!AnimGroundJumpStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimGroundJumpStart");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, AnimGroundJumpStart_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimGroundJumpStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimGroundJumpStart");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, AnimGroundJumpStart_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Jump")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimJumpStart_N")]
	public UAnimSequence AnimJumpStart_N
	{
		get
		{
			CheckDestroyed();
			if (!AnimJumpStart_N_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimJumpStart_N");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, AnimJumpStart_N_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimJumpStart_N_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimJumpStart_N");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, AnimJumpStart_N_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("Jump")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimJumpStart_F")]
	public UAnimSequence AnimJumpStart_F
	{
		get
		{
			CheckDestroyed();
			if (!AnimJumpStart_F_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimJumpStart_F");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, AnimJumpStart_F_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimJumpStart_F_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimJumpStart_F");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, AnimJumpStart_F_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("Jump")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimJumpStart_L")]
	public UAnimSequence AnimJumpStart_L
	{
		get
		{
			CheckDestroyed();
			if (!AnimJumpStart_L_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimJumpStart_L");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, AnimJumpStart_L_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimJumpStart_L_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimJumpStart_L");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, AnimJumpStart_L_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("Jump")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimJumpStart_R")]
	public UAnimSequence AnimJumpStart_R
	{
		get
		{
			CheckDestroyed();
			if (!AnimJumpStart_R_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimJumpStart_R");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, AnimJumpStart_R_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimJumpStart_R_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimJumpStart_R");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, AnimJumpStart_R_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Jump")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimJumpStart_B")]
	public UAnimSequence AnimJumpStart_B
	{
		get
		{
			CheckDestroyed();
			if (!AnimJumpStart_B_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimJumpStart_B");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, AnimJumpStart_B_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimJumpStart_B_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimJumpStart_B");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, AnimJumpStart_B_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Jump")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimGlideJumpStart")]
	public UAnimSequence AnimGlideJumpStart
	{
		get
		{
			CheckDestroyed();
			if (!AnimGlideJumpStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimGlideJumpStart");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, AnimGlideJumpStart_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimGlideJumpStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimGlideJumpStart");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, AnimGlideJumpStart_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Jump")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimFallStart")]
	public UAnimSequence AnimFallStart
	{
		get
		{
			CheckDestroyed();
			if (!AnimFallStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimFallStart");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, AnimFallStart_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimFallStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimFallStart");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, AnimFallStart_Offset), value);
			}
		}
	}

	[Category("Jump")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimFallStart_N")]
	public UAnimSequence AnimFallStart_N
	{
		get
		{
			CheckDestroyed();
			if (!AnimFallStart_N_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimFallStart_N");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, AnimFallStart_N_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimFallStart_N_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimFallStart_N");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, AnimFallStart_N_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Jump")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimFallStart_F")]
	public UAnimSequence AnimFallStart_F
	{
		get
		{
			CheckDestroyed();
			if (!AnimFallStart_F_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimFallStart_F");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, AnimFallStart_F_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimFallStart_F_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimFallStart_F");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, AnimFallStart_F_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Jump")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimFallStart_L")]
	public UAnimSequence AnimFallStart_L
	{
		get
		{
			CheckDestroyed();
			if (!AnimFallStart_L_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimFallStart_L");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, AnimFallStart_L_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimFallStart_L_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimFallStart_L");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, AnimFallStart_L_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("Jump")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimFallStart_R")]
	public UAnimSequence AnimFallStart_R
	{
		get
		{
			CheckDestroyed();
			if (!AnimFallStart_R_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimFallStart_R");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, AnimFallStart_R_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimFallStart_R_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimFallStart_R");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, AnimFallStart_R_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Jump")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimFallStart_B")]
	public UAnimSequence AnimFallStart_B
	{
		get
		{
			CheckDestroyed();
			if (!AnimFallStart_B_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimFallStart_B");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, AnimFallStart_B_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimFallStart_B_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimFallStart_B");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, AnimFallStart_B_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("Jump")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimFallLoop")]
	public UAnimSequence AnimFallLoop
	{
		get
		{
			CheckDestroyed();
			if (!AnimFallLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimFallLoop");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, AnimFallLoop_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimFallLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimFallLoop");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, AnimFallLoop_Offset), value);
			}
		}
	}

	[Category("Jump")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:FallHeightType")]
	public EFallHeightType_V2 FallHeightType
	{
		get
		{
			CheckDestroyed();
			if (!FallHeightType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:FallHeightType");
				return EFallHeightType_V2.FallHeight_Little;
			}
			return EnumMarshaler<EFallHeightType_V2>.FromNative(IntPtr.Add(base.Address, FallHeightType_Offset), 0, FallHeightType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!FallHeightType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:FallHeightType");
			}
			else
			{
				EnumMarshaler<EFallHeightType_V2>.ToNative(IntPtr.Add(base.Address, FallHeightType_Offset), 0, FallHeightType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Jump")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:FallHeight")]
	public float FallHeight
	{
		get
		{
			CheckDestroyed();
			if (!FallHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:FallHeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FallHeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FallHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:FallHeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FallHeight_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Jump")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimLand_F_Low")]
	public UAnimSequence AnimLand_F_Low
	{
		get
		{
			CheckDestroyed();
			if (!AnimLand_F_Low_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimLand_F_Low");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, AnimLand_F_Low_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimLand_F_Low_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimLand_F_Low");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, AnimLand_F_Low_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("Jump")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimLand_F_Mid")]
	public UAnimSequence AnimLand_F_Mid
	{
		get
		{
			CheckDestroyed();
			if (!AnimLand_F_Mid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimLand_F_Mid");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, AnimLand_F_Mid_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimLand_F_Mid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimLand_F_Mid");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, AnimLand_F_Mid_Offset), value);
			}
		}
	}

	[Category("Jump")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimLand_F_High")]
	public UAnimSequence AnimLand_F_High
	{
		get
		{
			CheckDestroyed();
			if (!AnimLand_F_High_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimLand_F_High");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, AnimLand_F_High_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimLand_F_High_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimLand_F_High");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, AnimLand_F_High_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("Jump")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimLand_L")]
	public UAnimSequence AnimLand_L
	{
		get
		{
			CheckDestroyed();
			if (!AnimLand_L_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimLand_L");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, AnimLand_L_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimLand_L_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimLand_L");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, AnimLand_L_Offset), value);
			}
		}
	}

	[Category("Jump")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimLand_R")]
	public UAnimSequence AnimLand_R
	{
		get
		{
			CheckDestroyed();
			if (!AnimLand_R_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimLand_R");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, AnimLand_R_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimLand_R_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimLand_R");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, AnimLand_R_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Jump")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimLand_B")]
	public UAnimSequence AnimLand_B
	{
		get
		{
			CheckDestroyed();
			if (!AnimLand_B_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimLand_B");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, AnimLand_B_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimLand_B_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimLand_B");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, AnimLand_B_Offset), value);
			}
		}
	}

	[Category("Jump")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bIsInLandCantMoveTime")]
	public bool bIsInLandCantMoveTime
	{
		get
		{
			CheckDestroyed();
			if (!bIsInLandCantMoveTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bIsInLandCantMoveTime");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bIsInLandCantMoveTime_Offset), 0, bIsInLandCantMoveTime_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bIsInLandCantMoveTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bIsInLandCantMoveTime");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bIsInLandCantMoveTime_Offset), 0, bIsInLandCantMoveTime_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Jump")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:StartMoveAfterJump")]
	public UAnimSequence StartMoveAfterJump
	{
		get
		{
			CheckDestroyed();
			if (!StartMoveAfterJump_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:StartMoveAfterJump");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, StartMoveAfterJump_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StartMoveAfterJump_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:StartMoveAfterJump");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, StartMoveAfterJump_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("Jump")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AddtiveMoveAfterJump_F")]
	public UAnimSequence AddtiveMoveAfterJump_F
	{
		get
		{
			CheckDestroyed();
			if (!AddtiveMoveAfterJump_F_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AddtiveMoveAfterJump_F");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, AddtiveMoveAfterJump_F_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AddtiveMoveAfterJump_F_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AddtiveMoveAfterJump_F");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, AddtiveMoveAfterJump_F_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Jump")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AddtiveMoveAfterJump_B")]
	public UAnimSequence AddtiveMoveAfterJump_B
	{
		get
		{
			CheckDestroyed();
			if (!AddtiveMoveAfterJump_B_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AddtiveMoveAfterJump_B");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, AddtiveMoveAfterJump_B_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AddtiveMoveAfterJump_B_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AddtiveMoveAfterJump_B");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, AddtiveMoveAfterJump_B_Offset), value);
			}
		}
	}

	[Category("Jump")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AddtiveMoveAfterJump_L")]
	public UAnimSequence AddtiveMoveAfterJump_L
	{
		get
		{
			CheckDestroyed();
			if (!AddtiveMoveAfterJump_L_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AddtiveMoveAfterJump_L");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, AddtiveMoveAfterJump_L_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AddtiveMoveAfterJump_L_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AddtiveMoveAfterJump_L");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, AddtiveMoveAfterJump_L_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("Jump")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AddtiveMoveAfterJump_R")]
	public UAnimSequence AddtiveMoveAfterJump_R
	{
		get
		{
			CheckDestroyed();
			if (!AddtiveMoveAfterJump_R_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AddtiveMoveAfterJump_R");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, AddtiveMoveAfterJump_R_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AddtiveMoveAfterJump_R_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AddtiveMoveAfterJump_R");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, AddtiveMoveAfterJump_R_Offset), value);
			}
		}
	}

	[Category("Jump")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AdditiveMoveAfterJumpFAlpha")]
	public float AdditiveMoveAfterJumpFAlpha
	{
		get
		{
			CheckDestroyed();
			if (!AdditiveMoveAfterJumpFAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AdditiveMoveAfterJumpFAlpha");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AdditiveMoveAfterJumpFAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AdditiveMoveAfterJumpFAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AdditiveMoveAfterJumpFAlpha");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AdditiveMoveAfterJumpFAlpha_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("Jump")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AdditiveMoveAfterJumpBAlpha")]
	public float AdditiveMoveAfterJumpBAlpha
	{
		get
		{
			CheckDestroyed();
			if (!AdditiveMoveAfterJumpBAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AdditiveMoveAfterJumpBAlpha");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AdditiveMoveAfterJumpBAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AdditiveMoveAfterJumpBAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AdditiveMoveAfterJumpBAlpha");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AdditiveMoveAfterJumpBAlpha_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Jump")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AdditiveMoveAfterJumpLAlpha")]
	public float AdditiveMoveAfterJumpLAlpha
	{
		get
		{
			CheckDestroyed();
			if (!AdditiveMoveAfterJumpLAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AdditiveMoveAfterJumpLAlpha");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AdditiveMoveAfterJumpLAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AdditiveMoveAfterJumpLAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AdditiveMoveAfterJumpLAlpha");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AdditiveMoveAfterJumpLAlpha_Offset), value);
			}
		}
	}

	[Category("Jump")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AdditiveMoveAfterJumpRAlpha")]
	public float AdditiveMoveAfterJumpRAlpha
	{
		get
		{
			CheckDestroyed();
			if (!AdditiveMoveAfterJumpRAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AdditiveMoveAfterJumpRAlpha");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AdditiveMoveAfterJumpRAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AdditiveMoveAfterJumpRAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AdditiveMoveAfterJumpRAlpha");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AdditiveMoveAfterJumpRAlpha_Offset), value);
			}
		}
	}

	[Category("Jump")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:BSJumpAdditiveLeanX")]
	public float BSJumpAdditiveLeanX
	{
		get
		{
			CheckDestroyed();
			if (!BSJumpAdditiveLeanX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:BSJumpAdditiveLeanX");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BSJumpAdditiveLeanX_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSJumpAdditiveLeanX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:BSJumpAdditiveLeanX");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BSJumpAdditiveLeanX_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Jump")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:BSJumpAdditiveLeanY")]
	public float BSJumpAdditiveLeanY
	{
		get
		{
			CheckDestroyed();
			if (!BSJumpAdditiveLeanY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:BSJumpAdditiveLeanY");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BSJumpAdditiveLeanY_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSJumpAdditiveLeanY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:BSJumpAdditiveLeanY");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BSJumpAdditiveLeanY_Offset), value);
			}
		}
	}

	[Category("Jump")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:LandPredictionAlpha")]
	public float LandPredictionAlpha
	{
		get
		{
			CheckDestroyed();
			if (!LandPredictionAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:LandPredictionAlpha");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LandPredictionAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LandPredictionAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:LandPredictionAlpha");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LandPredictionAlpha_Offset), value);
			}
		}
	}

	[Category("Jump")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:BSJumpAdditiveRotX")]
	public float BSJumpAdditiveRotX
	{
		get
		{
			CheckDestroyed();
			if (!BSJumpAdditiveRotX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:BSJumpAdditiveRotX");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BSJumpAdditiveRotX_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSJumpAdditiveRotX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:BSJumpAdditiveRotX");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BSJumpAdditiveRotX_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("Jump")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:BSJumpAdditiveRotY")]
	public float BSJumpAdditiveRotY
	{
		get
		{
			CheckDestroyed();
			if (!BSJumpAdditiveRotY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:BSJumpAdditiveRotY");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BSJumpAdditiveRotY_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSJumpAdditiveRotY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:BSJumpAdditiveRotY");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BSJumpAdditiveRotY_Offset), value);
			}
		}
	}

	[Category("Jump")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:LandAdditiveAlpha")]
	public float LandAdditiveAlpha
	{
		get
		{
			CheckDestroyed();
			if (!LandAdditiveAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:LandAdditiveAlpha");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LandAdditiveAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LandAdditiveAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:LandAdditiveAlpha");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LandAdditiveAlpha_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("Jump")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:VelocityDeltaAngle")]
	public float VelocityDeltaAngle
	{
		get
		{
			CheckDestroyed();
			if (!VelocityDeltaAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:VelocityDeltaAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, VelocityDeltaAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VelocityDeltaAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:VelocityDeltaAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, VelocityDeltaAngle_Offset), value);
			}
		}
	}

	[Category("Jump")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:VelocityDeltaAngleTrans")]
	public float VelocityDeltaAngleTrans
	{
		get
		{
			CheckDestroyed();
			if (!VelocityDeltaAngleTrans_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:VelocityDeltaAngleTrans");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, VelocityDeltaAngleTrans_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VelocityDeltaAngleTrans_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:VelocityDeltaAngleTrans");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, VelocityDeltaAngleTrans_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("Spline Move")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bSplineMoving")]
	public bool bSplineMoving
	{
		get
		{
			CheckDestroyed();
			if (!bSplineMoving_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bSplineMoving");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bSplineMoving_Offset), 0, bSplineMoving_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bSplineMoving_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bSplineMoving");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bSplineMoving_Offset), 0, bSplineMoving_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Spline Move")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bSplineMoveForward")]
	public bool bSplineMoveForward
	{
		get
		{
			CheckDestroyed();
			if (!bSplineMoveForward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bSplineMoveForward");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bSplineMoveForward_Offset), 0, bSplineMoveForward_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bSplineMoveForward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bSplineMoveForward");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bSplineMoveForward_Offset), 0, bSplineMoveForward_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[Category("Spline Move")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bSplineMoveSharpturn")]
	public bool bSplineMoveSharpturn
	{
		get
		{
			CheckDestroyed();
			if (!bSplineMoveSharpturn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bSplineMoveSharpturn");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bSplineMoveSharpturn_Offset), 0, bSplineMoveSharpturn_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bSplineMoveSharpturn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bSplineMoveSharpturn");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bSplineMoveSharpturn_Offset), 0, bSplineMoveSharpturn_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("Spline Move")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bSplineMoveReSharpturn")]
	public bool bSplineMoveReSharpturn
	{
		get
		{
			CheckDestroyed();
			if (!bSplineMoveReSharpturn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bSplineMoveReSharpturn");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bSplineMoveReSharpturn_Offset), 0, bSplineMoveReSharpturn_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bSplineMoveReSharpturn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bSplineMoveReSharpturn");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bSplineMoveReSharpturn_Offset), 0, bSplineMoveReSharpturn_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[Category("Spline Move")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bSplineMoveCanExitSharpturn")]
	public bool bSplineMoveCanExitSharpturn
	{
		get
		{
			CheckDestroyed();
			if (!bSplineMoveCanExitSharpturn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bSplineMoveCanExitSharpturn");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bSplineMoveCanExitSharpturn_Offset), 0, bSplineMoveCanExitSharpturn_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bSplineMoveCanExitSharpturn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bSplineMoveCanExitSharpturn");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bSplineMoveCanExitSharpturn_Offset), 0, bSplineMoveCanExitSharpturn_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Spline Move")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bSplineMoveStopToStart")]
	public bool bSplineMoveStopToStart
	{
		get
		{
			CheckDestroyed();
			if (!bSplineMoveStopToStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bSplineMoveStopToStart");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bSplineMoveStopToStart_Offset), 0, bSplineMoveStopToStart_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bSplineMoveStopToStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bSplineMoveStopToStart");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bSplineMoveStopToStart_Offset), 0, bSplineMoveStopToStart_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Spline Move")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bSplineMoveStopToLoop")]
	public bool bSplineMoveStopToLoop
	{
		get
		{
			CheckDestroyed();
			if (!bSplineMoveStopToLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bSplineMoveStopToLoop");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bSplineMoveStopToLoop_Offset), 0, bSplineMoveStopToLoop_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bSplineMoveStopToLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bSplineMoveStopToLoop");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bSplineMoveStopToLoop_Offset), 0, bSplineMoveStopToLoop_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Spline Move")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:SharpturnAngle")]
	public float SharpturnAngle
	{
		get
		{
			CheckDestroyed();
			if (!SharpturnAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:SharpturnAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SharpturnAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SharpturnAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:SharpturnAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SharpturnAngle_Offset), value);
			}
		}
	}

	[Category("Spline Move")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASSplineMoveIdleForward")]
	public UAnimSequence ASSplineMoveIdleForward
	{
		get
		{
			CheckDestroyed();
			if (!ASSplineMoveIdleForward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASSplineMoveIdleForward");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASSplineMoveIdleForward_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASSplineMoveIdleForward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASSplineMoveIdleForward");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASSplineMoveIdleForward_Offset), value);
			}
		}
	}

	[Category("Spline Move")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASSplineMoveIdleBackward")]
	public UAnimSequence ASSplineMoveIdleBackward
	{
		get
		{
			CheckDestroyed();
			if (!ASSplineMoveIdleBackward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASSplineMoveIdleBackward");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASSplineMoveIdleBackward_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASSplineMoveIdleBackward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASSplineMoveIdleBackward");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASSplineMoveIdleBackward_Offset), value);
			}
		}
	}

	[Category("Spline Move")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASSplineMoveStartForward")]
	public UAnimSequence ASSplineMoveStartForward
	{
		get
		{
			CheckDestroyed();
			if (!ASSplineMoveStartForward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASSplineMoveStartForward");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASSplineMoveStartForward_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASSplineMoveStartForward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASSplineMoveStartForward");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASSplineMoveStartForward_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("Spline Move")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASSplineMoveStartBackward")]
	public UAnimSequence ASSplineMoveStartBackward
	{
		get
		{
			CheckDestroyed();
			if (!ASSplineMoveStartBackward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASSplineMoveStartBackward");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASSplineMoveStartBackward_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASSplineMoveStartBackward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASSplineMoveStartBackward");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASSplineMoveStartBackward_Offset), value);
			}
		}
	}

	[Category("Spline Move")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASSplineMoveLoopForward")]
	public UAnimSequence ASSplineMoveLoopForward
	{
		get
		{
			CheckDestroyed();
			if (!ASSplineMoveLoopForward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASSplineMoveLoopForward");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASSplineMoveLoopForward_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASSplineMoveLoopForward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASSplineMoveLoopForward");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASSplineMoveLoopForward_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Spline Move")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASSplineMoveLoopBackward")]
	public UAnimSequence ASSplineMoveLoopBackward
	{
		get
		{
			CheckDestroyed();
			if (!ASSplineMoveLoopBackward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASSplineMoveLoopBackward");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASSplineMoveLoopBackward_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASSplineMoveLoopBackward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASSplineMoveLoopBackward");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASSplineMoveLoopBackward_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("Spline Move")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASSplineMoveStopForward")]
	public UAnimSequence ASSplineMoveStopForward
	{
		get
		{
			CheckDestroyed();
			if (!ASSplineMoveStopForward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASSplineMoveStopForward");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASSplineMoveStopForward_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASSplineMoveStopForward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASSplineMoveStopForward");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASSplineMoveStopForward_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("Spline Move")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASSplineMoveStopBackward")]
	public UAnimSequence ASSplineMoveStopBackward
	{
		get
		{
			CheckDestroyed();
			if (!ASSplineMoveStopBackward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASSplineMoveStopBackward");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASSplineMoveStopBackward_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASSplineMoveStopBackward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASSplineMoveStopBackward");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASSplineMoveStopBackward_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("Spline Move")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASSplineMoveTurnF2B")]
	public UAnimSequence ASSplineMoveTurnF2B
	{
		get
		{
			CheckDestroyed();
			if (!ASSplineMoveTurnF2B_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASSplineMoveTurnF2B");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASSplineMoveTurnF2B_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASSplineMoveTurnF2B_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASSplineMoveTurnF2B");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASSplineMoveTurnF2B_Offset), value);
			}
		}
	}

	[Category("Spline Move")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASSplineMoveTurnB2F")]
	public UAnimSequence ASSplineMoveTurnB2F
	{
		get
		{
			CheckDestroyed();
			if (!ASSplineMoveTurnB2F_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASSplineMoveTurnB2F");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASSplineMoveTurnB2F_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASSplineMoveTurnB2F_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:ASSplineMoveTurnB2F");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASSplineMoveTurnB2F_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Cloud Move")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimCloudFallStart")]
	public UAnimSequence AnimCloudFallStart
	{
		get
		{
			CheckDestroyed();
			if (!AnimCloudFallStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimCloudFallStart");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, AnimCloudFallStart_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimCloudFallStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimCloudFallStart");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, AnimCloudFallStart_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Cloud Move")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimCloudFallLoop")]
	public UAnimSequence AnimCloudFallLoop
	{
		get
		{
			CheckDestroyed();
			if (!AnimCloudFallLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimCloudFallLoop");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, AnimCloudFallLoop_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimCloudFallLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:AnimCloudFallLoop");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, AnimCloudFallLoop_Offset), value);
			}
		}
	}

	[Category("Trans")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bGlideEndToGroundMove")]
	public bool bGlideEndToGroundMove
	{
		get
		{
			CheckDestroyed();
			if (!bGlideEndToGroundMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bGlideEndToGroundMove");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bGlideEndToGroundMove_Offset), 0, bGlideEndToGroundMove_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bGlideEndToGroundMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bGlideEndToGroundMove");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bGlideEndToGroundMove_Offset), 0, bGlideEndToGroundMove_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[Category("Trans")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bAirStartGlide")]
	public bool bAirStartGlide
	{
		get
		{
			CheckDestroyed();
			if (!bAirStartGlide_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bAirStartGlide");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bAirStartGlide_Offset), 0, bAirStartGlide_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bAirStartGlide_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bAirStartGlide");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bAirStartGlide_Offset), 0, bAirStartGlide_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trans")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bGlideFlat")]
	public bool bGlideFlat
	{
		get
		{
			CheckDestroyed();
			if (!bGlideFlat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bGlideFlat");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bGlideFlat_Offset), 0, bGlideFlat_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bGlideFlat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bGlideFlat");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bGlideFlat_Offset), 0, bGlideFlat_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trans")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bGlideSteep")]
	public bool bGlideSteep
	{
		get
		{
			CheckDestroyed();
			if (!bGlideSteep_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bGlideSteep");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bGlideSteep_Offset), 0, bGlideSteep_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bGlideSteep_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bGlideSteep");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bGlideSteep_Offset), 0, bGlideSteep_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trans")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bGlideStartFront")]
	public bool bGlideStartFront
	{
		get
		{
			CheckDestroyed();
			if (!bGlideStartFront_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bGlideStartFront");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bGlideStartFront_Offset), 0, bGlideStartFront_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bGlideStartFront_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bGlideStartFront");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bGlideStartFront_Offset), 0, bGlideStartFront_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("Trans")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bGlideStartBack")]
	public bool bGlideStartBack
	{
		get
		{
			CheckDestroyed();
			if (!bGlideStartBack_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bGlideStartBack");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bGlideStartBack_Offset), 0, bGlideStartBack_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bGlideStartBack_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bGlideStartBack");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bGlideStartBack_Offset), 0, bGlideStartBack_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trans")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bGlideLoopRotationLeft")]
	public bool bGlideLoopRotationLeft
	{
		get
		{
			CheckDestroyed();
			if (!bGlideLoopRotationLeft_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bGlideLoopRotationLeft");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bGlideLoopRotationLeft_Offset), 0, bGlideLoopRotationLeft_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bGlideLoopRotationLeft_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bGlideLoopRotationLeft");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bGlideLoopRotationLeft_Offset), 0, bGlideLoopRotationLeft_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bGlideLoopRotationRight")]
	public bool bGlideLoopRotationRight
	{
		get
		{
			CheckDestroyed();
			if (!bGlideLoopRotationRight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bGlideLoopRotationRight");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bGlideLoopRotationRight_Offset), 0, bGlideLoopRotationRight_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bGlideLoopRotationRight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bGlideLoopRotationRight");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bGlideLoopRotationRight_Offset), 0, bGlideLoopRotationRight_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trans")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bGlideEndSlow")]
	public bool bGlideEndSlow
	{
		get
		{
			CheckDestroyed();
			if (!bGlideEndSlow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bGlideEndSlow");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bGlideEndSlow_Offset), 0, bGlideEndSlow_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bGlideEndSlow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bGlideEndSlow");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bGlideEndSlow_Offset), 0, bGlideEndSlow_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[Category("Trans")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bGlideEndFast")]
	public bool bGlideEndFast
	{
		get
		{
			CheckDestroyed();
			if (!bGlideEndFast_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bGlideEndFast");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bGlideEndFast_Offset), 0, bGlideEndFast_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bGlideEndFast_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bGlideEndFast");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bGlideEndFast_Offset), 0, bGlideEndFast_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bToFall")]
	public bool bToFall
	{
		get
		{
			CheckDestroyed();
			if (!bToFall_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bToFall");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bToFall_Offset), 0, bToFall_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bToFall_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bToFall");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bToFall_Offset), 0, bToFall_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bToGroundJumpStart")]
	public bool bToGroundJumpStart
	{
		get
		{
			CheckDestroyed();
			if (!bToGroundJumpStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bToGroundJumpStart");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bToGroundJumpStart_Offset), 0, bToGroundJumpStart_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bToGroundJumpStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bToGroundJumpStart");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bToGroundJumpStart_Offset), 0, bToGroundJumpStart_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bToGroundJumpStartFwd")]
	public bool bToGroundJumpStartFwd
	{
		get
		{
			CheckDestroyed();
			if (!bToGroundJumpStartFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bToGroundJumpStartFwd");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bToGroundJumpStartFwd_Offset), 0, bToGroundJumpStartFwd_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bToGroundJumpStartFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bToGroundJumpStartFwd");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bToGroundJumpStartFwd_Offset), 0, bToGroundJumpStartFwd_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bToGroundJumpStartBwd")]
	public bool bToGroundJumpStartBwd
	{
		get
		{
			CheckDestroyed();
			if (!bToGroundJumpStartBwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bToGroundJumpStartBwd");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bToGroundJumpStartBwd_Offset), 0, bToGroundJumpStartBwd_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bToGroundJumpStartBwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bToGroundJumpStartBwd");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bToGroundJumpStartBwd_Offset), 0, bToGroundJumpStartBwd_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trans")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bToGlideJumpStart")]
	public bool bToGlideJumpStart
	{
		get
		{
			CheckDestroyed();
			if (!bToGlideJumpStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bToGlideJumpStart");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bToGlideJumpStart_Offset), 0, bToGlideJumpStart_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bToGlideJumpStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bToGlideJumpStart");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bToGlideJumpStart_Offset), 0, bToGlideJumpStart_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bToLandAdditive")]
	public bool bToLandAdditive
	{
		get
		{
			CheckDestroyed();
			if (!bToLandAdditive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bToLandAdditive");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bToLandAdditive_Offset), 0, bToLandAdditive_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bToLandAdditive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bToLandAdditive");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bToLandAdditive_Offset), 0, bToLandAdditive_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bStride")]
	public bool bStride
	{
		get
		{
			CheckDestroyed();
			if (!bStride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bStride");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bStride_Offset), 0, bStride_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bStride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bStride");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bStride_Offset), 0, bStride_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trans")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bStrideJump")]
	public bool bStrideJump
	{
		get
		{
			CheckDestroyed();
			if (!bStrideJump_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bStrideJump");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bStrideJump_Offset), 0, bStrideJump_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bStrideJump_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bStrideJump");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bStrideJump_Offset), 0, bStrideJump_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trans")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bStrideUpJump")]
	public bool bStrideUpJump
	{
		get
		{
			CheckDestroyed();
			if (!bStrideUpJump_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bStrideUpJump");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bStrideUpJump_Offset), 0, bStrideUpJump_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bStrideUpJump_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bStrideUpJump");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bStrideUpJump_Offset), 0, bStrideUpJump_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bStrideDownJump")]
	public bool bStrideDownJump
	{
		get
		{
			CheckDestroyed();
			if (!bStrideDownJump_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bStrideDownJump");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bStrideDownJump_Offset), 0, bStrideDownJump_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bStrideDownJump_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bStrideDownJump");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bStrideDownJump_Offset), 0, bStrideDownJump_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bStrideUp")]
	public bool bStrideUp
	{
		get
		{
			CheckDestroyed();
			if (!bStrideUp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bStrideUp");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bStrideUp_Offset), 0, bStrideUp_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bStrideUp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bStrideUp");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bStrideUp_Offset), 0, bStrideUp_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[Category("Trans")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bStrideDown")]
	public bool bStrideDown
	{
		get
		{
			CheckDestroyed();
			if (!bStrideDown_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bStrideDown");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bStrideDown_Offset), 0, bStrideDown_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bStrideDown_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bStrideDown");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bStrideDown_Offset), 0, bStrideDown_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bStrideUpLand")]
	public bool bStrideUpLand
	{
		get
		{
			CheckDestroyed();
			if (!bStrideUpLand_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bStrideUpLand");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bStrideUpLand_Offset), 0, bStrideUpLand_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bStrideUpLand_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bStrideUpLand");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bStrideUpLand_Offset), 0, bStrideUpLand_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bStrideDownLand")]
	public bool bStrideDownLand
	{
		get
		{
			CheckDestroyed();
			if (!bStrideDownLand_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bStrideDownLand");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bStrideDownLand_Offset), 0, bStrideDownLand_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bStrideDownLand_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bStrideDownLand");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bStrideDownLand_Offset), 0, bStrideDownLand_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bStrideUpHigh")]
	public bool bStrideUpHigh
	{
		get
		{
			CheckDestroyed();
			if (!bStrideUpHigh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bStrideUpHigh");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bStrideUpHigh_Offset), 0, bStrideUpHigh_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bStrideUpHigh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bStrideUpHigh");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bStrideUpHigh_Offset), 0, bStrideUpHigh_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("Trans")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bStrideUpLow")]
	public bool bStrideUpLow
	{
		get
		{
			CheckDestroyed();
			if (!bStrideUpLow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bStrideUpLow");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bStrideUpLow_Offset), 0, bStrideUpLow_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bStrideUpLow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bStrideUpLow");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bStrideUpLow_Offset), 0, bStrideUpLow_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[Category("Trans")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bCloudFall")]
	public bool bCloudFall
	{
		get
		{
			CheckDestroyed();
			if (!bCloudFall_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bCloudFall");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bCloudFall_Offset), 0, bCloudFall_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bCloudFall_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bCloudFall");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bCloudFall_Offset), 0, bCloudFall_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bLeaveGlideMoving")]
	public bool bLeaveGlideMoving
	{
		get
		{
			CheckDestroyed();
			if (!bLeaveGlideMoving_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bLeaveGlideMoving");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLeaveGlideMoving_Offset), 0, bLeaveGlideMoving_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLeaveGlideMoving_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bLeaveGlideMoving");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLeaveGlideMoving_Offset), 0, bLeaveGlideMoving_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bParkourClimb")]
	public bool bParkourClimb
	{
		get
		{
			CheckDestroyed();
			if (!bParkourClimb_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bParkourClimb");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bParkourClimb_Offset), 0, bParkourClimb_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bParkourClimb_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bParkourClimb");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bParkourClimb_Offset), 0, bParkourClimb_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bParkourAcross")]
	public bool bParkourAcross
	{
		get
		{
			CheckDestroyed();
			if (!bParkourAcross_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bParkourAcross");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bParkourAcross_Offset), 0, bParkourAcross_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bParkourAcross_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bParkourAcross");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bParkourAcross_Offset), 0, bParkourAcross_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bParkourLow")]
	public bool bParkourLow
	{
		get
		{
			CheckDestroyed();
			if (!bParkourLow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bParkourLow");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bParkourLow_Offset), 0, bParkourLow_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bParkourLow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bParkourLow");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bParkourLow_Offset), 0, bParkourLow_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trans")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bParkourNormal")]
	public bool bParkourNormal
	{
		get
		{
			CheckDestroyed();
			if (!bParkourNormal_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bParkourNormal");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bParkourNormal_Offset), 0, bParkourNormal_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bParkourNormal_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bParkourNormal");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bParkourNormal_Offset), 0, bParkourNormal_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bParkourHigh")]
	public bool bParkourHigh
	{
		get
		{
			CheckDestroyed();
			if (!bParkourHigh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bParkourHigh");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bParkourHigh_Offset), 0, bParkourHigh_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bParkourHigh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bParkourHigh");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bParkourHigh_Offset), 0, bParkourHigh_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trans")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bParkourFall")]
	public bool bParkourFall
	{
		get
		{
			CheckDestroyed();
			if (!bParkourFall_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bParkourFall");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bParkourFall_Offset), 0, bParkourFall_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bParkourFall_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bParkourFall");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bParkourFall_Offset), 0, bParkourFall_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bLandAnimToGround")]
	public bool bLandAnimToGround
	{
		get
		{
			CheckDestroyed();
			if (!bLandAnimToGround_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bLandAnimToGround");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLandAnimToGround_Offset), 0, bLandAnimToGround_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLandAnimToGround_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bLandAnimToGround");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLandAnimToGround_Offset), 0, bLandAnimToGround_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trans")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bLockMoveJumpF")]
	public bool bLockMoveJumpF
	{
		get
		{
			CheckDestroyed();
			if (!bLockMoveJumpF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bLockMoveJumpF");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockMoveJumpF_Offset), 0, bLockMoveJumpF_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockMoveJumpF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bLockMoveJumpF");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockMoveJumpF_Offset), 0, bLockMoveJumpF_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trans")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bLockMoveJumpFL")]
	public bool bLockMoveJumpFL
	{
		get
		{
			CheckDestroyed();
			if (!bLockMoveJumpFL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bLockMoveJumpFL");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockMoveJumpFL_Offset), 0, bLockMoveJumpFL_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockMoveJumpFL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bLockMoveJumpFL");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockMoveJumpFL_Offset), 0, bLockMoveJumpFL_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bLockMoveJumpFR")]
	public bool bLockMoveJumpFR
	{
		get
		{
			CheckDestroyed();
			if (!bLockMoveJumpFR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bLockMoveJumpFR");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockMoveJumpFR_Offset), 0, bLockMoveJumpFR_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockMoveJumpFR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bLockMoveJumpFR");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockMoveJumpFR_Offset), 0, bLockMoveJumpFR_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bLockMoveJumpBL")]
	public bool bLockMoveJumpBL
	{
		get
		{
			CheckDestroyed();
			if (!bLockMoveJumpBL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bLockMoveJumpBL");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockMoveJumpBL_Offset), 0, bLockMoveJumpBL_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockMoveJumpBL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bLockMoveJumpBL");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockMoveJumpBL_Offset), 0, bLockMoveJumpBL_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bLockMoveJumpBR")]
	public bool bLockMoveJumpBR
	{
		get
		{
			CheckDestroyed();
			if (!bLockMoveJumpBR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bLockMoveJumpBR");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockMoveJumpBR_Offset), 0, bLockMoveJumpBR_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockMoveJumpBR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bLockMoveJumpBR");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockMoveJumpBR_Offset), 0, bLockMoveJumpBR_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trans")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bLockMoveJumpB")]
	public bool bLockMoveJumpB
	{
		get
		{
			CheckDestroyed();
			if (!bLockMoveJumpB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bLockMoveJumpB");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockMoveJumpB_Offset), 0, bLockMoveJumpB_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockMoveJumpB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bLockMoveJumpB");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockMoveJumpB_Offset), 0, bLockMoveJumpB_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bToStride")]
	public bool bToStride
	{
		get
		{
			CheckDestroyed();
			if (!bToStride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bToStride");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bToStride_Offset), 0, bToStride_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bToStride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bToStride");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bToStride_Offset), 0, bToStride_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trans")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bStrideContinue")]
	public bool bStrideContinue
	{
		get
		{
			CheckDestroyed();
			if (!bStrideContinue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bStrideContinue");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bStrideContinue_Offset), 0, bStrideContinue_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bStrideContinue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bStrideContinue");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bStrideContinue_Offset), 0, bStrideContinue_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trans")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bLeftFootFront")]
	public bool bLeftFootFront
	{
		get
		{
			CheckDestroyed();
			if (!bLeftFootFront_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bLeftFootFront");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLeftFootFront_Offset), 0, bLeftFootFront_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLeftFootFront_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bLeftFootFront");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLeftFootFront_Offset), 0, bLeftFootFront_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trans")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bToLandAnim")]
	public bool bToLandAnim
	{
		get
		{
			CheckDestroyed();
			if (!bToLandAnim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bToLandAnim");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bToLandAnim_Offset), 0, bToLandAnim_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bToLandAnim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bToLandAnim");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bToLandAnim_Offset), 0, bToLandAnim_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trans")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bToLandMove")]
	public bool bToLandMove
	{
		get
		{
			CheckDestroyed();
			if (!bToLandMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bToLandMove");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bToLandMove_Offset), 0, bToLandMove_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bToLandMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bToLandMove");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bToLandMove_Offset), 0, bToLandMove_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trans")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bSwitchToLock")]
	public bool bSwitchToLock
	{
		get
		{
			CheckDestroyed();
			if (!bSwitchToLock_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bSwitchToLock");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bSwitchToLock_Offset), 0, bSwitchToLock_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bSwitchToLock_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:bSwitchToLock");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bSwitchToLock_Offset), 0, bSwitchToLock_PropertyAddress.Address, value);
			}
		}
	}

	protected override void LinkedGraphInitializeAnimation()
	{
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Owner);
		if (bUS_GSEventCollection != null)
		{
			bUS_GSEventCollection.Evt_CacheSpecialMoveAnimInst.Invoke(this);
		}
	}

	public override void AttachEvent()
	{
		base.AttachEvent();
		BUC_ABPEventCollection bUC_ABPEventCollection = BUC_ABPEventCollection.Get(this);
		bUC_ABPEventCollection.Evt_SetSplineMoveAnimConfig = (BUC_ABPEventCollection.Del_SetSplineMoveAnimConfig)Delegate.Combine(bUC_ABPEventCollection.Evt_SetSplineMoveAnimConfig, new BUC_ABPEventCollection.Del_SetSplineMoveAnimConfig(OnSetSplineMoveAnimConfig));
	}

	public override void UnAttachEvent()
	{
		base.UnAttachEvent();
		BUC_ABPEventCollection bUC_ABPEventCollection = BUC_ABPEventCollection.Get(this);
		if (bUC_ABPEventCollection != null)
		{
			bUC_ABPEventCollection.Evt_SetSplineMoveAnimConfig = (BUC_ABPEventCollection.Del_SetSplineMoveAnimConfig)Delegate.Remove(bUC_ABPEventCollection.Evt_SetSplineMoveAnimConfig, new BUC_ABPEventCollection.Del_SetSplineMoveAnimConfig(OnSetSplineMoveAnimConfig));
		}
	}

	protected override void OnInitABPSetting()
	{
		if (this.IsNullOrDestroyed())
		{
			return;
		}
		BUABPSettingData aBPSettingData = TopAnimInst.ABPSettingData;
		if (aBPSettingData != null)
		{
			BUABPGlideMoveSettingData glideMoveSetting = aBPSettingData.GlideMoveSetting;
			BUABPParkourMoveSettingData parkourMoveSetting = aBPSettingData.ParkourMoveSetting;
			bEnableGlideAnim = glideMoveSetting.bEnableGlideAnim;
			bEnableParkourAnim = parkourMoveSetting.bEnableParkourAnim;
			if (bEnableGlideAnim)
			{
				InitGlideMoveSetting(glideMoveSetting);
			}
			if (bEnableParkourAnim)
			{
				InitParkourMoveSetting(parkourMoveSetting);
			}
			InitData();
		}
	}

	private void OnSetSplineMoveAnimConfig(BGWDataAsset_ManualSplineMoveAnimConfig MoveAnimConfig)
	{
		if (!this.IsNullOrDestroyed())
		{
			ASSplineMoveIdleForward = MoveAnimConfig.ASIdleForward;
			ASSplineMoveIdleBackward = MoveAnimConfig.ASIdleBackward;
			ASSplineMoveStartForward = MoveAnimConfig.ASStartForward;
			ASSplineMoveStartBackward = MoveAnimConfig.ASStartBackward;
			ASSplineMoveLoopForward = MoveAnimConfig.ASLoopForward;
			ASSplineMoveLoopBackward = MoveAnimConfig.ASLoopBackward;
			ASSplineMoveStopForward = MoveAnimConfig.ASStopForward;
			ASSplineMoveStopBackward = MoveAnimConfig.ASStopBackward;
			ASSplineMoveTurnF2B = MoveAnimConfig.ASTurnF2B;
			ASSplineMoveTurnB2F = MoveAnimConfig.ASTurnB2F;
		}
	}

	private void InitGlideMoveSetting(BUABPGlideMoveSettingData Setting)
	{
		InitGlideMoveStartSetting(Setting.Start);
		InitGlideMoveLoopSetting(Setting.Loop);
		InitGlideMoveEndSetting(Setting.End);
	}

	private void InitGlideMoveStartSetting(BUABPGlideMove_StartSettingData Setting)
	{
		ASGlideStartGroundFlatSlow = Setting.ASGlideStartGroundFlatSlow;
		ASGlideStartGroundFlatFast = Setting.ASGlideStartGroundFlatFast;
		ASGlideStartGroundSteepSlow = Setting.ASGlideStartGroundSteepSlow;
		ASGlideStartGroundSteepFast = Setting.ASGlideStartGroundSteepFast;
		ASGlideStartAirFlatSlow = Setting.ASGlideStartAirFlatSlow;
		ASGlideStartAirFlatFast = Setting.ASGlideStartAirFlatFast;
		ASGlideStartAirSteepSlow = Setting.ASGlideStartAirSteepSlow;
		ASGlideStartAirSteepFast = Setting.ASGlideStartAirSteepFast;
		ASGlideStartBackAirFlat = Setting.ASGlideStartBackAirFlat;
		ASGlideStartBackAirSteep = Setting.ASGlideStartBackAirSteep;
	}

	private void InitGlideMoveLoopSetting(BUABPGlideMove_LoopSettingData Setting)
	{
		ASGlideLoopSteep = Setting.ASGlideLoopSteep;
		BSGlideLoopSteepAdditive = Setting.BSGlideLoopSteepAdditive;
		ASGlideLoopFlatSlow = Setting.ASGlideLoopFlatSlow;
		ASGlideLoopFlatFast = Setting.ASGlideLoopFlatFast;
		BSGlideLoopFlatSlowDirAdditive = Setting.BSGlideLoopFlatSlowDirAdditive;
		BSGlideLoopFlatFastDirAdditive = Setting.BSGlideLoopFlatFastDirAdditive;
		BSGlideLoopFlatVerticalInputAdditive = Setting.BSGlideLoopFlatVerticalInputAdditive;
		BSGlideLoopFlatHorizonalInputAdditive = Setting.BSGlideLoopFlatHorizonalInputAdditive;
		ASGlideLoopFlatRotationLeftAdditive = Setting.ASGlideLoopFlatRotationLeftAdditive;
		ASGlideLoopFlatRotationRightAdditive = Setting.ASGlideLoopFlatRotationRightAdditive;
	}

	private void InitGlideMoveEndSetting(BUABPGlideMove_EndSettingData Setting)
	{
		ASGlideEndSlow = Setting.ASGlideEndSlow;
		ASGlideEndFast = Setting.ASGlideEndFast;
	}

	private void InitParkourMoveSetting(BUABPParkourMoveSettingData Setting)
	{
		ASStrideUpLeftFootLow = Setting.ASStrideUpLeftFootLow;
		ASStrideUpRightFootLow = Setting.ASStrideUpRightFootLow;
		ASStrideUpLeftFootHigh = Setting.ASStrideUpLeftFootHigh;
		ASStrideUpRightFootHigh = Setting.ASStrideUpRightFootHigh;
		ASStrideUpLeftFootFall = Setting.ASStrideUpLeftFootFall;
		ASStrideUpRightFootFall = Setting.ASStrideUpRightFootFall;
		ASStrideUpLeftFootEnd = Setting.ASStrideUpLeftFootEnd;
		ASStrideUpRightFootEnd = Setting.ASStrideUpRightFootEnd;
		ASStrideUpLeftFootLandMove = Setting.ASStrideUpLeftFootLandMove;
		ASStrideUpRightFootLandMove = Setting.ASStrideUpRightFootLandMove;
		ASStrideDownLeftFoot = Setting.ASStrideDownLeftFoot;
		ASStrideDownRightFoot = Setting.ASStrideDownRightFoot;
		ASStrideDownLeftFootFall = Setting.ASStrideDownLeftFootFall;
		ASStrideDownRightFootFall = Setting.ASStrideDownRightFootFall;
		ASStrideDownLeftFootEnd = Setting.ASStrideDownLeftFootEnd;
		ASStrideDownRightFootEnd = Setting.ASStrideDownRightFootEnd;
		ASStrideDownLeftFootLandMove = Setting.ASStrideDownLeftFootLandMove;
		ASStrideDownRightFootLandMove = Setting.ASStrideDownRightFootLandMove;
	}

	private void InitParkourMoveClimbSetting(in FAnimHumanoidSetting_ParkourMove_Climb Setting)
	{
		InitParkourMoveClimbLowSetting(in Setting.Low);
		InitParkourMoveClimbNormalSetting(in Setting.Normal);
		InitParkourMoveClimbHighSetting(in Setting.High);
	}

	private void InitParkourMoveAcrossSetting(in FAnimHumanoidSetting_ParkourMove_Across Setting)
	{
		InitParkourMoveAcrossLowSetting(in Setting.Low);
		InitParkourMoveAcrossNormalSetting(in Setting.Normal);
		InitParkourMoveAcrossHighSetting(in Setting.High);
	}

	private void InitParkourMoveClimbLowSetting(in FAnimHumanoidSetting_ParkourMove_Climb_Low Setting)
	{
		ASParkourLowClimbStart = Setting.ASParkourLowClimbStart;
		ASParkourLowClimbGetUp = Setting.ASParkourLowClimbGetUp;
		ASParkourLowClimbFallLoop = Setting.ASParkourLowClimbFallLoop;
		ASParkourLowClimbLand = Setting.ASParkourLowClimbLand;
		ASParkourLowClimbLandMove = Setting.ASParkourLowClimbLandMove;
	}

	private void InitParkourMoveClimbNormalSetting(in FAnimHumanoidSetting_ParkourMove_Climb_Normal Setting)
	{
		ASParkourNormalClimbStart = Setting.ASParkourNormalClimbStart;
		ASParkourNormalClimbGetUp = Setting.ASParkourNormalClimbGetUp;
		ASParkourNormalClimbFallLoop = Setting.ASParkourNormalClimbFallLoop;
		ASParkourNormalClimbLand = Setting.ASParkourNormalClimbLand;
		ASParkourNormalClimbLandMove = Setting.ASParkourNormalClimbLandMove;
	}

	private void InitParkourMoveClimbHighSetting(in FAnimHumanoidSetting_ParkourMove_Climb_High Setting)
	{
		ASParkourHighClimbStart = Setting.ASParkourHighClimbStart;
		ASParkourHighClimbGetUp = Setting.ASParkourHighClimbGetUp;
		ASParkourHighClimbFallLoop = Setting.ASParkourHighClimbFallLoop;
		ASParkourHighClimbLand = Setting.ASParkourHighClimbLand;
		ASParkourHighClimbLandMove = Setting.ASParkourHighClimbLandMove;
	}

	private void InitParkourMoveAcrossLowSetting(in FAnimHumanoidSetting_ParkourMove_Across_Low Setting)
	{
		ASParkourLowAcrossStart = Setting.ASParkourLowAcrossStart;
		ASParkourLowAcrossThrough = Setting.ASParkourLowAcrossThrough;
		ASParkourLowAcrossFallLoop = Setting.ASParkourLowAcrossFallLoop;
		ASParkourLowAcrossLand = Setting.ASParkourLowAcrossLand;
		ASParkourLowAcrossLandMove = Setting.ASParkourLowAcrossLandMove;
	}

	private void InitParkourMoveAcrossNormalSetting(in FAnimHumanoidSetting_ParkourMove_Across_Normal Setting)
	{
		ASParkourNormalAcrossStart = Setting.ASParkourNormalAcrossStart;
		ASParkourNormalAcrossThrough = Setting.ASParkourNormalAcrossThrough;
		ASParkourNormalAcrossFallLoop = Setting.ASParkourNormalAcrossFallLoop;
		ASParkourNormalAcrossLand = Setting.ASParkourNormalAcrossLand;
		ASParkourNormalAcrossLandMove = Setting.ASParkourNormalAcrossLandMove;
	}

	private void InitParkourMoveAcrossHighSetting(in FAnimHumanoidSetting_ParkourMove_Across_High Setting)
	{
		ASParkourHighAcrossStart = Setting.ASParkourHighAcrossStart;
		ASParkourHighAcrossThrough = Setting.ASParkourHighAcrossThrough;
		ASParkourHighAcrossFallLoop = Setting.ASParkourHighAcrossFallLoop;
		ASParkourHighAcrossLand = Setting.ASParkourHighAcrossLand;
		ASParkourHighAcrossLandMove = Setting.ASParkourHighAcrossLandMove;
	}

	protected override void LinkedGraphThreadUpdateAnimation(float DeltaTimeX)
	{
		UpdateData(DeltaTimeX);
	}

	private void InitBUCData()
	{
		if (!(Owner == null) && ECSExtension.IsECSActor(Owner))
		{
			JumpV2Data = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPJumpV2Data, BUC_ABPJumpV2Data>(Owner);
			CommonData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPCommonSettingData, BUC_ABPCommonSettingData>(Owner);
			BasicData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPBasicData, BUC_ABPBasicData>(Owner);
			ChrData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPCharacterData, BUC_ABPCharacterData>(Owner);
			SpecialMoveData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPSpecialMoveData, BUC_ABPSpecialMoveData>(Owner);
			SplineMoveData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPSplineMoveData, BUC_ABPSplineMoveData>(Owner);
			PlayerLocomotionData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPPlayerLocomotionData, BUC_ABPPlayerLocomotionData>(Owner);
			MonsterLocomotionData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPMonsterLocomotionData, BUC_ABPMonsterLocomotionData>(Owner);
			AdvancedMonsterLocomotionData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPAdvancedMonsterLocomotionData, BUC_ABPAdvancedMonsterLocomotionData>(Owner);
			CloudMoveData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPCloudLocomotionData, BUC_ABPCloudLocomotionData>(Owner);
			if (bEnableGlideAnim)
			{
				GlideMoveData = BGU_DataUtil.GetUnPersistentReadOnlyData<b1.IBUC_ABPGlideMoveData, BUC_ABPGlideMoveData>(Owner);
			}
			if (bEnableParkourAnim)
			{
				ParkourMoveData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPParkourMoveData, BUC_ABPParkourMoveData>(Owner);
			}
		}
	}

	private void InitData()
	{
		InitBUCData();
		if (JumpV2Data != null)
		{
			StartJumpDir = JumpV2Data.StartJumpDir;
			bIsJumpStartFast = JumpV2Data.bIsJumpStartFast;
			bHasFallAnimAsset = JumpV2Data.bHasFallAnimAsset;
			bIsLittleFall = JumpV2Data.bIsLittleFall;
			BSJumpStart_F = JumpV2Data.BS_jump_start_fwd;
			BSJumpStart_B = JumpV2Data.BS_jump_start_bwd;
			BSJumpLoop_F = JumpV2Data.BS_jump_loop_fwd;
			BSJumpLoop_B = JumpV2Data.BS_jump_loop_bwd;
			BSJumpAdditiveLean = JumpV2Data.BS_jump_additive_lean;
			BSJumpAdditiveRot = JumpV2Data.BS_jump_additive_rot;
			AnimGroundJumpStart = JumpV2Data.AnimGroundJumpStart;
			AnimGlideJumpStart = JumpV2Data.AnimGlideJumpStart;
			AnimFallStart = JumpV2Data.AnimFallStart;
			AnimFallLoop = JumpV2Data.AnimFallLoop;
			bIsInLandCantMoveTime = JumpV2Data.bIsInLandCantMoveTime;
			AddtiveMoveAfterJump_F = JumpV2Data.AddtiveMoveAfterJump_F;
			AddtiveMoveAfterJump_B = JumpV2Data.AddtiveMoveAfterJump_B;
			AddtiveMoveAfterJump_L = JumpV2Data.AddtiveMoveAfterJump_L;
			AddtiveMoveAfterJump_R = JumpV2Data.AddtiveMoveAfterJump_R;
			AnimJumpStart_N = JumpV2Data.AnimJumpStart_N;
			AnimJumpStart_F = JumpV2Data.AnimJumpStart_F;
			AnimJumpStart_L = JumpV2Data.AnimJumpStart_L;
			AnimJumpStart_R = JumpV2Data.AnimJumpStart_R;
			AnimJumpStart_B = JumpV2Data.AnimJumpStart_B;
			AnimFallStart_N = JumpV2Data.AnimFallStart_N;
			AnimFallStart_F = JumpV2Data.AnimFallStart_F;
			AnimFallStart_L = JumpV2Data.AnimFallStart_L;
			AnimFallStart_R = JumpV2Data.AnimFallStart_R;
			AnimFallStart_B = JumpV2Data.AnimFallStart_B;
			AnimLand_F_Low = JumpV2Data.AnimLand_F_Low;
			AnimLand_F_Mid = JumpV2Data.AnimLand_F_Mid;
			AnimLand_F_High = JumpV2Data.AnimLand_F_High;
			AnimLand_L = JumpV2Data.AnimLand_L;
			AnimLand_R = JumpV2Data.AnimLand_R;
			AnimLand_B = JumpV2Data.AnimLand_B;
			StartJumpSpdState = JumpV2Data.StartJumpSpdState;
			FallHeightType = JumpV2Data.FallHeightType;
			FallHeight = JumpV2Data.FallHeight;
		}
		if (CloudMoveData == null)
		{
			return;
		}
		if (CloudMoveData.CloudBreakAnimId >= 0 && (CloudMoveData.CloudBreakAnimSettings.TryGetValue(CloudMoveData.CloudBreakAnimId, out var value) || CloudMoveData.CloudBreakAnimSettings.TryGetValue(0, out value)))
		{
			if (CloudMoveData.bIsCloudFallInLowAirArea)
			{
				AnimCloudFallStart = value.CloudBreakAnimSetting_Low.AnimFallStart;
				AnimCloudFallLoop = value.CloudBreakAnimSetting_Low.AnimFallLoop;
			}
			else
			{
				AnimCloudFallStart = value.CloudBreakAnimSetting_High.AnimFallStart;
				AnimCloudFallLoop = value.CloudBreakAnimSetting_High.AnimFallLoop;
			}
		}
		else
		{
			UAnimSequence animCloudFallStart = (AnimCloudFallLoop = CloudMoveData.AnimCloudFallLoop);
			AnimCloudFallStart = animCloudFallStart;
		}
	}

	private void UpdateData(float DeltaTime)
	{
		bool flag = false;
		bool flag2 = false;
		EGlideSlopeType eGlideSlopeType = EGlideSlopeType.Flat;
		float num = 0f;
		float num2 = 0f;
		float num3 = 0f;
		FVector fVector = FVector.ZeroVector;
		if (ChrData != null)
		{
			bIsInAir = ChrData.IsFalling;
			bLeftFootFront = ChrData.IsLeftFootFront();
			fVector = ChrData.Velocity;
		}
		if (SpecialMoveData != null)
		{
			SpecialMovementMode = SpecialMoveData.SpecialMovementMode;
			LastSpecialMovementMode = SpecialMoveData.LastSpecialMovementMode;
		}
		if (GlideMoveData != null)
		{
			eGlideSlopeType = GlideMoveData.GlideSlopeType;
			_ = GlideMoveData.GlideMoveAnimState;
			num = GlideMoveData.GlideDirCosValue;
			GlideStartSpeedBlendAlpha = GlideMoveData.GlideStartSpeedBlendAlpha;
			GlideLoopDirAdditiveX = GlideMoveData.GlideDirAdditiveX;
			GlideLoopDirAdditiveY = GlideMoveData.GlideDirAdditiveY;
			BSGlideLoopFlatVerticalInputAdditiveY = GlideMoveData.GlideLoopInputAdditiveY;
			BSGlideLoopFlatHorizonalInputAdditiveX = GlideMoveData.GlideLoopInputAdditiveX;
			bGlideLoopRotationLeft = GlideMoveData.bGlideRotationLeft;
			bGlideLoopRotationRight = GlideMoveData.bGlideRotationRight;
			bGlideEndSlow = GlideMoveData.bGlideEndSlow;
			bGlideEndFast = !GlideMoveData.bGlideEndSlow;
		}
		if (BasicData != null)
		{
			bHasMoveInput = BasicData.bHasMoveInput;
			bHasPlayerInput = BasicData.bHasPlayerInput;
			flag = BasicData.bHasMoveInput && BasicData.Speed > 1f;
			Speed = BasicData.Speed;
			MappedSpeed = BasicData.GetMappedSpeed();
		}
		if (JumpV2Data != null)
		{
			StartJumpDir = JumpV2Data.StartJumpDir;
			bIsJumpStartFast = JumpV2Data.bIsJumpStartFast;
			bHasFallAnimAsset = JumpV2Data.bHasFallAnimAsset;
			bIsLittleFall = JumpV2Data.bIsLittleFall;
			bInJump = JumpV2Data.bInJump;
			flag2 = JumpV2Data.bFallByJump;
			VelocityDeltaAngle = JumpV2Data.VelocityDeltaAngle;
			VelocityDeltaAngleTrans = JumpV2Data.VelocityDeltaAngleTrans;
			bStride = JumpV2Data.JumpType == EJumpType.StrideJump && flag2;
			bToGroundJumpStart = bInJump && JumpV2Data.JumpType == EJumpType.Normal;
			bToGlideJumpStart = bInJump && JumpV2Data.JumpType == EJumpType.GlideJump;
			bStrideJump = bInJump && bStride;
			AnimGroundJumpStart = JumpV2Data.AnimGroundJumpStart;
			AnimFallStart = JumpV2Data.AnimFallStart;
			bIsInLandCantMoveTime = JumpV2Data.bIsInLandCantMoveTime;
			AdditiveMoveAfterJumpFAlpha = JumpV2Data.AdditiveMoveAfterJumpFAlpha;
			AdditiveMoveAfterJumpBAlpha = JumpV2Data.AdditiveMoveAfterJumpBAlpha;
			AdditiveMoveAfterJumpLAlpha = JumpV2Data.AdditiveMoveAfterJumpLAlpha;
			AdditiveMoveAfterJumpRAlpha = JumpV2Data.AdditiveMoveAfterJumpRAlpha;
			StartJumpSpdState = JumpV2Data.StartJumpSpdState;
			FallHeightType = JumpV2Data.FallHeightType;
			FallHeight = JumpV2Data.FallHeight;
		}
		if (ParkourMoveData != null)
		{
			bParkourClimb = ParkourMoveData.CurParkourProcessType == EParkourProcessType.Climb;
			bParkourAcross = ParkourMoveData.CurParkourProcessType == EParkourProcessType.Across;
			bParkourLow = ParkourMoveData.CurParkourHeightType == EParkourHeightType.Low;
			bParkourNormal = ParkourMoveData.CurParkourHeightType == EParkourHeightType.Normal;
			bParkourHigh = ParkourMoveData.CurParkourHeightType == EParkourHeightType.High;
			_ = ParkourMoveData.bParkourLandCanMove;
			bToStride = bParkourClimb || bParkourAcross;
			bStrideContinue = ParkourMoveData.bParkourContinue;
			num2 = ParkourMoveData.StrideHeight;
		}
		if (SplineMoveData != null)
		{
			bSplineMoveForward = SplineMoveData.bSplineMoveForward;
			bSplineMoveSharpturn = SplineMoveData.bSplineMoveInSharpturn;
			bSplineMoveReSharpturn = SplineMoveData.bSplineMoveShouldSharpturn;
			bSplineMoveCanExitSharpturn = SplineMoveData.SharpturnAngle == 0f;
			num3 = SplineMoveData.SplineMoveStopTimer;
			SharpturnAngle = SplineMoveData.SharpturnAngle;
		}
		if (PlayerLocomotionData != null)
		{
			bLockMoveJumpF = PlayerLocomotionData.LockMoveDirection == ELockMoveDirectionSix.F;
			bLockMoveJumpFL = PlayerLocomotionData.LockMoveDirection == ELockMoveDirectionSix.FL;
			bLockMoveJumpFR = PlayerLocomotionData.LockMoveDirection == ELockMoveDirectionSix.FR;
			bLockMoveJumpBL = PlayerLocomotionData.LockMoveDirection == ELockMoveDirectionSix.BL;
			bLockMoveJumpBR = PlayerLocomotionData.LockMoveDirection == ELockMoveDirectionSix.BR;
			bLockMoveJumpB = PlayerLocomotionData.LockMoveDirection == ELockMoveDirectionSix.B;
			MaxAnimWeightLockMoveDir = PlayerLocomotionData.MaxAnimWeightLockMoveDir;
		}
		if (CommonData != null)
		{
			switch (CommonData.FinalABPMoveMode)
			{
			case EABPMoveMode.PlayerLocomotion:
				if (PlayerLocomotionData != null)
				{
					bSwitchToLock = PlayerLocomotionData.bSwitchToLock;
				}
				break;
			case EABPMoveMode.MonsterLocomotion:
				if (MonsterLocomotionData != null)
				{
					bSwitchToLock = MonsterLocomotionData.bSwitchToLock;
				}
				break;
			case EABPMoveMode.AdvancedMonsterLocomotion:
				if (AdvancedMonsterLocomotionData != null)
				{
					bSwitchToLock = AdvancedMonsterLocomotionData.bSwitchToLock;
				}
				break;
			}
		}
		if (CloudMoveData != null && bIsInAir)
		{
			bCloudFall = CloudMoveData.bCloudFall;
			if (CloudMoveData.CloudBreakAnimId >= 0 && (CloudMoveData.CloudBreakAnimSettings.TryGetValue(CloudMoveData.CloudBreakAnimId, out var value) || CloudMoveData.CloudBreakAnimSettings.TryGetValue(0, out value)))
			{
				if (CloudMoveData.bIsCloudFallInLowAirArea)
				{
					AnimCloudFallStart = value.CloudBreakAnimSetting_Low.AnimFallStart;
					AnimCloudFallLoop = value.CloudBreakAnimSetting_Low.AnimFallLoop;
				}
				else
				{
					AnimCloudFallStart = value.CloudBreakAnimSetting_High.AnimFallStart;
					AnimCloudFallLoop = value.CloudBreakAnimSetting_High.AnimFallLoop;
				}
			}
			else
			{
				UAnimSequence animCloudFallStart = (AnimCloudFallLoop = CloudMoveData.AnimCloudFallLoop);
				AnimCloudFallStart = animCloudFallStart;
			}
		}
		bGroundMoving = SpecialMovementMode == ESpecialMovementMode.GroundMove || SpecialMovementMode == ESpecialMovementMode.FlyMove;
		bGlideMoving = SpecialMovementMode == ESpecialMovementMode.GlideMove;
		bParkourMoving = SpecialMovementMode == ESpecialMovementMode.ParkourMove;
		bSplineMoving = SpecialMovementMode == ESpecialMovementMode.SplineMove;
		bGlideFlat = eGlideSlopeType == EGlideSlopeType.Flat;
		bGlideSteep = eGlideSlopeType == EGlideSlopeType.Steep;
		bGlideStartFront = num <= 0f;
		bGlideStartBack = num > 0f;
		bSplineMoveStopToStart = bHasMoveInput && num3 >= 0.2f;
		bSplineMoveStopToLoop = bHasMoveInput && num3 < 0.2f;
		if (!bAirStartGlide)
		{
			bAirStartGlide = bGlideMoving && LastSpecialMovementMode == ESpecialMovementMode.AirMove;
		}
		if (!bGlideMoving)
		{
			bAirStartGlide = false;
		}
		if (SpecialMovementMode == ESpecialMovementMode.AirMove)
		{
			bParkourFall = LastSpecialMovementMode == ESpecialMovementMode.ParkourMove;
		}
		bGlideEndToGroundMove = flag;
		bToFall = !bInJump && bIsInAir && bHasFallAnimAsset && (!bIsLittleFall || LastSpecialMovementMode == ESpecialMovementMode.GlideMove);
		bLeaveGlideMoving = !bGroundMoving && !bGlideMoving;
		bAirMoving = bInJump || bToFall;
		bStrideUp = bStride && num2 > 0f;
		bStrideDown = bStride && num2 <= 0f;
		bStrideUpJump = bStrideJump && num2 > 0f;
		bStrideDownJump = bStrideJump && num2 <= 0f;
		bStrideUpLand = bStrideUp && (int)FallHeightType <= 1;
		bStrideDownLand = bStrideDown && (int)FallHeightType <= 1;
		bStrideUpHigh = bStrideUp && num2 >= 75f;
		bStrideUpLow = bStrideUp && num2 < 75f;
		bToLandAnim = !bInJump && !bIsInAir;
		bToLandMove = (!bInJump && !bIsInAir && (bHasPlayerInput || bHasMoveInput)) || !bGroundMoving;
		bLandAnimToGround = (!bIsInLandCantMoveTime && (bHasPlayerInput || bHasMoveInput)) || !bGroundMoving;
		if (fVector.Z < -50f)
		{
			LandAdditiveAlpha = FMath.GetMappedRangeValueClamped(LandAdditiveAlphaInput, CommonAlphaOutput, fVector.Z);
			bToLandAdditive = true;
		}
		if (bSwitchToLock)
		{
			if (MaxAnimWeightLockMoveDir != ELockMoveDirectionSix.None)
			{
				JumpMoveDir = MaxAnimWeightLockMoveDir;
			}
		}
		else
		{
			JumpMoveDir = ELockMoveDirectionSix.F;
		}
		bToGroundJumpStartFwd = JumpMoveDir == ELockMoveDirectionSix.F || JumpMoveDir == ELockMoveDirectionSix.FL || JumpMoveDir == ELockMoveDirectionSix.FR;
		bToGroundJumpStartBwd = JumpMoveDir == ELockMoveDirectionSix.B || JumpMoveDir == ELockMoveDirectionSix.BL || JumpMoveDir == ELockMoveDirectionSix.BR;
	}

	[BlueprintCallable]
	[UFunction]
	[Category("Thread Safe")]
	[UMeta(MDClass.BlueprintThreadSafe)]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:UpdateGroundJump")]
	private void UpdateGroundJump(ref FAnimUpdateContext Context, ref FAnimNodeReference Node)
	{
		UpdateLandPrediction();
		UpdateJumpAdditive();
	}

	private void UpdateLandPrediction()
	{
		LandPredictionAlpha = 0f;
		FVector fVector = FVector.ZeroVector;
		FVector fVector2 = FVector.ZeroVector;
		float halfHeight = 0f;
		float radius = 0f;
		UCharacterMovementComponent uCharacterMovementComponent = null;
		if (ChrData != null)
		{
			fVector = ChrData.Velocity;
			fVector2 = ChrData.ActorLocation;
			halfHeight = ChrData.ScaledCapsuleHalfHeight;
			radius = ChrData.ScaledCapsuleRadius;
			uCharacterMovementComponent = ChrData.MovementComp;
		}
		if (!(fVector.Z >= -100f))
		{
			FVector fVector3 = fVector;
			fVector3.Z = FMath.Clamp(fVector3.Z, -4000f, -100f);
			fVector3.Normalize();
			fVector3 *= (double)FMath.GetMappedRangeValueClamped(LandPredictionTraceOffsetInput, LandPredictionTraceOffsetOutput, fVector.Z);
			USystemLibrary.CapsuleTraceSingleByProfile(Owner, fVector2, fVector2 + fVector3, radius, halfHeight, B1GlobalFNames.Pawn, bTraceComplex: false, new List<AActor>(), EDrawDebugTrace.None, out var OutHit, bIgnoreSelf: true, FLinearColor.Red, FLinearColor.Blue, 0f);
			if (OutHit.BlockingHit && uCharacterMovementComponent.IsWalkable(OutHit))
			{
				LandPredictionAlpha = OutHit.Time;
			}
		}
	}

	private void UpdateJumpAdditive()
	{
		if (JumpV2Data != null)
		{
			FVector2D localInput2D = JumpV2Data.LocalInput2D;
			FVector2D velocityBlend = JumpV2Data.VelocityBlend;
			BSJumpAdditiveLeanX = localInput2D.Y;
			BSJumpAdditiveLeanY = localInput2D.X;
			BSJumpAdditiveRotX = localInput2D.Y - velocityBlend.Y;
			BSJumpAdditiveRotY = localInput2D.X - velocityBlend.X;
		}
	}

	[UFunction]
	[UMeta(MDClass.BlueprintThreadSafe)]
	[Category("Thread Safe")]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:UpdateGroundAdditive")]
	private void UpdateGroundAdditive(ref FAnimUpdateContext Context, ref FAnimNodeReference Node)
	{
		bToLandAdditive = false;
	}

	[Category("Thread Safe")]
	[UMeta(MDClass.BlueprintThreadSafe)]
	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:SetupLandAnim")]
	private void SetupLandAnim(ref FAnimUpdateContext Context, ref FAnimNodeReference Node)
	{
		USequencePlayerLibrary.ConvertToSequencePlayerPure(Node, out var SequencePlayer, out var Result);
		if (!Result)
		{
			return;
		}
		UAnimSequence sequence = AnimLand_F_Low;
		if (StartJumpDir != ESkillDirection.None)
		{
			if (JumpMoveDir == ELockMoveDirectionSix.None || JumpMoveDir == ELockMoveDirectionSix.F)
			{
				switch (FallHeightType)
				{
				case EFallHeightType_V2.FallHeight_Mid:
					sequence = AnimLand_F_Mid;
					break;
				case EFallHeightType_V2.FallHeight_High:
					sequence = AnimLand_F_High;
					break;
				case EFallHeightType_V2.FallHeight_Dead:
					sequence = null;
					break;
				}
			}
			else
			{
				switch (JumpMoveDir)
				{
				case ELockMoveDirectionSix.FL:
					sequence = AnimLand_L;
					break;
				case ELockMoveDirectionSix.FR:
					sequence = AnimLand_R;
					break;
				case ELockMoveDirectionSix.BL:
				case ELockMoveDirectionSix.BR:
				case ELockMoveDirectionSix.B:
					sequence = AnimLand_B;
					break;
				}
			}
		}
		USequencePlayerLibrary.SetSequence(SequencePlayer, sequence);
	}

	[UFunction]
	[BlueprintPure]
	[UMeta(MDClass.BlueprintThreadSafe)]
	[Category("Thread Safe")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:GetAnimCloudLand")]
	private void GetAnimCloudLand(out UAnimSequence AnimCloudLand)
	{
		AnimCloudLand = null;
		if (CloudMoveData == null)
		{
			return;
		}
		if (CloudMoveData.CloudBreakAnimId >= 0 && (CloudMoveData.CloudBreakAnimSettings.TryGetValue(CloudMoveData.CloudBreakAnimId, out var value) || CloudMoveData.CloudBreakAnimSettings.TryGetValue(0, out value)))
		{
			AnimCloudLand = (CloudMoveData.bIsCloudFallInLowAirArea ? value.CloudBreakAnimSetting_Low.LandSetting.AnimSeq_Land : value.CloudBreakAnimSetting_High.LandSetting.AnimSeq_Land);
			return;
		}
		switch (FallHeightType)
		{
		case EFallHeightType_V2.FallHeight_Little:
		case EFallHeightType_V2.FallHeight_Low:
		case EFallHeightType_V2.FallHeight_Mid:
			AnimCloudLand = CloudMoveData.CloudLand_Low.AnimSeq_Land;
			break;
		case EFallHeightType_V2.FallHeight_High:
			AnimCloudLand = CloudMoveData.CloudLand_High.AnimSeq_Land;
			break;
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:SetupLandAnim")]
	private static void SetupLandAnim__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_SpecialMove bUAnimHumanoidCS_SpecialMove = GCHelper.Find<BUAnimHumanoidCS_SpecialMove>(obj);
		FAnimUpdateContext Context = StructAsClassMarshaler<FAnimUpdateContext>.FromNative(IntPtr.Add(buffer, SetupLandAnim_Context_Offset));
		FAnimNodeReference Node = StructAsClassMarshaler<FAnimNodeReference>.FromNative(IntPtr.Add(buffer, SetupLandAnim_Node_Offset));
		bUAnimHumanoidCS_SpecialMove.SetupLandAnim(ref Context, ref Node);
		StructAsClassMarshaler<FAnimUpdateContext>.ToNative(IntPtr.Add(buffer, SetupLandAnim_Context_Offset), Context);
		StructAsClassMarshaler<FAnimNodeReference>.ToNative(IntPtr.Add(buffer, SetupLandAnim_Node_Offset), Node);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:GetAnimCloudLand")]
	private static void GetAnimCloudLand__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_SpecialMove bUAnimHumanoidCS_SpecialMove = GCHelper.Find<BUAnimHumanoidCS_SpecialMove>(obj);
		bUAnimHumanoidCS_SpecialMove.GetAnimCloudLand(out var AnimCloudLand);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(buffer, GetAnimCloudLand_AnimCloudLand_Offset), AnimCloudLand);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:UpdateGroundJump")]
	private static void UpdateGroundJump__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_SpecialMove bUAnimHumanoidCS_SpecialMove = GCHelper.Find<BUAnimHumanoidCS_SpecialMove>(obj);
		FAnimUpdateContext Context = StructAsClassMarshaler<FAnimUpdateContext>.FromNative(IntPtr.Add(buffer, UpdateGroundJump_Context_Offset));
		FAnimNodeReference Node = StructAsClassMarshaler<FAnimNodeReference>.FromNative(IntPtr.Add(buffer, UpdateGroundJump_Node_Offset));
		bUAnimHumanoidCS_SpecialMove.UpdateGroundJump(ref Context, ref Node);
		StructAsClassMarshaler<FAnimUpdateContext>.ToNative(IntPtr.Add(buffer, UpdateGroundJump_Context_Offset), Context);
		StructAsClassMarshaler<FAnimNodeReference>.ToNative(IntPtr.Add(buffer, UpdateGroundJump_Node_Offset), Node);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:UpdateGroundAdditive")]
	private static void UpdateGroundAdditive__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_SpecialMove bUAnimHumanoidCS_SpecialMove = GCHelper.Find<BUAnimHumanoidCS_SpecialMove>(obj);
		FAnimUpdateContext Context = StructAsClassMarshaler<FAnimUpdateContext>.FromNative(IntPtr.Add(buffer, UpdateGroundAdditive_Context_Offset));
		FAnimNodeReference Node = StructAsClassMarshaler<FAnimNodeReference>.FromNative(IntPtr.Add(buffer, UpdateGroundAdditive_Node_Offset));
		bUAnimHumanoidCS_SpecialMove.UpdateGroundAdditive(ref Context, ref Node);
		StructAsClassMarshaler<FAnimUpdateContext>.ToNative(IntPtr.Add(buffer, UpdateGroundAdditive_Context_Offset), Context);
		StructAsClassMarshaler<FAnimNodeReference>.ToNative(IntPtr.Add(buffer, UpdateGroundAdditive_Node_Offset), Node);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove");
		NativeReflection.GetPropertyRef(ref bHasMoveInput_PropertyAddress, intPtr, "bHasMoveInput");
		bHasMoveInput_Offset = NativeReflection.GetPropertyOffset(intPtr, "bHasMoveInput");
		bHasMoveInput_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bHasMoveInput", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bHasPlayerInput_PropertyAddress, intPtr, "bHasPlayerInput");
		bHasPlayerInput_Offset = NativeReflection.GetPropertyOffset(intPtr, "bHasPlayerInput");
		bHasPlayerInput_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bHasPlayerInput", Classes.FBoolProperty);
		Speed_Offset = NativeReflection.GetPropertyOffset(intPtr, "Speed");
		Speed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Speed", Classes.FFloatProperty);
		MappedSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "MappedSpeed");
		MappedSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MappedSpeed", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref SpecialMovementMode_PropertyAddress, intPtr, "SpecialMovementMode");
		SpecialMovementMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpecialMovementMode");
		SpecialMovementMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpecialMovementMode", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref LastSpecialMovementMode_PropertyAddress, intPtr, "LastSpecialMovementMode");
		LastSpecialMovementMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "LastSpecialMovementMode");
		LastSpecialMovementMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LastSpecialMovementMode", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref bGroundMoving_PropertyAddress, intPtr, "bGroundMoving");
		bGroundMoving_Offset = NativeReflection.GetPropertyOffset(intPtr, "bGroundMoving");
		bGroundMoving_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bGroundMoving", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref MaxAnimWeightLockMoveDir_PropertyAddress, intPtr, "MaxAnimWeightLockMoveDir");
		MaxAnimWeightLockMoveDir_Offset = NativeReflection.GetPropertyOffset(intPtr, "MaxAnimWeightLockMoveDir");
		MaxAnimWeightLockMoveDir_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MaxAnimWeightLockMoveDir", Classes.FEnumProperty);
		ASGlideStartGroundFlatSlow_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASGlideStartGroundFlatSlow");
		ASGlideStartGroundFlatSlow_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASGlideStartGroundFlatSlow", Classes.FObjectProperty);
		ASGlideStartGroundFlatFast_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASGlideStartGroundFlatFast");
		ASGlideStartGroundFlatFast_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASGlideStartGroundFlatFast", Classes.FObjectProperty);
		ASGlideStartGroundSteepSlow_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASGlideStartGroundSteepSlow");
		ASGlideStartGroundSteepSlow_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASGlideStartGroundSteepSlow", Classes.FObjectProperty);
		ASGlideStartGroundSteepFast_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASGlideStartGroundSteepFast");
		ASGlideStartGroundSteepFast_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASGlideStartGroundSteepFast", Classes.FObjectProperty);
		ASGlideStartAirFlatSlow_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASGlideStartAirFlatSlow");
		ASGlideStartAirFlatSlow_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASGlideStartAirFlatSlow", Classes.FObjectProperty);
		ASGlideStartAirFlatFast_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASGlideStartAirFlatFast");
		ASGlideStartAirFlatFast_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASGlideStartAirFlatFast", Classes.FObjectProperty);
		ASGlideStartAirSteepSlow_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASGlideStartAirSteepSlow");
		ASGlideStartAirSteepSlow_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASGlideStartAirSteepSlow", Classes.FObjectProperty);
		ASGlideStartAirSteepFast_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASGlideStartAirSteepFast");
		ASGlideStartAirSteepFast_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASGlideStartAirSteepFast", Classes.FObjectProperty);
		ASGlideStartBackAirFlat_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASGlideStartBackAirFlat");
		ASGlideStartBackAirFlat_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASGlideStartBackAirFlat", Classes.FObjectProperty);
		ASGlideStartBackAirSteep_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASGlideStartBackAirSteep");
		ASGlideStartBackAirSteep_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASGlideStartBackAirSteep", Classes.FObjectProperty);
		GlideStartSpeedBlendAlpha_Offset = NativeReflection.GetPropertyOffset(intPtr, "GlideStartSpeedBlendAlpha");
		GlideStartSpeedBlendAlpha_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GlideStartSpeedBlendAlpha", Classes.FFloatProperty);
		ASGlideLoopSteep_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASGlideLoopSteep");
		ASGlideLoopSteep_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASGlideLoopSteep", Classes.FObjectProperty);
		BSGlideLoopSteepAdditive_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSGlideLoopSteepAdditive");
		BSGlideLoopSteepAdditive_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSGlideLoopSteepAdditive", Classes.FObjectProperty);
		ASGlideLoopFlatSlow_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASGlideLoopFlatSlow");
		ASGlideLoopFlatSlow_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASGlideLoopFlatSlow", Classes.FObjectProperty);
		ASGlideLoopFlatFast_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASGlideLoopFlatFast");
		ASGlideLoopFlatFast_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASGlideLoopFlatFast", Classes.FObjectProperty);
		BSGlideLoopFlatSlowDirAdditive_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSGlideLoopFlatSlowDirAdditive");
		BSGlideLoopFlatSlowDirAdditive_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSGlideLoopFlatSlowDirAdditive", Classes.FObjectProperty);
		BSGlideLoopFlatFastDirAdditive_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSGlideLoopFlatFastDirAdditive");
		BSGlideLoopFlatFastDirAdditive_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSGlideLoopFlatFastDirAdditive", Classes.FObjectProperty);
		GlideLoopDirAdditiveX_Offset = NativeReflection.GetPropertyOffset(intPtr, "GlideLoopDirAdditiveX");
		GlideLoopDirAdditiveX_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GlideLoopDirAdditiveX", Classes.FFloatProperty);
		GlideLoopDirAdditiveY_Offset = NativeReflection.GetPropertyOffset(intPtr, "GlideLoopDirAdditiveY");
		GlideLoopDirAdditiveY_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GlideLoopDirAdditiveY", Classes.FFloatProperty);
		BSGlideLoopFlatVerticalInputAdditive_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSGlideLoopFlatVerticalInputAdditive");
		BSGlideLoopFlatVerticalInputAdditive_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSGlideLoopFlatVerticalInputAdditive", Classes.FObjectProperty);
		BSGlideLoopFlatVerticalInputAdditiveY_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSGlideLoopFlatVerticalInputAdditiveY");
		BSGlideLoopFlatVerticalInputAdditiveY_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSGlideLoopFlatVerticalInputAdditiveY", Classes.FFloatProperty);
		GlideLoopSpeedBlendAlpha_Offset = NativeReflection.GetPropertyOffset(intPtr, "GlideLoopSpeedBlendAlpha");
		GlideLoopSpeedBlendAlpha_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GlideLoopSpeedBlendAlpha", Classes.FFloatProperty);
		BSGlideLoopFlatHorizonalInputAdditive_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSGlideLoopFlatHorizonalInputAdditive");
		BSGlideLoopFlatHorizonalInputAdditive_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSGlideLoopFlatHorizonalInputAdditive", Classes.FObjectProperty);
		BSGlideLoopFlatHorizonalInputAdditiveX_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSGlideLoopFlatHorizonalInputAdditiveX");
		BSGlideLoopFlatHorizonalInputAdditiveX_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSGlideLoopFlatHorizonalInputAdditiveX", Classes.FFloatProperty);
		ASGlideLoopFlatRotationLeftAdditive_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASGlideLoopFlatRotationLeftAdditive");
		ASGlideLoopFlatRotationLeftAdditive_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASGlideLoopFlatRotationLeftAdditive", Classes.FObjectProperty);
		ASGlideLoopFlatRotationRightAdditive_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASGlideLoopFlatRotationRightAdditive");
		ASGlideLoopFlatRotationRightAdditive_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASGlideLoopFlatRotationRightAdditive", Classes.FObjectProperty);
		ASGlideEndSlow_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASGlideEndSlow");
		ASGlideEndSlow_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASGlideEndSlow", Classes.FObjectProperty);
		ASGlideEndFast_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASGlideEndFast");
		ASGlideEndFast_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASGlideEndFast", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref bGlideMoving_PropertyAddress, intPtr, "bGlideMoving");
		bGlideMoving_Offset = NativeReflection.GetPropertyOffset(intPtr, "bGlideMoving");
		bGlideMoving_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bGlideMoving", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bParkourMoving_PropertyAddress, intPtr, "bParkourMoving");
		bParkourMoving_Offset = NativeReflection.GetPropertyOffset(intPtr, "bParkourMoving");
		bParkourMoving_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bParkourMoving", Classes.FBoolProperty);
		ASParkourLowClimbStart_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASParkourLowClimbStart");
		ASParkourLowClimbStart_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASParkourLowClimbStart", Classes.FObjectProperty);
		ASParkourLowClimbGetUp_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASParkourLowClimbGetUp");
		ASParkourLowClimbGetUp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASParkourLowClimbGetUp", Classes.FObjectProperty);
		ASParkourLowClimbFallLoop_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASParkourLowClimbFallLoop");
		ASParkourLowClimbFallLoop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASParkourLowClimbFallLoop", Classes.FObjectProperty);
		ASParkourLowClimbLand_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASParkourLowClimbLand");
		ASParkourLowClimbLand_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASParkourLowClimbLand", Classes.FObjectProperty);
		ASParkourLowClimbLandMove_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASParkourLowClimbLandMove");
		ASParkourLowClimbLandMove_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASParkourLowClimbLandMove", Classes.FObjectProperty);
		ASParkourNormalClimbStart_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASParkourNormalClimbStart");
		ASParkourNormalClimbStart_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASParkourNormalClimbStart", Classes.FObjectProperty);
		ASParkourNormalClimbGetUp_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASParkourNormalClimbGetUp");
		ASParkourNormalClimbGetUp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASParkourNormalClimbGetUp", Classes.FObjectProperty);
		ASParkourNormalClimbFallLoop_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASParkourNormalClimbFallLoop");
		ASParkourNormalClimbFallLoop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASParkourNormalClimbFallLoop", Classes.FObjectProperty);
		ASParkourNormalClimbLand_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASParkourNormalClimbLand");
		ASParkourNormalClimbLand_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASParkourNormalClimbLand", Classes.FObjectProperty);
		ASParkourNormalClimbLandMove_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASParkourNormalClimbLandMove");
		ASParkourNormalClimbLandMove_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASParkourNormalClimbLandMove", Classes.FObjectProperty);
		ASParkourHighClimbStart_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASParkourHighClimbStart");
		ASParkourHighClimbStart_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASParkourHighClimbStart", Classes.FObjectProperty);
		ASParkourHighClimbGetUp_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASParkourHighClimbGetUp");
		ASParkourHighClimbGetUp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASParkourHighClimbGetUp", Classes.FObjectProperty);
		ASParkourHighClimbFallLoop_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASParkourHighClimbFallLoop");
		ASParkourHighClimbFallLoop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASParkourHighClimbFallLoop", Classes.FObjectProperty);
		ASParkourHighClimbLand_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASParkourHighClimbLand");
		ASParkourHighClimbLand_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASParkourHighClimbLand", Classes.FObjectProperty);
		ASParkourHighClimbLandMove_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASParkourHighClimbLandMove");
		ASParkourHighClimbLandMove_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASParkourHighClimbLandMove", Classes.FObjectProperty);
		ASParkourLowAcrossStart_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASParkourLowAcrossStart");
		ASParkourLowAcrossStart_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASParkourLowAcrossStart", Classes.FObjectProperty);
		ASParkourLowAcrossThrough_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASParkourLowAcrossThrough");
		ASParkourLowAcrossThrough_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASParkourLowAcrossThrough", Classes.FObjectProperty);
		ASParkourLowAcrossFallLoop_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASParkourLowAcrossFallLoop");
		ASParkourLowAcrossFallLoop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASParkourLowAcrossFallLoop", Classes.FObjectProperty);
		ASParkourLowAcrossLand_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASParkourLowAcrossLand");
		ASParkourLowAcrossLand_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASParkourLowAcrossLand", Classes.FObjectProperty);
		ASParkourLowAcrossLandMove_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASParkourLowAcrossLandMove");
		ASParkourLowAcrossLandMove_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASParkourLowAcrossLandMove", Classes.FObjectProperty);
		ASParkourNormalAcrossStart_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASParkourNormalAcrossStart");
		ASParkourNormalAcrossStart_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASParkourNormalAcrossStart", Classes.FObjectProperty);
		ASParkourNormalAcrossThrough_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASParkourNormalAcrossThrough");
		ASParkourNormalAcrossThrough_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASParkourNormalAcrossThrough", Classes.FObjectProperty);
		ASParkourNormalAcrossFallLoop_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASParkourNormalAcrossFallLoop");
		ASParkourNormalAcrossFallLoop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASParkourNormalAcrossFallLoop", Classes.FObjectProperty);
		ASParkourNormalAcrossLand_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASParkourNormalAcrossLand");
		ASParkourNormalAcrossLand_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASParkourNormalAcrossLand", Classes.FObjectProperty);
		ASParkourNormalAcrossLandMove_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASParkourNormalAcrossLandMove");
		ASParkourNormalAcrossLandMove_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASParkourNormalAcrossLandMove", Classes.FObjectProperty);
		ASParkourHighAcrossStart_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASParkourHighAcrossStart");
		ASParkourHighAcrossStart_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASParkourHighAcrossStart", Classes.FObjectProperty);
		ASParkourHighAcrossThrough_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASParkourHighAcrossThrough");
		ASParkourHighAcrossThrough_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASParkourHighAcrossThrough", Classes.FObjectProperty);
		ASParkourHighAcrossFallLoop_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASParkourHighAcrossFallLoop");
		ASParkourHighAcrossFallLoop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASParkourHighAcrossFallLoop", Classes.FObjectProperty);
		ASParkourHighAcrossLand_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASParkourHighAcrossLand");
		ASParkourHighAcrossLand_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASParkourHighAcrossLand", Classes.FObjectProperty);
		ASParkourHighAcrossLandMove_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASParkourHighAcrossLandMove");
		ASParkourHighAcrossLandMove_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASParkourHighAcrossLandMove", Classes.FObjectProperty);
		ASStrideUpLeftFootLow_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASStrideUpLeftFootLow");
		ASStrideUpLeftFootLow_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASStrideUpLeftFootLow", Classes.FObjectProperty);
		ASStrideUpRightFootLow_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASStrideUpRightFootLow");
		ASStrideUpRightFootLow_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASStrideUpRightFootLow", Classes.FObjectProperty);
		ASStrideUpLeftFootHigh_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASStrideUpLeftFootHigh");
		ASStrideUpLeftFootHigh_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASStrideUpLeftFootHigh", Classes.FObjectProperty);
		ASStrideUpRightFootHigh_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASStrideUpRightFootHigh");
		ASStrideUpRightFootHigh_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASStrideUpRightFootHigh", Classes.FObjectProperty);
		ASStrideUpLeftFootFall_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASStrideUpLeftFootFall");
		ASStrideUpLeftFootFall_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASStrideUpLeftFootFall", Classes.FObjectProperty);
		ASStrideUpRightFootFall_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASStrideUpRightFootFall");
		ASStrideUpRightFootFall_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASStrideUpRightFootFall", Classes.FObjectProperty);
		ASStrideUpLeftFootEnd_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASStrideUpLeftFootEnd");
		ASStrideUpLeftFootEnd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASStrideUpLeftFootEnd", Classes.FObjectProperty);
		ASStrideUpRightFootEnd_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASStrideUpRightFootEnd");
		ASStrideUpRightFootEnd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASStrideUpRightFootEnd", Classes.FObjectProperty);
		ASStrideUpLeftFootLandMove_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASStrideUpLeftFootLandMove");
		ASStrideUpLeftFootLandMove_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASStrideUpLeftFootLandMove", Classes.FObjectProperty);
		ASStrideUpRightFootLandMove_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASStrideUpRightFootLandMove");
		ASStrideUpRightFootLandMove_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASStrideUpRightFootLandMove", Classes.FObjectProperty);
		ASStrideDownLeftFoot_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASStrideDownLeftFoot");
		ASStrideDownLeftFoot_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASStrideDownLeftFoot", Classes.FObjectProperty);
		ASStrideDownRightFoot_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASStrideDownRightFoot");
		ASStrideDownRightFoot_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASStrideDownRightFoot", Classes.FObjectProperty);
		ASStrideDownLeftFootFall_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASStrideDownLeftFootFall");
		ASStrideDownLeftFootFall_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASStrideDownLeftFootFall", Classes.FObjectProperty);
		ASStrideDownRightFootFall_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASStrideDownRightFootFall");
		ASStrideDownRightFootFall_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASStrideDownRightFootFall", Classes.FObjectProperty);
		ASStrideDownLeftFootEnd_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASStrideDownLeftFootEnd");
		ASStrideDownLeftFootEnd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASStrideDownLeftFootEnd", Classes.FObjectProperty);
		ASStrideDownRightFootEnd_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASStrideDownRightFootEnd");
		ASStrideDownRightFootEnd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASStrideDownRightFootEnd", Classes.FObjectProperty);
		ASStrideDownLeftFootLandMove_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASStrideDownLeftFootLandMove");
		ASStrideDownLeftFootLandMove_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASStrideDownLeftFootLandMove", Classes.FObjectProperty);
		ASStrideDownRightFootLandMove_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASStrideDownRightFootLandMove");
		ASStrideDownRightFootLandMove_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASStrideDownRightFootLandMove", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref bIsInAir_PropertyAddress, intPtr, "bIsInAir");
		bIsInAir_Offset = NativeReflection.GetPropertyOffset(intPtr, "bIsInAir");
		bIsInAir_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bIsInAir", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bAirMoving_PropertyAddress, intPtr, "bAirMoving");
		bAirMoving_Offset = NativeReflection.GetPropertyOffset(intPtr, "bAirMoving");
		bAirMoving_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bAirMoving", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref StartJumpDir_PropertyAddress, intPtr, "StartJumpDir");
		StartJumpDir_Offset = NativeReflection.GetPropertyOffset(intPtr, "StartJumpDir");
		StartJumpDir_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StartJumpDir", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref bIsJumpStartFast_PropertyAddress, intPtr, "bIsJumpStartFast");
		bIsJumpStartFast_Offset = NativeReflection.GetPropertyOffset(intPtr, "bIsJumpStartFast");
		bIsJumpStartFast_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bIsJumpStartFast", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bInJump_PropertyAddress, intPtr, "bInJump");
		bInJump_Offset = NativeReflection.GetPropertyOffset(intPtr, "bInJump");
		bInJump_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bInJump", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bIsLittleFall_PropertyAddress, intPtr, "bIsLittleFall");
		bIsLittleFall_Offset = NativeReflection.GetPropertyOffset(intPtr, "bIsLittleFall");
		bIsLittleFall_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bIsLittleFall", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bHasFallAnimAsset_PropertyAddress, intPtr, "bHasFallAnimAsset");
		bHasFallAnimAsset_Offset = NativeReflection.GetPropertyOffset(intPtr, "bHasFallAnimAsset");
		bHasFallAnimAsset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bHasFallAnimAsset", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref StartJumpSpdState_PropertyAddress, intPtr, "StartJumpSpdState");
		StartJumpSpdState_Offset = NativeReflection.GetPropertyOffset(intPtr, "StartJumpSpdState");
		StartJumpSpdState_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StartJumpSpdState", Classes.FEnumProperty);
		BSJumpStart_F_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSJumpStart_F");
		BSJumpStart_F_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSJumpStart_F", Classes.FObjectProperty);
		BSJumpStart_B_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSJumpStart_B");
		BSJumpStart_B_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSJumpStart_B", Classes.FObjectProperty);
		BSJumpLoop_F_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSJumpLoop_F");
		BSJumpLoop_F_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSJumpLoop_F", Classes.FObjectProperty);
		BSJumpLoop_B_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSJumpLoop_B");
		BSJumpLoop_B_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSJumpLoop_B", Classes.FObjectProperty);
		BSJumpAdditiveLean_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSJumpAdditiveLean");
		BSJumpAdditiveLean_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSJumpAdditiveLean", Classes.FObjectProperty);
		BSJumpAdditiveRot_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSJumpAdditiveRot");
		BSJumpAdditiveRot_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSJumpAdditiveRot", Classes.FObjectProperty);
		AnimGroundJumpStart_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimGroundJumpStart");
		AnimGroundJumpStart_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimGroundJumpStart", Classes.FObjectProperty);
		AnimJumpStart_N_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimJumpStart_N");
		AnimJumpStart_N_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimJumpStart_N", Classes.FObjectProperty);
		AnimJumpStart_F_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimJumpStart_F");
		AnimJumpStart_F_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimJumpStart_F", Classes.FObjectProperty);
		AnimJumpStart_L_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimJumpStart_L");
		AnimJumpStart_L_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimJumpStart_L", Classes.FObjectProperty);
		AnimJumpStart_R_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimJumpStart_R");
		AnimJumpStart_R_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimJumpStart_R", Classes.FObjectProperty);
		AnimJumpStart_B_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimJumpStart_B");
		AnimJumpStart_B_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimJumpStart_B", Classes.FObjectProperty);
		AnimGlideJumpStart_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimGlideJumpStart");
		AnimGlideJumpStart_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimGlideJumpStart", Classes.FObjectProperty);
		AnimFallStart_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimFallStart");
		AnimFallStart_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimFallStart", Classes.FObjectProperty);
		AnimFallStart_N_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimFallStart_N");
		AnimFallStart_N_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimFallStart_N", Classes.FObjectProperty);
		AnimFallStart_F_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimFallStart_F");
		AnimFallStart_F_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimFallStart_F", Classes.FObjectProperty);
		AnimFallStart_L_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimFallStart_L");
		AnimFallStart_L_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimFallStart_L", Classes.FObjectProperty);
		AnimFallStart_R_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimFallStart_R");
		AnimFallStart_R_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimFallStart_R", Classes.FObjectProperty);
		AnimFallStart_B_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimFallStart_B");
		AnimFallStart_B_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimFallStart_B", Classes.FObjectProperty);
		AnimFallLoop_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimFallLoop");
		AnimFallLoop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimFallLoop", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref FallHeightType_PropertyAddress, intPtr, "FallHeightType");
		FallHeightType_Offset = NativeReflection.GetPropertyOffset(intPtr, "FallHeightType");
		FallHeightType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FallHeightType", Classes.FEnumProperty);
		FallHeight_Offset = NativeReflection.GetPropertyOffset(intPtr, "FallHeight");
		FallHeight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FallHeight", Classes.FFloatProperty);
		AnimLand_F_Low_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimLand_F_Low");
		AnimLand_F_Low_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimLand_F_Low", Classes.FObjectProperty);
		AnimLand_F_Mid_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimLand_F_Mid");
		AnimLand_F_Mid_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimLand_F_Mid", Classes.FObjectProperty);
		AnimLand_F_High_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimLand_F_High");
		AnimLand_F_High_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimLand_F_High", Classes.FObjectProperty);
		AnimLand_L_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimLand_L");
		AnimLand_L_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimLand_L", Classes.FObjectProperty);
		AnimLand_R_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimLand_R");
		AnimLand_R_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimLand_R", Classes.FObjectProperty);
		AnimLand_B_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimLand_B");
		AnimLand_B_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimLand_B", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref bIsInLandCantMoveTime_PropertyAddress, intPtr, "bIsInLandCantMoveTime");
		bIsInLandCantMoveTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "bIsInLandCantMoveTime");
		bIsInLandCantMoveTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bIsInLandCantMoveTime", Classes.FBoolProperty);
		StartMoveAfterJump_Offset = NativeReflection.GetPropertyOffset(intPtr, "StartMoveAfterJump");
		StartMoveAfterJump_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StartMoveAfterJump", Classes.FObjectProperty);
		AddtiveMoveAfterJump_F_Offset = NativeReflection.GetPropertyOffset(intPtr, "AddtiveMoveAfterJump_F");
		AddtiveMoveAfterJump_F_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AddtiveMoveAfterJump_F", Classes.FObjectProperty);
		AddtiveMoveAfterJump_B_Offset = NativeReflection.GetPropertyOffset(intPtr, "AddtiveMoveAfterJump_B");
		AddtiveMoveAfterJump_B_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AddtiveMoveAfterJump_B", Classes.FObjectProperty);
		AddtiveMoveAfterJump_L_Offset = NativeReflection.GetPropertyOffset(intPtr, "AddtiveMoveAfterJump_L");
		AddtiveMoveAfterJump_L_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AddtiveMoveAfterJump_L", Classes.FObjectProperty);
		AddtiveMoveAfterJump_R_Offset = NativeReflection.GetPropertyOffset(intPtr, "AddtiveMoveAfterJump_R");
		AddtiveMoveAfterJump_R_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AddtiveMoveAfterJump_R", Classes.FObjectProperty);
		AdditiveMoveAfterJumpFAlpha_Offset = NativeReflection.GetPropertyOffset(intPtr, "AdditiveMoveAfterJumpFAlpha");
		AdditiveMoveAfterJumpFAlpha_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AdditiveMoveAfterJumpFAlpha", Classes.FFloatProperty);
		AdditiveMoveAfterJumpBAlpha_Offset = NativeReflection.GetPropertyOffset(intPtr, "AdditiveMoveAfterJumpBAlpha");
		AdditiveMoveAfterJumpBAlpha_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AdditiveMoveAfterJumpBAlpha", Classes.FFloatProperty);
		AdditiveMoveAfterJumpLAlpha_Offset = NativeReflection.GetPropertyOffset(intPtr, "AdditiveMoveAfterJumpLAlpha");
		AdditiveMoveAfterJumpLAlpha_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AdditiveMoveAfterJumpLAlpha", Classes.FFloatProperty);
		AdditiveMoveAfterJumpRAlpha_Offset = NativeReflection.GetPropertyOffset(intPtr, "AdditiveMoveAfterJumpRAlpha");
		AdditiveMoveAfterJumpRAlpha_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AdditiveMoveAfterJumpRAlpha", Classes.FFloatProperty);
		BSJumpAdditiveLeanX_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSJumpAdditiveLeanX");
		BSJumpAdditiveLeanX_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSJumpAdditiveLeanX", Classes.FFloatProperty);
		BSJumpAdditiveLeanY_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSJumpAdditiveLeanY");
		BSJumpAdditiveLeanY_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSJumpAdditiveLeanY", Classes.FFloatProperty);
		LandPredictionAlpha_Offset = NativeReflection.GetPropertyOffset(intPtr, "LandPredictionAlpha");
		LandPredictionAlpha_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LandPredictionAlpha", Classes.FFloatProperty);
		BSJumpAdditiveRotX_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSJumpAdditiveRotX");
		BSJumpAdditiveRotX_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSJumpAdditiveRotX", Classes.FFloatProperty);
		BSJumpAdditiveRotY_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSJumpAdditiveRotY");
		BSJumpAdditiveRotY_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSJumpAdditiveRotY", Classes.FFloatProperty);
		LandAdditiveAlpha_Offset = NativeReflection.GetPropertyOffset(intPtr, "LandAdditiveAlpha");
		LandAdditiveAlpha_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LandAdditiveAlpha", Classes.FFloatProperty);
		VelocityDeltaAngle_Offset = NativeReflection.GetPropertyOffset(intPtr, "VelocityDeltaAngle");
		VelocityDeltaAngle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "VelocityDeltaAngle", Classes.FFloatProperty);
		VelocityDeltaAngleTrans_Offset = NativeReflection.GetPropertyOffset(intPtr, "VelocityDeltaAngleTrans");
		VelocityDeltaAngleTrans_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "VelocityDeltaAngleTrans", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bSplineMoving_PropertyAddress, intPtr, "bSplineMoving");
		bSplineMoving_Offset = NativeReflection.GetPropertyOffset(intPtr, "bSplineMoving");
		bSplineMoving_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bSplineMoving", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bSplineMoveForward_PropertyAddress, intPtr, "bSplineMoveForward");
		bSplineMoveForward_Offset = NativeReflection.GetPropertyOffset(intPtr, "bSplineMoveForward");
		bSplineMoveForward_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bSplineMoveForward", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bSplineMoveSharpturn_PropertyAddress, intPtr, "bSplineMoveSharpturn");
		bSplineMoveSharpturn_Offset = NativeReflection.GetPropertyOffset(intPtr, "bSplineMoveSharpturn");
		bSplineMoveSharpturn_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bSplineMoveSharpturn", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bSplineMoveReSharpturn_PropertyAddress, intPtr, "bSplineMoveReSharpturn");
		bSplineMoveReSharpturn_Offset = NativeReflection.GetPropertyOffset(intPtr, "bSplineMoveReSharpturn");
		bSplineMoveReSharpturn_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bSplineMoveReSharpturn", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bSplineMoveCanExitSharpturn_PropertyAddress, intPtr, "bSplineMoveCanExitSharpturn");
		bSplineMoveCanExitSharpturn_Offset = NativeReflection.GetPropertyOffset(intPtr, "bSplineMoveCanExitSharpturn");
		bSplineMoveCanExitSharpturn_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bSplineMoveCanExitSharpturn", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bSplineMoveStopToStart_PropertyAddress, intPtr, "bSplineMoveStopToStart");
		bSplineMoveStopToStart_Offset = NativeReflection.GetPropertyOffset(intPtr, "bSplineMoveStopToStart");
		bSplineMoveStopToStart_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bSplineMoveStopToStart", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bSplineMoveStopToLoop_PropertyAddress, intPtr, "bSplineMoveStopToLoop");
		bSplineMoveStopToLoop_Offset = NativeReflection.GetPropertyOffset(intPtr, "bSplineMoveStopToLoop");
		bSplineMoveStopToLoop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bSplineMoveStopToLoop", Classes.FBoolProperty);
		SharpturnAngle_Offset = NativeReflection.GetPropertyOffset(intPtr, "SharpturnAngle");
		SharpturnAngle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SharpturnAngle", Classes.FFloatProperty);
		ASSplineMoveIdleForward_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASSplineMoveIdleForward");
		ASSplineMoveIdleForward_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASSplineMoveIdleForward", Classes.FObjectProperty);
		ASSplineMoveIdleBackward_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASSplineMoveIdleBackward");
		ASSplineMoveIdleBackward_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASSplineMoveIdleBackward", Classes.FObjectProperty);
		ASSplineMoveStartForward_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASSplineMoveStartForward");
		ASSplineMoveStartForward_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASSplineMoveStartForward", Classes.FObjectProperty);
		ASSplineMoveStartBackward_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASSplineMoveStartBackward");
		ASSplineMoveStartBackward_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASSplineMoveStartBackward", Classes.FObjectProperty);
		ASSplineMoveLoopForward_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASSplineMoveLoopForward");
		ASSplineMoveLoopForward_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASSplineMoveLoopForward", Classes.FObjectProperty);
		ASSplineMoveLoopBackward_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASSplineMoveLoopBackward");
		ASSplineMoveLoopBackward_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASSplineMoveLoopBackward", Classes.FObjectProperty);
		ASSplineMoveStopForward_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASSplineMoveStopForward");
		ASSplineMoveStopForward_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASSplineMoveStopForward", Classes.FObjectProperty);
		ASSplineMoveStopBackward_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASSplineMoveStopBackward");
		ASSplineMoveStopBackward_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASSplineMoveStopBackward", Classes.FObjectProperty);
		ASSplineMoveTurnF2B_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASSplineMoveTurnF2B");
		ASSplineMoveTurnF2B_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASSplineMoveTurnF2B", Classes.FObjectProperty);
		ASSplineMoveTurnB2F_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASSplineMoveTurnB2F");
		ASSplineMoveTurnB2F_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASSplineMoveTurnB2F", Classes.FObjectProperty);
		AnimCloudFallStart_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimCloudFallStart");
		AnimCloudFallStart_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimCloudFallStart", Classes.FObjectProperty);
		AnimCloudFallLoop_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimCloudFallLoop");
		AnimCloudFallLoop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimCloudFallLoop", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref bGlideEndToGroundMove_PropertyAddress, intPtr, "bGlideEndToGroundMove");
		bGlideEndToGroundMove_Offset = NativeReflection.GetPropertyOffset(intPtr, "bGlideEndToGroundMove");
		bGlideEndToGroundMove_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bGlideEndToGroundMove", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bAirStartGlide_PropertyAddress, intPtr, "bAirStartGlide");
		bAirStartGlide_Offset = NativeReflection.GetPropertyOffset(intPtr, "bAirStartGlide");
		bAirStartGlide_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bAirStartGlide", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bGlideFlat_PropertyAddress, intPtr, "bGlideFlat");
		bGlideFlat_Offset = NativeReflection.GetPropertyOffset(intPtr, "bGlideFlat");
		bGlideFlat_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bGlideFlat", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bGlideSteep_PropertyAddress, intPtr, "bGlideSteep");
		bGlideSteep_Offset = NativeReflection.GetPropertyOffset(intPtr, "bGlideSteep");
		bGlideSteep_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bGlideSteep", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bGlideStartFront_PropertyAddress, intPtr, "bGlideStartFront");
		bGlideStartFront_Offset = NativeReflection.GetPropertyOffset(intPtr, "bGlideStartFront");
		bGlideStartFront_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bGlideStartFront", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bGlideStartBack_PropertyAddress, intPtr, "bGlideStartBack");
		bGlideStartBack_Offset = NativeReflection.GetPropertyOffset(intPtr, "bGlideStartBack");
		bGlideStartBack_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bGlideStartBack", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bGlideLoopRotationLeft_PropertyAddress, intPtr, "bGlideLoopRotationLeft");
		bGlideLoopRotationLeft_Offset = NativeReflection.GetPropertyOffset(intPtr, "bGlideLoopRotationLeft");
		bGlideLoopRotationLeft_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bGlideLoopRotationLeft", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bGlideLoopRotationRight_PropertyAddress, intPtr, "bGlideLoopRotationRight");
		bGlideLoopRotationRight_Offset = NativeReflection.GetPropertyOffset(intPtr, "bGlideLoopRotationRight");
		bGlideLoopRotationRight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bGlideLoopRotationRight", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bGlideEndSlow_PropertyAddress, intPtr, "bGlideEndSlow");
		bGlideEndSlow_Offset = NativeReflection.GetPropertyOffset(intPtr, "bGlideEndSlow");
		bGlideEndSlow_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bGlideEndSlow", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bGlideEndFast_PropertyAddress, intPtr, "bGlideEndFast");
		bGlideEndFast_Offset = NativeReflection.GetPropertyOffset(intPtr, "bGlideEndFast");
		bGlideEndFast_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bGlideEndFast", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bToFall_PropertyAddress, intPtr, "bToFall");
		bToFall_Offset = NativeReflection.GetPropertyOffset(intPtr, "bToFall");
		bToFall_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bToFall", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bToGroundJumpStart_PropertyAddress, intPtr, "bToGroundJumpStart");
		bToGroundJumpStart_Offset = NativeReflection.GetPropertyOffset(intPtr, "bToGroundJumpStart");
		bToGroundJumpStart_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bToGroundJumpStart", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bToGroundJumpStartFwd_PropertyAddress, intPtr, "bToGroundJumpStartFwd");
		bToGroundJumpStartFwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "bToGroundJumpStartFwd");
		bToGroundJumpStartFwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bToGroundJumpStartFwd", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bToGroundJumpStartBwd_PropertyAddress, intPtr, "bToGroundJumpStartBwd");
		bToGroundJumpStartBwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "bToGroundJumpStartBwd");
		bToGroundJumpStartBwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bToGroundJumpStartBwd", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bToGlideJumpStart_PropertyAddress, intPtr, "bToGlideJumpStart");
		bToGlideJumpStart_Offset = NativeReflection.GetPropertyOffset(intPtr, "bToGlideJumpStart");
		bToGlideJumpStart_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bToGlideJumpStart", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bToLandAdditive_PropertyAddress, intPtr, "bToLandAdditive");
		bToLandAdditive_Offset = NativeReflection.GetPropertyOffset(intPtr, "bToLandAdditive");
		bToLandAdditive_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bToLandAdditive", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bStride_PropertyAddress, intPtr, "bStride");
		bStride_Offset = NativeReflection.GetPropertyOffset(intPtr, "bStride");
		bStride_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bStride", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bStrideJump_PropertyAddress, intPtr, "bStrideJump");
		bStrideJump_Offset = NativeReflection.GetPropertyOffset(intPtr, "bStrideJump");
		bStrideJump_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bStrideJump", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bStrideUpJump_PropertyAddress, intPtr, "bStrideUpJump");
		bStrideUpJump_Offset = NativeReflection.GetPropertyOffset(intPtr, "bStrideUpJump");
		bStrideUpJump_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bStrideUpJump", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bStrideDownJump_PropertyAddress, intPtr, "bStrideDownJump");
		bStrideDownJump_Offset = NativeReflection.GetPropertyOffset(intPtr, "bStrideDownJump");
		bStrideDownJump_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bStrideDownJump", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bStrideUp_PropertyAddress, intPtr, "bStrideUp");
		bStrideUp_Offset = NativeReflection.GetPropertyOffset(intPtr, "bStrideUp");
		bStrideUp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bStrideUp", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bStrideDown_PropertyAddress, intPtr, "bStrideDown");
		bStrideDown_Offset = NativeReflection.GetPropertyOffset(intPtr, "bStrideDown");
		bStrideDown_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bStrideDown", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bStrideUpLand_PropertyAddress, intPtr, "bStrideUpLand");
		bStrideUpLand_Offset = NativeReflection.GetPropertyOffset(intPtr, "bStrideUpLand");
		bStrideUpLand_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bStrideUpLand", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bStrideDownLand_PropertyAddress, intPtr, "bStrideDownLand");
		bStrideDownLand_Offset = NativeReflection.GetPropertyOffset(intPtr, "bStrideDownLand");
		bStrideDownLand_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bStrideDownLand", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bStrideUpHigh_PropertyAddress, intPtr, "bStrideUpHigh");
		bStrideUpHigh_Offset = NativeReflection.GetPropertyOffset(intPtr, "bStrideUpHigh");
		bStrideUpHigh_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bStrideUpHigh", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bStrideUpLow_PropertyAddress, intPtr, "bStrideUpLow");
		bStrideUpLow_Offset = NativeReflection.GetPropertyOffset(intPtr, "bStrideUpLow");
		bStrideUpLow_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bStrideUpLow", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bCloudFall_PropertyAddress, intPtr, "bCloudFall");
		bCloudFall_Offset = NativeReflection.GetPropertyOffset(intPtr, "bCloudFall");
		bCloudFall_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bCloudFall", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLeaveGlideMoving_PropertyAddress, intPtr, "bLeaveGlideMoving");
		bLeaveGlideMoving_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLeaveGlideMoving");
		bLeaveGlideMoving_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLeaveGlideMoving", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bParkourClimb_PropertyAddress, intPtr, "bParkourClimb");
		bParkourClimb_Offset = NativeReflection.GetPropertyOffset(intPtr, "bParkourClimb");
		bParkourClimb_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bParkourClimb", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bParkourAcross_PropertyAddress, intPtr, "bParkourAcross");
		bParkourAcross_Offset = NativeReflection.GetPropertyOffset(intPtr, "bParkourAcross");
		bParkourAcross_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bParkourAcross", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bParkourLow_PropertyAddress, intPtr, "bParkourLow");
		bParkourLow_Offset = NativeReflection.GetPropertyOffset(intPtr, "bParkourLow");
		bParkourLow_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bParkourLow", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bParkourNormal_PropertyAddress, intPtr, "bParkourNormal");
		bParkourNormal_Offset = NativeReflection.GetPropertyOffset(intPtr, "bParkourNormal");
		bParkourNormal_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bParkourNormal", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bParkourHigh_PropertyAddress, intPtr, "bParkourHigh");
		bParkourHigh_Offset = NativeReflection.GetPropertyOffset(intPtr, "bParkourHigh");
		bParkourHigh_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bParkourHigh", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bParkourFall_PropertyAddress, intPtr, "bParkourFall");
		bParkourFall_Offset = NativeReflection.GetPropertyOffset(intPtr, "bParkourFall");
		bParkourFall_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bParkourFall", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLandAnimToGround_PropertyAddress, intPtr, "bLandAnimToGround");
		bLandAnimToGround_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLandAnimToGround");
		bLandAnimToGround_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLandAnimToGround", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockMoveJumpF_PropertyAddress, intPtr, "bLockMoveJumpF");
		bLockMoveJumpF_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLockMoveJumpF");
		bLockMoveJumpF_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLockMoveJumpF", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockMoveJumpFL_PropertyAddress, intPtr, "bLockMoveJumpFL");
		bLockMoveJumpFL_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLockMoveJumpFL");
		bLockMoveJumpFL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLockMoveJumpFL", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockMoveJumpFR_PropertyAddress, intPtr, "bLockMoveJumpFR");
		bLockMoveJumpFR_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLockMoveJumpFR");
		bLockMoveJumpFR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLockMoveJumpFR", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockMoveJumpBL_PropertyAddress, intPtr, "bLockMoveJumpBL");
		bLockMoveJumpBL_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLockMoveJumpBL");
		bLockMoveJumpBL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLockMoveJumpBL", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockMoveJumpBR_PropertyAddress, intPtr, "bLockMoveJumpBR");
		bLockMoveJumpBR_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLockMoveJumpBR");
		bLockMoveJumpBR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLockMoveJumpBR", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockMoveJumpB_PropertyAddress, intPtr, "bLockMoveJumpB");
		bLockMoveJumpB_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLockMoveJumpB");
		bLockMoveJumpB_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLockMoveJumpB", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bToStride_PropertyAddress, intPtr, "bToStride");
		bToStride_Offset = NativeReflection.GetPropertyOffset(intPtr, "bToStride");
		bToStride_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bToStride", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bStrideContinue_PropertyAddress, intPtr, "bStrideContinue");
		bStrideContinue_Offset = NativeReflection.GetPropertyOffset(intPtr, "bStrideContinue");
		bStrideContinue_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bStrideContinue", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLeftFootFront_PropertyAddress, intPtr, "bLeftFootFront");
		bLeftFootFront_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLeftFootFront");
		bLeftFootFront_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLeftFootFront", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bToLandAnim_PropertyAddress, intPtr, "bToLandAnim");
		bToLandAnim_Offset = NativeReflection.GetPropertyOffset(intPtr, "bToLandAnim");
		bToLandAnim_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bToLandAnim", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bToLandMove_PropertyAddress, intPtr, "bToLandMove");
		bToLandMove_Offset = NativeReflection.GetPropertyOffset(intPtr, "bToLandMove");
		bToLandMove_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bToLandMove", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bSwitchToLock_PropertyAddress, intPtr, "bSwitchToLock");
		bSwitchToLock_Offset = NativeReflection.GetPropertyOffset(intPtr, "bSwitchToLock");
		bSwitchToLock_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bSwitchToLock", Classes.FBoolProperty);
		SetupLandAnim_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetupLandAnim");
		SetupLandAnim_ParamsSize = NativeReflection.GetFunctionParamsSize(SetupLandAnim_FunctionAddress);
		NativeReflection.GetPropertyRef(ref SetupLandAnim_Context_PropertyAddress, SetupLandAnim_FunctionAddress, "Context");
		SetupLandAnim_Context_Offset = NativeReflection.GetPropertyOffset(SetupLandAnim_FunctionAddress, "Context");
		SetupLandAnim_Context_IsValid = NativeReflection.ValidatePropertyClass(SetupLandAnim_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref SetupLandAnim_Node_PropertyAddress, SetupLandAnim_FunctionAddress, "Node");
		SetupLandAnim_Node_Offset = NativeReflection.GetPropertyOffset(SetupLandAnim_FunctionAddress, "Node");
		SetupLandAnim_Node_IsValid = NativeReflection.ValidatePropertyClass(SetupLandAnim_FunctionAddress, "Node", Classes.FStructProperty);
		SetupLandAnim_IsValid = SetupLandAnim_FunctionAddress != IntPtr.Zero && SetupLandAnim_Context_IsValid && SetupLandAnim_Node_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:SetupLandAnim", SetupLandAnim_IsValid);
		GetAnimCloudLand_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAnimCloudLand");
		GetAnimCloudLand_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnimCloudLand_FunctionAddress);
		GetAnimCloudLand_AnimCloudLand_Offset = NativeReflection.GetPropertyOffset(GetAnimCloudLand_FunctionAddress, "AnimCloudLand");
		GetAnimCloudLand_AnimCloudLand_IsValid = NativeReflection.ValidatePropertyClass(GetAnimCloudLand_FunctionAddress, "AnimCloudLand", Classes.FObjectProperty);
		GetAnimCloudLand_IsValid = GetAnimCloudLand_FunctionAddress != IntPtr.Zero && GetAnimCloudLand_AnimCloudLand_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:GetAnimCloudLand", GetAnimCloudLand_IsValid);
		UpdateGroundJump_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateGroundJump");
		UpdateGroundJump_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateGroundJump_FunctionAddress);
		NativeReflection.GetPropertyRef(ref UpdateGroundJump_Context_PropertyAddress, UpdateGroundJump_FunctionAddress, "Context");
		UpdateGroundJump_Context_Offset = NativeReflection.GetPropertyOffset(UpdateGroundJump_FunctionAddress, "Context");
		UpdateGroundJump_Context_IsValid = NativeReflection.ValidatePropertyClass(UpdateGroundJump_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref UpdateGroundJump_Node_PropertyAddress, UpdateGroundJump_FunctionAddress, "Node");
		UpdateGroundJump_Node_Offset = NativeReflection.GetPropertyOffset(UpdateGroundJump_FunctionAddress, "Node");
		UpdateGroundJump_Node_IsValid = NativeReflection.ValidatePropertyClass(UpdateGroundJump_FunctionAddress, "Node", Classes.FStructProperty);
		UpdateGroundJump_IsValid = UpdateGroundJump_FunctionAddress != IntPtr.Zero && UpdateGroundJump_Context_IsValid && UpdateGroundJump_Node_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:UpdateGroundJump", UpdateGroundJump_IsValid);
		UpdateGroundAdditive_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateGroundAdditive");
		UpdateGroundAdditive_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateGroundAdditive_FunctionAddress);
		NativeReflection.GetPropertyRef(ref UpdateGroundAdditive_Context_PropertyAddress, UpdateGroundAdditive_FunctionAddress, "Context");
		UpdateGroundAdditive_Context_Offset = NativeReflection.GetPropertyOffset(UpdateGroundAdditive_FunctionAddress, "Context");
		UpdateGroundAdditive_Context_IsValid = NativeReflection.ValidatePropertyClass(UpdateGroundAdditive_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref UpdateGroundAdditive_Node_PropertyAddress, UpdateGroundAdditive_FunctionAddress, "Node");
		UpdateGroundAdditive_Node_Offset = NativeReflection.GetPropertyOffset(UpdateGroundAdditive_FunctionAddress, "Node");
		UpdateGroundAdditive_Node_IsValid = NativeReflection.ValidatePropertyClass(UpdateGroundAdditive_FunctionAddress, "Node", Classes.FStructProperty);
		UpdateGroundAdditive_IsValid = UpdateGroundAdditive_FunctionAddress != IntPtr.Zero && UpdateGroundAdditive_Context_IsValid && UpdateGroundAdditive_Node_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_SpecialMove:UpdateGroundAdditive", UpdateGroundAdditive_IsValid);
	}

	static BUAnimHumanoidCS_SpecialMove()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUAnimHumanoidCS_SpecialMove)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUAnimHumanoidCS_SpecialMove));
	}
}
