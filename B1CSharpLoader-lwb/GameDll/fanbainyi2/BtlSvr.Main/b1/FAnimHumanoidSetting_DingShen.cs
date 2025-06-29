using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_DingShen")]
public struct FAnimHumanoidSetting_DingShen
{
	[EditAnywhere]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_DingShen:AnimDingShenStart")]
	public UAnimSequence AnimDingShenStart;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_DingShen:AnimDingShenHold")]
	public UAnimSequence AnimDingShenHold;

	private static int AnimHumanoidSetting_DingShen_StructSize;

	private static int AnimHumanoidSetting_DingShen_IsValid;

	private static bool AnimDingShenStart_IsValid;

	private static int AnimDingShenStart_Offset;

	private static bool AnimDingShenHold_IsValid;

	private static int AnimDingShenHold_Offset;

	public FAnimHumanoidSetting_DingShen Copy()
	{
		return this;
	}

	public static FAnimHumanoidSetting_DingShen FromNative(IntPtr nativeBuffer)
	{
		return new FAnimHumanoidSetting_DingShen(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimHumanoidSetting_DingShen value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimHumanoidSetting_DingShen FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimHumanoidSetting_DingShen(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_DingShen_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimHumanoidSetting_DingShen value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_DingShen_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_DingShen_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_DingShen");
			return;
		}
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, AnimDingShenStart_Offset), AnimDingShenStart);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, AnimDingShenHold_Offset), AnimDingShenHold);
	}

	public FAnimHumanoidSetting_DingShen(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_DingShen_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_DingShen");
			AnimDingShenStart = null;
			AnimDingShenHold = null;
		}
		else
		{
			AnimDingShenStart = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, AnimDingShenStart_Offset));
			AnimDingShenHold = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, AnimDingShenHold_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.AnimHumanoidSetting_DingShen");
		AnimHumanoidSetting_DingShen_StructSize = NativeReflection.GetStructSize(intPtr);
		AnimDingShenStart_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimDingShenStart");
		AnimDingShenStart_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimDingShenStart", Classes.FObjectProperty);
		AnimDingShenHold_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimDingShenHold");
		AnimDingShenHold_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimDingShenHold", Classes.FObjectProperty);
		AnimHumanoidSetting_DingShen_IsValid = ((intPtr != IntPtr.Zero && AnimDingShenStart_IsValid && AnimDingShenHold_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.AnimHumanoidSetting_DingShen", (byte)AnimHumanoidSetting_DingShen_IsValid != 0);
	}

	static FAnimHumanoidSetting_DingShen()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FAnimHumanoidSetting_DingShen)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimHumanoidSetting_DingShen));
	}
}
