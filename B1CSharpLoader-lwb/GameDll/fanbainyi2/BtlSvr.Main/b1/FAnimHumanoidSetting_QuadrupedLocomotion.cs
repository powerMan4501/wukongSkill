using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_QuadrupedLocomotion")]
public struct FAnimHumanoidSetting_QuadrupedLocomotion
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_QuadrupedLocomotion:AnimIdleList")]
	public List<UAnimSequence> AnimIdleList;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_QuadrupedLocomotion:BSMove")]
	public UBlendSpace BSMove;

	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_QuadrupedLocomotion:BSMoveBack")]
	public UBlendSpace BSMoveBack;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_QuadrupedLocomotion:ASWalkStop")]
	public UAnimSequence ASWalkStop;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_QuadrupedLocomotion:ASRunStartF")]
	public UAnimSequence ASRunStartF;

	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_QuadrupedLocomotion:ASRunStartL")]
	public UAnimSequence ASRunStartL;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_QuadrupedLocomotion:ASRunStartR")]
	public UAnimSequence ASRunStartR;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_QuadrupedLocomotion:ASRunStartBL")]
	public UAnimSequence ASRunStartBL;

	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_QuadrupedLocomotion:ASRunStartBR")]
	public UAnimSequence ASRunStartBR;

	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_QuadrupedLocomotion:ASRunTurnStop")]
	public UAnimSequence ASRunTurnStop;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_QuadrupedLocomotion:ASRunTurnL")]
	public UAnimSequence ASRunTurnL;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_QuadrupedLocomotion:ASRunTurnR")]
	public UAnimSequence ASRunTurnR;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_QuadrupedLocomotion:ASRunTurnBL")]
	public UAnimSequence ASRunTurnBL;

	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_QuadrupedLocomotion:ASRunTurnBR")]
	public UAnimSequence ASRunTurnBR;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_QuadrupedLocomotion:ASRunStop")]
	public UAnimSequence ASRunStop;

	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_QuadrupedLocomotion:ASRushStartF")]
	public UAnimSequence ASRushStartF;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_QuadrupedLocomotion:ASRushStartL")]
	public UAnimSequence ASRushStartL;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_QuadrupedLocomotion:ASRushStartR")]
	public UAnimSequence ASRushStartR;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_QuadrupedLocomotion:ASRushStartBL")]
	public UAnimSequence ASRushStartBL;

	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_QuadrupedLocomotion:ASRushStartBR")]
	public UAnimSequence ASRushStartBR;

	[UProperty]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_QuadrupedLocomotion:ASRushTurnStop")]
	public UAnimSequence ASRushTurnStop;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_QuadrupedLocomotion:ASRushTurnL")]
	public UAnimSequence ASRushTurnL;

	[UProperty]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_QuadrupedLocomotion:ASRushTurnR")]
	public UAnimSequence ASRushTurnR;

	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_QuadrupedLocomotion:ASRushTurnBL")]
	public UAnimSequence ASRushTurnBL;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_QuadrupedLocomotion:ASRushTurnBR")]
	public UAnimSequence ASRushTurnBR;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_QuadrupedLocomotion:ASRushStop")]
	public UAnimSequence ASRushStop;

	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_QuadrupedLocomotion:ASRunJump")]
	public UAnimSequence ASRunJump;

	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_QuadrupedLocomotion:ASRushJump")]
	public UAnimSequence ASRushJump;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_QuadrupedLocomotion:ASRunJumpSlope")]
	public UAnimSequence ASRunJumpSlope;

	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_QuadrupedLocomotion:ASRushJumpSlope")]
	public UAnimSequence ASRushJumpSlope;

	[UProperty]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_QuadrupedLocomotion:JumpSlopeAngleThreahold")]
	public float JumpSlopeAngleThreahold;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_QuadrupedLocomotion:ASRunFall")]
	public UAnimSequence ASRunFall;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_QuadrupedLocomotion:ASRushFall")]
	public UAnimSequence ASRushFall;

	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_QuadrupedLocomotion:ASRunFallSlope")]
	public UAnimSequence ASRunFallSlope;

	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_QuadrupedLocomotion:ASRushFallSlope")]
	public UAnimSequence ASRushFallSlope;

	[UProperty]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_QuadrupedLocomotion:ASRunLandMove")]
	public UAnimSequence ASRunLandMove;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_QuadrupedLocomotion:ASRushLandMove")]
	public UAnimSequence ASRushLandMove;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_QuadrupedLocomotion:ASRunLandMoveSlope")]
	public UAnimSequence ASRunLandMoveSlope;

	[UProperty]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_QuadrupedLocomotion:ASRushLandMoveSlope")]
	public UAnimSequence ASRushLandMoveSlope;

	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_QuadrupedLocomotion:ASRunLandStop")]
	public UAnimSequence ASRunLandStop;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_QuadrupedLocomotion:ASRushLandStop")]
	public UAnimSequence ASRushLandStop;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_QuadrupedLocomotion:ASRunLandStopSlope")]
	public UAnimSequence ASRunLandStopSlope;

	[UProperty]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_QuadrupedLocomotion:ASRushLandStopSlope")]
	public UAnimSequence ASRushLandStopSlope;

	private static int AnimHumanoidSetting_QuadrupedLocomotion_StructSize;

	private static int AnimHumanoidSetting_QuadrupedLocomotion_IsValid;

	private static bool AnimIdleList_IsValid;

	private static int AnimIdleList_Offset;

	private static FFieldAddress AnimIdleList_PropertyAddress;

	private static bool BSMove_IsValid;

	private static int BSMove_Offset;

	private static bool BSMoveBack_IsValid;

	private static int BSMoveBack_Offset;

	private static bool ASWalkStop_IsValid;

	private static int ASWalkStop_Offset;

	private static bool ASRunStartF_IsValid;

	private static int ASRunStartF_Offset;

	private static bool ASRunStartL_IsValid;

	private static int ASRunStartL_Offset;

	private static bool ASRunStartR_IsValid;

	private static int ASRunStartR_Offset;

	private static bool ASRunStartBL_IsValid;

	private static int ASRunStartBL_Offset;

	private static bool ASRunStartBR_IsValid;

	private static int ASRunStartBR_Offset;

	private static bool ASRunTurnStop_IsValid;

	private static int ASRunTurnStop_Offset;

	private static bool ASRunTurnL_IsValid;

	private static int ASRunTurnL_Offset;

	private static bool ASRunTurnR_IsValid;

	private static int ASRunTurnR_Offset;

	private static bool ASRunTurnBL_IsValid;

	private static int ASRunTurnBL_Offset;

	private static bool ASRunTurnBR_IsValid;

	private static int ASRunTurnBR_Offset;

	private static bool ASRunStop_IsValid;

	private static int ASRunStop_Offset;

	private static bool ASRushStartF_IsValid;

	private static int ASRushStartF_Offset;

	private static bool ASRushStartL_IsValid;

	private static int ASRushStartL_Offset;

	private static bool ASRushStartR_IsValid;

	private static int ASRushStartR_Offset;

	private static bool ASRushStartBL_IsValid;

	private static int ASRushStartBL_Offset;

	private static bool ASRushStartBR_IsValid;

	private static int ASRushStartBR_Offset;

	private static bool ASRushTurnStop_IsValid;

	private static int ASRushTurnStop_Offset;

	private static bool ASRushTurnL_IsValid;

	private static int ASRushTurnL_Offset;

	private static bool ASRushTurnR_IsValid;

	private static int ASRushTurnR_Offset;

	private static bool ASRushTurnBL_IsValid;

	private static int ASRushTurnBL_Offset;

	private static bool ASRushTurnBR_IsValid;

	private static int ASRushTurnBR_Offset;

	private static bool ASRushStop_IsValid;

	private static int ASRushStop_Offset;

	private static bool ASRunJump_IsValid;

	private static int ASRunJump_Offset;

	private static bool ASRushJump_IsValid;

	private static int ASRushJump_Offset;

	private static bool ASRunJumpSlope_IsValid;

	private static int ASRunJumpSlope_Offset;

	private static bool ASRushJumpSlope_IsValid;

	private static int ASRushJumpSlope_Offset;

	private static bool JumpSlopeAngleThreahold_IsValid;

	private static int JumpSlopeAngleThreahold_Offset;

	private static bool ASRunFall_IsValid;

	private static int ASRunFall_Offset;

	private static bool ASRushFall_IsValid;

	private static int ASRushFall_Offset;

	private static bool ASRunFallSlope_IsValid;

	private static int ASRunFallSlope_Offset;

	private static bool ASRushFallSlope_IsValid;

	private static int ASRushFallSlope_Offset;

	private static bool ASRunLandMove_IsValid;

	private static int ASRunLandMove_Offset;

	private static bool ASRushLandMove_IsValid;

	private static int ASRushLandMove_Offset;

	private static bool ASRunLandMoveSlope_IsValid;

	private static int ASRunLandMoveSlope_Offset;

	private static bool ASRushLandMoveSlope_IsValid;

	private static int ASRushLandMoveSlope_Offset;

	private static bool ASRunLandStop_IsValid;

	private static int ASRunLandStop_Offset;

	private static bool ASRushLandStop_IsValid;

	private static int ASRushLandStop_Offset;

	private static bool ASRunLandStopSlope_IsValid;

	private static int ASRunLandStopSlope_Offset;

	private static bool ASRushLandStopSlope_IsValid;

	private static int ASRushLandStopSlope_Offset;

	public FAnimHumanoidSetting_QuadrupedLocomotion Copy()
	{
		FAnimHumanoidSetting_QuadrupedLocomotion result = this;
		if (AnimIdleList != null)
		{
			result.AnimIdleList = new List<UAnimSequence>(AnimIdleList);
		}
		return result;
	}

	public static FAnimHumanoidSetting_QuadrupedLocomotion FromNative(IntPtr nativeBuffer)
	{
		return new FAnimHumanoidSetting_QuadrupedLocomotion(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimHumanoidSetting_QuadrupedLocomotion value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimHumanoidSetting_QuadrupedLocomotion FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimHumanoidSetting_QuadrupedLocomotion(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_QuadrupedLocomotion_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimHumanoidSetting_QuadrupedLocomotion value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_QuadrupedLocomotion_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_QuadrupedLocomotion_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_QuadrupedLocomotion");
			return;
		}
		new TArrayCopyMarshaler<UAnimSequence>(1, AnimIdleList_PropertyAddress, CachedMarshalingDelegates<UAnimSequence, UObjectMarshaler<UAnimSequence>>.FromNative, CachedMarshalingDelegates<UAnimSequence, UObjectMarshaler<UAnimSequence>>.ToNative).ToNative(IntPtr.Add(nativeStruct, AnimIdleList_Offset), AnimIdleList);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSMove_Offset), BSMove);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSMoveBack_Offset), BSMoveBack);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASWalkStop_Offset), ASWalkStop);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunStartF_Offset), ASRunStartF);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunStartL_Offset), ASRunStartL);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunStartR_Offset), ASRunStartR);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunStartBL_Offset), ASRunStartBL);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunStartBR_Offset), ASRunStartBR);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunTurnStop_Offset), ASRunTurnStop);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunTurnL_Offset), ASRunTurnL);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunTurnR_Offset), ASRunTurnR);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunTurnBL_Offset), ASRunTurnBL);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunTurnBR_Offset), ASRunTurnBR);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunStop_Offset), ASRunStop);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRushStartF_Offset), ASRushStartF);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRushStartL_Offset), ASRushStartL);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRushStartR_Offset), ASRushStartR);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRushStartBL_Offset), ASRushStartBL);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRushStartBR_Offset), ASRushStartBR);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRushTurnStop_Offset), ASRushTurnStop);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRushTurnL_Offset), ASRushTurnL);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRushTurnR_Offset), ASRushTurnR);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRushTurnBL_Offset), ASRushTurnBL);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRushTurnBR_Offset), ASRushTurnBR);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRushStop_Offset), ASRushStop);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunJump_Offset), ASRunJump);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRushJump_Offset), ASRushJump);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunJumpSlope_Offset), ASRunJumpSlope);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRushJumpSlope_Offset), ASRushJumpSlope);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, JumpSlopeAngleThreahold_Offset), JumpSlopeAngleThreahold);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunFall_Offset), ASRunFall);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRushFall_Offset), ASRushFall);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunFallSlope_Offset), ASRunFallSlope);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRushFallSlope_Offset), ASRushFallSlope);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunLandMove_Offset), ASRunLandMove);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRushLandMove_Offset), ASRushLandMove);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunLandMoveSlope_Offset), ASRunLandMoveSlope);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRushLandMoveSlope_Offset), ASRushLandMoveSlope);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunLandStop_Offset), ASRunLandStop);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRushLandStop_Offset), ASRushLandStop);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRunLandStopSlope_Offset), ASRunLandStopSlope);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASRushLandStopSlope_Offset), ASRushLandStopSlope);
	}

	public FAnimHumanoidSetting_QuadrupedLocomotion(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_QuadrupedLocomotion_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_QuadrupedLocomotion");
			AnimIdleList = null;
			BSMove = null;
			BSMoveBack = null;
			ASWalkStop = null;
			ASRunStartF = null;
			ASRunStartL = null;
			ASRunStartR = null;
			ASRunStartBL = null;
			ASRunStartBR = null;
			ASRunTurnStop = null;
			ASRunTurnL = null;
			ASRunTurnR = null;
			ASRunTurnBL = null;
			ASRunTurnBR = null;
			ASRunStop = null;
			ASRushStartF = null;
			ASRushStartL = null;
			ASRushStartR = null;
			ASRushStartBL = null;
			ASRushStartBR = null;
			ASRushTurnStop = null;
			ASRushTurnL = null;
			ASRushTurnR = null;
			ASRushTurnBL = null;
			ASRushTurnBR = null;
			ASRushStop = null;
			ASRunJump = null;
			ASRushJump = null;
			ASRunJumpSlope = null;
			ASRushJumpSlope = null;
			JumpSlopeAngleThreahold = 0f;
			ASRunFall = null;
			ASRushFall = null;
			ASRunFallSlope = null;
			ASRushFallSlope = null;
			ASRunLandMove = null;
			ASRushLandMove = null;
			ASRunLandMoveSlope = null;
			ASRushLandMoveSlope = null;
			ASRunLandStop = null;
			ASRushLandStop = null;
			ASRunLandStopSlope = null;
			ASRushLandStopSlope = null;
		}
		else
		{
			AnimIdleList = new TArrayCopyMarshaler<UAnimSequence>(1, AnimIdleList_PropertyAddress, CachedMarshalingDelegates<UAnimSequence, UObjectMarshaler<UAnimSequence>>.FromNative, CachedMarshalingDelegates<UAnimSequence, UObjectMarshaler<UAnimSequence>>.ToNative).FromNative(IntPtr.Add(nativeStruct, AnimIdleList_Offset));
			BSMove = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSMove_Offset));
			BSMoveBack = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSMoveBack_Offset));
			ASWalkStop = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASWalkStop_Offset));
			ASRunStartF = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunStartF_Offset));
			ASRunStartL = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunStartL_Offset));
			ASRunStartR = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunStartR_Offset));
			ASRunStartBL = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunStartBL_Offset));
			ASRunStartBR = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunStartBR_Offset));
			ASRunTurnStop = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunTurnStop_Offset));
			ASRunTurnL = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunTurnL_Offset));
			ASRunTurnR = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunTurnR_Offset));
			ASRunTurnBL = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunTurnBL_Offset));
			ASRunTurnBR = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunTurnBR_Offset));
			ASRunStop = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunStop_Offset));
			ASRushStartF = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRushStartF_Offset));
			ASRushStartL = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRushStartL_Offset));
			ASRushStartR = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRushStartR_Offset));
			ASRushStartBL = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRushStartBL_Offset));
			ASRushStartBR = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRushStartBR_Offset));
			ASRushTurnStop = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRushTurnStop_Offset));
			ASRushTurnL = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRushTurnL_Offset));
			ASRushTurnR = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRushTurnR_Offset));
			ASRushTurnBL = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRushTurnBL_Offset));
			ASRushTurnBR = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRushTurnBR_Offset));
			ASRushStop = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRushStop_Offset));
			ASRunJump = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunJump_Offset));
			ASRushJump = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRushJump_Offset));
			ASRunJumpSlope = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunJumpSlope_Offset));
			ASRushJumpSlope = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRushJumpSlope_Offset));
			JumpSlopeAngleThreahold = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, JumpSlopeAngleThreahold_Offset));
			ASRunFall = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunFall_Offset));
			ASRushFall = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRushFall_Offset));
			ASRunFallSlope = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunFallSlope_Offset));
			ASRushFallSlope = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRushFallSlope_Offset));
			ASRunLandMove = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunLandMove_Offset));
			ASRushLandMove = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRushLandMove_Offset));
			ASRunLandMoveSlope = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunLandMoveSlope_Offset));
			ASRushLandMoveSlope = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRushLandMoveSlope_Offset));
			ASRunLandStop = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunLandStop_Offset));
			ASRushLandStop = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRushLandStop_Offset));
			ASRunLandStopSlope = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRunLandStopSlope_Offset));
			ASRushLandStopSlope = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASRushLandStopSlope_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.AnimHumanoidSetting_QuadrupedLocomotion");
		AnimHumanoidSetting_QuadrupedLocomotion_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref AnimIdleList_PropertyAddress, intPtr, "AnimIdleList");
		AnimIdleList_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimIdleList");
		AnimIdleList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimIdleList", Classes.FArrayProperty);
		BSMove_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSMove");
		BSMove_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSMove", Classes.FObjectProperty);
		BSMoveBack_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSMoveBack");
		BSMoveBack_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSMoveBack", Classes.FObjectProperty);
		ASWalkStop_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASWalkStop");
		ASWalkStop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASWalkStop", Classes.FObjectProperty);
		ASRunStartF_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunStartF");
		ASRunStartF_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunStartF", Classes.FObjectProperty);
		ASRunStartL_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunStartL");
		ASRunStartL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunStartL", Classes.FObjectProperty);
		ASRunStartR_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunStartR");
		ASRunStartR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunStartR", Classes.FObjectProperty);
		ASRunStartBL_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunStartBL");
		ASRunStartBL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunStartBL", Classes.FObjectProperty);
		ASRunStartBR_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunStartBR");
		ASRunStartBR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunStartBR", Classes.FObjectProperty);
		ASRunTurnStop_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunTurnStop");
		ASRunTurnStop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunTurnStop", Classes.FObjectProperty);
		ASRunTurnL_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunTurnL");
		ASRunTurnL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunTurnL", Classes.FObjectProperty);
		ASRunTurnR_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunTurnR");
		ASRunTurnR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunTurnR", Classes.FObjectProperty);
		ASRunTurnBL_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunTurnBL");
		ASRunTurnBL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunTurnBL", Classes.FObjectProperty);
		ASRunTurnBR_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunTurnBR");
		ASRunTurnBR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunTurnBR", Classes.FObjectProperty);
		ASRunStop_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunStop");
		ASRunStop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunStop", Classes.FObjectProperty);
		ASRushStartF_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRushStartF");
		ASRushStartF_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRushStartF", Classes.FObjectProperty);
		ASRushStartL_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRushStartL");
		ASRushStartL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRushStartL", Classes.FObjectProperty);
		ASRushStartR_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRushStartR");
		ASRushStartR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRushStartR", Classes.FObjectProperty);
		ASRushStartBL_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRushStartBL");
		ASRushStartBL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRushStartBL", Classes.FObjectProperty);
		ASRushStartBR_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRushStartBR");
		ASRushStartBR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRushStartBR", Classes.FObjectProperty);
		ASRushTurnStop_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRushTurnStop");
		ASRushTurnStop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRushTurnStop", Classes.FObjectProperty);
		ASRushTurnL_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRushTurnL");
		ASRushTurnL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRushTurnL", Classes.FObjectProperty);
		ASRushTurnR_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRushTurnR");
		ASRushTurnR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRushTurnR", Classes.FObjectProperty);
		ASRushTurnBL_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRushTurnBL");
		ASRushTurnBL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRushTurnBL", Classes.FObjectProperty);
		ASRushTurnBR_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRushTurnBR");
		ASRushTurnBR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRushTurnBR", Classes.FObjectProperty);
		ASRushStop_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRushStop");
		ASRushStop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRushStop", Classes.FObjectProperty);
		ASRunJump_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunJump");
		ASRunJump_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunJump", Classes.FObjectProperty);
		ASRushJump_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRushJump");
		ASRushJump_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRushJump", Classes.FObjectProperty);
		ASRunJumpSlope_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunJumpSlope");
		ASRunJumpSlope_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunJumpSlope", Classes.FObjectProperty);
		ASRushJumpSlope_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRushJumpSlope");
		ASRushJumpSlope_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRushJumpSlope", Classes.FObjectProperty);
		JumpSlopeAngleThreahold_Offset = NativeReflection.GetPropertyOffset(intPtr, "JumpSlopeAngleThreahold");
		JumpSlopeAngleThreahold_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "JumpSlopeAngleThreahold", Classes.FFloatProperty);
		ASRunFall_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunFall");
		ASRunFall_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunFall", Classes.FObjectProperty);
		ASRushFall_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRushFall");
		ASRushFall_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRushFall", Classes.FObjectProperty);
		ASRunFallSlope_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunFallSlope");
		ASRunFallSlope_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunFallSlope", Classes.FObjectProperty);
		ASRushFallSlope_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRushFallSlope");
		ASRushFallSlope_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRushFallSlope", Classes.FObjectProperty);
		ASRunLandMove_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunLandMove");
		ASRunLandMove_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunLandMove", Classes.FObjectProperty);
		ASRushLandMove_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRushLandMove");
		ASRushLandMove_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRushLandMove", Classes.FObjectProperty);
		ASRunLandMoveSlope_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunLandMoveSlope");
		ASRunLandMoveSlope_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunLandMoveSlope", Classes.FObjectProperty);
		ASRushLandMoveSlope_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRushLandMoveSlope");
		ASRushLandMoveSlope_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRushLandMoveSlope", Classes.FObjectProperty);
		ASRunLandStop_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunLandStop");
		ASRunLandStop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunLandStop", Classes.FObjectProperty);
		ASRushLandStop_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRushLandStop");
		ASRushLandStop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRushLandStop", Classes.FObjectProperty);
		ASRunLandStopSlope_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRunLandStopSlope");
		ASRunLandStopSlope_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRunLandStopSlope", Classes.FObjectProperty);
		ASRushLandStopSlope_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASRushLandStopSlope");
		ASRushLandStopSlope_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASRushLandStopSlope", Classes.FObjectProperty);
		AnimHumanoidSetting_QuadrupedLocomotion_IsValid = ((intPtr != IntPtr.Zero && AnimIdleList_IsValid && BSMove_IsValid && BSMoveBack_IsValid && ASWalkStop_IsValid && ASRunStartF_IsValid && ASRunStartL_IsValid && ASRunStartR_IsValid && ASRunStartBL_IsValid && ASRunStartBR_IsValid && ASRunTurnStop_IsValid && ASRunTurnL_IsValid && ASRunTurnR_IsValid && ASRunTurnBL_IsValid && ASRunTurnBR_IsValid && ASRunStop_IsValid && ASRushStartF_IsValid && ASRushStartL_IsValid && ASRushStartR_IsValid && ASRushStartBL_IsValid && ASRushStartBR_IsValid && ASRushTurnStop_IsValid && ASRushTurnL_IsValid && ASRushTurnR_IsValid && ASRushTurnBL_IsValid && ASRushTurnBR_IsValid && ASRushStop_IsValid && ASRunJump_IsValid && ASRushJump_IsValid && ASRunJumpSlope_IsValid && ASRushJumpSlope_IsValid && JumpSlopeAngleThreahold_IsValid && ASRunFall_IsValid && ASRushFall_IsValid && ASRunFallSlope_IsValid && ASRushFallSlope_IsValid && ASRunLandMove_IsValid && ASRushLandMove_IsValid && ASRunLandMoveSlope_IsValid && ASRushLandMoveSlope_IsValid && ASRunLandStop_IsValid && ASRushLandStop_IsValid && ASRunLandStopSlope_IsValid && ASRushLandStopSlope_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.AnimHumanoidSetting_QuadrupedLocomotion", (byte)AnimHumanoidSetting_QuadrupedLocomotion_IsValid != 0);
	}

	static FAnimHumanoidSetting_QuadrupedLocomotion()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FAnimHumanoidSetting_QuadrupedLocomotion)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimHumanoidSetting_QuadrupedLocomotion));
	}
}
