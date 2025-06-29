using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_SetBoneInitialTransform", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_SetBoneInitialTransform
{
	private static bool FRigUnit_SetBoneInitialTransform_IsValid;

	private static int FRigUnit_SetBoneInitialTransform_StructSize;

	public FRigUnit_SetBoneInitialTransform Copy()
	{
		return this;
	}

	public static FRigUnit_SetBoneInitialTransform FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_SetBoneInitialTransform(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_SetBoneInitialTransform value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_SetBoneInitialTransform FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_SetBoneInitialTransform(nativeBuffer + arrayIndex * FRigUnit_SetBoneInitialTransform_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_SetBoneInitialTransform value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_SetBoneInitialTransform_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_SetBoneInitialTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SetBoneInitialTransform");
		}
	}

	public FRigUnit_SetBoneInitialTransform(IntPtr nativeStruct)
	{
		if (!FRigUnit_SetBoneInitialTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SetBoneInitialTransform");
		}
	}

	static FRigUnit_SetBoneInitialTransform()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_SetBoneInitialTransform)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_SetBoneInitialTransform));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_SetBoneInitialTransform");
		FRigUnit_SetBoneInitialTransform_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_SetBoneInitialTransform_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_SetBoneInitialTransform", FRigUnit_SetBoneInitialTransform_IsValid);
	}
}
