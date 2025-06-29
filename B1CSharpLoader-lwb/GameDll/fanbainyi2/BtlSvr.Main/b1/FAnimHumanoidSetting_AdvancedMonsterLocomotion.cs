using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion")]
public struct FAnimHumanoidSetting_AdvancedMonsterLocomotion
{
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:FreeMode")]
	public ELMFreeMode FreeMode;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:LockMode")]
	public ELMLockMode LockMode;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:WalkMaxAcceleration")]
	public float WalkMaxAcceleration;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:WalkBrakingFriction")]
	public float WalkBrakingFriction;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:WalkBrakingDecelerationWalking")]
	public float WalkBrakingDecelerationWalking;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:RunMaxAcceleration")]
	public float RunMaxAcceleration;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:RunBrakingFriction")]
	public float RunBrakingFriction;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:RunBrakingDecelerationWalking")]
	public float RunBrakingDecelerationWalking;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:RushMaxAcceleration")]
	public float RushMaxAcceleration;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:RushBrakingFriction")]
	public float RushBrakingFriction;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:RushBrakingDecelerationWalking")]
	public float RushBrakingDecelerationWalking;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:StartAndTurnAnimPlayRateClamped")]
	public FVector2D StartAndTurnAnimPlayRateClamped;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:LoopAnimPlayRateClamped")]
	public FVector2D LoopAnimPlayRateClamped;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASIdleList")]
	public List<UAnimSequence> ASIdleList;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASWalkStartFwd")]
	public UAnimSequence ASWalkStartFwd;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASWalkStartBwd")]
	public UAnimSequence ASWalkStartBwd;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASWalkStartLeftMin")]
	public UAnimSequence ASWalkStartLeftMin;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASWalkStartLeftMax")]
	public UAnimSequence ASWalkStartLeftMax;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASWalkStartRightMin")]
	public UAnimSequence ASWalkStartRightMin;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASWalkStartRightMax")]
	public UAnimSequence ASWalkStartRightMax;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASWalkStartLF")]
	public UAnimSequence ASWalkStartLF;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASWalkStartLB")]
	public UAnimSequence ASWalkStartLB;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASWalkStartRF")]
	public UAnimSequence ASWalkStartRF;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASWalkStartRB")]
	public UAnimSequence ASWalkStartRB;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASWalkLoopFwd")]
	public UAnimSequence ASWalkLoopFwd;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASWalkLoopBwd")]
	public UAnimSequence ASWalkLoopBwd;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASWalkLoopLF")]
	public UAnimSequence ASWalkLoopLF;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASWalkLoopLB")]
	public UAnimSequence ASWalkLoopLB;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASWalkLoopRF")]
	public UAnimSequence ASWalkLoopRF;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASWalkLoopRB")]
	public UAnimSequence ASWalkLoopRB;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASWalkSharpturnLeftMin")]
	public UAnimSequence ASWalkSharpturnLeftMin;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASWalkSharpturnLeftMax")]
	public UAnimSequence ASWalkSharpturnLeftMax;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASWalkSharpturnRightMin")]
	public UAnimSequence ASWalkSharpturnRightMin;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASWalkSharpturnRightMax")]
	public UAnimSequence ASWalkSharpturnRightMax;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASWalkPivotFwd")]
	public UAnimSequence ASWalkPivotFwd;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASWalkPivotBwd")]
	public UAnimSequence ASWalkPivotBwd;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASWalkPivotLF")]
	public UAnimSequence ASWalkPivotLF;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASWalkPivotLB")]
	public UAnimSequence ASWalkPivotLB;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASWalkPivotRF")]
	public UAnimSequence ASWalkPivotRF;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASWalkPivotRB")]
	public UAnimSequence ASWalkPivotRB;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASWalkTransFRToBR")]
	public UAnimSequence ASWalkTransFRToBR;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASWalkTransBRToFR")]
	public UAnimSequence ASWalkTransBRToFR;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASWalkTransFLToBL")]
	public UAnimSequence ASWalkTransFLToBL;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASWalkTransBLToFL")]
	public UAnimSequence ASWalkTransBLToFL;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASWalkStopFwd")]
	public UAnimSequence ASWalkStopFwd;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASWalkStopBwd")]
	public UAnimSequence ASWalkStopBwd;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASWalkStopLF")]
	public UAnimSequence ASWalkStopLF;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASWalkStopLB")]
	public UAnimSequence ASWalkStopLB;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASWalkStopRF")]
	public UAnimSequence ASWalkStopRF;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASWalkStopRB")]
	public UAnimSequence ASWalkStopRB;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASWalkLoopAddPose")]
	public UAnimSequence ASWalkLoopAddPose;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASWalkLoopAdditiveList")]
	public List<UAnimSequence> ASWalkLoopAdditiveList;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASRunStartFwd")]
	public UAnimSequence ASRunStartFwd;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASRunStartBwd")]
	public UAnimSequence ASRunStartBwd;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASRunStartLeftMin")]
	public UAnimSequence ASRunStartLeftMin;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASRunStartLeftMax")]
	public UAnimSequence ASRunStartLeftMax;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASRunStartRightMin")]
	public UAnimSequence ASRunStartRightMin;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASRunStartRightMax")]
	public UAnimSequence ASRunStartRightMax;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASRunStartLF")]
	public UAnimSequence ASRunStartLF;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASRunStartLB")]
	public UAnimSequence ASRunStartLB;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASRunStartRF")]
	public UAnimSequence ASRunStartRF;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASRunStartRB")]
	public UAnimSequence ASRunStartRB;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASRunLoopFwd")]
	public UAnimSequence ASRunLoopFwd;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASRunLoopBwd")]
	public UAnimSequence ASRunLoopBwd;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASRunLoopLF")]
	public UAnimSequence ASRunLoopLF;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASRunLoopLB")]
	public UAnimSequence ASRunLoopLB;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASRunLoopRF")]
	public UAnimSequence ASRunLoopRF;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASRunLoopRB")]
	public UAnimSequence ASRunLoopRB;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASRunSharpturnLeftMin")]
	public UAnimSequence ASRunSharpturnLeftMin;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASRunSharpturnLeftMax")]
	public UAnimSequence ASRunSharpturnLeftMax;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASRunSharpturnRightMin")]
	public UAnimSequence ASRunSharpturnRightMin;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASRunSharpturnRightMax")]
	public UAnimSequence ASRunSharpturnRightMax;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASRunPivotFwd")]
	public UAnimSequence ASRunPivotFwd;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASRunPivotBwd")]
	public UAnimSequence ASRunPivotBwd;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASRunPivotLF")]
	public UAnimSequence ASRunPivotLF;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASRunPivotLB")]
	public UAnimSequence ASRunPivotLB;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASRunPivotRF")]
	public UAnimSequence ASRunPivotRF;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASRunPivotRB")]
	public UAnimSequence ASRunPivotRB;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASRunTransFRToBR")]
	public UAnimSequence ASRunTransFRToBR;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASRunTransBRToFR")]
	public UAnimSequence ASRunTransBRToFR;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASRunTransFLToBL")]
	public UAnimSequence ASRunTransFLToBL;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASRunTransBLToFL")]
	public UAnimSequence ASRunTransBLToFL;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASRunStopFwd")]
	public UAnimSequence ASRunStopFwd;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASRunStopBwd")]
	public UAnimSequence ASRunStopBwd;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASRunStopLF")]
	public UAnimSequence ASRunStopLF;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASRunStopLB")]
	public UAnimSequence ASRunStopLB;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASRunStopRF")]
	public UAnimSequence ASRunStopRF;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASRunStopRB")]
	public UAnimSequence ASRunStopRB;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASRunLoopAddPose")]
	public UAnimSequence ASRunLoopAddPose;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASRunLoopAdditiveList")]
	public List<UAnimSequence> ASRunLoopAdditiveList;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASRushStartFwd")]
	public UAnimSequence ASRushStartFwd;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASRushStartLeftMin")]
	public UAnimSequence ASRushStartLeftMin;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASRushStartLeftMax")]
	public UAnimSequence ASRushStartLeftMax;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASRushStartRightMin")]
	public UAnimSequence ASRushStartRightMin;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASRushStartRightMax")]
	public UAnimSequence ASRushStartRightMax;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASRushLoopFwd")]
	public UAnimSequence ASRushLoopFwd;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASRushSharpturnLeftMin")]
	public UAnimSequence ASRushSharpturnLeftMin;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASRushSharpturnLeftMax")]
	public UAnimSequence ASRushSharpturnLeftMax;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASRushSharpturnRightMin")]
	public UAnimSequence ASRushSharpturnRightMin;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASRushSharpturnRightMax")]
	public UAnimSequence ASRushSharpturnRightMax;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASRushStopFwd")]
	public UAnimSequence ASRushStopFwd;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASRushLoopAddPose")]
	public UAnimSequence ASRushLoopAddPose;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion:ASRushLoopAdditiveList")]
	public List<UAnimSequence> ASRushLoopAdditiveList;

	private static int AnimHumanoidSetting_AdvancedMonsterLocomotion_StructSize;

	private static int AnimHumanoidSetting_AdvancedMonsterLocomotion_IsValid;

	private static bool FreeMode_IsValid;

	private static int FreeMode_Offset;

	private static FFieldAddress FreeMode_PropertyAddress;

	private static bool LockMode_IsValid;

	private static int LockMode_Offset;

	private static FFieldAddress LockMode_PropertyAddress;

	private static bool WalkMaxAcceleration_IsValid;

	private static int WalkMaxAcceleration_Offset;

	private static bool WalkBrakingFriction_IsValid;

	private static int WalkBrakingFriction_Offset;

	private static bool WalkBrakingDecelerationWalking_IsValid;

	private static int WalkBrakingDecelerationWalking_Offset;

	private static bool RunMaxAcceleration_IsValid;

	private static int RunMaxAcceleration_Offset;

	private static bool RunBrakingFriction_IsValid;

	private static int RunBrakingFriction_Offset;

	private static bool RunBrakingDecelerationWalking_IsValid;

	private static int RunBrakingDecelerationWalking_Offset;

	private static bool RushMaxAcceleration_IsValid;

	private static int RushMaxAcceleration_Offset;

	private static bool RushBrakingFriction_IsValid;

	private static int RushBrakingFriction_Offset;

	private static bool RushBrakingDecelerationWalking_IsValid;

	private static int RushBrakingDecelerationWalking_Offset;

	private static bool StartAndTurnAnimPlayRateClamped_IsValid;

	private static int StartAndTurnAnimPlayRateClamped_Offset;

	private static bool LoopAnimPlayRateClamped_IsValid;

	private static int LoopAnimPlayRateClamped_Offset;

	private static bool ASIdleList_IsValid;

	private static int ASIdleList_Offset;

	private static FFieldAddress ASIdleList_PropertyAddress;

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

	public FAnimHumanoidSetting_AdvancedMonsterLocomotion Copy()
	{
		FAnimHumanoidSetting_AdvancedMonsterLocomotion result = this;
		if (ASIdleList != null)
		{
			result.ASIdleList = new List<UAnimSequence>(ASIdleList);
		}
		if (ASWalkLoopAdditiveList != null)
		{
			result.ASWalkLoopAdditiveList = new List<UAnimSequence>(ASWalkLoopAdditiveList);
		}
		if (ASRunLoopAdditiveList != null)
		{
			result.ASRunLoopAdditiveList = new List<UAnimSequence>(ASRunLoopAdditiveList);
		}
		if (ASRushLoopAdditiveList != null)
		{
			result.ASRushLoopAdditiveList = new List<UAnimSequence>(ASRushLoopAdditiveList);
		}
		return result;
	}

	public static FAnimHumanoidSetting_AdvancedMonsterLocomotion FromNative(IntPtr nativeBuffer)
	{
		return new FAnimHumanoidSetting_AdvancedMonsterLocomotion(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimHumanoidSetting_AdvancedMonsterLocomotion value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimHumanoidSetting_AdvancedMonsterLocomotion FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimHumanoidSetting_AdvancedMonsterLocomotion(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_AdvancedMonsterLocomotion_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimHumanoidSetting_AdvancedMonsterLocomotion value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_AdvancedMonsterLocomotion_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_AdvancedMonsterLocomotion_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion");
			return;
		}
		EnumMarshaler<ELMFreeMode>.ToNative(IntPtr.Add(nativeStruct, FreeMode_Offset), 0, FreeMode_PropertyAddress.Address, FreeMode);
		EnumMarshaler<ELMLockMode>.ToNative(IntPtr.Add(nativeStruct, LockMode_Offset), 0, LockMode_PropertyAddress.Address, LockMode);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, WalkMaxAcceleration_Offset), WalkMaxAcceleration);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, WalkBrakingFriction_Offset), WalkBrakingFriction);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, WalkBrakingDecelerationWalking_Offset), WalkBrakingDecelerationWalking);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, RunMaxAcceleration_Offset), RunMaxAcceleration);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, RunBrakingFriction_Offset), RunBrakingFriction);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, RunBrakingDecelerationWalking_Offset), RunBrakingDecelerationWalking);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, RushMaxAcceleration_Offset), RushMaxAcceleration);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, RushBrakingFriction_Offset), RushBrakingFriction);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, RushBrakingDecelerationWalking_Offset), RushBrakingDecelerationWalking);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, StartAndTurnAnimPlayRateClamped_Offset), StartAndTurnAnimPlayRateClamped);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, LoopAnimPlayRateClamped_Offset), LoopAnimPlayRateClamped);
		new TArrayCopyMarshaler<UAnimSequence>(1, ASIdleList_PropertyAddress, CachedMarshalingDelegates<UAnimSequence, UObjectMarshaler<UAnimSequence>>.FromNative, CachedMarshalingDelegates<UAnimSequence, UObjectMarshaler<UAnimSequence>>.ToNative).ToNative(IntPtr.Add(nativeStruct, ASIdleList_Offset), ASIdleList);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASWalkStartFwd_Offset), ASWalkStartFwd);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASWalkStartBwd_Offset), ASWalkStartBwd);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASWalkStartLeftMin_Offset), ASWalkStartLeftMin);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASWalkStartLeftMax_Offset), ASWalkStartLeftMax);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASWalkStartRightMin_Offset), ASWalkStartRightMin);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASWalkStartRightMax_Offset), ASWalkStartRightMax);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASWalkStartLF_Offset), ASWalkStartLF);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASWalkStartLB_Offset), ASWalkStartLB);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASWalkStartRF_Offset), ASWalkStartRF);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASWalkStartRB_Offset), ASWalkStartRB);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASWalkLoopFwd_Offset), ASWalkLoopFwd);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASWalkLoopBwd_Offset), ASWalkLoopBwd);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASWalkLoopLF_Offset), ASWalkLoopLF);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASWalkLoopLB_Offset), ASWalkLoopLB);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASWalkLoopRF_Offset), ASWalkLoopRF);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASWalkLoopRB_Offset), ASWalkLoopRB);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASWalkSharpturnLeftMin_Offset), ASWalkSharpturnLeftMin);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASWalkSharpturnLeftMax_Offset), ASWalkSharpturnLeftMax);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASWalkSharpturnRightMin_Offset), ASWalkSharpturnRightMin);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASWalkSharpturnRightMax_Offset), ASWalkSharpturnRightMax);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASWalkPivotFwd_Offset), ASWalkPivotFwd);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASWalkPivotBwd_Offset), ASWalkPivotBwd);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASWalkPivotLF_Offset), ASWalkPivotLF);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASWalkPivotLB_Offset), ASWalkPivotLB);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASWalkPivotRF_Offset), ASWalkPivotRF);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASWalkPivotRB_Offset), ASWalkPivotRB);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASWalkTransFRToBR_Offset), ASWalkTransFRToBR);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASWalkTransBRToFR_Offset), ASWalkTransBRToFR);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASWalkTransFLToBL_Offset), ASWalkTransFLToBL);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASWalkTransBLToFL_Offset), ASWalkTransBLToFL);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASWalkStopFwd_Offset), ASWalkStopFwd);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASWalkStopBwd_Offset), ASWalkStopBwd);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASWalkStopLF_Offset), ASWalkStopLF);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASWalkStopLB_Offset), ASWalkStopLB);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASWalkStopRF_Offset), ASWalkStopRF);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASWalkStopRB_Offset), ASWalkStopRB);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASWalkLoopAddPose_Offset), ASWalkLoopAddPose);
		new TArrayCopyMarshaler<UAnimSequence>(1, ASWalkLoopAdditiveList_PropertyAddress, CachedMarshalingDelegates<UAnimSequence, UObjectMarshaler<UAnimSequence>>.FromNative, CachedMarshalingDelegates<UAnimSequence, UObjectMarshaler<UAnimSequence>>.ToNative).ToNative(IntPtr.Add(nativeStruct, ASWalkLoopAdditiveList_Offset), ASWalkLoopAdditiveList);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunStartFwd_Offset), ASRunStartFwd);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunStartBwd_Offset), ASRunStartBwd);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunStartLeftMin_Offset), ASRunStartLeftMin);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunStartLeftMax_Offset), ASRunStartLeftMax);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunStartRightMin_Offset), ASRunStartRightMin);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunStartRightMax_Offset), ASRunStartRightMax);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunStartLF_Offset), ASRunStartLF);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunStartLB_Offset), ASRunStartLB);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunStartRF_Offset), ASRunStartRF);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunStartRB_Offset), ASRunStartRB);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunLoopFwd_Offset), ASRunLoopFwd);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunLoopBwd_Offset), ASRunLoopBwd);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunLoopLF_Offset), ASRunLoopLF);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunLoopLB_Offset), ASRunLoopLB);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunLoopRF_Offset), ASRunLoopRF);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunLoopRB_Offset), ASRunLoopRB);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunSharpturnLeftMin_Offset), ASRunSharpturnLeftMin);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunSharpturnLeftMax_Offset), ASRunSharpturnLeftMax);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunSharpturnRightMin_Offset), ASRunSharpturnRightMin);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunSharpturnRightMax_Offset), ASRunSharpturnRightMax);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunPivotFwd_Offset), ASRunPivotFwd);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunPivotBwd_Offset), ASRunPivotBwd);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunPivotLF_Offset), ASRunPivotLF);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunPivotLB_Offset), ASRunPivotLB);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunPivotRF_Offset), ASRunPivotRF);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunPivotRB_Offset), ASRunPivotRB);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunTransFRToBR_Offset), ASRunTransFRToBR);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunTransBRToFR_Offset), ASRunTransBRToFR);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunTransFLToBL_Offset), ASRunTransFLToBL);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunTransBLToFL_Offset), ASRunTransBLToFL);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunStopFwd_Offset), ASRunStopFwd);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunStopBwd_Offset), ASRunStopBwd);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunStopLF_Offset), ASRunStopLF);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunStopLB_Offset), ASRunStopLB);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunStopRF_Offset), ASRunStopRF);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunStopRB_Offset), ASRunStopRB);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunLoopAddPose_Offset), ASRunLoopAddPose);
		new TArrayCopyMarshaler<UAnimSequence>(1, ASRunLoopAdditiveList_PropertyAddress, CachedMarshalingDelegates<UAnimSequence, UObjectMarshaler<UAnimSequence>>.FromNative, CachedMarshalingDelegates<UAnimSequence, UObjectMarshaler<UAnimSequence>>.ToNative).ToNative(IntPtr.Add(nativeStruct, ASRunLoopAdditiveList_Offset), ASRunLoopAdditiveList);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRushStartFwd_Offset), ASRushStartFwd);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRushStartLeftMin_Offset), ASRushStartLeftMin);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRushStartLeftMax_Offset), ASRushStartLeftMax);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRushStartRightMin_Offset), ASRushStartRightMin);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRushStartRightMax_Offset), ASRushStartRightMax);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRushLoopFwd_Offset), ASRushLoopFwd);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRushSharpturnLeftMin_Offset), ASRushSharpturnLeftMin);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRushSharpturnLeftMax_Offset), ASRushSharpturnLeftMax);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRushSharpturnRightMin_Offset), ASRushSharpturnRightMin);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRushSharpturnRightMax_Offset), ASRushSharpturnRightMax);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRushStopFwd_Offset), ASRushStopFwd);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRushLoopAddPose_Offset), ASRushLoopAddPose);
		new TArrayCopyMarshaler<UAnimSequence>(1, ASRushLoopAdditiveList_PropertyAddress, CachedMarshalingDelegates<UAnimSequence, UObjectMarshaler<UAnimSequence>>.FromNative, CachedMarshalingDelegates<UAnimSequence, UObjectMarshaler<UAnimSequence>>.ToNative).ToNative(IntPtr.Add(nativeStruct, ASRushLoopAdditiveList_Offset), ASRushLoopAdditiveList);
	}

	public FAnimHumanoidSetting_AdvancedMonsterLocomotion(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_AdvancedMonsterLocomotion_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion");
			FreeMode = ELMFreeMode.Normal;
			LockMode = ELMLockMode.Normal;
			WalkMaxAcceleration = 0f;
			WalkBrakingFriction = 0f;
			WalkBrakingDecelerationWalking = 0f;
			RunMaxAcceleration = 0f;
			RunBrakingFriction = 0f;
			RunBrakingDecelerationWalking = 0f;
			RushMaxAcceleration = 0f;
			RushBrakingFriction = 0f;
			RushBrakingDecelerationWalking = 0f;
			StartAndTurnAnimPlayRateClamped = default(FVector2D);
			LoopAnimPlayRateClamped = default(FVector2D);
			ASIdleList = null;
			ASWalkStartFwd = null;
			ASWalkStartBwd = null;
			ASWalkStartLeftMin = null;
			ASWalkStartLeftMax = null;
			ASWalkStartRightMin = null;
			ASWalkStartRightMax = null;
			ASWalkStartLF = null;
			ASWalkStartLB = null;
			ASWalkStartRF = null;
			ASWalkStartRB = null;
			ASWalkLoopFwd = null;
			ASWalkLoopBwd = null;
			ASWalkLoopLF = null;
			ASWalkLoopLB = null;
			ASWalkLoopRF = null;
			ASWalkLoopRB = null;
			ASWalkSharpturnLeftMin = null;
			ASWalkSharpturnLeftMax = null;
			ASWalkSharpturnRightMin = null;
			ASWalkSharpturnRightMax = null;
			ASWalkPivotFwd = null;
			ASWalkPivotBwd = null;
			ASWalkPivotLF = null;
			ASWalkPivotLB = null;
			ASWalkPivotRF = null;
			ASWalkPivotRB = null;
			ASWalkTransFRToBR = null;
			ASWalkTransBRToFR = null;
			ASWalkTransFLToBL = null;
			ASWalkTransBLToFL = null;
			ASWalkStopFwd = null;
			ASWalkStopBwd = null;
			ASWalkStopLF = null;
			ASWalkStopLB = null;
			ASWalkStopRF = null;
			ASWalkStopRB = null;
			ASWalkLoopAddPose = null;
			ASWalkLoopAdditiveList = null;
			ASRunStartFwd = null;
			ASRunStartBwd = null;
			ASRunStartLeftMin = null;
			ASRunStartLeftMax = null;
			ASRunStartRightMin = null;
			ASRunStartRightMax = null;
			ASRunStartLF = null;
			ASRunStartLB = null;
			ASRunStartRF = null;
			ASRunStartRB = null;
			ASRunLoopFwd = null;
			ASRunLoopBwd = null;
			ASRunLoopLF = null;
			ASRunLoopLB = null;
			ASRunLoopRF = null;
			ASRunLoopRB = null;
			ASRunSharpturnLeftMin = null;
			ASRunSharpturnLeftMax = null;
			ASRunSharpturnRightMin = null;
			ASRunSharpturnRightMax = null;
			ASRunPivotFwd = null;
			ASRunPivotBwd = null;
			ASRunPivotLF = null;
			ASRunPivotLB = null;
			ASRunPivotRF = null;
			ASRunPivotRB = null;
			ASRunTransFRToBR = null;
			ASRunTransBRToFR = null;
			ASRunTransFLToBL = null;
			ASRunTransBLToFL = null;
			ASRunStopFwd = null;
			ASRunStopBwd = null;
			ASRunStopLF = null;
			ASRunStopLB = null;
			ASRunStopRF = null;
			ASRunStopRB = null;
			ASRunLoopAddPose = null;
			ASRunLoopAdditiveList = null;
			ASRushStartFwd = null;
			ASRushStartLeftMin = null;
			ASRushStartLeftMax = null;
			ASRushStartRightMin = null;
			ASRushStartRightMax = null;
			ASRushLoopFwd = null;
			ASRushSharpturnLeftMin = null;
			ASRushSharpturnLeftMax = null;
			ASRushSharpturnRightMin = null;
			ASRushSharpturnRightMax = null;
			ASRushStopFwd = null;
			ASRushLoopAddPose = null;
			ASRushLoopAdditiveList = null;
		}
		else
		{
			FreeMode = EnumMarshaler<ELMFreeMode>.FromNative(IntPtr.Add(nativeStruct, FreeMode_Offset), 0, FreeMode_PropertyAddress.Address);
			LockMode = EnumMarshaler<ELMLockMode>.FromNative(IntPtr.Add(nativeStruct, LockMode_Offset), 0, LockMode_PropertyAddress.Address);
			WalkMaxAcceleration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, WalkMaxAcceleration_Offset));
			WalkBrakingFriction = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, WalkBrakingFriction_Offset));
			WalkBrakingDecelerationWalking = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, WalkBrakingDecelerationWalking_Offset));
			RunMaxAcceleration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, RunMaxAcceleration_Offset));
			RunBrakingFriction = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, RunBrakingFriction_Offset));
			RunBrakingDecelerationWalking = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, RunBrakingDecelerationWalking_Offset));
			RushMaxAcceleration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, RushMaxAcceleration_Offset));
			RushBrakingFriction = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, RushBrakingFriction_Offset));
			RushBrakingDecelerationWalking = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, RushBrakingDecelerationWalking_Offset));
			StartAndTurnAnimPlayRateClamped = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, StartAndTurnAnimPlayRateClamped_Offset));
			LoopAnimPlayRateClamped = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, LoopAnimPlayRateClamped_Offset));
			ASIdleList = new TArrayCopyMarshaler<UAnimSequence>(1, ASIdleList_PropertyAddress, CachedMarshalingDelegates<UAnimSequence, UObjectMarshaler<UAnimSequence>>.FromNative, CachedMarshalingDelegates<UAnimSequence, UObjectMarshaler<UAnimSequence>>.ToNative).FromNative(IntPtr.Add(nativeStruct, ASIdleList_Offset));
			ASWalkStartFwd = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASWalkStartFwd_Offset));
			ASWalkStartBwd = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASWalkStartBwd_Offset));
			ASWalkStartLeftMin = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASWalkStartLeftMin_Offset));
			ASWalkStartLeftMax = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASWalkStartLeftMax_Offset));
			ASWalkStartRightMin = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASWalkStartRightMin_Offset));
			ASWalkStartRightMax = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASWalkStartRightMax_Offset));
			ASWalkStartLF = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASWalkStartLF_Offset));
			ASWalkStartLB = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASWalkStartLB_Offset));
			ASWalkStartRF = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASWalkStartRF_Offset));
			ASWalkStartRB = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASWalkStartRB_Offset));
			ASWalkLoopFwd = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASWalkLoopFwd_Offset));
			ASWalkLoopBwd = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASWalkLoopBwd_Offset));
			ASWalkLoopLF = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASWalkLoopLF_Offset));
			ASWalkLoopLB = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASWalkLoopLB_Offset));
			ASWalkLoopRF = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASWalkLoopRF_Offset));
			ASWalkLoopRB = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASWalkLoopRB_Offset));
			ASWalkSharpturnLeftMin = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASWalkSharpturnLeftMin_Offset));
			ASWalkSharpturnLeftMax = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASWalkSharpturnLeftMax_Offset));
			ASWalkSharpturnRightMin = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASWalkSharpturnRightMin_Offset));
			ASWalkSharpturnRightMax = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASWalkSharpturnRightMax_Offset));
			ASWalkPivotFwd = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASWalkPivotFwd_Offset));
			ASWalkPivotBwd = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASWalkPivotBwd_Offset));
			ASWalkPivotLF = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASWalkPivotLF_Offset));
			ASWalkPivotLB = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASWalkPivotLB_Offset));
			ASWalkPivotRF = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASWalkPivotRF_Offset));
			ASWalkPivotRB = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASWalkPivotRB_Offset));
			ASWalkTransFRToBR = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASWalkTransFRToBR_Offset));
			ASWalkTransBRToFR = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASWalkTransBRToFR_Offset));
			ASWalkTransFLToBL = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASWalkTransFLToBL_Offset));
			ASWalkTransBLToFL = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASWalkTransBLToFL_Offset));
			ASWalkStopFwd = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASWalkStopFwd_Offset));
			ASWalkStopBwd = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASWalkStopBwd_Offset));
			ASWalkStopLF = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASWalkStopLF_Offset));
			ASWalkStopLB = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASWalkStopLB_Offset));
			ASWalkStopRF = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASWalkStopRF_Offset));
			ASWalkStopRB = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASWalkStopRB_Offset));
			ASWalkLoopAddPose = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASWalkLoopAddPose_Offset));
			ASWalkLoopAdditiveList = new TArrayCopyMarshaler<UAnimSequence>(1, ASWalkLoopAdditiveList_PropertyAddress, CachedMarshalingDelegates<UAnimSequence, UObjectMarshaler<UAnimSequence>>.FromNative, CachedMarshalingDelegates<UAnimSequence, UObjectMarshaler<UAnimSequence>>.ToNative).FromNative(IntPtr.Add(nativeStruct, ASWalkLoopAdditiveList_Offset));
			ASRunStartFwd = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunStartFwd_Offset));
			ASRunStartBwd = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunStartBwd_Offset));
			ASRunStartLeftMin = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunStartLeftMin_Offset));
			ASRunStartLeftMax = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunStartLeftMax_Offset));
			ASRunStartRightMin = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunStartRightMin_Offset));
			ASRunStartRightMax = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunStartRightMax_Offset));
			ASRunStartLF = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunStartLF_Offset));
			ASRunStartLB = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunStartLB_Offset));
			ASRunStartRF = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunStartRF_Offset));
			ASRunStartRB = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunStartRB_Offset));
			ASRunLoopFwd = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunLoopFwd_Offset));
			ASRunLoopBwd = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunLoopBwd_Offset));
			ASRunLoopLF = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunLoopLF_Offset));
			ASRunLoopLB = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunLoopLB_Offset));
			ASRunLoopRF = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunLoopRF_Offset));
			ASRunLoopRB = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunLoopRB_Offset));
			ASRunSharpturnLeftMin = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunSharpturnLeftMin_Offset));
			ASRunSharpturnLeftMax = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunSharpturnLeftMax_Offset));
			ASRunSharpturnRightMin = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunSharpturnRightMin_Offset));
			ASRunSharpturnRightMax = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunSharpturnRightMax_Offset));
			ASRunPivotFwd = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunPivotFwd_Offset));
			ASRunPivotBwd = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunPivotBwd_Offset));
			ASRunPivotLF = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunPivotLF_Offset));
			ASRunPivotLB = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunPivotLB_Offset));
			ASRunPivotRF = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunPivotRF_Offset));
			ASRunPivotRB = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunPivotRB_Offset));
			ASRunTransFRToBR = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunTransFRToBR_Offset));
			ASRunTransBRToFR = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunTransBRToFR_Offset));
			ASRunTransFLToBL = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunTransFLToBL_Offset));
			ASRunTransBLToFL = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunTransBLToFL_Offset));
			ASRunStopFwd = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunStopFwd_Offset));
			ASRunStopBwd = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunStopBwd_Offset));
			ASRunStopLF = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunStopLF_Offset));
			ASRunStopLB = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunStopLB_Offset));
			ASRunStopRF = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunStopRF_Offset));
			ASRunStopRB = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunStopRB_Offset));
			ASRunLoopAddPose = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunLoopAddPose_Offset));
			ASRunLoopAdditiveList = new TArrayCopyMarshaler<UAnimSequence>(1, ASRunLoopAdditiveList_PropertyAddress, CachedMarshalingDelegates<UAnimSequence, UObjectMarshaler<UAnimSequence>>.FromNative, CachedMarshalingDelegates<UAnimSequence, UObjectMarshaler<UAnimSequence>>.ToNative).FromNative(IntPtr.Add(nativeStruct, ASRunLoopAdditiveList_Offset));
			ASRushStartFwd = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRushStartFwd_Offset));
			ASRushStartLeftMin = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRushStartLeftMin_Offset));
			ASRushStartLeftMax = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRushStartLeftMax_Offset));
			ASRushStartRightMin = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRushStartRightMin_Offset));
			ASRushStartRightMax = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRushStartRightMax_Offset));
			ASRushLoopFwd = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRushLoopFwd_Offset));
			ASRushSharpturnLeftMin = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRushSharpturnLeftMin_Offset));
			ASRushSharpturnLeftMax = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRushSharpturnLeftMax_Offset));
			ASRushSharpturnRightMin = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRushSharpturnRightMin_Offset));
			ASRushSharpturnRightMax = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRushSharpturnRightMax_Offset));
			ASRushStopFwd = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRushStopFwd_Offset));
			ASRushLoopAddPose = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRushLoopAddPose_Offset));
			ASRushLoopAdditiveList = new TArrayCopyMarshaler<UAnimSequence>(1, ASRushLoopAdditiveList_PropertyAddress, CachedMarshalingDelegates<UAnimSequence, UObjectMarshaler<UAnimSequence>>.FromNative, CachedMarshalingDelegates<UAnimSequence, UObjectMarshaler<UAnimSequence>>.ToNative).FromNative(IntPtr.Add(nativeStruct, ASRushLoopAdditiveList_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion");
		AnimHumanoidSetting_AdvancedMonsterLocomotion_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref FreeMode_PropertyAddress, intPtr, "FreeMode");
		FreeMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "FreeMode");
		FreeMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FreeMode", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref LockMode_PropertyAddress, intPtr, "LockMode");
		LockMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "LockMode");
		LockMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LockMode", Classes.FEnumProperty);
		WalkMaxAcceleration_Offset = NativeReflection.GetPropertyOffset(intPtr, "WalkMaxAcceleration");
		WalkMaxAcceleration_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WalkMaxAcceleration", Classes.FFloatProperty);
		WalkBrakingFriction_Offset = NativeReflection.GetPropertyOffset(intPtr, "WalkBrakingFriction");
		WalkBrakingFriction_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WalkBrakingFriction", Classes.FFloatProperty);
		WalkBrakingDecelerationWalking_Offset = NativeReflection.GetPropertyOffset(intPtr, "WalkBrakingDecelerationWalking");
		WalkBrakingDecelerationWalking_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WalkBrakingDecelerationWalking", Classes.FFloatProperty);
		RunMaxAcceleration_Offset = NativeReflection.GetPropertyOffset(intPtr, "RunMaxAcceleration");
		RunMaxAcceleration_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RunMaxAcceleration", Classes.FFloatProperty);
		RunBrakingFriction_Offset = NativeReflection.GetPropertyOffset(intPtr, "RunBrakingFriction");
		RunBrakingFriction_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RunBrakingFriction", Classes.FFloatProperty);
		RunBrakingDecelerationWalking_Offset = NativeReflection.GetPropertyOffset(intPtr, "RunBrakingDecelerationWalking");
		RunBrakingDecelerationWalking_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RunBrakingDecelerationWalking", Classes.FFloatProperty);
		RushMaxAcceleration_Offset = NativeReflection.GetPropertyOffset(intPtr, "RushMaxAcceleration");
		RushMaxAcceleration_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RushMaxAcceleration", Classes.FFloatProperty);
		RushBrakingFriction_Offset = NativeReflection.GetPropertyOffset(intPtr, "RushBrakingFriction");
		RushBrakingFriction_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RushBrakingFriction", Classes.FFloatProperty);
		RushBrakingDecelerationWalking_Offset = NativeReflection.GetPropertyOffset(intPtr, "RushBrakingDecelerationWalking");
		RushBrakingDecelerationWalking_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RushBrakingDecelerationWalking", Classes.FFloatProperty);
		StartAndTurnAnimPlayRateClamped_Offset = NativeReflection.GetPropertyOffset(intPtr, "StartAndTurnAnimPlayRateClamped");
		StartAndTurnAnimPlayRateClamped_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StartAndTurnAnimPlayRateClamped", Classes.FStructProperty);
		LoopAnimPlayRateClamped_Offset = NativeReflection.GetPropertyOffset(intPtr, "LoopAnimPlayRateClamped");
		LoopAnimPlayRateClamped_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LoopAnimPlayRateClamped", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref ASIdleList_PropertyAddress, intPtr, "ASIdleList");
		ASIdleList_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASIdleList");
		ASIdleList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASIdleList", Classes.FArrayProperty);
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
		AnimHumanoidSetting_AdvancedMonsterLocomotion_IsValid = ((intPtr != IntPtr.Zero && FreeMode_IsValid && LockMode_IsValid && WalkMaxAcceleration_IsValid && WalkBrakingFriction_IsValid && WalkBrakingDecelerationWalking_IsValid && RunMaxAcceleration_IsValid && RunBrakingFriction_IsValid && RunBrakingDecelerationWalking_IsValid && RushMaxAcceleration_IsValid && RushBrakingFriction_IsValid && RushBrakingDecelerationWalking_IsValid && StartAndTurnAnimPlayRateClamped_IsValid && LoopAnimPlayRateClamped_IsValid && ASIdleList_IsValid && ASWalkStartFwd_IsValid && ASWalkStartBwd_IsValid && ASWalkStartLeftMin_IsValid && ASWalkStartLeftMax_IsValid && ASWalkStartRightMin_IsValid && ASWalkStartRightMax_IsValid && ASWalkStartLF_IsValid && ASWalkStartLB_IsValid && ASWalkStartRF_IsValid && ASWalkStartRB_IsValid && ASWalkLoopFwd_IsValid && ASWalkLoopBwd_IsValid && ASWalkLoopLF_IsValid && ASWalkLoopLB_IsValid && ASWalkLoopRF_IsValid && ASWalkLoopRB_IsValid && ASWalkSharpturnLeftMin_IsValid && ASWalkSharpturnLeftMax_IsValid && ASWalkSharpturnRightMin_IsValid && ASWalkSharpturnRightMax_IsValid && ASWalkPivotFwd_IsValid && ASWalkPivotBwd_IsValid && ASWalkPivotLF_IsValid && ASWalkPivotLB_IsValid && ASWalkPivotRF_IsValid && ASWalkPivotRB_IsValid && ASWalkTransFRToBR_IsValid && ASWalkTransBRToFR_IsValid && ASWalkTransFLToBL_IsValid && ASWalkTransBLToFL_IsValid && ASWalkStopFwd_IsValid && ASWalkStopBwd_IsValid && ASWalkStopLF_IsValid && ASWalkStopLB_IsValid && ASWalkStopRF_IsValid && ASWalkStopRB_IsValid && ASWalkLoopAddPose_IsValid && ASWalkLoopAdditiveList_IsValid && ASRunStartFwd_IsValid && ASRunStartBwd_IsValid && ASRunStartLeftMin_IsValid && ASRunStartLeftMax_IsValid && ASRunStartRightMin_IsValid && ASRunStartRightMax_IsValid && ASRunStartLF_IsValid && ASRunStartLB_IsValid && ASRunStartRF_IsValid && ASRunStartRB_IsValid && ASRunLoopFwd_IsValid && ASRunLoopBwd_IsValid && ASRunLoopLF_IsValid && ASRunLoopLB_IsValid && ASRunLoopRF_IsValid && ASRunLoopRB_IsValid && ASRunSharpturnLeftMin_IsValid && ASRunSharpturnLeftMax_IsValid && ASRunSharpturnRightMin_IsValid && ASRunSharpturnRightMax_IsValid && ASRunPivotFwd_IsValid && ASRunPivotBwd_IsValid && ASRunPivotLF_IsValid && ASRunPivotLB_IsValid && ASRunPivotRF_IsValid && ASRunPivotRB_IsValid && ASRunTransFRToBR_IsValid && ASRunTransBRToFR_IsValid && ASRunTransFLToBL_IsValid && ASRunTransBLToFL_IsValid && ASRunStopFwd_IsValid && ASRunStopBwd_IsValid && ASRunStopLF_IsValid && ASRunStopLB_IsValid && ASRunStopRF_IsValid && ASRunStopRB_IsValid && ASRunLoopAddPose_IsValid && ASRunLoopAdditiveList_IsValid && ASRushStartFwd_IsValid && ASRushStartLeftMin_IsValid && ASRushStartLeftMax_IsValid && ASRushStartRightMin_IsValid && ASRushStartRightMax_IsValid && ASRushLoopFwd_IsValid && ASRushSharpturnLeftMin_IsValid && ASRushSharpturnLeftMax_IsValid && ASRushSharpturnRightMin_IsValid && ASRushSharpturnRightMax_IsValid && ASRushStopFwd_IsValid && ASRushLoopAddPose_IsValid && ASRushLoopAdditiveList_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.AnimHumanoidSetting_AdvancedMonsterLocomotion", (byte)AnimHumanoidSetting_AdvancedMonsterLocomotion_IsValid != 0);
	}

	static FAnimHumanoidSetting_AdvancedMonsterLocomotion()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FAnimHumanoidSetting_AdvancedMonsterLocomotion)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimHumanoidSetting_AdvancedMonsterLocomotion));
	}
}
