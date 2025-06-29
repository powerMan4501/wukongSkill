using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathIntLessEqual", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathIntLessEqual
{
	private static bool FRigUnit_MathIntLessEqual_IsValid;

	private static int FRigUnit_MathIntLessEqual_StructSize;

	public FRigUnit_MathIntLessEqual Copy()
	{
		return this;
	}

	public static FRigUnit_MathIntLessEqual FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathIntLessEqual(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathIntLessEqual value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathIntLessEqual FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathIntLessEqual(nativeBuffer + arrayIndex * FRigUnit_MathIntLessEqual_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathIntLessEqual value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathIntLessEqual_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathIntLessEqual_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathIntLessEqual");
		}
	}

	public FRigUnit_MathIntLessEqual(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathIntLessEqual_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathIntLessEqual");
		}
	}

	static FRigUnit_MathIntLessEqual()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathIntLessEqual)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathIntLessEqual));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathIntLessEqual");
		FRigUnit_MathIntLessEqual_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathIntLessEqual_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathIntLessEqual", FRigUnit_MathIntLessEqual_IsValid);
	}
}
