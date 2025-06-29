using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 57352)]
[BlueprintType]
[UMetaPath("/Script/Engine.FloatRK4SpringInterpolator", "Engine", UnrealModuleType.Engine)]
public struct FFloatRK4SpringInterpolator
{
	private static bool FFloatRK4SpringInterpolator_IsValid;

	private static int FFloatRK4SpringInterpolator_StructSize;

	public FFloatRK4SpringInterpolator Copy()
	{
		return this;
	}

	public static FFloatRK4SpringInterpolator FromNative(IntPtr nativeBuffer)
	{
		return new FFloatRK4SpringInterpolator(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FFloatRK4SpringInterpolator value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FFloatRK4SpringInterpolator FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FFloatRK4SpringInterpolator(nativeBuffer + arrayIndex * FFloatRK4SpringInterpolator_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FFloatRK4SpringInterpolator value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FFloatRK4SpringInterpolator_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FFloatRK4SpringInterpolator_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.FloatRK4SpringInterpolator");
		}
	}

	public FFloatRK4SpringInterpolator(IntPtr nativeStruct)
	{
		if (!FFloatRK4SpringInterpolator_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.FloatRK4SpringInterpolator");
		}
	}

	static FFloatRK4SpringInterpolator()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FFloatRK4SpringInterpolator)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FFloatRK4SpringInterpolator));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.FloatRK4SpringInterpolator");
		FFloatRK4SpringInterpolator_StructSize = NativeReflection.GetStructSize(intPtr);
		FFloatRK4SpringInterpolator_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.FloatRK4SpringInterpolator", FFloatRK4SpringInterpolator_IsValid);
	}
}
