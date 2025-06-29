using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.AnimWheelSetting_WheelMove")]
public struct FAnimWheelSetting_WheelMove
{
	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimWheelSetting_WheelMove:MoveNearParamCurve")]
	public UCurveVector MoveNearParamCurve;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimWheelSetting_WheelMove:MoveFarParamCurve")]
	public UCurveVector MoveFarParamCurve;

	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimWheelSetting_WheelMove:ASIdle")]
	public UAnimSequence ASIdle;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimWheelSetting_WheelMove:ASSpeedUp")]
	public UAnimSequence ASSpeedUp;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimWheelSetting_WheelMove:ASSpeedDown")]
	public UAnimSequence ASSpeedDown;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimWheelSetting_WheelMove:ASMoveLoop")]
	public UAnimSequence ASMoveLoop;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimWheelSetting_WheelMove:BSRotationAdditive")]
	public UBlendSpace BSRotationAdditive;

	private static int AnimWheelSetting_WheelMove_StructSize;

	private static int AnimWheelSetting_WheelMove_IsValid;

	private static bool MoveNearParamCurve_IsValid;

	private static int MoveNearParamCurve_Offset;

	private static bool MoveFarParamCurve_IsValid;

	private static int MoveFarParamCurve_Offset;

	private static bool ASIdle_IsValid;

	private static int ASIdle_Offset;

	private static bool ASSpeedUp_IsValid;

	private static int ASSpeedUp_Offset;

	private static bool ASSpeedDown_IsValid;

	private static int ASSpeedDown_Offset;

	private static bool ASMoveLoop_IsValid;

	private static int ASMoveLoop_Offset;

	private static bool BSRotationAdditive_IsValid;

	private static int BSRotationAdditive_Offset;

	public FAnimWheelSetting_WheelMove Copy()
	{
		return this;
	}

	public static FAnimWheelSetting_WheelMove FromNative(IntPtr nativeBuffer)
	{
		return new FAnimWheelSetting_WheelMove(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimWheelSetting_WheelMove value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimWheelSetting_WheelMove FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimWheelSetting_WheelMove(IntPtr.Add(nativeBuffer, arrayIndex * AnimWheelSetting_WheelMove_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimWheelSetting_WheelMove value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * AnimWheelSetting_WheelMove_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (AnimWheelSetting_WheelMove_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimWheelSetting_WheelMove");
			return;
		}
		UObjectMarshaler<UCurveVector>.ToNative(IntPtr.Add(nativeStruct, MoveNearParamCurve_Offset), MoveNearParamCurve);
		UObjectMarshaler<UCurveVector>.ToNative(IntPtr.Add(nativeStruct, MoveFarParamCurve_Offset), MoveFarParamCurve);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASIdle_Offset), ASIdle);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASSpeedUp_Offset), ASSpeedUp);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASSpeedDown_Offset), ASSpeedDown);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASMoveLoop_Offset), ASMoveLoop);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSRotationAdditive_Offset), BSRotationAdditive);
	}

	public FAnimWheelSetting_WheelMove(IntPtr nativeStruct)
	{
		if (AnimWheelSetting_WheelMove_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimWheelSetting_WheelMove");
			MoveNearParamCurve = null;
			MoveFarParamCurve = null;
			ASIdle = null;
			ASSpeedUp = null;
			ASSpeedDown = null;
			ASMoveLoop = null;
			BSRotationAdditive = null;
		}
		else
		{
			MoveNearParamCurve = UObjectMarshaler<UCurveVector>.FromNative(IntPtr.Add(nativeStruct, MoveNearParamCurve_Offset));
			MoveFarParamCurve = UObjectMarshaler<UCurveVector>.FromNative(IntPtr.Add(nativeStruct, MoveFarParamCurve_Offset));
			ASIdle = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASIdle_Offset));
			ASSpeedUp = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASSpeedUp_Offset));
			ASSpeedDown = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASSpeedDown_Offset));
			ASMoveLoop = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASMoveLoop_Offset));
			BSRotationAdditive = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSRotationAdditive_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.AnimWheelSetting_WheelMove");
		AnimWheelSetting_WheelMove_StructSize = NativeReflection.GetStructSize(intPtr);
		MoveNearParamCurve_Offset = NativeReflection.GetPropertyOffset(intPtr, "MoveNearParamCurve");
		MoveNearParamCurve_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MoveNearParamCurve", Classes.FObjectProperty);
		MoveFarParamCurve_Offset = NativeReflection.GetPropertyOffset(intPtr, "MoveFarParamCurve");
		MoveFarParamCurve_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MoveFarParamCurve", Classes.FObjectProperty);
		ASIdle_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASIdle");
		ASIdle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASIdle", Classes.FObjectProperty);
		ASSpeedUp_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASSpeedUp");
		ASSpeedUp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASSpeedUp", Classes.FObjectProperty);
		ASSpeedDown_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASSpeedDown");
		ASSpeedDown_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASSpeedDown", Classes.FObjectProperty);
		ASMoveLoop_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASMoveLoop");
		ASMoveLoop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASMoveLoop", Classes.FObjectProperty);
		BSRotationAdditive_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSRotationAdditive");
		BSRotationAdditive_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSRotationAdditive", Classes.FObjectProperty);
		AnimWheelSetting_WheelMove_IsValid = ((intPtr != IntPtr.Zero && MoveNearParamCurve_IsValid && MoveFarParamCurve_IsValid && ASIdle_IsValid && ASSpeedUp_IsValid && ASSpeedDown_IsValid && ASMoveLoop_IsValid && BSRotationAdditive_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.AnimWheelSetting_WheelMove", (byte)AnimWheelSetting_WheelMove_IsValid != 0);
	}

	static FAnimWheelSetting_WheelMove()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FAnimWheelSetting_WheelMove)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimWheelSetting_WheelMove));
	}
}
