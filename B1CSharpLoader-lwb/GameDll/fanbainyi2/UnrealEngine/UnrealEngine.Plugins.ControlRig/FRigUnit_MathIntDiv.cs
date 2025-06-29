using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathIntDiv", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathIntDiv
{
	private static bool FRigUnit_MathIntDiv_IsValid;

	private static int FRigUnit_MathIntDiv_StructSize;

	public FRigUnit_MathIntDiv Copy()
	{
		return this;
	}

	public static FRigUnit_MathIntDiv FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathIntDiv(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathIntDiv value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathIntDiv FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathIntDiv(nativeBuffer + arrayIndex * FRigUnit_MathIntDiv_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathIntDiv value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathIntDiv_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathIntDiv_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathIntDiv");
		}
	}

	public FRigUnit_MathIntDiv(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathIntDiv_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathIntDiv");
		}
	}

	static FRigUnit_MathIntDiv()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathIntDiv)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathIntDiv));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathIntDiv");
		FRigUnit_MathIntDiv_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathIntDiv_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathIntDiv", FRigUnit_MathIntDiv_IsValid);
	}
}
