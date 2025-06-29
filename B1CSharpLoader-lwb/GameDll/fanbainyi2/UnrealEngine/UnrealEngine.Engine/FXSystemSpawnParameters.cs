using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.FXSystemSpawnParameters", "Engine", UnrealModuleType.Engine)]
public struct FXSystemSpawnParameters
{
	private static bool FXSystemSpawnParameters_IsValid;

	private static int FXSystemSpawnParameters_StructSize;

	public FXSystemSpawnParameters Copy()
	{
		return this;
	}

	public static FXSystemSpawnParameters FromNative(IntPtr nativeBuffer)
	{
		return new FXSystemSpawnParameters(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FXSystemSpawnParameters value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FXSystemSpawnParameters FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FXSystemSpawnParameters(nativeBuffer + arrayIndex * FXSystemSpawnParameters_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FXSystemSpawnParameters value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FXSystemSpawnParameters_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FXSystemSpawnParameters_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.FXSystemSpawnParameters");
		}
	}

	public FXSystemSpawnParameters(IntPtr nativeStruct)
	{
		if (!FXSystemSpawnParameters_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.FXSystemSpawnParameters");
		}
	}

	static FXSystemSpawnParameters()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FXSystemSpawnParameters)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FXSystemSpawnParameters));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.FXSystemSpawnParameters");
		FXSystemSpawnParameters_StructSize = NativeReflection.GetStructSize(intPtr);
		FXSystemSpawnParameters_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.FXSystemSpawnParameters", FXSystemSpawnParameters_IsValid);
	}
}
