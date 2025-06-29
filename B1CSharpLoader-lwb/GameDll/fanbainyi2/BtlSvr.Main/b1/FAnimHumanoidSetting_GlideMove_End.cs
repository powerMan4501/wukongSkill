using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_GlideMove_End")]
public struct FAnimHumanoidSetting_GlideMove_End
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_GlideMove_End:ASGlideEndSlow")]
	public UAnimSequence ASGlideEndSlow;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_GlideMove_End:ASGlideEndFast")]
	public UAnimSequence ASGlideEndFast;

	private static int AnimHumanoidSetting_GlideMove_End_StructSize;

	private static int AnimHumanoidSetting_GlideMove_End_IsValid;

	private static bool ASGlideEndSlow_IsValid;

	private static int ASGlideEndSlow_Offset;

	private static bool ASGlideEndFast_IsValid;

	private static int ASGlideEndFast_Offset;

	public FAnimHumanoidSetting_GlideMove_End Copy()
	{
		return this;
	}

	public static FAnimHumanoidSetting_GlideMove_End FromNative(IntPtr nativeBuffer)
	{
		return new FAnimHumanoidSetting_GlideMove_End(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimHumanoidSetting_GlideMove_End value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimHumanoidSetting_GlideMove_End FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimHumanoidSetting_GlideMove_End(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_GlideMove_End_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimHumanoidSetting_GlideMove_End value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_GlideMove_End_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_GlideMove_End_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_GlideMove_End");
			return;
		}
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASGlideEndSlow_Offset), ASGlideEndSlow);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASGlideEndFast_Offset), ASGlideEndFast);
	}

	public FAnimHumanoidSetting_GlideMove_End(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_GlideMove_End_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_GlideMove_End");
			ASGlideEndSlow = null;
			ASGlideEndFast = null;
		}
		else
		{
			ASGlideEndSlow = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASGlideEndSlow_Offset));
			ASGlideEndFast = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASGlideEndFast_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.AnimHumanoidSetting_GlideMove_End");
		AnimHumanoidSetting_GlideMove_End_StructSize = NativeReflection.GetStructSize(intPtr);
		ASGlideEndSlow_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASGlideEndSlow");
		ASGlideEndSlow_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASGlideEndSlow", Classes.FObjectProperty);
		ASGlideEndFast_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASGlideEndFast");
		ASGlideEndFast_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASGlideEndFast", Classes.FObjectProperty);
		AnimHumanoidSetting_GlideMove_End_IsValid = ((intPtr != IntPtr.Zero && ASGlideEndSlow_IsValid && ASGlideEndFast_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.AnimHumanoidSetting_GlideMove_End", (byte)AnimHumanoidSetting_GlideMove_End_IsValid != 0);
	}

	static FAnimHumanoidSetting_GlideMove_End()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FAnimHumanoidSetting_GlideMove_End)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimHumanoidSetting_GlideMove_End));
	}
}
