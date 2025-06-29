using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_SetBoneTransform", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_SetBoneTransform
{
	private static bool FRigUnit_SetBoneTransform_IsValid;

	private static int FRigUnit_SetBoneTransform_StructSize;

	public FRigUnit_SetBoneTransform Copy()
	{
		return this;
	}

	public static FRigUnit_SetBoneTransform FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_SetBoneTransform(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_SetBoneTransform value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_SetBoneTransform FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_SetBoneTransform(nativeBuffer + arrayIndex * FRigUnit_SetBoneTransform_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_SetBoneTransform value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_SetBoneTransform_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_SetBoneTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SetBoneTransform");
		}
	}

	public FRigUnit_SetBoneTransform(IntPtr nativeStruct)
	{
		if (!FRigUnit_SetBoneTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SetBoneTransform");
		}
	}

	static FRigUnit_SetBoneTransform()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_SetBoneTransform)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_SetBoneTransform));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_SetBoneTransform");
		FRigUnit_SetBoneTransform_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_SetBoneTransform_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_SetBoneTransform", FRigUnit_SetBoneTransform_IsValid);
	}
}
