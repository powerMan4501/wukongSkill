using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_AccumulateVectorAdd", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_AccumulateVectorAdd
{
	private static bool FRigUnit_AccumulateVectorAdd_IsValid;

	private static int FRigUnit_AccumulateVectorAdd_StructSize;

	public FRigUnit_AccumulateVectorAdd Copy()
	{
		return this;
	}

	public static FRigUnit_AccumulateVectorAdd FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_AccumulateVectorAdd(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_AccumulateVectorAdd value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_AccumulateVectorAdd FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_AccumulateVectorAdd(nativeBuffer + arrayIndex * FRigUnit_AccumulateVectorAdd_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_AccumulateVectorAdd value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_AccumulateVectorAdd_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_AccumulateVectorAdd_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_AccumulateVectorAdd");
		}
	}

	public FRigUnit_AccumulateVectorAdd(IntPtr nativeStruct)
	{
		if (!FRigUnit_AccumulateVectorAdd_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_AccumulateVectorAdd");
		}
	}

	static FRigUnit_AccumulateVectorAdd()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_AccumulateVectorAdd)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_AccumulateVectorAdd));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_AccumulateVectorAdd");
		FRigUnit_AccumulateVectorAdd_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_AccumulateVectorAdd_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_AccumulateVectorAdd", FRigUnit_AccumulateVectorAdd_IsValid);
	}
}
