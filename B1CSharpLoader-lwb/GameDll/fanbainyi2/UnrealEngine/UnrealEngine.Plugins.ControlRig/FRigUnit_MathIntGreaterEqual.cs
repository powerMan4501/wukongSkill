using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathIntGreaterEqual", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathIntGreaterEqual
{
	private static bool FRigUnit_MathIntGreaterEqual_IsValid;

	private static int FRigUnit_MathIntGreaterEqual_StructSize;

	public FRigUnit_MathIntGreaterEqual Copy()
	{
		return this;
	}

	public static FRigUnit_MathIntGreaterEqual FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathIntGreaterEqual(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathIntGreaterEqual value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathIntGreaterEqual FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathIntGreaterEqual(nativeBuffer + arrayIndex * FRigUnit_MathIntGreaterEqual_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathIntGreaterEqual value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathIntGreaterEqual_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathIntGreaterEqual_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathIntGreaterEqual");
		}
	}

	public FRigUnit_MathIntGreaterEqual(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathIntGreaterEqual_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathIntGreaterEqual");
		}
	}

	static FRigUnit_MathIntGreaterEqual()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathIntGreaterEqual)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathIntGreaterEqual));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathIntGreaterEqual");
		FRigUnit_MathIntGreaterEqual_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathIntGreaterEqual_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathIntGreaterEqual", FRigUnit_MathIntGreaterEqual_IsValid);
	}
}
