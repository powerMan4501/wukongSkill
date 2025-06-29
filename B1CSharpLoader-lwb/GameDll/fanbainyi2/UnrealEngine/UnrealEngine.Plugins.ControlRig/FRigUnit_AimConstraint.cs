using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_AimConstraint", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_AimConstraint
{
	private static bool FRigUnit_AimConstraint_IsValid;

	private static int FRigUnit_AimConstraint_StructSize;

	public FRigUnit_AimConstraint Copy()
	{
		return this;
	}

	public static FRigUnit_AimConstraint FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_AimConstraint(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_AimConstraint value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_AimConstraint FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_AimConstraint(nativeBuffer + arrayIndex * FRigUnit_AimConstraint_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_AimConstraint value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_AimConstraint_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_AimConstraint_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_AimConstraint");
		}
	}

	public FRigUnit_AimConstraint(IntPtr nativeStruct)
	{
		if (!FRigUnit_AimConstraint_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_AimConstraint");
		}
	}

	static FRigUnit_AimConstraint()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_AimConstraint)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_AimConstraint));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_AimConstraint");
		FRigUnit_AimConstraint_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_AimConstraint_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_AimConstraint", FRigUnit_AimConstraint_IsValid);
	}
}
