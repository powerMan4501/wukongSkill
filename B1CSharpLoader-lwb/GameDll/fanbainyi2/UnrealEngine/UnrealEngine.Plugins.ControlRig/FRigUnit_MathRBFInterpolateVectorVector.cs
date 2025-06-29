using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathRBFInterpolateVectorVector", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathRBFInterpolateVectorVector
{
	private static bool FRigUnit_MathRBFInterpolateVectorVector_IsValid;

	private static int FRigUnit_MathRBFInterpolateVectorVector_StructSize;

	public FRigUnit_MathRBFInterpolateVectorVector Copy()
	{
		return this;
	}

	public static FRigUnit_MathRBFInterpolateVectorVector FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathRBFInterpolateVectorVector(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathRBFInterpolateVectorVector value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathRBFInterpolateVectorVector FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathRBFInterpolateVectorVector(nativeBuffer + arrayIndex * FRigUnit_MathRBFInterpolateVectorVector_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathRBFInterpolateVectorVector value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathRBFInterpolateVectorVector_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathRBFInterpolateVectorVector_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathRBFInterpolateVectorVector");
		}
	}

	public FRigUnit_MathRBFInterpolateVectorVector(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathRBFInterpolateVectorVector_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathRBFInterpolateVectorVector");
		}
	}

	static FRigUnit_MathRBFInterpolateVectorVector()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathRBFInterpolateVectorVector)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathRBFInterpolateVectorVector));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathRBFInterpolateVectorVector");
		FRigUnit_MathRBFInterpolateVectorVector_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathRBFInterpolateVectorVector_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathRBFInterpolateVectorVector", FRigUnit_MathRBFInterpolateVectorVector_IsValid);
	}
}
