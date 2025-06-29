using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/AnimGraphRuntime.AnimationStateResultReference", "AnimGraphRuntime", UnrealModuleType.Engine)]
public struct FAnimationStateResultReference
{
	private static bool FAnimationStateResultReference_IsValid;

	private static int FAnimationStateResultReference_StructSize;

	public FAnimationStateResultReference Copy()
	{
		return this;
	}

	public static FAnimationStateResultReference FromNative(IntPtr nativeBuffer)
	{
		return new FAnimationStateResultReference(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimationStateResultReference value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimationStateResultReference FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimationStateResultReference(nativeBuffer + arrayIndex * FAnimationStateResultReference_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimationStateResultReference value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimationStateResultReference_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimationStateResultReference_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimationStateResultReference");
		}
	}

	public FAnimationStateResultReference(IntPtr nativeStruct)
	{
		if (!FAnimationStateResultReference_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimationStateResultReference");
		}
	}

	static FAnimationStateResultReference()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimationStateResultReference)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimationStateResultReference));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AnimGraphRuntime.AnimationStateResultReference");
		FAnimationStateResultReference_StructSize = NativeReflection.GetStructSize(intPtr);
		FAnimationStateResultReference_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/AnimGraphRuntime.AnimationStateResultReference", FAnimationStateResultReference_IsValid);
	}
}
