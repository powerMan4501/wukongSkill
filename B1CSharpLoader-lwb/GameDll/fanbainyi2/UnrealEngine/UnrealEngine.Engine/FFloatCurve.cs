using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.FloatCurve", "Engine", UnrealModuleType.Engine)]
public struct FFloatCurve
{
	private static bool FFloatCurve_IsValid;

	private static int FFloatCurve_StructSize;

	public FFloatCurve Copy()
	{
		return this;
	}

	public static FFloatCurve FromNative(IntPtr nativeBuffer)
	{
		return new FFloatCurve(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FFloatCurve value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FFloatCurve FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FFloatCurve(nativeBuffer + arrayIndex * FFloatCurve_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FFloatCurve value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FFloatCurve_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FFloatCurve_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.FloatCurve");
		}
	}

	public FFloatCurve(IntPtr nativeStruct)
	{
		if (!FFloatCurve_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.FloatCurve");
		}
	}

	static FFloatCurve()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FFloatCurve)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FFloatCurve));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.FloatCurve");
		FFloatCurve_StructSize = NativeReflection.GetStructSize(intPtr);
		FFloatCurve_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.FloatCurve", FFloatCurve_IsValid);
	}
}
