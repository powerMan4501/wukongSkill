using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathRBFInterpolateQuatColor", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathRBFInterpolateQuatColor
{
	private static bool FRigUnit_MathRBFInterpolateQuatColor_IsValid;

	private static int FRigUnit_MathRBFInterpolateQuatColor_StructSize;

	public FRigUnit_MathRBFInterpolateQuatColor Copy()
	{
		return this;
	}

	public static FRigUnit_MathRBFInterpolateQuatColor FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathRBFInterpolateQuatColor(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathRBFInterpolateQuatColor value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathRBFInterpolateQuatColor FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathRBFInterpolateQuatColor(nativeBuffer + arrayIndex * FRigUnit_MathRBFInterpolateQuatColor_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathRBFInterpolateQuatColor value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathRBFInterpolateQuatColor_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathRBFInterpolateQuatColor_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathRBFInterpolateQuatColor");
		}
	}

	public FRigUnit_MathRBFInterpolateQuatColor(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathRBFInterpolateQuatColor_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathRBFInterpolateQuatColor");
		}
	}

	static FRigUnit_MathRBFInterpolateQuatColor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathRBFInterpolateQuatColor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathRBFInterpolateQuatColor));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathRBFInterpolateQuatColor");
		FRigUnit_MathRBFInterpolateQuatColor_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathRBFInterpolateQuatColor_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathRBFInterpolateQuatColor", FRigUnit_MathRBFInterpolateQuatColor_IsValid);
	}
}
