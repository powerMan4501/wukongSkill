using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_PositionConstraint", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_PositionConstraint
{
	private static bool FRigUnit_PositionConstraint_IsValid;

	private static int FRigUnit_PositionConstraint_StructSize;

	public FRigUnit_PositionConstraint Copy()
	{
		return this;
	}

	public static FRigUnit_PositionConstraint FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_PositionConstraint(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_PositionConstraint value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_PositionConstraint FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_PositionConstraint(nativeBuffer + arrayIndex * FRigUnit_PositionConstraint_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_PositionConstraint value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_PositionConstraint_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_PositionConstraint_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_PositionConstraint");
		}
	}

	public FRigUnit_PositionConstraint(IntPtr nativeStruct)
	{
		if (!FRigUnit_PositionConstraint_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_PositionConstraint");
		}
	}

	static FRigUnit_PositionConstraint()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_PositionConstraint)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_PositionConstraint));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_PositionConstraint");
		FRigUnit_PositionConstraint_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_PositionConstraint_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_PositionConstraint", FRigUnit_PositionConstraint_IsValid);
	}
}
