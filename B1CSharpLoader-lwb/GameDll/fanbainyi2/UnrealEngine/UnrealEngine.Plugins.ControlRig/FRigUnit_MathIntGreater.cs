using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathIntGreater", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathIntGreater
{
	private static bool FRigUnit_MathIntGreater_IsValid;

	private static int FRigUnit_MathIntGreater_StructSize;

	public FRigUnit_MathIntGreater Copy()
	{
		return this;
	}

	public static FRigUnit_MathIntGreater FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathIntGreater(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathIntGreater value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathIntGreater FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathIntGreater(nativeBuffer + arrayIndex * FRigUnit_MathIntGreater_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathIntGreater value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathIntGreater_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathIntGreater_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathIntGreater");
		}
	}

	public FRigUnit_MathIntGreater(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathIntGreater_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathIntGreater");
		}
	}

	static FRigUnit_MathIntGreater()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathIntGreater)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathIntGreater));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathIntGreater");
		FRigUnit_MathIntGreater_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathIntGreater_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathIntGreater", FRigUnit_MathIntGreater_IsValid);
	}
}
