using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathRBFInterpolateVectorQuat", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathRBFInterpolateVectorQuat
{
	private static bool FRigUnit_MathRBFInterpolateVectorQuat_IsValid;

	private static int FRigUnit_MathRBFInterpolateVectorQuat_StructSize;

	public FRigUnit_MathRBFInterpolateVectorQuat Copy()
	{
		return this;
	}

	public static FRigUnit_MathRBFInterpolateVectorQuat FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathRBFInterpolateVectorQuat(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathRBFInterpolateVectorQuat value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathRBFInterpolateVectorQuat FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathRBFInterpolateVectorQuat(nativeBuffer + arrayIndex * FRigUnit_MathRBFInterpolateVectorQuat_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathRBFInterpolateVectorQuat value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathRBFInterpolateVectorQuat_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathRBFInterpolateVectorQuat_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathRBFInterpolateVectorQuat");
		}
	}

	public FRigUnit_MathRBFInterpolateVectorQuat(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathRBFInterpolateVectorQuat_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathRBFInterpolateVectorQuat");
		}
	}

	static FRigUnit_MathRBFInterpolateVectorQuat()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathRBFInterpolateVectorQuat)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathRBFInterpolateVectorQuat));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathRBFInterpolateVectorQuat");
		FRigUnit_MathRBFInterpolateVectorQuat_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathRBFInterpolateVectorQuat_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathRBFInterpolateVectorQuat", FRigUnit_MathRBFInterpolateVectorQuat_IsValid);
	}
}
