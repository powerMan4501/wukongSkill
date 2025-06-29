using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathTransformRotateVector", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathTransformRotateVector
{
	private static bool FRigUnit_MathTransformRotateVector_IsValid;

	private static int FRigUnit_MathTransformRotateVector_StructSize;

	public FRigUnit_MathTransformRotateVector Copy()
	{
		return this;
	}

	public static FRigUnit_MathTransformRotateVector FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathTransformRotateVector(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathTransformRotateVector value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathTransformRotateVector FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathTransformRotateVector(nativeBuffer + arrayIndex * FRigUnit_MathTransformRotateVector_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathTransformRotateVector value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathTransformRotateVector_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathTransformRotateVector_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathTransformRotateVector");
		}
	}

	public FRigUnit_MathTransformRotateVector(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathTransformRotateVector_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathTransformRotateVector");
		}
	}

	static FRigUnit_MathTransformRotateVector()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathTransformRotateVector)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathTransformRotateVector));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathTransformRotateVector");
		FRigUnit_MathTransformRotateVector_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathTransformRotateVector_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathTransformRotateVector", FRigUnit_MathTransformRotateVector_IsValid);
	}
}
