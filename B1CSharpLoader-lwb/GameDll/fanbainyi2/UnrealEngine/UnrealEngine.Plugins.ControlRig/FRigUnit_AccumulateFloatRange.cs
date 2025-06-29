using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_AccumulateFloatRange", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_AccumulateFloatRange
{
	private static bool FRigUnit_AccumulateFloatRange_IsValid;

	private static int FRigUnit_AccumulateFloatRange_StructSize;

	public FRigUnit_AccumulateFloatRange Copy()
	{
		return this;
	}

	public static FRigUnit_AccumulateFloatRange FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_AccumulateFloatRange(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_AccumulateFloatRange value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_AccumulateFloatRange FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_AccumulateFloatRange(nativeBuffer + arrayIndex * FRigUnit_AccumulateFloatRange_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_AccumulateFloatRange value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_AccumulateFloatRange_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_AccumulateFloatRange_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_AccumulateFloatRange");
		}
	}

	public FRigUnit_AccumulateFloatRange(IntPtr nativeStruct)
	{
		if (!FRigUnit_AccumulateFloatRange_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_AccumulateFloatRange");
		}
	}

	static FRigUnit_AccumulateFloatRange()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_AccumulateFloatRange)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_AccumulateFloatRange));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_AccumulateFloatRange");
		FRigUnit_AccumulateFloatRange_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_AccumulateFloatRange_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_AccumulateFloatRange", FRigUnit_AccumulateFloatRange_IsValid);
	}
}
