using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 57352)]
[BlueprintType]
[UMetaPath("/Script/Engine.VectorRK4SpringInterpolator", "Engine", UnrealModuleType.Engine)]
public struct FVectorRK4SpringInterpolator
{
	private static bool FVectorRK4SpringInterpolator_IsValid;

	private static int FVectorRK4SpringInterpolator_StructSize;

	public FVectorRK4SpringInterpolator Copy()
	{
		return this;
	}

	public static FVectorRK4SpringInterpolator FromNative(IntPtr nativeBuffer)
	{
		return new FVectorRK4SpringInterpolator(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FVectorRK4SpringInterpolator value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FVectorRK4SpringInterpolator FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FVectorRK4SpringInterpolator(nativeBuffer + arrayIndex * FVectorRK4SpringInterpolator_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FVectorRK4SpringInterpolator value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FVectorRK4SpringInterpolator_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FVectorRK4SpringInterpolator_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.VectorRK4SpringInterpolator");
		}
	}

	public FVectorRK4SpringInterpolator(IntPtr nativeStruct)
	{
		if (!FVectorRK4SpringInterpolator_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.VectorRK4SpringInterpolator");
		}
	}

	static FVectorRK4SpringInterpolator()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FVectorRK4SpringInterpolator)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FVectorRK4SpringInterpolator));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.VectorRK4SpringInterpolator");
		FVectorRK4SpringInterpolator_StructSize = NativeReflection.GetStructSize(intPtr);
		FVectorRK4SpringInterpolator_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.VectorRK4SpringInterpolator", FVectorRK4SpringInterpolator_IsValid);
	}
}
