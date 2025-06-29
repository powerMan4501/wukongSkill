using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.QuaternionSpringState", "Engine", UnrealModuleType.Engine)]
public struct FQuaternionSpringState
{
	private static bool FQuaternionSpringState_IsValid;

	private static int FQuaternionSpringState_StructSize;

	public FQuaternionSpringState Copy()
	{
		return this;
	}

	public static FQuaternionSpringState FromNative(IntPtr nativeBuffer)
	{
		return new FQuaternionSpringState(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FQuaternionSpringState value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FQuaternionSpringState FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FQuaternionSpringState(nativeBuffer + arrayIndex * FQuaternionSpringState_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FQuaternionSpringState value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FQuaternionSpringState_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FQuaternionSpringState_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.QuaternionSpringState");
		}
	}

	public FQuaternionSpringState(IntPtr nativeStruct)
	{
		if (!FQuaternionSpringState_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.QuaternionSpringState");
		}
	}

	static FQuaternionSpringState()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FQuaternionSpringState)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FQuaternionSpringState));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.QuaternionSpringState");
		FQuaternionSpringState_StructSize = NativeReflection.GetStructSize(intPtr);
		FQuaternionSpringState_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.QuaternionSpringState", FQuaternionSpringState_IsValid);
	}
}
