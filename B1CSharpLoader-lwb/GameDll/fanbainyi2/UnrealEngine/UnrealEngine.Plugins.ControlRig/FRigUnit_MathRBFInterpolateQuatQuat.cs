using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathRBFInterpolateQuatQuat", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathRBFInterpolateQuatQuat
{
	private static bool FRigUnit_MathRBFInterpolateQuatQuat_IsValid;

	private static int FRigUnit_MathRBFInterpolateQuatQuat_StructSize;

	public FRigUnit_MathRBFInterpolateQuatQuat Copy()
	{
		return this;
	}

	public static FRigUnit_MathRBFInterpolateQuatQuat FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathRBFInterpolateQuatQuat(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathRBFInterpolateQuatQuat value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathRBFInterpolateQuatQuat FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathRBFInterpolateQuatQuat(nativeBuffer + arrayIndex * FRigUnit_MathRBFInterpolateQuatQuat_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathRBFInterpolateQuatQuat value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathRBFInterpolateQuatQuat_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathRBFInterpolateQuatQuat_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathRBFInterpolateQuatQuat");
		}
	}

	public FRigUnit_MathRBFInterpolateQuatQuat(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathRBFInterpolateQuatQuat_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathRBFInterpolateQuatQuat");
		}
	}

	static FRigUnit_MathRBFInterpolateQuatQuat()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathRBFInterpolateQuatQuat)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathRBFInterpolateQuatQuat));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathRBFInterpolateQuatQuat");
		FRigUnit_MathRBFInterpolateQuatQuat_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathRBFInterpolateQuatQuat_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathRBFInterpolateQuatQuat", FRigUnit_MathRBFInterpolateQuatQuat_IsValid);
	}
}
