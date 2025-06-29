using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_QuaternionToAngle", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_QuaternionToAngle
{
	private static bool FRigUnit_QuaternionToAngle_IsValid;

	private static int FRigUnit_QuaternionToAngle_StructSize;

	public FRigUnit_QuaternionToAngle Copy()
	{
		return this;
	}

	public static FRigUnit_QuaternionToAngle FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_QuaternionToAngle(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_QuaternionToAngle value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_QuaternionToAngle FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_QuaternionToAngle(nativeBuffer + arrayIndex * FRigUnit_QuaternionToAngle_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_QuaternionToAngle value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_QuaternionToAngle_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_QuaternionToAngle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_QuaternionToAngle");
		}
	}

	public FRigUnit_QuaternionToAngle(IntPtr nativeStruct)
	{
		if (!FRigUnit_QuaternionToAngle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_QuaternionToAngle");
		}
	}

	static FRigUnit_QuaternionToAngle()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_QuaternionToAngle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_QuaternionToAngle));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_QuaternionToAngle");
		FRigUnit_QuaternionToAngle_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_QuaternionToAngle_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_QuaternionToAngle", FRigUnit_QuaternionToAngle_IsValid);
	}
}
