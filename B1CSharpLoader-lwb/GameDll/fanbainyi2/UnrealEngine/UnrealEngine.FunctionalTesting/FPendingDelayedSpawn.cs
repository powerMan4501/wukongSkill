using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.FunctionalTesting;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/FunctionalTesting.PendingDelayedSpawn", "FunctionalTesting", UnrealModuleType.Engine)]
public struct FPendingDelayedSpawn
{
	private static bool FPendingDelayedSpawn_IsValid;

	private static int FPendingDelayedSpawn_StructSize;

	public FPendingDelayedSpawn Copy()
	{
		return this;
	}

	public static FPendingDelayedSpawn FromNative(IntPtr nativeBuffer)
	{
		return new FPendingDelayedSpawn(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPendingDelayedSpawn value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPendingDelayedSpawn FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPendingDelayedSpawn(nativeBuffer + arrayIndex * FPendingDelayedSpawn_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPendingDelayedSpawn value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPendingDelayedSpawn_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPendingDelayedSpawn_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FunctionalTesting.PendingDelayedSpawn");
		}
	}

	public FPendingDelayedSpawn(IntPtr nativeStruct)
	{
		if (!FPendingDelayedSpawn_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FunctionalTesting.PendingDelayedSpawn");
		}
	}

	static FPendingDelayedSpawn()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPendingDelayedSpawn)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPendingDelayedSpawn));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/FunctionalTesting.PendingDelayedSpawn");
		FPendingDelayedSpawn_StructSize = NativeReflection.GetStructSize(intPtr);
		FPendingDelayedSpawn_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/FunctionalTesting.PendingDelayedSpawn", FPendingDelayedSpawn_IsValid);
	}
}
