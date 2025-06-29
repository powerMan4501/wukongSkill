using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_AddBoneTransform", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_AddBoneTransform
{
	private static bool FRigUnit_AddBoneTransform_IsValid;

	private static int FRigUnit_AddBoneTransform_StructSize;

	public FRigUnit_AddBoneTransform Copy()
	{
		return this;
	}

	public static FRigUnit_AddBoneTransform FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_AddBoneTransform(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_AddBoneTransform value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_AddBoneTransform FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_AddBoneTransform(nativeBuffer + arrayIndex * FRigUnit_AddBoneTransform_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_AddBoneTransform value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_AddBoneTransform_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_AddBoneTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_AddBoneTransform");
		}
	}

	public FRigUnit_AddBoneTransform(IntPtr nativeStruct)
	{
		if (!FRigUnit_AddBoneTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_AddBoneTransform");
		}
	}

	static FRigUnit_AddBoneTransform()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_AddBoneTransform)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_AddBoneTransform));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_AddBoneTransform");
		FRigUnit_AddBoneTransform_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_AddBoneTransform_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_AddBoneTransform", FRigUnit_AddBoneTransform_IsValid);
	}
}
