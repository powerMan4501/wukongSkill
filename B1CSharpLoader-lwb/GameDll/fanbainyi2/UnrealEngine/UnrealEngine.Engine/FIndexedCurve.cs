using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[UMetaPath("/Script/Engine.IndexedCurve", "Engine", UnrealModuleType.Engine)]
public struct FIndexedCurve
{
	private static bool FIndexedCurve_IsValid;

	private static int FIndexedCurve_StructSize;

	public FIndexedCurve Copy()
	{
		return this;
	}

	public static FIndexedCurve FromNative(IntPtr nativeBuffer)
	{
		return new FIndexedCurve(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FIndexedCurve value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FIndexedCurve FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FIndexedCurve(nativeBuffer + arrayIndex * FIndexedCurve_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FIndexedCurve value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FIndexedCurve_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FIndexedCurve_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.IndexedCurve");
		}
	}

	public FIndexedCurve(IntPtr nativeStruct)
	{
		if (!FIndexedCurve_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.IndexedCurve");
		}
	}

	static FIndexedCurve()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FIndexedCurve)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FIndexedCurve));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.IndexedCurve");
		FIndexedCurve_StructSize = NativeReflection.GetStructSize(intPtr);
		FIndexedCurve_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.IndexedCurve", FIndexedCurve_IsValid);
	}
}
