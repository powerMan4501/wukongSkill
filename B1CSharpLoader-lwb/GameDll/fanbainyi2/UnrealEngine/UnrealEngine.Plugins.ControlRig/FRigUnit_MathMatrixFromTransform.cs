using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathMatrixFromTransform", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathMatrixFromTransform
{
	private static bool FRigUnit_MathMatrixFromTransform_IsValid;

	private static int FRigUnit_MathMatrixFromTransform_StructSize;

	public FRigUnit_MathMatrixFromTransform Copy()
	{
		return this;
	}

	public static FRigUnit_MathMatrixFromTransform FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathMatrixFromTransform(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathMatrixFromTransform value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathMatrixFromTransform FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathMatrixFromTransform(nativeBuffer + arrayIndex * FRigUnit_MathMatrixFromTransform_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathMatrixFromTransform value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathMatrixFromTransform_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathMatrixFromTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathMatrixFromTransform");
		}
	}

	public FRigUnit_MathMatrixFromTransform(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathMatrixFromTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathMatrixFromTransform");
		}
	}

	static FRigUnit_MathMatrixFromTransform()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathMatrixFromTransform)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathMatrixFromTransform));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathMatrixFromTransform");
		FRigUnit_MathMatrixFromTransform_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathMatrixFromTransform_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathMatrixFromTransform", FRigUnit_MathMatrixFromTransform_IsValid);
	}
}
