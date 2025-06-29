using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.VectorSpringState", "Engine", UnrealModuleType.Engine)]
public struct FVectorSpringState
{
	private static bool FVectorSpringState_IsValid;

	private static int FVectorSpringState_StructSize;

	public FVectorSpringState Copy()
	{
		return this;
	}

	public static FVectorSpringState FromNative(IntPtr nativeBuffer)
	{
		return new FVectorSpringState(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FVectorSpringState value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FVectorSpringState FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FVectorSpringState(nativeBuffer + arrayIndex * FVectorSpringState_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FVectorSpringState value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FVectorSpringState_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FVectorSpringState_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.VectorSpringState");
		}
	}

	public FVectorSpringState(IntPtr nativeStruct)
	{
		if (!FVectorSpringState_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.VectorSpringState");
		}
	}

	static FVectorSpringState()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FVectorSpringState)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FVectorSpringState));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.VectorSpringState");
		FVectorSpringState_StructSize = NativeReflection.GetStructSize(intPtr);
		FVectorSpringState_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.VectorSpringState", FVectorSpringState_IsValid);
	}
}
