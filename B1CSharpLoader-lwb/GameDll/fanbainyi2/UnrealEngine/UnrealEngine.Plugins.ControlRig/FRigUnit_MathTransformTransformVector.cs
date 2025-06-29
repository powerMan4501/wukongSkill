using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathTransformTransformVector", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathTransformTransformVector
{
	private static bool FRigUnit_MathTransformTransformVector_IsValid;

	private static int FRigUnit_MathTransformTransformVector_StructSize;

	public FRigUnit_MathTransformTransformVector Copy()
	{
		return this;
	}

	public static FRigUnit_MathTransformTransformVector FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathTransformTransformVector(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathTransformTransformVector value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathTransformTransformVector FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathTransformTransformVector(nativeBuffer + arrayIndex * FRigUnit_MathTransformTransformVector_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathTransformTransformVector value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathTransformTransformVector_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathTransformTransformVector_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathTransformTransformVector");
		}
	}

	public FRigUnit_MathTransformTransformVector(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathTransformTransformVector_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathTransformTransformVector");
		}
	}

	static FRigUnit_MathTransformTransformVector()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathTransformTransformVector)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathTransformTransformVector));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathTransformTransformVector");
		FRigUnit_MathTransformTransformVector_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathTransformTransformVector_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathTransformTransformVector", FRigUnit_MathTransformTransformVector_IsValid);
	}
}
