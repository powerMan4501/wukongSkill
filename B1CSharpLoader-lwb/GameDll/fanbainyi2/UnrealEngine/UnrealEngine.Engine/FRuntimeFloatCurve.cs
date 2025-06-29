using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.RuntimeFloatCurve", "Engine", UnrealModuleType.Engine)]
public struct FRuntimeFloatCurve
{
	private static bool FRuntimeFloatCurve_IsValid;

	private static int FRuntimeFloatCurve_StructSize;

	public FRuntimeFloatCurve Copy()
	{
		return this;
	}

	public static FRuntimeFloatCurve FromNative(IntPtr nativeBuffer)
	{
		return new FRuntimeFloatCurve(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRuntimeFloatCurve value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRuntimeFloatCurve FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRuntimeFloatCurve(nativeBuffer + arrayIndex * FRuntimeFloatCurve_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRuntimeFloatCurve value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRuntimeFloatCurve_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRuntimeFloatCurve_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.RuntimeFloatCurve");
		}
	}

	public FRuntimeFloatCurve(IntPtr nativeStruct)
	{
		if (!FRuntimeFloatCurve_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.RuntimeFloatCurve");
		}
	}

	static FRuntimeFloatCurve()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRuntimeFloatCurve)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRuntimeFloatCurve));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.RuntimeFloatCurve");
		FRuntimeFloatCurve_StructSize = NativeReflection.GetStructSize(intPtr);
		FRuntimeFloatCurve_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.RuntimeFloatCurve", FRuntimeFloatCurve_IsValid);
	}
}
