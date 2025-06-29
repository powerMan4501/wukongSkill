using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathQuaternionToAxisAndAngle", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathQuaternionToAxisAndAngle
{
	private static bool FRigUnit_MathQuaternionToAxisAndAngle_IsValid;

	private static int FRigUnit_MathQuaternionToAxisAndAngle_StructSize;

	public FRigUnit_MathQuaternionToAxisAndAngle Copy()
	{
		return this;
	}

	public static FRigUnit_MathQuaternionToAxisAndAngle FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathQuaternionToAxisAndAngle(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathQuaternionToAxisAndAngle value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathQuaternionToAxisAndAngle FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathQuaternionToAxisAndAngle(nativeBuffer + arrayIndex * FRigUnit_MathQuaternionToAxisAndAngle_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathQuaternionToAxisAndAngle value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathQuaternionToAxisAndAngle_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathQuaternionToAxisAndAngle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathQuaternionToAxisAndAngle");
		}
	}

	public FRigUnit_MathQuaternionToAxisAndAngle(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathQuaternionToAxisAndAngle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathQuaternionToAxisAndAngle");
		}
	}

	static FRigUnit_MathQuaternionToAxisAndAngle()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathQuaternionToAxisAndAngle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathQuaternionToAxisAndAngle));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathQuaternionToAxisAndAngle");
		FRigUnit_MathQuaternionToAxisAndAngle_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathQuaternionToAxisAndAngle_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathQuaternionToAxisAndAngle", FRigUnit_MathQuaternionToAxisAndAngle_IsValid);
	}
}
