using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_PointSimulation", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_PointSimulation
{
	private static bool FRigUnit_PointSimulation_IsValid;

	private static int FRigUnit_PointSimulation_StructSize;

	public FRigUnit_PointSimulation Copy()
	{
		return this;
	}

	public static FRigUnit_PointSimulation FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_PointSimulation(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_PointSimulation value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_PointSimulation FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_PointSimulation(nativeBuffer + arrayIndex * FRigUnit_PointSimulation_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_PointSimulation value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_PointSimulation_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_PointSimulation_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_PointSimulation");
		}
	}

	public FRigUnit_PointSimulation(IntPtr nativeStruct)
	{
		if (!FRigUnit_PointSimulation_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_PointSimulation");
		}
	}

	static FRigUnit_PointSimulation()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_PointSimulation)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_PointSimulation));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_PointSimulation");
		FRigUnit_PointSimulation_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_PointSimulation_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_PointSimulation", FRigUnit_PointSimulation_IsValid);
	}
}
