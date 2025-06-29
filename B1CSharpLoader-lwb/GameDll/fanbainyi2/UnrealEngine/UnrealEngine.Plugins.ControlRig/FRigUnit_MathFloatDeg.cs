using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathFloatDeg", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathFloatDeg
{
	private static bool FRigUnit_MathFloatDeg_IsValid;

	private static int FRigUnit_MathFloatDeg_StructSize;

	public FRigUnit_MathFloatDeg Copy()
	{
		return this;
	}

	public static FRigUnit_MathFloatDeg FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathFloatDeg(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathFloatDeg value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathFloatDeg FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathFloatDeg(nativeBuffer + arrayIndex * FRigUnit_MathFloatDeg_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathFloatDeg value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathFloatDeg_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatDeg_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatDeg");
		}
	}

	public FRigUnit_MathFloatDeg(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatDeg_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatDeg");
		}
	}

	static FRigUnit_MathFloatDeg()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathFloatDeg)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathFloatDeg));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathFloatDeg");
		FRigUnit_MathFloatDeg_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathFloatDeg_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathFloatDeg", FRigUnit_MathFloatDeg_IsValid);
	}
}
