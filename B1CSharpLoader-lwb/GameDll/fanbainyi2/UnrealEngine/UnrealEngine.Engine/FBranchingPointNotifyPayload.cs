using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[UMetaPath("/Script/Engine.BranchingPointNotifyPayload", "Engine", UnrealModuleType.Engine)]
public struct FBranchingPointNotifyPayload
{
	private static bool FBranchingPointNotifyPayload_IsValid;

	private static int FBranchingPointNotifyPayload_StructSize;

	public FBranchingPointNotifyPayload Copy()
	{
		return this;
	}

	public static FBranchingPointNotifyPayload FromNative(IntPtr nativeBuffer)
	{
		return new FBranchingPointNotifyPayload(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FBranchingPointNotifyPayload value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FBranchingPointNotifyPayload FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FBranchingPointNotifyPayload(nativeBuffer + arrayIndex * FBranchingPointNotifyPayload_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FBranchingPointNotifyPayload value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FBranchingPointNotifyPayload_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FBranchingPointNotifyPayload_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.BranchingPointNotifyPayload");
		}
	}

	public FBranchingPointNotifyPayload(IntPtr nativeStruct)
	{
		if (!FBranchingPointNotifyPayload_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.BranchingPointNotifyPayload");
		}
	}

	static FBranchingPointNotifyPayload()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FBranchingPointNotifyPayload)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FBranchingPointNotifyPayload));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.BranchingPointNotifyPayload");
		FBranchingPointNotifyPayload_StructSize = NativeReflection.GetStructSize(intPtr);
		FBranchingPointNotifyPayload_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.BranchingPointNotifyPayload", FBranchingPointNotifyPayload_IsValid);
	}
}
