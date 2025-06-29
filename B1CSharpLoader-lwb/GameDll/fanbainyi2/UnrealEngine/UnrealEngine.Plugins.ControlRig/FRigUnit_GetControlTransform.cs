using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_GetControlTransform", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_GetControlTransform
{
	private static bool FRigUnit_GetControlTransform_IsValid;

	private static int FRigUnit_GetControlTransform_StructSize;

	public FRigUnit_GetControlTransform Copy()
	{
		return this;
	}

	public static FRigUnit_GetControlTransform FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_GetControlTransform(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_GetControlTransform value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_GetControlTransform FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_GetControlTransform(nativeBuffer + arrayIndex * FRigUnit_GetControlTransform_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_GetControlTransform value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_GetControlTransform_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_GetControlTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_GetControlTransform");
		}
	}

	public FRigUnit_GetControlTransform(IntPtr nativeStruct)
	{
		if (!FRigUnit_GetControlTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_GetControlTransform");
		}
	}

	static FRigUnit_GetControlTransform()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_GetControlTransform)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_GetControlTransform));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_GetControlTransform");
		FRigUnit_GetControlTransform_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_GetControlTransform_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_GetControlTransform", FRigUnit_GetControlTransform_IsValid);
	}
}
