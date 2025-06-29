using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_ModifyBoneTransforms", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_ModifyBoneTransforms
{
	private static bool FRigUnit_ModifyBoneTransforms_IsValid;

	private static int FRigUnit_ModifyBoneTransforms_StructSize;

	public FRigUnit_ModifyBoneTransforms Copy()
	{
		return this;
	}

	public static FRigUnit_ModifyBoneTransforms FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_ModifyBoneTransforms(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_ModifyBoneTransforms value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_ModifyBoneTransforms FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_ModifyBoneTransforms(nativeBuffer + arrayIndex * FRigUnit_ModifyBoneTransforms_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_ModifyBoneTransforms value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_ModifyBoneTransforms_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_ModifyBoneTransforms_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ModifyBoneTransforms");
		}
	}

	public FRigUnit_ModifyBoneTransforms(IntPtr nativeStruct)
	{
		if (!FRigUnit_ModifyBoneTransforms_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ModifyBoneTransforms");
		}
	}

	static FRigUnit_ModifyBoneTransforms()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_ModifyBoneTransforms)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_ModifyBoneTransforms));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_ModifyBoneTransforms");
		FRigUnit_ModifyBoneTransforms_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_ModifyBoneTransforms_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_ModifyBoneTransforms", FRigUnit_ModifyBoneTransforms_IsValid);
	}
}
