using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_VerletIntegrateVector", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_VerletIntegrateVector
{
	private static bool FRigUnit_VerletIntegrateVector_IsValid;

	private static int FRigUnit_VerletIntegrateVector_StructSize;

	public FRigUnit_VerletIntegrateVector Copy()
	{
		return this;
	}

	public static FRigUnit_VerletIntegrateVector FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_VerletIntegrateVector(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_VerletIntegrateVector value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_VerletIntegrateVector FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_VerletIntegrateVector(nativeBuffer + arrayIndex * FRigUnit_VerletIntegrateVector_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_VerletIntegrateVector value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_VerletIntegrateVector_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_VerletIntegrateVector_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_VerletIntegrateVector");
		}
	}

	public FRigUnit_VerletIntegrateVector(IntPtr nativeStruct)
	{
		if (!FRigUnit_VerletIntegrateVector_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_VerletIntegrateVector");
		}
	}

	static FRigUnit_VerletIntegrateVector()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_VerletIntegrateVector)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_VerletIntegrateVector));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_VerletIntegrateVector");
		FRigUnit_VerletIntegrateVector_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_VerletIntegrateVector_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_VerletIntegrateVector", FRigUnit_VerletIntegrateVector_IsValid);
	}
}
