using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_RotationConstraint", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_RotationConstraint
{
	private static bool FRigUnit_RotationConstraint_IsValid;

	private static int FRigUnit_RotationConstraint_StructSize;

	public FRigUnit_RotationConstraint Copy()
	{
		return this;
	}

	public static FRigUnit_RotationConstraint FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_RotationConstraint(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_RotationConstraint value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_RotationConstraint FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_RotationConstraint(nativeBuffer + arrayIndex * FRigUnit_RotationConstraint_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_RotationConstraint value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_RotationConstraint_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_RotationConstraint_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_RotationConstraint");
		}
	}

	public FRigUnit_RotationConstraint(IntPtr nativeStruct)
	{
		if (!FRigUnit_RotationConstraint_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_RotationConstraint");
		}
	}

	static FRigUnit_RotationConstraint()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_RotationConstraint)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_RotationConstraint));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_RotationConstraint");
		FRigUnit_RotationConstraint_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_RotationConstraint_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_RotationConstraint", FRigUnit_RotationConstraint_IsValid);
	}
}
