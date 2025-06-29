using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_PositionConstraintLocalSpaceOffset", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_PositionConstraintLocalSpaceOffset
{
	private static bool FRigUnit_PositionConstraintLocalSpaceOffset_IsValid;

	private static int FRigUnit_PositionConstraintLocalSpaceOffset_StructSize;

	public FRigUnit_PositionConstraintLocalSpaceOffset Copy()
	{
		return this;
	}

	public static FRigUnit_PositionConstraintLocalSpaceOffset FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_PositionConstraintLocalSpaceOffset(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_PositionConstraintLocalSpaceOffset value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_PositionConstraintLocalSpaceOffset FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_PositionConstraintLocalSpaceOffset(nativeBuffer + arrayIndex * FRigUnit_PositionConstraintLocalSpaceOffset_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_PositionConstraintLocalSpaceOffset value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_PositionConstraintLocalSpaceOffset_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_PositionConstraintLocalSpaceOffset_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_PositionConstraintLocalSpaceOffset");
		}
	}

	public FRigUnit_PositionConstraintLocalSpaceOffset(IntPtr nativeStruct)
	{
		if (!FRigUnit_PositionConstraintLocalSpaceOffset_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_PositionConstraintLocalSpaceOffset");
		}
	}

	static FRigUnit_PositionConstraintLocalSpaceOffset()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_PositionConstraintLocalSpaceOffset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_PositionConstraintLocalSpaceOffset));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_PositionConstraintLocalSpaceOffset");
		FRigUnit_PositionConstraintLocalSpaceOffset_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_PositionConstraintLocalSpaceOffset_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_PositionConstraintLocalSpaceOffset", FRigUnit_PositionConstraintLocalSpaceOffset_IsValid);
	}
}
