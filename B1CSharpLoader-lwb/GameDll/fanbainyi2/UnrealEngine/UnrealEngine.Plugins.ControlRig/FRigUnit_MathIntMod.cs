using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathIntMod", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathIntMod
{
	private static bool FRigUnit_MathIntMod_IsValid;

	private static int FRigUnit_MathIntMod_StructSize;

	public FRigUnit_MathIntMod Copy()
	{
		return this;
	}

	public static FRigUnit_MathIntMod FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathIntMod(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathIntMod value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathIntMod FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathIntMod(nativeBuffer + arrayIndex * FRigUnit_MathIntMod_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathIntMod value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathIntMod_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathIntMod_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathIntMod");
		}
	}

	public FRigUnit_MathIntMod(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathIntMod_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathIntMod");
		}
	}

	static FRigUnit_MathIntMod()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathIntMod)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathIntMod));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathIntMod");
		FRigUnit_MathIntMod_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathIntMod_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathIntMod", FRigUnit_MathIntMod_IsValid);
	}
}
