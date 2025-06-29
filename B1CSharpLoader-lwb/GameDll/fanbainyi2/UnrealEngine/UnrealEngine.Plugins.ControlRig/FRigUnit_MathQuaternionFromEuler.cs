using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathQuaternionFromEuler", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathQuaternionFromEuler
{
	private static bool FRigUnit_MathQuaternionFromEuler_IsValid;

	private static int FRigUnit_MathQuaternionFromEuler_StructSize;

	public FRigUnit_MathQuaternionFromEuler Copy()
	{
		return this;
	}

	public static FRigUnit_MathQuaternionFromEuler FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathQuaternionFromEuler(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathQuaternionFromEuler value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathQuaternionFromEuler FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathQuaternionFromEuler(nativeBuffer + arrayIndex * FRigUnit_MathQuaternionFromEuler_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathQuaternionFromEuler value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathQuaternionFromEuler_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathQuaternionFromEuler_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathQuaternionFromEuler");
		}
	}

	public FRigUnit_MathQuaternionFromEuler(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathQuaternionFromEuler_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathQuaternionFromEuler");
		}
	}

	static FRigUnit_MathQuaternionFromEuler()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathQuaternionFromEuler)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathQuaternionFromEuler));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathQuaternionFromEuler");
		FRigUnit_MathQuaternionFromEuler_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathQuaternionFromEuler_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathQuaternionFromEuler", FRigUnit_MathQuaternionFromEuler_IsValid);
	}
}
