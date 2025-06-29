using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathRBFInterpolateVectorColor", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathRBFInterpolateVectorColor
{
	private static bool FRigUnit_MathRBFInterpolateVectorColor_IsValid;

	private static int FRigUnit_MathRBFInterpolateVectorColor_StructSize;

	public FRigUnit_MathRBFInterpolateVectorColor Copy()
	{
		return this;
	}

	public static FRigUnit_MathRBFInterpolateVectorColor FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathRBFInterpolateVectorColor(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathRBFInterpolateVectorColor value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathRBFInterpolateVectorColor FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathRBFInterpolateVectorColor(nativeBuffer + arrayIndex * FRigUnit_MathRBFInterpolateVectorColor_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathRBFInterpolateVectorColor value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathRBFInterpolateVectorColor_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathRBFInterpolateVectorColor_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathRBFInterpolateVectorColor");
		}
	}

	public FRigUnit_MathRBFInterpolateVectorColor(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathRBFInterpolateVectorColor_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathRBFInterpolateVectorColor");
		}
	}

	static FRigUnit_MathRBFInterpolateVectorColor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathRBFInterpolateVectorColor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathRBFInterpolateVectorColor));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathRBFInterpolateVectorColor");
		FRigUnit_MathRBFInterpolateVectorColor_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathRBFInterpolateVectorColor_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathRBFInterpolateVectorColor", FRigUnit_MathRBFInterpolateVectorColor_IsValid);
	}
}
