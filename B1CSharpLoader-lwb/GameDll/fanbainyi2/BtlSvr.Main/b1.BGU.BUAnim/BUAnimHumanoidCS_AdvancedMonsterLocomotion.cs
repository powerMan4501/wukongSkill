using System;
using System.Collections.Generic;
using UnrealEngine.AnimGraphRuntime;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.AnimationLocomotionLibraryRuntime;
using UnrealEngine.Runtime;

namespace b1.BGU.BUAnim;

[Abstract]
[Blueprintable]
[UClass]
[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion")]
public class BUAnimHumanoidCS_AdvancedMonsterLocomotion : BUAnimHumanoidCS_LinkedInstanceBase
{
	private IBUC_ABPBasicData BasicData;

	private IBUC_ABPCharacterData ChrData;

	private IBUC_ABPAdvancedMonsterLocomotionData AdvancedMonsterLocomotionData;

	private IBUC_ABPCommonSettingData CommonData;

	private List<UAnimSequence> ASIdleList = new List<UAnimSequence>();

	private bool bHasWalkAnim;

	private bool bHasWalkPivotAnim;

	private bool bHasWalkTransAnim;

	private bool bHasWalkSharpturnAnim;

	private bool bHasRunAnim;

	private bool bHasRunPivotAnim;

	private bool bHasRunTransAnim;

	private bool bHasRunSharpturnAnim;

	private bool bHasRushAnim;

	private bool bHasRushSharpturnAnim;

	private float MoveStartInputDeltaAngle;

	private float MoveTurnInputDeltaAngle;

	private EAdvancedMonsterLocomotionLoopDir CurrentMoveLoopDir;

	private bool bMoveLoopTransNotFinish;

	private bool bInvalidTurnDir;

	private ELockMoveDirectionSix CurrentLockTurnDir;

	private ELockMoveDirectionSix StopDirection;

	private bool bMoveToTurn;

	private ELockMoveDirectionSix StartInputDirection;

	private ELockMoveDirectionSix StopInputDirection;

	private float StopTimer;

	private float TurnTimer;

	private bool bFirstUpdateLoopOutput;

	private float ExplicitTimeTurnFinish;

	private bool bFirstUpdateTurnAnim;

	private FVector2D PlayRateClampStartAndTurn;

	private FVector2D PlayRateClampLoop;

	private FVector LastActorLocation;

	private float MoveDistanceSinceLastUpdate;

	private float PivotOrientationWarpingMinVelocity;

	private EGaitGroundedState StartOrTurnGaitGroundedState;

	private bool bChangeMoveSpeedInStartOrTurn;

	private FName Distance = B1GlobalFNames.Distance;

	private readonly float StrideWarpingBlendInStartTime = 0.15f;

	private readonly float StrideWarpingBlendInEndTime = 0.2f;

	private readonly FVector2D AlphaRange = new FVector2D(-2.0, 2.0);

	private readonly FVector2D Spine01AngleOffsetRange = new FVector2D(-5.0, 5.0);

	private readonly FVector2D Spine02AngleOffsetRange = new FVector2D(-10.0, 10.0);

	private readonly FVector2D Spine03AngleOffsetRange = new FVector2D(-15.0, 15.0);

	private readonly FVector2D HeadAngleOffsetRange = new FVector2D(-20.0, 20.0);

	private static bool FreeMode_IsValid;

	private static int FreeMode_Offset;

	private static FFieldAddress FreeMode_PropertyAddress;

	private static bool LockMode_IsValid;

	private static int LockMode_Offset;

	private static FFieldAddress LockMode_PropertyAddress;

	private static bool StartAngle_IsValid;

	private static int StartAngle_Offset;

	private static bool StrideWarpingStartAlpha_IsValid;

	private static int StrideWarpingStartAlpha_Offset;

	private static bool StrideWarpingLoopAlpha_IsValid;

	private static int StrideWarpingLoopAlpha_Offset;

	private static bool StrideWarpingTurnAlpha_IsValid;

	private static int StrideWarpingTurnAlpha_Offset;

	private static bool MoveLoopSpine01AngleOffset_IsValid;

	private static int MoveLoopSpine01AngleOffset_Offset;

	private static bool MoveLoopSpine02AngleOffset_IsValid;

	private static int MoveLoopSpine02AngleOffset_Offset;

	private static bool MoveLoopSpine03AngleOffset_IsValid;

	private static int MoveLoopSpine03AngleOffset_Offset;

	private static bool MoveLoopHeadAngleOffset_IsValid;

	private static int MoveLoopHeadAngleOffset_Offset;

	private static bool MoveLoopPelvisLocalOffset_IsValid;

	private static int MoveLoopPelvisLocalOffset_Offset;

	private static bool MoveLoopPelvisAngleOffset_IsValid;

	private static int MoveLoopPelvisAngleOffset_Offset;

	private static bool ASWalkStartFwd_IsValid;

	private static int ASWalkStartFwd_Offset;

	private static bool ASWalkStartBwd_IsValid;

	private static int ASWalkStartBwd_Offset;

	private static bool ASWalkStartLeftMin_IsValid;

	private static int ASWalkStartLeftMin_Offset;

	private static bool ASWalkStartLeftMax_IsValid;

	private static int ASWalkStartLeftMax_Offset;

	private static bool ASWalkStartRightMin_IsValid;

	private static int ASWalkStartRightMin_Offset;

	private static bool ASWalkStartRightMax_IsValid;

	private static int ASWalkStartRightMax_Offset;

	private static bool ASWalkStartLF_IsValid;

	private static int ASWalkStartLF_Offset;

	private static bool ASWalkStartLB_IsValid;

	private static int ASWalkStartLB_Offset;

	private static bool ASWalkStartRF_IsValid;

	private static int ASWalkStartRF_Offset;

	private static bool ASWalkStartRB_IsValid;

	private static int ASWalkStartRB_Offset;

	private static bool ASWalkLoopFwd_IsValid;

	private static int ASWalkLoopFwd_Offset;

	private static bool ASWalkLoopBwd_IsValid;

	private static int ASWalkLoopBwd_Offset;

	private static bool ASWalkLoopLF_IsValid;

	private static int ASWalkLoopLF_Offset;

	private static bool ASWalkLoopLB_IsValid;

	private static int ASWalkLoopLB_Offset;

	private static bool ASWalkLoopRF_IsValid;

	private static int ASWalkLoopRF_Offset;

	private static bool ASWalkLoopRB_IsValid;

	private static int ASWalkLoopRB_Offset;

	private static bool ASWalkSharpturnLeftMin_IsValid;

	private static int ASWalkSharpturnLeftMin_Offset;

	private static bool ASWalkSharpturnLeftMax_IsValid;

	private static int ASWalkSharpturnLeftMax_Offset;

	private static bool ASWalkSharpturnRightMin_IsValid;

	private static int ASWalkSharpturnRightMin_Offset;

	private static bool ASWalkSharpturnRightMax_IsValid;

	private static int ASWalkSharpturnRightMax_Offset;

	private static bool ASWalkPivotFwd_IsValid;

	private static int ASWalkPivotFwd_Offset;

	private static bool ASWalkPivotBwd_IsValid;

	private static int ASWalkPivotBwd_Offset;

	private static bool ASWalkPivotLF_IsValid;

	private static int ASWalkPivotLF_Offset;

	private static bool ASWalkPivotLB_IsValid;

	private static int ASWalkPivotLB_Offset;

	private static bool ASWalkPivotRF_IsValid;

	private static int ASWalkPivotRF_Offset;

	private static bool ASWalkPivotRB_IsValid;

	private static int ASWalkPivotRB_Offset;

	private static bool ASWalkTransFRToBR_IsValid;

	private static int ASWalkTransFRToBR_Offset;

	private static bool ASWalkTransBRToFR_IsValid;

	private static int ASWalkTransBRToFR_Offset;

	private static bool ASWalkTransFLToBL_IsValid;

	private static int ASWalkTransFLToBL_Offset;

	private static bool ASWalkTransBLToFL_IsValid;

	private static int ASWalkTransBLToFL_Offset;

	private static bool ASWalkStopFwd_IsValid;

	private static int ASWalkStopFwd_Offset;

	private static bool ASWalkStopBwd_IsValid;

	private static int ASWalkStopBwd_Offset;

	private static bool ASWalkStopLF_IsValid;

	private static int ASWalkStopLF_Offset;

	private static bool ASWalkStopLB_IsValid;

	private static int ASWalkStopLB_Offset;

	private static bool ASWalkStopRF_IsValid;

	private static int ASWalkStopRF_Offset;

	private static bool ASWalkStopRB_IsValid;

	private static int ASWalkStopRB_Offset;

	private static bool ASWalkLoopAddPose_IsValid;

	private static int ASWalkLoopAddPose_Offset;

	private static bool ASWalkLoopAdditiveList_IsValid;

	private static int ASWalkLoopAdditiveList_Offset;

	private static FFieldAddress ASWalkLoopAdditiveList_PropertyAddress;

	private TArrayReadWriteMarshaler<UAnimSequence> ASWalkLoopAdditiveList_Marshaler;

	private static bool ASRunStartFwd_IsValid;

	private static int ASRunStartFwd_Offset;

	private static bool ASRunStartBwd_IsValid;

	private static int ASRunStartBwd_Offset;

	private static bool ASRunStartLeftMin_IsValid;

	private static int ASRunStartLeftMin_Offset;

	private static bool ASRunStartLeftMax_IsValid;

	private static int ASRunStartLeftMax_Offset;

	private static bool ASRunStartRightMin_IsValid;

	private static int ASRunStartRightMin_Offset;

	private static bool ASRunStartRightMax_IsValid;

	private static int ASRunStartRightMax_Offset;

	private static bool ASRunStartLF_IsValid;

	private static int ASRunStartLF_Offset;

	private static bool ASRunStartLB_IsValid;

	private static int ASRunStartLB_Offset;

	private static bool ASRunStartRF_IsValid;

	private static int ASRunStartRF_Offset;

	private static bool ASRunStartRB_IsValid;

	private static int ASRunStartRB_Offset;

	private static bool ASRunLoopFwd_IsValid;

	private static int ASRunLoopFwd_Offset;

	private static bool ASRunLoopBwd_IsValid;

	private static int ASRunLoopBwd_Offset;

	private static bool ASRunLoopLF_IsValid;

	private static int ASRunLoopLF_Offset;

	private static bool ASRunLoopLB_IsValid;

	private static int ASRunLoopLB_Offset;

	private static bool ASRunLoopRF_IsValid;

	private static int ASRunLoopRF_Offset;

	private static bool ASRunLoopRB_IsValid;

	private static int ASRunLoopRB_Offset;

	private static bool ASRunSharpturnLeftMin_IsValid;

	private static int ASRunSharpturnLeftMin_Offset;

	private static bool ASRunSharpturnLeftMax_IsValid;

	private static int ASRunSharpturnLeftMax_Offset;

	private static bool ASRunSharpturnRightMin_IsValid;

	private static int ASRunSharpturnRightMin_Offset;

	private static bool ASRunSharpturnRightMax_IsValid;

	private static int ASRunSharpturnRightMax_Offset;

	private static bool ASRunPivotFwd_IsValid;

	private static int ASRunPivotFwd_Offset;

	private static bool ASRunPivotBwd_IsValid;

	private static int ASRunPivotBwd_Offset;

	private static bool ASRunPivotLF_IsValid;

	private static int ASRunPivotLF_Offset;

	private static bool ASRunPivotLB_IsValid;

	private static int ASRunPivotLB_Offset;

	private static bool ASRunPivotRF_IsValid;

	private static int ASRunPivotRF_Offset;

	private static bool ASRunPivotRB_IsValid;

	private static int ASRunPivotRB_Offset;

	private static bool ASRunTransFRToBR_IsValid;

	private static int ASRunTransFRToBR_Offset;

	private static bool ASRunTransBRToFR_IsValid;

	private static int ASRunTransBRToFR_Offset;

	private static bool ASRunTransFLToBL_IsValid;

	private static int ASRunTransFLToBL_Offset;

	private static bool ASRunTransBLToFL_IsValid;

	private static int ASRunTransBLToFL_Offset;

	private static bool ASRunStopFwd_IsValid;

	private static int ASRunStopFwd_Offset;

	private static bool ASRunStopBwd_IsValid;

	private static int ASRunStopBwd_Offset;

	private static bool ASRunStopLF_IsValid;

	private static int ASRunStopLF_Offset;

	private static bool ASRunStopLB_IsValid;

	private static int ASRunStopLB_Offset;

	private static bool ASRunStopRF_IsValid;

	private static int ASRunStopRF_Offset;

	private static bool ASRunStopRB_IsValid;

	private static int ASRunStopRB_Offset;

	private static bool ASRunLoopAddPose_IsValid;

	private static int ASRunLoopAddPose_Offset;

	private static bool ASRunLoopAdditiveList_IsValid;

	private static int ASRunLoopAdditiveList_Offset;

	private static FFieldAddress ASRunLoopAdditiveList_PropertyAddress;

	private TArrayReadWriteMarshaler<UAnimSequence> ASRunLoopAdditiveList_Marshaler;

	private static bool ASRushStartFwd_IsValid;

	private static int ASRushStartFwd_Offset;

	private static bool ASRushStartLeftMin_IsValid;

	private static int ASRushStartLeftMin_Offset;

	private static bool ASRushStartLeftMax_IsValid;

	private static int ASRushStartLeftMax_Offset;

	private static bool ASRushStartRightMin_IsValid;

	private static int ASRushStartRightMin_Offset;

	private static bool ASRushStartRightMax_IsValid;

	private static int ASRushStartRightMax_Offset;

	private static bool ASRushLoopFwd_IsValid;

	private static int ASRushLoopFwd_Offset;

	private static bool ASRushSharpturnLeftMin_IsValid;

	private static int ASRushSharpturnLeftMin_Offset;

	private static bool ASRushSharpturnLeftMax_IsValid;

	private static int ASRushSharpturnLeftMax_Offset;

	private static bool ASRushSharpturnRightMin_IsValid;

	private static int ASRushSharpturnRightMin_Offset;

	private static bool ASRushSharpturnRightMax_IsValid;

	private static int ASRushSharpturnRightMax_Offset;

	private static bool ASRushStopFwd_IsValid;

	private static int ASRushStopFwd_Offset;

	private static bool ASRushLoopAddPose_IsValid;

	private static int ASRushLoopAddPose_Offset;

	private static bool ASRushLoopAdditiveList_IsValid;

	private static int ASRushLoopAdditiveList_Offset;

	private static FFieldAddress ASRushLoopAdditiveList_PropertyAddress;

	private TArrayReadWriteMarshaler<UAnimSequence> ASRushLoopAdditiveList_Marshaler;

	private static bool AnimIdle_IsValid;

	private static int AnimIdle_Offset;

	private static bool MappedSpeed_IsValid;

	private static int MappedSpeed_Offset;

	private static bool GaitGroundedState_IsValid;

	private static int GaitGroundedState_Offset;

	private static FFieldAddress GaitGroundedState_PropertyAddress;

	private static bool MoveGaitGroundedState_IsValid;

	private static int MoveGaitGroundedState_Offset;

	private static FFieldAddress MoveGaitGroundedState_PropertyAddress;

	private static bool SwitchingLockStateAngle_IsValid;

	private static int SwitchingLockStateAngle_Offset;

	private static bool ActorSpineNum_IsValid;

	private static int ActorSpineNum_Offset;

	private static bool VelocityDeltaAngle_IsValid;

	private static int VelocityDeltaAngle_Offset;

	private static bool StopVelocityDeltaAngle_IsValid;

	private static int StopVelocityDeltaAngle_Offset;

	private static bool InputDeltaAngle_IsValid;

	private static int InputDeltaAngle_Offset;

	private static bool InputVelocityAngle_IsValid;

	private static int InputVelocityAngle_Offset;

	private static bool MoveSpeedLastUpdate_IsValid;

	private static int MoveSpeedLastUpdate_Offset;

	private static bool bPivotUseOrientationWarping_IsValid;

	private static int bPivotUseOrientationWarping_Offset;

	private static FFieldAddress bPivotUseOrientationWarping_PropertyAddress;

	private static bool bUpdateAnimIdle_IsValid;

	private static int bUpdateAnimIdle_Offset;

	private static FFieldAddress bUpdateAnimIdle_PropertyAddress;

	private static bool bSwitchToLock_IsValid;

	private static int bSwitchToLock_Offset;

	private static FFieldAddress bSwitchToLock_PropertyAddress;

	private static bool bSwitchingLockState_IsValid;

	private static int bSwitchingLockState_Offset;

	private static FFieldAddress bSwitchingLockState_PropertyAddress;

	private static bool bFreeStop_IsValid;

	private static int bFreeStop_Offset;

	private static FFieldAddress bFreeStop_PropertyAddress;

	private static bool bLockStop_IsValid;

	private static int bLockStop_Offset;

	private static FFieldAddress bLockStop_PropertyAddress;

	private static bool bSwitchingLockStateStop_IsValid;

	private static int bSwitchingLockStateStop_Offset;

	private static FFieldAddress bSwitchingLockStateStop_PropertyAddress;

	private static bool bMoveToIdle_IsValid;

	private static int bMoveToIdle_Offset;

	private static FFieldAddress bMoveToIdle_PropertyAddress;

	private static bool bStartToTrans_IsValid;

	private static int bStartToTrans_Offset;

	private static FFieldAddress bStartToTrans_PropertyAddress;

	private static bool bFreeStartToTurn_IsValid;

	private static int bFreeStartToTurn_Offset;

	private static FFieldAddress bFreeStartToTurn_PropertyAddress;

	private static bool bLockStartToTurn_IsValid;

	private static int bLockStartToTurn_Offset;

	private static FFieldAddress bLockStartToTurn_PropertyAddress;

	private static bool bSwitchingFreeToTurn_IsValid;

	private static int bSwitchingFreeToTurn_Offset;

	private static FFieldAddress bSwitchingFreeToTurn_PropertyAddress;

	private static bool bLockLoopToTurn_IsValid;

	private static int bLockLoopToTurn_Offset;

	private static FFieldAddress bLockLoopToTurn_PropertyAddress;

	private static bool bLockTurnToLoop_IsValid;

	private static int bLockTurnToLoop_Offset;

	private static FFieldAddress bLockTurnToLoop_PropertyAddress;

	private static bool bFreeLoopToTurn_IsValid;

	private static int bFreeLoopToTurn_Offset;

	private static FFieldAddress bFreeLoopToTurn_PropertyAddress;

	private static bool bFreeMoveToTurn_IsValid;

	private static int bFreeMoveToTurn_Offset;

	private static FFieldAddress bFreeMoveToTurn_PropertyAddress;

	private static bool bLockMoveToTurn_IsValid;

	private static int bLockMoveToTurn_Offset;

	private static FFieldAddress bLockMoveToTurn_PropertyAddress;

	private static bool bMoveStartSwitch_IsValid;

	private static int bMoveStartSwitch_Offset;

	private static FFieldAddress bMoveStartSwitch_PropertyAddress;

	private static bool bMoveTurnSwitch_IsValid;

	private static int bMoveTurnSwitch_Offset;

	private static FFieldAddress bMoveTurnSwitch_PropertyAddress;

	private static bool ShouldToMove_IsValid;

	private static IntPtr ShouldToMove_FunctionAddress;

	private static int ShouldToMove_ParamsSize;

	private static bool ShouldToMove_ReturnValue_IsValid;

	private static int ShouldToMove_ReturnValue_Offset;

	private static FFieldAddress ShouldToMove_ReturnValue_PropertyAddress;

	private static bool SetupIdleAnim_IsValid;

	private static IntPtr SetupIdleAnim_FunctionAddress;

	private static int SetupIdleAnim_ParamsSize;

	private static bool SetupIdleAnim_Context_IsValid;

	private static int SetupIdleAnim_Context_Offset;

	private static FFieldAddress SetupIdleAnim_Context_PropertyAddress;

	private static bool SetupIdleAnim_Node_IsValid;

	private static int SetupIdleAnim_Node_Offset;

	private static FFieldAddress SetupIdleAnim_Node_PropertyAddress;

	private static bool SetupIdleOutput_IsValid;

	private static IntPtr SetupIdleOutput_FunctionAddress;

	private static int SetupIdleOutput_ParamsSize;

	private static bool SetupIdleOutput_Context_IsValid;

	private static int SetupIdleOutput_Context_Offset;

	private static FFieldAddress SetupIdleOutput_Context_PropertyAddress;

	private static bool SetupIdleOutput_Node_IsValid;

	private static int SetupIdleOutput_Node_Offset;

	private static FFieldAddress SetupIdleOutput_Node_PropertyAddress;

	private static bool SetupMoveLoopAnim_IsValid;

	private static IntPtr SetupMoveLoopAnim_FunctionAddress;

	private static int SetupMoveLoopAnim_ParamsSize;

	private static bool SetupMoveLoopAnim_Context_IsValid;

	private static int SetupMoveLoopAnim_Context_Offset;

	private static FFieldAddress SetupMoveLoopAnim_Context_PropertyAddress;

	private static bool SetupMoveLoopAnim_Node_IsValid;

	private static int SetupMoveLoopAnim_Node_Offset;

	private static FFieldAddress SetupMoveLoopAnim_Node_PropertyAddress;

	private static bool SetupMoveStopAnim_IsValid;

	private static IntPtr SetupMoveStopAnim_FunctionAddress;

	private static int SetupMoveStopAnim_ParamsSize;

	private static bool SetupMoveStopAnim_Context_IsValid;

	private static int SetupMoveStopAnim_Context_Offset;

	private static FFieldAddress SetupMoveStopAnim_Context_PropertyAddress;

	private static bool SetupMoveStopAnim_Node_IsValid;

	private static int SetupMoveStopAnim_Node_Offset;

	private static FFieldAddress SetupMoveStopAnim_Node_PropertyAddress;

	private static bool SetupMoveTurnAnim_IsValid;

	private static IntPtr SetupMoveTurnAnim_FunctionAddress;

	private static int SetupMoveTurnAnim_ParamsSize;

	private static bool SetupMoveTurnAnim_Context_IsValid;

	private static int SetupMoveTurnAnim_Context_Offset;

	private static FFieldAddress SetupMoveTurnAnim_Context_PropertyAddress;

	private static bool SetupMoveTurnAnim_Node_IsValid;

	private static int SetupMoveTurnAnim_Node_Offset;

	private static FFieldAddress SetupMoveTurnAnim_Node_PropertyAddress;

	private static bool ShouldMoveLoopToBR_IsValid;

	private static IntPtr ShouldMoveLoopToBR_FunctionAddress;

	private static int ShouldMoveLoopToBR_ParamsSize;

	private static bool ShouldMoveLoopToBR_ReturnValue_IsValid;

	private static int ShouldMoveLoopToBR_ReturnValue_Offset;

	private static FFieldAddress ShouldMoveLoopToBR_ReturnValue_PropertyAddress;

	private static bool ShouldMoveLoopToBL_IsValid;

	private static IntPtr ShouldMoveLoopToBL_FunctionAddress;

	private static int ShouldMoveLoopToBL_ParamsSize;

	private static bool ShouldMoveLoopToBL_ReturnValue_IsValid;

	private static int ShouldMoveLoopToBL_ReturnValue_Offset;

	private static FFieldAddress ShouldMoveLoopToBL_ReturnValue_PropertyAddress;

	private static bool ShouldMoveLoopToFR_IsValid;

	private static IntPtr ShouldMoveLoopToFR_FunctionAddress;

	private static int ShouldMoveLoopToFR_ParamsSize;

	private static bool ShouldMoveLoopToFR_ReturnValue_IsValid;

	private static int ShouldMoveLoopToFR_ReturnValue_Offset;

	private static FFieldAddress ShouldMoveLoopToFR_ReturnValue_PropertyAddress;

	private static bool ShouldMoveLoopToFL_IsValid;

	private static IntPtr ShouldMoveLoopToFL_FunctionAddress;

	private static int ShouldMoveLoopToFL_ParamsSize;

	private static bool ShouldMoveLoopToFL_ReturnValue_IsValid;

	private static int ShouldMoveLoopToFL_ReturnValue_Offset;

	private static FFieldAddress ShouldMoveLoopToFL_ReturnValue_PropertyAddress;

	private static bool SetupMoveStartAnim_IsValid;

	private static IntPtr SetupMoveStartAnim_FunctionAddress;

	private static int SetupMoveStartAnim_ParamsSize;

	private static bool SetupMoveStartAnim_Context_IsValid;

	private static int SetupMoveStartAnim_Context_Offset;

	private static FFieldAddress SetupMoveStartAnim_Context_PropertyAddress;

	private static bool SetupMoveStartAnim_Node_IsValid;

	private static int SetupMoveStartAnim_Node_Offset;

	private static FFieldAddress SetupMoveStartAnim_Node_PropertyAddress;

	private static bool UpdateMoveStopAnim_IsValid;

	private static IntPtr UpdateMoveStopAnim_FunctionAddress;

	private static int UpdateMoveStopAnim_ParamsSize;

	private static bool UpdateMoveStopAnim_Context_IsValid;

	private static int UpdateMoveStopAnim_Context_Offset;

	private static FFieldAddress UpdateMoveStopAnim_Context_PropertyAddress;

	private static bool UpdateMoveStopAnim_Node_IsValid;

	private static int UpdateMoveStopAnim_Node_Offset;

	private static FFieldAddress UpdateMoveStopAnim_Node_PropertyAddress;

	private static bool UpdateMoveTurnAnim_IsValid;

	private static IntPtr UpdateMoveTurnAnim_FunctionAddress;

	private static int UpdateMoveTurnAnim_ParamsSize;

	private static bool UpdateMoveTurnAnim_Context_IsValid;

	private static int UpdateMoveTurnAnim_Context_Offset;

	private static FFieldAddress UpdateMoveTurnAnim_Context_PropertyAddress;

	private static bool UpdateMoveTurnAnim_Node_IsValid;

	private static int UpdateMoveTurnAnim_Node_Offset;

	private static FFieldAddress UpdateMoveTurnAnim_Node_PropertyAddress;

	private static bool SetupMoveTurnOutput_IsValid;

	private static IntPtr SetupMoveTurnOutput_FunctionAddress;

	private static int SetupMoveTurnOutput_ParamsSize;

	private static bool SetupMoveTurnOutput_Context_IsValid;

	private static int SetupMoveTurnOutput_Context_Offset;

	private static FFieldAddress SetupMoveTurnOutput_Context_PropertyAddress;

	private static bool SetupMoveTurnOutput_Node_IsValid;

	private static int SetupMoveTurnOutput_Node_Offset;

	private static FFieldAddress SetupMoveTurnOutput_Node_PropertyAddress;

	private static bool SetupMoveStopOutput_IsValid;

	private static IntPtr SetupMoveStopOutput_FunctionAddress;

	private static int SetupMoveStopOutput_ParamsSize;

	private static bool SetupMoveStopOutput_Context_IsValid;

	private static int SetupMoveStopOutput_Context_Offset;

	private static FFieldAddress SetupMoveStopOutput_Context_PropertyAddress;

	private static bool SetupMoveStopOutput_Node_IsValid;

	private static int SetupMoveStopOutput_Node_Offset;

	private static FFieldAddress SetupMoveStopOutput_Node_PropertyAddress;

	private static bool UpdateMoveStartAnim_IsValid;

	private static IntPtr UpdateMoveStartAnim_FunctionAddress;

	private static int UpdateMoveStartAnim_ParamsSize;

	private static bool UpdateMoveStartAnim_Context_IsValid;

	private static int UpdateMoveStartAnim_Context_Offset;

	private static FFieldAddress UpdateMoveStartAnim_Context_PropertyAddress;

	private static bool UpdateMoveStartAnim_Node_IsValid;

	private static int UpdateMoveStartAnim_Node_Offset;

	private static FFieldAddress UpdateMoveStartAnim_Node_PropertyAddress;

	private static bool SetupMoveLoopOutput_IsValid;

	private static IntPtr SetupMoveLoopOutput_FunctionAddress;

	private static int SetupMoveLoopOutput_ParamsSize;

	private static bool SetupMoveLoopOutput_Context_IsValid;

	private static int SetupMoveLoopOutput_Context_Offset;

	private static FFieldAddress SetupMoveLoopOutput_Context_PropertyAddress;

	private static bool SetupMoveLoopOutput_Node_IsValid;

	private static int SetupMoveLoopOutput_Node_Offset;

	private static FFieldAddress SetupMoveLoopOutput_Node_PropertyAddress;

	private static bool ShouldMoveLoopToFwd_IsValid;

	private static IntPtr ShouldMoveLoopToFwd_FunctionAddress;

	private static int ShouldMoveLoopToFwd_ParamsSize;

	private static bool ShouldMoveLoopToFwd_ReturnValue_IsValid;

	private static int ShouldMoveLoopToFwd_ReturnValue_Offset;

	private static FFieldAddress ShouldMoveLoopToFwd_ReturnValue_PropertyAddress;

	private static bool ShouldMoveLoopToBwd_IsValid;

	private static IntPtr ShouldMoveLoopToBwd_FunctionAddress;

	private static int ShouldMoveLoopToBwd_ParamsSize;

	private static bool ShouldMoveLoopToBwd_ReturnValue_IsValid;

	private static int ShouldMoveLoopToBwd_ReturnValue_Offset;

	private static FFieldAddress ShouldMoveLoopToBwd_ReturnValue_PropertyAddress;

	private static bool ShouldMoveLoopBRToFR_IsValid;

	private static IntPtr ShouldMoveLoopBRToFR_FunctionAddress;

	private static int ShouldMoveLoopBRToFR_ParamsSize;

	private static bool ShouldMoveLoopBRToFR_ReturnValue_IsValid;

	private static int ShouldMoveLoopBRToFR_ReturnValue_Offset;

	private static FFieldAddress ShouldMoveLoopBRToFR_ReturnValue_PropertyAddress;

	private static bool ShouldMoveLoopFRToBR_IsValid;

	private static IntPtr ShouldMoveLoopFRToBR_FunctionAddress;

	private static int ShouldMoveLoopFRToBR_ParamsSize;

	private static bool ShouldMoveLoopFRToBR_ReturnValue_IsValid;

	private static int ShouldMoveLoopFRToBR_ReturnValue_Offset;

	private static FFieldAddress ShouldMoveLoopFRToBR_ReturnValue_PropertyAddress;

	private static bool ShouldMoveLoopFLToBL_IsValid;

	private static IntPtr ShouldMoveLoopFLToBL_FunctionAddress;

	private static int ShouldMoveLoopFLToBL_ParamsSize;

	private static bool ShouldMoveLoopFLToBL_ReturnValue_IsValid;

	private static int ShouldMoveLoopFLToBL_ReturnValue_Offset;

	private static FFieldAddress ShouldMoveLoopFLToBL_ReturnValue_PropertyAddress;

	private static bool ShouldMoveLoopLeftBR_IsValid;

	private static IntPtr ShouldMoveLoopLeftBR_FunctionAddress;

	private static int ShouldMoveLoopLeftBR_ParamsSize;

	private static bool ShouldMoveLoopLeftBR_ReturnValue_IsValid;

	private static int ShouldMoveLoopLeftBR_ReturnValue_Offset;

	private static FFieldAddress ShouldMoveLoopLeftBR_ReturnValue_PropertyAddress;

	private static bool UpdateMoveTurnOutput_IsValid;

	private static IntPtr UpdateMoveTurnOutput_FunctionAddress;

	private static int UpdateMoveTurnOutput_ParamsSize;

	private static bool UpdateMoveTurnOutput_Context_IsValid;

	private static int UpdateMoveTurnOutput_Context_Offset;

	private static FFieldAddress UpdateMoveTurnOutput_Context_PropertyAddress;

	private static bool UpdateMoveTurnOutput_Node_IsValid;

	private static int UpdateMoveTurnOutput_Node_Offset;

	private static FFieldAddress UpdateMoveTurnOutput_Node_PropertyAddress;

	private static bool ShouldMoveLoopLeftFR_IsValid;

	private static IntPtr ShouldMoveLoopLeftFR_FunctionAddress;

	private static int ShouldMoveLoopLeftFR_ParamsSize;

	private static bool ShouldMoveLoopLeftFR_ReturnValue_IsValid;

	private static int ShouldMoveLoopLeftFR_ReturnValue_Offset;

	private static FFieldAddress ShouldMoveLoopLeftFR_ReturnValue_PropertyAddress;

	private static bool ShouldMoveLoopLeftFL_IsValid;

	private static IntPtr ShouldMoveLoopLeftFL_FunctionAddress;

	private static int ShouldMoveLoopLeftFL_ParamsSize;

	private static bool ShouldMoveLoopLeftFL_ReturnValue_IsValid;

	private static int ShouldMoveLoopLeftFL_ReturnValue_Offset;

	private static FFieldAddress ShouldMoveLoopLeftFL_ReturnValue_PropertyAddress;

	private static bool UpdateMoveStopOutput_IsValid;

	private static IntPtr UpdateMoveStopOutput_FunctionAddress;

	private static int UpdateMoveStopOutput_ParamsSize;

	private static bool UpdateMoveStopOutput_Context_IsValid;

	private static int UpdateMoveStopOutput_Context_Offset;

	private static FFieldAddress UpdateMoveStopOutput_Context_PropertyAddress;

	private static bool UpdateMoveStopOutput_Node_IsValid;

	private static int UpdateMoveStopOutput_Node_Offset;

	private static FFieldAddress UpdateMoveStopOutput_Node_PropertyAddress;

	private static bool UpdateMoveLoopOutput_IsValid;

	private static IntPtr UpdateMoveLoopOutput_FunctionAddress;

	private static int UpdateMoveLoopOutput_ParamsSize;

	private static bool UpdateMoveLoopOutput_Context_IsValid;

	private static int UpdateMoveLoopOutput_Context_Offset;

	private static FFieldAddress UpdateMoveLoopOutput_Context_PropertyAddress;

	private static bool UpdateMoveLoopOutput_Node_IsValid;

	private static int UpdateMoveLoopOutput_Node_Offset;

	private static FFieldAddress UpdateMoveLoopOutput_Node_PropertyAddress;

	private static bool UpdateMoveLoopBRAnim_IsValid;

	private static IntPtr UpdateMoveLoopBRAnim_FunctionAddress;

	private static int UpdateMoveLoopBRAnim_ParamsSize;

	private static bool UpdateMoveLoopBRAnim_Context_IsValid;

	private static int UpdateMoveLoopBRAnim_Context_Offset;

	private static FFieldAddress UpdateMoveLoopBRAnim_Context_PropertyAddress;

	private static bool UpdateMoveLoopBRAnim_Node_IsValid;

	private static int UpdateMoveLoopBRAnim_Node_Offset;

	private static FFieldAddress UpdateMoveLoopBRAnim_Node_PropertyAddress;

	private static bool UpdateMoveLoopBLAnim_IsValid;

	private static IntPtr UpdateMoveLoopBLAnim_FunctionAddress;

	private static int UpdateMoveLoopBLAnim_ParamsSize;

	private static bool UpdateMoveLoopBLAnim_Context_IsValid;

	private static int UpdateMoveLoopBLAnim_Context_Offset;

	private static FFieldAddress UpdateMoveLoopBLAnim_Context_PropertyAddress;

	private static bool UpdateMoveLoopBLAnim_Node_IsValid;

	private static int UpdateMoveLoopBLAnim_Node_Offset;

	private static FFieldAddress UpdateMoveLoopBLAnim_Node_PropertyAddress;

	private static bool UpdateMoveLoopFRAnim_IsValid;

	private static IntPtr UpdateMoveLoopFRAnim_FunctionAddress;

	private static int UpdateMoveLoopFRAnim_ParamsSize;

	private static bool UpdateMoveLoopFRAnim_Context_IsValid;

	private static int UpdateMoveLoopFRAnim_Context_Offset;

	private static FFieldAddress UpdateMoveLoopFRAnim_Context_PropertyAddress;

	private static bool UpdateMoveLoopFRAnim_Node_IsValid;

	private static int UpdateMoveLoopFRAnim_Node_Offset;

	private static FFieldAddress UpdateMoveLoopFRAnim_Node_PropertyAddress;

	private static bool UpdateMoveLoopFLAnim_IsValid;

	private static IntPtr UpdateMoveLoopFLAnim_FunctionAddress;

	private static int UpdateMoveLoopFLAnim_ParamsSize;

	private static bool UpdateMoveLoopFLAnim_Context_IsValid;

	private static int UpdateMoveLoopFLAnim_Context_Offset;

	private static FFieldAddress UpdateMoveLoopFLAnim_Context_PropertyAddress;

	private static bool UpdateMoveLoopFLAnim_Node_IsValid;

	private static int UpdateMoveLoopFLAnim_Node_Offset;

	private static FFieldAddress UpdateMoveLoopFLAnim_Node_PropertyAddress;

	private static bool SetupMoveStartOutput_IsValid;

	private static IntPtr SetupMoveStartOutput_FunctionAddress;

	private static int SetupMoveStartOutput_ParamsSize;

	private static bool SetupMoveStartOutput_Context_IsValid;

	private static int SetupMoveStartOutput_Context_Offset;

	private static FFieldAddress SetupMoveStartOutput_Context_PropertyAddress;

	private static bool SetupMoveStartOutput_Node_IsValid;

	private static int SetupMoveStartOutput_Node_Offset;

	private static FFieldAddress SetupMoveStartOutput_Node_PropertyAddress;

	private static bool ShouldMoveLoopLeftBL_IsValid;

	private static IntPtr ShouldMoveLoopLeftBL_FunctionAddress;

	private static int ShouldMoveLoopLeftBL_ParamsSize;

	private static bool ShouldMoveLoopLeftBL_ReturnValue_IsValid;

	private static int ShouldMoveLoopLeftBL_ReturnValue_Offset;

	private static FFieldAddress ShouldMoveLoopLeftBL_ReturnValue_PropertyAddress;

	private static bool ShouldMoveLoopBLToFL_IsValid;

	private static IntPtr ShouldMoveLoopBLToFL_FunctionAddress;

	private static int ShouldMoveLoopBLToFL_ParamsSize;

	private static bool ShouldMoveLoopBLToFL_ReturnValue_IsValid;

	private static int ShouldMoveLoopBLToFL_ReturnValue_Offset;

	private static FFieldAddress ShouldMoveLoopBLToFL_ReturnValue_PropertyAddress;

	private static bool ShouldMoveLoopLeftBwd_IsValid;

	private static IntPtr ShouldMoveLoopLeftBwd_FunctionAddress;

	private static int ShouldMoveLoopLeftBwd_ParamsSize;

	private static bool ShouldMoveLoopLeftBwd_ReturnValue_IsValid;

	private static int ShouldMoveLoopLeftBwd_ReturnValue_Offset;

	private static FFieldAddress ShouldMoveLoopLeftBwd_ReturnValue_PropertyAddress;

	private static bool ShouldMoveLoopLeftFwd_IsValid;

	private static IntPtr ShouldMoveLoopLeftFwd_FunctionAddress;

	private static int ShouldMoveLoopLeftFwd_ParamsSize;

	private static bool ShouldMoveLoopLeftFwd_ReturnValue_IsValid;

	private static int ShouldMoveLoopLeftFwd_ReturnValue_Offset;

	private static FFieldAddress ShouldMoveLoopLeftFwd_ReturnValue_PropertyAddress;

	private static bool UpdateMoveLoopFwdAnim_IsValid;

	private static IntPtr UpdateMoveLoopFwdAnim_FunctionAddress;

	private static int UpdateMoveLoopFwdAnim_ParamsSize;

	private static bool UpdateMoveLoopFwdAnim_Context_IsValid;

	private static int UpdateMoveLoopFwdAnim_Context_Offset;

	private static FFieldAddress UpdateMoveLoopFwdAnim_Context_PropertyAddress;

	private static bool UpdateMoveLoopFwdAnim_Node_IsValid;

	private static int UpdateMoveLoopFwdAnim_Node_Offset;

	private static FFieldAddress UpdateMoveLoopFwdAnim_Node_PropertyAddress;

	private static bool UpdateMoveLoopBwdAnim_IsValid;

	private static IntPtr UpdateMoveLoopBwdAnim_FunctionAddress;

	private static int UpdateMoveLoopBwdAnim_ParamsSize;

	private static bool UpdateMoveLoopBwdAnim_Context_IsValid;

	private static int UpdateMoveLoopBwdAnim_Context_Offset;

	private static FFieldAddress UpdateMoveLoopBwdAnim_Context_PropertyAddress;

	private static bool UpdateMoveLoopBwdAnim_Node_IsValid;

	private static int UpdateMoveLoopBwdAnim_Node_Offset;

	private static FFieldAddress UpdateMoveLoopBwdAnim_Node_PropertyAddress;

	private static bool ShouldMoveLoopTransToFL_IsValid;

	private static IntPtr ShouldMoveLoopTransToFL_FunctionAddress;

	private static int ShouldMoveLoopTransToFL_ParamsSize;

	private static bool ShouldMoveLoopTransToFL_ReturnValue_IsValid;

	private static int ShouldMoveLoopTransToFL_ReturnValue_Offset;

	private static FFieldAddress ShouldMoveLoopTransToFL_ReturnValue_PropertyAddress;

	private static bool ShouldMoveLoopTransToFR_IsValid;

	private static IntPtr ShouldMoveLoopTransToFR_FunctionAddress;

	private static int ShouldMoveLoopTransToFR_ParamsSize;

	private static bool ShouldMoveLoopTransToFR_ReturnValue_IsValid;

	private static int ShouldMoveLoopTransToFR_ReturnValue_Offset;

	private static FFieldAddress ShouldMoveLoopTransToFR_ReturnValue_PropertyAddress;

	private static bool ShouldMoveLoopTransToBR_IsValid;

	private static IntPtr ShouldMoveLoopTransToBR_FunctionAddress;

	private static int ShouldMoveLoopTransToBR_ParamsSize;

	private static bool ShouldMoveLoopTransToBR_ReturnValue_IsValid;

	private static int ShouldMoveLoopTransToBR_ReturnValue_Offset;

	private static FFieldAddress ShouldMoveLoopTransToBR_ReturnValue_PropertyAddress;

	private static bool UpdateMoveLoopTransAnim_IsValid;

	private static IntPtr UpdateMoveLoopTransAnim_FunctionAddress;

	private static int UpdateMoveLoopTransAnim_ParamsSize;

	private static bool UpdateMoveLoopTransAnim_Context_IsValid;

	private static int UpdateMoveLoopTransAnim_Context_Offset;

	private static FFieldAddress UpdateMoveLoopTransAnim_Context_PropertyAddress;

	private static bool UpdateMoveLoopTransAnim_Node_IsValid;

	private static int UpdateMoveLoopTransAnim_Node_Offset;

	private static FFieldAddress UpdateMoveLoopTransAnim_Node_PropertyAddress;

	private static bool ShouldMoveLoopTransToBL_IsValid;

	private static IntPtr ShouldMoveLoopTransToBL_FunctionAddress;

	private static int ShouldMoveLoopTransToBL_ParamsSize;

	private static bool ShouldMoveLoopTransToBL_ReturnValue_IsValid;

	private static int ShouldMoveLoopTransToBL_ReturnValue_Offset;

	private static FFieldAddress ShouldMoveLoopTransToBL_ReturnValue_PropertyAddress;

	private static bool UpdateMoveLoopSimpleAnim_IsValid;

	private static IntPtr UpdateMoveLoopSimpleAnim_FunctionAddress;

	private static int UpdateMoveLoopSimpleAnim_ParamsSize;

	private static bool UpdateMoveLoopSimpleAnim_Context_IsValid;

	private static int UpdateMoveLoopSimpleAnim_Context_Offset;

	private static FFieldAddress UpdateMoveLoopSimpleAnim_Context_PropertyAddress;

	private static bool UpdateMoveLoopSimpleAnim_Node_IsValid;

	private static int UpdateMoveLoopSimpleAnim_Node_Offset;

	private static FFieldAddress UpdateMoveLoopSimpleAnim_Node_PropertyAddress;

	private static bool ShouldMoveTurnSwitchFree_IsValid;

	private static IntPtr ShouldMoveTurnSwitchFree_FunctionAddress;

	private static int ShouldMoveTurnSwitchFree_ParamsSize;

	private static bool ShouldMoveTurnSwitchFree_ReturnValue_IsValid;

	private static int ShouldMoveTurnSwitchFree_ReturnValue_Offset;

	private static FFieldAddress ShouldMoveTurnSwitchFree_ReturnValue_PropertyAddress;

	private static bool ShouldMoveTurnSwitchLock_IsValid;

	private static IntPtr ShouldMoveTurnSwitchLock_FunctionAddress;

	private static int ShouldMoveTurnSwitchLock_ParamsSize;

	private static bool ShouldMoveTurnSwitchLock_ReturnValue_IsValid;

	private static int ShouldMoveTurnSwitchLock_ReturnValue_Offset;

	private static FFieldAddress ShouldMoveTurnSwitchLock_ReturnValue_PropertyAddress;

	private static bool SetupMoveLoopAdditiveAnim_IsValid;

	private static IntPtr SetupMoveLoopAdditiveAnim_FunctionAddress;

	private static int SetupMoveLoopAdditiveAnim_ParamsSize;

	private static bool SetupMoveLoopAdditiveAnim_Context_IsValid;

	private static int SetupMoveLoopAdditiveAnim_Context_Offset;

	private static FFieldAddress SetupMoveLoopAdditiveAnim_Context_PropertyAddress;

	private static bool SetupMoveLoopAdditiveAnim_Node_IsValid;

	private static int SetupMoveLoopAdditiveAnim_Node_Offset;

	private static FFieldAddress SetupMoveLoopAdditiveAnim_Node_PropertyAddress;

	private static bool UpdateMoveLoopLB2LFOutput_IsValid;

	private static IntPtr UpdateMoveLoopLB2LFOutput_FunctionAddress;

	private static int UpdateMoveLoopLB2LFOutput_ParamsSize;

	private static bool UpdateMoveLoopLB2LFOutput_Context_IsValid;

	private static int UpdateMoveLoopLB2LFOutput_Context_Offset;

	private static FFieldAddress UpdateMoveLoopLB2LFOutput_Context_PropertyAddress;

	private static bool UpdateMoveLoopLB2LFOutput_Node_IsValid;

	private static int UpdateMoveLoopLB2LFOutput_Node_Offset;

	private static FFieldAddress UpdateMoveLoopLB2LFOutput_Node_PropertyAddress;

	private static bool UpdateMoveLoopRB2RFOutput_IsValid;

	private static IntPtr UpdateMoveLoopRB2RFOutput_FunctionAddress;

	private static int UpdateMoveLoopRB2RFOutput_ParamsSize;

	private static bool UpdateMoveLoopRB2RFOutput_Context_IsValid;

	private static int UpdateMoveLoopRB2RFOutput_Context_Offset;

	private static FFieldAddress UpdateMoveLoopRB2RFOutput_Context_PropertyAddress;

	private static bool UpdateMoveLoopRB2RFOutput_Node_IsValid;

	private static int UpdateMoveLoopRB2RFOutput_Node_Offset;

	private static FFieldAddress UpdateMoveLoopRB2RFOutput_Node_PropertyAddress;

	private static bool UpdateMoveLoopRF2RBOutput_IsValid;

	private static IntPtr UpdateMoveLoopRF2RBOutput_FunctionAddress;

	private static int UpdateMoveLoopRF2RBOutput_ParamsSize;

	private static bool UpdateMoveLoopRF2RBOutput_Context_IsValid;

	private static int UpdateMoveLoopRF2RBOutput_Context_Offset;

	private static FFieldAddress UpdateMoveLoopRF2RBOutput_Context_PropertyAddress;

	private static bool UpdateMoveLoopRF2RBOutput_Node_IsValid;

	private static int UpdateMoveLoopRF2RBOutput_Node_Offset;

	private static FFieldAddress UpdateMoveLoopRF2RBOutput_Node_PropertyAddress;

	private static bool UpdateMoveLoopLF2LBOutput_IsValid;

	private static IntPtr UpdateMoveLoopLF2LBOutput_FunctionAddress;

	private static int UpdateMoveLoopLF2LBOutput_ParamsSize;

	private static bool UpdateMoveLoopLF2LBOutput_Context_IsValid;

	private static int UpdateMoveLoopLF2LBOutput_Context_Offset;

	private static FFieldAddress UpdateMoveLoopLF2LBOutput_Context_PropertyAddress;

	private static bool UpdateMoveLoopLF2LBOutput_Node_IsValid;

	private static int UpdateMoveLoopLF2LBOutput_Node_Offset;

	private static FFieldAddress UpdateMoveLoopLF2LBOutput_Node_PropertyAddress;

	private static bool ShouldMoveLoopLeftTransBR_IsValid;

	private static IntPtr ShouldMoveLoopLeftTransBR_FunctionAddress;

	private static int ShouldMoveLoopLeftTransBR_ParamsSize;

	private static bool ShouldMoveLoopLeftTransBR_ReturnValue_IsValid;

	private static int ShouldMoveLoopLeftTransBR_ReturnValue_Offset;

	private static FFieldAddress ShouldMoveLoopLeftTransBR_ReturnValue_PropertyAddress;

	private static bool ShouldMoveLoopLeftTransFL_IsValid;

	private static IntPtr ShouldMoveLoopLeftTransFL_FunctionAddress;

	private static int ShouldMoveLoopLeftTransFL_ParamsSize;

	private static bool ShouldMoveLoopLeftTransFL_ReturnValue_IsValid;

	private static int ShouldMoveLoopLeftTransFL_ReturnValue_Offset;

	private static FFieldAddress ShouldMoveLoopLeftTransFL_ReturnValue_PropertyAddress;

	private static bool ShouldMoveLoopLeftTransBL_IsValid;

	private static IntPtr ShouldMoveLoopLeftTransBL_FunctionAddress;

	private static int ShouldMoveLoopLeftTransBL_ParamsSize;

	private static bool ShouldMoveLoopLeftTransBL_ReturnValue_IsValid;

	private static int ShouldMoveLoopLeftTransBL_ReturnValue_Offset;

	private static FFieldAddress ShouldMoveLoopLeftTransBL_ReturnValue_PropertyAddress;

	private static bool ShouldMoveLoopLeftTransFR_IsValid;

	private static IntPtr ShouldMoveLoopLeftTransFR_FunctionAddress;

	private static int ShouldMoveLoopLeftTransFR_ParamsSize;

	private static bool ShouldMoveLoopLeftTransFR_ReturnValue_IsValid;

	private static int ShouldMoveLoopLeftTransFR_ReturnValue_Offset;

	private static FFieldAddress ShouldMoveLoopLeftTransFR_ReturnValue_PropertyAddress;

	private static bool UpdateMoveLoopStateMachine_IsValid;

	private static IntPtr UpdateMoveLoopStateMachine_FunctionAddress;

	private static int UpdateMoveLoopStateMachine_ParamsSize;

	private static bool UpdateMoveLoopStateMachine_Context_IsValid;

	private static int UpdateMoveLoopStateMachine_Context_Offset;

	private static FFieldAddress UpdateMoveLoopStateMachine_Context_PropertyAddress;

	private static bool UpdateMoveLoopStateMachine_Node_IsValid;

	private static int UpdateMoveLoopStateMachine_Node_Offset;

	private static FFieldAddress UpdateMoveLoopStateMachine_Node_PropertyAddress;

	private static bool ShouldMoveTurnSwitchLockToFree_IsValid;

	private static IntPtr ShouldMoveTurnSwitchLockToFree_FunctionAddress;

	private static int ShouldMoveTurnSwitchLockToFree_ParamsSize;

	private static bool ShouldMoveTurnSwitchLockToFree_ReturnValue_IsValid;

	private static int ShouldMoveTurnSwitchLockToFree_ReturnValue_Offset;

	private static FFieldAddress ShouldMoveTurnSwitchLockToFree_ReturnValue_PropertyAddress;

	[UProperty]
	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:FreeMode")]
	public ELMFreeMode FreeMode
	{
		get
		{
			CheckDestroyed();
			if (!FreeMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:FreeMode");
				return ELMFreeMode.Normal;
			}
			return EnumMarshaler<ELMFreeMode>.FromNative(IntPtr.Add(base.Address, FreeMode_Offset), 0, FreeMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!FreeMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:FreeMode");
			}
			else
			{
				EnumMarshaler<ELMFreeMode>.ToNative(IntPtr.Add(base.Address, FreeMode_Offset), 0, FreeMode_PropertyAddress.Address, value);
			}
		}
	}

	[Category("AdvancedMonsterLocomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:LockMode")]
	public ELMLockMode LockMode
	{
		get
		{
			CheckDestroyed();
			if (!LockMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:LockMode");
				return ELMLockMode.Normal;
			}
			return EnumMarshaler<ELMLockMode>.FromNative(IntPtr.Add(base.Address, LockMode_Offset), 0, LockMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!LockMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:LockMode");
			}
			else
			{
				EnumMarshaler<ELMLockMode>.ToNative(IntPtr.Add(base.Address, LockMode_Offset), 0, LockMode_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:StartAngle")]
	public float StartAngle
	{
		get
		{
			CheckDestroyed();
			if (!StartAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:StartAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, StartAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StartAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:StartAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, StartAngle_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:StrideWarpingStartAlpha")]
	public float StrideWarpingStartAlpha
	{
		get
		{
			CheckDestroyed();
			if (!StrideWarpingStartAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:StrideWarpingStartAlpha");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, StrideWarpingStartAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StrideWarpingStartAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:StrideWarpingStartAlpha");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, StrideWarpingStartAlpha_Offset), value);
			}
		}
	}

	[Category("AdvancedMonsterLocomotion")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:StrideWarpingLoopAlpha")]
	public float StrideWarpingLoopAlpha
	{
		get
		{
			CheckDestroyed();
			if (!StrideWarpingLoopAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:StrideWarpingLoopAlpha");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, StrideWarpingLoopAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StrideWarpingLoopAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:StrideWarpingLoopAlpha");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, StrideWarpingLoopAlpha_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("AdvancedMonsterLocomotion")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:StrideWarpingTurnAlpha")]
	public float StrideWarpingTurnAlpha
	{
		get
		{
			CheckDestroyed();
			if (!StrideWarpingTurnAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:StrideWarpingTurnAlpha");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, StrideWarpingTurnAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StrideWarpingTurnAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:StrideWarpingTurnAlpha");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, StrideWarpingTurnAlpha_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:MoveLoopSpine01AngleOffset")]
	public float MoveLoopSpine01AngleOffset
	{
		get
		{
			CheckDestroyed();
			if (!MoveLoopSpine01AngleOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:MoveLoopSpine01AngleOffset");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MoveLoopSpine01AngleOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MoveLoopSpine01AngleOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:MoveLoopSpine01AngleOffset");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MoveLoopSpine01AngleOffset_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:MoveLoopSpine02AngleOffset")]
	public float MoveLoopSpine02AngleOffset
	{
		get
		{
			CheckDestroyed();
			if (!MoveLoopSpine02AngleOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:MoveLoopSpine02AngleOffset");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MoveLoopSpine02AngleOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MoveLoopSpine02AngleOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:MoveLoopSpine02AngleOffset");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MoveLoopSpine02AngleOffset_Offset), value);
			}
		}
	}

	[Category("AdvancedMonsterLocomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:MoveLoopSpine03AngleOffset")]
	public float MoveLoopSpine03AngleOffset
	{
		get
		{
			CheckDestroyed();
			if (!MoveLoopSpine03AngleOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:MoveLoopSpine03AngleOffset");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MoveLoopSpine03AngleOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MoveLoopSpine03AngleOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:MoveLoopSpine03AngleOffset");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MoveLoopSpine03AngleOffset_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:MoveLoopHeadAngleOffset")]
	public float MoveLoopHeadAngleOffset
	{
		get
		{
			CheckDestroyed();
			if (!MoveLoopHeadAngleOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:MoveLoopHeadAngleOffset");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MoveLoopHeadAngleOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MoveLoopHeadAngleOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:MoveLoopHeadAngleOffset");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MoveLoopHeadAngleOffset_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:MoveLoopPelvisLocalOffset")]
	public float MoveLoopPelvisLocalOffset
	{
		get
		{
			CheckDestroyed();
			if (!MoveLoopPelvisLocalOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:MoveLoopPelvisLocalOffset");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MoveLoopPelvisLocalOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MoveLoopPelvisLocalOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:MoveLoopPelvisLocalOffset");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MoveLoopPelvisLocalOffset_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:MoveLoopPelvisAngleOffset")]
	public float MoveLoopPelvisAngleOffset
	{
		get
		{
			CheckDestroyed();
			if (!MoveLoopPelvisAngleOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:MoveLoopPelvisAngleOffset");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MoveLoopPelvisAngleOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MoveLoopPelvisAngleOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:MoveLoopPelvisAngleOffset");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MoveLoopPelvisAngleOffset_Offset), value);
			}
		}
	}

	[Category("AdvancedMonsterLocomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkStartFwd")]
	public UAnimSequence ASWalkStartFwd
	{
		get
		{
			CheckDestroyed();
			if (!ASWalkStartFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkStartFwd");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASWalkStartFwd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASWalkStartFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkStartFwd");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASWalkStartFwd_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkStartBwd")]
	public UAnimSequence ASWalkStartBwd
	{
		get
		{
			CheckDestroyed();
			if (!ASWalkStartBwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkStartBwd");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASWalkStartBwd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASWalkStartBwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkStartBwd");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASWalkStartBwd_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkStartLeftMin")]
	public UAnimSequence ASWalkStartLeftMin
	{
		get
		{
			CheckDestroyed();
			if (!ASWalkStartLeftMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkStartLeftMin");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASWalkStartLeftMin_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASWalkStartLeftMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkStartLeftMin");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASWalkStartLeftMin_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkStartLeftMax")]
	public UAnimSequence ASWalkStartLeftMax
	{
		get
		{
			CheckDestroyed();
			if (!ASWalkStartLeftMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkStartLeftMax");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASWalkStartLeftMax_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASWalkStartLeftMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkStartLeftMax");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASWalkStartLeftMax_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("AdvancedMonsterLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkStartRightMin")]
	public UAnimSequence ASWalkStartRightMin
	{
		get
		{
			CheckDestroyed();
			if (!ASWalkStartRightMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkStartRightMin");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASWalkStartRightMin_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASWalkStartRightMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkStartRightMin");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASWalkStartRightMin_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkStartRightMax")]
	public UAnimSequence ASWalkStartRightMax
	{
		get
		{
			CheckDestroyed();
			if (!ASWalkStartRightMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkStartRightMax");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASWalkStartRightMax_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASWalkStartRightMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkStartRightMax");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASWalkStartRightMax_Offset), value);
			}
		}
	}

	[Category("AdvancedMonsterLocomotion")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkStartLF")]
	public UAnimSequence ASWalkStartLF
	{
		get
		{
			CheckDestroyed();
			if (!ASWalkStartLF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkStartLF");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASWalkStartLF_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASWalkStartLF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkStartLF");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASWalkStartLF_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkStartLB")]
	public UAnimSequence ASWalkStartLB
	{
		get
		{
			CheckDestroyed();
			if (!ASWalkStartLB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkStartLB");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASWalkStartLB_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASWalkStartLB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkStartLB");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASWalkStartLB_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkStartRF")]
	public UAnimSequence ASWalkStartRF
	{
		get
		{
			CheckDestroyed();
			if (!ASWalkStartRF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkStartRF");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASWalkStartRF_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASWalkStartRF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkStartRF");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASWalkStartRF_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("AdvancedMonsterLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkStartRB")]
	public UAnimSequence ASWalkStartRB
	{
		get
		{
			CheckDestroyed();
			if (!ASWalkStartRB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkStartRB");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASWalkStartRB_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASWalkStartRB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkStartRB");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASWalkStartRB_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("AdvancedMonsterLocomotion")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkLoopFwd")]
	public UAnimSequence ASWalkLoopFwd
	{
		get
		{
			CheckDestroyed();
			if (!ASWalkLoopFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkLoopFwd");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASWalkLoopFwd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASWalkLoopFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkLoopFwd");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASWalkLoopFwd_Offset), value);
			}
		}
	}

	[Category("AdvancedMonsterLocomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkLoopBwd")]
	public UAnimSequence ASWalkLoopBwd
	{
		get
		{
			CheckDestroyed();
			if (!ASWalkLoopBwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkLoopBwd");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASWalkLoopBwd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASWalkLoopBwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkLoopBwd");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASWalkLoopBwd_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("AdvancedMonsterLocomotion")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkLoopLF")]
	public UAnimSequence ASWalkLoopLF
	{
		get
		{
			CheckDestroyed();
			if (!ASWalkLoopLF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkLoopLF");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASWalkLoopLF_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASWalkLoopLF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkLoopLF");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASWalkLoopLF_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("AdvancedMonsterLocomotion")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkLoopLB")]
	public UAnimSequence ASWalkLoopLB
	{
		get
		{
			CheckDestroyed();
			if (!ASWalkLoopLB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkLoopLB");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASWalkLoopLB_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASWalkLoopLB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkLoopLB");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASWalkLoopLB_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkLoopRF")]
	public UAnimSequence ASWalkLoopRF
	{
		get
		{
			CheckDestroyed();
			if (!ASWalkLoopRF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkLoopRF");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASWalkLoopRF_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASWalkLoopRF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkLoopRF");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASWalkLoopRF_Offset), value);
			}
		}
	}

	[Category("AdvancedMonsterLocomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkLoopRB")]
	public UAnimSequence ASWalkLoopRB
	{
		get
		{
			CheckDestroyed();
			if (!ASWalkLoopRB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkLoopRB");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASWalkLoopRB_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASWalkLoopRB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkLoopRB");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASWalkLoopRB_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkSharpturnLeftMin")]
	public UAnimSequence ASWalkSharpturnLeftMin
	{
		get
		{
			CheckDestroyed();
			if (!ASWalkSharpturnLeftMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkSharpturnLeftMin");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASWalkSharpturnLeftMin_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASWalkSharpturnLeftMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkSharpturnLeftMin");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASWalkSharpturnLeftMin_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("AdvancedMonsterLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkSharpturnLeftMax")]
	public UAnimSequence ASWalkSharpturnLeftMax
	{
		get
		{
			CheckDestroyed();
			if (!ASWalkSharpturnLeftMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkSharpturnLeftMax");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASWalkSharpturnLeftMax_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASWalkSharpturnLeftMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkSharpturnLeftMax");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASWalkSharpturnLeftMax_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkSharpturnRightMin")]
	public UAnimSequence ASWalkSharpturnRightMin
	{
		get
		{
			CheckDestroyed();
			if (!ASWalkSharpturnRightMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkSharpturnRightMin");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASWalkSharpturnRightMin_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASWalkSharpturnRightMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkSharpturnRightMin");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASWalkSharpturnRightMin_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkSharpturnRightMax")]
	public UAnimSequence ASWalkSharpturnRightMax
	{
		get
		{
			CheckDestroyed();
			if (!ASWalkSharpturnRightMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkSharpturnRightMax");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASWalkSharpturnRightMax_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASWalkSharpturnRightMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkSharpturnRightMax");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASWalkSharpturnRightMax_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkPivotFwd")]
	public UAnimSequence ASWalkPivotFwd
	{
		get
		{
			CheckDestroyed();
			if (!ASWalkPivotFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkPivotFwd");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASWalkPivotFwd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASWalkPivotFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkPivotFwd");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASWalkPivotFwd_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkPivotBwd")]
	public UAnimSequence ASWalkPivotBwd
	{
		get
		{
			CheckDestroyed();
			if (!ASWalkPivotBwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkPivotBwd");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASWalkPivotBwd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASWalkPivotBwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkPivotBwd");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASWalkPivotBwd_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("AdvancedMonsterLocomotion")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkPivotLF")]
	public UAnimSequence ASWalkPivotLF
	{
		get
		{
			CheckDestroyed();
			if (!ASWalkPivotLF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkPivotLF");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASWalkPivotLF_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASWalkPivotLF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkPivotLF");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASWalkPivotLF_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("AdvancedMonsterLocomotion")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkPivotLB")]
	public UAnimSequence ASWalkPivotLB
	{
		get
		{
			CheckDestroyed();
			if (!ASWalkPivotLB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkPivotLB");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASWalkPivotLB_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASWalkPivotLB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkPivotLB");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASWalkPivotLB_Offset), value);
			}
		}
	}

	[Category("AdvancedMonsterLocomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkPivotRF")]
	public UAnimSequence ASWalkPivotRF
	{
		get
		{
			CheckDestroyed();
			if (!ASWalkPivotRF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkPivotRF");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASWalkPivotRF_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASWalkPivotRF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkPivotRF");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASWalkPivotRF_Offset), value);
			}
		}
	}

	[Category("AdvancedMonsterLocomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkPivotRB")]
	public UAnimSequence ASWalkPivotRB
	{
		get
		{
			CheckDestroyed();
			if (!ASWalkPivotRB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkPivotRB");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASWalkPivotRB_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASWalkPivotRB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkPivotRB");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASWalkPivotRB_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("AdvancedMonsterLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkTransFRToBR")]
	public UAnimSequence ASWalkTransFRToBR
	{
		get
		{
			CheckDestroyed();
			if (!ASWalkTransFRToBR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkTransFRToBR");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASWalkTransFRToBR_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASWalkTransFRToBR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkTransFRToBR");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASWalkTransFRToBR_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkTransBRToFR")]
	public UAnimSequence ASWalkTransBRToFR
	{
		get
		{
			CheckDestroyed();
			if (!ASWalkTransBRToFR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkTransBRToFR");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASWalkTransBRToFR_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASWalkTransBRToFR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkTransBRToFR");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASWalkTransBRToFR_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkTransFLToBL")]
	public UAnimSequence ASWalkTransFLToBL
	{
		get
		{
			CheckDestroyed();
			if (!ASWalkTransFLToBL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkTransFLToBL");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASWalkTransFLToBL_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASWalkTransFLToBL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkTransFLToBL");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASWalkTransFLToBL_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkTransBLToFL")]
	public UAnimSequence ASWalkTransBLToFL
	{
		get
		{
			CheckDestroyed();
			if (!ASWalkTransBLToFL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkTransBLToFL");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASWalkTransBLToFL_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASWalkTransBLToFL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkTransBLToFL");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASWalkTransBLToFL_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkStopFwd")]
	public UAnimSequence ASWalkStopFwd
	{
		get
		{
			CheckDestroyed();
			if (!ASWalkStopFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkStopFwd");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASWalkStopFwd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASWalkStopFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkStopFwd");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASWalkStopFwd_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkStopBwd")]
	public UAnimSequence ASWalkStopBwd
	{
		get
		{
			CheckDestroyed();
			if (!ASWalkStopBwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkStopBwd");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASWalkStopBwd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASWalkStopBwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkStopBwd");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASWalkStopBwd_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkStopLF")]
	public UAnimSequence ASWalkStopLF
	{
		get
		{
			CheckDestroyed();
			if (!ASWalkStopLF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkStopLF");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASWalkStopLF_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASWalkStopLF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkStopLF");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASWalkStopLF_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkStopLB")]
	public UAnimSequence ASWalkStopLB
	{
		get
		{
			CheckDestroyed();
			if (!ASWalkStopLB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkStopLB");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASWalkStopLB_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASWalkStopLB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkStopLB");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASWalkStopLB_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("AdvancedMonsterLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkStopRF")]
	public UAnimSequence ASWalkStopRF
	{
		get
		{
			CheckDestroyed();
			if (!ASWalkStopRF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkStopRF");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASWalkStopRF_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASWalkStopRF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkStopRF");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASWalkStopRF_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkStopRB")]
	public UAnimSequence ASWalkStopRB
	{
		get
		{
			CheckDestroyed();
			if (!ASWalkStopRB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkStopRB");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASWalkStopRB_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASWalkStopRB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkStopRB");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASWalkStopRB_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("AdvancedMonsterLocomotion")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkLoopAddPose")]
	public UAnimSequence ASWalkLoopAddPose
	{
		get
		{
			CheckDestroyed();
			if (!ASWalkLoopAddPose_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkLoopAddPose");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASWalkLoopAddPose_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASWalkLoopAddPose_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkLoopAddPose");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASWalkLoopAddPose_Offset), value);
			}
		}
	}

	[Category("AdvancedMonsterLocomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkLoopAdditiveList")]
	public TArrayReadWrite<UAnimSequence> ASWalkLoopAdditiveList
	{
		get
		{
			CheckDestroyed();
			if (!ASWalkLoopAdditiveList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASWalkLoopAdditiveList");
				return null;
			}
			if (ASWalkLoopAdditiveList_Marshaler == null)
			{
				ASWalkLoopAdditiveList_Marshaler = new TArrayReadWriteMarshaler<UAnimSequence>(1, ASWalkLoopAdditiveList_PropertyAddress, CachedMarshalingDelegates<UAnimSequence, UObjectMarshaler<UAnimSequence>>.FromNative, CachedMarshalingDelegates<UAnimSequence, UObjectMarshaler<UAnimSequence>>.ToNative);
			}
			return ASWalkLoopAdditiveList_Marshaler.FromNative(IntPtr.Add(base.Address, ASWalkLoopAdditiveList_Offset));
		}
	}

	[Category("AdvancedMonsterLocomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunStartFwd")]
	public UAnimSequence ASRunStartFwd
	{
		get
		{
			CheckDestroyed();
			if (!ASRunStartFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunStartFwd");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunStartFwd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunStartFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunStartFwd");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunStartFwd_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("AdvancedMonsterLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunStartBwd")]
	public UAnimSequence ASRunStartBwd
	{
		get
		{
			CheckDestroyed();
			if (!ASRunStartBwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunStartBwd");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunStartBwd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunStartBwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunStartBwd");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunStartBwd_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunStartLeftMin")]
	public UAnimSequence ASRunStartLeftMin
	{
		get
		{
			CheckDestroyed();
			if (!ASRunStartLeftMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunStartLeftMin");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunStartLeftMin_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunStartLeftMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunStartLeftMin");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunStartLeftMin_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunStartLeftMax")]
	public UAnimSequence ASRunStartLeftMax
	{
		get
		{
			CheckDestroyed();
			if (!ASRunStartLeftMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunStartLeftMax");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunStartLeftMax_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunStartLeftMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunStartLeftMax");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunStartLeftMax_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunStartRightMin")]
	public UAnimSequence ASRunStartRightMin
	{
		get
		{
			CheckDestroyed();
			if (!ASRunStartRightMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunStartRightMin");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunStartRightMin_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunStartRightMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunStartRightMin");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunStartRightMin_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunStartRightMax")]
	public UAnimSequence ASRunStartRightMax
	{
		get
		{
			CheckDestroyed();
			if (!ASRunStartRightMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunStartRightMax");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunStartRightMax_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunStartRightMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunStartRightMax");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunStartRightMax_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunStartLF")]
	public UAnimSequence ASRunStartLF
	{
		get
		{
			CheckDestroyed();
			if (!ASRunStartLF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunStartLF");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunStartLF_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunStartLF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunStartLF");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunStartLF_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunStartLB")]
	public UAnimSequence ASRunStartLB
	{
		get
		{
			CheckDestroyed();
			if (!ASRunStartLB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunStartLB");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunStartLB_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunStartLB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunStartLB");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunStartLB_Offset), value);
			}
		}
	}

	[Category("AdvancedMonsterLocomotion")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunStartRF")]
	public UAnimSequence ASRunStartRF
	{
		get
		{
			CheckDestroyed();
			if (!ASRunStartRF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunStartRF");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunStartRF_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunStartRF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunStartRF");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunStartRF_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("AdvancedMonsterLocomotion")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunStartRB")]
	public UAnimSequence ASRunStartRB
	{
		get
		{
			CheckDestroyed();
			if (!ASRunStartRB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunStartRB");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunStartRB_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunStartRB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunStartRB");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunStartRB_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunLoopFwd")]
	public UAnimSequence ASRunLoopFwd
	{
		get
		{
			CheckDestroyed();
			if (!ASRunLoopFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunLoopFwd");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunLoopFwd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunLoopFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunLoopFwd");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunLoopFwd_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunLoopBwd")]
	public UAnimSequence ASRunLoopBwd
	{
		get
		{
			CheckDestroyed();
			if (!ASRunLoopBwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunLoopBwd");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunLoopBwd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunLoopBwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunLoopBwd");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunLoopBwd_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunLoopLF")]
	public UAnimSequence ASRunLoopLF
	{
		get
		{
			CheckDestroyed();
			if (!ASRunLoopLF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunLoopLF");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunLoopLF_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunLoopLF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunLoopLF");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunLoopLF_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunLoopLB")]
	public UAnimSequence ASRunLoopLB
	{
		get
		{
			CheckDestroyed();
			if (!ASRunLoopLB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunLoopLB");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunLoopLB_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunLoopLB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunLoopLB");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunLoopLB_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunLoopRF")]
	public UAnimSequence ASRunLoopRF
	{
		get
		{
			CheckDestroyed();
			if (!ASRunLoopRF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunLoopRF");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunLoopRF_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunLoopRF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunLoopRF");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunLoopRF_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunLoopRB")]
	public UAnimSequence ASRunLoopRB
	{
		get
		{
			CheckDestroyed();
			if (!ASRunLoopRB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunLoopRB");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunLoopRB_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunLoopRB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunLoopRB");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunLoopRB_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunSharpturnLeftMin")]
	public UAnimSequence ASRunSharpturnLeftMin
	{
		get
		{
			CheckDestroyed();
			if (!ASRunSharpturnLeftMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunSharpturnLeftMin");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunSharpturnLeftMin_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunSharpturnLeftMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunSharpturnLeftMin");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunSharpturnLeftMin_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunSharpturnLeftMax")]
	public UAnimSequence ASRunSharpturnLeftMax
	{
		get
		{
			CheckDestroyed();
			if (!ASRunSharpturnLeftMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunSharpturnLeftMax");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunSharpturnLeftMax_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunSharpturnLeftMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunSharpturnLeftMax");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunSharpturnLeftMax_Offset), value);
			}
		}
	}

	[Category("AdvancedMonsterLocomotion")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunSharpturnRightMin")]
	public UAnimSequence ASRunSharpturnRightMin
	{
		get
		{
			CheckDestroyed();
			if (!ASRunSharpturnRightMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunSharpturnRightMin");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunSharpturnRightMin_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunSharpturnRightMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunSharpturnRightMin");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunSharpturnRightMin_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunSharpturnRightMax")]
	public UAnimSequence ASRunSharpturnRightMax
	{
		get
		{
			CheckDestroyed();
			if (!ASRunSharpturnRightMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunSharpturnRightMax");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunSharpturnRightMax_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunSharpturnRightMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunSharpturnRightMax");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunSharpturnRightMax_Offset), value);
			}
		}
	}

	[Category("AdvancedMonsterLocomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunPivotFwd")]
	public UAnimSequence ASRunPivotFwd
	{
		get
		{
			CheckDestroyed();
			if (!ASRunPivotFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunPivotFwd");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunPivotFwd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunPivotFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunPivotFwd");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunPivotFwd_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunPivotBwd")]
	public UAnimSequence ASRunPivotBwd
	{
		get
		{
			CheckDestroyed();
			if (!ASRunPivotBwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunPivotBwd");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunPivotBwd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunPivotBwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunPivotBwd");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunPivotBwd_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunPivotLF")]
	public UAnimSequence ASRunPivotLF
	{
		get
		{
			CheckDestroyed();
			if (!ASRunPivotLF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunPivotLF");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunPivotLF_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunPivotLF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunPivotLF");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunPivotLF_Offset), value);
			}
		}
	}

	[Category("AdvancedMonsterLocomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunPivotLB")]
	public UAnimSequence ASRunPivotLB
	{
		get
		{
			CheckDestroyed();
			if (!ASRunPivotLB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunPivotLB");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunPivotLB_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunPivotLB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunPivotLB");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunPivotLB_Offset), value);
			}
		}
	}

	[Category("AdvancedMonsterLocomotion")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunPivotRF")]
	public UAnimSequence ASRunPivotRF
	{
		get
		{
			CheckDestroyed();
			if (!ASRunPivotRF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunPivotRF");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunPivotRF_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunPivotRF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunPivotRF");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunPivotRF_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("AdvancedMonsterLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunPivotRB")]
	public UAnimSequence ASRunPivotRB
	{
		get
		{
			CheckDestroyed();
			if (!ASRunPivotRB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunPivotRB");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunPivotRB_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunPivotRB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunPivotRB");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunPivotRB_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunTransFRToBR")]
	public UAnimSequence ASRunTransFRToBR
	{
		get
		{
			CheckDestroyed();
			if (!ASRunTransFRToBR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunTransFRToBR");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunTransFRToBR_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunTransFRToBR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunTransFRToBR");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunTransFRToBR_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("AdvancedMonsterLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunTransBRToFR")]
	public UAnimSequence ASRunTransBRToFR
	{
		get
		{
			CheckDestroyed();
			if (!ASRunTransBRToFR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunTransBRToFR");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunTransBRToFR_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunTransBRToFR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunTransBRToFR");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunTransBRToFR_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunTransFLToBL")]
	public UAnimSequence ASRunTransFLToBL
	{
		get
		{
			CheckDestroyed();
			if (!ASRunTransFLToBL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunTransFLToBL");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunTransFLToBL_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunTransFLToBL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunTransFLToBL");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunTransFLToBL_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunTransBLToFL")]
	public UAnimSequence ASRunTransBLToFL
	{
		get
		{
			CheckDestroyed();
			if (!ASRunTransBLToFL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunTransBLToFL");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunTransBLToFL_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunTransBLToFL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunTransBLToFL");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunTransBLToFL_Offset), value);
			}
		}
	}

	[Category("AdvancedMonsterLocomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunStopFwd")]
	public UAnimSequence ASRunStopFwd
	{
		get
		{
			CheckDestroyed();
			if (!ASRunStopFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunStopFwd");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunStopFwd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunStopFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunStopFwd");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunStopFwd_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunStopBwd")]
	public UAnimSequence ASRunStopBwd
	{
		get
		{
			CheckDestroyed();
			if (!ASRunStopBwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunStopBwd");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunStopBwd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunStopBwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunStopBwd");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunStopBwd_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunStopLF")]
	public UAnimSequence ASRunStopLF
	{
		get
		{
			CheckDestroyed();
			if (!ASRunStopLF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunStopLF");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunStopLF_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunStopLF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunStopLF");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunStopLF_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunStopLB")]
	public UAnimSequence ASRunStopLB
	{
		get
		{
			CheckDestroyed();
			if (!ASRunStopLB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunStopLB");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunStopLB_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunStopLB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunStopLB");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunStopLB_Offset), value);
			}
		}
	}

	[Category("AdvancedMonsterLocomotion")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunStopRF")]
	public UAnimSequence ASRunStopRF
	{
		get
		{
			CheckDestroyed();
			if (!ASRunStopRF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunStopRF");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunStopRF_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunStopRF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunStopRF");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunStopRF_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunStopRB")]
	public UAnimSequence ASRunStopRB
	{
		get
		{
			CheckDestroyed();
			if (!ASRunStopRB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunStopRB");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunStopRB_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunStopRB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunStopRB");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunStopRB_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunLoopAddPose")]
	public UAnimSequence ASRunLoopAddPose
	{
		get
		{
			CheckDestroyed();
			if (!ASRunLoopAddPose_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunLoopAddPose");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRunLoopAddPose_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRunLoopAddPose_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunLoopAddPose");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRunLoopAddPose_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunLoopAdditiveList")]
	public TArrayReadWrite<UAnimSequence> ASRunLoopAdditiveList
	{
		get
		{
			CheckDestroyed();
			if (!ASRunLoopAdditiveList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRunLoopAdditiveList");
				return null;
			}
			if (ASRunLoopAdditiveList_Marshaler == null)
			{
				ASRunLoopAdditiveList_Marshaler = new TArrayReadWriteMarshaler<UAnimSequence>(1, ASRunLoopAdditiveList_PropertyAddress, CachedMarshalingDelegates<UAnimSequence, UObjectMarshaler<UAnimSequence>>.FromNative, CachedMarshalingDelegates<UAnimSequence, UObjectMarshaler<UAnimSequence>>.ToNative);
			}
			return ASRunLoopAdditiveList_Marshaler.FromNative(IntPtr.Add(base.Address, ASRunLoopAdditiveList_Offset));
		}
	}

	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRushStartFwd")]
	public UAnimSequence ASRushStartFwd
	{
		get
		{
			CheckDestroyed();
			if (!ASRushStartFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRushStartFwd");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRushStartFwd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRushStartFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRushStartFwd");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRushStartFwd_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRushStartLeftMin")]
	public UAnimSequence ASRushStartLeftMin
	{
		get
		{
			CheckDestroyed();
			if (!ASRushStartLeftMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRushStartLeftMin");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRushStartLeftMin_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRushStartLeftMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRushStartLeftMin");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRushStartLeftMin_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRushStartLeftMax")]
	public UAnimSequence ASRushStartLeftMax
	{
		get
		{
			CheckDestroyed();
			if (!ASRushStartLeftMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRushStartLeftMax");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRushStartLeftMax_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRushStartLeftMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRushStartLeftMax");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRushStartLeftMax_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRushStartRightMin")]
	public UAnimSequence ASRushStartRightMin
	{
		get
		{
			CheckDestroyed();
			if (!ASRushStartRightMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRushStartRightMin");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRushStartRightMin_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRushStartRightMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRushStartRightMin");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRushStartRightMin_Offset), value);
			}
		}
	}

	[Category("AdvancedMonsterLocomotion")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRushStartRightMax")]
	public UAnimSequence ASRushStartRightMax
	{
		get
		{
			CheckDestroyed();
			if (!ASRushStartRightMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRushStartRightMax");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRushStartRightMax_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRushStartRightMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRushStartRightMax");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRushStartRightMax_Offset), value);
			}
		}
	}

	[Category("AdvancedMonsterLocomotion")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRushLoopFwd")]
	public UAnimSequence ASRushLoopFwd
	{
		get
		{
			CheckDestroyed();
			if (!ASRushLoopFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRushLoopFwd");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRushLoopFwd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRushLoopFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRushLoopFwd");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRushLoopFwd_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRushSharpturnLeftMin")]
	public UAnimSequence ASRushSharpturnLeftMin
	{
		get
		{
			CheckDestroyed();
			if (!ASRushSharpturnLeftMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRushSharpturnLeftMin");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRushSharpturnLeftMin_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRushSharpturnLeftMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRushSharpturnLeftMin");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRushSharpturnLeftMin_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRushSharpturnLeftMax")]
	public UAnimSequence ASRushSharpturnLeftMax
	{
		get
		{
			CheckDestroyed();
			if (!ASRushSharpturnLeftMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRushSharpturnLeftMax");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRushSharpturnLeftMax_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRushSharpturnLeftMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRushSharpturnLeftMax");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRushSharpturnLeftMax_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRushSharpturnRightMin")]
	public UAnimSequence ASRushSharpturnRightMin
	{
		get
		{
			CheckDestroyed();
			if (!ASRushSharpturnRightMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRushSharpturnRightMin");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRushSharpturnRightMin_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRushSharpturnRightMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRushSharpturnRightMin");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRushSharpturnRightMin_Offset), value);
			}
		}
	}

	[Category("AdvancedMonsterLocomotion")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRushSharpturnRightMax")]
	public UAnimSequence ASRushSharpturnRightMax
	{
		get
		{
			CheckDestroyed();
			if (!ASRushSharpturnRightMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRushSharpturnRightMax");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRushSharpturnRightMax_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRushSharpturnRightMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRushSharpturnRightMax");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRushSharpturnRightMax_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRushStopFwd")]
	public UAnimSequence ASRushStopFwd
	{
		get
		{
			CheckDestroyed();
			if (!ASRushStopFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRushStopFwd");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRushStopFwd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRushStopFwd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRushStopFwd");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRushStopFwd_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("AdvancedMonsterLocomotion")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRushLoopAddPose")]
	public UAnimSequence ASRushLoopAddPose
	{
		get
		{
			CheckDestroyed();
			if (!ASRushLoopAddPose_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRushLoopAddPose");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASRushLoopAddPose_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRushLoopAddPose_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRushLoopAddPose");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASRushLoopAddPose_Offset), value);
			}
		}
	}

	[Category("AdvancedMonsterLocomotion")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRushLoopAdditiveList")]
	public TArrayReadWrite<UAnimSequence> ASRushLoopAdditiveList
	{
		get
		{
			CheckDestroyed();
			if (!ASRushLoopAdditiveList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ASRushLoopAdditiveList");
				return null;
			}
			if (ASRushLoopAdditiveList_Marshaler == null)
			{
				ASRushLoopAdditiveList_Marshaler = new TArrayReadWriteMarshaler<UAnimSequence>(1, ASRushLoopAdditiveList_PropertyAddress, CachedMarshalingDelegates<UAnimSequence, UObjectMarshaler<UAnimSequence>>.FromNative, CachedMarshalingDelegates<UAnimSequence, UObjectMarshaler<UAnimSequence>>.ToNative);
			}
			return ASRushLoopAdditiveList_Marshaler.FromNative(IntPtr.Add(base.Address, ASRushLoopAdditiveList_Offset));
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Common")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:AnimIdle")]
	public UAnimSequence AnimIdle
	{
		get
		{
			CheckDestroyed();
			if (!AnimIdle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:AnimIdle");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, AnimIdle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimIdle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:AnimIdle");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, AnimIdle_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Common")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:MappedSpeed")]
	public float MappedSpeed
	{
		get
		{
			CheckDestroyed();
			if (!MappedSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:MappedSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MappedSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MappedSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:MappedSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MappedSpeed_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("Common")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:GaitGroundedState")]
	public EGaitGroundedState GaitGroundedState
	{
		get
		{
			CheckDestroyed();
			if (!GaitGroundedState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:GaitGroundedState");
				return EGaitGroundedState.None;
			}
			return EnumMarshaler<EGaitGroundedState>.FromNative(IntPtr.Add(base.Address, GaitGroundedState_Offset), 0, GaitGroundedState_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!GaitGroundedState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:GaitGroundedState");
			}
			else
			{
				EnumMarshaler<EGaitGroundedState>.ToNative(IntPtr.Add(base.Address, GaitGroundedState_Offset), 0, GaitGroundedState_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Common")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:MoveGaitGroundedState")]
	public EGaitGroundedState MoveGaitGroundedState
	{
		get
		{
			CheckDestroyed();
			if (!MoveGaitGroundedState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:MoveGaitGroundedState");
				return EGaitGroundedState.None;
			}
			return EnumMarshaler<EGaitGroundedState>.FromNative(IntPtr.Add(base.Address, MoveGaitGroundedState_Offset), 0, MoveGaitGroundedState_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MoveGaitGroundedState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:MoveGaitGroundedState");
			}
			else
			{
				EnumMarshaler<EGaitGroundedState>.ToNative(IntPtr.Add(base.Address, MoveGaitGroundedState_Offset), 0, MoveGaitGroundedState_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Common")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:SwitchingLockStateAngle")]
	public float SwitchingLockStateAngle
	{
		get
		{
			CheckDestroyed();
			if (!SwitchingLockStateAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:SwitchingLockStateAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SwitchingLockStateAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SwitchingLockStateAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:SwitchingLockStateAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SwitchingLockStateAngle_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("Common")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ActorSpineNum")]
	public int ActorSpineNum
	{
		get
		{
			CheckDestroyed();
			if (!ActorSpineNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ActorSpineNum");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ActorSpineNum_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ActorSpineNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ActorSpineNum");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ActorSpineNum_Offset), value);
			}
		}
	}

	[Category("Common")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:VelocityDeltaAngle")]
	public float VelocityDeltaAngle
	{
		get
		{
			CheckDestroyed();
			if (!VelocityDeltaAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:VelocityDeltaAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, VelocityDeltaAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VelocityDeltaAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:VelocityDeltaAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, VelocityDeltaAngle_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Common")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:StopVelocityDeltaAngle")]
	public float StopVelocityDeltaAngle
	{
		get
		{
			CheckDestroyed();
			if (!StopVelocityDeltaAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:StopVelocityDeltaAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, StopVelocityDeltaAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StopVelocityDeltaAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:StopVelocityDeltaAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, StopVelocityDeltaAngle_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Common")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:InputDeltaAngle")]
	public float InputDeltaAngle
	{
		get
		{
			CheckDestroyed();
			if (!InputDeltaAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:InputDeltaAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, InputDeltaAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InputDeltaAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:InputDeltaAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, InputDeltaAngle_Offset), value);
			}
		}
	}

	[Category("Common")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:InputVelocityAngle")]
	public float InputVelocityAngle
	{
		get
		{
			CheckDestroyed();
			if (!InputVelocityAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:InputVelocityAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, InputVelocityAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InputVelocityAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:InputVelocityAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, InputVelocityAngle_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Common")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:MoveSpeedLastUpdate")]
	public float MoveSpeedLastUpdate
	{
		get
		{
			CheckDestroyed();
			if (!MoveSpeedLastUpdate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:MoveSpeedLastUpdate");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MoveSpeedLastUpdate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MoveSpeedLastUpdate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:MoveSpeedLastUpdate");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MoveSpeedLastUpdate_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("Common")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:bPivotUseOrientationWarping")]
	public bool bPivotUseOrientationWarping
	{
		get
		{
			CheckDestroyed();
			if (!bPivotUseOrientationWarping_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:bPivotUseOrientationWarping");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bPivotUseOrientationWarping_Offset), 0, bPivotUseOrientationWarping_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bPivotUseOrientationWarping_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:bPivotUseOrientationWarping");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bPivotUseOrientationWarping_Offset), 0, bPivotUseOrientationWarping_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:bUpdateAnimIdle")]
	public bool bUpdateAnimIdle
	{
		get
		{
			CheckDestroyed();
			if (!bUpdateAnimIdle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:bUpdateAnimIdle");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bUpdateAnimIdle_Offset), 0, bUpdateAnimIdle_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bUpdateAnimIdle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:bUpdateAnimIdle");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bUpdateAnimIdle_Offset), 0, bUpdateAnimIdle_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("Trans")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:bSwitchToLock")]
	public bool bSwitchToLock
	{
		get
		{
			CheckDestroyed();
			if (!bSwitchToLock_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:bSwitchToLock");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bSwitchToLock_Offset), 0, bSwitchToLock_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bSwitchToLock_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:bSwitchToLock");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bSwitchToLock_Offset), 0, bSwitchToLock_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("Trans")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:bSwitchingLockState")]
	public bool bSwitchingLockState
	{
		get
		{
			CheckDestroyed();
			if (!bSwitchingLockState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:bSwitchingLockState");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bSwitchingLockState_Offset), 0, bSwitchingLockState_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bSwitchingLockState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:bSwitchingLockState");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bSwitchingLockState_Offset), 0, bSwitchingLockState_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:bFreeStop")]
	public bool bFreeStop
	{
		get
		{
			CheckDestroyed();
			if (!bFreeStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:bFreeStop");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bFreeStop_Offset), 0, bFreeStop_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bFreeStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:bFreeStop");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bFreeStop_Offset), 0, bFreeStop_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:bLockStop")]
	public bool bLockStop
	{
		get
		{
			CheckDestroyed();
			if (!bLockStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:bLockStop");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockStop_Offset), 0, bLockStop_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:bLockStop");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockStop_Offset), 0, bLockStop_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("Trans")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:bSwitchingLockStateStop")]
	public bool bSwitchingLockStateStop
	{
		get
		{
			CheckDestroyed();
			if (!bSwitchingLockStateStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:bSwitchingLockStateStop");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bSwitchingLockStateStop_Offset), 0, bSwitchingLockStateStop_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bSwitchingLockStateStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:bSwitchingLockStateStop");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bSwitchingLockStateStop_Offset), 0, bSwitchingLockStateStop_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:bMoveToIdle")]
	public bool bMoveToIdle
	{
		get
		{
			CheckDestroyed();
			if (!bMoveToIdle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:bMoveToIdle");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bMoveToIdle_Offset), 0, bMoveToIdle_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bMoveToIdle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:bMoveToIdle");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bMoveToIdle_Offset), 0, bMoveToIdle_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:bStartToTrans")]
	public bool bStartToTrans
	{
		get
		{
			CheckDestroyed();
			if (!bStartToTrans_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:bStartToTrans");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bStartToTrans_Offset), 0, bStartToTrans_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bStartToTrans_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:bStartToTrans");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bStartToTrans_Offset), 0, bStartToTrans_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trans")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:bFreeStartToTurn")]
	public bool bFreeStartToTurn
	{
		get
		{
			CheckDestroyed();
			if (!bFreeStartToTurn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:bFreeStartToTurn");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bFreeStartToTurn_Offset), 0, bFreeStartToTurn_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bFreeStartToTurn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:bFreeStartToTurn");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bFreeStartToTurn_Offset), 0, bFreeStartToTurn_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:bLockStartToTurn")]
	public bool bLockStartToTurn
	{
		get
		{
			CheckDestroyed();
			if (!bLockStartToTurn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:bLockStartToTurn");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockStartToTurn_Offset), 0, bLockStartToTurn_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockStartToTurn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:bLockStartToTurn");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockStartToTurn_Offset), 0, bLockStartToTurn_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:bSwitchingFreeToTurn")]
	public bool bSwitchingFreeToTurn
	{
		get
		{
			CheckDestroyed();
			if (!bSwitchingFreeToTurn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:bSwitchingFreeToTurn");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bSwitchingFreeToTurn_Offset), 0, bSwitchingFreeToTurn_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bSwitchingFreeToTurn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:bSwitchingFreeToTurn");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bSwitchingFreeToTurn_Offset), 0, bSwitchingFreeToTurn_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:bLockLoopToTurn")]
	public bool bLockLoopToTurn
	{
		get
		{
			CheckDestroyed();
			if (!bLockLoopToTurn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:bLockLoopToTurn");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockLoopToTurn_Offset), 0, bLockLoopToTurn_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockLoopToTurn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:bLockLoopToTurn");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockLoopToTurn_Offset), 0, bLockLoopToTurn_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:bLockTurnToLoop")]
	public bool bLockTurnToLoop
	{
		get
		{
			CheckDestroyed();
			if (!bLockTurnToLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:bLockTurnToLoop");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockTurnToLoop_Offset), 0, bLockTurnToLoop_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockTurnToLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:bLockTurnToLoop");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockTurnToLoop_Offset), 0, bLockTurnToLoop_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trans")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:bFreeLoopToTurn")]
	public bool bFreeLoopToTurn
	{
		get
		{
			CheckDestroyed();
			if (!bFreeLoopToTurn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:bFreeLoopToTurn");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bFreeLoopToTurn_Offset), 0, bFreeLoopToTurn_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bFreeLoopToTurn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:bFreeLoopToTurn");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bFreeLoopToTurn_Offset), 0, bFreeLoopToTurn_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("Trans")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:bFreeMoveToTurn")]
	public bool bFreeMoveToTurn
	{
		get
		{
			CheckDestroyed();
			if (!bFreeMoveToTurn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:bFreeMoveToTurn");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bFreeMoveToTurn_Offset), 0, bFreeMoveToTurn_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bFreeMoveToTurn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:bFreeMoveToTurn");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bFreeMoveToTurn_Offset), 0, bFreeMoveToTurn_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:bLockMoveToTurn")]
	public bool bLockMoveToTurn
	{
		get
		{
			CheckDestroyed();
			if (!bLockMoveToTurn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:bLockMoveToTurn");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLockMoveToTurn_Offset), 0, bLockMoveToTurn_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLockMoveToTurn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:bLockMoveToTurn");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLockMoveToTurn_Offset), 0, bLockMoveToTurn_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:bMoveStartSwitch")]
	public bool bMoveStartSwitch
	{
		get
		{
			CheckDestroyed();
			if (!bMoveStartSwitch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:bMoveStartSwitch");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bMoveStartSwitch_Offset), 0, bMoveStartSwitch_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bMoveStartSwitch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:bMoveStartSwitch");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bMoveStartSwitch_Offset), 0, bMoveStartSwitch_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trans")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:bMoveTurnSwitch")]
	public bool bMoveTurnSwitch
	{
		get
		{
			CheckDestroyed();
			if (!bMoveTurnSwitch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:bMoveTurnSwitch");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bMoveTurnSwitch_Offset), 0, bMoveTurnSwitch_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bMoveTurnSwitch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:bMoveTurnSwitch");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bMoveTurnSwitch_Offset), 0, bMoveTurnSwitch_PropertyAddress.Address, value);
			}
		}
	}

	protected override void OnInitABPSetting()
	{
		if (!this.IsNullOrDestroyed())
		{
			BUABPSettingData aBPSettingData = TopAnimInst.ABPSettingData;
			if (aBPSettingData != null && b1.BGU.BUAnim.AbpHelperUtil.ShouldInitABPMoveModeData(Owner, EABPMoveMode.AdvancedMonsterLocomotion, aBPSettingData))
			{
				InitSetting(aBPSettingData.AdvancedMonsterLocomotionSetting);
				InitData();
			}
		}
	}

	private void InitSetting(BUABPAdvancedMonsterLocomotionSettingData Setting)
	{
		ASIdleList = Setting.ASIdleList;
		ASWalkStartFwd = Setting.ASWalkStartFwd;
		ASWalkStartBwd = Setting.ASWalkStartBwd;
		ASWalkStartLeftMin = Setting.ASWalkStartLeftMin;
		ASWalkStartLeftMax = Setting.ASWalkStartLeftMax;
		ASWalkStartRightMin = Setting.ASWalkStartRightMin;
		ASWalkStartRightMax = Setting.ASWalkStartRightMax;
		ASWalkStartLF = Setting.ASWalkStartLF;
		ASWalkStartLB = Setting.ASWalkStartLB;
		ASWalkStartRF = Setting.ASWalkStartRF;
		ASWalkStartRB = Setting.ASWalkStartRB;
		ASWalkLoopFwd = Setting.ASWalkLoopFwd;
		ASWalkLoopBwd = Setting.ASWalkLoopBwd;
		ASWalkLoopLF = Setting.ASWalkLoopLF;
		ASWalkLoopLB = Setting.ASWalkLoopLB;
		ASWalkLoopRF = Setting.ASWalkLoopRF;
		ASWalkLoopRB = Setting.ASWalkLoopRB;
		ASWalkSharpturnLeftMin = Setting.ASWalkSharpturnLeftMin;
		ASWalkSharpturnLeftMax = Setting.ASWalkSharpturnLeftMax;
		ASWalkSharpturnRightMin = Setting.ASWalkSharpturnRightMin;
		ASWalkSharpturnRightMax = Setting.ASWalkSharpturnRightMax;
		ASWalkPivotFwd = Setting.ASWalkPivotFwd;
		ASWalkPivotBwd = Setting.ASWalkPivotBwd;
		ASWalkPivotLF = Setting.ASWalkPivotLF;
		ASWalkPivotLB = Setting.ASWalkPivotLB;
		ASWalkPivotRF = Setting.ASWalkPivotRF;
		ASWalkPivotRB = Setting.ASWalkPivotRB;
		ASWalkTransFRToBR = Setting.ASWalkTransFRToBR;
		ASWalkTransBRToFR = Setting.ASWalkTransBRToFR;
		ASWalkTransFLToBL = Setting.ASWalkTransFLToBL;
		ASWalkTransBLToFL = Setting.ASWalkTransBLToFL;
		ASWalkStopFwd = Setting.ASWalkStopFwd;
		ASWalkStopBwd = Setting.ASWalkStopBwd;
		ASWalkStopLF = Setting.ASWalkStopLF;
		ASWalkStopLB = Setting.ASWalkStopLB;
		ASWalkStopRF = Setting.ASWalkStopRF;
		ASWalkStopRB = Setting.ASWalkStopRB;
		ASWalkLoopAddPose = Setting.ASWalkLoopAddPose;
		ASWalkLoopAdditiveList.SetValues(Setting.ASWalkLoopAdditiveList);
		bHasWalkAnim = ASWalkLoopFwd != null;
		bHasWalkPivotAnim = bHasWalkAnim && ASWalkPivotFwd != null && ASWalkPivotBwd != null && ASWalkPivotLF != null && ASWalkPivotRF != null && ASWalkPivotLB != null && ASWalkPivotRB != null;
		bHasWalkTransAnim = bHasWalkAnim && ASWalkTransBLToFL != null && ASWalkTransBRToFR != null && ASWalkTransFLToBL != null && ASWalkTransFRToBR != null;
		bHasWalkSharpturnAnim = bHasWalkAnim && ASWalkSharpturnLeftMax != null && ASWalkSharpturnLeftMin != null && ASWalkSharpturnRightMax != null && ASWalkSharpturnRightMin != null;
		ASRunStartFwd = Setting.ASRunStartFwd;
		ASRunStartBwd = Setting.ASRunStartBwd;
		ASRunStartLeftMin = Setting.ASRunStartLeftMin;
		ASRunStartLeftMax = Setting.ASRunStartLeftMax;
		ASRunStartRightMin = Setting.ASRunStartRightMin;
		ASRunStartRightMax = Setting.ASRunStartRightMax;
		ASRunStartLF = Setting.ASRunStartLF;
		ASRunStartLB = Setting.ASRunStartLB;
		ASRunStartRF = Setting.ASRunStartRF;
		ASRunStartRB = Setting.ASRunStartRB;
		ASRunLoopFwd = Setting.ASRunLoopFwd;
		ASRunLoopBwd = Setting.ASRunLoopBwd;
		ASRunLoopLF = Setting.ASRunLoopLF;
		ASRunLoopLB = Setting.ASRunLoopLB;
		ASRunLoopRF = Setting.ASRunLoopRF;
		ASRunLoopRB = Setting.ASRunLoopRB;
		ASRunSharpturnLeftMin = Setting.ASRunSharpturnLeftMin;
		ASRunSharpturnLeftMax = Setting.ASRunSharpturnLeftMax;
		ASRunSharpturnRightMin = Setting.ASRunSharpturnRightMin;
		ASRunSharpturnRightMax = Setting.ASRunSharpturnRightMax;
		ASRunPivotFwd = Setting.ASRunPivotFwd;
		ASRunPivotBwd = Setting.ASRunPivotBwd;
		ASRunPivotLF = Setting.ASRunPivotLF;
		ASRunPivotLB = Setting.ASRunPivotLB;
		ASRunPivotRF = Setting.ASRunPivotRF;
		ASRunPivotRB = Setting.ASRunPivotRB;
		ASRunTransFRToBR = Setting.ASRunTransFRToBR;
		ASRunTransBRToFR = Setting.ASRunTransBRToFR;
		ASRunTransFLToBL = Setting.ASRunTransFLToBL;
		ASRunTransBLToFL = Setting.ASRunTransBLToFL;
		ASRunStopFwd = Setting.ASRunStopFwd;
		ASRunStopBwd = Setting.ASRunStopBwd;
		ASRunStopLF = Setting.ASRunStopLF;
		ASRunStopLB = Setting.ASRunStopLB;
		ASRunStopRF = Setting.ASRunStopRF;
		ASRunStopRB = Setting.ASRunStopRB;
		ASRunLoopAddPose = Setting.ASRunLoopAddPose;
		ASRunLoopAdditiveList.SetValues(Setting.ASRunLoopAdditiveList);
		bHasRunAnim = ASRunLoopFwd != null;
		bHasRunPivotAnim = bHasRunAnim && ASRunPivotFwd != null && ASRunPivotBwd != null && ASRunPivotLF != null && ASRunPivotRF != null && ASRunPivotLB != null && ASRunPivotRB != null;
		bHasRunTransAnim = bHasRunAnim && ASRunTransBLToFL != null && ASRunTransBRToFR != null && ASRunTransFLToBL != null && ASRunTransFRToBR != null;
		bHasRunSharpturnAnim = bHasRunAnim && ASRunSharpturnLeftMax != null && ASRunSharpturnLeftMin != null && ASRunSharpturnRightMax != null && ASRunSharpturnRightMin != null;
		ASRushStartFwd = Setting.ASRushStartFwd;
		ASRushStartLeftMin = Setting.ASRushStartLeftMin;
		ASRushStartLeftMax = Setting.ASRushStartLeftMax;
		ASRushStartRightMin = Setting.ASRushStartRightMin;
		ASRushStartRightMax = Setting.ASRushStartRightMax;
		ASRushLoopFwd = Setting.ASRushLoopFwd;
		ASRushSharpturnLeftMin = Setting.ASRushSharpturnLeftMin;
		ASRushSharpturnLeftMax = Setting.ASRushSharpturnLeftMax;
		ASRushSharpturnRightMin = Setting.ASRushSharpturnRightMin;
		ASRushSharpturnRightMax = Setting.ASRushSharpturnRightMax;
		ASRushStopFwd = Setting.ASRushStopFwd;
		ASRushLoopAddPose = Setting.ASRushLoopAddPose;
		ASRushLoopAdditiveList.SetValues(Setting.ASRushLoopAdditiveList);
		PlayRateClampStartAndTurn = Setting.StartAndTurnAnimPlayRateClamped;
		PlayRateClampLoop = Setting.LoopAnimPlayRateClamped;
		bHasRushAnim = ASRushLoopFwd != null;
		bHasRushSharpturnAnim = bHasRushAnim && ASRushSharpturnLeftMax != null && ASRushSharpturnLeftMin != null && ASRushSharpturnRightMax != null && ASRushSharpturnRightMin != null;
	}

	protected override void LinkedGraphInitializeAnimation()
	{
		ACharacter aCharacter = Owner as ACharacter;
		if (!(aCharacter != null))
		{
			return;
		}
		if (TopAnimInst != null && TopAnimInst.ABPSettingData != null)
		{
			AnimIdle = TopAnimInst.ABPSettingData.CommonSetting.AnimSeqIdle;
		}
		if (aCharacter.Mesh != null)
		{
			if (aCharacter.Mesh.DoesSocketExist(B1GlobalFNames.spine_03))
			{
				ActorSpineNum = 3;
			}
			else if (aCharacter.Mesh.DoesSocketExist(B1GlobalFNames.spine_02))
			{
				ActorSpineNum = 2;
			}
			else if (aCharacter.Mesh.DoesSocketExist(B1GlobalFNames.spine_01))
			{
				ActorSpineNum = 1;
			}
		}
		CommonData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_ABPCommonSettingData, BUC_ABPCommonSettingData>(aCharacter);
		if (CommonData != null)
		{
			AnimIdle = CommonData.AnimIdle;
			ASIdleList = CommonData.ExtendAnimIdleList;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(aCharacter);
		if (bUS_GSEventCollection != null)
		{
			bUS_GSEventCollection.Evt_CacheAdvancedMonsterLocomotionAnimInst.Invoke(this);
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
			AdvancedMonsterLocomotionData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPAdvancedMonsterLocomotionData, BUC_ABPAdvancedMonsterLocomotionData>(Owner);
			CommonData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPCommonSettingData, BUC_ABPCommonSettingData>(Owner);
		}
	}

	private void InitData()
	{
		InitBUCData();
		LastActorLocation = BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner);
		if (CommonData != null)
		{
			AnimIdle = CommonData.AnimIdle;
			ASIdleList = CommonData.ExtendAnimIdleList;
		}
		if (AdvancedMonsterLocomotionData != null)
		{
			FreeMode = AdvancedMonsterLocomotionData.FreeMode;
			LockMode = AdvancedMonsterLocomotionData.LockMode;
		}
	}

	private void UpdateData(float DeltaTime)
	{
		bUpdateAnimIdle = false;
		float num = 0f;
		float num2 = 1f;
		float num3 = 0f;
		if (CommonData != null)
		{
			AnimIdle = CommonData.AnimIdle;
			if (ASIdleList != CommonData.ExtendAnimIdleList)
			{
				ASIdleList = CommonData.ExtendAnimIdleList;
				bUpdateAnimIdle = true;
			}
		}
		if (BasicData != null)
		{
			MappedSpeed = BasicData.GetMappedSpeed();
			num3 = BasicData.Speed;
		}
		if (ChrData != null)
		{
			num2 = ChrData.ActorScale3D.X;
			PivotOrientationWarpingMinVelocity = ChrData.MaxSpeed / 4f;
		}
		if (AdvancedMonsterLocomotionData != null)
		{
			bSwitchToLock = AdvancedMonsterLocomotionData.bSwitchToLock;
			bSwitchingLockState = AdvancedMonsterLocomotionData.bSwitchingLockState;
			SwitchingLockStateAngle = AdvancedMonsterLocomotionData.SwitchingLockStateAngle;
			StartAngle = AdvancedMonsterLocomotionData.StartAngle;
			GaitGroundedState = AdvancedMonsterLocomotionData.GaitGroundedState;
			MoveGaitGroundedState = AdvancedMonsterLocomotionData.MoveGaitGroundedState;
			VelocityDeltaAngle = AdvancedMonsterLocomotionData.VelocityDeltaAngle;
			InputDeltaAngle = AdvancedMonsterLocomotionData.InputDeltaAngle;
			InputVelocityAngle = AdvancedMonsterLocomotionData.InputVelocityAngle;
			num = FMath.Abs(InputVelocityAngle);
			MoveLoopPelvisLocalOffset = FMath.FInterpTo(MoveLoopPelvisLocalOffset, AdvancedMonsterLocomotionData.MoveLoopPelvisLocationOffset, DeltaTime, 6f);
			MoveLoopPelvisAngleOffset = FMath.FInterpTo(MoveLoopPelvisAngleOffset, AdvancedMonsterLocomotionData.MoveLoopPelvisAngleOffset, DeltaTime, 6f);
		}
		float num4 = FMath.Abs(MathLib.NormalizedDeltaRotator(new FRotator(0.0, MoveStartInputDeltaAngle, 0.0), new FRotator(0.0, InputDeltaAngle, 0.0)).Yaw);
		float num5 = FMath.Abs(MathLib.NormalizedDeltaRotator(new FRotator(0.0, StopVelocityDeltaAngle, 0.0), new FRotator(0.0, InputDeltaAngle, 0.0)).Yaw);
		bMoveToIdle = (GaitGroundedState == EGaitGroundedState.Idle || GaitGroundedState == EGaitGroundedState.None) && bSwitchToLock && MappedSpeed < 0.2f;
		bFreeStop = GaitGroundedState == EGaitGroundedState.Idle && !bSwitchToLock;
		bLockStop = GaitGroundedState == EGaitGroundedState.Idle && bSwitchToLock;
		bSwitchingLockStateStop = GaitGroundedState == EGaitGroundedState.Idle && bSwitchingLockState;
		bFreeMoveToTurn = !bSwitchToLock && !bSwitchingLockState && FreeMode == ELMFreeMode.Normal && bMoveToTurn;
		bLockMoveToTurn = bSwitchToLock && !bSwitchingLockState && LockMode == ELMLockMode.Normal && bMoveToTurn && num5 > 90f && HasPivotAnim(MoveGaitGroundedState);
		bFreeStartToTurn = !bSwitchToLock && FreeMode == ELMFreeMode.Normal && bChangeMoveSpeedInStartOrTurn;
		bool flag = num > 135f && num4 > 90f;
		bLockStartToTurn = bSwitchToLock && LockMode == ELMLockMode.Normal && (flag || bChangeMoveSpeedInStartOrTurn);
		bSwitchingFreeToTurn = bSwitchingLockState && !bSwitchToLock && FreeMode == ELMFreeMode.Normal && FMath.Abs(InputDeltaAngle) > 60f;
		bLockLoopToTurn = bSwitchToLock && num > 135f && LockMode == ELMLockMode.Normal && HasPivotAnim(MoveGaitGroundedState);
		bFreeLoopToTurn = !bSwitchToLock && num > 60f && FreeMode != ELMFreeMode.Normal;
		bPivotUseOrientationWarping = bSwitchToLock && num3 >= PivotOrientationWarpingMinVelocity;
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner);
		MoveDistanceSinceLastUpdate = (fVector - LastActorLocation).Size2D() / num2;
		MoveSpeedLastUpdate = MoveDistanceSinceLastUpdate / DeltaTime;
		LastActorLocation = fVector;
	}

	private bool HasPivotAnim(EGaitGroundedState GaitGroundedState)
	{
		return GaitGroundedState switch
		{
			EGaitGroundedState.Walk => bHasWalkPivotAnim, 
			EGaitGroundedState.Run => bHasRunPivotAnim, 
			_ => false, 
		};
	}

	private bool HasTransAnim(EGaitGroundedState GaitGroundedState)
	{
		return GaitGroundedState switch
		{
			EGaitGroundedState.Walk => bHasWalkTransAnim, 
			EGaitGroundedState.Run => bHasRunTransAnim, 
			_ => false, 
		};
	}

	private bool ShouldPivotTransDirection(ELockMoveDirectionSix LockInputDirection)
	{
		switch (CurrentLockTurnDir)
		{
		case ELockMoveDirectionSix.F:
		case ELockMoveDirectionSix.B:
			if (LockInputDirection != ELockMoveDirectionSix.F && LockInputDirection != ELockMoveDirectionSix.B)
			{
				return true;
			}
			break;
		case ELockMoveDirectionSix.FL:
		case ELockMoveDirectionSix.BR:
			if (LockInputDirection != ELockMoveDirectionSix.FL && LockInputDirection != ELockMoveDirectionSix.BR)
			{
				return true;
			}
			break;
		case ELockMoveDirectionSix.FR:
		case ELockMoveDirectionSix.BL:
			if (LockInputDirection != ELockMoveDirectionSix.FR && LockInputDirection != ELockMoveDirectionSix.BL)
			{
				return true;
			}
			break;
		}
		return false;
	}

	private UAnimSequence SelectWalkAnim(EAdvancedMonsterLocomotionMoveState MoveState)
	{
		if (!bHasWalkAnim)
		{
			return null;
		}
		bool flag = false;
		EMoveDirectionFive eMoveDirectionFive = EMoveDirectionFive.None;
		ELockMoveDirectionSix eLockMoveDirectionSix = ELockMoveDirectionSix.None;
		if (AdvancedMonsterLocomotionData != null)
		{
			flag = AdvancedMonsterLocomotionData.bSwitchToLock;
			eMoveDirectionFive = AdvancedMonsterLocomotionData.FreeInputDirection;
			eLockMoveDirectionSix = AdvancedMonsterLocomotionData.InputDirection;
		}
		switch (MoveState)
		{
		case EAdvancedMonsterLocomotionMoveState.Start:
			if (flag)
			{
				switch (eLockMoveDirectionSix)
				{
				case ELockMoveDirectionSix.None:
				case ELockMoveDirectionSix.F:
					return ASWalkStartFwd;
				case ELockMoveDirectionSix.FL:
					return ASWalkStartLF;
				case ELockMoveDirectionSix.FR:
					return ASWalkStartRF;
				case ELockMoveDirectionSix.BL:
					return ASWalkStartLB;
				case ELockMoveDirectionSix.BR:
					return ASWalkStartRB;
				case ELockMoveDirectionSix.B:
					return ASWalkStartBwd;
				}
			}
			else
			{
				switch (eMoveDirectionFive)
				{
				case EMoveDirectionFive.None:
				case EMoveDirectionFive.F:
					return ASWalkStartFwd;
				case EMoveDirectionFive.R:
					return ASWalkStartRightMin;
				case EMoveDirectionFive.BR:
					return ASWalkStartRightMax;
				case EMoveDirectionFive.BL:
					return ASWalkStartLeftMax;
				case EMoveDirectionFive.L:
					return ASWalkStartLeftMin;
				}
			}
			break;
		case EAdvancedMonsterLocomotionMoveState.Turn:
			if (flag)
			{
				switch (SelectLockMoveTurnDir())
				{
				case ELockMoveDirectionSix.None:
				case ELockMoveDirectionSix.F:
					return ASWalkPivotFwd;
				case ELockMoveDirectionSix.FL:
					return ASWalkPivotLF;
				case ELockMoveDirectionSix.FR:
					return ASWalkPivotRF;
				case ELockMoveDirectionSix.BL:
					return ASWalkPivotLB;
				case ELockMoveDirectionSix.BR:
					return ASWalkPivotRB;
				case ELockMoveDirectionSix.B:
					return ASWalkPivotBwd;
				}
			}
			else
			{
				switch (eMoveDirectionFive)
				{
				case EMoveDirectionFive.None:
				case EMoveDirectionFive.F:
					return ASWalkStartFwd;
				case EMoveDirectionFive.R:
					return ASWalkSharpturnRightMin;
				case EMoveDirectionFive.BR:
					return ASWalkSharpturnRightMax;
				case EMoveDirectionFive.BL:
					return ASWalkSharpturnLeftMax;
				case EMoveDirectionFive.L:
					return ASWalkSharpturnLeftMin;
				}
			}
			break;
		case EAdvancedMonsterLocomotionMoveState.Stop:
			if (bMoveLoopTransNotFinish)
			{
				switch (CurrentMoveLoopDir)
				{
				case EAdvancedMonsterLocomotionLoopDir.LFtoLB:
					return ASWalkStopLF;
				case EAdvancedMonsterLocomotionLoopDir.LBtoLF:
					return ASWalkStopLB;
				case EAdvancedMonsterLocomotionLoopDir.RFtoRB:
					return ASWalkStopRF;
				case EAdvancedMonsterLocomotionLoopDir.RBtoRF:
					return ASWalkStopRB;
				}
			}
			switch (StopDirection)
			{
			case ELockMoveDirectionSix.None:
			case ELockMoveDirectionSix.F:
				return ASWalkStopFwd;
			case ELockMoveDirectionSix.FL:
				return ASWalkStopLF;
			case ELockMoveDirectionSix.FR:
				return ASWalkStopRF;
			case ELockMoveDirectionSix.BL:
				return ASWalkStopLB;
			case ELockMoveDirectionSix.BR:
				return ASWalkStopRB;
			case ELockMoveDirectionSix.B:
				return ASWalkStopBwd;
			}
			break;
		}
		return null;
	}

	private UAnimSequence SelectRunAnim(EAdvancedMonsterLocomotionMoveState MoveState)
	{
		if (!bHasRunAnim)
		{
			return null;
		}
		bool flag = false;
		EMoveDirectionFive eMoveDirectionFive = EMoveDirectionFive.None;
		ELockMoveDirectionSix eLockMoveDirectionSix = ELockMoveDirectionSix.None;
		if (AdvancedMonsterLocomotionData != null)
		{
			flag = AdvancedMonsterLocomotionData.bSwitchToLock;
			eMoveDirectionFive = AdvancedMonsterLocomotionData.FreeInputDirection;
			eLockMoveDirectionSix = AdvancedMonsterLocomotionData.InputDirection;
		}
		switch (MoveState)
		{
		case EAdvancedMonsterLocomotionMoveState.Start:
			if (flag)
			{
				switch (eLockMoveDirectionSix)
				{
				case ELockMoveDirectionSix.None:
				case ELockMoveDirectionSix.F:
					return ASRunStartFwd;
				case ELockMoveDirectionSix.FL:
					if (LockMode != ELMLockMode.Normal && LockMode != ELMLockMode.SimpleLeft)
					{
						return ASRunStartLB;
					}
					return ASRunStartLF;
				case ELockMoveDirectionSix.FR:
					if (LockMode != ELMLockMode.Normal && LockMode != ELMLockMode.SimpleRight)
					{
						return ASRunStartRB;
					}
					return ASRunStartRF;
				case ELockMoveDirectionSix.BL:
					if (LockMode != ELMLockMode.Normal && LockMode != ELMLockMode.SimpleRight)
					{
						return ASRunStartLF;
					}
					return ASRunStartLB;
				case ELockMoveDirectionSix.BR:
					if (LockMode != ELMLockMode.Normal && LockMode != ELMLockMode.SimpleLeft)
					{
						return ASRunStartRF;
					}
					return ASRunStartRB;
				case ELockMoveDirectionSix.B:
					return ASRunStartBwd;
				}
			}
			else
			{
				if (FreeMode == ELMFreeMode.Simple)
				{
					return ASRunStartFwd;
				}
				switch (eMoveDirectionFive)
				{
				case EMoveDirectionFive.None:
				case EMoveDirectionFive.F:
					return ASRunStartFwd;
				case EMoveDirectionFive.R:
					return ASRunStartRightMin;
				case EMoveDirectionFive.BR:
					return ASRunStartRightMax;
				case EMoveDirectionFive.BL:
					return ASRunStartLeftMax;
				case EMoveDirectionFive.L:
					return ASRunStartLeftMin;
				}
			}
			break;
		case EAdvancedMonsterLocomotionMoveState.Turn:
			if (flag)
			{
				switch (SelectLockMoveTurnDir())
				{
				case ELockMoveDirectionSix.None:
				case ELockMoveDirectionSix.F:
					return ASRunPivotFwd;
				case ELockMoveDirectionSix.FL:
					return ASRunPivotLF;
				case ELockMoveDirectionSix.FR:
					return ASRunPivotRF;
				case ELockMoveDirectionSix.BL:
					return ASRunPivotLB;
				case ELockMoveDirectionSix.BR:
					return ASRunPivotRB;
				case ELockMoveDirectionSix.B:
					return ASRunPivotBwd;
				}
			}
			else
			{
				switch (eMoveDirectionFive)
				{
				case EMoveDirectionFive.None:
				case EMoveDirectionFive.F:
					return ASRunStartFwd;
				case EMoveDirectionFive.R:
					return ASRunSharpturnRightMin;
				case EMoveDirectionFive.BR:
					return ASRunSharpturnRightMax;
				case EMoveDirectionFive.BL:
					return ASRunSharpturnLeftMax;
				case EMoveDirectionFive.L:
					return ASRunSharpturnLeftMin;
				}
			}
			break;
		case EAdvancedMonsterLocomotionMoveState.Stop:
			if (flag)
			{
				if (bMoveLoopTransNotFinish)
				{
					switch (CurrentMoveLoopDir)
					{
					case EAdvancedMonsterLocomotionLoopDir.LFtoLB:
						if (LockMode != ELMLockMode.Normal && LockMode != ELMLockMode.SimpleLeft)
						{
							return ASRunStopLB;
						}
						return ASRunStopLF;
					case EAdvancedMonsterLocomotionLoopDir.LBtoLF:
						if (LockMode != ELMLockMode.Normal && LockMode != ELMLockMode.SimpleRight)
						{
							return ASRunStopLF;
						}
						return ASRunStopLB;
					case EAdvancedMonsterLocomotionLoopDir.RFtoRB:
						if (LockMode != ELMLockMode.Normal && LockMode != ELMLockMode.SimpleRight)
						{
							return ASRunStopRB;
						}
						return ASRunStopRF;
					case EAdvancedMonsterLocomotionLoopDir.RBtoRF:
						if (LockMode != ELMLockMode.Normal && LockMode != ELMLockMode.SimpleLeft)
						{
							return ASRunStopRF;
						}
						return ASRunStopRB;
					}
				}
				switch (StopDirection)
				{
				case ELockMoveDirectionSix.None:
				case ELockMoveDirectionSix.F:
					return ASRunStopFwd;
				case ELockMoveDirectionSix.FL:
					if (LockMode != ELMLockMode.Normal && LockMode != ELMLockMode.SimpleLeft)
					{
						return ASRunStopLB;
					}
					return ASRunStopLF;
				case ELockMoveDirectionSix.FR:
					if (LockMode != ELMLockMode.Normal && LockMode != ELMLockMode.SimpleRight)
					{
						return ASRunStopRB;
					}
					return ASRunStopRF;
				case ELockMoveDirectionSix.BL:
					if (LockMode != ELMLockMode.Normal && LockMode != ELMLockMode.SimpleRight)
					{
						return ASRunStopLF;
					}
					return ASRunStopLB;
				case ELockMoveDirectionSix.BR:
					if (LockMode != ELMLockMode.Normal && LockMode != ELMLockMode.SimpleLeft)
					{
						return ASRunStopRF;
					}
					return ASRunStopRB;
				case ELockMoveDirectionSix.B:
					return ASRunStopBwd;
				}
				break;
			}
			return ASRunStopFwd;
		}
		return null;
	}

	private UAnimSequence SelectRushAnim(EAdvancedMonsterLocomotionMoveState MoveState)
	{
		if (!bHasRushAnim)
		{
			return null;
		}
		EMoveDirectionFive eMoveDirectionFive = EMoveDirectionFive.None;
		if (AdvancedMonsterLocomotionData != null)
		{
			eMoveDirectionFive = AdvancedMonsterLocomotionData.FreeInputDirection;
		}
		switch (MoveState)
		{
		case EAdvancedMonsterLocomotionMoveState.Start:
			if (FreeMode == ELMFreeMode.Simple)
			{
				return ASRushStartFwd;
			}
			switch (eMoveDirectionFive)
			{
			case EMoveDirectionFive.None:
			case EMoveDirectionFive.F:
				return ASRushStartFwd;
			case EMoveDirectionFive.R:
				return ASRushStartRightMin;
			case EMoveDirectionFive.BR:
				return ASRushStartRightMax;
			case EMoveDirectionFive.BL:
				return ASRushStartLeftMax;
			case EMoveDirectionFive.L:
				return ASRushStartLeftMin;
			}
			break;
		case EAdvancedMonsterLocomotionMoveState.Turn:
			switch (eMoveDirectionFive)
			{
			case EMoveDirectionFive.None:
			case EMoveDirectionFive.F:
				return ASRushStartFwd;
			case EMoveDirectionFive.R:
				return ASRushSharpturnRightMin;
			case EMoveDirectionFive.BR:
				return ASRushSharpturnRightMax;
			case EMoveDirectionFive.BL:
				return ASRushSharpturnLeftMax;
			case EMoveDirectionFive.L:
				return ASRushSharpturnLeftMin;
			}
			break;
		case EAdvancedMonsterLocomotionMoveState.Stop:
			return ASRushStopFwd;
		}
		return null;
	}

	private UAnimSequence SelectMoveStartAnim()
	{
		UAnimSequence uAnimSequence = null;
		switch (GaitGroundedState)
		{
		case EGaitGroundedState.None:
		case EGaitGroundedState.Idle:
		case EGaitGroundedState.Walk:
			uAnimSequence = SelectWalkAnim(EAdvancedMonsterLocomotionMoveState.Start);
			break;
		case EGaitGroundedState.Run:
			uAnimSequence = SelectRunAnim(EAdvancedMonsterLocomotionMoveState.Start);
			break;
		case EGaitGroundedState.Rush:
			uAnimSequence = SelectRushAnim(EAdvancedMonsterLocomotionMoveState.Start);
			break;
		}
		if (uAnimSequence != null)
		{
			return uAnimSequence;
		}
		uAnimSequence = SelectRunAnim(EAdvancedMonsterLocomotionMoveState.Start);
		if (uAnimSequence != null)
		{
			return uAnimSequence;
		}
		uAnimSequence = SelectWalkAnim(EAdvancedMonsterLocomotionMoveState.Start);
		if (uAnimSequence != null)
		{
			return uAnimSequence;
		}
		return SelectRushAnim(EAdvancedMonsterLocomotionMoveState.Start);
	}

	private UAnimSequence SelectMoveLoopAnim(ELockMoveDirectionSix Direction)
	{
		if (GaitGroundedState == EGaitGroundedState.Rush)
		{
			return ASRushLoopFwd;
		}
		switch (Direction)
		{
		case ELockMoveDirectionSix.None:
		case ELockMoveDirectionSix.F:
			if (GaitGroundedState == EGaitGroundedState.Run || !bHasWalkAnim)
			{
				return ASRunLoopFwd;
			}
			return ASWalkLoopFwd;
		case ELockMoveDirectionSix.FL:
			if (GaitGroundedState == EGaitGroundedState.Run || !bHasWalkAnim)
			{
				return ASRunLoopLF;
			}
			return ASWalkLoopLF;
		case ELockMoveDirectionSix.FR:
			if (GaitGroundedState == EGaitGroundedState.Run || !bHasWalkAnim)
			{
				return ASRunLoopRF;
			}
			return ASWalkLoopRF;
		case ELockMoveDirectionSix.BL:
			if (GaitGroundedState == EGaitGroundedState.Run || !bHasWalkAnim)
			{
				return ASRunLoopLB;
			}
			return ASWalkLoopLB;
		case ELockMoveDirectionSix.BR:
			if (GaitGroundedState == EGaitGroundedState.Run || !bHasWalkAnim)
			{
				return ASRunLoopRB;
			}
			return ASWalkLoopRB;
		case ELockMoveDirectionSix.B:
			if (GaitGroundedState == EGaitGroundedState.Run || !bHasWalkAnim)
			{
				return ASRunLoopBwd;
			}
			return ASWalkLoopBwd;
		default:
			return null;
		}
	}

	private UAnimSequence SelectMoveLoopSimpleAnim()
	{
		ELockMoveDirectionSix eLockMoveDirectionSix = ELockMoveDirectionSix.None;
		if (AdvancedMonsterLocomotionData != null)
		{
			eLockMoveDirectionSix = AdvancedMonsterLocomotionData.VelocityDirection;
		}
		if (GaitGroundedState == EGaitGroundedState.Rush)
		{
			return ASRushLoopFwd;
		}
		switch (LockMode)
		{
		case ELMLockMode.Normal:
		case ELMLockMode.SimpleLeft:
			switch (eLockMoveDirectionSix)
			{
			case ELockMoveDirectionSix.None:
			case ELockMoveDirectionSix.F:
				if (GaitGroundedState == EGaitGroundedState.Run || !bHasWalkAnim)
				{
					return ASRunLoopFwd;
				}
				return ASWalkLoopFwd;
			case ELockMoveDirectionSix.FL:
			case ELockMoveDirectionSix.BL:
				if (GaitGroundedState == EGaitGroundedState.Run || !bHasWalkAnim)
				{
					return ASRunLoopLF;
				}
				return ASWalkLoopLF;
			case ELockMoveDirectionSix.FR:
			case ELockMoveDirectionSix.BR:
				if (GaitGroundedState == EGaitGroundedState.Run || !bHasWalkAnim)
				{
					return ASRunLoopRB;
				}
				return ASWalkLoopRB;
			case ELockMoveDirectionSix.B:
				if (GaitGroundedState == EGaitGroundedState.Run || !bHasWalkAnim)
				{
					return ASRunLoopBwd;
				}
				return ASWalkLoopBwd;
			}
			break;
		case ELMLockMode.SimpleRight:
			switch (eLockMoveDirectionSix)
			{
			case ELockMoveDirectionSix.None:
			case ELockMoveDirectionSix.F:
				if (GaitGroundedState == EGaitGroundedState.Run || !bHasWalkAnim)
				{
					return ASRunLoopFwd;
				}
				return ASWalkLoopFwd;
			case ELockMoveDirectionSix.FL:
			case ELockMoveDirectionSix.BL:
				if (GaitGroundedState == EGaitGroundedState.Run || !bHasWalkAnim)
				{
					return ASRunLoopLB;
				}
				return ASWalkLoopLB;
			case ELockMoveDirectionSix.FR:
			case ELockMoveDirectionSix.BR:
				if (GaitGroundedState == EGaitGroundedState.Run || !bHasWalkAnim)
				{
					return ASRunLoopRF;
				}
				return ASWalkLoopRF;
			case ELockMoveDirectionSix.B:
				if (GaitGroundedState == EGaitGroundedState.Run || !bHasWalkAnim)
				{
					return ASRunLoopBwd;
				}
				return ASWalkLoopBwd;
			}
			break;
		}
		return null;
	}

	private UAnimSequence SelectMoveTurnAnim()
	{
		UAnimSequence uAnimSequence = null;
		switch (MoveGaitGroundedState)
		{
		case EGaitGroundedState.None:
		case EGaitGroundedState.Idle:
		case EGaitGroundedState.Walk:
			uAnimSequence = SelectWalkAnim(EAdvancedMonsterLocomotionMoveState.Turn);
			break;
		case EGaitGroundedState.Run:
			uAnimSequence = SelectRunAnim(EAdvancedMonsterLocomotionMoveState.Turn);
			break;
		case EGaitGroundedState.Rush:
			uAnimSequence = SelectRushAnim(EAdvancedMonsterLocomotionMoveState.Turn);
			break;
		}
		if (uAnimSequence != null)
		{
			return uAnimSequence;
		}
		uAnimSequence = SelectRunAnim(EAdvancedMonsterLocomotionMoveState.Turn);
		if (uAnimSequence != null)
		{
			return uAnimSequence;
		}
		uAnimSequence = SelectWalkAnim(EAdvancedMonsterLocomotionMoveState.Turn);
		if (uAnimSequence != null)
		{
			return uAnimSequence;
		}
		return SelectRushAnim(EAdvancedMonsterLocomotionMoveState.Turn);
	}

	private UAnimSequence SelectMoveStopAnim()
	{
		UAnimSequence uAnimSequence = null;
		float num = 0f;
		if (BasicData != null)
		{
			num = BasicData.GetMappedSpeed();
		}
		uAnimSequence = ((num <= 1f && bHasWalkAnim) ? SelectWalkAnim(EAdvancedMonsterLocomotionMoveState.Stop) : ((!(num > 2f)) ? SelectRunAnim(EAdvancedMonsterLocomotionMoveState.Stop) : SelectRushAnim(EAdvancedMonsterLocomotionMoveState.Stop)));
		if (uAnimSequence != null)
		{
			return uAnimSequence;
		}
		uAnimSequence = SelectRunAnim(EAdvancedMonsterLocomotionMoveState.Stop);
		if (uAnimSequence != null)
		{
			return uAnimSequence;
		}
		uAnimSequence = SelectWalkAnim(EAdvancedMonsterLocomotionMoveState.Stop);
		if (uAnimSequence != null)
		{
			return uAnimSequence;
		}
		return SelectRushAnim(EAdvancedMonsterLocomotionMoveState.Stop);
	}

	private ELockMoveDirectionSix SelectLockMoveTurnDir()
	{
		ELockMoveDirectionSix eLockMoveDirectionSix = ELockMoveDirectionSix.None;
		if (AdvancedMonsterLocomotionData != null)
		{
			eLockMoveDirectionSix = AdvancedMonsterLocomotionData.InputDirection;
		}
		if (bMoveLoopTransNotFinish && eLockMoveDirectionSix != ELockMoveDirectionSix.F && eLockMoveDirectionSix != ELockMoveDirectionSix.B)
		{
			switch (CurrentMoveLoopDir)
			{
			case EAdvancedMonsterLocomotionLoopDir.LFtoLB:
				return ELockMoveDirectionSix.BR;
			case EAdvancedMonsterLocomotionLoopDir.LBtoLF:
				return ELockMoveDirectionSix.FR;
			case EAdvancedMonsterLocomotionLoopDir.RFtoRB:
				return ELockMoveDirectionSix.BL;
			case EAdvancedMonsterLocomotionLoopDir.RBtoRF:
				return ELockMoveDirectionSix.FL;
			}
		}
		if (bInvalidTurnDir)
		{
			switch (eLockMoveDirectionSix)
			{
			case ELockMoveDirectionSix.FL:
				return ELockMoveDirectionSix.BL;
			case ELockMoveDirectionSix.FR:
				return ELockMoveDirectionSix.BR;
			case ELockMoveDirectionSix.BL:
				return ELockMoveDirectionSix.FL;
			case ELockMoveDirectionSix.BR:
				return ELockMoveDirectionSix.FR;
			}
		}
		return eLockMoveDirectionSix;
	}

	private bool CanSwitchPivotDirection(ELockMoveDirectionSix OldDir, ELockMoveDirectionSix NewDir)
	{
		switch (OldDir)
		{
		case ELockMoveDirectionSix.FL:
		case ELockMoveDirectionSix.BL:
			if (NewDir != ELockMoveDirectionSix.FL)
			{
				return NewDir != ELockMoveDirectionSix.BL;
			}
			return false;
		case ELockMoveDirectionSix.FR:
		case ELockMoveDirectionSix.BR:
			if (NewDir != ELockMoveDirectionSix.FR)
			{
				return NewDir != ELockMoveDirectionSix.BR;
			}
			return false;
		default:
			return true;
		}
	}

	private bool ShouldStartToTrans(ELockMoveDirectionSix InputDirection)
	{
		if (!bSwitchToLock)
		{
			return false;
		}
		if (LockMode != ELMLockMode.Normal)
		{
			return false;
		}
		switch (StartInputDirection)
		{
		case ELockMoveDirectionSix.None:
		case ELockMoveDirectionSix.F:
		case ELockMoveDirectionSix.B:
			return false;
		case ELockMoveDirectionSix.FL:
			return InputDirection == ELockMoveDirectionSix.BL;
		case ELockMoveDirectionSix.FR:
			return InputDirection == ELockMoveDirectionSix.BR;
		case ELockMoveDirectionSix.BL:
			return InputDirection == ELockMoveDirectionSix.FL;
		case ELockMoveDirectionSix.BR:
			return InputDirection == ELockMoveDirectionSix.FR;
		default:
			return false;
		}
	}

	[UMeta(MDClass.BlueprintThreadSafe)]
	[UFunction]
	[Category("Thread Safe")]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:SetupIdleAnim")]
	private void SetupIdleAnim(ref FAnimUpdateContext Context, ref FAnimNodeReference Node)
	{
		USequencePlayerLibrary.ConvertToSequencePlayerPure(Node, out var SequencePlayer, out var Result);
		if (Result)
		{
			UAnimSequence uAnimSequence = null;
			if (ASIdleList.Count == 0)
			{
				uAnimSequence = AnimIdle;
			}
			else
			{
				int index = FMath.RandRange(0, ASIdleList.Count - 1);
				uAnimSequence = ASIdleList[index];
			}
			USequencePlayerLibrary.SetSequence(SequencePlayer, uAnimSequence);
		}
	}

	[UMeta(MDClass.BlueprintThreadSafe)]
	[UFunction]
	[Category("Thread Safe")]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:SetupIdleOutput")]
	private void SetupIdleOutput(ref FAnimUpdateContext Context, ref FAnimNodeReference Node)
	{
		bStartToTrans = false;
		bMoveLoopTransNotFinish = false;
		bInvalidTurnDir = false;
		CurrentMoveLoopDir = EAdvancedMonsterLocomotionLoopDir.None;
	}

	[UFunction]
	[BlueprintCallable]
	[Category("Thread Safe")]
	[UMeta(MDClass.BlueprintThreadSafe)]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:SetupMoveStartOutput")]
	private void SetupMoveStartOutput(ref FAnimUpdateContext Context, ref FAnimNodeReference Node)
	{
		bMoveStartSwitch = !bMoveStartSwitch;
		CurrentLockTurnDir = ELockMoveDirectionSix.None;
	}

	[UMeta(MDClass.BlueprintThreadSafe)]
	[Category("Thread Safe")]
	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:SetupMoveStartAnim")]
	private void SetupMoveStartAnim(ref FAnimUpdateContext Context, ref FAnimNodeReference Node)
	{
		USequenceEvaluatorLibrary.ConvertToSequenceEvaluatorPure(Node, out var SequenceEvaluator, out var Result);
		if (Result)
		{
			USequenceEvaluatorLibrary.SetSequence(SequenceEvaluator, SelectMoveStartAnim());
			USequenceEvaluatorLibrary.SetExplicitTime(SequenceEvaluator, 0f);
			StrideWarpingStartAlpha = 0f;
			bStartToTrans = false;
			if (AdvancedMonsterLocomotionData != null)
			{
				MoveStartInputDeltaAngle = AdvancedMonsterLocomotionData.InputDeltaAngle;
				StartInputDirection = AdvancedMonsterLocomotionData.InputDirection;
				StartOrTurnGaitGroundedState = AdvancedMonsterLocomotionData.GaitGroundedState;
			}
		}
	}

	[BlueprintCallable]
	[Category("Thread Safe")]
	[UMeta(MDClass.BlueprintThreadSafe)]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:UpdateMoveStartAnim")]
	private void UpdateMoveStartAnim(ref FAnimUpdateContext Context, ref FAnimNodeReference Node)
	{
		USequenceEvaluatorLibrary.ConvertToSequenceEvaluatorPure(Node, out var SequenceEvaluator, out var Result);
		if (!Result)
		{
			return;
		}
		float accumulatedTime = USequenceEvaluatorLibrary.GetAccumulatedTime(SequenceEvaluator);
		float moveStartInputDeltaAngle = 0f;
		bool flag = false;
		ELockMoveDirectionSix eLockMoveDirectionSix = ELockMoveDirectionSix.None;
		if (AdvancedMonsterLocomotionData != null)
		{
			flag = AdvancedMonsterLocomotionData.bSwitchToLock;
			moveStartInputDeltaAngle = AdvancedMonsterLocomotionData.InputDeltaAngle;
			StopDirection = AdvancedMonsterLocomotionData.InputDirection;
			eLockMoveDirectionSix = AdvancedMonsterLocomotionData.InputDirection;
			bChangeMoveSpeedInStartOrTurn = StartOrTurnGaitGroundedState != AdvancedMonsterLocomotionData.GaitGroundedState;
		}
		bStartToTrans = ShouldStartToTrans(eLockMoveDirectionSix);
		StartInputDirection = eLockMoveDirectionSix;
		if (flag && !bStartToTrans)
		{
			UAnimSequence uAnimSequence = SelectMoveStartAnim();
			if (USequenceEvaluatorLibrary.GetSequence(SequenceEvaluator) != uAnimSequence)
			{
				USequenceEvaluatorLibrary.SetSequenceWithInertialBlending(Context, SequenceEvaluator, uAnimSequence, 0.3f);
				MoveStartInputDeltaAngle = moveStartInputDeltaAngle;
			}
		}
		StrideWarpingStartAlpha = FMath.GetMappedRangeValueClamped(new FVector2D(0.0, StrideWarpingBlendInEndTime), new FVector2D(0.0, 1.0), accumulatedTime - StrideWarpingBlendInStartTime);
		UAnimDistanceMatchingLibrary.AdvanceTimeByDistanceMatching(PlayRateClamp: new FVector2D(FMath.Lerp(0.2f, PlayRateClampStartAndTurn.X, StrideWarpingStartAlpha), PlayRateClampStartAndTurn.Y), UpdateContext: Context, SequenceEvaluator: SequenceEvaluator, DistanceTraveled: MoveDistanceSinceLastUpdate, DistanceCurveName: B1GlobalFNames.Distance);
	}

	[UFunction]
	[BlueprintCallable]
	[Category("Thread Safe")]
	[UMeta(MDClass.BlueprintThreadSafe)]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:SetupMoveLoopAnim")]
	private void SetupMoveLoopAnim(ref FAnimUpdateContext Context, ref FAnimNodeReference Node)
	{
		if (AdvancedMonsterLocomotionData != null)
		{
			AdvancedMonsterLocomotionData.SetupMoveLoop();
		}
	}

	[UMeta(MDClass.BlueprintThreadSafe)]
	[BlueprintCallable]
	[Category("Thread Safe")]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:UpdateMoveLoopStateMachine")]
	private void UpdateMoveLoopStateMachine(ref FAnimUpdateContext Context, ref FAnimNodeReference Node)
	{
		StrideWarpingLoopAlpha = FMath.FInterpTo(StrideWarpingLoopAlpha, 1f, UAnimExecutionContextLibrary.GetDeltaTime(Context), 10f);
		if (AdvancedMonsterLocomotionData != null)
		{
			StopDirection = AdvancedMonsterLocomotionData.VelocityDirection;
		}
	}

	[BlueprintCallable]
	[UFunction]
	[Category("Thread Safe")]
	[UMeta(MDClass.BlueprintThreadSafe)]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:UpdateMoveLoopTransAnim")]
	private void UpdateMoveLoopTransAnim(ref FAnimUpdateContext Context, ref FAnimNodeReference Node)
	{
		USequencePlayerLibrary.ConvertToSequencePlayerPure(Node, out var SequencePlayer, out var Result);
		if (Result)
		{
			UAnimDistanceMatchingLibrary.SetPlayrateToMatchSpeed(SequencePlayer, MoveSpeedLastUpdate, PlayRateClampLoop);
		}
		if (WasAnimNotifyStateActiveInAnyState(UClass.GetClass<b1.BANS_GSNotFinishTrans>()))
		{
			bMoveLoopTransNotFinish = true;
		}
	}

	[UFunction]
	[BlueprintCallable]
	[Category("Thread Safe")]
	[UMeta(MDClass.BlueprintThreadSafe)]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:UpdateMoveLoopFwdAnim")]
	private void UpdateMoveLoopFwdAnim(ref FAnimUpdateContext Context, ref FAnimNodeReference Node)
	{
		USequencePlayerLibrary.ConvertToSequencePlayerPure(Node, out var SequencePlayer, out var Result);
		if (Result)
		{
			USequencePlayerLibrary.SetSequenceWithInertialBlending(Context, SequencePlayer, SelectMoveLoopAnim(ELockMoveDirectionSix.F), 0.25f);
			UAnimDistanceMatchingLibrary.SetPlayrateToMatchSpeed(SequencePlayer, MoveSpeedLastUpdate, PlayRateClampLoop);
			StrideWarpingLoopAlpha = FMath.FInterpTo(StrideWarpingLoopAlpha, 1f, UAnimExecutionContextLibrary.GetDeltaTime(Context), 10f);
			CurrentMoveLoopDir = EAdvancedMonsterLocomotionLoopDir.Fwd;
		}
	}

	[UFunction]
	[BlueprintCallable]
	[Category("Thread Safe")]
	[UMeta(MDClass.BlueprintThreadSafe)]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:UpdateMoveLoopBwdAnim")]
	private void UpdateMoveLoopBwdAnim(ref FAnimUpdateContext Context, ref FAnimNodeReference Node)
	{
		USequencePlayerLibrary.ConvertToSequencePlayerPure(Node, out var SequencePlayer, out var Result);
		if (Result)
		{
			USequencePlayerLibrary.SetSequenceWithInertialBlending(Context, SequencePlayer, SelectMoveLoopAnim(ELockMoveDirectionSix.B), 0.25f);
			UAnimDistanceMatchingLibrary.SetPlayrateToMatchSpeed(SequencePlayer, MoveSpeedLastUpdate, PlayRateClampLoop);
			StrideWarpingLoopAlpha = FMath.FInterpTo(StrideWarpingLoopAlpha, 1f, UAnimExecutionContextLibrary.GetDeltaTime(Context), 10f);
			CurrentMoveLoopDir = EAdvancedMonsterLocomotionLoopDir.Bwd;
		}
	}

	[UMeta(MDClass.BlueprintThreadSafe)]
	[UFunction]
	[BlueprintCallable]
	[Category("Thread Safe")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:UpdateMoveLoopFLAnim")]
	private void UpdateMoveLoopFLAnim(ref FAnimUpdateContext Context, ref FAnimNodeReference Node)
	{
		USequencePlayerLibrary.ConvertToSequencePlayerPure(Node, out var SequencePlayer, out var Result);
		if (Result)
		{
			USequencePlayerLibrary.SetSequenceWithInertialBlending(Context, SequencePlayer, SelectMoveLoopAnim(ELockMoveDirectionSix.FL), 0.25f);
			UAnimDistanceMatchingLibrary.SetPlayrateToMatchSpeed(SequencePlayer, MoveSpeedLastUpdate, PlayRateClampLoop);
			StrideWarpingLoopAlpha = FMath.FInterpTo(StrideWarpingLoopAlpha, 1f, UAnimExecutionContextLibrary.GetDeltaTime(Context), 10f);
			CurrentMoveLoopDir = EAdvancedMonsterLocomotionLoopDir.LF;
		}
	}

	[UFunction]
	[BlueprintCallable]
	[Category("Thread Safe")]
	[UMeta(MDClass.BlueprintThreadSafe)]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:UpdateMoveLoopFRAnim")]
	private void UpdateMoveLoopFRAnim(ref FAnimUpdateContext Context, ref FAnimNodeReference Node)
	{
		USequencePlayerLibrary.ConvertToSequencePlayerPure(Node, out var SequencePlayer, out var Result);
		if (Result)
		{
			USequencePlayerLibrary.SetSequenceWithInertialBlending(Context, SequencePlayer, SelectMoveLoopAnim(ELockMoveDirectionSix.FR), 0.25f);
			UAnimDistanceMatchingLibrary.SetPlayrateToMatchSpeed(SequencePlayer, MoveSpeedLastUpdate, PlayRateClampLoop);
			StrideWarpingLoopAlpha = FMath.FInterpTo(StrideWarpingLoopAlpha, 1f, UAnimExecutionContextLibrary.GetDeltaTime(Context), 10f);
			CurrentMoveLoopDir = EAdvancedMonsterLocomotionLoopDir.RF;
		}
	}

	[UFunction]
	[BlueprintCallable]
	[Category("Thread Safe")]
	[UMeta(MDClass.BlueprintThreadSafe)]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:UpdateMoveLoopBLAnim")]
	private void UpdateMoveLoopBLAnim(ref FAnimUpdateContext Context, ref FAnimNodeReference Node)
	{
		USequencePlayerLibrary.ConvertToSequencePlayerPure(Node, out var SequencePlayer, out var Result);
		if (Result)
		{
			USequencePlayerLibrary.SetSequenceWithInertialBlending(Context, SequencePlayer, SelectMoveLoopAnim(ELockMoveDirectionSix.BL), 0.25f);
			UAnimDistanceMatchingLibrary.SetPlayrateToMatchSpeed(SequencePlayer, MoveSpeedLastUpdate, PlayRateClampLoop);
			StrideWarpingLoopAlpha = FMath.FInterpTo(StrideWarpingLoopAlpha, 1f, UAnimExecutionContextLibrary.GetDeltaTime(Context), 10f);
			CurrentMoveLoopDir = EAdvancedMonsterLocomotionLoopDir.LB;
		}
	}

	[UMeta(MDClass.BlueprintThreadSafe)]
	[Category("Thread Safe")]
	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:UpdateMoveLoopBRAnim")]
	private void UpdateMoveLoopBRAnim(ref FAnimUpdateContext Context, ref FAnimNodeReference Node)
	{
		USequencePlayerLibrary.ConvertToSequencePlayerPure(Node, out var SequencePlayer, out var Result);
		if (Result)
		{
			USequencePlayerLibrary.SetSequenceWithInertialBlending(Context, SequencePlayer, SelectMoveLoopAnim(ELockMoveDirectionSix.BR), 0.25f);
			UAnimDistanceMatchingLibrary.SetPlayrateToMatchSpeed(SequencePlayer, MoveSpeedLastUpdate, PlayRateClampLoop);
			StrideWarpingLoopAlpha = FMath.FInterpTo(StrideWarpingLoopAlpha, 1f, UAnimExecutionContextLibrary.GetDeltaTime(Context), 10f);
			CurrentMoveLoopDir = EAdvancedMonsterLocomotionLoopDir.RB;
		}
	}

	[UMeta(MDClass.BlueprintThreadSafe)]
	[UFunction]
	[BlueprintCallable]
	[Category("Thread Safe")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:UpdateMoveLoopRF2RBOutput")]
	private void UpdateMoveLoopRF2RBOutput(ref FAnimUpdateContext Context, ref FAnimNodeReference Node)
	{
		CurrentMoveLoopDir = EAdvancedMonsterLocomotionLoopDir.RFtoRB;
	}

	[UFunction]
	[BlueprintCallable]
	[Category("Thread Safe")]
	[UMeta(MDClass.BlueprintThreadSafe)]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:UpdateMoveLoopRB2RFOutput")]
	private void UpdateMoveLoopRB2RFOutput(ref FAnimUpdateContext Context, ref FAnimNodeReference Node)
	{
		CurrentMoveLoopDir = EAdvancedMonsterLocomotionLoopDir.RBtoRF;
	}

	[UFunction]
	[BlueprintCallable]
	[Category("Thread Safe")]
	[UMeta(MDClass.BlueprintThreadSafe)]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:UpdateMoveLoopLF2LBOutput")]
	private void UpdateMoveLoopLF2LBOutput(ref FAnimUpdateContext Context, ref FAnimNodeReference Node)
	{
		CurrentMoveLoopDir = EAdvancedMonsterLocomotionLoopDir.LFtoLB;
	}

	[UMeta(MDClass.BlueprintThreadSafe)]
	[BlueprintCallable]
	[UFunction]
	[Category("Thread Safe")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:UpdateMoveLoopLB2LFOutput")]
	private void UpdateMoveLoopLB2LFOutput(ref FAnimUpdateContext Context, ref FAnimNodeReference Node)
	{
		CurrentMoveLoopDir = EAdvancedMonsterLocomotionLoopDir.LBtoLF;
	}

	[UFunction]
	[Category("Thread Safe")]
	[UMeta(MDClass.BlueprintThreadSafe)]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:UpdateMoveLoopSimpleAnim")]
	private void UpdateMoveLoopSimpleAnim(ref FAnimUpdateContext Context, ref FAnimNodeReference Node)
	{
		USequencePlayerLibrary.ConvertToSequencePlayerPure(Node, out var SequencePlayer, out var Result);
		if (!Result)
		{
			return;
		}
		UAnimSequence uAnimSequence = SelectMoveLoopSimpleAnim();
		if (USequencePlayerLibrary.GetSequencePure(SequencePlayer) != uAnimSequence)
		{
			USequencePlayerLibrary.SetSequenceWithInertialBlending(Context, SequencePlayer, uAnimSequence, 0.3f);
		}
		UAnimDistanceMatchingLibrary.SetPlayrateToMatchSpeed(SequencePlayer, MoveSpeedLastUpdate, PlayRateClampLoop);
		StrideWarpingLoopAlpha = FMath.FInterpTo(StrideWarpingLoopAlpha, 1f, UAnimExecutionContextLibrary.GetDeltaTime(Context), 10f);
		if (AdvancedMonsterLocomotionData != null)
		{
			switch (AdvancedMonsterLocomotionData.VelocityDirection)
			{
			case ELockMoveDirectionSix.None:
				CurrentMoveLoopDir = EAdvancedMonsterLocomotionLoopDir.None;
				break;
			case ELockMoveDirectionSix.F:
				CurrentMoveLoopDir = EAdvancedMonsterLocomotionLoopDir.Fwd;
				break;
			case ELockMoveDirectionSix.FL:
				CurrentMoveLoopDir = EAdvancedMonsterLocomotionLoopDir.LF;
				break;
			case ELockMoveDirectionSix.FR:
				CurrentMoveLoopDir = EAdvancedMonsterLocomotionLoopDir.RF;
				break;
			case ELockMoveDirectionSix.BL:
				CurrentMoveLoopDir = EAdvancedMonsterLocomotionLoopDir.LB;
				break;
			case ELockMoveDirectionSix.BR:
				CurrentMoveLoopDir = EAdvancedMonsterLocomotionLoopDir.RB;
				break;
			case ELockMoveDirectionSix.B:
				CurrentMoveLoopDir = EAdvancedMonsterLocomotionLoopDir.Bwd;
				break;
			}
		}
	}

	[UFunction]
	[BlueprintCallable]
	[Category("Thread Safe")]
	[UMeta(MDClass.BlueprintThreadSafe)]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:SetupMoveLoopOutput")]
	private void SetupMoveLoopOutput(ref FAnimUpdateContext Context, ref FAnimNodeReference Node)
	{
		if (AdvancedMonsterLocomotionData != null)
		{
			AdvancedMonsterLocomotionData.ResetMoveLoopAlpha();
		}
		bFirstUpdateLoopOutput = true;
	}

	[UFunction]
	[BlueprintCallable]
	[Category("Thread Safe")]
	[UMeta(MDClass.BlueprintThreadSafe)]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:UpdateMoveLoopOutput")]
	private void UpdateMoveLoopOutput(ref FAnimUpdateContext Context, ref FAnimNodeReference Node)
	{
		float num = 0f;
		float num2 = 0f;
		if (AdvancedMonsterLocomotionData != null)
		{
			AdvancedMonsterLocomotionData.UpdateMoveLoopAlpha(UAnimExecutionContextLibrary.GetDeltaTime(Context));
			num = AdvancedMonsterLocomotionData.VelocityLeanAlpha;
			num2 = AdvancedMonsterLocomotionData.MoveLoopAlpha;
		}
		float deltaTime = UAnimExecutionContextLibrary.GetDeltaTime(Context);
		float num3 = num * num2;
		MoveLoopSpine01AngleOffset = FMath.FInterpTo(MoveLoopSpine01AngleOffset, FMath.GetMappedRangeValueClamped(AlphaRange, Spine01AngleOffsetRange, num3), deltaTime, 6f);
		MoveLoopSpine02AngleOffset = FMath.FInterpTo(MoveLoopSpine02AngleOffset, FMath.GetMappedRangeValueClamped(AlphaRange, Spine02AngleOffsetRange, num3), deltaTime, 6f);
		MoveLoopSpine03AngleOffset = FMath.FInterpTo(MoveLoopSpine03AngleOffset, FMath.GetMappedRangeValueClamped(AlphaRange, Spine03AngleOffsetRange, num3), deltaTime, 6f);
		MoveLoopHeadAngleOffset = FMath.FInterpTo(MoveLoopHeadAngleOffset, FMath.GetMappedRangeValueClamped(AlphaRange, HeadAngleOffsetRange, num3), deltaTime, 6f);
		if (bFirstUpdateLoopOutput)
		{
			bFirstUpdateLoopOutput = false;
			return;
		}
		bStartToTrans = false;
		bMoveLoopTransNotFinish = false;
		bInvalidTurnDir = false;
		CurrentMoveLoopDir = EAdvancedMonsterLocomotionLoopDir.None;
	}

	[UMeta(MDClass.BlueprintThreadSafe)]
	[Category("Thread Safe")]
	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:SetupMoveLoopAdditiveAnim")]
	private void SetupMoveLoopAdditiveAnim(ref FAnimUpdateContext Context, ref FAnimNodeReference Node)
	{
		USequencePlayerLibrary.ConvertToSequencePlayerPure(Node, out var SequencePlayer, out var Result);
		if (!Result)
		{
			return;
		}
		TArrayReadWrite<UAnimSequence> tArrayReadWrite = null;
		if (AdvancedMonsterLocomotionData != null)
		{
			switch (GaitGroundedState)
			{
			case EGaitGroundedState.Walk:
				tArrayReadWrite = ASWalkLoopAdditiveList;
				break;
			case EGaitGroundedState.Run:
				tArrayReadWrite = ASRunLoopAdditiveList;
				break;
			case EGaitGroundedState.Rush:
				tArrayReadWrite = ASRushLoopAdditiveList;
				break;
			}
		}
		if (tArrayReadWrite != null && tArrayReadWrite.Count > 0)
		{
			int index = FMath.RandRange(0, tArrayReadWrite.Count - 1);
			USequencePlayerLibrary.SetSequenceWithInertialBlending(Context, SequencePlayer, tArrayReadWrite[index], 0.25f);
		}
	}

	[UMeta(MDClass.BlueprintThreadSafe)]
	[UFunction]
	[BlueprintCallable]
	[Category("Thread Safe")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:SetupMoveTurnOutput")]
	private void SetupMoveTurnOutput(ref FAnimUpdateContext Context, ref FAnimNodeReference Node)
	{
		bMoveTurnSwitch = !bMoveTurnSwitch;
	}

	[UFunction]
	[BlueprintCallable]
	[Category("Thread Safe")]
	[UMeta(MDClass.BlueprintThreadSafe)]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:UpdateMoveTurnOutput")]
	private void UpdateMoveTurnOutput(ref FAnimUpdateContext Context, ref FAnimNodeReference Node)
	{
		TurnTimer += UAnimExecutionContextLibrary.GetDeltaTime(Context);
	}

	[UFunction]
	[BlueprintCallable]
	[Category("Thread Safe")]
	[UMeta(MDClass.BlueprintThreadSafe)]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:SetupMoveTurnAnim")]
	private void SetupMoveTurnAnim(ref FAnimUpdateContext Context, ref FAnimNodeReference Node)
	{
		ELockMoveDirectionSix eLockMoveDirectionSix = ELockMoveDirectionSix.None;
		ELockMoveDirectionSix eLockMoveDirectionSix2 = ELockMoveDirectionSix.None;
		if (AdvancedMonsterLocomotionData != null)
		{
			MoveTurnInputDeltaAngle = AdvancedMonsterLocomotionData.InputDeltaAngle;
			eLockMoveDirectionSix = AdvancedMonsterLocomotionData.InputDirection;
			eLockMoveDirectionSix2 = AdvancedMonsterLocomotionData.LastFrameInputDirection;
			StartOrTurnGaitGroundedState = AdvancedMonsterLocomotionData.GaitGroundedState;
		}
		USequenceEvaluatorLibrary.ConvertToSequenceEvaluatorPure(Node, out var SequenceEvaluator, out var Result);
		if (Result)
		{
			bInvalidTurnDir = false;
			switch (eLockMoveDirectionSix2)
			{
			case ELockMoveDirectionSix.FL:
			case ELockMoveDirectionSix.FR:
				bInvalidTurnDir = eLockMoveDirectionSix == ELockMoveDirectionSix.FL || eLockMoveDirectionSix == ELockMoveDirectionSix.FR;
				break;
			case ELockMoveDirectionSix.BL:
			case ELockMoveDirectionSix.BR:
				bInvalidTurnDir = eLockMoveDirectionSix == ELockMoveDirectionSix.BL || eLockMoveDirectionSix == ELockMoveDirectionSix.BR;
				break;
			}
			CurrentLockTurnDir = SelectLockMoveTurnDir();
			USequenceEvaluatorLibrary.SetSequence(SequenceEvaluator, SelectMoveTurnAnim());
			USequenceEvaluatorLibrary.SetExplicitTime(SequenceEvaluator, 0f);
			if (bMoveLoopTransNotFinish && (eLockMoveDirectionSix == ELockMoveDirectionSix.F || eLockMoveDirectionSix == ELockMoveDirectionSix.B))
			{
				bMoveLoopTransNotFinish = false;
			}
			StrideWarpingTurnAlpha = 0f;
			ExplicitTimeTurnFinish = 0f;
			TurnTimer = 0f;
			bFirstUpdateTurnAnim = true;
		}
	}

	[UMeta(MDClass.BlueprintThreadSafe)]
	[UFunction]
	[Category("Thread Safe")]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:UpdateMoveTurnAnim")]
	private void UpdateMoveTurnAnim(ref FAnimUpdateContext Context, ref FAnimNodeReference Node)
	{
		USequenceEvaluatorLibrary.ConvertToSequenceEvaluatorPure(Node, out var SequenceEvaluator, out var Result);
		if (!Result)
		{
			return;
		}
		bool flag = false;
		float num = 0f;
		float moveTurnInputDeltaAngle = 0f;
		float groundFriction = 0f;
		float num2 = 0f;
		ELockMoveDirectionSix eLockMoveDirectionSix = ELockMoveDirectionSix.None;
		FVector velocity = FVector.ZeroVector;
		FVector acceleration = FVector.ZeroVector;
		if (AdvancedMonsterLocomotionData != null)
		{
			flag = AdvancedMonsterLocomotionData.bSwitchToLock;
			num = AdvancedMonsterLocomotionData.InputVelocityAngle;
			moveTurnInputDeltaAngle = AdvancedMonsterLocomotionData.InputDeltaAngle;
			eLockMoveDirectionSix = AdvancedMonsterLocomotionData.InputDirection;
			bChangeMoveSpeedInStartOrTurn = StartOrTurnGaitGroundedState != AdvancedMonsterLocomotionData.GaitGroundedState;
		}
		if (ChrData != null)
		{
			groundFriction = ChrData.GroundFriction;
			velocity = ChrData.Velocity;
			acceleration = ChrData.MoveAcceleration;
			num2 = ChrData.ActorScale3D.X;
		}
		float accumulatedTime = USequenceEvaluatorLibrary.GetAccumulatedTime(SequenceEvaluator);
		StopDirection = eLockMoveDirectionSix;
		bLockTurnToLoop = false;
		if (flag)
		{
			if (TurnTimer < 0.2f)
			{
				ELockMoveDirectionSix eLockMoveDirectionSix2 = SelectLockMoveTurnDir();
				if (CanSwitchPivotDirection(CurrentLockTurnDir, eLockMoveDirectionSix2))
				{
					CurrentLockTurnDir = eLockMoveDirectionSix2;
					UAnimSequence uAnimSequence = SelectMoveTurnAnim();
					if (USequenceEvaluatorLibrary.GetSequence(SequenceEvaluator) != uAnimSequence)
					{
						USequenceEvaluatorLibrary.SetSequenceWithInertialBlending(Context, SequenceEvaluator, uAnimSequence);
						MoveTurnInputDeltaAngle = moveTurnInputDeltaAngle;
					}
				}
			}
			else if (TurnTimer >= 0.3f)
			{
				bLockTurnToLoop = ShouldPivotTransDirection(eLockMoveDirectionSix);
			}
		}
		if (!bFirstUpdateTurnAnim)
		{
			AnimFuncLib.GetCurveValueFromAnimInstance(TopAnimInst.Address, ref Distance, out var OutIsActive, out var _);
			if (!OutIsActive)
			{
				USequenceEvaluatorLibrary.AdvanceTime(Context, SequenceEvaluator);
				return;
			}
		}
		if (num > 90f || bFirstUpdateTurnAnim)
		{
			float num3 = UAnimCharacterMovementLibrary.PredictGroundMovementPivotLocation(acceleration, velocity, groundFriction).Size2D();
			num3 /= num2;
			if (flag)
			{
				UAnimDistanceMatchingLibrary.DistanceMatchToTarget(SequenceEvaluator, num3, B1GlobalFNames.Distance);
			}
			else
			{
				UGSE_AnimDistanceMatchingLibrary.AdvanceTimeByDistanceMatchToTarget(Context, SequenceEvaluator, num3, B1GlobalFNames.Distance, PlayRateClampStartAndTurn);
			}
			ExplicitTimeTurnFinish = accumulatedTime;
			bFirstUpdateTurnAnim = false;
		}
		else
		{
			StrideWarpingTurnAlpha = FMath.GetMappedRangeValueClamped(new FVector2D(0.0, StrideWarpingBlendInEndTime), new FVector2D(0.0, 1.0), accumulatedTime - ExplicitTimeTurnFinish - StrideWarpingBlendInStartTime);
			UAnimDistanceMatchingLibrary.AdvanceTimeByDistanceMatching(PlayRateClamp: new FVector2D(FMath.Lerp(0.2f, PlayRateClampStartAndTurn.X, StrideWarpingTurnAlpha), PlayRateClampStartAndTurn.Y), UpdateContext: Context, SequenceEvaluator: SequenceEvaluator, DistanceTraveled: MoveDistanceSinceLastUpdate, DistanceCurveName: B1GlobalFNames.Distance);
		}
	}

	[UFunction]
	[BlueprintCallable]
	[Category("Thread Safe")]
	[UMeta(MDClass.BlueprintThreadSafe)]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:SetupMoveStopOutput")]
	private void SetupMoveStopOutput(ref FAnimUpdateContext Context, ref FAnimNodeReference Node)
	{
		StopTimer = 0f;
		bMoveToTurn = true;
	}

	[UFunction]
	[BlueprintCallable]
	[Category("Thread Safe")]
	[UMeta(MDClass.BlueprintThreadSafe)]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:UpdateMoveStopOutput")]
	private void UpdateMoveStopOutput(ref FAnimUpdateContext Context, ref FAnimNodeReference Node)
	{
		if (!ShouldToMove())
		{
			StopTimer += UAnimExecutionContextLibrary.GetDeltaTime(Context);
			if (StopTimer > 0.25f)
			{
				bMoveToTurn = false;
				bStartToTrans = false;
				bMoveLoopTransNotFinish = false;
				bInvalidTurnDir = false;
				CurrentMoveLoopDir = EAdvancedMonsterLocomotionLoopDir.None;
			}
		}
	}

	[UMeta(MDClass.BlueprintThreadSafe)]
	[Category("Thread Safe")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:SetupMoveStopAnim")]
	private void SetupMoveStopAnim(ref FAnimUpdateContext Context, ref FAnimNodeReference Node)
	{
		bool flag = false;
		bool flag2 = false;
		if (ChrData != null)
		{
			flag = !ChrData.Velocity.IsNearlyZero();
			flag2 = !ChrData.MoveAcceleration.IsNearlyZero();
		}
		if (AdvancedMonsterLocomotionData != null)
		{
			StopInputDirection = AdvancedMonsterLocomotionData.InputDirection;
			StopVelocityDeltaAngle = AdvancedMonsterLocomotionData.VelocityDeltaAngle;
		}
		USequenceEvaluatorLibrary.ConvertToSequenceEvaluatorPure(Node, out var SequenceEvaluator, out var Result);
		if (Result)
		{
			USequenceEvaluatorLibrary.SetSequence(SequenceEvaluator, SelectMoveStopAnim());
			USequenceEvaluatorLibrary.SetExplicitTime(SequenceEvaluator, 0f);
			if (!flag || flag2)
			{
				UAnimDistanceMatchingLibrary.DistanceMatchToTarget(SequenceEvaluator, 0f, B1GlobalFNames.Distance);
			}
		}
	}

	[UFunction]
	[BlueprintCallable]
	[Category("Thread Safe")]
	[UMeta(MDClass.BlueprintThreadSafe)]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:UpdateMoveStopAnim")]
	private void UpdateMoveStopAnim(ref FAnimUpdateContext Context, ref FAnimNodeReference Node)
	{
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		bool bUseSeparateBrakingFriction = false;
		float groundFriction = 0f;
		float brakingFriction = 0f;
		float brakingFrictionFactor = 0f;
		float brakingDecelerationWalking = 0f;
		float num = 0f;
		FVector velocity = FVector.ZeroVector;
		EGaitGroundedState eGaitGroundedState = EGaitGroundedState.None;
		ELockMoveDirectionSix eLockMoveDirectionSix = ELockMoveDirectionSix.None;
		if (ChrData != null)
		{
			velocity = ChrData.Velocity;
			flag = !ChrData.MoveAcceleration.IsNearlyZero();
			flag2 = ChrData.IsMontage;
			bUseSeparateBrakingFriction = ChrData.bUseSeparateBrakingFriction;
			groundFriction = ChrData.GroundFriction;
			brakingFriction = ChrData.BrakingFriction;
			brakingFrictionFactor = ChrData.BrakingFrictionFactor;
			brakingDecelerationWalking = ChrData.BrakingDecelerationWalking;
			num = ChrData.ActorScale3D.X;
		}
		if (AdvancedMonsterLocomotionData != null)
		{
			flag3 = AdvancedMonsterLocomotionData.bSwitchToLock;
			eGaitGroundedState = AdvancedMonsterLocomotionData.GaitGroundedState;
			eLockMoveDirectionSix = AdvancedMonsterLocomotionData.InputDirection;
		}
		USequenceEvaluatorLibrary.ConvertToSequenceEvaluatorPure(Node, out var SequenceEvaluator, out var Result);
		if (!Result)
		{
			return;
		}
		if (flag3 && eGaitGroundedState == EGaitGroundedState.Idle && eLockMoveDirectionSix != StopInputDirection)
		{
			UAnimSequence uAnimSequence = SelectMoveStopAnim();
			if (USequenceEvaluatorLibrary.GetSequence(SequenceEvaluator) != uAnimSequence)
			{
				USequenceEvaluatorLibrary.SetSequenceWithInertialBlending(Context, SequenceEvaluator, uAnimSequence, 0.3f);
				StopInputDirection = eLockMoveDirectionSix;
			}
		}
		if (flag2 && !BGUFunctionLibraryCS.BGUCanMoveRun(Owner))
		{
			USequenceEvaluatorLibrary.AdvanceTime(Context, SequenceEvaluator);
			return;
		}
		if (!velocity.IsNearlyZero() && !flag)
		{
			float num2 = UAnimCharacterMovementLibrary.PredictGroundMovementStopLocation(velocity, bUseSeparateBrakingFriction, brakingFriction, groundFriction, brakingFrictionFactor, brakingDecelerationWalking).Size2D();
			if (num2 > 0f)
			{
				num2 /= num;
				UAnimDistanceMatchingLibrary.DistanceMatchToTarget(SequenceEvaluator, num2, B1GlobalFNames.Distance);
				return;
			}
		}
		USequenceEvaluatorLibrary.AdvanceTime(Context, SequenceEvaluator);
	}

	[UFunction]
	[BlueprintPure]
	[Category("Transition Rule")]
	[UMeta(MDClass.BlueprintThreadSafe)]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldToMove")]
	private bool ShouldToMove()
	{
		if (GaitGroundedState != EGaitGroundedState.None)
		{
			return GaitGroundedState != EGaitGroundedState.Idle;
		}
		return false;
	}

	[UFunction]
	[BlueprintPure]
	[Category("Transition Rule")]
	[UMeta(MDClass.BlueprintThreadSafe)]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopToFwd")]
	private bool ShouldMoveLoopToFwd()
	{
		if (AdvancedMonsterLocomotionData == null)
		{
			return false;
		}
		if (!AdvancedMonsterLocomotionData.bSwitchToLock)
		{
			return true;
		}
		return AdvancedMonsterLocomotionData.VelocityDirection == ELockMoveDirectionSix.F;
	}

	[UMeta(MDClass.BlueprintThreadSafe)]
	[Category("Transition Rule")]
	[UFunction]
	[BlueprintPure]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopLeftFwd")]
	private bool ShouldMoveLoopLeftFwd()
	{
		if (AdvancedMonsterLocomotionData == null)
		{
			return false;
		}
		if (!AdvancedMonsterLocomotionData.bSwitchToLock)
		{
			return false;
		}
		ELockMoveDirectionSix velocityDirection = AdvancedMonsterLocomotionData.VelocityDirection;
		if (velocityDirection != ELockMoveDirectionSix.F)
		{
			return !ShouldPivotTransDirection(velocityDirection);
		}
		return false;
	}

	[UFunction]
	[BlueprintPure]
	[Category("Transition Rule")]
	[UMeta(MDClass.BlueprintThreadSafe)]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopToBwd")]
	private bool ShouldMoveLoopToBwd()
	{
		if (AdvancedMonsterLocomotionData == null)
		{
			return false;
		}
		if (!AdvancedMonsterLocomotionData.bSwitchToLock)
		{
			return false;
		}
		return AdvancedMonsterLocomotionData.VelocityDirection == ELockMoveDirectionSix.B;
	}

	[UFunction]
	[BlueprintPure]
	[Category("Transition Rule")]
	[UMeta(MDClass.BlueprintThreadSafe)]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopLeftBwd")]
	private bool ShouldMoveLoopLeftBwd()
	{
		if (AdvancedMonsterLocomotionData == null)
		{
			return false;
		}
		if (!AdvancedMonsterLocomotionData.bSwitchToLock)
		{
			return false;
		}
		ELockMoveDirectionSix velocityDirection = AdvancedMonsterLocomotionData.VelocityDirection;
		if (velocityDirection != ELockMoveDirectionSix.B)
		{
			return !ShouldPivotTransDirection(velocityDirection);
		}
		return false;
	}

	[UFunction]
	[BlueprintPure]
	[Category("Transition Rule")]
	[UMeta(MDClass.BlueprintThreadSafe)]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopToFL")]
	private bool ShouldMoveLoopToFL()
	{
		if (AdvancedMonsterLocomotionData == null)
		{
			return false;
		}
		if (!AdvancedMonsterLocomotionData.bSwitchToLock)
		{
			return false;
		}
		return AdvancedMonsterLocomotionData.VelocityDirection == ELockMoveDirectionSix.FL;
	}

	[UMeta(MDClass.BlueprintThreadSafe)]
	[UFunction]
	[BlueprintPure]
	[Category("Transition Rule")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopLeftFL")]
	private bool ShouldMoveLoopLeftFL()
	{
		if (AdvancedMonsterLocomotionData == null)
		{
			return false;
		}
		if (!AdvancedMonsterLocomotionData.bSwitchToLock)
		{
			return false;
		}
		ELockMoveDirectionSix velocityDirection = AdvancedMonsterLocomotionData.VelocityDirection;
		if (velocityDirection != ELockMoveDirectionSix.FL)
		{
			return !ShouldPivotTransDirection(velocityDirection);
		}
		return false;
	}

	[UFunction]
	[BlueprintPure]
	[Category("Transition Rule")]
	[UMeta(MDClass.BlueprintThreadSafe)]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopToFR")]
	private bool ShouldMoveLoopToFR()
	{
		if (AdvancedMonsterLocomotionData == null)
		{
			return false;
		}
		if (!AdvancedMonsterLocomotionData.bSwitchToLock)
		{
			return false;
		}
		return AdvancedMonsterLocomotionData.VelocityDirection == ELockMoveDirectionSix.FR;
	}

	[UMeta(MDClass.BlueprintThreadSafe)]
	[UFunction]
	[BlueprintPure]
	[Category("Transition Rule")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopLeftFR")]
	private bool ShouldMoveLoopLeftFR()
	{
		if (AdvancedMonsterLocomotionData == null)
		{
			return false;
		}
		if (!AdvancedMonsterLocomotionData.bSwitchToLock)
		{
			return false;
		}
		ELockMoveDirectionSix velocityDirection = AdvancedMonsterLocomotionData.VelocityDirection;
		if (velocityDirection != ELockMoveDirectionSix.FR)
		{
			return !ShouldPivotTransDirection(velocityDirection);
		}
		return false;
	}

	[UFunction]
	[BlueprintPure]
	[Category("Transition Rule")]
	[UMeta(MDClass.BlueprintThreadSafe)]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopToBL")]
	private bool ShouldMoveLoopToBL()
	{
		if (AdvancedMonsterLocomotionData == null)
		{
			return false;
		}
		if (!AdvancedMonsterLocomotionData.bSwitchToLock)
		{
			return false;
		}
		return AdvancedMonsterLocomotionData.VelocityDirection == ELockMoveDirectionSix.BL;
	}

	[UMeta(MDClass.BlueprintThreadSafe)]
	[UFunction]
	[BlueprintPure]
	[Category("Transition Rule")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopLeftBL")]
	private bool ShouldMoveLoopLeftBL()
	{
		if (AdvancedMonsterLocomotionData == null)
		{
			return false;
		}
		if (!AdvancedMonsterLocomotionData.bSwitchToLock)
		{
			return false;
		}
		ELockMoveDirectionSix velocityDirection = AdvancedMonsterLocomotionData.VelocityDirection;
		if (velocityDirection != ELockMoveDirectionSix.BL)
		{
			return !ShouldPivotTransDirection(velocityDirection);
		}
		return false;
	}

	[BlueprintPure]
	[Category("Transition Rule")]
	[UMeta(MDClass.BlueprintThreadSafe)]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopToBR")]
	private bool ShouldMoveLoopToBR()
	{
		if (AdvancedMonsterLocomotionData == null)
		{
			return false;
		}
		if (!AdvancedMonsterLocomotionData.bSwitchToLock)
		{
			return false;
		}
		return AdvancedMonsterLocomotionData.VelocityDirection == ELockMoveDirectionSix.BR;
	}

	[UFunction]
	[BlueprintPure]
	[Category("Transition Rule")]
	[UMeta(MDClass.BlueprintThreadSafe)]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopLeftBR")]
	private bool ShouldMoveLoopLeftBR()
	{
		if (AdvancedMonsterLocomotionData == null)
		{
			return false;
		}
		if (!AdvancedMonsterLocomotionData.bSwitchToLock)
		{
			return false;
		}
		ELockMoveDirectionSix velocityDirection = AdvancedMonsterLocomotionData.VelocityDirection;
		if (velocityDirection != ELockMoveDirectionSix.BR)
		{
			return !ShouldPivotTransDirection(velocityDirection);
		}
		return false;
	}

	[BlueprintPure]
	[UFunction]
	[Category("Transition Rule")]
	[UMeta(MDClass.BlueprintThreadSafe)]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopTransToFL")]
	private bool ShouldMoveLoopTransToFL()
	{
		if (AdvancedMonsterLocomotionData == null)
		{
			return false;
		}
		if (!AdvancedMonsterLocomotionData.bSwitchToLock)
		{
			return false;
		}
		if (!HasTransAnim(AdvancedMonsterLocomotionData.GaitGroundedState))
		{
			return false;
		}
		if (AdvancedMonsterLocomotionData.VelocityDirection == ELockMoveDirectionSix.FL)
		{
			if (!bStartToTrans)
			{
				if (CurrentLockTurnDir != ELockMoveDirectionSix.None)
				{
					return CurrentLockTurnDir != AdvancedMonsterLocomotionData.VelocityDirection;
				}
				return false;
			}
			return true;
		}
		return false;
	}

	[UFunction]
	[BlueprintPure]
	[Category("Transition Rule")]
	[UMeta(MDClass.BlueprintThreadSafe)]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopTransToFR")]
	private bool ShouldMoveLoopTransToFR()
	{
		if (AdvancedMonsterLocomotionData == null)
		{
			return false;
		}
		if (!AdvancedMonsterLocomotionData.bSwitchToLock)
		{
			return false;
		}
		if (!HasTransAnim(AdvancedMonsterLocomotionData.GaitGroundedState))
		{
			return false;
		}
		if (AdvancedMonsterLocomotionData.VelocityDirection == ELockMoveDirectionSix.FR)
		{
			if (!bStartToTrans)
			{
				if (CurrentLockTurnDir != ELockMoveDirectionSix.None)
				{
					return CurrentLockTurnDir != AdvancedMonsterLocomotionData.VelocityDirection;
				}
				return false;
			}
			return true;
		}
		return false;
	}

	[UFunction]
	[Category("Transition Rule")]
	[UMeta(MDClass.BlueprintThreadSafe)]
	[BlueprintPure]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopTransToBL")]
	private bool ShouldMoveLoopTransToBL()
	{
		if (AdvancedMonsterLocomotionData == null)
		{
			return false;
		}
		if (!AdvancedMonsterLocomotionData.bSwitchToLock)
		{
			return false;
		}
		if (!HasTransAnim(AdvancedMonsterLocomotionData.GaitGroundedState))
		{
			return false;
		}
		if (AdvancedMonsterLocomotionData.VelocityDirection == ELockMoveDirectionSix.BL)
		{
			if (!bStartToTrans)
			{
				if (CurrentLockTurnDir != ELockMoveDirectionSix.None)
				{
					return CurrentLockTurnDir != AdvancedMonsterLocomotionData.VelocityDirection;
				}
				return false;
			}
			return true;
		}
		return false;
	}

	[UFunction]
	[BlueprintPure]
	[Category("Transition Rule")]
	[UMeta(MDClass.BlueprintThreadSafe)]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopTransToBR")]
	private bool ShouldMoveLoopTransToBR()
	{
		if (AdvancedMonsterLocomotionData == null)
		{
			return false;
		}
		if (!AdvancedMonsterLocomotionData.bSwitchToLock)
		{
			return false;
		}
		if (!HasTransAnim(AdvancedMonsterLocomotionData.GaitGroundedState))
		{
			return false;
		}
		if (AdvancedMonsterLocomotionData.VelocityDirection == ELockMoveDirectionSix.BR)
		{
			if (!bStartToTrans)
			{
				if (CurrentLockTurnDir != ELockMoveDirectionSix.None)
				{
					return CurrentLockTurnDir != AdvancedMonsterLocomotionData.VelocityDirection;
				}
				return false;
			}
			return true;
		}
		return false;
	}

	[Category("Transition Rule")]
	[UMeta(MDClass.BlueprintThreadSafe)]
	[BlueprintPure]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopFLToBL")]
	private bool ShouldMoveLoopFLToBL()
	{
		if (AdvancedMonsterLocomotionData == null)
		{
			return false;
		}
		if (!AdvancedMonsterLocomotionData.bSwitchToLock)
		{
			return false;
		}
		if (!HasTransAnim(AdvancedMonsterLocomotionData.GaitGroundedState))
		{
			return false;
		}
		if (AdvancedMonsterLocomotionData.VelocityDirection == ELockMoveDirectionSix.BL)
		{
			return AdvancedMonsterLocomotionData.bSwitchToLock;
		}
		return false;
	}

	[UMeta(MDClass.BlueprintThreadSafe)]
	[UFunction]
	[Category("Transition Rule")]
	[BlueprintPure]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopBLToFL")]
	private bool ShouldMoveLoopBLToFL()
	{
		if (AdvancedMonsterLocomotionData == null)
		{
			return false;
		}
		if (!AdvancedMonsterLocomotionData.bSwitchToLock)
		{
			return false;
		}
		if (!HasTransAnim(AdvancedMonsterLocomotionData.GaitGroundedState))
		{
			return false;
		}
		if (AdvancedMonsterLocomotionData.VelocityDirection == ELockMoveDirectionSix.FL)
		{
			return AdvancedMonsterLocomotionData.bSwitchToLock;
		}
		return false;
	}

	[UMeta(MDClass.BlueprintThreadSafe)]
	[UFunction]
	[BlueprintPure]
	[Category("Transition Rule")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopFRToBR")]
	private bool ShouldMoveLoopFRToBR()
	{
		if (AdvancedMonsterLocomotionData == null)
		{
			return false;
		}
		if (!AdvancedMonsterLocomotionData.bSwitchToLock)
		{
			return false;
		}
		if (!HasTransAnim(AdvancedMonsterLocomotionData.GaitGroundedState))
		{
			return false;
		}
		if (AdvancedMonsterLocomotionData.VelocityDirection == ELockMoveDirectionSix.BR)
		{
			return AdvancedMonsterLocomotionData.bSwitchToLock;
		}
		return false;
	}

	[Category("Transition Rule")]
	[UMeta(MDClass.BlueprintThreadSafe)]
	[BlueprintPure]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopBRToFR")]
	private bool ShouldMoveLoopBRToFR()
	{
		if (AdvancedMonsterLocomotionData == null)
		{
			return false;
		}
		if (!AdvancedMonsterLocomotionData.bSwitchToLock)
		{
			return false;
		}
		if (!HasTransAnim(AdvancedMonsterLocomotionData.GaitGroundedState))
		{
			return false;
		}
		if (AdvancedMonsterLocomotionData.VelocityDirection == ELockMoveDirectionSix.FR)
		{
			return AdvancedMonsterLocomotionData.bSwitchToLock;
		}
		return false;
	}

	[BlueprintPure]
	[Category("Transition Rule")]
	[UFunction]
	[UMeta(MDClass.BlueprintThreadSafe)]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopLeftTransFL")]
	private bool ShouldMoveLoopLeftTransFL()
	{
		if (AdvancedMonsterLocomotionData == null)
		{
			return false;
		}
		if (!AdvancedMonsterLocomotionData.bSwitchToLock)
		{
			return false;
		}
		return AdvancedMonsterLocomotionData.VelocityDirection != ELockMoveDirectionSix.FL;
	}

	[Category("Transition Rule")]
	[UMeta(MDClass.BlueprintThreadSafe)]
	[BlueprintPure]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopLeftTransBL")]
	private bool ShouldMoveLoopLeftTransBL()
	{
		if (AdvancedMonsterLocomotionData == null)
		{
			return false;
		}
		if (!AdvancedMonsterLocomotionData.bSwitchToLock)
		{
			return false;
		}
		return AdvancedMonsterLocomotionData.VelocityDirection != ELockMoveDirectionSix.BL;
	}

	[UFunction]
	[Category("Transition Rule")]
	[UMeta(MDClass.BlueprintThreadSafe)]
	[BlueprintPure]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopLeftTransFR")]
	private bool ShouldMoveLoopLeftTransFR()
	{
		if (AdvancedMonsterLocomotionData == null)
		{
			return false;
		}
		if (!AdvancedMonsterLocomotionData.bSwitchToLock)
		{
			return false;
		}
		return AdvancedMonsterLocomotionData.VelocityDirection != ELockMoveDirectionSix.FR;
	}

	[UFunction]
	[BlueprintPure]
	[Category("Transition Rule")]
	[UMeta(MDClass.BlueprintThreadSafe)]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopLeftTransBR")]
	private bool ShouldMoveLoopLeftTransBR()
	{
		if (AdvancedMonsterLocomotionData == null)
		{
			return false;
		}
		if (!AdvancedMonsterLocomotionData.bSwitchToLock)
		{
			return false;
		}
		return AdvancedMonsterLocomotionData.VelocityDirection != ELockMoveDirectionSix.BR;
	}

	[UFunction]
	[UMeta(MDClass.BlueprintThreadSafe)]
	[Category("Transition Rule")]
	[BlueprintPure]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveTurnSwitchFree")]
	private bool ShouldMoveTurnSwitchFree()
	{
		bool flag = false;
		if (AdvancedMonsterLocomotionData != null)
		{
			flag = AdvancedMonsterLocomotionData.bSwitchToLock;
		}
		if (!flag)
		{
			return bChangeMoveSpeedInStartOrTurn;
		}
		return false;
	}

	[UMeta(MDClass.BlueprintThreadSafe)]
	[BlueprintPure]
	[UFunction]
	[Category("Transition Rule")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveTurnSwitchLock")]
	private bool ShouldMoveTurnSwitchLock()
	{
		bool flag = false;
		bool flag2 = false;
		float num = 0f;
		float num2 = 0f;
		if (AdvancedMonsterLocomotionData != null)
		{
			flag = AdvancedMonsterLocomotionData.bSwitchToLock;
			num = FMath.Abs(AdvancedMonsterLocomotionData.InputVelocityAngle);
			num2 = AdvancedMonsterLocomotionData.InputDeltaAngle;
		}
		if (ChrData != null)
		{
			flag2 = !ChrData.MoveAcceleration.IsNearlyZero();
		}
		bool flag3 = FMath.Abs(MathLib.NormalizedDeltaRotator(new FRotator(0.0, MoveTurnInputDeltaAngle, 0.0), new FRotator(0.0, num2, 0.0)).Yaw) > 90f && num > 135f;
		if (flag && flag2)
		{
			if (!flag3)
			{
				return bChangeMoveSpeedInStartOrTurn;
			}
			return true;
		}
		return false;
	}

	[UFunction]
	[BlueprintPure]
	[Category("Transition Rule")]
	[UMeta(MDClass.BlueprintThreadSafe)]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveTurnSwitchLockToFree")]
	private bool ShouldMoveTurnSwitchLockToFree()
	{
		bool flag = false;
		bool flag2 = false;
		FVector a = FVector.ZeroVector;
		FVector b = FVector.ZeroVector;
		if (AdvancedMonsterLocomotionData != null)
		{
			flag = AdvancedMonsterLocomotionData.bSwitchToLock;
			flag2 = AdvancedMonsterLocomotionData.bSwitchingLockState;
		}
		if (ChrData != null)
		{
			a = ChrData.ForwardVector.GetSafeNormal();
			b = ChrData.MoveAcceleration.GetSafeNormal();
		}
		if (!flag && flag2)
		{
			return FVector.DotProduct(a, b) < 0.5f;
		}
		return false;
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldToMove")]
	private static void ShouldToMove__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_AdvancedMonsterLocomotion bUAnimHumanoidCS_AdvancedMonsterLocomotion = GCHelper.Find<BUAnimHumanoidCS_AdvancedMonsterLocomotion>(obj);
		bool value = bUAnimHumanoidCS_AdvancedMonsterLocomotion.ShouldToMove();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, ShouldToMove_ReturnValue_Offset), 0, ShouldToMove_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:SetupIdleAnim")]
	private static void SetupIdleAnim__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_AdvancedMonsterLocomotion bUAnimHumanoidCS_AdvancedMonsterLocomotion = GCHelper.Find<BUAnimHumanoidCS_AdvancedMonsterLocomotion>(obj);
		FAnimUpdateContext Context = StructAsClassMarshaler<FAnimUpdateContext>.FromNative(IntPtr.Add(buffer, SetupIdleAnim_Context_Offset));
		FAnimNodeReference Node = StructAsClassMarshaler<FAnimNodeReference>.FromNative(IntPtr.Add(buffer, SetupIdleAnim_Node_Offset));
		bUAnimHumanoidCS_AdvancedMonsterLocomotion.SetupIdleAnim(ref Context, ref Node);
		StructAsClassMarshaler<FAnimUpdateContext>.ToNative(IntPtr.Add(buffer, SetupIdleAnim_Context_Offset), Context);
		StructAsClassMarshaler<FAnimNodeReference>.ToNative(IntPtr.Add(buffer, SetupIdleAnim_Node_Offset), Node);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:SetupIdleOutput")]
	private static void SetupIdleOutput__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_AdvancedMonsterLocomotion bUAnimHumanoidCS_AdvancedMonsterLocomotion = GCHelper.Find<BUAnimHumanoidCS_AdvancedMonsterLocomotion>(obj);
		FAnimUpdateContext Context = StructAsClassMarshaler<FAnimUpdateContext>.FromNative(IntPtr.Add(buffer, SetupIdleOutput_Context_Offset));
		FAnimNodeReference Node = StructAsClassMarshaler<FAnimNodeReference>.FromNative(IntPtr.Add(buffer, SetupIdleOutput_Node_Offset));
		bUAnimHumanoidCS_AdvancedMonsterLocomotion.SetupIdleOutput(ref Context, ref Node);
		StructAsClassMarshaler<FAnimUpdateContext>.ToNative(IntPtr.Add(buffer, SetupIdleOutput_Context_Offset), Context);
		StructAsClassMarshaler<FAnimNodeReference>.ToNative(IntPtr.Add(buffer, SetupIdleOutput_Node_Offset), Node);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:SetupMoveLoopAnim")]
	private static void SetupMoveLoopAnim__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_AdvancedMonsterLocomotion bUAnimHumanoidCS_AdvancedMonsterLocomotion = GCHelper.Find<BUAnimHumanoidCS_AdvancedMonsterLocomotion>(obj);
		FAnimUpdateContext Context = StructAsClassMarshaler<FAnimUpdateContext>.FromNative(IntPtr.Add(buffer, SetupMoveLoopAnim_Context_Offset));
		FAnimNodeReference Node = StructAsClassMarshaler<FAnimNodeReference>.FromNative(IntPtr.Add(buffer, SetupMoveLoopAnim_Node_Offset));
		bUAnimHumanoidCS_AdvancedMonsterLocomotion.SetupMoveLoopAnim(ref Context, ref Node);
		StructAsClassMarshaler<FAnimUpdateContext>.ToNative(IntPtr.Add(buffer, SetupMoveLoopAnim_Context_Offset), Context);
		StructAsClassMarshaler<FAnimNodeReference>.ToNative(IntPtr.Add(buffer, SetupMoveLoopAnim_Node_Offset), Node);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:SetupMoveStopAnim")]
	private static void SetupMoveStopAnim__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_AdvancedMonsterLocomotion bUAnimHumanoidCS_AdvancedMonsterLocomotion = GCHelper.Find<BUAnimHumanoidCS_AdvancedMonsterLocomotion>(obj);
		FAnimUpdateContext Context = StructAsClassMarshaler<FAnimUpdateContext>.FromNative(IntPtr.Add(buffer, SetupMoveStopAnim_Context_Offset));
		FAnimNodeReference Node = StructAsClassMarshaler<FAnimNodeReference>.FromNative(IntPtr.Add(buffer, SetupMoveStopAnim_Node_Offset));
		bUAnimHumanoidCS_AdvancedMonsterLocomotion.SetupMoveStopAnim(ref Context, ref Node);
		StructAsClassMarshaler<FAnimUpdateContext>.ToNative(IntPtr.Add(buffer, SetupMoveStopAnim_Context_Offset), Context);
		StructAsClassMarshaler<FAnimNodeReference>.ToNative(IntPtr.Add(buffer, SetupMoveStopAnim_Node_Offset), Node);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:SetupMoveTurnAnim")]
	private static void SetupMoveTurnAnim__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_AdvancedMonsterLocomotion bUAnimHumanoidCS_AdvancedMonsterLocomotion = GCHelper.Find<BUAnimHumanoidCS_AdvancedMonsterLocomotion>(obj);
		FAnimUpdateContext Context = StructAsClassMarshaler<FAnimUpdateContext>.FromNative(IntPtr.Add(buffer, SetupMoveTurnAnim_Context_Offset));
		FAnimNodeReference Node = StructAsClassMarshaler<FAnimNodeReference>.FromNative(IntPtr.Add(buffer, SetupMoveTurnAnim_Node_Offset));
		bUAnimHumanoidCS_AdvancedMonsterLocomotion.SetupMoveTurnAnim(ref Context, ref Node);
		StructAsClassMarshaler<FAnimUpdateContext>.ToNative(IntPtr.Add(buffer, SetupMoveTurnAnim_Context_Offset), Context);
		StructAsClassMarshaler<FAnimNodeReference>.ToNative(IntPtr.Add(buffer, SetupMoveTurnAnim_Node_Offset), Node);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopToBR")]
	private static void ShouldMoveLoopToBR__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_AdvancedMonsterLocomotion bUAnimHumanoidCS_AdvancedMonsterLocomotion = GCHelper.Find<BUAnimHumanoidCS_AdvancedMonsterLocomotion>(obj);
		bool value = bUAnimHumanoidCS_AdvancedMonsterLocomotion.ShouldMoveLoopToBR();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, ShouldMoveLoopToBR_ReturnValue_Offset), 0, ShouldMoveLoopToBR_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopToBL")]
	private static void ShouldMoveLoopToBL__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_AdvancedMonsterLocomotion bUAnimHumanoidCS_AdvancedMonsterLocomotion = GCHelper.Find<BUAnimHumanoidCS_AdvancedMonsterLocomotion>(obj);
		bool value = bUAnimHumanoidCS_AdvancedMonsterLocomotion.ShouldMoveLoopToBL();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, ShouldMoveLoopToBL_ReturnValue_Offset), 0, ShouldMoveLoopToBL_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopToFR")]
	private static void ShouldMoveLoopToFR__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_AdvancedMonsterLocomotion bUAnimHumanoidCS_AdvancedMonsterLocomotion = GCHelper.Find<BUAnimHumanoidCS_AdvancedMonsterLocomotion>(obj);
		bool value = bUAnimHumanoidCS_AdvancedMonsterLocomotion.ShouldMoveLoopToFR();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, ShouldMoveLoopToFR_ReturnValue_Offset), 0, ShouldMoveLoopToFR_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopToFL")]
	private static void ShouldMoveLoopToFL__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_AdvancedMonsterLocomotion bUAnimHumanoidCS_AdvancedMonsterLocomotion = GCHelper.Find<BUAnimHumanoidCS_AdvancedMonsterLocomotion>(obj);
		bool value = bUAnimHumanoidCS_AdvancedMonsterLocomotion.ShouldMoveLoopToFL();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, ShouldMoveLoopToFL_ReturnValue_Offset), 0, ShouldMoveLoopToFL_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:SetupMoveStartAnim")]
	private static void SetupMoveStartAnim__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_AdvancedMonsterLocomotion bUAnimHumanoidCS_AdvancedMonsterLocomotion = GCHelper.Find<BUAnimHumanoidCS_AdvancedMonsterLocomotion>(obj);
		FAnimUpdateContext Context = StructAsClassMarshaler<FAnimUpdateContext>.FromNative(IntPtr.Add(buffer, SetupMoveStartAnim_Context_Offset));
		FAnimNodeReference Node = StructAsClassMarshaler<FAnimNodeReference>.FromNative(IntPtr.Add(buffer, SetupMoveStartAnim_Node_Offset));
		bUAnimHumanoidCS_AdvancedMonsterLocomotion.SetupMoveStartAnim(ref Context, ref Node);
		StructAsClassMarshaler<FAnimUpdateContext>.ToNative(IntPtr.Add(buffer, SetupMoveStartAnim_Context_Offset), Context);
		StructAsClassMarshaler<FAnimNodeReference>.ToNative(IntPtr.Add(buffer, SetupMoveStartAnim_Node_Offset), Node);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:UpdateMoveStopAnim")]
	private static void UpdateMoveStopAnim__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_AdvancedMonsterLocomotion bUAnimHumanoidCS_AdvancedMonsterLocomotion = GCHelper.Find<BUAnimHumanoidCS_AdvancedMonsterLocomotion>(obj);
		FAnimUpdateContext Context = StructAsClassMarshaler<FAnimUpdateContext>.FromNative(IntPtr.Add(buffer, UpdateMoveStopAnim_Context_Offset));
		FAnimNodeReference Node = StructAsClassMarshaler<FAnimNodeReference>.FromNative(IntPtr.Add(buffer, UpdateMoveStopAnim_Node_Offset));
		bUAnimHumanoidCS_AdvancedMonsterLocomotion.UpdateMoveStopAnim(ref Context, ref Node);
		StructAsClassMarshaler<FAnimUpdateContext>.ToNative(IntPtr.Add(buffer, UpdateMoveStopAnim_Context_Offset), Context);
		StructAsClassMarshaler<FAnimNodeReference>.ToNative(IntPtr.Add(buffer, UpdateMoveStopAnim_Node_Offset), Node);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:UpdateMoveTurnAnim")]
	private static void UpdateMoveTurnAnim__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_AdvancedMonsterLocomotion bUAnimHumanoidCS_AdvancedMonsterLocomotion = GCHelper.Find<BUAnimHumanoidCS_AdvancedMonsterLocomotion>(obj);
		FAnimUpdateContext Context = StructAsClassMarshaler<FAnimUpdateContext>.FromNative(IntPtr.Add(buffer, UpdateMoveTurnAnim_Context_Offset));
		FAnimNodeReference Node = StructAsClassMarshaler<FAnimNodeReference>.FromNative(IntPtr.Add(buffer, UpdateMoveTurnAnim_Node_Offset));
		bUAnimHumanoidCS_AdvancedMonsterLocomotion.UpdateMoveTurnAnim(ref Context, ref Node);
		StructAsClassMarshaler<FAnimUpdateContext>.ToNative(IntPtr.Add(buffer, UpdateMoveTurnAnim_Context_Offset), Context);
		StructAsClassMarshaler<FAnimNodeReference>.ToNative(IntPtr.Add(buffer, UpdateMoveTurnAnim_Node_Offset), Node);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:SetupMoveTurnOutput")]
	private static void SetupMoveTurnOutput__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_AdvancedMonsterLocomotion bUAnimHumanoidCS_AdvancedMonsterLocomotion = GCHelper.Find<BUAnimHumanoidCS_AdvancedMonsterLocomotion>(obj);
		FAnimUpdateContext Context = StructAsClassMarshaler<FAnimUpdateContext>.FromNative(IntPtr.Add(buffer, SetupMoveTurnOutput_Context_Offset));
		FAnimNodeReference Node = StructAsClassMarshaler<FAnimNodeReference>.FromNative(IntPtr.Add(buffer, SetupMoveTurnOutput_Node_Offset));
		bUAnimHumanoidCS_AdvancedMonsterLocomotion.SetupMoveTurnOutput(ref Context, ref Node);
		StructAsClassMarshaler<FAnimUpdateContext>.ToNative(IntPtr.Add(buffer, SetupMoveTurnOutput_Context_Offset), Context);
		StructAsClassMarshaler<FAnimNodeReference>.ToNative(IntPtr.Add(buffer, SetupMoveTurnOutput_Node_Offset), Node);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:SetupMoveStopOutput")]
	private static void SetupMoveStopOutput__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_AdvancedMonsterLocomotion bUAnimHumanoidCS_AdvancedMonsterLocomotion = GCHelper.Find<BUAnimHumanoidCS_AdvancedMonsterLocomotion>(obj);
		FAnimUpdateContext Context = StructAsClassMarshaler<FAnimUpdateContext>.FromNative(IntPtr.Add(buffer, SetupMoveStopOutput_Context_Offset));
		FAnimNodeReference Node = StructAsClassMarshaler<FAnimNodeReference>.FromNative(IntPtr.Add(buffer, SetupMoveStopOutput_Node_Offset));
		bUAnimHumanoidCS_AdvancedMonsterLocomotion.SetupMoveStopOutput(ref Context, ref Node);
		StructAsClassMarshaler<FAnimUpdateContext>.ToNative(IntPtr.Add(buffer, SetupMoveStopOutput_Context_Offset), Context);
		StructAsClassMarshaler<FAnimNodeReference>.ToNative(IntPtr.Add(buffer, SetupMoveStopOutput_Node_Offset), Node);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:UpdateMoveStartAnim")]
	private static void UpdateMoveStartAnim__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_AdvancedMonsterLocomotion bUAnimHumanoidCS_AdvancedMonsterLocomotion = GCHelper.Find<BUAnimHumanoidCS_AdvancedMonsterLocomotion>(obj);
		FAnimUpdateContext Context = StructAsClassMarshaler<FAnimUpdateContext>.FromNative(IntPtr.Add(buffer, UpdateMoveStartAnim_Context_Offset));
		FAnimNodeReference Node = StructAsClassMarshaler<FAnimNodeReference>.FromNative(IntPtr.Add(buffer, UpdateMoveStartAnim_Node_Offset));
		bUAnimHumanoidCS_AdvancedMonsterLocomotion.UpdateMoveStartAnim(ref Context, ref Node);
		StructAsClassMarshaler<FAnimUpdateContext>.ToNative(IntPtr.Add(buffer, UpdateMoveStartAnim_Context_Offset), Context);
		StructAsClassMarshaler<FAnimNodeReference>.ToNative(IntPtr.Add(buffer, UpdateMoveStartAnim_Node_Offset), Node);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:SetupMoveLoopOutput")]
	private static void SetupMoveLoopOutput__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_AdvancedMonsterLocomotion bUAnimHumanoidCS_AdvancedMonsterLocomotion = GCHelper.Find<BUAnimHumanoidCS_AdvancedMonsterLocomotion>(obj);
		FAnimUpdateContext Context = StructAsClassMarshaler<FAnimUpdateContext>.FromNative(IntPtr.Add(buffer, SetupMoveLoopOutput_Context_Offset));
		FAnimNodeReference Node = StructAsClassMarshaler<FAnimNodeReference>.FromNative(IntPtr.Add(buffer, SetupMoveLoopOutput_Node_Offset));
		bUAnimHumanoidCS_AdvancedMonsterLocomotion.SetupMoveLoopOutput(ref Context, ref Node);
		StructAsClassMarshaler<FAnimUpdateContext>.ToNative(IntPtr.Add(buffer, SetupMoveLoopOutput_Context_Offset), Context);
		StructAsClassMarshaler<FAnimNodeReference>.ToNative(IntPtr.Add(buffer, SetupMoveLoopOutput_Node_Offset), Node);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopToFwd")]
	private static void ShouldMoveLoopToFwd__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_AdvancedMonsterLocomotion bUAnimHumanoidCS_AdvancedMonsterLocomotion = GCHelper.Find<BUAnimHumanoidCS_AdvancedMonsterLocomotion>(obj);
		bool value = bUAnimHumanoidCS_AdvancedMonsterLocomotion.ShouldMoveLoopToFwd();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, ShouldMoveLoopToFwd_ReturnValue_Offset), 0, ShouldMoveLoopToFwd_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopToBwd")]
	private static void ShouldMoveLoopToBwd__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_AdvancedMonsterLocomotion bUAnimHumanoidCS_AdvancedMonsterLocomotion = GCHelper.Find<BUAnimHumanoidCS_AdvancedMonsterLocomotion>(obj);
		bool value = bUAnimHumanoidCS_AdvancedMonsterLocomotion.ShouldMoveLoopToBwd();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, ShouldMoveLoopToBwd_ReturnValue_Offset), 0, ShouldMoveLoopToBwd_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopBRToFR")]
	private static void ShouldMoveLoopBRToFR__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_AdvancedMonsterLocomotion bUAnimHumanoidCS_AdvancedMonsterLocomotion = GCHelper.Find<BUAnimHumanoidCS_AdvancedMonsterLocomotion>(obj);
		bool value = bUAnimHumanoidCS_AdvancedMonsterLocomotion.ShouldMoveLoopBRToFR();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, ShouldMoveLoopBRToFR_ReturnValue_Offset), 0, ShouldMoveLoopBRToFR_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopFRToBR")]
	private static void ShouldMoveLoopFRToBR__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_AdvancedMonsterLocomotion bUAnimHumanoidCS_AdvancedMonsterLocomotion = GCHelper.Find<BUAnimHumanoidCS_AdvancedMonsterLocomotion>(obj);
		bool value = bUAnimHumanoidCS_AdvancedMonsterLocomotion.ShouldMoveLoopFRToBR();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, ShouldMoveLoopFRToBR_ReturnValue_Offset), 0, ShouldMoveLoopFRToBR_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopFLToBL")]
	private static void ShouldMoveLoopFLToBL__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_AdvancedMonsterLocomotion bUAnimHumanoidCS_AdvancedMonsterLocomotion = GCHelper.Find<BUAnimHumanoidCS_AdvancedMonsterLocomotion>(obj);
		bool value = bUAnimHumanoidCS_AdvancedMonsterLocomotion.ShouldMoveLoopFLToBL();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, ShouldMoveLoopFLToBL_ReturnValue_Offset), 0, ShouldMoveLoopFLToBL_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopLeftBR")]
	private static void ShouldMoveLoopLeftBR__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_AdvancedMonsterLocomotion bUAnimHumanoidCS_AdvancedMonsterLocomotion = GCHelper.Find<BUAnimHumanoidCS_AdvancedMonsterLocomotion>(obj);
		bool value = bUAnimHumanoidCS_AdvancedMonsterLocomotion.ShouldMoveLoopLeftBR();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, ShouldMoveLoopLeftBR_ReturnValue_Offset), 0, ShouldMoveLoopLeftBR_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:UpdateMoveTurnOutput")]
	private static void UpdateMoveTurnOutput__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_AdvancedMonsterLocomotion bUAnimHumanoidCS_AdvancedMonsterLocomotion = GCHelper.Find<BUAnimHumanoidCS_AdvancedMonsterLocomotion>(obj);
		FAnimUpdateContext Context = StructAsClassMarshaler<FAnimUpdateContext>.FromNative(IntPtr.Add(buffer, UpdateMoveTurnOutput_Context_Offset));
		FAnimNodeReference Node = StructAsClassMarshaler<FAnimNodeReference>.FromNative(IntPtr.Add(buffer, UpdateMoveTurnOutput_Node_Offset));
		bUAnimHumanoidCS_AdvancedMonsterLocomotion.UpdateMoveTurnOutput(ref Context, ref Node);
		StructAsClassMarshaler<FAnimUpdateContext>.ToNative(IntPtr.Add(buffer, UpdateMoveTurnOutput_Context_Offset), Context);
		StructAsClassMarshaler<FAnimNodeReference>.ToNative(IntPtr.Add(buffer, UpdateMoveTurnOutput_Node_Offset), Node);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopLeftFR")]
	private static void ShouldMoveLoopLeftFR__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_AdvancedMonsterLocomotion bUAnimHumanoidCS_AdvancedMonsterLocomotion = GCHelper.Find<BUAnimHumanoidCS_AdvancedMonsterLocomotion>(obj);
		bool value = bUAnimHumanoidCS_AdvancedMonsterLocomotion.ShouldMoveLoopLeftFR();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, ShouldMoveLoopLeftFR_ReturnValue_Offset), 0, ShouldMoveLoopLeftFR_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopLeftFL")]
	private static void ShouldMoveLoopLeftFL__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_AdvancedMonsterLocomotion bUAnimHumanoidCS_AdvancedMonsterLocomotion = GCHelper.Find<BUAnimHumanoidCS_AdvancedMonsterLocomotion>(obj);
		bool value = bUAnimHumanoidCS_AdvancedMonsterLocomotion.ShouldMoveLoopLeftFL();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, ShouldMoveLoopLeftFL_ReturnValue_Offset), 0, ShouldMoveLoopLeftFL_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:UpdateMoveStopOutput")]
	private static void UpdateMoveStopOutput__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_AdvancedMonsterLocomotion bUAnimHumanoidCS_AdvancedMonsterLocomotion = GCHelper.Find<BUAnimHumanoidCS_AdvancedMonsterLocomotion>(obj);
		FAnimUpdateContext Context = StructAsClassMarshaler<FAnimUpdateContext>.FromNative(IntPtr.Add(buffer, UpdateMoveStopOutput_Context_Offset));
		FAnimNodeReference Node = StructAsClassMarshaler<FAnimNodeReference>.FromNative(IntPtr.Add(buffer, UpdateMoveStopOutput_Node_Offset));
		bUAnimHumanoidCS_AdvancedMonsterLocomotion.UpdateMoveStopOutput(ref Context, ref Node);
		StructAsClassMarshaler<FAnimUpdateContext>.ToNative(IntPtr.Add(buffer, UpdateMoveStopOutput_Context_Offset), Context);
		StructAsClassMarshaler<FAnimNodeReference>.ToNative(IntPtr.Add(buffer, UpdateMoveStopOutput_Node_Offset), Node);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:UpdateMoveLoopOutput")]
	private static void UpdateMoveLoopOutput__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_AdvancedMonsterLocomotion bUAnimHumanoidCS_AdvancedMonsterLocomotion = GCHelper.Find<BUAnimHumanoidCS_AdvancedMonsterLocomotion>(obj);
		FAnimUpdateContext Context = StructAsClassMarshaler<FAnimUpdateContext>.FromNative(IntPtr.Add(buffer, UpdateMoveLoopOutput_Context_Offset));
		FAnimNodeReference Node = StructAsClassMarshaler<FAnimNodeReference>.FromNative(IntPtr.Add(buffer, UpdateMoveLoopOutput_Node_Offset));
		bUAnimHumanoidCS_AdvancedMonsterLocomotion.UpdateMoveLoopOutput(ref Context, ref Node);
		StructAsClassMarshaler<FAnimUpdateContext>.ToNative(IntPtr.Add(buffer, UpdateMoveLoopOutput_Context_Offset), Context);
		StructAsClassMarshaler<FAnimNodeReference>.ToNative(IntPtr.Add(buffer, UpdateMoveLoopOutput_Node_Offset), Node);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:UpdateMoveLoopBRAnim")]
	private static void UpdateMoveLoopBRAnim__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_AdvancedMonsterLocomotion bUAnimHumanoidCS_AdvancedMonsterLocomotion = GCHelper.Find<BUAnimHumanoidCS_AdvancedMonsterLocomotion>(obj);
		FAnimUpdateContext Context = StructAsClassMarshaler<FAnimUpdateContext>.FromNative(IntPtr.Add(buffer, UpdateMoveLoopBRAnim_Context_Offset));
		FAnimNodeReference Node = StructAsClassMarshaler<FAnimNodeReference>.FromNative(IntPtr.Add(buffer, UpdateMoveLoopBRAnim_Node_Offset));
		bUAnimHumanoidCS_AdvancedMonsterLocomotion.UpdateMoveLoopBRAnim(ref Context, ref Node);
		StructAsClassMarshaler<FAnimUpdateContext>.ToNative(IntPtr.Add(buffer, UpdateMoveLoopBRAnim_Context_Offset), Context);
		StructAsClassMarshaler<FAnimNodeReference>.ToNative(IntPtr.Add(buffer, UpdateMoveLoopBRAnim_Node_Offset), Node);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:UpdateMoveLoopBLAnim")]
	private static void UpdateMoveLoopBLAnim__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_AdvancedMonsterLocomotion bUAnimHumanoidCS_AdvancedMonsterLocomotion = GCHelper.Find<BUAnimHumanoidCS_AdvancedMonsterLocomotion>(obj);
		FAnimUpdateContext Context = StructAsClassMarshaler<FAnimUpdateContext>.FromNative(IntPtr.Add(buffer, UpdateMoveLoopBLAnim_Context_Offset));
		FAnimNodeReference Node = StructAsClassMarshaler<FAnimNodeReference>.FromNative(IntPtr.Add(buffer, UpdateMoveLoopBLAnim_Node_Offset));
		bUAnimHumanoidCS_AdvancedMonsterLocomotion.UpdateMoveLoopBLAnim(ref Context, ref Node);
		StructAsClassMarshaler<FAnimUpdateContext>.ToNative(IntPtr.Add(buffer, UpdateMoveLoopBLAnim_Context_Offset), Context);
		StructAsClassMarshaler<FAnimNodeReference>.ToNative(IntPtr.Add(buffer, UpdateMoveLoopBLAnim_Node_Offset), Node);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:UpdateMoveLoopFRAnim")]
	private static void UpdateMoveLoopFRAnim__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_AdvancedMonsterLocomotion bUAnimHumanoidCS_AdvancedMonsterLocomotion = GCHelper.Find<BUAnimHumanoidCS_AdvancedMonsterLocomotion>(obj);
		FAnimUpdateContext Context = StructAsClassMarshaler<FAnimUpdateContext>.FromNative(IntPtr.Add(buffer, UpdateMoveLoopFRAnim_Context_Offset));
		FAnimNodeReference Node = StructAsClassMarshaler<FAnimNodeReference>.FromNative(IntPtr.Add(buffer, UpdateMoveLoopFRAnim_Node_Offset));
		bUAnimHumanoidCS_AdvancedMonsterLocomotion.UpdateMoveLoopFRAnim(ref Context, ref Node);
		StructAsClassMarshaler<FAnimUpdateContext>.ToNative(IntPtr.Add(buffer, UpdateMoveLoopFRAnim_Context_Offset), Context);
		StructAsClassMarshaler<FAnimNodeReference>.ToNative(IntPtr.Add(buffer, UpdateMoveLoopFRAnim_Node_Offset), Node);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:UpdateMoveLoopFLAnim")]
	private static void UpdateMoveLoopFLAnim__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_AdvancedMonsterLocomotion bUAnimHumanoidCS_AdvancedMonsterLocomotion = GCHelper.Find<BUAnimHumanoidCS_AdvancedMonsterLocomotion>(obj);
		FAnimUpdateContext Context = StructAsClassMarshaler<FAnimUpdateContext>.FromNative(IntPtr.Add(buffer, UpdateMoveLoopFLAnim_Context_Offset));
		FAnimNodeReference Node = StructAsClassMarshaler<FAnimNodeReference>.FromNative(IntPtr.Add(buffer, UpdateMoveLoopFLAnim_Node_Offset));
		bUAnimHumanoidCS_AdvancedMonsterLocomotion.UpdateMoveLoopFLAnim(ref Context, ref Node);
		StructAsClassMarshaler<FAnimUpdateContext>.ToNative(IntPtr.Add(buffer, UpdateMoveLoopFLAnim_Context_Offset), Context);
		StructAsClassMarshaler<FAnimNodeReference>.ToNative(IntPtr.Add(buffer, UpdateMoveLoopFLAnim_Node_Offset), Node);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:SetupMoveStartOutput")]
	private static void SetupMoveStartOutput__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_AdvancedMonsterLocomotion bUAnimHumanoidCS_AdvancedMonsterLocomotion = GCHelper.Find<BUAnimHumanoidCS_AdvancedMonsterLocomotion>(obj);
		FAnimUpdateContext Context = StructAsClassMarshaler<FAnimUpdateContext>.FromNative(IntPtr.Add(buffer, SetupMoveStartOutput_Context_Offset));
		FAnimNodeReference Node = StructAsClassMarshaler<FAnimNodeReference>.FromNative(IntPtr.Add(buffer, SetupMoveStartOutput_Node_Offset));
		bUAnimHumanoidCS_AdvancedMonsterLocomotion.SetupMoveStartOutput(ref Context, ref Node);
		StructAsClassMarshaler<FAnimUpdateContext>.ToNative(IntPtr.Add(buffer, SetupMoveStartOutput_Context_Offset), Context);
		StructAsClassMarshaler<FAnimNodeReference>.ToNative(IntPtr.Add(buffer, SetupMoveStartOutput_Node_Offset), Node);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopLeftBL")]
	private static void ShouldMoveLoopLeftBL__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_AdvancedMonsterLocomotion bUAnimHumanoidCS_AdvancedMonsterLocomotion = GCHelper.Find<BUAnimHumanoidCS_AdvancedMonsterLocomotion>(obj);
		bool value = bUAnimHumanoidCS_AdvancedMonsterLocomotion.ShouldMoveLoopLeftBL();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, ShouldMoveLoopLeftBL_ReturnValue_Offset), 0, ShouldMoveLoopLeftBL_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopBLToFL")]
	private static void ShouldMoveLoopBLToFL__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_AdvancedMonsterLocomotion bUAnimHumanoidCS_AdvancedMonsterLocomotion = GCHelper.Find<BUAnimHumanoidCS_AdvancedMonsterLocomotion>(obj);
		bool value = bUAnimHumanoidCS_AdvancedMonsterLocomotion.ShouldMoveLoopBLToFL();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, ShouldMoveLoopBLToFL_ReturnValue_Offset), 0, ShouldMoveLoopBLToFL_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopLeftBwd")]
	private static void ShouldMoveLoopLeftBwd__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_AdvancedMonsterLocomotion bUAnimHumanoidCS_AdvancedMonsterLocomotion = GCHelper.Find<BUAnimHumanoidCS_AdvancedMonsterLocomotion>(obj);
		bool value = bUAnimHumanoidCS_AdvancedMonsterLocomotion.ShouldMoveLoopLeftBwd();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, ShouldMoveLoopLeftBwd_ReturnValue_Offset), 0, ShouldMoveLoopLeftBwd_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopLeftFwd")]
	private static void ShouldMoveLoopLeftFwd__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_AdvancedMonsterLocomotion bUAnimHumanoidCS_AdvancedMonsterLocomotion = GCHelper.Find<BUAnimHumanoidCS_AdvancedMonsterLocomotion>(obj);
		bool value = bUAnimHumanoidCS_AdvancedMonsterLocomotion.ShouldMoveLoopLeftFwd();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, ShouldMoveLoopLeftFwd_ReturnValue_Offset), 0, ShouldMoveLoopLeftFwd_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:UpdateMoveLoopFwdAnim")]
	private static void UpdateMoveLoopFwdAnim__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_AdvancedMonsterLocomotion bUAnimHumanoidCS_AdvancedMonsterLocomotion = GCHelper.Find<BUAnimHumanoidCS_AdvancedMonsterLocomotion>(obj);
		FAnimUpdateContext Context = StructAsClassMarshaler<FAnimUpdateContext>.FromNative(IntPtr.Add(buffer, UpdateMoveLoopFwdAnim_Context_Offset));
		FAnimNodeReference Node = StructAsClassMarshaler<FAnimNodeReference>.FromNative(IntPtr.Add(buffer, UpdateMoveLoopFwdAnim_Node_Offset));
		bUAnimHumanoidCS_AdvancedMonsterLocomotion.UpdateMoveLoopFwdAnim(ref Context, ref Node);
		StructAsClassMarshaler<FAnimUpdateContext>.ToNative(IntPtr.Add(buffer, UpdateMoveLoopFwdAnim_Context_Offset), Context);
		StructAsClassMarshaler<FAnimNodeReference>.ToNative(IntPtr.Add(buffer, UpdateMoveLoopFwdAnim_Node_Offset), Node);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:UpdateMoveLoopBwdAnim")]
	private static void UpdateMoveLoopBwdAnim__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_AdvancedMonsterLocomotion bUAnimHumanoidCS_AdvancedMonsterLocomotion = GCHelper.Find<BUAnimHumanoidCS_AdvancedMonsterLocomotion>(obj);
		FAnimUpdateContext Context = StructAsClassMarshaler<FAnimUpdateContext>.FromNative(IntPtr.Add(buffer, UpdateMoveLoopBwdAnim_Context_Offset));
		FAnimNodeReference Node = StructAsClassMarshaler<FAnimNodeReference>.FromNative(IntPtr.Add(buffer, UpdateMoveLoopBwdAnim_Node_Offset));
		bUAnimHumanoidCS_AdvancedMonsterLocomotion.UpdateMoveLoopBwdAnim(ref Context, ref Node);
		StructAsClassMarshaler<FAnimUpdateContext>.ToNative(IntPtr.Add(buffer, UpdateMoveLoopBwdAnim_Context_Offset), Context);
		StructAsClassMarshaler<FAnimNodeReference>.ToNative(IntPtr.Add(buffer, UpdateMoveLoopBwdAnim_Node_Offset), Node);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopTransToFL")]
	private static void ShouldMoveLoopTransToFL__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_AdvancedMonsterLocomotion bUAnimHumanoidCS_AdvancedMonsterLocomotion = GCHelper.Find<BUAnimHumanoidCS_AdvancedMonsterLocomotion>(obj);
		bool value = bUAnimHumanoidCS_AdvancedMonsterLocomotion.ShouldMoveLoopTransToFL();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, ShouldMoveLoopTransToFL_ReturnValue_Offset), 0, ShouldMoveLoopTransToFL_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopTransToFR")]
	private static void ShouldMoveLoopTransToFR__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_AdvancedMonsterLocomotion bUAnimHumanoidCS_AdvancedMonsterLocomotion = GCHelper.Find<BUAnimHumanoidCS_AdvancedMonsterLocomotion>(obj);
		bool value = bUAnimHumanoidCS_AdvancedMonsterLocomotion.ShouldMoveLoopTransToFR();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, ShouldMoveLoopTransToFR_ReturnValue_Offset), 0, ShouldMoveLoopTransToFR_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopTransToBR")]
	private static void ShouldMoveLoopTransToBR__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_AdvancedMonsterLocomotion bUAnimHumanoidCS_AdvancedMonsterLocomotion = GCHelper.Find<BUAnimHumanoidCS_AdvancedMonsterLocomotion>(obj);
		bool value = bUAnimHumanoidCS_AdvancedMonsterLocomotion.ShouldMoveLoopTransToBR();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, ShouldMoveLoopTransToBR_ReturnValue_Offset), 0, ShouldMoveLoopTransToBR_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:UpdateMoveLoopTransAnim")]
	private static void UpdateMoveLoopTransAnim__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_AdvancedMonsterLocomotion bUAnimHumanoidCS_AdvancedMonsterLocomotion = GCHelper.Find<BUAnimHumanoidCS_AdvancedMonsterLocomotion>(obj);
		FAnimUpdateContext Context = StructAsClassMarshaler<FAnimUpdateContext>.FromNative(IntPtr.Add(buffer, UpdateMoveLoopTransAnim_Context_Offset));
		FAnimNodeReference Node = StructAsClassMarshaler<FAnimNodeReference>.FromNative(IntPtr.Add(buffer, UpdateMoveLoopTransAnim_Node_Offset));
		bUAnimHumanoidCS_AdvancedMonsterLocomotion.UpdateMoveLoopTransAnim(ref Context, ref Node);
		StructAsClassMarshaler<FAnimUpdateContext>.ToNative(IntPtr.Add(buffer, UpdateMoveLoopTransAnim_Context_Offset), Context);
		StructAsClassMarshaler<FAnimNodeReference>.ToNative(IntPtr.Add(buffer, UpdateMoveLoopTransAnim_Node_Offset), Node);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopTransToBL")]
	private static void ShouldMoveLoopTransToBL__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_AdvancedMonsterLocomotion bUAnimHumanoidCS_AdvancedMonsterLocomotion = GCHelper.Find<BUAnimHumanoidCS_AdvancedMonsterLocomotion>(obj);
		bool value = bUAnimHumanoidCS_AdvancedMonsterLocomotion.ShouldMoveLoopTransToBL();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, ShouldMoveLoopTransToBL_ReturnValue_Offset), 0, ShouldMoveLoopTransToBL_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:UpdateMoveLoopSimpleAnim")]
	private static void UpdateMoveLoopSimpleAnim__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_AdvancedMonsterLocomotion bUAnimHumanoidCS_AdvancedMonsterLocomotion = GCHelper.Find<BUAnimHumanoidCS_AdvancedMonsterLocomotion>(obj);
		FAnimUpdateContext Context = StructAsClassMarshaler<FAnimUpdateContext>.FromNative(IntPtr.Add(buffer, UpdateMoveLoopSimpleAnim_Context_Offset));
		FAnimNodeReference Node = StructAsClassMarshaler<FAnimNodeReference>.FromNative(IntPtr.Add(buffer, UpdateMoveLoopSimpleAnim_Node_Offset));
		bUAnimHumanoidCS_AdvancedMonsterLocomotion.UpdateMoveLoopSimpleAnim(ref Context, ref Node);
		StructAsClassMarshaler<FAnimUpdateContext>.ToNative(IntPtr.Add(buffer, UpdateMoveLoopSimpleAnim_Context_Offset), Context);
		StructAsClassMarshaler<FAnimNodeReference>.ToNative(IntPtr.Add(buffer, UpdateMoveLoopSimpleAnim_Node_Offset), Node);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveTurnSwitchFree")]
	private static void ShouldMoveTurnSwitchFree__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_AdvancedMonsterLocomotion bUAnimHumanoidCS_AdvancedMonsterLocomotion = GCHelper.Find<BUAnimHumanoidCS_AdvancedMonsterLocomotion>(obj);
		bool value = bUAnimHumanoidCS_AdvancedMonsterLocomotion.ShouldMoveTurnSwitchFree();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, ShouldMoveTurnSwitchFree_ReturnValue_Offset), 0, ShouldMoveTurnSwitchFree_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveTurnSwitchLock")]
	private static void ShouldMoveTurnSwitchLock__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_AdvancedMonsterLocomotion bUAnimHumanoidCS_AdvancedMonsterLocomotion = GCHelper.Find<BUAnimHumanoidCS_AdvancedMonsterLocomotion>(obj);
		bool value = bUAnimHumanoidCS_AdvancedMonsterLocomotion.ShouldMoveTurnSwitchLock();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, ShouldMoveTurnSwitchLock_ReturnValue_Offset), 0, ShouldMoveTurnSwitchLock_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:SetupMoveLoopAdditiveAnim")]
	private static void SetupMoveLoopAdditiveAnim__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_AdvancedMonsterLocomotion bUAnimHumanoidCS_AdvancedMonsterLocomotion = GCHelper.Find<BUAnimHumanoidCS_AdvancedMonsterLocomotion>(obj);
		FAnimUpdateContext Context = StructAsClassMarshaler<FAnimUpdateContext>.FromNative(IntPtr.Add(buffer, SetupMoveLoopAdditiveAnim_Context_Offset));
		FAnimNodeReference Node = StructAsClassMarshaler<FAnimNodeReference>.FromNative(IntPtr.Add(buffer, SetupMoveLoopAdditiveAnim_Node_Offset));
		bUAnimHumanoidCS_AdvancedMonsterLocomotion.SetupMoveLoopAdditiveAnim(ref Context, ref Node);
		StructAsClassMarshaler<FAnimUpdateContext>.ToNative(IntPtr.Add(buffer, SetupMoveLoopAdditiveAnim_Context_Offset), Context);
		StructAsClassMarshaler<FAnimNodeReference>.ToNative(IntPtr.Add(buffer, SetupMoveLoopAdditiveAnim_Node_Offset), Node);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:UpdateMoveLoopLB2LFOutput")]
	private static void UpdateMoveLoopLB2LFOutput__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_AdvancedMonsterLocomotion bUAnimHumanoidCS_AdvancedMonsterLocomotion = GCHelper.Find<BUAnimHumanoidCS_AdvancedMonsterLocomotion>(obj);
		FAnimUpdateContext Context = StructAsClassMarshaler<FAnimUpdateContext>.FromNative(IntPtr.Add(buffer, UpdateMoveLoopLB2LFOutput_Context_Offset));
		FAnimNodeReference Node = StructAsClassMarshaler<FAnimNodeReference>.FromNative(IntPtr.Add(buffer, UpdateMoveLoopLB2LFOutput_Node_Offset));
		bUAnimHumanoidCS_AdvancedMonsterLocomotion.UpdateMoveLoopLB2LFOutput(ref Context, ref Node);
		StructAsClassMarshaler<FAnimUpdateContext>.ToNative(IntPtr.Add(buffer, UpdateMoveLoopLB2LFOutput_Context_Offset), Context);
		StructAsClassMarshaler<FAnimNodeReference>.ToNative(IntPtr.Add(buffer, UpdateMoveLoopLB2LFOutput_Node_Offset), Node);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:UpdateMoveLoopRB2RFOutput")]
	private static void UpdateMoveLoopRB2RFOutput__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_AdvancedMonsterLocomotion bUAnimHumanoidCS_AdvancedMonsterLocomotion = GCHelper.Find<BUAnimHumanoidCS_AdvancedMonsterLocomotion>(obj);
		FAnimUpdateContext Context = StructAsClassMarshaler<FAnimUpdateContext>.FromNative(IntPtr.Add(buffer, UpdateMoveLoopRB2RFOutput_Context_Offset));
		FAnimNodeReference Node = StructAsClassMarshaler<FAnimNodeReference>.FromNative(IntPtr.Add(buffer, UpdateMoveLoopRB2RFOutput_Node_Offset));
		bUAnimHumanoidCS_AdvancedMonsterLocomotion.UpdateMoveLoopRB2RFOutput(ref Context, ref Node);
		StructAsClassMarshaler<FAnimUpdateContext>.ToNative(IntPtr.Add(buffer, UpdateMoveLoopRB2RFOutput_Context_Offset), Context);
		StructAsClassMarshaler<FAnimNodeReference>.ToNative(IntPtr.Add(buffer, UpdateMoveLoopRB2RFOutput_Node_Offset), Node);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:UpdateMoveLoopRF2RBOutput")]
	private static void UpdateMoveLoopRF2RBOutput__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_AdvancedMonsterLocomotion bUAnimHumanoidCS_AdvancedMonsterLocomotion = GCHelper.Find<BUAnimHumanoidCS_AdvancedMonsterLocomotion>(obj);
		FAnimUpdateContext Context = StructAsClassMarshaler<FAnimUpdateContext>.FromNative(IntPtr.Add(buffer, UpdateMoveLoopRF2RBOutput_Context_Offset));
		FAnimNodeReference Node = StructAsClassMarshaler<FAnimNodeReference>.FromNative(IntPtr.Add(buffer, UpdateMoveLoopRF2RBOutput_Node_Offset));
		bUAnimHumanoidCS_AdvancedMonsterLocomotion.UpdateMoveLoopRF2RBOutput(ref Context, ref Node);
		StructAsClassMarshaler<FAnimUpdateContext>.ToNative(IntPtr.Add(buffer, UpdateMoveLoopRF2RBOutput_Context_Offset), Context);
		StructAsClassMarshaler<FAnimNodeReference>.ToNative(IntPtr.Add(buffer, UpdateMoveLoopRF2RBOutput_Node_Offset), Node);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:UpdateMoveLoopLF2LBOutput")]
	private static void UpdateMoveLoopLF2LBOutput__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_AdvancedMonsterLocomotion bUAnimHumanoidCS_AdvancedMonsterLocomotion = GCHelper.Find<BUAnimHumanoidCS_AdvancedMonsterLocomotion>(obj);
		FAnimUpdateContext Context = StructAsClassMarshaler<FAnimUpdateContext>.FromNative(IntPtr.Add(buffer, UpdateMoveLoopLF2LBOutput_Context_Offset));
		FAnimNodeReference Node = StructAsClassMarshaler<FAnimNodeReference>.FromNative(IntPtr.Add(buffer, UpdateMoveLoopLF2LBOutput_Node_Offset));
		bUAnimHumanoidCS_AdvancedMonsterLocomotion.UpdateMoveLoopLF2LBOutput(ref Context, ref Node);
		StructAsClassMarshaler<FAnimUpdateContext>.ToNative(IntPtr.Add(buffer, UpdateMoveLoopLF2LBOutput_Context_Offset), Context);
		StructAsClassMarshaler<FAnimNodeReference>.ToNative(IntPtr.Add(buffer, UpdateMoveLoopLF2LBOutput_Node_Offset), Node);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopLeftTransBR")]
	private static void ShouldMoveLoopLeftTransBR__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_AdvancedMonsterLocomotion bUAnimHumanoidCS_AdvancedMonsterLocomotion = GCHelper.Find<BUAnimHumanoidCS_AdvancedMonsterLocomotion>(obj);
		bool value = bUAnimHumanoidCS_AdvancedMonsterLocomotion.ShouldMoveLoopLeftTransBR();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, ShouldMoveLoopLeftTransBR_ReturnValue_Offset), 0, ShouldMoveLoopLeftTransBR_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopLeftTransFL")]
	private static void ShouldMoveLoopLeftTransFL__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_AdvancedMonsterLocomotion bUAnimHumanoidCS_AdvancedMonsterLocomotion = GCHelper.Find<BUAnimHumanoidCS_AdvancedMonsterLocomotion>(obj);
		bool value = bUAnimHumanoidCS_AdvancedMonsterLocomotion.ShouldMoveLoopLeftTransFL();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, ShouldMoveLoopLeftTransFL_ReturnValue_Offset), 0, ShouldMoveLoopLeftTransFL_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopLeftTransBL")]
	private static void ShouldMoveLoopLeftTransBL__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_AdvancedMonsterLocomotion bUAnimHumanoidCS_AdvancedMonsterLocomotion = GCHelper.Find<BUAnimHumanoidCS_AdvancedMonsterLocomotion>(obj);
		bool value = bUAnimHumanoidCS_AdvancedMonsterLocomotion.ShouldMoveLoopLeftTransBL();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, ShouldMoveLoopLeftTransBL_ReturnValue_Offset), 0, ShouldMoveLoopLeftTransBL_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopLeftTransFR")]
	private static void ShouldMoveLoopLeftTransFR__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_AdvancedMonsterLocomotion bUAnimHumanoidCS_AdvancedMonsterLocomotion = GCHelper.Find<BUAnimHumanoidCS_AdvancedMonsterLocomotion>(obj);
		bool value = bUAnimHumanoidCS_AdvancedMonsterLocomotion.ShouldMoveLoopLeftTransFR();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, ShouldMoveLoopLeftTransFR_ReturnValue_Offset), 0, ShouldMoveLoopLeftTransFR_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:UpdateMoveLoopStateMachine")]
	private static void UpdateMoveLoopStateMachine__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_AdvancedMonsterLocomotion bUAnimHumanoidCS_AdvancedMonsterLocomotion = GCHelper.Find<BUAnimHumanoidCS_AdvancedMonsterLocomotion>(obj);
		FAnimUpdateContext Context = StructAsClassMarshaler<FAnimUpdateContext>.FromNative(IntPtr.Add(buffer, UpdateMoveLoopStateMachine_Context_Offset));
		FAnimNodeReference Node = StructAsClassMarshaler<FAnimNodeReference>.FromNative(IntPtr.Add(buffer, UpdateMoveLoopStateMachine_Node_Offset));
		bUAnimHumanoidCS_AdvancedMonsterLocomotion.UpdateMoveLoopStateMachine(ref Context, ref Node);
		StructAsClassMarshaler<FAnimUpdateContext>.ToNative(IntPtr.Add(buffer, UpdateMoveLoopStateMachine_Context_Offset), Context);
		StructAsClassMarshaler<FAnimNodeReference>.ToNative(IntPtr.Add(buffer, UpdateMoveLoopStateMachine_Node_Offset), Node);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveTurnSwitchLockToFree")]
	private static void ShouldMoveTurnSwitchLockToFree__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_AdvancedMonsterLocomotion bUAnimHumanoidCS_AdvancedMonsterLocomotion = GCHelper.Find<BUAnimHumanoidCS_AdvancedMonsterLocomotion>(obj);
		bool value = bUAnimHumanoidCS_AdvancedMonsterLocomotion.ShouldMoveTurnSwitchLockToFree();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, ShouldMoveTurnSwitchLockToFree_ReturnValue_Offset), 0, ShouldMoveTurnSwitchLockToFree_ReturnValue_PropertyAddress.Address, value);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion");
		NativeReflection.GetPropertyRef(ref FreeMode_PropertyAddress, intPtr, "FreeMode");
		FreeMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "FreeMode");
		FreeMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FreeMode", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref LockMode_PropertyAddress, intPtr, "LockMode");
		LockMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "LockMode");
		LockMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LockMode", Classes.FEnumProperty);
		StartAngle_Offset = NativeReflection.GetPropertyOffset(intPtr, "StartAngle");
		StartAngle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StartAngle", Classes.FFloatProperty);
		StrideWarpingStartAlpha_Offset = NativeReflection.GetPropertyOffset(intPtr, "StrideWarpingStartAlpha");
		StrideWarpingStartAlpha_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StrideWarpingStartAlpha", Classes.FFloatProperty);
		StrideWarpingLoopAlpha_Offset = NativeReflection.GetPropertyOffset(intPtr, "StrideWarpingLoopAlpha");
		StrideWarpingLoopAlpha_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StrideWarpingLoopAlpha", Classes.FFloatProperty);
		StrideWarpingTurnAlpha_Offset = NativeReflection.GetPropertyOffset(intPtr, "StrideWarpingTurnAlpha");
		StrideWarpingTurnAlpha_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StrideWarpingTurnAlpha", Classes.FFloatProperty);
		MoveLoopSpine01AngleOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "MoveLoopSpine01AngleOffset");
		MoveLoopSpine01AngleOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MoveLoopSpine01AngleOffset", Classes.FFloatProperty);
		MoveLoopSpine02AngleOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "MoveLoopSpine02AngleOffset");
		MoveLoopSpine02AngleOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MoveLoopSpine02AngleOffset", Classes.FFloatProperty);
		MoveLoopSpine03AngleOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "MoveLoopSpine03AngleOffset");
		MoveLoopSpine03AngleOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MoveLoopSpine03AngleOffset", Classes.FFloatProperty);
		MoveLoopHeadAngleOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "MoveLoopHeadAngleOffset");
		MoveLoopHeadAngleOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MoveLoopHeadAngleOffset", Classes.FFloatProperty);
		MoveLoopPelvisLocalOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "MoveLoopPelvisLocalOffset");
		MoveLoopPelvisLocalOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MoveLoopPelvisLocalOffset", Classes.FFloatProperty);
		MoveLoopPelvisAngleOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "MoveLoopPelvisAngleOffset");
		MoveLoopPelvisAngleOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MoveLoopPelvisAngleOffset", Classes.FFloatProperty);
		ASWalkStartFwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASWalkStartFwd");
		ASWalkStartFwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASWalkStartFwd", Classes.FObjectProperty);
		ASWalkStartBwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASWalkStartBwd");
		ASWalkStartBwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASWalkStartBwd", Classes.FObjectProperty);
		ASWalkStartLeftMin_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASWalkStartLeftMin");
		ASWalkStartLeftMin_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASWalkStartLeftMin", Classes.FObjectProperty);
		ASWalkStartLeftMax_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASWalkStartLeftMax");
		ASWalkStartLeftMax_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASWalkStartLeftMax", Classes.FObjectProperty);
		ASWalkStartRightMin_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASWalkStartRightMin");
		ASWalkStartRightMin_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASWalkStartRightMin", Classes.FObjectProperty);
		ASWalkStartRightMax_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASWalkStartRightMax");
		ASWalkStartRightMax_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASWalkStartRightMax", Classes.FObjectProperty);
		ASWalkStartLF_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASWalkStartLF");
		ASWalkStartLF_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASWalkStartLF", Classes.FObjectProperty);
		ASWalkStartLB_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASWalkStartLB");
		ASWalkStartLB_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASWalkStartLB", Classes.FObjectProperty);
		ASWalkStartRF_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASWalkStartRF");
		ASWalkStartRF_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASWalkStartRF", Classes.FObjectProperty);
		ASWalkStartRB_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASWalkStartRB");
		ASWalkStartRB_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASWalkStartRB", Classes.FObjectProperty);
		ASWalkLoopFwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASWalkLoopFwd");
		ASWalkLoopFwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASWalkLoopFwd", Classes.FObjectProperty);
		ASWalkLoopBwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASWalkLoopBwd");
		ASWalkLoopBwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASWalkLoopBwd", Classes.FObjectProperty);
		ASWalkLoopLF_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASWalkLoopLF");
		ASWalkLoopLF_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASWalkLoopLF", Classes.FObjectProperty);
		ASWalkLoopLB_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASWalkLoopLB");
		ASWalkLoopLB_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASWalkLoopLB", Classes.FObjectProperty);
		ASWalkLoopRF_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASWalkLoopRF");
		ASWalkLoopRF_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASWalkLoopRF", Classes.FObjectProperty);
		ASWalkLoopRB_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASWalkLoopRB");
		ASWalkLoopRB_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASWalkLoopRB", Classes.FObjectProperty);
		ASWalkSharpturnLeftMin_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASWalkSharpturnLeftMin");
		ASWalkSharpturnLeftMin_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASWalkSharpturnLeftMin", Classes.FObjectProperty);
		ASWalkSharpturnLeftMax_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASWalkSharpturnLeftMax");
		ASWalkSharpturnLeftMax_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASWalkSharpturnLeftMax", Classes.FObjectProperty);
		ASWalkSharpturnRightMin_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASWalkSharpturnRightMin");
		ASWalkSharpturnRightMin_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASWalkSharpturnRightMin", Classes.FObjectProperty);
		ASWalkSharpturnRightMax_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASWalkSharpturnRightMax");
		ASWalkSharpturnRightMax_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASWalkSharpturnRightMax", Classes.FObjectProperty);
		ASWalkPivotFwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASWalkPivotFwd");
		ASWalkPivotFwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASWalkPivotFwd", Classes.FObjectProperty);
		ASWalkPivotBwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASWalkPivotBwd");
		ASWalkPivotBwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASWalkPivotBwd", Classes.FObjectProperty);
		ASWalkPivotLF_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASWalkPivotLF");
		ASWalkPivotLF_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASWalkPivotLF", Classes.FObjectProperty);
		ASWalkPivotLB_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASWalkPivotLB");
		ASWalkPivotLB_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASWalkPivotLB", Classes.FObjectProperty);
		ASWalkPivotRF_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASWalkPivotRF");
		ASWalkPivotRF_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASWalkPivotRF", Classes.FObjectProperty);
		ASWalkPivotRB_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASWalkPivotRB");
		ASWalkPivotRB_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASWalkPivotRB", Classes.FObjectProperty);
		ASWalkTransFRToBR_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASWalkTransFRToBR");
		ASWalkTransFRToBR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASWalkTransFRToBR", Classes.FObjectProperty);
		ASWalkTransBRToFR_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASWalkTransBRToFR");
		ASWalkTransBRToFR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASWalkTransBRToFR", Classes.FObjectProperty);
		ASWalkTransFLToBL_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASWalkTransFLToBL");
		ASWalkTransFLToBL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASWalkTransFLToBL", Classes.FObjectProperty);
		ASWalkTransBLToFL_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASWalkTransBLToFL");
		ASWalkTransBLToFL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASWalkTransBLToFL", Classes.FObjectProperty);
		ASWalkStopFwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASWalkStopFwd");
		ASWalkStopFwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASWalkStopFwd", Classes.FObjectProperty);
		ASWalkStopBwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASWalkStopBwd");
		ASWalkStopBwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASWalkStopBwd", Classes.FObjectProperty);
		ASWalkStopLF_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASWalkStopLF");
		ASWalkStopLF_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASWalkStopLF", Classes.FObjectProperty);
		ASWalkStopLB_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASWalkStopLB");
		ASWalkStopLB_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASWalkStopLB", Classes.FObjectProperty);
		ASWalkStopRF_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASWalkStopRF");
		ASWalkStopRF_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASWalkStopRF", Classes.FObjectProperty);
		ASWalkStopRB_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASWalkStopRB");
		ASWalkStopRB_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASWalkStopRB", Classes.FObjectProperty);
		ASWalkLoopAddPose_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASWalkLoopAddPose");
		ASWalkLoopAddPose_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASWalkLoopAddPose", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref ASWalkLoopAdditiveList_PropertyAddress, intPtr, "ASWalkLoopAdditiveList");
		ASWalkLoopAdditiveList_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASWalkLoopAdditiveList");
		ASWalkLoopAdditiveList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASWalkLoopAdditiveList", Classes.FArrayProperty);
		ASRunStartFwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunStartFwd");
		ASRunStartFwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunStartFwd", Classes.FObjectProperty);
		ASRunStartBwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunStartBwd");
		ASRunStartBwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunStartBwd", Classes.FObjectProperty);
		ASRunStartLeftMin_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunStartLeftMin");
		ASRunStartLeftMin_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunStartLeftMin", Classes.FObjectProperty);
		ASRunStartLeftMax_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunStartLeftMax");
		ASRunStartLeftMax_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunStartLeftMax", Classes.FObjectProperty);
		ASRunStartRightMin_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunStartRightMin");
		ASRunStartRightMin_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunStartRightMin", Classes.FObjectProperty);
		ASRunStartRightMax_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunStartRightMax");
		ASRunStartRightMax_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunStartRightMax", Classes.FObjectProperty);
		ASRunStartLF_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunStartLF");
		ASRunStartLF_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunStartLF", Classes.FObjectProperty);
		ASRunStartLB_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunStartLB");
		ASRunStartLB_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunStartLB", Classes.FObjectProperty);
		ASRunStartRF_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunStartRF");
		ASRunStartRF_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunStartRF", Classes.FObjectProperty);
		ASRunStartRB_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunStartRB");
		ASRunStartRB_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunStartRB", Classes.FObjectProperty);
		ASRunLoopFwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunLoopFwd");
		ASRunLoopFwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunLoopFwd", Classes.FObjectProperty);
		ASRunLoopBwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunLoopBwd");
		ASRunLoopBwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunLoopBwd", Classes.FObjectProperty);
		ASRunLoopLF_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunLoopLF");
		ASRunLoopLF_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunLoopLF", Classes.FObjectProperty);
		ASRunLoopLB_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunLoopLB");
		ASRunLoopLB_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunLoopLB", Classes.FObjectProperty);
		ASRunLoopRF_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunLoopRF");
		ASRunLoopRF_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunLoopRF", Classes.FObjectProperty);
		ASRunLoopRB_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunLoopRB");
		ASRunLoopRB_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunLoopRB", Classes.FObjectProperty);
		ASRunSharpturnLeftMin_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunSharpturnLeftMin");
		ASRunSharpturnLeftMin_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunSharpturnLeftMin", Classes.FObjectProperty);
		ASRunSharpturnLeftMax_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunSharpturnLeftMax");
		ASRunSharpturnLeftMax_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunSharpturnLeftMax", Classes.FObjectProperty);
		ASRunSharpturnRightMin_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunSharpturnRightMin");
		ASRunSharpturnRightMin_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunSharpturnRightMin", Classes.FObjectProperty);
		ASRunSharpturnRightMax_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunSharpturnRightMax");
		ASRunSharpturnRightMax_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunSharpturnRightMax", Classes.FObjectProperty);
		ASRunPivotFwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunPivotFwd");
		ASRunPivotFwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunPivotFwd", Classes.FObjectProperty);
		ASRunPivotBwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunPivotBwd");
		ASRunPivotBwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunPivotBwd", Classes.FObjectProperty);
		ASRunPivotLF_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunPivotLF");
		ASRunPivotLF_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunPivotLF", Classes.FObjectProperty);
		ASRunPivotLB_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunPivotLB");
		ASRunPivotLB_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunPivotLB", Classes.FObjectProperty);
		ASRunPivotRF_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunPivotRF");
		ASRunPivotRF_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunPivotRF", Classes.FObjectProperty);
		ASRunPivotRB_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunPivotRB");
		ASRunPivotRB_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunPivotRB", Classes.FObjectProperty);
		ASRunTransFRToBR_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunTransFRToBR");
		ASRunTransFRToBR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunTransFRToBR", Classes.FObjectProperty);
		ASRunTransBRToFR_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunTransBRToFR");
		ASRunTransBRToFR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunTransBRToFR", Classes.FObjectProperty);
		ASRunTransFLToBL_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunTransFLToBL");
		ASRunTransFLToBL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunTransFLToBL", Classes.FObjectProperty);
		ASRunTransBLToFL_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunTransBLToFL");
		ASRunTransBLToFL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunTransBLToFL", Classes.FObjectProperty);
		ASRunStopFwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunStopFwd");
		ASRunStopFwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunStopFwd", Classes.FObjectProperty);
		ASRunStopBwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunStopBwd");
		ASRunStopBwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunStopBwd", Classes.FObjectProperty);
		ASRunStopLF_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunStopLF");
		ASRunStopLF_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunStopLF", Classes.FObjectProperty);
		ASRunStopLB_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunStopLB");
		ASRunStopLB_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunStopLB", Classes.FObjectProperty);
		ASRunStopRF_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunStopRF");
		ASRunStopRF_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunStopRF", Classes.FObjectProperty);
		ASRunStopRB_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunStopRB");
		ASRunStopRB_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunStopRB", Classes.FObjectProperty);
		ASRunLoopAddPose_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunLoopAddPose");
		ASRunLoopAddPose_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunLoopAddPose", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref ASRunLoopAdditiveList_PropertyAddress, intPtr, "ASRunLoopAdditiveList");
		ASRunLoopAdditiveList_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunLoopAdditiveList");
		ASRunLoopAdditiveList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunLoopAdditiveList", Classes.FArrayProperty);
		ASRushStartFwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRushStartFwd");
		ASRushStartFwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRushStartFwd", Classes.FObjectProperty);
		ASRushStartLeftMin_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRushStartLeftMin");
		ASRushStartLeftMin_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRushStartLeftMin", Classes.FObjectProperty);
		ASRushStartLeftMax_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRushStartLeftMax");
		ASRushStartLeftMax_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRushStartLeftMax", Classes.FObjectProperty);
		ASRushStartRightMin_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRushStartRightMin");
		ASRushStartRightMin_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRushStartRightMin", Classes.FObjectProperty);
		ASRushStartRightMax_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRushStartRightMax");
		ASRushStartRightMax_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRushStartRightMax", Classes.FObjectProperty);
		ASRushLoopFwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRushLoopFwd");
		ASRushLoopFwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRushLoopFwd", Classes.FObjectProperty);
		ASRushSharpturnLeftMin_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRushSharpturnLeftMin");
		ASRushSharpturnLeftMin_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRushSharpturnLeftMin", Classes.FObjectProperty);
		ASRushSharpturnLeftMax_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRushSharpturnLeftMax");
		ASRushSharpturnLeftMax_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRushSharpturnLeftMax", Classes.FObjectProperty);
		ASRushSharpturnRightMin_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRushSharpturnRightMin");
		ASRushSharpturnRightMin_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRushSharpturnRightMin", Classes.FObjectProperty);
		ASRushSharpturnRightMax_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRushSharpturnRightMax");
		ASRushSharpturnRightMax_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRushSharpturnRightMax", Classes.FObjectProperty);
		ASRushStopFwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRushStopFwd");
		ASRushStopFwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRushStopFwd", Classes.FObjectProperty);
		ASRushLoopAddPose_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRushLoopAddPose");
		ASRushLoopAddPose_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRushLoopAddPose", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref ASRushLoopAdditiveList_PropertyAddress, intPtr, "ASRushLoopAdditiveList");
		ASRushLoopAdditiveList_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRushLoopAdditiveList");
		ASRushLoopAdditiveList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRushLoopAdditiveList", Classes.FArrayProperty);
		AnimIdle_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimIdle");
		AnimIdle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimIdle", Classes.FObjectProperty);
		MappedSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "MappedSpeed");
		MappedSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MappedSpeed", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref GaitGroundedState_PropertyAddress, intPtr, "GaitGroundedState");
		GaitGroundedState_Offset = NativeReflection.GetPropertyOffset(intPtr, "GaitGroundedState");
		GaitGroundedState_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GaitGroundedState", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref MoveGaitGroundedState_PropertyAddress, intPtr, "MoveGaitGroundedState");
		MoveGaitGroundedState_Offset = NativeReflection.GetPropertyOffset(intPtr, "MoveGaitGroundedState");
		MoveGaitGroundedState_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MoveGaitGroundedState", Classes.FEnumProperty);
		SwitchingLockStateAngle_Offset = NativeReflection.GetPropertyOffset(intPtr, "SwitchingLockStateAngle");
		SwitchingLockStateAngle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SwitchingLockStateAngle", Classes.FFloatProperty);
		ActorSpineNum_Offset = NativeReflection.GetPropertyOffset(intPtr, "ActorSpineNum");
		ActorSpineNum_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ActorSpineNum", Classes.FIntProperty);
		VelocityDeltaAngle_Offset = NativeReflection.GetPropertyOffset(intPtr, "VelocityDeltaAngle");
		VelocityDeltaAngle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "VelocityDeltaAngle", Classes.FFloatProperty);
		StopVelocityDeltaAngle_Offset = NativeReflection.GetPropertyOffset(intPtr, "StopVelocityDeltaAngle");
		StopVelocityDeltaAngle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StopVelocityDeltaAngle", Classes.FFloatProperty);
		InputDeltaAngle_Offset = NativeReflection.GetPropertyOffset(intPtr, "InputDeltaAngle");
		InputDeltaAngle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InputDeltaAngle", Classes.FFloatProperty);
		InputVelocityAngle_Offset = NativeReflection.GetPropertyOffset(intPtr, "InputVelocityAngle");
		InputVelocityAngle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InputVelocityAngle", Classes.FFloatProperty);
		MoveSpeedLastUpdate_Offset = NativeReflection.GetPropertyOffset(intPtr, "MoveSpeedLastUpdate");
		MoveSpeedLastUpdate_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MoveSpeedLastUpdate", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bPivotUseOrientationWarping_PropertyAddress, intPtr, "bPivotUseOrientationWarping");
		bPivotUseOrientationWarping_Offset = NativeReflection.GetPropertyOffset(intPtr, "bPivotUseOrientationWarping");
		bPivotUseOrientationWarping_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bPivotUseOrientationWarping", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bUpdateAnimIdle_PropertyAddress, intPtr, "bUpdateAnimIdle");
		bUpdateAnimIdle_Offset = NativeReflection.GetPropertyOffset(intPtr, "bUpdateAnimIdle");
		bUpdateAnimIdle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bUpdateAnimIdle", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bSwitchToLock_PropertyAddress, intPtr, "bSwitchToLock");
		bSwitchToLock_Offset = NativeReflection.GetPropertyOffset(intPtr, "bSwitchToLock");
		bSwitchToLock_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bSwitchToLock", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bSwitchingLockState_PropertyAddress, intPtr, "bSwitchingLockState");
		bSwitchingLockState_Offset = NativeReflection.GetPropertyOffset(intPtr, "bSwitchingLockState");
		bSwitchingLockState_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bSwitchingLockState", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bFreeStop_PropertyAddress, intPtr, "bFreeStop");
		bFreeStop_Offset = NativeReflection.GetPropertyOffset(intPtr, "bFreeStop");
		bFreeStop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bFreeStop", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockStop_PropertyAddress, intPtr, "bLockStop");
		bLockStop_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLockStop");
		bLockStop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLockStop", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bSwitchingLockStateStop_PropertyAddress, intPtr, "bSwitchingLockStateStop");
		bSwitchingLockStateStop_Offset = NativeReflection.GetPropertyOffset(intPtr, "bSwitchingLockStateStop");
		bSwitchingLockStateStop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bSwitchingLockStateStop", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bMoveToIdle_PropertyAddress, intPtr, "bMoveToIdle");
		bMoveToIdle_Offset = NativeReflection.GetPropertyOffset(intPtr, "bMoveToIdle");
		bMoveToIdle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bMoveToIdle", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bStartToTrans_PropertyAddress, intPtr, "bStartToTrans");
		bStartToTrans_Offset = NativeReflection.GetPropertyOffset(intPtr, "bStartToTrans");
		bStartToTrans_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bStartToTrans", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bFreeStartToTurn_PropertyAddress, intPtr, "bFreeStartToTurn");
		bFreeStartToTurn_Offset = NativeReflection.GetPropertyOffset(intPtr, "bFreeStartToTurn");
		bFreeStartToTurn_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bFreeStartToTurn", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockStartToTurn_PropertyAddress, intPtr, "bLockStartToTurn");
		bLockStartToTurn_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLockStartToTurn");
		bLockStartToTurn_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLockStartToTurn", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bSwitchingFreeToTurn_PropertyAddress, intPtr, "bSwitchingFreeToTurn");
		bSwitchingFreeToTurn_Offset = NativeReflection.GetPropertyOffset(intPtr, "bSwitchingFreeToTurn");
		bSwitchingFreeToTurn_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bSwitchingFreeToTurn", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockLoopToTurn_PropertyAddress, intPtr, "bLockLoopToTurn");
		bLockLoopToTurn_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLockLoopToTurn");
		bLockLoopToTurn_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLockLoopToTurn", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockTurnToLoop_PropertyAddress, intPtr, "bLockTurnToLoop");
		bLockTurnToLoop_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLockTurnToLoop");
		bLockTurnToLoop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLockTurnToLoop", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bFreeLoopToTurn_PropertyAddress, intPtr, "bFreeLoopToTurn");
		bFreeLoopToTurn_Offset = NativeReflection.GetPropertyOffset(intPtr, "bFreeLoopToTurn");
		bFreeLoopToTurn_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bFreeLoopToTurn", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bFreeMoveToTurn_PropertyAddress, intPtr, "bFreeMoveToTurn");
		bFreeMoveToTurn_Offset = NativeReflection.GetPropertyOffset(intPtr, "bFreeMoveToTurn");
		bFreeMoveToTurn_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bFreeMoveToTurn", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLockMoveToTurn_PropertyAddress, intPtr, "bLockMoveToTurn");
		bLockMoveToTurn_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLockMoveToTurn");
		bLockMoveToTurn_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLockMoveToTurn", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bMoveStartSwitch_PropertyAddress, intPtr, "bMoveStartSwitch");
		bMoveStartSwitch_Offset = NativeReflection.GetPropertyOffset(intPtr, "bMoveStartSwitch");
		bMoveStartSwitch_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bMoveStartSwitch", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bMoveTurnSwitch_PropertyAddress, intPtr, "bMoveTurnSwitch");
		bMoveTurnSwitch_Offset = NativeReflection.GetPropertyOffset(intPtr, "bMoveTurnSwitch");
		bMoveTurnSwitch_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bMoveTurnSwitch", Classes.FBoolProperty);
		ShouldToMove_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ShouldToMove");
		ShouldToMove_ParamsSize = NativeReflection.GetFunctionParamsSize(ShouldToMove_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ShouldToMove_ReturnValue_PropertyAddress, ShouldToMove_FunctionAddress, "ReturnValue");
		ShouldToMove_ReturnValue_Offset = NativeReflection.GetPropertyOffset(ShouldToMove_FunctionAddress, "ReturnValue");
		ShouldToMove_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(ShouldToMove_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ShouldToMove_IsValid = ShouldToMove_FunctionAddress != IntPtr.Zero && ShouldToMove_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldToMove", ShouldToMove_IsValid);
		SetupIdleAnim_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetupIdleAnim");
		SetupIdleAnim_ParamsSize = NativeReflection.GetFunctionParamsSize(SetupIdleAnim_FunctionAddress);
		NativeReflection.GetPropertyRef(ref SetupIdleAnim_Context_PropertyAddress, SetupIdleAnim_FunctionAddress, "Context");
		SetupIdleAnim_Context_Offset = NativeReflection.GetPropertyOffset(SetupIdleAnim_FunctionAddress, "Context");
		SetupIdleAnim_Context_IsValid = NativeReflection.ValidatePropertyClass(SetupIdleAnim_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref SetupIdleAnim_Node_PropertyAddress, SetupIdleAnim_FunctionAddress, "Node");
		SetupIdleAnim_Node_Offset = NativeReflection.GetPropertyOffset(SetupIdleAnim_FunctionAddress, "Node");
		SetupIdleAnim_Node_IsValid = NativeReflection.ValidatePropertyClass(SetupIdleAnim_FunctionAddress, "Node", Classes.FStructProperty);
		SetupIdleAnim_IsValid = SetupIdleAnim_FunctionAddress != IntPtr.Zero && SetupIdleAnim_Context_IsValid && SetupIdleAnim_Node_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:SetupIdleAnim", SetupIdleAnim_IsValid);
		SetupIdleOutput_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetupIdleOutput");
		SetupIdleOutput_ParamsSize = NativeReflection.GetFunctionParamsSize(SetupIdleOutput_FunctionAddress);
		NativeReflection.GetPropertyRef(ref SetupIdleOutput_Context_PropertyAddress, SetupIdleOutput_FunctionAddress, "Context");
		SetupIdleOutput_Context_Offset = NativeReflection.GetPropertyOffset(SetupIdleOutput_FunctionAddress, "Context");
		SetupIdleOutput_Context_IsValid = NativeReflection.ValidatePropertyClass(SetupIdleOutput_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref SetupIdleOutput_Node_PropertyAddress, SetupIdleOutput_FunctionAddress, "Node");
		SetupIdleOutput_Node_Offset = NativeReflection.GetPropertyOffset(SetupIdleOutput_FunctionAddress, "Node");
		SetupIdleOutput_Node_IsValid = NativeReflection.ValidatePropertyClass(SetupIdleOutput_FunctionAddress, "Node", Classes.FStructProperty);
		SetupIdleOutput_IsValid = SetupIdleOutput_FunctionAddress != IntPtr.Zero && SetupIdleOutput_Context_IsValid && SetupIdleOutput_Node_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:SetupIdleOutput", SetupIdleOutput_IsValid);
		SetupMoveLoopAnim_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetupMoveLoopAnim");
		SetupMoveLoopAnim_ParamsSize = NativeReflection.GetFunctionParamsSize(SetupMoveLoopAnim_FunctionAddress);
		NativeReflection.GetPropertyRef(ref SetupMoveLoopAnim_Context_PropertyAddress, SetupMoveLoopAnim_FunctionAddress, "Context");
		SetupMoveLoopAnim_Context_Offset = NativeReflection.GetPropertyOffset(SetupMoveLoopAnim_FunctionAddress, "Context");
		SetupMoveLoopAnim_Context_IsValid = NativeReflection.ValidatePropertyClass(SetupMoveLoopAnim_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref SetupMoveLoopAnim_Node_PropertyAddress, SetupMoveLoopAnim_FunctionAddress, "Node");
		SetupMoveLoopAnim_Node_Offset = NativeReflection.GetPropertyOffset(SetupMoveLoopAnim_FunctionAddress, "Node");
		SetupMoveLoopAnim_Node_IsValid = NativeReflection.ValidatePropertyClass(SetupMoveLoopAnim_FunctionAddress, "Node", Classes.FStructProperty);
		SetupMoveLoopAnim_IsValid = SetupMoveLoopAnim_FunctionAddress != IntPtr.Zero && SetupMoveLoopAnim_Context_IsValid && SetupMoveLoopAnim_Node_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:SetupMoveLoopAnim", SetupMoveLoopAnim_IsValid);
		SetupMoveStopAnim_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetupMoveStopAnim");
		SetupMoveStopAnim_ParamsSize = NativeReflection.GetFunctionParamsSize(SetupMoveStopAnim_FunctionAddress);
		NativeReflection.GetPropertyRef(ref SetupMoveStopAnim_Context_PropertyAddress, SetupMoveStopAnim_FunctionAddress, "Context");
		SetupMoveStopAnim_Context_Offset = NativeReflection.GetPropertyOffset(SetupMoveStopAnim_FunctionAddress, "Context");
		SetupMoveStopAnim_Context_IsValid = NativeReflection.ValidatePropertyClass(SetupMoveStopAnim_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref SetupMoveStopAnim_Node_PropertyAddress, SetupMoveStopAnim_FunctionAddress, "Node");
		SetupMoveStopAnim_Node_Offset = NativeReflection.GetPropertyOffset(SetupMoveStopAnim_FunctionAddress, "Node");
		SetupMoveStopAnim_Node_IsValid = NativeReflection.ValidatePropertyClass(SetupMoveStopAnim_FunctionAddress, "Node", Classes.FStructProperty);
		SetupMoveStopAnim_IsValid = SetupMoveStopAnim_FunctionAddress != IntPtr.Zero && SetupMoveStopAnim_Context_IsValid && SetupMoveStopAnim_Node_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:SetupMoveStopAnim", SetupMoveStopAnim_IsValid);
		SetupMoveTurnAnim_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetupMoveTurnAnim");
		SetupMoveTurnAnim_ParamsSize = NativeReflection.GetFunctionParamsSize(SetupMoveTurnAnim_FunctionAddress);
		NativeReflection.GetPropertyRef(ref SetupMoveTurnAnim_Context_PropertyAddress, SetupMoveTurnAnim_FunctionAddress, "Context");
		SetupMoveTurnAnim_Context_Offset = NativeReflection.GetPropertyOffset(SetupMoveTurnAnim_FunctionAddress, "Context");
		SetupMoveTurnAnim_Context_IsValid = NativeReflection.ValidatePropertyClass(SetupMoveTurnAnim_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref SetupMoveTurnAnim_Node_PropertyAddress, SetupMoveTurnAnim_FunctionAddress, "Node");
		SetupMoveTurnAnim_Node_Offset = NativeReflection.GetPropertyOffset(SetupMoveTurnAnim_FunctionAddress, "Node");
		SetupMoveTurnAnim_Node_IsValid = NativeReflection.ValidatePropertyClass(SetupMoveTurnAnim_FunctionAddress, "Node", Classes.FStructProperty);
		SetupMoveTurnAnim_IsValid = SetupMoveTurnAnim_FunctionAddress != IntPtr.Zero && SetupMoveTurnAnim_Context_IsValid && SetupMoveTurnAnim_Node_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:SetupMoveTurnAnim", SetupMoveTurnAnim_IsValid);
		ShouldMoveLoopToBR_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ShouldMoveLoopToBR");
		ShouldMoveLoopToBR_ParamsSize = NativeReflection.GetFunctionParamsSize(ShouldMoveLoopToBR_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ShouldMoveLoopToBR_ReturnValue_PropertyAddress, ShouldMoveLoopToBR_FunctionAddress, "ReturnValue");
		ShouldMoveLoopToBR_ReturnValue_Offset = NativeReflection.GetPropertyOffset(ShouldMoveLoopToBR_FunctionAddress, "ReturnValue");
		ShouldMoveLoopToBR_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(ShouldMoveLoopToBR_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ShouldMoveLoopToBR_IsValid = ShouldMoveLoopToBR_FunctionAddress != IntPtr.Zero && ShouldMoveLoopToBR_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopToBR", ShouldMoveLoopToBR_IsValid);
		ShouldMoveLoopToBL_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ShouldMoveLoopToBL");
		ShouldMoveLoopToBL_ParamsSize = NativeReflection.GetFunctionParamsSize(ShouldMoveLoopToBL_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ShouldMoveLoopToBL_ReturnValue_PropertyAddress, ShouldMoveLoopToBL_FunctionAddress, "ReturnValue");
		ShouldMoveLoopToBL_ReturnValue_Offset = NativeReflection.GetPropertyOffset(ShouldMoveLoopToBL_FunctionAddress, "ReturnValue");
		ShouldMoveLoopToBL_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(ShouldMoveLoopToBL_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ShouldMoveLoopToBL_IsValid = ShouldMoveLoopToBL_FunctionAddress != IntPtr.Zero && ShouldMoveLoopToBL_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopToBL", ShouldMoveLoopToBL_IsValid);
		ShouldMoveLoopToFR_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ShouldMoveLoopToFR");
		ShouldMoveLoopToFR_ParamsSize = NativeReflection.GetFunctionParamsSize(ShouldMoveLoopToFR_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ShouldMoveLoopToFR_ReturnValue_PropertyAddress, ShouldMoveLoopToFR_FunctionAddress, "ReturnValue");
		ShouldMoveLoopToFR_ReturnValue_Offset = NativeReflection.GetPropertyOffset(ShouldMoveLoopToFR_FunctionAddress, "ReturnValue");
		ShouldMoveLoopToFR_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(ShouldMoveLoopToFR_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ShouldMoveLoopToFR_IsValid = ShouldMoveLoopToFR_FunctionAddress != IntPtr.Zero && ShouldMoveLoopToFR_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopToFR", ShouldMoveLoopToFR_IsValid);
		ShouldMoveLoopToFL_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ShouldMoveLoopToFL");
		ShouldMoveLoopToFL_ParamsSize = NativeReflection.GetFunctionParamsSize(ShouldMoveLoopToFL_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ShouldMoveLoopToFL_ReturnValue_PropertyAddress, ShouldMoveLoopToFL_FunctionAddress, "ReturnValue");
		ShouldMoveLoopToFL_ReturnValue_Offset = NativeReflection.GetPropertyOffset(ShouldMoveLoopToFL_FunctionAddress, "ReturnValue");
		ShouldMoveLoopToFL_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(ShouldMoveLoopToFL_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ShouldMoveLoopToFL_IsValid = ShouldMoveLoopToFL_FunctionAddress != IntPtr.Zero && ShouldMoveLoopToFL_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopToFL", ShouldMoveLoopToFL_IsValid);
		SetupMoveStartAnim_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetupMoveStartAnim");
		SetupMoveStartAnim_ParamsSize = NativeReflection.GetFunctionParamsSize(SetupMoveStartAnim_FunctionAddress);
		NativeReflection.GetPropertyRef(ref SetupMoveStartAnim_Context_PropertyAddress, SetupMoveStartAnim_FunctionAddress, "Context");
		SetupMoveStartAnim_Context_Offset = NativeReflection.GetPropertyOffset(SetupMoveStartAnim_FunctionAddress, "Context");
		SetupMoveStartAnim_Context_IsValid = NativeReflection.ValidatePropertyClass(SetupMoveStartAnim_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref SetupMoveStartAnim_Node_PropertyAddress, SetupMoveStartAnim_FunctionAddress, "Node");
		SetupMoveStartAnim_Node_Offset = NativeReflection.GetPropertyOffset(SetupMoveStartAnim_FunctionAddress, "Node");
		SetupMoveStartAnim_Node_IsValid = NativeReflection.ValidatePropertyClass(SetupMoveStartAnim_FunctionAddress, "Node", Classes.FStructProperty);
		SetupMoveStartAnim_IsValid = SetupMoveStartAnim_FunctionAddress != IntPtr.Zero && SetupMoveStartAnim_Context_IsValid && SetupMoveStartAnim_Node_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:SetupMoveStartAnim", SetupMoveStartAnim_IsValid);
		UpdateMoveStopAnim_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateMoveStopAnim");
		UpdateMoveStopAnim_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateMoveStopAnim_FunctionAddress);
		NativeReflection.GetPropertyRef(ref UpdateMoveStopAnim_Context_PropertyAddress, UpdateMoveStopAnim_FunctionAddress, "Context");
		UpdateMoveStopAnim_Context_Offset = NativeReflection.GetPropertyOffset(UpdateMoveStopAnim_FunctionAddress, "Context");
		UpdateMoveStopAnim_Context_IsValid = NativeReflection.ValidatePropertyClass(UpdateMoveStopAnim_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref UpdateMoveStopAnim_Node_PropertyAddress, UpdateMoveStopAnim_FunctionAddress, "Node");
		UpdateMoveStopAnim_Node_Offset = NativeReflection.GetPropertyOffset(UpdateMoveStopAnim_FunctionAddress, "Node");
		UpdateMoveStopAnim_Node_IsValid = NativeReflection.ValidatePropertyClass(UpdateMoveStopAnim_FunctionAddress, "Node", Classes.FStructProperty);
		UpdateMoveStopAnim_IsValid = UpdateMoveStopAnim_FunctionAddress != IntPtr.Zero && UpdateMoveStopAnim_Context_IsValid && UpdateMoveStopAnim_Node_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:UpdateMoveStopAnim", UpdateMoveStopAnim_IsValid);
		UpdateMoveTurnAnim_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateMoveTurnAnim");
		UpdateMoveTurnAnim_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateMoveTurnAnim_FunctionAddress);
		NativeReflection.GetPropertyRef(ref UpdateMoveTurnAnim_Context_PropertyAddress, UpdateMoveTurnAnim_FunctionAddress, "Context");
		UpdateMoveTurnAnim_Context_Offset = NativeReflection.GetPropertyOffset(UpdateMoveTurnAnim_FunctionAddress, "Context");
		UpdateMoveTurnAnim_Context_IsValid = NativeReflection.ValidatePropertyClass(UpdateMoveTurnAnim_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref UpdateMoveTurnAnim_Node_PropertyAddress, UpdateMoveTurnAnim_FunctionAddress, "Node");
		UpdateMoveTurnAnim_Node_Offset = NativeReflection.GetPropertyOffset(UpdateMoveTurnAnim_FunctionAddress, "Node");
		UpdateMoveTurnAnim_Node_IsValid = NativeReflection.ValidatePropertyClass(UpdateMoveTurnAnim_FunctionAddress, "Node", Classes.FStructProperty);
		UpdateMoveTurnAnim_IsValid = UpdateMoveTurnAnim_FunctionAddress != IntPtr.Zero && UpdateMoveTurnAnim_Context_IsValid && UpdateMoveTurnAnim_Node_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:UpdateMoveTurnAnim", UpdateMoveTurnAnim_IsValid);
		SetupMoveTurnOutput_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetupMoveTurnOutput");
		SetupMoveTurnOutput_ParamsSize = NativeReflection.GetFunctionParamsSize(SetupMoveTurnOutput_FunctionAddress);
		NativeReflection.GetPropertyRef(ref SetupMoveTurnOutput_Context_PropertyAddress, SetupMoveTurnOutput_FunctionAddress, "Context");
		SetupMoveTurnOutput_Context_Offset = NativeReflection.GetPropertyOffset(SetupMoveTurnOutput_FunctionAddress, "Context");
		SetupMoveTurnOutput_Context_IsValid = NativeReflection.ValidatePropertyClass(SetupMoveTurnOutput_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref SetupMoveTurnOutput_Node_PropertyAddress, SetupMoveTurnOutput_FunctionAddress, "Node");
		SetupMoveTurnOutput_Node_Offset = NativeReflection.GetPropertyOffset(SetupMoveTurnOutput_FunctionAddress, "Node");
		SetupMoveTurnOutput_Node_IsValid = NativeReflection.ValidatePropertyClass(SetupMoveTurnOutput_FunctionAddress, "Node", Classes.FStructProperty);
		SetupMoveTurnOutput_IsValid = SetupMoveTurnOutput_FunctionAddress != IntPtr.Zero && SetupMoveTurnOutput_Context_IsValid && SetupMoveTurnOutput_Node_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:SetupMoveTurnOutput", SetupMoveTurnOutput_IsValid);
		SetupMoveStopOutput_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetupMoveStopOutput");
		SetupMoveStopOutput_ParamsSize = NativeReflection.GetFunctionParamsSize(SetupMoveStopOutput_FunctionAddress);
		NativeReflection.GetPropertyRef(ref SetupMoveStopOutput_Context_PropertyAddress, SetupMoveStopOutput_FunctionAddress, "Context");
		SetupMoveStopOutput_Context_Offset = NativeReflection.GetPropertyOffset(SetupMoveStopOutput_FunctionAddress, "Context");
		SetupMoveStopOutput_Context_IsValid = NativeReflection.ValidatePropertyClass(SetupMoveStopOutput_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref SetupMoveStopOutput_Node_PropertyAddress, SetupMoveStopOutput_FunctionAddress, "Node");
		SetupMoveStopOutput_Node_Offset = NativeReflection.GetPropertyOffset(SetupMoveStopOutput_FunctionAddress, "Node");
		SetupMoveStopOutput_Node_IsValid = NativeReflection.ValidatePropertyClass(SetupMoveStopOutput_FunctionAddress, "Node", Classes.FStructProperty);
		SetupMoveStopOutput_IsValid = SetupMoveStopOutput_FunctionAddress != IntPtr.Zero && SetupMoveStopOutput_Context_IsValid && SetupMoveStopOutput_Node_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:SetupMoveStopOutput", SetupMoveStopOutput_IsValid);
		UpdateMoveStartAnim_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateMoveStartAnim");
		UpdateMoveStartAnim_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateMoveStartAnim_FunctionAddress);
		NativeReflection.GetPropertyRef(ref UpdateMoveStartAnim_Context_PropertyAddress, UpdateMoveStartAnim_FunctionAddress, "Context");
		UpdateMoveStartAnim_Context_Offset = NativeReflection.GetPropertyOffset(UpdateMoveStartAnim_FunctionAddress, "Context");
		UpdateMoveStartAnim_Context_IsValid = NativeReflection.ValidatePropertyClass(UpdateMoveStartAnim_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref UpdateMoveStartAnim_Node_PropertyAddress, UpdateMoveStartAnim_FunctionAddress, "Node");
		UpdateMoveStartAnim_Node_Offset = NativeReflection.GetPropertyOffset(UpdateMoveStartAnim_FunctionAddress, "Node");
		UpdateMoveStartAnim_Node_IsValid = NativeReflection.ValidatePropertyClass(UpdateMoveStartAnim_FunctionAddress, "Node", Classes.FStructProperty);
		UpdateMoveStartAnim_IsValid = UpdateMoveStartAnim_FunctionAddress != IntPtr.Zero && UpdateMoveStartAnim_Context_IsValid && UpdateMoveStartAnim_Node_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:UpdateMoveStartAnim", UpdateMoveStartAnim_IsValid);
		SetupMoveLoopOutput_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetupMoveLoopOutput");
		SetupMoveLoopOutput_ParamsSize = NativeReflection.GetFunctionParamsSize(SetupMoveLoopOutput_FunctionAddress);
		NativeReflection.GetPropertyRef(ref SetupMoveLoopOutput_Context_PropertyAddress, SetupMoveLoopOutput_FunctionAddress, "Context");
		SetupMoveLoopOutput_Context_Offset = NativeReflection.GetPropertyOffset(SetupMoveLoopOutput_FunctionAddress, "Context");
		SetupMoveLoopOutput_Context_IsValid = NativeReflection.ValidatePropertyClass(SetupMoveLoopOutput_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref SetupMoveLoopOutput_Node_PropertyAddress, SetupMoveLoopOutput_FunctionAddress, "Node");
		SetupMoveLoopOutput_Node_Offset = NativeReflection.GetPropertyOffset(SetupMoveLoopOutput_FunctionAddress, "Node");
		SetupMoveLoopOutput_Node_IsValid = NativeReflection.ValidatePropertyClass(SetupMoveLoopOutput_FunctionAddress, "Node", Classes.FStructProperty);
		SetupMoveLoopOutput_IsValid = SetupMoveLoopOutput_FunctionAddress != IntPtr.Zero && SetupMoveLoopOutput_Context_IsValid && SetupMoveLoopOutput_Node_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:SetupMoveLoopOutput", SetupMoveLoopOutput_IsValid);
		ShouldMoveLoopToFwd_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ShouldMoveLoopToFwd");
		ShouldMoveLoopToFwd_ParamsSize = NativeReflection.GetFunctionParamsSize(ShouldMoveLoopToFwd_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ShouldMoveLoopToFwd_ReturnValue_PropertyAddress, ShouldMoveLoopToFwd_FunctionAddress, "ReturnValue");
		ShouldMoveLoopToFwd_ReturnValue_Offset = NativeReflection.GetPropertyOffset(ShouldMoveLoopToFwd_FunctionAddress, "ReturnValue");
		ShouldMoveLoopToFwd_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(ShouldMoveLoopToFwd_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ShouldMoveLoopToFwd_IsValid = ShouldMoveLoopToFwd_FunctionAddress != IntPtr.Zero && ShouldMoveLoopToFwd_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopToFwd", ShouldMoveLoopToFwd_IsValid);
		ShouldMoveLoopToBwd_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ShouldMoveLoopToBwd");
		ShouldMoveLoopToBwd_ParamsSize = NativeReflection.GetFunctionParamsSize(ShouldMoveLoopToBwd_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ShouldMoveLoopToBwd_ReturnValue_PropertyAddress, ShouldMoveLoopToBwd_FunctionAddress, "ReturnValue");
		ShouldMoveLoopToBwd_ReturnValue_Offset = NativeReflection.GetPropertyOffset(ShouldMoveLoopToBwd_FunctionAddress, "ReturnValue");
		ShouldMoveLoopToBwd_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(ShouldMoveLoopToBwd_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ShouldMoveLoopToBwd_IsValid = ShouldMoveLoopToBwd_FunctionAddress != IntPtr.Zero && ShouldMoveLoopToBwd_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopToBwd", ShouldMoveLoopToBwd_IsValid);
		ShouldMoveLoopBRToFR_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ShouldMoveLoopBRToFR");
		ShouldMoveLoopBRToFR_ParamsSize = NativeReflection.GetFunctionParamsSize(ShouldMoveLoopBRToFR_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ShouldMoveLoopBRToFR_ReturnValue_PropertyAddress, ShouldMoveLoopBRToFR_FunctionAddress, "ReturnValue");
		ShouldMoveLoopBRToFR_ReturnValue_Offset = NativeReflection.GetPropertyOffset(ShouldMoveLoopBRToFR_FunctionAddress, "ReturnValue");
		ShouldMoveLoopBRToFR_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(ShouldMoveLoopBRToFR_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ShouldMoveLoopBRToFR_IsValid = ShouldMoveLoopBRToFR_FunctionAddress != IntPtr.Zero && ShouldMoveLoopBRToFR_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopBRToFR", ShouldMoveLoopBRToFR_IsValid);
		ShouldMoveLoopFRToBR_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ShouldMoveLoopFRToBR");
		ShouldMoveLoopFRToBR_ParamsSize = NativeReflection.GetFunctionParamsSize(ShouldMoveLoopFRToBR_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ShouldMoveLoopFRToBR_ReturnValue_PropertyAddress, ShouldMoveLoopFRToBR_FunctionAddress, "ReturnValue");
		ShouldMoveLoopFRToBR_ReturnValue_Offset = NativeReflection.GetPropertyOffset(ShouldMoveLoopFRToBR_FunctionAddress, "ReturnValue");
		ShouldMoveLoopFRToBR_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(ShouldMoveLoopFRToBR_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ShouldMoveLoopFRToBR_IsValid = ShouldMoveLoopFRToBR_FunctionAddress != IntPtr.Zero && ShouldMoveLoopFRToBR_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopFRToBR", ShouldMoveLoopFRToBR_IsValid);
		ShouldMoveLoopFLToBL_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ShouldMoveLoopFLToBL");
		ShouldMoveLoopFLToBL_ParamsSize = NativeReflection.GetFunctionParamsSize(ShouldMoveLoopFLToBL_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ShouldMoveLoopFLToBL_ReturnValue_PropertyAddress, ShouldMoveLoopFLToBL_FunctionAddress, "ReturnValue");
		ShouldMoveLoopFLToBL_ReturnValue_Offset = NativeReflection.GetPropertyOffset(ShouldMoveLoopFLToBL_FunctionAddress, "ReturnValue");
		ShouldMoveLoopFLToBL_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(ShouldMoveLoopFLToBL_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ShouldMoveLoopFLToBL_IsValid = ShouldMoveLoopFLToBL_FunctionAddress != IntPtr.Zero && ShouldMoveLoopFLToBL_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopFLToBL", ShouldMoveLoopFLToBL_IsValid);
		ShouldMoveLoopLeftBR_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ShouldMoveLoopLeftBR");
		ShouldMoveLoopLeftBR_ParamsSize = NativeReflection.GetFunctionParamsSize(ShouldMoveLoopLeftBR_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ShouldMoveLoopLeftBR_ReturnValue_PropertyAddress, ShouldMoveLoopLeftBR_FunctionAddress, "ReturnValue");
		ShouldMoveLoopLeftBR_ReturnValue_Offset = NativeReflection.GetPropertyOffset(ShouldMoveLoopLeftBR_FunctionAddress, "ReturnValue");
		ShouldMoveLoopLeftBR_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(ShouldMoveLoopLeftBR_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ShouldMoveLoopLeftBR_IsValid = ShouldMoveLoopLeftBR_FunctionAddress != IntPtr.Zero && ShouldMoveLoopLeftBR_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopLeftBR", ShouldMoveLoopLeftBR_IsValid);
		UpdateMoveTurnOutput_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateMoveTurnOutput");
		UpdateMoveTurnOutput_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateMoveTurnOutput_FunctionAddress);
		NativeReflection.GetPropertyRef(ref UpdateMoveTurnOutput_Context_PropertyAddress, UpdateMoveTurnOutput_FunctionAddress, "Context");
		UpdateMoveTurnOutput_Context_Offset = NativeReflection.GetPropertyOffset(UpdateMoveTurnOutput_FunctionAddress, "Context");
		UpdateMoveTurnOutput_Context_IsValid = NativeReflection.ValidatePropertyClass(UpdateMoveTurnOutput_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref UpdateMoveTurnOutput_Node_PropertyAddress, UpdateMoveTurnOutput_FunctionAddress, "Node");
		UpdateMoveTurnOutput_Node_Offset = NativeReflection.GetPropertyOffset(UpdateMoveTurnOutput_FunctionAddress, "Node");
		UpdateMoveTurnOutput_Node_IsValid = NativeReflection.ValidatePropertyClass(UpdateMoveTurnOutput_FunctionAddress, "Node", Classes.FStructProperty);
		UpdateMoveTurnOutput_IsValid = UpdateMoveTurnOutput_FunctionAddress != IntPtr.Zero && UpdateMoveTurnOutput_Context_IsValid && UpdateMoveTurnOutput_Node_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:UpdateMoveTurnOutput", UpdateMoveTurnOutput_IsValid);
		ShouldMoveLoopLeftFR_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ShouldMoveLoopLeftFR");
		ShouldMoveLoopLeftFR_ParamsSize = NativeReflection.GetFunctionParamsSize(ShouldMoveLoopLeftFR_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ShouldMoveLoopLeftFR_ReturnValue_PropertyAddress, ShouldMoveLoopLeftFR_FunctionAddress, "ReturnValue");
		ShouldMoveLoopLeftFR_ReturnValue_Offset = NativeReflection.GetPropertyOffset(ShouldMoveLoopLeftFR_FunctionAddress, "ReturnValue");
		ShouldMoveLoopLeftFR_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(ShouldMoveLoopLeftFR_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ShouldMoveLoopLeftFR_IsValid = ShouldMoveLoopLeftFR_FunctionAddress != IntPtr.Zero && ShouldMoveLoopLeftFR_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopLeftFR", ShouldMoveLoopLeftFR_IsValid);
		ShouldMoveLoopLeftFL_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ShouldMoveLoopLeftFL");
		ShouldMoveLoopLeftFL_ParamsSize = NativeReflection.GetFunctionParamsSize(ShouldMoveLoopLeftFL_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ShouldMoveLoopLeftFL_ReturnValue_PropertyAddress, ShouldMoveLoopLeftFL_FunctionAddress, "ReturnValue");
		ShouldMoveLoopLeftFL_ReturnValue_Offset = NativeReflection.GetPropertyOffset(ShouldMoveLoopLeftFL_FunctionAddress, "ReturnValue");
		ShouldMoveLoopLeftFL_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(ShouldMoveLoopLeftFL_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ShouldMoveLoopLeftFL_IsValid = ShouldMoveLoopLeftFL_FunctionAddress != IntPtr.Zero && ShouldMoveLoopLeftFL_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopLeftFL", ShouldMoveLoopLeftFL_IsValid);
		UpdateMoveStopOutput_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateMoveStopOutput");
		UpdateMoveStopOutput_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateMoveStopOutput_FunctionAddress);
		NativeReflection.GetPropertyRef(ref UpdateMoveStopOutput_Context_PropertyAddress, UpdateMoveStopOutput_FunctionAddress, "Context");
		UpdateMoveStopOutput_Context_Offset = NativeReflection.GetPropertyOffset(UpdateMoveStopOutput_FunctionAddress, "Context");
		UpdateMoveStopOutput_Context_IsValid = NativeReflection.ValidatePropertyClass(UpdateMoveStopOutput_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref UpdateMoveStopOutput_Node_PropertyAddress, UpdateMoveStopOutput_FunctionAddress, "Node");
		UpdateMoveStopOutput_Node_Offset = NativeReflection.GetPropertyOffset(UpdateMoveStopOutput_FunctionAddress, "Node");
		UpdateMoveStopOutput_Node_IsValid = NativeReflection.ValidatePropertyClass(UpdateMoveStopOutput_FunctionAddress, "Node", Classes.FStructProperty);
		UpdateMoveStopOutput_IsValid = UpdateMoveStopOutput_FunctionAddress != IntPtr.Zero && UpdateMoveStopOutput_Context_IsValid && UpdateMoveStopOutput_Node_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:UpdateMoveStopOutput", UpdateMoveStopOutput_IsValid);
		UpdateMoveLoopOutput_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateMoveLoopOutput");
		UpdateMoveLoopOutput_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateMoveLoopOutput_FunctionAddress);
		NativeReflection.GetPropertyRef(ref UpdateMoveLoopOutput_Context_PropertyAddress, UpdateMoveLoopOutput_FunctionAddress, "Context");
		UpdateMoveLoopOutput_Context_Offset = NativeReflection.GetPropertyOffset(UpdateMoveLoopOutput_FunctionAddress, "Context");
		UpdateMoveLoopOutput_Context_IsValid = NativeReflection.ValidatePropertyClass(UpdateMoveLoopOutput_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref UpdateMoveLoopOutput_Node_PropertyAddress, UpdateMoveLoopOutput_FunctionAddress, "Node");
		UpdateMoveLoopOutput_Node_Offset = NativeReflection.GetPropertyOffset(UpdateMoveLoopOutput_FunctionAddress, "Node");
		UpdateMoveLoopOutput_Node_IsValid = NativeReflection.ValidatePropertyClass(UpdateMoveLoopOutput_FunctionAddress, "Node", Classes.FStructProperty);
		UpdateMoveLoopOutput_IsValid = UpdateMoveLoopOutput_FunctionAddress != IntPtr.Zero && UpdateMoveLoopOutput_Context_IsValid && UpdateMoveLoopOutput_Node_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:UpdateMoveLoopOutput", UpdateMoveLoopOutput_IsValid);
		UpdateMoveLoopBRAnim_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateMoveLoopBRAnim");
		UpdateMoveLoopBRAnim_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateMoveLoopBRAnim_FunctionAddress);
		NativeReflection.GetPropertyRef(ref UpdateMoveLoopBRAnim_Context_PropertyAddress, UpdateMoveLoopBRAnim_FunctionAddress, "Context");
		UpdateMoveLoopBRAnim_Context_Offset = NativeReflection.GetPropertyOffset(UpdateMoveLoopBRAnim_FunctionAddress, "Context");
		UpdateMoveLoopBRAnim_Context_IsValid = NativeReflection.ValidatePropertyClass(UpdateMoveLoopBRAnim_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref UpdateMoveLoopBRAnim_Node_PropertyAddress, UpdateMoveLoopBRAnim_FunctionAddress, "Node");
		UpdateMoveLoopBRAnim_Node_Offset = NativeReflection.GetPropertyOffset(UpdateMoveLoopBRAnim_FunctionAddress, "Node");
		UpdateMoveLoopBRAnim_Node_IsValid = NativeReflection.ValidatePropertyClass(UpdateMoveLoopBRAnim_FunctionAddress, "Node", Classes.FStructProperty);
		UpdateMoveLoopBRAnim_IsValid = UpdateMoveLoopBRAnim_FunctionAddress != IntPtr.Zero && UpdateMoveLoopBRAnim_Context_IsValid && UpdateMoveLoopBRAnim_Node_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:UpdateMoveLoopBRAnim", UpdateMoveLoopBRAnim_IsValid);
		UpdateMoveLoopBLAnim_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateMoveLoopBLAnim");
		UpdateMoveLoopBLAnim_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateMoveLoopBLAnim_FunctionAddress);
		NativeReflection.GetPropertyRef(ref UpdateMoveLoopBLAnim_Context_PropertyAddress, UpdateMoveLoopBLAnim_FunctionAddress, "Context");
		UpdateMoveLoopBLAnim_Context_Offset = NativeReflection.GetPropertyOffset(UpdateMoveLoopBLAnim_FunctionAddress, "Context");
		UpdateMoveLoopBLAnim_Context_IsValid = NativeReflection.ValidatePropertyClass(UpdateMoveLoopBLAnim_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref UpdateMoveLoopBLAnim_Node_PropertyAddress, UpdateMoveLoopBLAnim_FunctionAddress, "Node");
		UpdateMoveLoopBLAnim_Node_Offset = NativeReflection.GetPropertyOffset(UpdateMoveLoopBLAnim_FunctionAddress, "Node");
		UpdateMoveLoopBLAnim_Node_IsValid = NativeReflection.ValidatePropertyClass(UpdateMoveLoopBLAnim_FunctionAddress, "Node", Classes.FStructProperty);
		UpdateMoveLoopBLAnim_IsValid = UpdateMoveLoopBLAnim_FunctionAddress != IntPtr.Zero && UpdateMoveLoopBLAnim_Context_IsValid && UpdateMoveLoopBLAnim_Node_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:UpdateMoveLoopBLAnim", UpdateMoveLoopBLAnim_IsValid);
		UpdateMoveLoopFRAnim_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateMoveLoopFRAnim");
		UpdateMoveLoopFRAnim_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateMoveLoopFRAnim_FunctionAddress);
		NativeReflection.GetPropertyRef(ref UpdateMoveLoopFRAnim_Context_PropertyAddress, UpdateMoveLoopFRAnim_FunctionAddress, "Context");
		UpdateMoveLoopFRAnim_Context_Offset = NativeReflection.GetPropertyOffset(UpdateMoveLoopFRAnim_FunctionAddress, "Context");
		UpdateMoveLoopFRAnim_Context_IsValid = NativeReflection.ValidatePropertyClass(UpdateMoveLoopFRAnim_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref UpdateMoveLoopFRAnim_Node_PropertyAddress, UpdateMoveLoopFRAnim_FunctionAddress, "Node");
		UpdateMoveLoopFRAnim_Node_Offset = NativeReflection.GetPropertyOffset(UpdateMoveLoopFRAnim_FunctionAddress, "Node");
		UpdateMoveLoopFRAnim_Node_IsValid = NativeReflection.ValidatePropertyClass(UpdateMoveLoopFRAnim_FunctionAddress, "Node", Classes.FStructProperty);
		UpdateMoveLoopFRAnim_IsValid = UpdateMoveLoopFRAnim_FunctionAddress != IntPtr.Zero && UpdateMoveLoopFRAnim_Context_IsValid && UpdateMoveLoopFRAnim_Node_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:UpdateMoveLoopFRAnim", UpdateMoveLoopFRAnim_IsValid);
		UpdateMoveLoopFLAnim_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateMoveLoopFLAnim");
		UpdateMoveLoopFLAnim_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateMoveLoopFLAnim_FunctionAddress);
		NativeReflection.GetPropertyRef(ref UpdateMoveLoopFLAnim_Context_PropertyAddress, UpdateMoveLoopFLAnim_FunctionAddress, "Context");
		UpdateMoveLoopFLAnim_Context_Offset = NativeReflection.GetPropertyOffset(UpdateMoveLoopFLAnim_FunctionAddress, "Context");
		UpdateMoveLoopFLAnim_Context_IsValid = NativeReflection.ValidatePropertyClass(UpdateMoveLoopFLAnim_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref UpdateMoveLoopFLAnim_Node_PropertyAddress, UpdateMoveLoopFLAnim_FunctionAddress, "Node");
		UpdateMoveLoopFLAnim_Node_Offset = NativeReflection.GetPropertyOffset(UpdateMoveLoopFLAnim_FunctionAddress, "Node");
		UpdateMoveLoopFLAnim_Node_IsValid = NativeReflection.ValidatePropertyClass(UpdateMoveLoopFLAnim_FunctionAddress, "Node", Classes.FStructProperty);
		UpdateMoveLoopFLAnim_IsValid = UpdateMoveLoopFLAnim_FunctionAddress != IntPtr.Zero && UpdateMoveLoopFLAnim_Context_IsValid && UpdateMoveLoopFLAnim_Node_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:UpdateMoveLoopFLAnim", UpdateMoveLoopFLAnim_IsValid);
		SetupMoveStartOutput_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetupMoveStartOutput");
		SetupMoveStartOutput_ParamsSize = NativeReflection.GetFunctionParamsSize(SetupMoveStartOutput_FunctionAddress);
		NativeReflection.GetPropertyRef(ref SetupMoveStartOutput_Context_PropertyAddress, SetupMoveStartOutput_FunctionAddress, "Context");
		SetupMoveStartOutput_Context_Offset = NativeReflection.GetPropertyOffset(SetupMoveStartOutput_FunctionAddress, "Context");
		SetupMoveStartOutput_Context_IsValid = NativeReflection.ValidatePropertyClass(SetupMoveStartOutput_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref SetupMoveStartOutput_Node_PropertyAddress, SetupMoveStartOutput_FunctionAddress, "Node");
		SetupMoveStartOutput_Node_Offset = NativeReflection.GetPropertyOffset(SetupMoveStartOutput_FunctionAddress, "Node");
		SetupMoveStartOutput_Node_IsValid = NativeReflection.ValidatePropertyClass(SetupMoveStartOutput_FunctionAddress, "Node", Classes.FStructProperty);
		SetupMoveStartOutput_IsValid = SetupMoveStartOutput_FunctionAddress != IntPtr.Zero && SetupMoveStartOutput_Context_IsValid && SetupMoveStartOutput_Node_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:SetupMoveStartOutput", SetupMoveStartOutput_IsValid);
		ShouldMoveLoopLeftBL_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ShouldMoveLoopLeftBL");
		ShouldMoveLoopLeftBL_ParamsSize = NativeReflection.GetFunctionParamsSize(ShouldMoveLoopLeftBL_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ShouldMoveLoopLeftBL_ReturnValue_PropertyAddress, ShouldMoveLoopLeftBL_FunctionAddress, "ReturnValue");
		ShouldMoveLoopLeftBL_ReturnValue_Offset = NativeReflection.GetPropertyOffset(ShouldMoveLoopLeftBL_FunctionAddress, "ReturnValue");
		ShouldMoveLoopLeftBL_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(ShouldMoveLoopLeftBL_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ShouldMoveLoopLeftBL_IsValid = ShouldMoveLoopLeftBL_FunctionAddress != IntPtr.Zero && ShouldMoveLoopLeftBL_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopLeftBL", ShouldMoveLoopLeftBL_IsValid);
		ShouldMoveLoopBLToFL_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ShouldMoveLoopBLToFL");
		ShouldMoveLoopBLToFL_ParamsSize = NativeReflection.GetFunctionParamsSize(ShouldMoveLoopBLToFL_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ShouldMoveLoopBLToFL_ReturnValue_PropertyAddress, ShouldMoveLoopBLToFL_FunctionAddress, "ReturnValue");
		ShouldMoveLoopBLToFL_ReturnValue_Offset = NativeReflection.GetPropertyOffset(ShouldMoveLoopBLToFL_FunctionAddress, "ReturnValue");
		ShouldMoveLoopBLToFL_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(ShouldMoveLoopBLToFL_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ShouldMoveLoopBLToFL_IsValid = ShouldMoveLoopBLToFL_FunctionAddress != IntPtr.Zero && ShouldMoveLoopBLToFL_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopBLToFL", ShouldMoveLoopBLToFL_IsValid);
		ShouldMoveLoopLeftBwd_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ShouldMoveLoopLeftBwd");
		ShouldMoveLoopLeftBwd_ParamsSize = NativeReflection.GetFunctionParamsSize(ShouldMoveLoopLeftBwd_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ShouldMoveLoopLeftBwd_ReturnValue_PropertyAddress, ShouldMoveLoopLeftBwd_FunctionAddress, "ReturnValue");
		ShouldMoveLoopLeftBwd_ReturnValue_Offset = NativeReflection.GetPropertyOffset(ShouldMoveLoopLeftBwd_FunctionAddress, "ReturnValue");
		ShouldMoveLoopLeftBwd_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(ShouldMoveLoopLeftBwd_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ShouldMoveLoopLeftBwd_IsValid = ShouldMoveLoopLeftBwd_FunctionAddress != IntPtr.Zero && ShouldMoveLoopLeftBwd_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopLeftBwd", ShouldMoveLoopLeftBwd_IsValid);
		ShouldMoveLoopLeftFwd_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ShouldMoveLoopLeftFwd");
		ShouldMoveLoopLeftFwd_ParamsSize = NativeReflection.GetFunctionParamsSize(ShouldMoveLoopLeftFwd_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ShouldMoveLoopLeftFwd_ReturnValue_PropertyAddress, ShouldMoveLoopLeftFwd_FunctionAddress, "ReturnValue");
		ShouldMoveLoopLeftFwd_ReturnValue_Offset = NativeReflection.GetPropertyOffset(ShouldMoveLoopLeftFwd_FunctionAddress, "ReturnValue");
		ShouldMoveLoopLeftFwd_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(ShouldMoveLoopLeftFwd_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ShouldMoveLoopLeftFwd_IsValid = ShouldMoveLoopLeftFwd_FunctionAddress != IntPtr.Zero && ShouldMoveLoopLeftFwd_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopLeftFwd", ShouldMoveLoopLeftFwd_IsValid);
		UpdateMoveLoopFwdAnim_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateMoveLoopFwdAnim");
		UpdateMoveLoopFwdAnim_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateMoveLoopFwdAnim_FunctionAddress);
		NativeReflection.GetPropertyRef(ref UpdateMoveLoopFwdAnim_Context_PropertyAddress, UpdateMoveLoopFwdAnim_FunctionAddress, "Context");
		UpdateMoveLoopFwdAnim_Context_Offset = NativeReflection.GetPropertyOffset(UpdateMoveLoopFwdAnim_FunctionAddress, "Context");
		UpdateMoveLoopFwdAnim_Context_IsValid = NativeReflection.ValidatePropertyClass(UpdateMoveLoopFwdAnim_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref UpdateMoveLoopFwdAnim_Node_PropertyAddress, UpdateMoveLoopFwdAnim_FunctionAddress, "Node");
		UpdateMoveLoopFwdAnim_Node_Offset = NativeReflection.GetPropertyOffset(UpdateMoveLoopFwdAnim_FunctionAddress, "Node");
		UpdateMoveLoopFwdAnim_Node_IsValid = NativeReflection.ValidatePropertyClass(UpdateMoveLoopFwdAnim_FunctionAddress, "Node", Classes.FStructProperty);
		UpdateMoveLoopFwdAnim_IsValid = UpdateMoveLoopFwdAnim_FunctionAddress != IntPtr.Zero && UpdateMoveLoopFwdAnim_Context_IsValid && UpdateMoveLoopFwdAnim_Node_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:UpdateMoveLoopFwdAnim", UpdateMoveLoopFwdAnim_IsValid);
		UpdateMoveLoopBwdAnim_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateMoveLoopBwdAnim");
		UpdateMoveLoopBwdAnim_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateMoveLoopBwdAnim_FunctionAddress);
		NativeReflection.GetPropertyRef(ref UpdateMoveLoopBwdAnim_Context_PropertyAddress, UpdateMoveLoopBwdAnim_FunctionAddress, "Context");
		UpdateMoveLoopBwdAnim_Context_Offset = NativeReflection.GetPropertyOffset(UpdateMoveLoopBwdAnim_FunctionAddress, "Context");
		UpdateMoveLoopBwdAnim_Context_IsValid = NativeReflection.ValidatePropertyClass(UpdateMoveLoopBwdAnim_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref UpdateMoveLoopBwdAnim_Node_PropertyAddress, UpdateMoveLoopBwdAnim_FunctionAddress, "Node");
		UpdateMoveLoopBwdAnim_Node_Offset = NativeReflection.GetPropertyOffset(UpdateMoveLoopBwdAnim_FunctionAddress, "Node");
		UpdateMoveLoopBwdAnim_Node_IsValid = NativeReflection.ValidatePropertyClass(UpdateMoveLoopBwdAnim_FunctionAddress, "Node", Classes.FStructProperty);
		UpdateMoveLoopBwdAnim_IsValid = UpdateMoveLoopBwdAnim_FunctionAddress != IntPtr.Zero && UpdateMoveLoopBwdAnim_Context_IsValid && UpdateMoveLoopBwdAnim_Node_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:UpdateMoveLoopBwdAnim", UpdateMoveLoopBwdAnim_IsValid);
		ShouldMoveLoopTransToFL_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ShouldMoveLoopTransToFL");
		ShouldMoveLoopTransToFL_ParamsSize = NativeReflection.GetFunctionParamsSize(ShouldMoveLoopTransToFL_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ShouldMoveLoopTransToFL_ReturnValue_PropertyAddress, ShouldMoveLoopTransToFL_FunctionAddress, "ReturnValue");
		ShouldMoveLoopTransToFL_ReturnValue_Offset = NativeReflection.GetPropertyOffset(ShouldMoveLoopTransToFL_FunctionAddress, "ReturnValue");
		ShouldMoveLoopTransToFL_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(ShouldMoveLoopTransToFL_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ShouldMoveLoopTransToFL_IsValid = ShouldMoveLoopTransToFL_FunctionAddress != IntPtr.Zero && ShouldMoveLoopTransToFL_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopTransToFL", ShouldMoveLoopTransToFL_IsValid);
		ShouldMoveLoopTransToFR_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ShouldMoveLoopTransToFR");
		ShouldMoveLoopTransToFR_ParamsSize = NativeReflection.GetFunctionParamsSize(ShouldMoveLoopTransToFR_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ShouldMoveLoopTransToFR_ReturnValue_PropertyAddress, ShouldMoveLoopTransToFR_FunctionAddress, "ReturnValue");
		ShouldMoveLoopTransToFR_ReturnValue_Offset = NativeReflection.GetPropertyOffset(ShouldMoveLoopTransToFR_FunctionAddress, "ReturnValue");
		ShouldMoveLoopTransToFR_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(ShouldMoveLoopTransToFR_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ShouldMoveLoopTransToFR_IsValid = ShouldMoveLoopTransToFR_FunctionAddress != IntPtr.Zero && ShouldMoveLoopTransToFR_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopTransToFR", ShouldMoveLoopTransToFR_IsValid);
		ShouldMoveLoopTransToBR_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ShouldMoveLoopTransToBR");
		ShouldMoveLoopTransToBR_ParamsSize = NativeReflection.GetFunctionParamsSize(ShouldMoveLoopTransToBR_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ShouldMoveLoopTransToBR_ReturnValue_PropertyAddress, ShouldMoveLoopTransToBR_FunctionAddress, "ReturnValue");
		ShouldMoveLoopTransToBR_ReturnValue_Offset = NativeReflection.GetPropertyOffset(ShouldMoveLoopTransToBR_FunctionAddress, "ReturnValue");
		ShouldMoveLoopTransToBR_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(ShouldMoveLoopTransToBR_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ShouldMoveLoopTransToBR_IsValid = ShouldMoveLoopTransToBR_FunctionAddress != IntPtr.Zero && ShouldMoveLoopTransToBR_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopTransToBR", ShouldMoveLoopTransToBR_IsValid);
		UpdateMoveLoopTransAnim_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateMoveLoopTransAnim");
		UpdateMoveLoopTransAnim_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateMoveLoopTransAnim_FunctionAddress);
		NativeReflection.GetPropertyRef(ref UpdateMoveLoopTransAnim_Context_PropertyAddress, UpdateMoveLoopTransAnim_FunctionAddress, "Context");
		UpdateMoveLoopTransAnim_Context_Offset = NativeReflection.GetPropertyOffset(UpdateMoveLoopTransAnim_FunctionAddress, "Context");
		UpdateMoveLoopTransAnim_Context_IsValid = NativeReflection.ValidatePropertyClass(UpdateMoveLoopTransAnim_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref UpdateMoveLoopTransAnim_Node_PropertyAddress, UpdateMoveLoopTransAnim_FunctionAddress, "Node");
		UpdateMoveLoopTransAnim_Node_Offset = NativeReflection.GetPropertyOffset(UpdateMoveLoopTransAnim_FunctionAddress, "Node");
		UpdateMoveLoopTransAnim_Node_IsValid = NativeReflection.ValidatePropertyClass(UpdateMoveLoopTransAnim_FunctionAddress, "Node", Classes.FStructProperty);
		UpdateMoveLoopTransAnim_IsValid = UpdateMoveLoopTransAnim_FunctionAddress != IntPtr.Zero && UpdateMoveLoopTransAnim_Context_IsValid && UpdateMoveLoopTransAnim_Node_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:UpdateMoveLoopTransAnim", UpdateMoveLoopTransAnim_IsValid);
		ShouldMoveLoopTransToBL_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ShouldMoveLoopTransToBL");
		ShouldMoveLoopTransToBL_ParamsSize = NativeReflection.GetFunctionParamsSize(ShouldMoveLoopTransToBL_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ShouldMoveLoopTransToBL_ReturnValue_PropertyAddress, ShouldMoveLoopTransToBL_FunctionAddress, "ReturnValue");
		ShouldMoveLoopTransToBL_ReturnValue_Offset = NativeReflection.GetPropertyOffset(ShouldMoveLoopTransToBL_FunctionAddress, "ReturnValue");
		ShouldMoveLoopTransToBL_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(ShouldMoveLoopTransToBL_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ShouldMoveLoopTransToBL_IsValid = ShouldMoveLoopTransToBL_FunctionAddress != IntPtr.Zero && ShouldMoveLoopTransToBL_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopTransToBL", ShouldMoveLoopTransToBL_IsValid);
		UpdateMoveLoopSimpleAnim_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateMoveLoopSimpleAnim");
		UpdateMoveLoopSimpleAnim_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateMoveLoopSimpleAnim_FunctionAddress);
		NativeReflection.GetPropertyRef(ref UpdateMoveLoopSimpleAnim_Context_PropertyAddress, UpdateMoveLoopSimpleAnim_FunctionAddress, "Context");
		UpdateMoveLoopSimpleAnim_Context_Offset = NativeReflection.GetPropertyOffset(UpdateMoveLoopSimpleAnim_FunctionAddress, "Context");
		UpdateMoveLoopSimpleAnim_Context_IsValid = NativeReflection.ValidatePropertyClass(UpdateMoveLoopSimpleAnim_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref UpdateMoveLoopSimpleAnim_Node_PropertyAddress, UpdateMoveLoopSimpleAnim_FunctionAddress, "Node");
		UpdateMoveLoopSimpleAnim_Node_Offset = NativeReflection.GetPropertyOffset(UpdateMoveLoopSimpleAnim_FunctionAddress, "Node");
		UpdateMoveLoopSimpleAnim_Node_IsValid = NativeReflection.ValidatePropertyClass(UpdateMoveLoopSimpleAnim_FunctionAddress, "Node", Classes.FStructProperty);
		UpdateMoveLoopSimpleAnim_IsValid = UpdateMoveLoopSimpleAnim_FunctionAddress != IntPtr.Zero && UpdateMoveLoopSimpleAnim_Context_IsValid && UpdateMoveLoopSimpleAnim_Node_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:UpdateMoveLoopSimpleAnim", UpdateMoveLoopSimpleAnim_IsValid);
		ShouldMoveTurnSwitchFree_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ShouldMoveTurnSwitchFree");
		ShouldMoveTurnSwitchFree_ParamsSize = NativeReflection.GetFunctionParamsSize(ShouldMoveTurnSwitchFree_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ShouldMoveTurnSwitchFree_ReturnValue_PropertyAddress, ShouldMoveTurnSwitchFree_FunctionAddress, "ReturnValue");
		ShouldMoveTurnSwitchFree_ReturnValue_Offset = NativeReflection.GetPropertyOffset(ShouldMoveTurnSwitchFree_FunctionAddress, "ReturnValue");
		ShouldMoveTurnSwitchFree_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(ShouldMoveTurnSwitchFree_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ShouldMoveTurnSwitchFree_IsValid = ShouldMoveTurnSwitchFree_FunctionAddress != IntPtr.Zero && ShouldMoveTurnSwitchFree_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveTurnSwitchFree", ShouldMoveTurnSwitchFree_IsValid);
		ShouldMoveTurnSwitchLock_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ShouldMoveTurnSwitchLock");
		ShouldMoveTurnSwitchLock_ParamsSize = NativeReflection.GetFunctionParamsSize(ShouldMoveTurnSwitchLock_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ShouldMoveTurnSwitchLock_ReturnValue_PropertyAddress, ShouldMoveTurnSwitchLock_FunctionAddress, "ReturnValue");
		ShouldMoveTurnSwitchLock_ReturnValue_Offset = NativeReflection.GetPropertyOffset(ShouldMoveTurnSwitchLock_FunctionAddress, "ReturnValue");
		ShouldMoveTurnSwitchLock_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(ShouldMoveTurnSwitchLock_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ShouldMoveTurnSwitchLock_IsValid = ShouldMoveTurnSwitchLock_FunctionAddress != IntPtr.Zero && ShouldMoveTurnSwitchLock_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveTurnSwitchLock", ShouldMoveTurnSwitchLock_IsValid);
		SetupMoveLoopAdditiveAnim_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetupMoveLoopAdditiveAnim");
		SetupMoveLoopAdditiveAnim_ParamsSize = NativeReflection.GetFunctionParamsSize(SetupMoveLoopAdditiveAnim_FunctionAddress);
		NativeReflection.GetPropertyRef(ref SetupMoveLoopAdditiveAnim_Context_PropertyAddress, SetupMoveLoopAdditiveAnim_FunctionAddress, "Context");
		SetupMoveLoopAdditiveAnim_Context_Offset = NativeReflection.GetPropertyOffset(SetupMoveLoopAdditiveAnim_FunctionAddress, "Context");
		SetupMoveLoopAdditiveAnim_Context_IsValid = NativeReflection.ValidatePropertyClass(SetupMoveLoopAdditiveAnim_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref SetupMoveLoopAdditiveAnim_Node_PropertyAddress, SetupMoveLoopAdditiveAnim_FunctionAddress, "Node");
		SetupMoveLoopAdditiveAnim_Node_Offset = NativeReflection.GetPropertyOffset(SetupMoveLoopAdditiveAnim_FunctionAddress, "Node");
		SetupMoveLoopAdditiveAnim_Node_IsValid = NativeReflection.ValidatePropertyClass(SetupMoveLoopAdditiveAnim_FunctionAddress, "Node", Classes.FStructProperty);
		SetupMoveLoopAdditiveAnim_IsValid = SetupMoveLoopAdditiveAnim_FunctionAddress != IntPtr.Zero && SetupMoveLoopAdditiveAnim_Context_IsValid && SetupMoveLoopAdditiveAnim_Node_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:SetupMoveLoopAdditiveAnim", SetupMoveLoopAdditiveAnim_IsValid);
		UpdateMoveLoopLB2LFOutput_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateMoveLoopLB2LFOutput");
		UpdateMoveLoopLB2LFOutput_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateMoveLoopLB2LFOutput_FunctionAddress);
		NativeReflection.GetPropertyRef(ref UpdateMoveLoopLB2LFOutput_Context_PropertyAddress, UpdateMoveLoopLB2LFOutput_FunctionAddress, "Context");
		UpdateMoveLoopLB2LFOutput_Context_Offset = NativeReflection.GetPropertyOffset(UpdateMoveLoopLB2LFOutput_FunctionAddress, "Context");
		UpdateMoveLoopLB2LFOutput_Context_IsValid = NativeReflection.ValidatePropertyClass(UpdateMoveLoopLB2LFOutput_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref UpdateMoveLoopLB2LFOutput_Node_PropertyAddress, UpdateMoveLoopLB2LFOutput_FunctionAddress, "Node");
		UpdateMoveLoopLB2LFOutput_Node_Offset = NativeReflection.GetPropertyOffset(UpdateMoveLoopLB2LFOutput_FunctionAddress, "Node");
		UpdateMoveLoopLB2LFOutput_Node_IsValid = NativeReflection.ValidatePropertyClass(UpdateMoveLoopLB2LFOutput_FunctionAddress, "Node", Classes.FStructProperty);
		UpdateMoveLoopLB2LFOutput_IsValid = UpdateMoveLoopLB2LFOutput_FunctionAddress != IntPtr.Zero && UpdateMoveLoopLB2LFOutput_Context_IsValid && UpdateMoveLoopLB2LFOutput_Node_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:UpdateMoveLoopLB2LFOutput", UpdateMoveLoopLB2LFOutput_IsValid);
		UpdateMoveLoopRB2RFOutput_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateMoveLoopRB2RFOutput");
		UpdateMoveLoopRB2RFOutput_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateMoveLoopRB2RFOutput_FunctionAddress);
		NativeReflection.GetPropertyRef(ref UpdateMoveLoopRB2RFOutput_Context_PropertyAddress, UpdateMoveLoopRB2RFOutput_FunctionAddress, "Context");
		UpdateMoveLoopRB2RFOutput_Context_Offset = NativeReflection.GetPropertyOffset(UpdateMoveLoopRB2RFOutput_FunctionAddress, "Context");
		UpdateMoveLoopRB2RFOutput_Context_IsValid = NativeReflection.ValidatePropertyClass(UpdateMoveLoopRB2RFOutput_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref UpdateMoveLoopRB2RFOutput_Node_PropertyAddress, UpdateMoveLoopRB2RFOutput_FunctionAddress, "Node");
		UpdateMoveLoopRB2RFOutput_Node_Offset = NativeReflection.GetPropertyOffset(UpdateMoveLoopRB2RFOutput_FunctionAddress, "Node");
		UpdateMoveLoopRB2RFOutput_Node_IsValid = NativeReflection.ValidatePropertyClass(UpdateMoveLoopRB2RFOutput_FunctionAddress, "Node", Classes.FStructProperty);
		UpdateMoveLoopRB2RFOutput_IsValid = UpdateMoveLoopRB2RFOutput_FunctionAddress != IntPtr.Zero && UpdateMoveLoopRB2RFOutput_Context_IsValid && UpdateMoveLoopRB2RFOutput_Node_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:UpdateMoveLoopRB2RFOutput", UpdateMoveLoopRB2RFOutput_IsValid);
		UpdateMoveLoopRF2RBOutput_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateMoveLoopRF2RBOutput");
		UpdateMoveLoopRF2RBOutput_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateMoveLoopRF2RBOutput_FunctionAddress);
		NativeReflection.GetPropertyRef(ref UpdateMoveLoopRF2RBOutput_Context_PropertyAddress, UpdateMoveLoopRF2RBOutput_FunctionAddress, "Context");
		UpdateMoveLoopRF2RBOutput_Context_Offset = NativeReflection.GetPropertyOffset(UpdateMoveLoopRF2RBOutput_FunctionAddress, "Context");
		UpdateMoveLoopRF2RBOutput_Context_IsValid = NativeReflection.ValidatePropertyClass(UpdateMoveLoopRF2RBOutput_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref UpdateMoveLoopRF2RBOutput_Node_PropertyAddress, UpdateMoveLoopRF2RBOutput_FunctionAddress, "Node");
		UpdateMoveLoopRF2RBOutput_Node_Offset = NativeReflection.GetPropertyOffset(UpdateMoveLoopRF2RBOutput_FunctionAddress, "Node");
		UpdateMoveLoopRF2RBOutput_Node_IsValid = NativeReflection.ValidatePropertyClass(UpdateMoveLoopRF2RBOutput_FunctionAddress, "Node", Classes.FStructProperty);
		UpdateMoveLoopRF2RBOutput_IsValid = UpdateMoveLoopRF2RBOutput_FunctionAddress != IntPtr.Zero && UpdateMoveLoopRF2RBOutput_Context_IsValid && UpdateMoveLoopRF2RBOutput_Node_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:UpdateMoveLoopRF2RBOutput", UpdateMoveLoopRF2RBOutput_IsValid);
		UpdateMoveLoopLF2LBOutput_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateMoveLoopLF2LBOutput");
		UpdateMoveLoopLF2LBOutput_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateMoveLoopLF2LBOutput_FunctionAddress);
		NativeReflection.GetPropertyRef(ref UpdateMoveLoopLF2LBOutput_Context_PropertyAddress, UpdateMoveLoopLF2LBOutput_FunctionAddress, "Context");
		UpdateMoveLoopLF2LBOutput_Context_Offset = NativeReflection.GetPropertyOffset(UpdateMoveLoopLF2LBOutput_FunctionAddress, "Context");
		UpdateMoveLoopLF2LBOutput_Context_IsValid = NativeReflection.ValidatePropertyClass(UpdateMoveLoopLF2LBOutput_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref UpdateMoveLoopLF2LBOutput_Node_PropertyAddress, UpdateMoveLoopLF2LBOutput_FunctionAddress, "Node");
		UpdateMoveLoopLF2LBOutput_Node_Offset = NativeReflection.GetPropertyOffset(UpdateMoveLoopLF2LBOutput_FunctionAddress, "Node");
		UpdateMoveLoopLF2LBOutput_Node_IsValid = NativeReflection.ValidatePropertyClass(UpdateMoveLoopLF2LBOutput_FunctionAddress, "Node", Classes.FStructProperty);
		UpdateMoveLoopLF2LBOutput_IsValid = UpdateMoveLoopLF2LBOutput_FunctionAddress != IntPtr.Zero && UpdateMoveLoopLF2LBOutput_Context_IsValid && UpdateMoveLoopLF2LBOutput_Node_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:UpdateMoveLoopLF2LBOutput", UpdateMoveLoopLF2LBOutput_IsValid);
		ShouldMoveLoopLeftTransBR_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ShouldMoveLoopLeftTransBR");
		ShouldMoveLoopLeftTransBR_ParamsSize = NativeReflection.GetFunctionParamsSize(ShouldMoveLoopLeftTransBR_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ShouldMoveLoopLeftTransBR_ReturnValue_PropertyAddress, ShouldMoveLoopLeftTransBR_FunctionAddress, "ReturnValue");
		ShouldMoveLoopLeftTransBR_ReturnValue_Offset = NativeReflection.GetPropertyOffset(ShouldMoveLoopLeftTransBR_FunctionAddress, "ReturnValue");
		ShouldMoveLoopLeftTransBR_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(ShouldMoveLoopLeftTransBR_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ShouldMoveLoopLeftTransBR_IsValid = ShouldMoveLoopLeftTransBR_FunctionAddress != IntPtr.Zero && ShouldMoveLoopLeftTransBR_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopLeftTransBR", ShouldMoveLoopLeftTransBR_IsValid);
		ShouldMoveLoopLeftTransFL_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ShouldMoveLoopLeftTransFL");
		ShouldMoveLoopLeftTransFL_ParamsSize = NativeReflection.GetFunctionParamsSize(ShouldMoveLoopLeftTransFL_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ShouldMoveLoopLeftTransFL_ReturnValue_PropertyAddress, ShouldMoveLoopLeftTransFL_FunctionAddress, "ReturnValue");
		ShouldMoveLoopLeftTransFL_ReturnValue_Offset = NativeReflection.GetPropertyOffset(ShouldMoveLoopLeftTransFL_FunctionAddress, "ReturnValue");
		ShouldMoveLoopLeftTransFL_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(ShouldMoveLoopLeftTransFL_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ShouldMoveLoopLeftTransFL_IsValid = ShouldMoveLoopLeftTransFL_FunctionAddress != IntPtr.Zero && ShouldMoveLoopLeftTransFL_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopLeftTransFL", ShouldMoveLoopLeftTransFL_IsValid);
		ShouldMoveLoopLeftTransBL_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ShouldMoveLoopLeftTransBL");
		ShouldMoveLoopLeftTransBL_ParamsSize = NativeReflection.GetFunctionParamsSize(ShouldMoveLoopLeftTransBL_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ShouldMoveLoopLeftTransBL_ReturnValue_PropertyAddress, ShouldMoveLoopLeftTransBL_FunctionAddress, "ReturnValue");
		ShouldMoveLoopLeftTransBL_ReturnValue_Offset = NativeReflection.GetPropertyOffset(ShouldMoveLoopLeftTransBL_FunctionAddress, "ReturnValue");
		ShouldMoveLoopLeftTransBL_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(ShouldMoveLoopLeftTransBL_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ShouldMoveLoopLeftTransBL_IsValid = ShouldMoveLoopLeftTransBL_FunctionAddress != IntPtr.Zero && ShouldMoveLoopLeftTransBL_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopLeftTransBL", ShouldMoveLoopLeftTransBL_IsValid);
		ShouldMoveLoopLeftTransFR_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ShouldMoveLoopLeftTransFR");
		ShouldMoveLoopLeftTransFR_ParamsSize = NativeReflection.GetFunctionParamsSize(ShouldMoveLoopLeftTransFR_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ShouldMoveLoopLeftTransFR_ReturnValue_PropertyAddress, ShouldMoveLoopLeftTransFR_FunctionAddress, "ReturnValue");
		ShouldMoveLoopLeftTransFR_ReturnValue_Offset = NativeReflection.GetPropertyOffset(ShouldMoveLoopLeftTransFR_FunctionAddress, "ReturnValue");
		ShouldMoveLoopLeftTransFR_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(ShouldMoveLoopLeftTransFR_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ShouldMoveLoopLeftTransFR_IsValid = ShouldMoveLoopLeftTransFR_FunctionAddress != IntPtr.Zero && ShouldMoveLoopLeftTransFR_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveLoopLeftTransFR", ShouldMoveLoopLeftTransFR_IsValid);
		UpdateMoveLoopStateMachine_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateMoveLoopStateMachine");
		UpdateMoveLoopStateMachine_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateMoveLoopStateMachine_FunctionAddress);
		NativeReflection.GetPropertyRef(ref UpdateMoveLoopStateMachine_Context_PropertyAddress, UpdateMoveLoopStateMachine_FunctionAddress, "Context");
		UpdateMoveLoopStateMachine_Context_Offset = NativeReflection.GetPropertyOffset(UpdateMoveLoopStateMachine_FunctionAddress, "Context");
		UpdateMoveLoopStateMachine_Context_IsValid = NativeReflection.ValidatePropertyClass(UpdateMoveLoopStateMachine_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref UpdateMoveLoopStateMachine_Node_PropertyAddress, UpdateMoveLoopStateMachine_FunctionAddress, "Node");
		UpdateMoveLoopStateMachine_Node_Offset = NativeReflection.GetPropertyOffset(UpdateMoveLoopStateMachine_FunctionAddress, "Node");
		UpdateMoveLoopStateMachine_Node_IsValid = NativeReflection.ValidatePropertyClass(UpdateMoveLoopStateMachine_FunctionAddress, "Node", Classes.FStructProperty);
		UpdateMoveLoopStateMachine_IsValid = UpdateMoveLoopStateMachine_FunctionAddress != IntPtr.Zero && UpdateMoveLoopStateMachine_Context_IsValid && UpdateMoveLoopStateMachine_Node_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:UpdateMoveLoopStateMachine", UpdateMoveLoopStateMachine_IsValid);
		ShouldMoveTurnSwitchLockToFree_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ShouldMoveTurnSwitchLockToFree");
		ShouldMoveTurnSwitchLockToFree_ParamsSize = NativeReflection.GetFunctionParamsSize(ShouldMoveTurnSwitchLockToFree_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ShouldMoveTurnSwitchLockToFree_ReturnValue_PropertyAddress, ShouldMoveTurnSwitchLockToFree_FunctionAddress, "ReturnValue");
		ShouldMoveTurnSwitchLockToFree_ReturnValue_Offset = NativeReflection.GetPropertyOffset(ShouldMoveTurnSwitchLockToFree_FunctionAddress, "ReturnValue");
		ShouldMoveTurnSwitchLockToFree_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(ShouldMoveTurnSwitchLockToFree_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ShouldMoveTurnSwitchLockToFree_IsValid = ShouldMoveTurnSwitchLockToFree_FunctionAddress != IntPtr.Zero && ShouldMoveTurnSwitchLockToFree_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_AdvancedMonsterLocomotion:ShouldMoveTurnSwitchLockToFree", ShouldMoveTurnSwitchLockToFree_IsValid);
	}

	static BUAnimHumanoidCS_AdvancedMonsterLocomotion()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUAnimHumanoidCS_AdvancedMonsterLocomotion)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUAnimHumanoidCS_AdvancedMonsterLocomotion));
	}
}
