using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathRBFInterpolateQuatFloat", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathRBFInterpolateQuatFloat
{
	private static bool FRigUnit_MathRBFInterpolateQuatFloat_IsValid;

	private static int FRigUnit_MathRBFInterpolateQuatFloat_StructSize;

	public FRigUnit_MathRBFInterpolateQuatFloat Copy()
	{
		return this;
	}

	public static FRigUnit_MathRBFInterpolateQuatFloat FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathRBFInterpolateQuatFloat(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathRBFInterpolateQuatFloat value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathRBFInterpolateQuatFloat FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathRBFInterpolateQuatFloat(nativeBuffer + arrayIndex * FRigUnit_MathRBFInterpolateQuatFloat_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathRBFInterpolateQuatFloat value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathRBFInterpolateQuatFloat_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathRBFInterpolateQuatFloat_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathRBFInterpolateQuatFloat");
		}
	}

	public FRigUnit_MathRBFInterpolateQuatFloat(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathRBFInterpolateQuatFloat_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathRBFInterpolateQuatFloat");
		}
	}

	static FRigUnit_MathRBFInterpolateQuatFloat()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathRBFInterpolateQuatFloat)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathRBFInterpolateQuatFloat));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathRBFInterpolateQuatFloat");
		FRigUnit_MathRBFInterpolateQuatFloat_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathRBFInterpolateQuatFloat_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathRBFInterpolateQuatFloat", FRigUnit_MathRBFInterpolateQuatFloat_IsValid);
	}
}
