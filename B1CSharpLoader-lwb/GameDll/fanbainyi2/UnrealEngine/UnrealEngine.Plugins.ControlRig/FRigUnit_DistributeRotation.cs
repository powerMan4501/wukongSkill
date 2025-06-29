using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_DistributeRotation", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_DistributeRotation
{
	private static bool FRigUnit_DistributeRotation_IsValid;

	private static int FRigUnit_DistributeRotation_StructSize;

	public FRigUnit_DistributeRotation Copy()
	{
		return this;
	}

	public static FRigUnit_DistributeRotation FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_DistributeRotation(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_DistributeRotation value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_DistributeRotation FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_DistributeRotation(nativeBuffer + arrayIndex * FRigUnit_DistributeRotation_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_DistributeRotation value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_DistributeRotation_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_DistributeRotation_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DistributeRotation");
		}
	}

	public FRigUnit_DistributeRotation(IntPtr nativeStruct)
	{
		if (!FRigUnit_DistributeRotation_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DistributeRotation");
		}
	}

	static FRigUnit_DistributeRotation()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_DistributeRotation)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_DistributeRotation));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_DistributeRotation");
		FRigUnit_DistributeRotation_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_DistributeRotation_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_DistributeRotation", FRigUnit_DistributeRotation_IsValid);
	}
}
