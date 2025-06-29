using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_AccumulateFloatAdd", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_AccumulateFloatAdd
{
	private static bool FRigUnit_AccumulateFloatAdd_IsValid;

	private static int FRigUnit_AccumulateFloatAdd_StructSize;

	public FRigUnit_AccumulateFloatAdd Copy()
	{
		return this;
	}

	public static FRigUnit_AccumulateFloatAdd FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_AccumulateFloatAdd(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_AccumulateFloatAdd value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_AccumulateFloatAdd FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_AccumulateFloatAdd(nativeBuffer + arrayIndex * FRigUnit_AccumulateFloatAdd_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_AccumulateFloatAdd value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_AccumulateFloatAdd_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_AccumulateFloatAdd_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_AccumulateFloatAdd");
		}
	}

	public FRigUnit_AccumulateFloatAdd(IntPtr nativeStruct)
	{
		if (!FRigUnit_AccumulateFloatAdd_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_AccumulateFloatAdd");
		}
	}

	static FRigUnit_AccumulateFloatAdd()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_AccumulateFloatAdd)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_AccumulateFloatAdd));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_AccumulateFloatAdd");
		FRigUnit_AccumulateFloatAdd_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_AccumulateFloatAdd_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_AccumulateFloatAdd", FRigUnit_AccumulateFloatAdd_IsValid);
	}
}
