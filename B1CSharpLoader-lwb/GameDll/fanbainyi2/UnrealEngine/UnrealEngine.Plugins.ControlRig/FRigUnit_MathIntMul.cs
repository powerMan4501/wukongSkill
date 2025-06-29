using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathIntMul", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathIntMul
{
	private static bool FRigUnit_MathIntMul_IsValid;

	private static int FRigUnit_MathIntMul_StructSize;

	public FRigUnit_MathIntMul Copy()
	{
		return this;
	}

	public static FRigUnit_MathIntMul FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathIntMul(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathIntMul value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathIntMul FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathIntMul(nativeBuffer + arrayIndex * FRigUnit_MathIntMul_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathIntMul value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathIntMul_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathIntMul_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathIntMul");
		}
	}

	public FRigUnit_MathIntMul(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathIntMul_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathIntMul");
		}
	}

	static FRigUnit_MathIntMul()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathIntMul)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathIntMul));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathIntMul");
		FRigUnit_MathIntMul_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathIntMul_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathIntMul", FRigUnit_MathIntMul_IsValid);
	}
}
