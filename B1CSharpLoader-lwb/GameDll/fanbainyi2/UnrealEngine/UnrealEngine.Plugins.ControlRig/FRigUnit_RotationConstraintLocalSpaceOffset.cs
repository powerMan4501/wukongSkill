using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_RotationConstraintLocalSpaceOffset", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_RotationConstraintLocalSpaceOffset
{
	private static bool FRigUnit_RotationConstraintLocalSpaceOffset_IsValid;

	private static int FRigUnit_RotationConstraintLocalSpaceOffset_StructSize;

	public FRigUnit_RotationConstraintLocalSpaceOffset Copy()
	{
		return this;
	}

	public static FRigUnit_RotationConstraintLocalSpaceOffset FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_RotationConstraintLocalSpaceOffset(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_RotationConstraintLocalSpaceOffset value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_RotationConstraintLocalSpaceOffset FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_RotationConstraintLocalSpaceOffset(nativeBuffer + arrayIndex * FRigUnit_RotationConstraintLocalSpaceOffset_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_RotationConstraintLocalSpaceOffset value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_RotationConstraintLocalSpaceOffset_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_RotationConstraintLocalSpaceOffset_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_RotationConstraintLocalSpaceOffset");
		}
	}

	public FRigUnit_RotationConstraintLocalSpaceOffset(IntPtr nativeStruct)
	{
		if (!FRigUnit_RotationConstraintLocalSpaceOffset_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_RotationConstraintLocalSpaceOffset");
		}
	}

	static FRigUnit_RotationConstraintLocalSpaceOffset()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_RotationConstraintLocalSpaceOffset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_RotationConstraintLocalSpaceOffset));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_RotationConstraintLocalSpaceOffset");
		FRigUnit_RotationConstraintLocalSpaceOffset_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_RotationConstraintLocalSpaceOffset_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_RotationConstraintLocalSpaceOffset", FRigUnit_RotationConstraintLocalSpaceOffset_IsValid);
	}
}
