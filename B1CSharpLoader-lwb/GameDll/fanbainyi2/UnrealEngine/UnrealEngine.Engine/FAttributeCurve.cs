using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 6657)]
[BlueprintType]
[UMetaPath("/Script/Engine.AttributeCurve", "Engine", UnrealModuleType.Engine)]
public struct FAttributeCurve
{
	private static bool FAttributeCurve_IsValid;

	private static int FAttributeCurve_StructSize;

	public FAttributeCurve Copy()
	{
		return this;
	}

	public static FAttributeCurve FromNative(IntPtr nativeBuffer)
	{
		return new FAttributeCurve(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAttributeCurve value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAttributeCurve FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAttributeCurve(nativeBuffer + arrayIndex * FAttributeCurve_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAttributeCurve value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAttributeCurve_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAttributeCurve_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AttributeCurve");
		}
	}

	public FAttributeCurve(IntPtr nativeStruct)
	{
		if (!FAttributeCurve_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AttributeCurve");
		}
	}

	static FAttributeCurve()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAttributeCurve)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAttributeCurve));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.AttributeCurve");
		FAttributeCurve_StructSize = NativeReflection.GetStructSize(intPtr);
		FAttributeCurve_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.AttributeCurve", FAttributeCurve_IsValid);
	}
}
