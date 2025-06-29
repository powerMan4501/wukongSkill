using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathFloatIsNearlyEqual", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathFloatIsNearlyEqual
{
	private static bool FRigUnit_MathFloatIsNearlyEqual_IsValid;

	private static int FRigUnit_MathFloatIsNearlyEqual_StructSize;

	public FRigUnit_MathFloatIsNearlyEqual Copy()
	{
		return this;
	}

	public static FRigUnit_MathFloatIsNearlyEqual FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathFloatIsNearlyEqual(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathFloatIsNearlyEqual value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathFloatIsNearlyEqual FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathFloatIsNearlyEqual(nativeBuffer + arrayIndex * FRigUnit_MathFloatIsNearlyEqual_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathFloatIsNearlyEqual value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathFloatIsNearlyEqual_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatIsNearlyEqual_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatIsNearlyEqual");
		}
	}

	public FRigUnit_MathFloatIsNearlyEqual(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatIsNearlyEqual_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatIsNearlyEqual");
		}
	}

	static FRigUnit_MathFloatIsNearlyEqual()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathFloatIsNearlyEqual)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathFloatIsNearlyEqual));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathFloatIsNearlyEqual");
		FRigUnit_MathFloatIsNearlyEqual_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathFloatIsNearlyEqual_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathFloatIsNearlyEqual", FRigUnit_MathFloatIsNearlyEqual_IsValid);
	}
}
