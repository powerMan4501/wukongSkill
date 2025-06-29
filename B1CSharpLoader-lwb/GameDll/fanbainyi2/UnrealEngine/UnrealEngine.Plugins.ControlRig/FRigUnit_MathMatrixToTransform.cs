using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathMatrixToTransform", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathMatrixToTransform
{
	private static bool FRigUnit_MathMatrixToTransform_IsValid;

	private static int FRigUnit_MathMatrixToTransform_StructSize;

	public FRigUnit_MathMatrixToTransform Copy()
	{
		return this;
	}

	public static FRigUnit_MathMatrixToTransform FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathMatrixToTransform(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathMatrixToTransform value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathMatrixToTransform FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathMatrixToTransform(nativeBuffer + arrayIndex * FRigUnit_MathMatrixToTransform_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathMatrixToTransform value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathMatrixToTransform_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathMatrixToTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathMatrixToTransform");
		}
	}

	public FRigUnit_MathMatrixToTransform(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathMatrixToTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathMatrixToTransform");
		}
	}

	static FRigUnit_MathMatrixToTransform()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathMatrixToTransform)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathMatrixToTransform));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathMatrixToTransform");
		FRigUnit_MathMatrixToTransform_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathMatrixToTransform_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathMatrixToTransform", FRigUnit_MathMatrixToTransform_IsValid);
	}
}
