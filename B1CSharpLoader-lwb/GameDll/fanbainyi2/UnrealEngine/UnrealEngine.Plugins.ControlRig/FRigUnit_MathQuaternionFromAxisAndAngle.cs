using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathQuaternionFromAxisAndAngle", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathQuaternionFromAxisAndAngle
{
	private static bool FRigUnit_MathQuaternionFromAxisAndAngle_IsValid;

	private static int FRigUnit_MathQuaternionFromAxisAndAngle_StructSize;

	public FRigUnit_MathQuaternionFromAxisAndAngle Copy()
	{
		return this;
	}

	public static FRigUnit_MathQuaternionFromAxisAndAngle FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathQuaternionFromAxisAndAngle(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathQuaternionFromAxisAndAngle value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathQuaternionFromAxisAndAngle FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathQuaternionFromAxisAndAngle(nativeBuffer + arrayIndex * FRigUnit_MathQuaternionFromAxisAndAngle_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathQuaternionFromAxisAndAngle value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathQuaternionFromAxisAndAngle_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathQuaternionFromAxisAndAngle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathQuaternionFromAxisAndAngle");
		}
	}

	public FRigUnit_MathQuaternionFromAxisAndAngle(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathQuaternionFromAxisAndAngle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathQuaternionFromAxisAndAngle");
		}
	}

	static FRigUnit_MathQuaternionFromAxisAndAngle()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathQuaternionFromAxisAndAngle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathQuaternionFromAxisAndAngle));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathQuaternionFromAxisAndAngle");
		FRigUnit_MathQuaternionFromAxisAndAngle_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathQuaternionFromAxisAndAngle_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathQuaternionFromAxisAndAngle", FRigUnit_MathQuaternionFromAxisAndAngle_IsValid);
	}
}
