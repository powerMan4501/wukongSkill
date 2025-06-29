using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.MM;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/MM.MotionMatchingCostData", "MM", UnrealModuleType.GamePlugin)]
public struct FMotionMatchingCostData
{
	private static bool FMotionMatchingCostData_IsValid;

	private static int FMotionMatchingCostData_StructSize;

	public FMotionMatchingCostData Copy()
	{
		return this;
	}

	public static FMotionMatchingCostData FromNative(IntPtr nativeBuffer)
	{
		return new FMotionMatchingCostData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMotionMatchingCostData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMotionMatchingCostData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMotionMatchingCostData(nativeBuffer + arrayIndex * FMotionMatchingCostData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMotionMatchingCostData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FMotionMatchingCostData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FMotionMatchingCostData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MM.MotionMatchingCostData");
		}
	}

	public FMotionMatchingCostData(IntPtr nativeStruct)
	{
		if (!FMotionMatchingCostData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MM.MotionMatchingCostData");
		}
	}

	static FMotionMatchingCostData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMotionMatchingCostData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMotionMatchingCostData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/MM.MotionMatchingCostData");
		FMotionMatchingCostData_StructSize = NativeReflection.GetStructSize(intPtr);
		FMotionMatchingCostData_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/MM.MotionMatchingCostData", FMotionMatchingCostData_IsValid);
	}
}
