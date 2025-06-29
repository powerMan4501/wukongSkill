using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_QuaternionFromAxisAndAngle", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_QuaternionFromAxisAndAngle
{
	private static bool FRigUnit_QuaternionFromAxisAndAngle_IsValid;

	private static int FRigUnit_QuaternionFromAxisAndAngle_StructSize;

	public FRigUnit_QuaternionFromAxisAndAngle Copy()
	{
		return this;
	}

	public static FRigUnit_QuaternionFromAxisAndAngle FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_QuaternionFromAxisAndAngle(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_QuaternionFromAxisAndAngle value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_QuaternionFromAxisAndAngle FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_QuaternionFromAxisAndAngle(nativeBuffer + arrayIndex * FRigUnit_QuaternionFromAxisAndAngle_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_QuaternionFromAxisAndAngle value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_QuaternionFromAxisAndAngle_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_QuaternionFromAxisAndAngle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_QuaternionFromAxisAndAngle");
		}
	}

	public FRigUnit_QuaternionFromAxisAndAngle(IntPtr nativeStruct)
	{
		if (!FRigUnit_QuaternionFromAxisAndAngle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_QuaternionFromAxisAndAngle");
		}
	}

	static FRigUnit_QuaternionFromAxisAndAngle()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_QuaternionFromAxisAndAngle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_QuaternionFromAxisAndAngle));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_QuaternionFromAxisAndAngle");
		FRigUnit_QuaternionFromAxisAndAngle_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_QuaternionFromAxisAndAngle_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_QuaternionFromAxisAndAngle", FRigUnit_QuaternionFromAxisAndAngle_IsValid);
	}
}
