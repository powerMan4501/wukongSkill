using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathRBFInterpolateQuatBase", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathRBFInterpolateQuatBase
{
	private static bool FRigUnit_MathRBFInterpolateQuatBase_IsValid;

	private static int FRigUnit_MathRBFInterpolateQuatBase_StructSize;

	public FRigUnit_MathRBFInterpolateQuatBase Copy()
	{
		return this;
	}

	public static FRigUnit_MathRBFInterpolateQuatBase FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathRBFInterpolateQuatBase(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathRBFInterpolateQuatBase value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathRBFInterpolateQuatBase FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathRBFInterpolateQuatBase(nativeBuffer + arrayIndex * FRigUnit_MathRBFInterpolateQuatBase_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathRBFInterpolateQuatBase value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathRBFInterpolateQuatBase_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathRBFInterpolateQuatBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathRBFInterpolateQuatBase");
		}
	}

	public FRigUnit_MathRBFInterpolateQuatBase(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathRBFInterpolateQuatBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathRBFInterpolateQuatBase");
		}
	}

	static FRigUnit_MathRBFInterpolateQuatBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathRBFInterpolateQuatBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathRBFInterpolateQuatBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathRBFInterpolateQuatBase");
		FRigUnit_MathRBFInterpolateQuatBase_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathRBFInterpolateQuatBase_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathRBFInterpolateQuatBase", FRigUnit_MathRBFInterpolateQuatBase_IsValid);
	}
}
