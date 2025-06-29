using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.RuntimeVectorCurve", "Engine", UnrealModuleType.Engine)]
public struct FRuntimeVectorCurve
{
	private static bool FRuntimeVectorCurve_IsValid;

	private static int FRuntimeVectorCurve_StructSize;

	public FRuntimeVectorCurve Copy()
	{
		return this;
	}

	public static FRuntimeVectorCurve FromNative(IntPtr nativeBuffer)
	{
		return new FRuntimeVectorCurve(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRuntimeVectorCurve value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRuntimeVectorCurve FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRuntimeVectorCurve(nativeBuffer + arrayIndex * FRuntimeVectorCurve_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRuntimeVectorCurve value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRuntimeVectorCurve_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRuntimeVectorCurve_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.RuntimeVectorCurve");
		}
	}

	public FRuntimeVectorCurve(IntPtr nativeStruct)
	{
		if (!FRuntimeVectorCurve_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.RuntimeVectorCurve");
		}
	}

	static FRuntimeVectorCurve()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRuntimeVectorCurve)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRuntimeVectorCurve));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.RuntimeVectorCurve");
		FRuntimeVectorCurve_StructSize = NativeReflection.GetStructSize(intPtr);
		FRuntimeVectorCurve_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.RuntimeVectorCurve", FRuntimeVectorCurve_IsValid);
	}
}
