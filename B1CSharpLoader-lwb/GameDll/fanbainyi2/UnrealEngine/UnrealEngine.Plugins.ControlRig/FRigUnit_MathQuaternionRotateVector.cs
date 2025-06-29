using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathQuaternionRotateVector", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathQuaternionRotateVector
{
	private static bool FRigUnit_MathQuaternionRotateVector_IsValid;

	private static int FRigUnit_MathQuaternionRotateVector_StructSize;

	public FRigUnit_MathQuaternionRotateVector Copy()
	{
		return this;
	}

	public static FRigUnit_MathQuaternionRotateVector FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathQuaternionRotateVector(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathQuaternionRotateVector value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathQuaternionRotateVector FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathQuaternionRotateVector(nativeBuffer + arrayIndex * FRigUnit_MathQuaternionRotateVector_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathQuaternionRotateVector value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathQuaternionRotateVector_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathQuaternionRotateVector_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathQuaternionRotateVector");
		}
	}

	public FRigUnit_MathQuaternionRotateVector(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathQuaternionRotateVector_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathQuaternionRotateVector");
		}
	}

	static FRigUnit_MathQuaternionRotateVector()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathQuaternionRotateVector)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathQuaternionRotateVector));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathQuaternionRotateVector");
		FRigUnit_MathQuaternionRotateVector_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathQuaternionRotateVector_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathQuaternionRotateVector", FRigUnit_MathQuaternionRotateVector_IsValid);
	}
}
