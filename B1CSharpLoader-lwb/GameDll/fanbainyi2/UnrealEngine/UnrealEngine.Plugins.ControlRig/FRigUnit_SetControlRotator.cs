using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_SetControlRotator", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_SetControlRotator
{
	private static bool FRigUnit_SetControlRotator_IsValid;

	private static int FRigUnit_SetControlRotator_StructSize;

	public FRigUnit_SetControlRotator Copy()
	{
		return this;
	}

	public static FRigUnit_SetControlRotator FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_SetControlRotator(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_SetControlRotator value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_SetControlRotator FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_SetControlRotator(nativeBuffer + arrayIndex * FRigUnit_SetControlRotator_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_SetControlRotator value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_SetControlRotator_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_SetControlRotator_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SetControlRotator");
		}
	}

	public FRigUnit_SetControlRotator(IntPtr nativeStruct)
	{
		if (!FRigUnit_SetControlRotator_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SetControlRotator");
		}
	}

	static FRigUnit_SetControlRotator()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_SetControlRotator)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_SetControlRotator));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_SetControlRotator");
		FRigUnit_SetControlRotator_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_SetControlRotator_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_SetControlRotator", FRigUnit_SetControlRotator_IsValid);
	}
}
