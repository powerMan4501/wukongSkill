using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_GlideJump")]
public struct FAnimHumanoidSetting_GlideJump
{
	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_GlideJump:ASGlideJumpStart")]
	public UAnimSequence ASGlideJumpStart;

	private static int AnimHumanoidSetting_GlideJump_StructSize;

	private static int AnimHumanoidSetting_GlideJump_IsValid;

	private static bool ASGlideJumpStart_IsValid;

	private static int ASGlideJumpStart_Offset;

	public FAnimHumanoidSetting_GlideJump Copy()
	{
		return this;
	}

	public static FAnimHumanoidSetting_GlideJump FromNative(IntPtr nativeBuffer)
	{
		return new FAnimHumanoidSetting_GlideJump(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimHumanoidSetting_GlideJump value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimHumanoidSetting_GlideJump FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimHumanoidSetting_GlideJump(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_GlideJump_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimHumanoidSetting_GlideJump value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_GlideJump_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_GlideJump_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_GlideJump");
		}
		else
		{
			UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASGlideJumpStart_Offset), ASGlideJumpStart);
		}
	}

	public FAnimHumanoidSetting_GlideJump(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_GlideJump_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_GlideJump");
			ASGlideJumpStart = null;
		}
		else
		{
			ASGlideJumpStart = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASGlideJumpStart_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.AnimHumanoidSetting_GlideJump");
		AnimHumanoidSetting_GlideJump_StructSize = NativeReflection.GetStructSize(intPtr);
		ASGlideJumpStart_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASGlideJumpStart");
		ASGlideJumpStart_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASGlideJumpStart", Classes.FObjectProperty);
		AnimHumanoidSetting_GlideJump_IsValid = ((intPtr != IntPtr.Zero && ASGlideJumpStart_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.AnimHumanoidSetting_GlideJump", (byte)AnimHumanoidSetting_GlideJump_IsValid != 0);
	}

	static FAnimHumanoidSetting_GlideJump()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FAnimHumanoidSetting_GlideJump)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimHumanoidSetting_GlideJump));
	}
}
