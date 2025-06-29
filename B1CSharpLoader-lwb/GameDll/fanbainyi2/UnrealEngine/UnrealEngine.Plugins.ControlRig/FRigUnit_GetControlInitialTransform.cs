using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_GetControlInitialTransform", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_GetControlInitialTransform
{
	private static bool FRigUnit_GetControlInitialTransform_IsValid;

	private static int FRigUnit_GetControlInitialTransform_StructSize;

	public FRigUnit_GetControlInitialTransform Copy()
	{
		return this;
	}

	public static FRigUnit_GetControlInitialTransform FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_GetControlInitialTransform(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_GetControlInitialTransform value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_GetControlInitialTransform FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_GetControlInitialTransform(nativeBuffer + arrayIndex * FRigUnit_GetControlInitialTransform_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_GetControlInitialTransform value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_GetControlInitialTransform_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_GetControlInitialTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_GetControlInitialTransform");
		}
	}

	public FRigUnit_GetControlInitialTransform(IntPtr nativeStruct)
	{
		if (!FRigUnit_GetControlInitialTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_GetControlInitialTransform");
		}
	}

	static FRigUnit_GetControlInitialTransform()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_GetControlInitialTransform)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_GetControlInitialTransform));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_GetControlInitialTransform");
		FRigUnit_GetControlInitialTransform_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_GetControlInitialTransform_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_GetControlInitialTransform", FRigUnit_GetControlInitialTransform_IsValid);
	}
}
