using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_SetControlTransform", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_SetControlTransform
{
	private static bool FRigUnit_SetControlTransform_IsValid;

	private static int FRigUnit_SetControlTransform_StructSize;

	public FRigUnit_SetControlTransform Copy()
	{
		return this;
	}

	public static FRigUnit_SetControlTransform FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_SetControlTransform(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_SetControlTransform value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_SetControlTransform FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_SetControlTransform(nativeBuffer + arrayIndex * FRigUnit_SetControlTransform_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_SetControlTransform value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_SetControlTransform_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_SetControlTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SetControlTransform");
		}
	}

	public FRigUnit_SetControlTransform(IntPtr nativeStruct)
	{
		if (!FRigUnit_SetControlTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SetControlTransform");
		}
	}

	static FRigUnit_SetControlTransform()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_SetControlTransform)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_SetControlTransform));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_SetControlTransform");
		FRigUnit_SetControlTransform_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_SetControlTransform_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_SetControlTransform", FRigUnit_SetControlTransform_IsValid);
	}
}
