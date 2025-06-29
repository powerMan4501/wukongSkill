using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_AimBone", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_AimBone
{
	private static bool FRigUnit_AimBone_IsValid;

	private static int FRigUnit_AimBone_StructSize;

	public FRigUnit_AimBone Copy()
	{
		return this;
	}

	public static FRigUnit_AimBone FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_AimBone(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_AimBone value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_AimBone FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_AimBone(nativeBuffer + arrayIndex * FRigUnit_AimBone_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_AimBone value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_AimBone_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_AimBone_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_AimBone");
		}
	}

	public FRigUnit_AimBone(IntPtr nativeStruct)
	{
		if (!FRigUnit_AimBone_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_AimBone");
		}
	}

	static FRigUnit_AimBone()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_AimBone)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_AimBone));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_AimBone");
		FRigUnit_AimBone_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_AimBone_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_AimBone", FRigUnit_AimBone_IsValid);
	}
}
