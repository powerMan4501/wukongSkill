using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/AnimGraphRuntime.SkeletalControlReference", "AnimGraphRuntime", UnrealModuleType.Engine)]
public struct FSkeletalControlReference
{
	private static bool FSkeletalControlReference_IsValid;

	private static int FSkeletalControlReference_StructSize;

	public FSkeletalControlReference Copy()
	{
		return this;
	}

	public static FSkeletalControlReference FromNative(IntPtr nativeBuffer)
	{
		return new FSkeletalControlReference(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSkeletalControlReference value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSkeletalControlReference FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSkeletalControlReference(nativeBuffer + arrayIndex * FSkeletalControlReference_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSkeletalControlReference value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSkeletalControlReference_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSkeletalControlReference_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.SkeletalControlReference");
		}
	}

	public FSkeletalControlReference(IntPtr nativeStruct)
	{
		if (!FSkeletalControlReference_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.SkeletalControlReference");
		}
	}

	static FSkeletalControlReference()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSkeletalControlReference)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSkeletalControlReference));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AnimGraphRuntime.SkeletalControlReference");
		FSkeletalControlReference_StructSize = NativeReflection.GetStructSize(intPtr);
		FSkeletalControlReference_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/AnimGraphRuntime.SkeletalControlReference", FSkeletalControlReference_IsValid);
	}
}
