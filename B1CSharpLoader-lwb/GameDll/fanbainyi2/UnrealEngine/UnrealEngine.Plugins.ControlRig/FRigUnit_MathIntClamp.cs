using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathIntClamp", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathIntClamp
{
	private static bool FRigUnit_MathIntClamp_IsValid;

	private static int FRigUnit_MathIntClamp_StructSize;

	public FRigUnit_MathIntClamp Copy()
	{
		return this;
	}

	public static FRigUnit_MathIntClamp FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathIntClamp(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathIntClamp value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathIntClamp FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathIntClamp(nativeBuffer + arrayIndex * FRigUnit_MathIntClamp_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathIntClamp value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathIntClamp_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathIntClamp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathIntClamp");
		}
	}

	public FRigUnit_MathIntClamp(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathIntClamp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathIntClamp");
		}
	}

	static FRigUnit_MathIntClamp()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathIntClamp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathIntClamp));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathIntClamp");
		FRigUnit_MathIntClamp_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathIntClamp_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathIntClamp", FRigUnit_MathIntClamp_IsValid);
	}
}
