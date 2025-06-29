using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathRBFInterpolateBase", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathRBFInterpolateBase
{
	private static bool FRigUnit_MathRBFInterpolateBase_IsValid;

	private static int FRigUnit_MathRBFInterpolateBase_StructSize;

	public FRigUnit_MathRBFInterpolateBase Copy()
	{
		return this;
	}

	public static FRigUnit_MathRBFInterpolateBase FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathRBFInterpolateBase(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathRBFInterpolateBase value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathRBFInterpolateBase FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathRBFInterpolateBase(nativeBuffer + arrayIndex * FRigUnit_MathRBFInterpolateBase_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathRBFInterpolateBase value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathRBFInterpolateBase_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathRBFInterpolateBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathRBFInterpolateBase");
		}
	}

	public FRigUnit_MathRBFInterpolateBase(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathRBFInterpolateBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathRBFInterpolateBase");
		}
	}

	static FRigUnit_MathRBFInterpolateBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathRBFInterpolateBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathRBFInterpolateBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathRBFInterpolateBase");
		FRigUnit_MathRBFInterpolateBase_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathRBFInterpolateBase_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathRBFInterpolateBase", FRigUnit_MathRBFInterpolateBase_IsValid);
	}
}
