using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathRBFInterpolateVectorXform", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathRBFInterpolateVectorXform
{
	private static bool FRigUnit_MathRBFInterpolateVectorXform_IsValid;

	private static int FRigUnit_MathRBFInterpolateVectorXform_StructSize;

	public FRigUnit_MathRBFInterpolateVectorXform Copy()
	{
		return this;
	}

	public static FRigUnit_MathRBFInterpolateVectorXform FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathRBFInterpolateVectorXform(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathRBFInterpolateVectorXform value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathRBFInterpolateVectorXform FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathRBFInterpolateVectorXform(nativeBuffer + arrayIndex * FRigUnit_MathRBFInterpolateVectorXform_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathRBFInterpolateVectorXform value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathRBFInterpolateVectorXform_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathRBFInterpolateVectorXform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathRBFInterpolateVectorXform");
		}
	}

	public FRigUnit_MathRBFInterpolateVectorXform(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathRBFInterpolateVectorXform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathRBFInterpolateVectorXform");
		}
	}

	static FRigUnit_MathRBFInterpolateVectorXform()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathRBFInterpolateVectorXform)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathRBFInterpolateVectorXform));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathRBFInterpolateVectorXform");
		FRigUnit_MathRBFInterpolateVectorXform_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathRBFInterpolateVectorXform_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathRBFInterpolateVectorXform", FRigUnit_MathRBFInterpolateVectorXform_IsValid);
	}
}
