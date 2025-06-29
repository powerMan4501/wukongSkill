using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_SetMultiControlRotator", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_SetMultiControlRotator
{
	private static bool FRigUnit_SetMultiControlRotator_IsValid;

	private static int FRigUnit_SetMultiControlRotator_StructSize;

	public FRigUnit_SetMultiControlRotator Copy()
	{
		return this;
	}

	public static FRigUnit_SetMultiControlRotator FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_SetMultiControlRotator(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_SetMultiControlRotator value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_SetMultiControlRotator FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_SetMultiControlRotator(nativeBuffer + arrayIndex * FRigUnit_SetMultiControlRotator_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_SetMultiControlRotator value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_SetMultiControlRotator_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_SetMultiControlRotator_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SetMultiControlRotator");
		}
	}

	public FRigUnit_SetMultiControlRotator(IntPtr nativeStruct)
	{
		if (!FRigUnit_SetMultiControlRotator_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SetMultiControlRotator");
		}
	}

	static FRigUnit_SetMultiControlRotator()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_SetMultiControlRotator)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_SetMultiControlRotator));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_SetMultiControlRotator");
		FRigUnit_SetMultiControlRotator_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_SetMultiControlRotator_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_SetMultiControlRotator", FRigUnit_SetMultiControlRotator_IsValid);
	}
}
