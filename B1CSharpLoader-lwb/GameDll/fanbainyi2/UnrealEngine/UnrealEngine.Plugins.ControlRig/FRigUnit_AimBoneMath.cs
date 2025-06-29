using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_AimBoneMath", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_AimBoneMath
{
	private static bool FRigUnit_AimBoneMath_IsValid;

	private static int FRigUnit_AimBoneMath_StructSize;

	public FRigUnit_AimBoneMath Copy()
	{
		return this;
	}

	public static FRigUnit_AimBoneMath FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_AimBoneMath(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_AimBoneMath value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_AimBoneMath FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_AimBoneMath(nativeBuffer + arrayIndex * FRigUnit_AimBoneMath_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_AimBoneMath value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_AimBoneMath_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_AimBoneMath_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_AimBoneMath");
		}
	}

	public FRigUnit_AimBoneMath(IntPtr nativeStruct)
	{
		if (!FRigUnit_AimBoneMath_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_AimBoneMath");
		}
	}

	static FRigUnit_AimBoneMath()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_AimBoneMath)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_AimBoneMath));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_AimBoneMath");
		FRigUnit_AimBoneMath_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_AimBoneMath_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_AimBoneMath", FRigUnit_AimBoneMath_IsValid);
	}
}
