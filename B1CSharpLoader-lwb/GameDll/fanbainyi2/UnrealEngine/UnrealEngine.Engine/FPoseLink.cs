using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.PoseLink", "Engine", UnrealModuleType.Engine)]
public struct FPoseLink
{
	private static bool FPoseLink_IsValid;

	private static int FPoseLink_StructSize;

	public FPoseLink Copy()
	{
		return this;
	}

	public static FPoseLink FromNative(IntPtr nativeBuffer)
	{
		return new FPoseLink(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPoseLink value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPoseLink FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPoseLink(nativeBuffer + arrayIndex * FPoseLink_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPoseLink value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPoseLink_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPoseLink_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.PoseLink");
		}
	}

	public FPoseLink(IntPtr nativeStruct)
	{
		if (!FPoseLink_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.PoseLink");
		}
	}

	static FPoseLink()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPoseLink)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPoseLink));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.PoseLink");
		FPoseLink_StructSize = NativeReflection.GetStructSize(intPtr);
		FPoseLink_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.PoseLink", FPoseLink_IsValid);
	}
}
