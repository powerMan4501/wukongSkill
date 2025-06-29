using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock")]
public struct FAnimHumanoidSetting_PlayerLocomotion_Lock
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:LockMovementCurve")]
	public UCurveVector LockMovementCurve;

	[UProperty]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:ASLockWalkLoopFwd")]
	public UAnimSequence ASLockWalkLoopFwd;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:ASLockWalkLoopBwd")]
	public UAnimSequence ASLockWalkLoopBwd;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:ASLockWalkLoopLeftF")]
	public UAnimSequence ASLockWalkLoopLeftF;

	[UProperty]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:ASLockWalkLoopRightF")]
	public UAnimSequence ASLockWalkLoopRightF;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:ASLockWalkLoopLeftB")]
	public UAnimSequence ASLockWalkLoopLeftB;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:ASLockWalkLoopRightB")]
	public UAnimSequence ASLockWalkLoopRightB;

	[UProperty]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:ASLockWalkLoopLeftFAdd")]
	public UAnimSequence ASLockWalkLoopLeftFAdd;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:ASLockWalkLoopRightFAdd")]
	public UAnimSequence ASLockWalkLoopRightFAdd;

	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:ASLockRunLoopFwd")]
	public UAnimSequence ASLockRunLoopFwd;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:ASLockRunLoopLeftF")]
	public UAnimSequence ASLockRunLoopLeftF;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:ASLockRunLoopLeftB")]
	public UAnimSequence ASLockRunLoopLeftB;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:ASLockRunLoopLeftFAdd")]
	public UAnimSequence ASLockRunLoopLeftFAdd;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:ASLockRunLoopRightF")]
	public UAnimSequence ASLockRunLoopRightF;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:ASLockRunLoopRightB")]
	public UAnimSequence ASLockRunLoopRightB;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:ASLockRunLoopRightFAdd")]
	public UAnimSequence ASLockRunLoopRightFAdd;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:ASLockRunLoopBwd")]
	public UAnimSequence ASLockRunLoopBwd;

	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:BSLockWalkStartFwd")]
	public UBlendSpace BSLockWalkStartFwd;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:BSLockWalkStartBwd")]
	public UBlendSpace BSLockWalkStartBwd;

	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:ASLockWalkStartFwdL")]
	public UAnimSequence ASLockWalkStartFwdL;

	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:ASLockWalkStartFwdR")]
	public UAnimSequence ASLockWalkStartFwdR;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:ASLockWalkStartBwdL")]
	public UAnimSequence ASLockWalkStartBwdL;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:ASLockWalkStartBwdR")]
	public UAnimSequence ASLockWalkStartBwdR;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:ASLockWalkStartLeftF")]
	public UAnimSequence ASLockWalkStartLeftF;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:ASLockWalkStartLeftB")]
	public UAnimSequence ASLockWalkStartLeftB;

	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:ASLockWalkStartRightF")]
	public UAnimSequence ASLockWalkStartRightF;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:ASLockWalkStartRightB")]
	public UAnimSequence ASLockWalkStartRightB;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:BSLockRunStartFwd")]
	public UBlendSpace BSLockRunStartFwd;

	[UProperty]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:BSLockRunStartBwd")]
	public UBlendSpace BSLockRunStartBwd;

	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:ASLockRunStartFwdL")]
	public UAnimSequence ASLockRunStartFwdL;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:ASLockRunStartFwdR")]
	public UAnimSequence ASLockRunStartFwdR;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:ASLockRunStartBwdL")]
	public UAnimSequence ASLockRunStartBwdL;

	[UProperty]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:ASLockRunStartBwdR")]
	public UAnimSequence ASLockRunStartBwdR;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:ASLockRunStartLeftF")]
	public UAnimSequence ASLockRunStartLeftF;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:ASLockRunStartLeftB")]
	public UAnimSequence ASLockRunStartLeftB;

	[UProperty]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:ASLockRunStartRightF")]
	public UAnimSequence ASLockRunStartRightF;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:ASLockRunStartRightB")]
	public UAnimSequence ASLockRunStartRightB;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:BSLockWalkTurnF2B")]
	public UBlendSpace BSLockWalkTurnF2B;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:BSLockWalkTurnB2F")]
	public UBlendSpace BSLockWalkTurnB2F;

	[UProperty]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:BSLockWalkTurnFR2BL")]
	public UBlendSpace BSLockWalkTurnFR2BL;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:BSLockWalkTurnBR2FL")]
	public UBlendSpace BSLockWalkTurnBR2FL;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:BSLockWalkTurnBL2FR")]
	public UBlendSpace BSLockWalkTurnBL2FR;

	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:BSLockWalkTurnFL2BR")]
	public UBlendSpace BSLockWalkTurnFL2BR;

	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:BSLockWalkTurnFR2FL")]
	public UBlendSpace BSLockWalkTurnFR2FL;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:BSLockWalkTurnFL2FR")]
	public UBlendSpace BSLockWalkTurnFL2FR;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:BSLockWalkTurnBL2FL")]
	public UBlendSpace BSLockWalkTurnBL2FL;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:BSLockWalkTurnFL2BL")]
	public UBlendSpace BSLockWalkTurnFL2BL;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:BSLockWalkTurnBR2FR")]
	public UBlendSpace BSLockWalkTurnBR2FR;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:BSLockWalkTurnFR2BR")]
	public UBlendSpace BSLockWalkTurnFR2BR;

	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:BSLockRunTurnF2B")]
	public UBlendSpace BSLockRunTurnF2B;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:BSLockRunTurnB2F")]
	public UBlendSpace BSLockRunTurnB2F;

	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:BSLockRunTurnBR2FL")]
	public UBlendSpace BSLockRunTurnBR2FL;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:BSLockRunTurnFR2FL")]
	public UBlendSpace BSLockRunTurnFR2FL;

	[UProperty]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:BSLockRunTurnBL2FL")]
	public UBlendSpace BSLockRunTurnBL2FL;

	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:BSLockRunTurnFR2BL")]
	public UBlendSpace BSLockRunTurnFR2BL;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:BSLockRunTurnFL2BL")]
	public UBlendSpace BSLockRunTurnFL2BL;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:BSLockRunTurnFL2FR")]
	public UBlendSpace BSLockRunTurnFL2FR;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:BSLockRunTurnBL2FR")]
	public UBlendSpace BSLockRunTurnBL2FR;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:BSLockRunTurnBR2FR")]
	public UBlendSpace BSLockRunTurnBR2FR;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:BSLockRunTurnFL2BR")]
	public UBlendSpace BSLockRunTurnFL2BR;

	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:BSLockRunTurnFR2BR")]
	public UBlendSpace BSLockRunTurnFR2BR;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:BSLockTurnFRFromFRBL")]
	public UBlendSpace BSLockTurnFRFromFRBL;

	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:BSLockTurnFRFromFLBR")]
	public UBlendSpace BSLockTurnFRFromFLBR;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:BSLockTurnBRFromFRBL")]
	public UBlendSpace BSLockTurnBRFromFRBL;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:BSLockTurnBRFromFLBR")]
	public UBlendSpace BSLockTurnBRFromFLBR;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:BSLockTurnBLFromFRBL")]
	public UBlendSpace BSLockTurnBLFromFRBL;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:BSLockTurnBLFromFLBR")]
	public UBlendSpace BSLockTurnBLFromFLBR;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:BSLockTurnFLFromFRBL")]
	public UBlendSpace BSLockTurnFLFromFRBL;

	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:BSLockTurnFLFromFLBR")]
	public UBlendSpace BSLockTurnFLFromFLBR;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:BSLockTurnStopFL")]
	public UBlendSpace BSLockTurnStopFL;

	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:BSLockTurnStopFR")]
	public UBlendSpace BSLockTurnStopFR;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:BSLockTurnStopBL")]
	public UBlendSpace BSLockTurnStopBL;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:BSLockTurnStopBR")]
	public UBlendSpace BSLockTurnStopBR;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:ASLockWalkStopFwd")]
	public UAnimSequence ASLockWalkStopFwd;

	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:ASLockWalkStopBwd")]
	public UAnimSequence ASLockWalkStopBwd;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:ASLockWalkStopLeftF")]
	public UAnimSequence ASLockWalkStopLeftF;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:ASLockWalkStopLeftB")]
	public UAnimSequence ASLockWalkStopLeftB;

	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:ASLockWalkStopRightF")]
	public UAnimSequence ASLockWalkStopRightF;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:ASLockWalkStopRightB")]
	public UAnimSequence ASLockWalkStopRightB;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:ASLockWalkStopFL45")]
	public UAnimSequence ASLockWalkStopFL45;

	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:ASLockWalkStopFR45")]
	public UAnimSequence ASLockWalkStopFR45;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:ASLockWalkStopBL45")]
	public UAnimSequence ASLockWalkStopBL45;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:ASLockWalkStopBR45")]
	public UAnimSequence ASLockWalkStopBR45;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:ASLockRunStopFwdL")]
	public UAnimSequence ASLockRunStopFwdL;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:ASLockRunStopFwdR")]
	public UAnimSequence ASLockRunStopFwdR;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:ASLockRunStopLeftF")]
	public UAnimSequence ASLockRunStopLeftF;

	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:ASLockRunStopLeftB")]
	public UAnimSequence ASLockRunStopLeftB;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:ASLockRunStopRightF")]
	public UAnimSequence ASLockRunStopRightF;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:ASLockRunStopRightB")]
	public UAnimSequence ASLockRunStopRightB;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:ASLockRunStopBwdL")]
	public UAnimSequence ASLockRunStopBwdL;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock:ASLockRunStopBwdR")]
	public UAnimSequence ASLockRunStopBwdR;

	private static int AnimHumanoidSetting_PlayerLocomotion_Lock_StructSize;

	private static int AnimHumanoidSetting_PlayerLocomotion_Lock_IsValid;

	private static bool LockMovementCurve_IsValid;

	private static int LockMovementCurve_Offset;

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

	private static bool ASLockRunLoopLeftF_IsValid;

	private static int ASLockRunLoopLeftF_Offset;

	private static bool ASLockRunLoopLeftB_IsValid;

	private static int ASLockRunLoopLeftB_Offset;

	private static bool ASLockRunLoopLeftFAdd_IsValid;

	private static int ASLockRunLoopLeftFAdd_Offset;

	private static bool ASLockRunLoopRightF_IsValid;

	private static int ASLockRunLoopRightF_Offset;

	private static bool ASLockRunLoopRightB_IsValid;

	private static int ASLockRunLoopRightB_Offset;

	private static bool ASLockRunLoopRightFAdd_IsValid;

	private static int ASLockRunLoopRightFAdd_Offset;

	private static bool ASLockRunLoopBwd_IsValid;

	private static int ASLockRunLoopBwd_Offset;

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

	private static bool BSLockWalkTurnF2B_IsValid;

	private static int BSLockWalkTurnF2B_Offset;

	private static bool BSLockWalkTurnB2F_IsValid;

	private static int BSLockWalkTurnB2F_Offset;

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

	private static bool BSLockRunTurnF2B_IsValid;

	private static int BSLockRunTurnF2B_Offset;

	private static bool BSLockRunTurnB2F_IsValid;

	private static int BSLockRunTurnB2F_Offset;

	private static bool BSLockRunTurnBR2FL_IsValid;

	private static int BSLockRunTurnBR2FL_Offset;

	private static bool BSLockRunTurnFR2FL_IsValid;

	private static int BSLockRunTurnFR2FL_Offset;

	private static bool BSLockRunTurnBL2FL_IsValid;

	private static int BSLockRunTurnBL2FL_Offset;

	private static bool BSLockRunTurnFR2BL_IsValid;

	private static int BSLockRunTurnFR2BL_Offset;

	private static bool BSLockRunTurnFL2BL_IsValid;

	private static int BSLockRunTurnFL2BL_Offset;

	private static bool BSLockRunTurnFL2FR_IsValid;

	private static int BSLockRunTurnFL2FR_Offset;

	private static bool BSLockRunTurnBL2FR_IsValid;

	private static int BSLockRunTurnBL2FR_Offset;

	private static bool BSLockRunTurnBR2FR_IsValid;

	private static int BSLockRunTurnBR2FR_Offset;

	private static bool BSLockRunTurnFL2BR_IsValid;

	private static int BSLockRunTurnFL2BR_Offset;

	private static bool BSLockRunTurnFR2BR_IsValid;

	private static int BSLockRunTurnFR2BR_Offset;

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

	private static bool BSLockTurnStopFL_IsValid;

	private static int BSLockTurnStopFL_Offset;

	private static bool BSLockTurnStopFR_IsValid;

	private static int BSLockTurnStopFR_Offset;

	private static bool BSLockTurnStopBL_IsValid;

	private static int BSLockTurnStopBL_Offset;

	private static bool BSLockTurnStopBR_IsValid;

	private static int BSLockTurnStopBR_Offset;

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

	private static bool ASLockRunStopLeftF_IsValid;

	private static int ASLockRunStopLeftF_Offset;

	private static bool ASLockRunStopLeftB_IsValid;

	private static int ASLockRunStopLeftB_Offset;

	private static bool ASLockRunStopRightF_IsValid;

	private static int ASLockRunStopRightF_Offset;

	private static bool ASLockRunStopRightB_IsValid;

	private static int ASLockRunStopRightB_Offset;

	private static bool ASLockRunStopBwdL_IsValid;

	private static int ASLockRunStopBwdL_Offset;

	private static bool ASLockRunStopBwdR_IsValid;

	private static int ASLockRunStopBwdR_Offset;

	public FAnimHumanoidSetting_PlayerLocomotion_Lock Copy()
	{
		return this;
	}

	public static FAnimHumanoidSetting_PlayerLocomotion_Lock FromNative(IntPtr nativeBuffer)
	{
		return new FAnimHumanoidSetting_PlayerLocomotion_Lock(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimHumanoidSetting_PlayerLocomotion_Lock value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimHumanoidSetting_PlayerLocomotion_Lock FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimHumanoidSetting_PlayerLocomotion_Lock(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_PlayerLocomotion_Lock_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimHumanoidSetting_PlayerLocomotion_Lock value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_PlayerLocomotion_Lock_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_PlayerLocomotion_Lock_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock");
			return;
		}
		UObjectMarshaler<UCurveVector>.ToNative(IntPtr.Add(nativeStruct, LockMovementCurve_Offset), LockMovementCurve);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASLockWalkLoopFwd_Offset), ASLockWalkLoopFwd);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASLockWalkLoopBwd_Offset), ASLockWalkLoopBwd);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASLockWalkLoopLeftF_Offset), ASLockWalkLoopLeftF);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASLockWalkLoopRightF_Offset), ASLockWalkLoopRightF);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASLockWalkLoopLeftB_Offset), ASLockWalkLoopLeftB);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASLockWalkLoopRightB_Offset), ASLockWalkLoopRightB);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASLockWalkLoopLeftFAdd_Offset), ASLockWalkLoopLeftFAdd);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASLockWalkLoopRightFAdd_Offset), ASLockWalkLoopRightFAdd);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASLockRunLoopFwd_Offset), ASLockRunLoopFwd);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASLockRunLoopLeftF_Offset), ASLockRunLoopLeftF);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASLockRunLoopLeftB_Offset), ASLockRunLoopLeftB);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASLockRunLoopLeftFAdd_Offset), ASLockRunLoopLeftFAdd);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASLockRunLoopRightF_Offset), ASLockRunLoopRightF);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASLockRunLoopRightB_Offset), ASLockRunLoopRightB);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASLockRunLoopRightFAdd_Offset), ASLockRunLoopRightFAdd);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASLockRunLoopBwd_Offset), ASLockRunLoopBwd);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSLockWalkStartFwd_Offset), BSLockWalkStartFwd);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSLockWalkStartBwd_Offset), BSLockWalkStartBwd);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASLockWalkStartFwdL_Offset), ASLockWalkStartFwdL);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASLockWalkStartFwdR_Offset), ASLockWalkStartFwdR);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASLockWalkStartBwdL_Offset), ASLockWalkStartBwdL);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASLockWalkStartBwdR_Offset), ASLockWalkStartBwdR);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASLockWalkStartLeftF_Offset), ASLockWalkStartLeftF);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASLockWalkStartLeftB_Offset), ASLockWalkStartLeftB);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASLockWalkStartRightF_Offset), ASLockWalkStartRightF);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASLockWalkStartRightB_Offset), ASLockWalkStartRightB);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSLockRunStartFwd_Offset), BSLockRunStartFwd);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSLockRunStartBwd_Offset), BSLockRunStartBwd);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASLockRunStartFwdL_Offset), ASLockRunStartFwdL);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASLockRunStartFwdR_Offset), ASLockRunStartFwdR);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASLockRunStartBwdL_Offset), ASLockRunStartBwdL);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASLockRunStartBwdR_Offset), ASLockRunStartBwdR);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASLockRunStartLeftF_Offset), ASLockRunStartLeftF);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASLockRunStartLeftB_Offset), ASLockRunStartLeftB);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASLockRunStartRightF_Offset), ASLockRunStartRightF);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASLockRunStartRightB_Offset), ASLockRunStartRightB);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSLockWalkTurnF2B_Offset), BSLockWalkTurnF2B);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSLockWalkTurnB2F_Offset), BSLockWalkTurnB2F);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSLockWalkTurnFR2BL_Offset), BSLockWalkTurnFR2BL);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSLockWalkTurnBR2FL_Offset), BSLockWalkTurnBR2FL);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSLockWalkTurnBL2FR_Offset), BSLockWalkTurnBL2FR);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSLockWalkTurnFL2BR_Offset), BSLockWalkTurnFL2BR);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSLockWalkTurnFR2FL_Offset), BSLockWalkTurnFR2FL);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSLockWalkTurnFL2FR_Offset), BSLockWalkTurnFL2FR);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSLockWalkTurnBL2FL_Offset), BSLockWalkTurnBL2FL);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSLockWalkTurnFL2BL_Offset), BSLockWalkTurnFL2BL);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSLockWalkTurnBR2FR_Offset), BSLockWalkTurnBR2FR);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSLockWalkTurnFR2BR_Offset), BSLockWalkTurnFR2BR);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSLockRunTurnF2B_Offset), BSLockRunTurnF2B);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSLockRunTurnB2F_Offset), BSLockRunTurnB2F);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSLockRunTurnBR2FL_Offset), BSLockRunTurnBR2FL);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSLockRunTurnFR2FL_Offset), BSLockRunTurnFR2FL);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSLockRunTurnBL2FL_Offset), BSLockRunTurnBL2FL);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSLockRunTurnFR2BL_Offset), BSLockRunTurnFR2BL);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSLockRunTurnFL2BL_Offset), BSLockRunTurnFL2BL);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSLockRunTurnFL2FR_Offset), BSLockRunTurnFL2FR);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSLockRunTurnBL2FR_Offset), BSLockRunTurnBL2FR);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSLockRunTurnBR2FR_Offset), BSLockRunTurnBR2FR);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSLockRunTurnFL2BR_Offset), BSLockRunTurnFL2BR);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSLockRunTurnFR2BR_Offset), BSLockRunTurnFR2BR);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSLockTurnFRFromFRBL_Offset), BSLockTurnFRFromFRBL);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSLockTurnFRFromFLBR_Offset), BSLockTurnFRFromFLBR);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSLockTurnBRFromFRBL_Offset), BSLockTurnBRFromFRBL);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSLockTurnBRFromFLBR_Offset), BSLockTurnBRFromFLBR);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSLockTurnBLFromFRBL_Offset), BSLockTurnBLFromFRBL);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSLockTurnBLFromFLBR_Offset), BSLockTurnBLFromFLBR);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSLockTurnFLFromFRBL_Offset), BSLockTurnFLFromFRBL);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSLockTurnFLFromFLBR_Offset), BSLockTurnFLFromFLBR);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSLockTurnStopFL_Offset), BSLockTurnStopFL);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSLockTurnStopFR_Offset), BSLockTurnStopFR);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSLockTurnStopBL_Offset), BSLockTurnStopBL);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSLockTurnStopBR_Offset), BSLockTurnStopBR);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASLockWalkStopFwd_Offset), ASLockWalkStopFwd);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASLockWalkStopBwd_Offset), ASLockWalkStopBwd);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASLockWalkStopLeftF_Offset), ASLockWalkStopLeftF);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASLockWalkStopLeftB_Offset), ASLockWalkStopLeftB);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASLockWalkStopRightF_Offset), ASLockWalkStopRightF);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASLockWalkStopRightB_Offset), ASLockWalkStopRightB);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASLockWalkStopFL45_Offset), ASLockWalkStopFL45);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASLockWalkStopFR45_Offset), ASLockWalkStopFR45);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASLockWalkStopBL45_Offset), ASLockWalkStopBL45);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASLockWalkStopBR45_Offset), ASLockWalkStopBR45);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASLockRunStopFwdL_Offset), ASLockRunStopFwdL);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASLockRunStopFwdR_Offset), ASLockRunStopFwdR);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASLockRunStopLeftF_Offset), ASLockRunStopLeftF);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASLockRunStopLeftB_Offset), ASLockRunStopLeftB);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASLockRunStopRightF_Offset), ASLockRunStopRightF);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASLockRunStopRightB_Offset), ASLockRunStopRightB);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASLockRunStopBwdL_Offset), ASLockRunStopBwdL);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASLockRunStopBwdR_Offset), ASLockRunStopBwdR);
	}

	public FAnimHumanoidSetting_PlayerLocomotion_Lock(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_PlayerLocomotion_Lock_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock");
			LockMovementCurve = null;
			ASLockWalkLoopFwd = null;
			ASLockWalkLoopBwd = null;
			ASLockWalkLoopLeftF = null;
			ASLockWalkLoopRightF = null;
			ASLockWalkLoopLeftB = null;
			ASLockWalkLoopRightB = null;
			ASLockWalkLoopLeftFAdd = null;
			ASLockWalkLoopRightFAdd = null;
			ASLockRunLoopFwd = null;
			ASLockRunLoopLeftF = null;
			ASLockRunLoopLeftB = null;
			ASLockRunLoopLeftFAdd = null;
			ASLockRunLoopRightF = null;
			ASLockRunLoopRightB = null;
			ASLockRunLoopRightFAdd = null;
			ASLockRunLoopBwd = null;
			BSLockWalkStartFwd = null;
			BSLockWalkStartBwd = null;
			ASLockWalkStartFwdL = null;
			ASLockWalkStartFwdR = null;
			ASLockWalkStartBwdL = null;
			ASLockWalkStartBwdR = null;
			ASLockWalkStartLeftF = null;
			ASLockWalkStartLeftB = null;
			ASLockWalkStartRightF = null;
			ASLockWalkStartRightB = null;
			BSLockRunStartFwd = null;
			BSLockRunStartBwd = null;
			ASLockRunStartFwdL = null;
			ASLockRunStartFwdR = null;
			ASLockRunStartBwdL = null;
			ASLockRunStartBwdR = null;
			ASLockRunStartLeftF = null;
			ASLockRunStartLeftB = null;
			ASLockRunStartRightF = null;
			ASLockRunStartRightB = null;
			BSLockWalkTurnF2B = null;
			BSLockWalkTurnB2F = null;
			BSLockWalkTurnFR2BL = null;
			BSLockWalkTurnBR2FL = null;
			BSLockWalkTurnBL2FR = null;
			BSLockWalkTurnFL2BR = null;
			BSLockWalkTurnFR2FL = null;
			BSLockWalkTurnFL2FR = null;
			BSLockWalkTurnBL2FL = null;
			BSLockWalkTurnFL2BL = null;
			BSLockWalkTurnBR2FR = null;
			BSLockWalkTurnFR2BR = null;
			BSLockRunTurnF2B = null;
			BSLockRunTurnB2F = null;
			BSLockRunTurnBR2FL = null;
			BSLockRunTurnFR2FL = null;
			BSLockRunTurnBL2FL = null;
			BSLockRunTurnFR2BL = null;
			BSLockRunTurnFL2BL = null;
			BSLockRunTurnFL2FR = null;
			BSLockRunTurnBL2FR = null;
			BSLockRunTurnBR2FR = null;
			BSLockRunTurnFL2BR = null;
			BSLockRunTurnFR2BR = null;
			BSLockTurnFRFromFRBL = null;
			BSLockTurnFRFromFLBR = null;
			BSLockTurnBRFromFRBL = null;
			BSLockTurnBRFromFLBR = null;
			BSLockTurnBLFromFRBL = null;
			BSLockTurnBLFromFLBR = null;
			BSLockTurnFLFromFRBL = null;
			BSLockTurnFLFromFLBR = null;
			BSLockTurnStopFL = null;
			BSLockTurnStopFR = null;
			BSLockTurnStopBL = null;
			BSLockTurnStopBR = null;
			ASLockWalkStopFwd = null;
			ASLockWalkStopBwd = null;
			ASLockWalkStopLeftF = null;
			ASLockWalkStopLeftB = null;
			ASLockWalkStopRightF = null;
			ASLockWalkStopRightB = null;
			ASLockWalkStopFL45 = null;
			ASLockWalkStopFR45 = null;
			ASLockWalkStopBL45 = null;
			ASLockWalkStopBR45 = null;
			ASLockRunStopFwdL = null;
			ASLockRunStopFwdR = null;
			ASLockRunStopLeftF = null;
			ASLockRunStopLeftB = null;
			ASLockRunStopRightF = null;
			ASLockRunStopRightB = null;
			ASLockRunStopBwdL = null;
			ASLockRunStopBwdR = null;
		}
		else
		{
			LockMovementCurve = UObjectMarshaler<UCurveVector>.FromNative(IntPtr.Add(nativeStruct, LockMovementCurve_Offset));
			ASLockWalkLoopFwd = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASLockWalkLoopFwd_Offset));
			ASLockWalkLoopBwd = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASLockWalkLoopBwd_Offset));
			ASLockWalkLoopLeftF = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASLockWalkLoopLeftF_Offset));
			ASLockWalkLoopRightF = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASLockWalkLoopRightF_Offset));
			ASLockWalkLoopLeftB = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASLockWalkLoopLeftB_Offset));
			ASLockWalkLoopRightB = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASLockWalkLoopRightB_Offset));
			ASLockWalkLoopLeftFAdd = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASLockWalkLoopLeftFAdd_Offset));
			ASLockWalkLoopRightFAdd = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASLockWalkLoopRightFAdd_Offset));
			ASLockRunLoopFwd = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASLockRunLoopFwd_Offset));
			ASLockRunLoopLeftF = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASLockRunLoopLeftF_Offset));
			ASLockRunLoopLeftB = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASLockRunLoopLeftB_Offset));
			ASLockRunLoopLeftFAdd = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASLockRunLoopLeftFAdd_Offset));
			ASLockRunLoopRightF = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASLockRunLoopRightF_Offset));
			ASLockRunLoopRightB = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASLockRunLoopRightB_Offset));
			ASLockRunLoopRightFAdd = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASLockRunLoopRightFAdd_Offset));
			ASLockRunLoopBwd = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASLockRunLoopBwd_Offset));
			BSLockWalkStartFwd = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSLockWalkStartFwd_Offset));
			BSLockWalkStartBwd = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSLockWalkStartBwd_Offset));
			ASLockWalkStartFwdL = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASLockWalkStartFwdL_Offset));
			ASLockWalkStartFwdR = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASLockWalkStartFwdR_Offset));
			ASLockWalkStartBwdL = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASLockWalkStartBwdL_Offset));
			ASLockWalkStartBwdR = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASLockWalkStartBwdR_Offset));
			ASLockWalkStartLeftF = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASLockWalkStartLeftF_Offset));
			ASLockWalkStartLeftB = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASLockWalkStartLeftB_Offset));
			ASLockWalkStartRightF = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASLockWalkStartRightF_Offset));
			ASLockWalkStartRightB = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASLockWalkStartRightB_Offset));
			BSLockRunStartFwd = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSLockRunStartFwd_Offset));
			BSLockRunStartBwd = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSLockRunStartBwd_Offset));
			ASLockRunStartFwdL = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASLockRunStartFwdL_Offset));
			ASLockRunStartFwdR = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASLockRunStartFwdR_Offset));
			ASLockRunStartBwdL = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASLockRunStartBwdL_Offset));
			ASLockRunStartBwdR = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASLockRunStartBwdR_Offset));
			ASLockRunStartLeftF = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASLockRunStartLeftF_Offset));
			ASLockRunStartLeftB = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASLockRunStartLeftB_Offset));
			ASLockRunStartRightF = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASLockRunStartRightF_Offset));
			ASLockRunStartRightB = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASLockRunStartRightB_Offset));
			BSLockWalkTurnF2B = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSLockWalkTurnF2B_Offset));
			BSLockWalkTurnB2F = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSLockWalkTurnB2F_Offset));
			BSLockWalkTurnFR2BL = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSLockWalkTurnFR2BL_Offset));
			BSLockWalkTurnBR2FL = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSLockWalkTurnBR2FL_Offset));
			BSLockWalkTurnBL2FR = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSLockWalkTurnBL2FR_Offset));
			BSLockWalkTurnFL2BR = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSLockWalkTurnFL2BR_Offset));
			BSLockWalkTurnFR2FL = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSLockWalkTurnFR2FL_Offset));
			BSLockWalkTurnFL2FR = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSLockWalkTurnFL2FR_Offset));
			BSLockWalkTurnBL2FL = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSLockWalkTurnBL2FL_Offset));
			BSLockWalkTurnFL2BL = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSLockWalkTurnFL2BL_Offset));
			BSLockWalkTurnBR2FR = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSLockWalkTurnBR2FR_Offset));
			BSLockWalkTurnFR2BR = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSLockWalkTurnFR2BR_Offset));
			BSLockRunTurnF2B = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSLockRunTurnF2B_Offset));
			BSLockRunTurnB2F = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSLockRunTurnB2F_Offset));
			BSLockRunTurnBR2FL = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSLockRunTurnBR2FL_Offset));
			BSLockRunTurnFR2FL = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSLockRunTurnFR2FL_Offset));
			BSLockRunTurnBL2FL = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSLockRunTurnBL2FL_Offset));
			BSLockRunTurnFR2BL = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSLockRunTurnFR2BL_Offset));
			BSLockRunTurnFL2BL = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSLockRunTurnFL2BL_Offset));
			BSLockRunTurnFL2FR = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSLockRunTurnFL2FR_Offset));
			BSLockRunTurnBL2FR = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSLockRunTurnBL2FR_Offset));
			BSLockRunTurnBR2FR = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSLockRunTurnBR2FR_Offset));
			BSLockRunTurnFL2BR = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSLockRunTurnFL2BR_Offset));
			BSLockRunTurnFR2BR = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSLockRunTurnFR2BR_Offset));
			BSLockTurnFRFromFRBL = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSLockTurnFRFromFRBL_Offset));
			BSLockTurnFRFromFLBR = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSLockTurnFRFromFLBR_Offset));
			BSLockTurnBRFromFRBL = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSLockTurnBRFromFRBL_Offset));
			BSLockTurnBRFromFLBR = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSLockTurnBRFromFLBR_Offset));
			BSLockTurnBLFromFRBL = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSLockTurnBLFromFRBL_Offset));
			BSLockTurnBLFromFLBR = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSLockTurnBLFromFLBR_Offset));
			BSLockTurnFLFromFRBL = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSLockTurnFLFromFRBL_Offset));
			BSLockTurnFLFromFLBR = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSLockTurnFLFromFLBR_Offset));
			BSLockTurnStopFL = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSLockTurnStopFL_Offset));
			BSLockTurnStopFR = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSLockTurnStopFR_Offset));
			BSLockTurnStopBL = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSLockTurnStopBL_Offset));
			BSLockTurnStopBR = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSLockTurnStopBR_Offset));
			ASLockWalkStopFwd = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASLockWalkStopFwd_Offset));
			ASLockWalkStopBwd = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASLockWalkStopBwd_Offset));
			ASLockWalkStopLeftF = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASLockWalkStopLeftF_Offset));
			ASLockWalkStopLeftB = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASLockWalkStopLeftB_Offset));
			ASLockWalkStopRightF = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASLockWalkStopRightF_Offset));
			ASLockWalkStopRightB = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASLockWalkStopRightB_Offset));
			ASLockWalkStopFL45 = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASLockWalkStopFL45_Offset));
			ASLockWalkStopFR45 = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASLockWalkStopFR45_Offset));
			ASLockWalkStopBL45 = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASLockWalkStopBL45_Offset));
			ASLockWalkStopBR45 = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASLockWalkStopBR45_Offset));
			ASLockRunStopFwdL = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASLockRunStopFwdL_Offset));
			ASLockRunStopFwdR = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASLockRunStopFwdR_Offset));
			ASLockRunStopLeftF = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASLockRunStopLeftF_Offset));
			ASLockRunStopLeftB = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASLockRunStopLeftB_Offset));
			ASLockRunStopRightF = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASLockRunStopRightF_Offset));
			ASLockRunStopRightB = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASLockRunStopRightB_Offset));
			ASLockRunStopBwdL = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASLockRunStopBwdL_Offset));
			ASLockRunStopBwdR = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASLockRunStopBwdR_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock");
		AnimHumanoidSetting_PlayerLocomotion_Lock_StructSize = NativeReflection.GetStructSize(intPtr);
		LockMovementCurve_Offset = NativeReflection.GetPropertyOffset(intPtr, "LockMovementCurve");
		LockMovementCurve_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LockMovementCurve", Classes.FObjectProperty);
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
		ASLockRunLoopLeftF_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockRunLoopLeftF");
		ASLockRunLoopLeftF_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockRunLoopLeftF", Classes.FObjectProperty);
		ASLockRunLoopLeftB_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockRunLoopLeftB");
		ASLockRunLoopLeftB_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockRunLoopLeftB", Classes.FObjectProperty);
		ASLockRunLoopLeftFAdd_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockRunLoopLeftFAdd");
		ASLockRunLoopLeftFAdd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockRunLoopLeftFAdd", Classes.FObjectProperty);
		ASLockRunLoopRightF_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockRunLoopRightF");
		ASLockRunLoopRightF_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockRunLoopRightF", Classes.FObjectProperty);
		ASLockRunLoopRightB_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockRunLoopRightB");
		ASLockRunLoopRightB_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockRunLoopRightB", Classes.FObjectProperty);
		ASLockRunLoopRightFAdd_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockRunLoopRightFAdd");
		ASLockRunLoopRightFAdd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockRunLoopRightFAdd", Classes.FObjectProperty);
		ASLockRunLoopBwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockRunLoopBwd");
		ASLockRunLoopBwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockRunLoopBwd", Classes.FObjectProperty);
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
		BSLockWalkTurnF2B_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSLockWalkTurnF2B");
		BSLockWalkTurnF2B_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSLockWalkTurnF2B", Classes.FObjectProperty);
		BSLockWalkTurnB2F_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSLockWalkTurnB2F");
		BSLockWalkTurnB2F_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSLockWalkTurnB2F", Classes.FObjectProperty);
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
		BSLockRunTurnF2B_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSLockRunTurnF2B");
		BSLockRunTurnF2B_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSLockRunTurnF2B", Classes.FObjectProperty);
		BSLockRunTurnB2F_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSLockRunTurnB2F");
		BSLockRunTurnB2F_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSLockRunTurnB2F", Classes.FObjectProperty);
		BSLockRunTurnBR2FL_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSLockRunTurnBR2FL");
		BSLockRunTurnBR2FL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSLockRunTurnBR2FL", Classes.FObjectProperty);
		BSLockRunTurnFR2FL_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSLockRunTurnFR2FL");
		BSLockRunTurnFR2FL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSLockRunTurnFR2FL", Classes.FObjectProperty);
		BSLockRunTurnBL2FL_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSLockRunTurnBL2FL");
		BSLockRunTurnBL2FL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSLockRunTurnBL2FL", Classes.FObjectProperty);
		BSLockRunTurnFR2BL_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSLockRunTurnFR2BL");
		BSLockRunTurnFR2BL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSLockRunTurnFR2BL", Classes.FObjectProperty);
		BSLockRunTurnFL2BL_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSLockRunTurnFL2BL");
		BSLockRunTurnFL2BL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSLockRunTurnFL2BL", Classes.FObjectProperty);
		BSLockRunTurnFL2FR_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSLockRunTurnFL2FR");
		BSLockRunTurnFL2FR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSLockRunTurnFL2FR", Classes.FObjectProperty);
		BSLockRunTurnBL2FR_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSLockRunTurnBL2FR");
		BSLockRunTurnBL2FR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSLockRunTurnBL2FR", Classes.FObjectProperty);
		BSLockRunTurnBR2FR_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSLockRunTurnBR2FR");
		BSLockRunTurnBR2FR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSLockRunTurnBR2FR", Classes.FObjectProperty);
		BSLockRunTurnFL2BR_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSLockRunTurnFL2BR");
		BSLockRunTurnFL2BR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSLockRunTurnFL2BR", Classes.FObjectProperty);
		BSLockRunTurnFR2BR_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSLockRunTurnFR2BR");
		BSLockRunTurnFR2BR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSLockRunTurnFR2BR", Classes.FObjectProperty);
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
		BSLockTurnStopFL_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSLockTurnStopFL");
		BSLockTurnStopFL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSLockTurnStopFL", Classes.FObjectProperty);
		BSLockTurnStopFR_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSLockTurnStopFR");
		BSLockTurnStopFR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSLockTurnStopFR", Classes.FObjectProperty);
		BSLockTurnStopBL_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSLockTurnStopBL");
		BSLockTurnStopBL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSLockTurnStopBL", Classes.FObjectProperty);
		BSLockTurnStopBR_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSLockTurnStopBR");
		BSLockTurnStopBR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSLockTurnStopBR", Classes.FObjectProperty);
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
		ASLockRunStopLeftF_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockRunStopLeftF");
		ASLockRunStopLeftF_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockRunStopLeftF", Classes.FObjectProperty);
		ASLockRunStopLeftB_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockRunStopLeftB");
		ASLockRunStopLeftB_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockRunStopLeftB", Classes.FObjectProperty);
		ASLockRunStopRightF_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockRunStopRightF");
		ASLockRunStopRightF_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockRunStopRightF", Classes.FObjectProperty);
		ASLockRunStopRightB_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockRunStopRightB");
		ASLockRunStopRightB_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockRunStopRightB", Classes.FObjectProperty);
		ASLockRunStopBwdL_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockRunStopBwdL");
		ASLockRunStopBwdL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockRunStopBwdL", Classes.FObjectProperty);
		ASLockRunStopBwdR_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockRunStopBwdR");
		ASLockRunStopBwdR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockRunStopBwdR", Classes.FObjectProperty);
		AnimHumanoidSetting_PlayerLocomotion_Lock_IsValid = ((intPtr != IntPtr.Zero && LockMovementCurve_IsValid && ASLockWalkLoopFwd_IsValid && ASLockWalkLoopBwd_IsValid && ASLockWalkLoopLeftF_IsValid && ASLockWalkLoopRightF_IsValid && ASLockWalkLoopLeftB_IsValid && ASLockWalkLoopRightB_IsValid && ASLockWalkLoopLeftFAdd_IsValid && ASLockWalkLoopRightFAdd_IsValid && ASLockRunLoopFwd_IsValid && ASLockRunLoopLeftF_IsValid && ASLockRunLoopLeftB_IsValid && ASLockRunLoopLeftFAdd_IsValid && ASLockRunLoopRightF_IsValid && ASLockRunLoopRightB_IsValid && ASLockRunLoopRightFAdd_IsValid && ASLockRunLoopBwd_IsValid && BSLockWalkStartFwd_IsValid && BSLockWalkStartBwd_IsValid && ASLockWalkStartFwdL_IsValid && ASLockWalkStartFwdR_IsValid && ASLockWalkStartBwdL_IsValid && ASLockWalkStartBwdR_IsValid && ASLockWalkStartLeftF_IsValid && ASLockWalkStartLeftB_IsValid && ASLockWalkStartRightF_IsValid && ASLockWalkStartRightB_IsValid && BSLockRunStartFwd_IsValid && BSLockRunStartBwd_IsValid && ASLockRunStartFwdL_IsValid && ASLockRunStartFwdR_IsValid && ASLockRunStartBwdL_IsValid && ASLockRunStartBwdR_IsValid && ASLockRunStartLeftF_IsValid && ASLockRunStartLeftB_IsValid && ASLockRunStartRightF_IsValid && ASLockRunStartRightB_IsValid && BSLockWalkTurnF2B_IsValid && BSLockWalkTurnB2F_IsValid && BSLockWalkTurnFR2BL_IsValid && BSLockWalkTurnBR2FL_IsValid && BSLockWalkTurnBL2FR_IsValid && BSLockWalkTurnFL2BR_IsValid && BSLockWalkTurnFR2FL_IsValid && BSLockWalkTurnFL2FR_IsValid && BSLockWalkTurnBL2FL_IsValid && BSLockWalkTurnFL2BL_IsValid && BSLockWalkTurnBR2FR_IsValid && BSLockWalkTurnFR2BR_IsValid && BSLockRunTurnF2B_IsValid && BSLockRunTurnB2F_IsValid && BSLockRunTurnBR2FL_IsValid && BSLockRunTurnFR2FL_IsValid && BSLockRunTurnBL2FL_IsValid && BSLockRunTurnFR2BL_IsValid && BSLockRunTurnFL2BL_IsValid && BSLockRunTurnFL2FR_IsValid && BSLockRunTurnBL2FR_IsValid && BSLockRunTurnBR2FR_IsValid && BSLockRunTurnFL2BR_IsValid && BSLockRunTurnFR2BR_IsValid && BSLockTurnFRFromFRBL_IsValid && BSLockTurnFRFromFLBR_IsValid && BSLockTurnBRFromFRBL_IsValid && BSLockTurnBRFromFLBR_IsValid && BSLockTurnBLFromFRBL_IsValid && BSLockTurnBLFromFLBR_IsValid && BSLockTurnFLFromFRBL_IsValid && BSLockTurnFLFromFLBR_IsValid && BSLockTurnStopFL_IsValid && BSLockTurnStopFR_IsValid && BSLockTurnStopBL_IsValid && BSLockTurnStopBR_IsValid && ASLockWalkStopFwd_IsValid && ASLockWalkStopBwd_IsValid && ASLockWalkStopLeftF_IsValid && ASLockWalkStopLeftB_IsValid && ASLockWalkStopRightF_IsValid && ASLockWalkStopRightB_IsValid && ASLockWalkStopFL45_IsValid && ASLockWalkStopFR45_IsValid && ASLockWalkStopBL45_IsValid && ASLockWalkStopBR45_IsValid && ASLockRunStopFwdL_IsValid && ASLockRunStopFwdR_IsValid && ASLockRunStopLeftF_IsValid && ASLockRunStopLeftB_IsValid && ASLockRunStopRightF_IsValid && ASLockRunStopRightB_IsValid && ASLockRunStopBwdL_IsValid && ASLockRunStopBwdR_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Lock", (byte)AnimHumanoidSetting_PlayerLocomotion_Lock_IsValid != 0);
	}

	static FAnimHumanoidSetting_PlayerLocomotion_Lock()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FAnimHumanoidSetting_PlayerLocomotion_Lock)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimHumanoidSetting_PlayerLocomotion_Lock));
	}
}
