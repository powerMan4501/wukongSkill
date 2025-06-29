using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_GlideMove_Loop")]
public struct FAnimHumanoidSetting_GlideMove_Loop
{
	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_GlideMove_Loop:ASGlideLoopSteep")]
	public UAnimSequence ASGlideLoopSteep;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_GlideMove_Loop:BSGlideLoopSteepAdditive")]
	public UBlendSpace BSGlideLoopSteepAdditive;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_GlideMove_Loop:ASGlideLoopFlatSlow")]
	public UAnimSequence ASGlideLoopFlatSlow;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_GlideMove_Loop:ASGlideLoopFlatFast")]
	public UAnimSequence ASGlideLoopFlatFast;

	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_GlideMove_Loop:BSGlideLoopFlatSlowDirAdditive")]
	public UBlendSpace BSGlideLoopFlatSlowDirAdditive;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_GlideMove_Loop:BSGlideLoopFlatFastDirAdditive")]
	public UBlendSpace BSGlideLoopFlatFastDirAdditive;

	[UProperty]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_GlideMove_Loop:BSGlideLoopFlatVerticalInputAdditive")]
	public UBlendSpace BSGlideLoopFlatVerticalInputAdditive;

	[UProperty]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_GlideMove_Loop:BSGlideLoopFlatHorizonalInputAdditive")]
	public UBlendSpace BSGlideLoopFlatHorizonalInputAdditive;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_GlideMove_Loop:ASGlideLoopFlatRotationLeftAdditive")]
	public UAnimSequence ASGlideLoopFlatRotationLeftAdditive;

	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_GlideMove_Loop:ASGlideLoopFlatRotationRightAdditive")]
	public UAnimSequence ASGlideLoopFlatRotationRightAdditive;

	private static int AnimHumanoidSetting_GlideMove_Loop_StructSize;

	private static int AnimHumanoidSetting_GlideMove_Loop_IsValid;

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

	private static bool BSGlideLoopFlatVerticalInputAdditive_IsValid;

	private static int BSGlideLoopFlatVerticalInputAdditive_Offset;

	private static bool BSGlideLoopFlatHorizonalInputAdditive_IsValid;

	private static int BSGlideLoopFlatHorizonalInputAdditive_Offset;

	private static bool ASGlideLoopFlatRotationLeftAdditive_IsValid;

	private static int ASGlideLoopFlatRotationLeftAdditive_Offset;

	private static bool ASGlideLoopFlatRotationRightAdditive_IsValid;

	private static int ASGlideLoopFlatRotationRightAdditive_Offset;

	public FAnimHumanoidSetting_GlideMove_Loop Copy()
	{
		return this;
	}

	public static FAnimHumanoidSetting_GlideMove_Loop FromNative(IntPtr nativeBuffer)
	{
		return new FAnimHumanoidSetting_GlideMove_Loop(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimHumanoidSetting_GlideMove_Loop value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimHumanoidSetting_GlideMove_Loop FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimHumanoidSetting_GlideMove_Loop(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_GlideMove_Loop_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimHumanoidSetting_GlideMove_Loop value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_GlideMove_Loop_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_GlideMove_Loop_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_GlideMove_Loop");
			return;
		}
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASGlideLoopSteep_Offset), ASGlideLoopSteep);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSGlideLoopSteepAdditive_Offset), BSGlideLoopSteepAdditive);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASGlideLoopFlatSlow_Offset), ASGlideLoopFlatSlow);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASGlideLoopFlatFast_Offset), ASGlideLoopFlatFast);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSGlideLoopFlatSlowDirAdditive_Offset), BSGlideLoopFlatSlowDirAdditive);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSGlideLoopFlatFastDirAdditive_Offset), BSGlideLoopFlatFastDirAdditive);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSGlideLoopFlatVerticalInputAdditive_Offset), BSGlideLoopFlatVerticalInputAdditive);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSGlideLoopFlatHorizonalInputAdditive_Offset), BSGlideLoopFlatHorizonalInputAdditive);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASGlideLoopFlatRotationLeftAdditive_Offset), ASGlideLoopFlatRotationLeftAdditive);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASGlideLoopFlatRotationRightAdditive_Offset), ASGlideLoopFlatRotationRightAdditive);
	}

	public FAnimHumanoidSetting_GlideMove_Loop(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_GlideMove_Loop_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_GlideMove_Loop");
			ASGlideLoopSteep = null;
			BSGlideLoopSteepAdditive = null;
			ASGlideLoopFlatSlow = null;
			ASGlideLoopFlatFast = null;
			BSGlideLoopFlatSlowDirAdditive = null;
			BSGlideLoopFlatFastDirAdditive = null;
			BSGlideLoopFlatVerticalInputAdditive = null;
			BSGlideLoopFlatHorizonalInputAdditive = null;
			ASGlideLoopFlatRotationLeftAdditive = null;
			ASGlideLoopFlatRotationRightAdditive = null;
		}
		else
		{
			ASGlideLoopSteep = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASGlideLoopSteep_Offset));
			BSGlideLoopSteepAdditive = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSGlideLoopSteepAdditive_Offset));
			ASGlideLoopFlatSlow = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASGlideLoopFlatSlow_Offset));
			ASGlideLoopFlatFast = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASGlideLoopFlatFast_Offset));
			BSGlideLoopFlatSlowDirAdditive = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSGlideLoopFlatSlowDirAdditive_Offset));
			BSGlideLoopFlatFastDirAdditive = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSGlideLoopFlatFastDirAdditive_Offset));
			BSGlideLoopFlatVerticalInputAdditive = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSGlideLoopFlatVerticalInputAdditive_Offset));
			BSGlideLoopFlatHorizonalInputAdditive = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSGlideLoopFlatHorizonalInputAdditive_Offset));
			ASGlideLoopFlatRotationLeftAdditive = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASGlideLoopFlatRotationLeftAdditive_Offset));
			ASGlideLoopFlatRotationRightAdditive = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASGlideLoopFlatRotationRightAdditive_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.AnimHumanoidSetting_GlideMove_Loop");
		AnimHumanoidSetting_GlideMove_Loop_StructSize = NativeReflection.GetStructSize(intPtr);
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
		BSGlideLoopFlatVerticalInputAdditive_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSGlideLoopFlatVerticalInputAdditive");
		BSGlideLoopFlatVerticalInputAdditive_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSGlideLoopFlatVerticalInputAdditive", Classes.FObjectProperty);
		BSGlideLoopFlatHorizonalInputAdditive_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSGlideLoopFlatHorizonalInputAdditive");
		BSGlideLoopFlatHorizonalInputAdditive_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSGlideLoopFlatHorizonalInputAdditive", Classes.FObjectProperty);
		ASGlideLoopFlatRotationLeftAdditive_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASGlideLoopFlatRotationLeftAdditive");
		ASGlideLoopFlatRotationLeftAdditive_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASGlideLoopFlatRotationLeftAdditive", Classes.FObjectProperty);
		ASGlideLoopFlatRotationRightAdditive_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASGlideLoopFlatRotationRightAdditive");
		ASGlideLoopFlatRotationRightAdditive_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASGlideLoopFlatRotationRightAdditive", Classes.FObjectProperty);
		AnimHumanoidSetting_GlideMove_Loop_IsValid = ((intPtr != IntPtr.Zero && ASGlideLoopSteep_IsValid && BSGlideLoopSteepAdditive_IsValid && ASGlideLoopFlatSlow_IsValid && ASGlideLoopFlatFast_IsValid && BSGlideLoopFlatSlowDirAdditive_IsValid && BSGlideLoopFlatFastDirAdditive_IsValid && BSGlideLoopFlatVerticalInputAdditive_IsValid && BSGlideLoopFlatHorizonalInputAdditive_IsValid && ASGlideLoopFlatRotationLeftAdditive_IsValid && ASGlideLoopFlatRotationRightAdditive_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.AnimHumanoidSetting_GlideMove_Loop", (byte)AnimHumanoidSetting_GlideMove_Loop_IsValid != 0);
	}

	static FAnimHumanoidSetting_GlideMove_Loop()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FAnimHumanoidSetting_GlideMove_Loop)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimHumanoidSetting_GlideMove_Loop));
	}
}
