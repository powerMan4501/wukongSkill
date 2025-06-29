using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_GetBoneTransform", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_GetBoneTransform
{
	private static bool FRigUnit_GetBoneTransform_IsValid;

	private static int FRigUnit_GetBoneTransform_StructSize;

	public FRigUnit_GetBoneTransform Copy()
	{
		return this;
	}

	public static FRigUnit_GetBoneTransform FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_GetBoneTransform(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_GetBoneTransform value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_GetBoneTransform FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_GetBoneTransform(nativeBuffer + arrayIndex * FRigUnit_GetBoneTransform_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_GetBoneTransform value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_GetBoneTransform_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_GetBoneTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_GetBoneTransform");
		}
	}

	public FRigUnit_GetBoneTransform(IntPtr nativeStruct)
	{
		if (!FRigUnit_GetBoneTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_GetBoneTransform");
		}
	}

	static FRigUnit_GetBoneTransform()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_GetBoneTransform)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_GetBoneTransform));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_GetBoneTransform");
		FRigUnit_GetBoneTransform_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_GetBoneTransform_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_GetBoneTransform", FRigUnit_GetBoneTransform_IsValid);
	}
}
