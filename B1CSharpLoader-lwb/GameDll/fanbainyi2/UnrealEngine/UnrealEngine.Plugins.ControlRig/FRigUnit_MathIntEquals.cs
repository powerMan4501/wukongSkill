using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathIntEquals", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathIntEquals
{
	private static bool FRigUnit_MathIntEquals_IsValid;

	private static int FRigUnit_MathIntEquals_StructSize;

	public FRigUnit_MathIntEquals Copy()
	{
		return this;
	}

	public static FRigUnit_MathIntEquals FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathIntEquals(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathIntEquals value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathIntEquals FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathIntEquals(nativeBuffer + arrayIndex * FRigUnit_MathIntEquals_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathIntEquals value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathIntEquals_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathIntEquals_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathIntEquals");
		}
	}

	public FRigUnit_MathIntEquals(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathIntEquals_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathIntEquals");
		}
	}

	static FRigUnit_MathIntEquals()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathIntEquals)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathIntEquals));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathIntEquals");
		FRigUnit_MathIntEquals_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathIntEquals_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathIntEquals", FRigUnit_MathIntEquals_IsValid);
	}
}
