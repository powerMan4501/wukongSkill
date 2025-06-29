using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.FloatSpringState", "Engine", UnrealModuleType.Engine)]
public struct FFloatSpringState
{
	private static bool FFloatSpringState_IsValid;

	private static int FFloatSpringState_StructSize;

	public FFloatSpringState Copy()
	{
		return this;
	}

	public static FFloatSpringState FromNative(IntPtr nativeBuffer)
	{
		return new FFloatSpringState(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FFloatSpringState value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FFloatSpringState FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FFloatSpringState(nativeBuffer + arrayIndex * FFloatSpringState_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FFloatSpringState value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FFloatSpringState_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FFloatSpringState_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.FloatSpringState");
		}
	}

	public FFloatSpringState(IntPtr nativeStruct)
	{
		if (!FFloatSpringState_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.FloatSpringState");
		}
	}

	static FFloatSpringState()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FFloatSpringState)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FFloatSpringState));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.FloatSpringState");
		FFloatSpringState_StructSize = NativeReflection.GetStructSize(intPtr);
		FFloatSpringState_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.FloatSpringState", FFloatSpringState_IsValid);
	}
}
