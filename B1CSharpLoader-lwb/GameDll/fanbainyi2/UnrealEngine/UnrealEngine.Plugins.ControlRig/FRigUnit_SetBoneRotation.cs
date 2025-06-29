using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_SetBoneRotation", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_SetBoneRotation
{
	private static bool FRigUnit_SetBoneRotation_IsValid;

	private static int FRigUnit_SetBoneRotation_StructSize;

	public FRigUnit_SetBoneRotation Copy()
	{
		return this;
	}

	public static FRigUnit_SetBoneRotation FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_SetBoneRotation(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_SetBoneRotation value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_SetBoneRotation FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_SetBoneRotation(nativeBuffer + arrayIndex * FRigUnit_SetBoneRotation_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_SetBoneRotation value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_SetBoneRotation_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_SetBoneRotation_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SetBoneRotation");
		}
	}

	public FRigUnit_SetBoneRotation(IntPtr nativeStruct)
	{
		if (!FRigUnit_SetBoneRotation_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SetBoneRotation");
		}
	}

	static FRigUnit_SetBoneRotation()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_SetBoneRotation)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_SetBoneRotation));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_SetBoneRotation");
		FRigUnit_SetBoneRotation_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_SetBoneRotation_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_SetBoneRotation", FRigUnit_SetBoneRotation_IsValid);
	}
}
