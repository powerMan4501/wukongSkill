using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Free")]
public struct FAnimHumanoidSetting_PlayerLocomotion_Free
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Free:FreeMovementCurve")]
	public UCurveVector FreeMovementCurve;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Free:BSFreeAdditiveMovingLean")]
	public UBlendSpace BSFreeAdditiveMovingLean;

	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Free:BSWalkLoopFwd")]
	public UBlendSpace BSWalkLoopFwd;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Free:BSRunLoopFwd")]
	public UBlendSpace BSRunLoopFwd;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Free:BSRunLoopAdditive")]
	public UBlendSpace BSRunLoopAdditive;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Free:BSRunLoopRotationAdditive")]
	public UBlendSpace BSRunLoopRotationAdditive;

	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Free:BSRushLoopFwd")]
	public UBlendSpace BSRushLoopFwd;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Free:BSRushLoopLean")]
	public UBlendSpace BSRushLoopLean;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Free:ASWalkStartBwdL")]
	public UAnimSequence ASWalkStartBwdL;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Free:ASWalkStartLeft")]
	public UAnimSequence ASWalkStartLeft;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Free:ASWalkStartFwd")]
	public UAnimSequence ASWalkStartFwd;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Free:ASWalkStartRight")]
	public UAnimSequence ASWalkStartRight;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Free:ASWalkStartBwdR")]
	public UAnimSequence ASWalkStartBwdR;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Free:ASWalkTurnBwdL")]
	public UAnimSequence ASWalkTurnBwdL;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Free:ASWalkTurnLeft")]
	public UAnimSequence ASWalkTurnLeft;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Free:ASWalkTurnRight")]
	public UAnimSequence ASWalkTurnRight;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Free:ASWalkTurnBwdR")]
	public UAnimSequence ASWalkTurnBwdR;

	[UProperty]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Free:ASFreeWalkStop")]
	public UAnimSequence ASFreeWalkStop;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Free:ASRunStartBwdL")]
	public UAnimSequence ASRunStartBwdL;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Free:ASRunStartLeft")]
	public UAnimSequence ASRunStartLeft;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Free:ASRunStartFwd")]
	public UAnimSequence ASRunStartFwd;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Free:ASRunStartRight")]
	public UAnimSequence ASRunStartRight;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Free:ASRunStartBwdR")]
	public UAnimSequence ASRunStartBwdR;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Free:ASRunTurnBwdL")]
	public UAnimSequence ASRunTurnBwdL;

	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Free:ASRunTurnLeft")]
	public UAnimSequence ASRunTurnLeft;

	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Free:ASRunTurnFwdL")]
	public UAnimSequence ASRunTurnFwdL;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Free:ASRunTurnFwdR")]
	public UAnimSequence ASRunTurnFwdR;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Free:ASRunTurnRight")]
	public UAnimSequence ASRunTurnRight;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Free:ASRunTurnBwdR")]
	public UAnimSequence ASRunTurnBwdR;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Free:ASRunTurnFwdFallingVelocityAdditive")]
	public UAnimSequence ASRunTurnFwdFallingVelocityAdditive;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Free:ASRunTurnFwdSpeedAdditive")]
	public UAnimSequence ASRunTurnFwdSpeedAdditive;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Free:ASRunTurnBwdFallingVelocityAdditive")]
	public UAnimSequence ASRunTurnBwdFallingVelocityAdditive;

	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Free:ASFreeRunStop")]
	public UAnimSequence ASFreeRunStop;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Free:ASFreeSprintStartBwdL")]
	public UAnimSequence ASFreeSprintStartBwdL;

	[UProperty]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Free:ASFreeSprintStartLeft")]
	public UAnimSequence ASFreeSprintStartLeft;

	[UProperty]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Free:ASFreeSprintStartFwd")]
	public UAnimSequence ASFreeSprintStartFwd;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Free:ASFreeSprintStartRight")]
	public UAnimSequence ASFreeSprintStartRight;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Free:ASFreeSprintStartBwdR")]
	public UAnimSequence ASFreeSprintStartBwdR;

	[UProperty]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Free:ASFreeSprintTurnBwdL")]
	public UAnimSequence ASFreeSprintTurnBwdL;

	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Free:ASFreeSprintTurnLeft")]
	public UAnimSequence ASFreeSprintTurnLeft;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Free:ASFreeSprintTurnRight")]
	public UAnimSequence ASFreeSprintTurnRight;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Free:ASFreeSprintTurnBwdR")]
	public UAnimSequence ASFreeSprintTurnBwdR;

	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Free:ASFreeSprintStop")]
	public UAnimSequence ASFreeSprintStop;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Free:SprintStopSlopeAngleThreshold")]
	public float SprintStopSlopeAngleThreshold;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Free:ASFreeSprintStopSlopeUp")]
	public UAnimSequence ASFreeSprintStopSlopeUp;

	private static int AnimHumanoidSetting_PlayerLocomotion_Free_StructSize;

	private static int AnimHumanoidSetting_PlayerLocomotion_Free_IsValid;

	private static bool FreeMovementCurve_IsValid;

	private static int FreeMovementCurve_Offset;

	private static bool BSFreeAdditiveMovingLean_IsValid;

	private static int BSFreeAdditiveMovingLean_Offset;

	private static bool BSWalkLoopFwd_IsValid;

	private static int BSWalkLoopFwd_Offset;

	private static bool BSRunLoopFwd_IsValid;

	private static int BSRunLoopFwd_Offset;

	private static bool BSRunLoopAdditive_IsValid;

	private static int BSRunLoopAdditive_Offset;

	private static bool BSRunLoopRotationAdditive_IsValid;

	private static int BSRunLoopRotationAdditive_Offset;

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

	private static bool ASFreeWalkStop_IsValid;

	private static int ASFreeWalkStop_Offset;

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

	private static bool ASRunTurnFwdL_IsValid;

	private static int ASRunTurnFwdL_Offset;

	private static bool ASRunTurnFwdR_IsValid;

	private static int ASRunTurnFwdR_Offset;

	private static bool ASRunTurnRight_IsValid;

	private static int ASRunTurnRight_Offset;

	private static bool ASRunTurnBwdR_IsValid;

	private static int ASRunTurnBwdR_Offset;

	private static bool ASRunTurnFwdFallingVelocityAdditive_IsValid;

	private static int ASRunTurnFwdFallingVelocityAdditive_Offset;

	private static bool ASRunTurnFwdSpeedAdditive_IsValid;

	private static int ASRunTurnFwdSpeedAdditive_Offset;

	private static bool ASRunTurnBwdFallingVelocityAdditive_IsValid;

	private static int ASRunTurnBwdFallingVelocityAdditive_Offset;

	private static bool ASFreeRunStop_IsValid;

	private static int ASFreeRunStop_Offset;

	private static bool ASFreeSprintStartBwdL_IsValid;

	private static int ASFreeSprintStartBwdL_Offset;

	private static bool ASFreeSprintStartLeft_IsValid;

	private static int ASFreeSprintStartLeft_Offset;

	private static bool ASFreeSprintStartFwd_IsValid;

	private static int ASFreeSprintStartFwd_Offset;

	private static bool ASFreeSprintStartRight_IsValid;

	private static int ASFreeSprintStartRight_Offset;

	private static bool ASFreeSprintStartBwdR_IsValid;

	private static int ASFreeSprintStartBwdR_Offset;

	private static bool ASFreeSprintTurnBwdL_IsValid;

	private static int ASFreeSprintTurnBwdL_Offset;

	private static bool ASFreeSprintTurnLeft_IsValid;

	private static int ASFreeSprintTurnLeft_Offset;

	private static bool ASFreeSprintTurnRight_IsValid;

	private static int ASFreeSprintTurnRight_Offset;

	private static bool ASFreeSprintTurnBwdR_IsValid;

	private static int ASFreeSprintTurnBwdR_Offset;

	private static bool ASFreeSprintStop_IsValid;

	private static int ASFreeSprintStop_Offset;

	private static bool SprintStopSlopeAngleThreshold_IsValid;

	private static int SprintStopSlopeAngleThreshold_Offset;

	private static bool ASFreeSprintStopSlopeUp_IsValid;

	private static int ASFreeSprintStopSlopeUp_Offset;

	public FAnimHumanoidSetting_PlayerLocomotion_Free Copy()
	{
		return this;
	}

	public static FAnimHumanoidSetting_PlayerLocomotion_Free FromNative(IntPtr nativeBuffer)
	{
		return new FAnimHumanoidSetting_PlayerLocomotion_Free(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimHumanoidSetting_PlayerLocomotion_Free value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimHumanoidSetting_PlayerLocomotion_Free FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimHumanoidSetting_PlayerLocomotion_Free(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_PlayerLocomotion_Free_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimHumanoidSetting_PlayerLocomotion_Free value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_PlayerLocomotion_Free_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_PlayerLocomotion_Free_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Free");
			return;
		}
		UObjectMarshaler<UCurveVector>.ToNative(IntPtr.Add(nativeStruct, FreeMovementCurve_Offset), FreeMovementCurve);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSFreeAdditiveMovingLean_Offset), BSFreeAdditiveMovingLean);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSWalkLoopFwd_Offset), BSWalkLoopFwd);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSRunLoopFwd_Offset), BSRunLoopFwd);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSRunLoopAdditive_Offset), BSRunLoopAdditive);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSRunLoopRotationAdditive_Offset), BSRunLoopRotationAdditive);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSRushLoopFwd_Offset), BSRushLoopFwd);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSRushLoopLean_Offset), BSRushLoopLean);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASWalkStartBwdL_Offset), ASWalkStartBwdL);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASWalkStartLeft_Offset), ASWalkStartLeft);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASWalkStartFwd_Offset), ASWalkStartFwd);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASWalkStartRight_Offset), ASWalkStartRight);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASWalkStartBwdR_Offset), ASWalkStartBwdR);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASWalkTurnBwdL_Offset), ASWalkTurnBwdL);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASWalkTurnLeft_Offset), ASWalkTurnLeft);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASWalkTurnRight_Offset), ASWalkTurnRight);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASWalkTurnBwdR_Offset), ASWalkTurnBwdR);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASFreeWalkStop_Offset), ASFreeWalkStop);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunStartBwdL_Offset), ASRunStartBwdL);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunStartLeft_Offset), ASRunStartLeft);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunStartFwd_Offset), ASRunStartFwd);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunStartRight_Offset), ASRunStartRight);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunStartBwdR_Offset), ASRunStartBwdR);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunTurnBwdL_Offset), ASRunTurnBwdL);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunTurnLeft_Offset), ASRunTurnLeft);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunTurnFwdL_Offset), ASRunTurnFwdL);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunTurnFwdR_Offset), ASRunTurnFwdR);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunTurnRight_Offset), ASRunTurnRight);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunTurnBwdR_Offset), ASRunTurnBwdR);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunTurnFwdFallingVelocityAdditive_Offset), ASRunTurnFwdFallingVelocityAdditive);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunTurnFwdSpeedAdditive_Offset), ASRunTurnFwdSpeedAdditive);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunTurnBwdFallingVelocityAdditive_Offset), ASRunTurnBwdFallingVelocityAdditive);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASFreeRunStop_Offset), ASFreeRunStop);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASFreeSprintStartBwdL_Offset), ASFreeSprintStartBwdL);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASFreeSprintStartLeft_Offset), ASFreeSprintStartLeft);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASFreeSprintStartFwd_Offset), ASFreeSprintStartFwd);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASFreeSprintStartRight_Offset), ASFreeSprintStartRight);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASFreeSprintStartBwdR_Offset), ASFreeSprintStartBwdR);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASFreeSprintTurnBwdL_Offset), ASFreeSprintTurnBwdL);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASFreeSprintTurnLeft_Offset), ASFreeSprintTurnLeft);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASFreeSprintTurnRight_Offset), ASFreeSprintTurnRight);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASFreeSprintTurnBwdR_Offset), ASFreeSprintTurnBwdR);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASFreeSprintStop_Offset), ASFreeSprintStop);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SprintStopSlopeAngleThreshold_Offset), SprintStopSlopeAngleThreshold);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASFreeSprintStopSlopeUp_Offset), ASFreeSprintStopSlopeUp);
	}

	public FAnimHumanoidSetting_PlayerLocomotion_Free(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_PlayerLocomotion_Free_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Free");
			FreeMovementCurve = null;
			BSFreeAdditiveMovingLean = null;
			BSWalkLoopFwd = null;
			BSRunLoopFwd = null;
			BSRunLoopAdditive = null;
			BSRunLoopRotationAdditive = null;
			BSRushLoopFwd = null;
			BSRushLoopLean = null;
			ASWalkStartBwdL = null;
			ASWalkStartLeft = null;
			ASWalkStartFwd = null;
			ASWalkStartRight = null;
			ASWalkStartBwdR = null;
			ASWalkTurnBwdL = null;
			ASWalkTurnLeft = null;
			ASWalkTurnRight = null;
			ASWalkTurnBwdR = null;
			ASFreeWalkStop = null;
			ASRunStartBwdL = null;
			ASRunStartLeft = null;
			ASRunStartFwd = null;
			ASRunStartRight = null;
			ASRunStartBwdR = null;
			ASRunTurnBwdL = null;
			ASRunTurnLeft = null;
			ASRunTurnFwdL = null;
			ASRunTurnFwdR = null;
			ASRunTurnRight = null;
			ASRunTurnBwdR = null;
			ASRunTurnFwdFallingVelocityAdditive = null;
			ASRunTurnFwdSpeedAdditive = null;
			ASRunTurnBwdFallingVelocityAdditive = null;
			ASFreeRunStop = null;
			ASFreeSprintStartBwdL = null;
			ASFreeSprintStartLeft = null;
			ASFreeSprintStartFwd = null;
			ASFreeSprintStartRight = null;
			ASFreeSprintStartBwdR = null;
			ASFreeSprintTurnBwdL = null;
			ASFreeSprintTurnLeft = null;
			ASFreeSprintTurnRight = null;
			ASFreeSprintTurnBwdR = null;
			ASFreeSprintStop = null;
			SprintStopSlopeAngleThreshold = 0f;
			ASFreeSprintStopSlopeUp = null;
		}
		else
		{
			FreeMovementCurve = UObjectMarshaler<UCurveVector>.FromNative(IntPtr.Add(nativeStruct, FreeMovementCurve_Offset));
			BSFreeAdditiveMovingLean = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSFreeAdditiveMovingLean_Offset));
			BSWalkLoopFwd = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSWalkLoopFwd_Offset));
			BSRunLoopFwd = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSRunLoopFwd_Offset));
			BSRunLoopAdditive = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSRunLoopAdditive_Offset));
			BSRunLoopRotationAdditive = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSRunLoopRotationAdditive_Offset));
			BSRushLoopFwd = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSRushLoopFwd_Offset));
			BSRushLoopLean = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSRushLoopLean_Offset));
			ASWalkStartBwdL = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASWalkStartBwdL_Offset));
			ASWalkStartLeft = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASWalkStartLeft_Offset));
			ASWalkStartFwd = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASWalkStartFwd_Offset));
			ASWalkStartRight = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASWalkStartRight_Offset));
			ASWalkStartBwdR = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASWalkStartBwdR_Offset));
			ASWalkTurnBwdL = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASWalkTurnBwdL_Offset));
			ASWalkTurnLeft = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASWalkTurnLeft_Offset));
			ASWalkTurnRight = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASWalkTurnRight_Offset));
			ASWalkTurnBwdR = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASWalkTurnBwdR_Offset));
			ASFreeWalkStop = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASFreeWalkStop_Offset));
			ASRunStartBwdL = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunStartBwdL_Offset));
			ASRunStartLeft = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunStartLeft_Offset));
			ASRunStartFwd = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunStartFwd_Offset));
			ASRunStartRight = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunStartRight_Offset));
			ASRunStartBwdR = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunStartBwdR_Offset));
			ASRunTurnBwdL = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunTurnBwdL_Offset));
			ASRunTurnLeft = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunTurnLeft_Offset));
			ASRunTurnFwdL = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunTurnFwdL_Offset));
			ASRunTurnFwdR = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunTurnFwdR_Offset));
			ASRunTurnRight = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunTurnRight_Offset));
			ASRunTurnBwdR = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunTurnBwdR_Offset));
			ASRunTurnFwdFallingVelocityAdditive = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunTurnFwdFallingVelocityAdditive_Offset));
			ASRunTurnFwdSpeedAdditive = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunTurnFwdSpeedAdditive_Offset));
			ASRunTurnBwdFallingVelocityAdditive = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunTurnBwdFallingVelocityAdditive_Offset));
			ASFreeRunStop = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASFreeRunStop_Offset));
			ASFreeSprintStartBwdL = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASFreeSprintStartBwdL_Offset));
			ASFreeSprintStartLeft = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASFreeSprintStartLeft_Offset));
			ASFreeSprintStartFwd = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASFreeSprintStartFwd_Offset));
			ASFreeSprintStartRight = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASFreeSprintStartRight_Offset));
			ASFreeSprintStartBwdR = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASFreeSprintStartBwdR_Offset));
			ASFreeSprintTurnBwdL = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASFreeSprintTurnBwdL_Offset));
			ASFreeSprintTurnLeft = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASFreeSprintTurnLeft_Offset));
			ASFreeSprintTurnRight = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASFreeSprintTurnRight_Offset));
			ASFreeSprintTurnBwdR = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASFreeSprintTurnBwdR_Offset));
			ASFreeSprintStop = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASFreeSprintStop_Offset));
			SprintStopSlopeAngleThreshold = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SprintStopSlopeAngleThreshold_Offset));
			ASFreeSprintStopSlopeUp = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASFreeSprintStopSlopeUp_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Free");
		AnimHumanoidSetting_PlayerLocomotion_Free_StructSize = NativeReflection.GetStructSize(intPtr);
		FreeMovementCurve_Offset = NativeReflection.GetPropertyOffset(intPtr, "FreeMovementCurve");
		FreeMovementCurve_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FreeMovementCurve", Classes.FObjectProperty);
		BSFreeAdditiveMovingLean_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSFreeAdditiveMovingLean");
		BSFreeAdditiveMovingLean_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSFreeAdditiveMovingLean", Classes.FObjectProperty);
		BSWalkLoopFwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSWalkLoopFwd");
		BSWalkLoopFwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSWalkLoopFwd", Classes.FObjectProperty);
		BSRunLoopFwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSRunLoopFwd");
		BSRunLoopFwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSRunLoopFwd", Classes.FObjectProperty);
		BSRunLoopAdditive_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSRunLoopAdditive");
		BSRunLoopAdditive_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSRunLoopAdditive", Classes.FObjectProperty);
		BSRunLoopRotationAdditive_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSRunLoopRotationAdditive");
		BSRunLoopRotationAdditive_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSRunLoopRotationAdditive", Classes.FObjectProperty);
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
		ASFreeWalkStop_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASFreeWalkStop");
		ASFreeWalkStop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASFreeWalkStop", Classes.FObjectProperty);
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
		ASRunTurnFwdL_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunTurnFwdL");
		ASRunTurnFwdL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunTurnFwdL", Classes.FObjectProperty);
		ASRunTurnFwdR_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunTurnFwdR");
		ASRunTurnFwdR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunTurnFwdR", Classes.FObjectProperty);
		ASRunTurnRight_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunTurnRight");
		ASRunTurnRight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunTurnRight", Classes.FObjectProperty);
		ASRunTurnBwdR_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunTurnBwdR");
		ASRunTurnBwdR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunTurnBwdR", Classes.FObjectProperty);
		ASRunTurnFwdFallingVelocityAdditive_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunTurnFwdFallingVelocityAdditive");
		ASRunTurnFwdFallingVelocityAdditive_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunTurnFwdFallingVelocityAdditive", Classes.FObjectProperty);
		ASRunTurnFwdSpeedAdditive_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunTurnFwdSpeedAdditive");
		ASRunTurnFwdSpeedAdditive_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunTurnFwdSpeedAdditive", Classes.FObjectProperty);
		ASRunTurnBwdFallingVelocityAdditive_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunTurnBwdFallingVelocityAdditive");
		ASRunTurnBwdFallingVelocityAdditive_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunTurnBwdFallingVelocityAdditive", Classes.FObjectProperty);
		ASFreeRunStop_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASFreeRunStop");
		ASFreeRunStop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASFreeRunStop", Classes.FObjectProperty);
		ASFreeSprintStartBwdL_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASFreeSprintStartBwdL");
		ASFreeSprintStartBwdL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASFreeSprintStartBwdL", Classes.FObjectProperty);
		ASFreeSprintStartLeft_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASFreeSprintStartLeft");
		ASFreeSprintStartLeft_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASFreeSprintStartLeft", Classes.FObjectProperty);
		ASFreeSprintStartFwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASFreeSprintStartFwd");
		ASFreeSprintStartFwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASFreeSprintStartFwd", Classes.FObjectProperty);
		ASFreeSprintStartRight_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASFreeSprintStartRight");
		ASFreeSprintStartRight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASFreeSprintStartRight", Classes.FObjectProperty);
		ASFreeSprintStartBwdR_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASFreeSprintStartBwdR");
		ASFreeSprintStartBwdR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASFreeSprintStartBwdR", Classes.FObjectProperty);
		ASFreeSprintTurnBwdL_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASFreeSprintTurnBwdL");
		ASFreeSprintTurnBwdL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASFreeSprintTurnBwdL", Classes.FObjectProperty);
		ASFreeSprintTurnLeft_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASFreeSprintTurnLeft");
		ASFreeSprintTurnLeft_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASFreeSprintTurnLeft", Classes.FObjectProperty);
		ASFreeSprintTurnRight_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASFreeSprintTurnRight");
		ASFreeSprintTurnRight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASFreeSprintTurnRight", Classes.FObjectProperty);
		ASFreeSprintTurnBwdR_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASFreeSprintTurnBwdR");
		ASFreeSprintTurnBwdR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASFreeSprintTurnBwdR", Classes.FObjectProperty);
		ASFreeSprintStop_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASFreeSprintStop");
		ASFreeSprintStop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASFreeSprintStop", Classes.FObjectProperty);
		SprintStopSlopeAngleThreshold_Offset = NativeReflection.GetPropertyOffset(intPtr, "SprintStopSlopeAngleThreshold");
		SprintStopSlopeAngleThreshold_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SprintStopSlopeAngleThreshold", Classes.FFloatProperty);
		ASFreeSprintStopSlopeUp_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASFreeSprintStopSlopeUp");
		ASFreeSprintStopSlopeUp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASFreeSprintStopSlopeUp", Classes.FObjectProperty);
		AnimHumanoidSetting_PlayerLocomotion_Free_IsValid = ((intPtr != IntPtr.Zero && FreeMovementCurve_IsValid && BSFreeAdditiveMovingLean_IsValid && BSWalkLoopFwd_IsValid && BSRunLoopFwd_IsValid && BSRunLoopAdditive_IsValid && BSRunLoopRotationAdditive_IsValid && BSRushLoopFwd_IsValid && BSRushLoopLean_IsValid && ASWalkStartBwdL_IsValid && ASWalkStartLeft_IsValid && ASWalkStartFwd_IsValid && ASWalkStartRight_IsValid && ASWalkStartBwdR_IsValid && ASWalkTurnBwdL_IsValid && ASWalkTurnLeft_IsValid && ASWalkTurnRight_IsValid && ASWalkTurnBwdR_IsValid && ASFreeWalkStop_IsValid && ASRunStartBwdL_IsValid && ASRunStartLeft_IsValid && ASRunStartFwd_IsValid && ASRunStartRight_IsValid && ASRunStartBwdR_IsValid && ASRunTurnBwdL_IsValid && ASRunTurnLeft_IsValid && ASRunTurnFwdL_IsValid && ASRunTurnFwdR_IsValid && ASRunTurnRight_IsValid && ASRunTurnBwdR_IsValid && ASRunTurnFwdFallingVelocityAdditive_IsValid && ASRunTurnFwdSpeedAdditive_IsValid && ASRunTurnBwdFallingVelocityAdditive_IsValid && ASFreeRunStop_IsValid && ASFreeSprintStartBwdL_IsValid && ASFreeSprintStartLeft_IsValid && ASFreeSprintStartFwd_IsValid && ASFreeSprintStartRight_IsValid && ASFreeSprintStartBwdR_IsValid && ASFreeSprintTurnBwdL_IsValid && ASFreeSprintTurnLeft_IsValid && ASFreeSprintTurnRight_IsValid && ASFreeSprintTurnBwdR_IsValid && ASFreeSprintStop_IsValid && SprintStopSlopeAngleThreshold_IsValid && ASFreeSprintStopSlopeUp_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion_Free", (byte)AnimHumanoidSetting_PlayerLocomotion_Free_IsValid != 0);
	}

	static FAnimHumanoidSetting_PlayerLocomotion_Free()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FAnimHumanoidSetting_PlayerLocomotion_Free)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimHumanoidSetting_PlayerLocomotion_Free));
	}
}
