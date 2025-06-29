using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathFloatIsNearlyZero", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathFloatIsNearlyZero
{
	private static bool FRigUnit_MathFloatIsNearlyZero_IsValid;

	private static int FRigUnit_MathFloatIsNearlyZero_StructSize;

	public FRigUnit_MathFloatIsNearlyZero Copy()
	{
		return this;
	}

	public static FRigUnit_MathFloatIsNearlyZero FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathFloatIsNearlyZero(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathFloatIsNearlyZero value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathFloatIsNearlyZero FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathFloatIsNearlyZero(nativeBuffer + arrayIndex * FRigUnit_MathFloatIsNearlyZero_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathFloatIsNearlyZero value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathFloatIsNearlyZero_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatIsNearlyZero_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatIsNearlyZero");
		}
	}

	public FRigUnit_MathFloatIsNearlyZero(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatIsNearlyZero_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatIsNearlyZero");
		}
	}

	static FRigUnit_MathFloatIsNearlyZero()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathFloatIsNearlyZero)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathFloatIsNearlyZero));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathFloatIsNearlyZero");
		FRigUnit_MathFloatIsNearlyZero_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathFloatIsNearlyZero_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathFloatIsNearlyZero", FRigUnit_MathFloatIsNearlyZero_IsValid);
	}
}
