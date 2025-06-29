using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathTransformToEulerTransform", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathTransformToEulerTransform
{
	private static bool FRigUnit_MathTransformToEulerTransform_IsValid;

	private static int FRigUnit_MathTransformToEulerTransform_StructSize;

	public FRigUnit_MathTransformToEulerTransform Copy()
	{
		return this;
	}

	public static FRigUnit_MathTransformToEulerTransform FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathTransformToEulerTransform(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathTransformToEulerTransform value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathTransformToEulerTransform FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathTransformToEulerTransform(nativeBuffer + arrayIndex * FRigUnit_MathTransformToEulerTransform_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathTransformToEulerTransform value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathTransformToEulerTransform_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathTransformToEulerTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathTransformToEulerTransform");
		}
	}

	public FRigUnit_MathTransformToEulerTransform(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathTransformToEulerTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathTransformToEulerTransform");
		}
	}

	static FRigUnit_MathTransformToEulerTransform()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathTransformToEulerTransform)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathTransformToEulerTransform));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathTransformToEulerTransform");
		FRigUnit_MathTransformToEulerTransform_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathTransformToEulerTransform_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathTransformToEulerTransform", FRigUnit_MathTransformToEulerTransform_IsValid);
	}
}
