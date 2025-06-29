using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimationBlueprintLibrary;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AnimationBlueprintLibrary.AnimPose", "AnimationBlueprintLibrary", UnrealModuleType.Engine)]
public struct FAnimPose
{
	private static bool FAnimPose_IsValid;

	private static int FAnimPose_StructSize;

	public FAnimPose Copy()
	{
		return this;
	}

	public static FAnimPose FromNative(IntPtr nativeBuffer)
	{
		return new FAnimPose(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimPose value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimPose FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimPose(nativeBuffer + arrayIndex * FAnimPose_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimPose value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimPose_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimPose_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimationBlueprintLibrary.AnimPose");
		}
	}

	public FAnimPose(IntPtr nativeStruct)
	{
		if (!FAnimPose_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimationBlueprintLibrary.AnimPose");
		}
	}

	static FAnimPose()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimPose)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimPose));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AnimationBlueprintLibrary.AnimPose");
		FAnimPose_StructSize = NativeReflection.GetStructSize(intPtr);
		FAnimPose_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/AnimationBlueprintLibrary.AnimPose", FAnimPose_IsValid);
	}
}
