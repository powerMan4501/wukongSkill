using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_GetInitialBoneTransform", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_GetInitialBoneTransform
{
	private static bool FRigUnit_GetInitialBoneTransform_IsValid;

	private static int FRigUnit_GetInitialBoneTransform_StructSize;

	public FRigUnit_GetInitialBoneTransform Copy()
	{
		return this;
	}

	public static FRigUnit_GetInitialBoneTransform FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_GetInitialBoneTransform(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_GetInitialBoneTransform value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_GetInitialBoneTransform FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_GetInitialBoneTransform(nativeBuffer + arrayIndex * FRigUnit_GetInitialBoneTransform_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_GetInitialBoneTransform value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_GetInitialBoneTransform_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_GetInitialBoneTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_GetInitialBoneTransform");
		}
	}

	public FRigUnit_GetInitialBoneTransform(IntPtr nativeStruct)
	{
		if (!FRigUnit_GetInitialBoneTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_GetInitialBoneTransform");
		}
	}

	static FRigUnit_GetInitialBoneTransform()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_GetInitialBoneTransform)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_GetInitialBoneTransform));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_GetInitialBoneTransform");
		FRigUnit_GetInitialBoneTransform_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_GetInitialBoneTransform_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_GetInitialBoneTransform", FRigUnit_GetInitialBoneTransform_IsValid);
	}
}
