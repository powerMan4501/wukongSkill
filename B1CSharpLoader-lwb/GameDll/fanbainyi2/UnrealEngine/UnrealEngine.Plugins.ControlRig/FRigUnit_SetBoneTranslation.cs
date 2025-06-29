using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_SetBoneTranslation", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_SetBoneTranslation
{
	private static bool FRigUnit_SetBoneTranslation_IsValid;

	private static int FRigUnit_SetBoneTranslation_StructSize;

	public FRigUnit_SetBoneTranslation Copy()
	{
		return this;
	}

	public static FRigUnit_SetBoneTranslation FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_SetBoneTranslation(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_SetBoneTranslation value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_SetBoneTranslation FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_SetBoneTranslation(nativeBuffer + arrayIndex * FRigUnit_SetBoneTranslation_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_SetBoneTranslation value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_SetBoneTranslation_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_SetBoneTranslation_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SetBoneTranslation");
		}
	}

	public FRigUnit_SetBoneTranslation(IntPtr nativeStruct)
	{
		if (!FRigUnit_SetBoneTranslation_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SetBoneTranslation");
		}
	}

	static FRigUnit_SetBoneTranslation()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_SetBoneTranslation)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_SetBoneTranslation));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_SetBoneTranslation");
		FRigUnit_SetBoneTranslation_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_SetBoneTranslation_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_SetBoneTranslation", FRigUnit_SetBoneTranslation_IsValid);
	}
}
