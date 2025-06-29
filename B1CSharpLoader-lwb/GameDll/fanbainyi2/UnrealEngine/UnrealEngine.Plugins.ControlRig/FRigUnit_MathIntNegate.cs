using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathIntNegate", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathIntNegate
{
	private static bool FRigUnit_MathIntNegate_IsValid;

	private static int FRigUnit_MathIntNegate_StructSize;

	public FRigUnit_MathIntNegate Copy()
	{
		return this;
	}

	public static FRigUnit_MathIntNegate FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathIntNegate(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathIntNegate value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathIntNegate FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathIntNegate(nativeBuffer + arrayIndex * FRigUnit_MathIntNegate_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathIntNegate value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathIntNegate_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathIntNegate_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathIntNegate");
		}
	}

	public FRigUnit_MathIntNegate(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathIntNegate_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathIntNegate");
		}
	}

	static FRigUnit_MathIntNegate()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathIntNegate)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathIntNegate));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathIntNegate");
		FRigUnit_MathIntNegate_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathIntNegate_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathIntNegate", FRigUnit_MathIntNegate_IsValid);
	}
}
