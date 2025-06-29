using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathRBFInterpolateVectorBase", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathRBFInterpolateVectorBase
{
	private static bool FRigUnit_MathRBFInterpolateVectorBase_IsValid;

	private static int FRigUnit_MathRBFInterpolateVectorBase_StructSize;

	public FRigUnit_MathRBFInterpolateVectorBase Copy()
	{
		return this;
	}

	public static FRigUnit_MathRBFInterpolateVectorBase FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathRBFInterpolateVectorBase(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathRBFInterpolateVectorBase value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathRBFInterpolateVectorBase FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathRBFInterpolateVectorBase(nativeBuffer + arrayIndex * FRigUnit_MathRBFInterpolateVectorBase_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathRBFInterpolateVectorBase value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathRBFInterpolateVectorBase_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathRBFInterpolateVectorBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathRBFInterpolateVectorBase");
		}
	}

	public FRigUnit_MathRBFInterpolateVectorBase(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathRBFInterpolateVectorBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathRBFInterpolateVectorBase");
		}
	}

	static FRigUnit_MathRBFInterpolateVectorBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathRBFInterpolateVectorBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathRBFInterpolateVectorBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathRBFInterpolateVectorBase");
		FRigUnit_MathRBFInterpolateVectorBase_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathRBFInterpolateVectorBase_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathRBFInterpolateVectorBase", FRigUnit_MathRBFInterpolateVectorBase_IsValid);
	}
}
