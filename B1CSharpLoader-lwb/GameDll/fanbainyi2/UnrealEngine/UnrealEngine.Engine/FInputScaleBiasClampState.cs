using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.InputScaleBiasClampState", "Engine", UnrealModuleType.Engine)]
public struct FInputScaleBiasClampState
{
	private static bool FInputScaleBiasClampState_IsValid;

	private static int FInputScaleBiasClampState_StructSize;

	public FInputScaleBiasClampState Copy()
	{
		return this;
	}

	public static FInputScaleBiasClampState FromNative(IntPtr nativeBuffer)
	{
		return new FInputScaleBiasClampState(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FInputScaleBiasClampState value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FInputScaleBiasClampState FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FInputScaleBiasClampState(nativeBuffer + arrayIndex * FInputScaleBiasClampState_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FInputScaleBiasClampState value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FInputScaleBiasClampState_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FInputScaleBiasClampState_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.InputScaleBiasClampState");
		}
	}

	public FInputScaleBiasClampState(IntPtr nativeStruct)
	{
		if (!FInputScaleBiasClampState_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.InputScaleBiasClampState");
		}
	}

	static FInputScaleBiasClampState()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FInputScaleBiasClampState)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FInputScaleBiasClampState));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.InputScaleBiasClampState");
		FInputScaleBiasClampState_StructSize = NativeReflection.GetStructSize(intPtr);
		FInputScaleBiasClampState_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.InputScaleBiasClampState", FInputScaleBiasClampState_IsValid);
	}
}
