using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathTransformFromEulerTransform", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathTransformFromEulerTransform
{
	private static bool FRigUnit_MathTransformFromEulerTransform_IsValid;

	private static int FRigUnit_MathTransformFromEulerTransform_StructSize;

	public FRigUnit_MathTransformFromEulerTransform Copy()
	{
		return this;
	}

	public static FRigUnit_MathTransformFromEulerTransform FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathTransformFromEulerTransform(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathTransformFromEulerTransform value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathTransformFromEulerTransform FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathTransformFromEulerTransform(nativeBuffer + arrayIndex * FRigUnit_MathTransformFromEulerTransform_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathTransformFromEulerTransform value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathTransformFromEulerTransform_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathTransformFromEulerTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathTransformFromEulerTransform");
		}
	}

	public FRigUnit_MathTransformFromEulerTransform(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathTransformFromEulerTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathTransformFromEulerTransform");
		}
	}

	static FRigUnit_MathTransformFromEulerTransform()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathTransformFromEulerTransform)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathTransformFromEulerTransform));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathTransformFromEulerTransform");
		FRigUnit_MathTransformFromEulerTransform_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathTransformFromEulerTransform_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathTransformFromEulerTransform", FRigUnit_MathTransformFromEulerTransform_IsValid);
	}
}
