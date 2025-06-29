using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.VectorCurve", "Engine", UnrealModuleType.Engine)]
public struct FVectorCurve
{
	private static bool FVectorCurve_IsValid;

	private static int FVectorCurve_StructSize;

	public FVectorCurve Copy()
	{
		return this;
	}

	public static FVectorCurve FromNative(IntPtr nativeBuffer)
	{
		return new FVectorCurve(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FVectorCurve value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FVectorCurve FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FVectorCurve(nativeBuffer + arrayIndex * FVectorCurve_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FVectorCurve value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FVectorCurve_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FVectorCurve_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.VectorCurve");
		}
	}

	public FVectorCurve(IntPtr nativeStruct)
	{
		if (!FVectorCurve_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.VectorCurve");
		}
	}

	static FVectorCurve()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FVectorCurve)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FVectorCurve));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.VectorCurve");
		FVectorCurve_StructSize = NativeReflection.GetStructSize(intPtr);
		FVectorCurve_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.VectorCurve", FVectorCurve_IsValid);
	}
}
