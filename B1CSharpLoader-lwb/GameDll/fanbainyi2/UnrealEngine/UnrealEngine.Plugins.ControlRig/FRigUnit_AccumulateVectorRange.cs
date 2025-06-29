using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_AccumulateVectorRange", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_AccumulateVectorRange
{
	private static bool FRigUnit_AccumulateVectorRange_IsValid;

	private static int FRigUnit_AccumulateVectorRange_StructSize;

	public FRigUnit_AccumulateVectorRange Copy()
	{
		return this;
	}

	public static FRigUnit_AccumulateVectorRange FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_AccumulateVectorRange(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_AccumulateVectorRange value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_AccumulateVectorRange FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_AccumulateVectorRange(nativeBuffer + arrayIndex * FRigUnit_AccumulateVectorRange_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_AccumulateVectorRange value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_AccumulateVectorRange_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_AccumulateVectorRange_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_AccumulateVectorRange");
		}
	}

	public FRigUnit_AccumulateVectorRange(IntPtr nativeStruct)
	{
		if (!FRigUnit_AccumulateVectorRange_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_AccumulateVectorRange");
		}
	}

	static FRigUnit_AccumulateVectorRange()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_AccumulateVectorRange)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_AccumulateVectorRange));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_AccumulateVectorRange");
		FRigUnit_AccumulateVectorRange_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_AccumulateVectorRange_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_AccumulateVectorRange", FRigUnit_AccumulateVectorRange_IsValid);
	}
}
