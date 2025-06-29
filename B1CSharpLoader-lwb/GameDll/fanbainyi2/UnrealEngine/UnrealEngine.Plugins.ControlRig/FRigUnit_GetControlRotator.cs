using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_GetControlRotator", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_GetControlRotator
{
	private static bool FRigUnit_GetControlRotator_IsValid;

	private static int FRigUnit_GetControlRotator_StructSize;

	public FRigUnit_GetControlRotator Copy()
	{
		return this;
	}

	public static FRigUnit_GetControlRotator FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_GetControlRotator(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_GetControlRotator value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_GetControlRotator FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_GetControlRotator(nativeBuffer + arrayIndex * FRigUnit_GetControlRotator_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_GetControlRotator value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_GetControlRotator_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_GetControlRotator_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_GetControlRotator");
		}
	}

	public FRigUnit_GetControlRotator(IntPtr nativeStruct)
	{
		if (!FRigUnit_GetControlRotator_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_GetControlRotator");
		}
	}

	static FRigUnit_GetControlRotator()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_GetControlRotator)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_GetControlRotator));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_GetControlRotator");
		FRigUnit_GetControlRotator_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_GetControlRotator_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_GetControlRotator", FRigUnit_GetControlRotator_IsValid);
	}
}
