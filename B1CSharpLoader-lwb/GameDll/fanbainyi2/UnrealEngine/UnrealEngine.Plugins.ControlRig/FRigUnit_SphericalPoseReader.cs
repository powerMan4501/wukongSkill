using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_SphericalPoseReader", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_SphericalPoseReader
{
	private static bool FRigUnit_SphericalPoseReader_IsValid;

	private static int FRigUnit_SphericalPoseReader_StructSize;

	public FRigUnit_SphericalPoseReader Copy()
	{
		return this;
	}

	public static FRigUnit_SphericalPoseReader FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_SphericalPoseReader(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_SphericalPoseReader value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_SphericalPoseReader FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_SphericalPoseReader(nativeBuffer + arrayIndex * FRigUnit_SphericalPoseReader_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_SphericalPoseReader value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_SphericalPoseReader_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_SphericalPoseReader_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SphericalPoseReader");
		}
	}

	public FRigUnit_SphericalPoseReader(IntPtr nativeStruct)
	{
		if (!FRigUnit_SphericalPoseReader_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SphericalPoseReader");
		}
	}

	static FRigUnit_SphericalPoseReader()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_SphericalPoseReader)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_SphericalPoseReader));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_SphericalPoseReader");
		FRigUnit_SphericalPoseReader_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_SphericalPoseReader_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_SphericalPoseReader", FRigUnit_SphericalPoseReader_IsValid);
	}
}
