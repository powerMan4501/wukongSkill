using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AnimationWarpingRuntime;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AnimationWarpingRuntime.StrideWarpingFootDefinition", "AnimationWarpingRuntime", UnrealModuleType.EnginePlugin)]
public struct FStrideWarpingFootDefinition
{
	private static bool FStrideWarpingFootDefinition_IsValid;

	private static int FStrideWarpingFootDefinition_StructSize;

	public FStrideWarpingFootDefinition Copy()
	{
		return this;
	}

	public static FStrideWarpingFootDefinition FromNative(IntPtr nativeBuffer)
	{
		return new FStrideWarpingFootDefinition(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FStrideWarpingFootDefinition value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FStrideWarpingFootDefinition FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FStrideWarpingFootDefinition(nativeBuffer + arrayIndex * FStrideWarpingFootDefinition_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FStrideWarpingFootDefinition value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FStrideWarpingFootDefinition_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FStrideWarpingFootDefinition_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimationWarpingRuntime.StrideWarpingFootDefinition");
		}
	}

	public FStrideWarpingFootDefinition(IntPtr nativeStruct)
	{
		if (!FStrideWarpingFootDefinition_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimationWarpingRuntime.StrideWarpingFootDefinition");
		}
	}

	static FStrideWarpingFootDefinition()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FStrideWarpingFootDefinition)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FStrideWarpingFootDefinition));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AnimationWarpingRuntime.StrideWarpingFootDefinition");
		FStrideWarpingFootDefinition_StructSize = NativeReflection.GetStructSize(intPtr);
		FStrideWarpingFootDefinition_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/AnimationWarpingRuntime.StrideWarpingFootDefinition", FStrideWarpingFootDefinition_IsValid);
	}
}
