using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_QuaternionToAxisAndAngle", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_QuaternionToAxisAndAngle
{
	private static bool FRigUnit_QuaternionToAxisAndAngle_IsValid;

	private static int FRigUnit_QuaternionToAxisAndAngle_StructSize;

	public FRigUnit_QuaternionToAxisAndAngle Copy()
	{
		return this;
	}

	public static FRigUnit_QuaternionToAxisAndAngle FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_QuaternionToAxisAndAngle(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_QuaternionToAxisAndAngle value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_QuaternionToAxisAndAngle FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_QuaternionToAxisAndAngle(nativeBuffer + arrayIndex * FRigUnit_QuaternionToAxisAndAngle_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_QuaternionToAxisAndAngle value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_QuaternionToAxisAndAngle_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_QuaternionToAxisAndAngle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_QuaternionToAxisAndAngle");
		}
	}

	public FRigUnit_QuaternionToAxisAndAngle(IntPtr nativeStruct)
	{
		if (!FRigUnit_QuaternionToAxisAndAngle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_QuaternionToAxisAndAngle");
		}
	}

	static FRigUnit_QuaternionToAxisAndAngle()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_QuaternionToAxisAndAngle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_QuaternionToAxisAndAngle));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_QuaternionToAxisAndAngle");
		FRigUnit_QuaternionToAxisAndAngle_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_QuaternionToAxisAndAngle_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_QuaternionToAxisAndAngle", FRigUnit_QuaternionToAxisAndAngle_IsValid);
	}
}
