using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathIntLess", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathIntLess
{
	private static bool FRigUnit_MathIntLess_IsValid;

	private static int FRigUnit_MathIntLess_StructSize;

	public FRigUnit_MathIntLess Copy()
	{
		return this;
	}

	public static FRigUnit_MathIntLess FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathIntLess(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathIntLess value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathIntLess FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathIntLess(nativeBuffer + arrayIndex * FRigUnit_MathIntLess_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathIntLess value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathIntLess_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathIntLess_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathIntLess");
		}
	}

	public FRigUnit_MathIntLess(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathIntLess_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathIntLess");
		}
	}

	static FRigUnit_MathIntLess()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathIntLess)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathIntLess));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathIntLess");
		FRigUnit_MathIntLess_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathIntLess_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathIntLess", FRigUnit_MathIntLess_IsValid);
	}
}
