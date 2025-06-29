using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathFloatAsin", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathFloatAsin
{
	private static bool FRigUnit_MathFloatAsin_IsValid;

	private static int FRigUnit_MathFloatAsin_StructSize;

	public FRigUnit_MathFloatAsin Copy()
	{
		return this;
	}

	public static FRigUnit_MathFloatAsin FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathFloatAsin(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathFloatAsin value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathFloatAsin FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathFloatAsin(nativeBuffer + arrayIndex * FRigUnit_MathFloatAsin_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathFloatAsin value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathFloatAsin_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatAsin_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatAsin");
		}
	}

	public FRigUnit_MathFloatAsin(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatAsin_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatAsin");
		}
	}

	static FRigUnit_MathFloatAsin()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathFloatAsin)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathFloatAsin));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathFloatAsin");
		FRigUnit_MathFloatAsin_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathFloatAsin_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathFloatAsin", FRigUnit_MathFloatAsin_IsValid);
	}
}
