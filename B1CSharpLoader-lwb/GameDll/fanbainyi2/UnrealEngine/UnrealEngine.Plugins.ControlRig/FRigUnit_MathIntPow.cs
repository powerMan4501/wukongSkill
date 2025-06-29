using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathIntPow", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathIntPow
{
	private static bool FRigUnit_MathIntPow_IsValid;

	private static int FRigUnit_MathIntPow_StructSize;

	public FRigUnit_MathIntPow Copy()
	{
		return this;
	}

	public static FRigUnit_MathIntPow FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathIntPow(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathIntPow value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathIntPow FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathIntPow(nativeBuffer + arrayIndex * FRigUnit_MathIntPow_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathIntPow value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathIntPow_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathIntPow_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathIntPow");
		}
	}

	public FRigUnit_MathIntPow(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathIntPow_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathIntPow");
		}
	}

	static FRigUnit_MathIntPow()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathIntPow)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathIntPow));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathIntPow");
		FRigUnit_MathIntPow_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathIntPow_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathIntPow", FRigUnit_MathIntPow_IsValid);
	}
}
