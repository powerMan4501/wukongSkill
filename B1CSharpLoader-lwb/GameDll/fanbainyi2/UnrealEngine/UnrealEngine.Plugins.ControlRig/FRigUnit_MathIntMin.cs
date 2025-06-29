using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathIntMin", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathIntMin
{
	private static bool FRigUnit_MathIntMin_IsValid;

	private static int FRigUnit_MathIntMin_StructSize;

	public FRigUnit_MathIntMin Copy()
	{
		return this;
	}

	public static FRigUnit_MathIntMin FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathIntMin(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathIntMin value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathIntMin FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathIntMin(nativeBuffer + arrayIndex * FRigUnit_MathIntMin_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathIntMin value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathIntMin_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathIntMin_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathIntMin");
		}
	}

	public FRigUnit_MathIntMin(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathIntMin_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathIntMin");
		}
	}

	static FRigUnit_MathIntMin()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathIntMin)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathIntMin));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathIntMin");
		FRigUnit_MathIntMin_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathIntMin_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathIntMin", FRigUnit_MathIntMin_IsValid);
	}
}
