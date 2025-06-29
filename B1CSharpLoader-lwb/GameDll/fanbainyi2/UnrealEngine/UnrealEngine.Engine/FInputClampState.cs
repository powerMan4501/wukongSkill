using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.InputClampState", "Engine", UnrealModuleType.Engine)]
public struct FInputClampState
{
	private static bool FInputClampState_IsValid;

	private static int FInputClampState_StructSize;

	public FInputClampState Copy()
	{
		return this;
	}

	public static FInputClampState FromNative(IntPtr nativeBuffer)
	{
		return new FInputClampState(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FInputClampState value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FInputClampState FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FInputClampState(nativeBuffer + arrayIndex * FInputClampState_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FInputClampState value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FInputClampState_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FInputClampState_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.InputClampState");
		}
	}

	public FInputClampState(IntPtr nativeStruct)
	{
		if (!FInputClampState_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.InputClampState");
		}
	}

	static FInputClampState()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FInputClampState)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FInputClampState));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.InputClampState");
		FInputClampState_StructSize = NativeReflection.GetStructSize(intPtr);
		FInputClampState_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.InputClampState", FInputClampState_IsValid);
	}
}
