using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.TransformCurve", "Engine", UnrealModuleType.Engine)]
public struct FTransformCurve
{
	private static bool FTransformCurve_IsValid;

	private static int FTransformCurve_StructSize;

	public FTransformCurve Copy()
	{
		return this;
	}

	public static FTransformCurve FromNative(IntPtr nativeBuffer)
	{
		return new FTransformCurve(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTransformCurve value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTransformCurve FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTransformCurve(nativeBuffer + arrayIndex * FTransformCurve_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTransformCurve value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FTransformCurve_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FTransformCurve_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.TransformCurve");
		}
	}

	public FTransformCurve(IntPtr nativeStruct)
	{
		if (!FTransformCurve_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.TransformCurve");
		}
	}

	static FTransformCurve()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FTransformCurve)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTransformCurve));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.TransformCurve");
		FTransformCurve_StructSize = NativeReflection.GetStructSize(intPtr);
		FTransformCurve_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.TransformCurve", FTransformCurve_IsValid);
	}
}
