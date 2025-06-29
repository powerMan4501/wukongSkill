using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathQuaternionToEuler", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathQuaternionToEuler
{
	private static bool FRigUnit_MathQuaternionToEuler_IsValid;

	private static int FRigUnit_MathQuaternionToEuler_StructSize;

	public FRigUnit_MathQuaternionToEuler Copy()
	{
		return this;
	}

	public static FRigUnit_MathQuaternionToEuler FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathQuaternionToEuler(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathQuaternionToEuler value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathQuaternionToEuler FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathQuaternionToEuler(nativeBuffer + arrayIndex * FRigUnit_MathQuaternionToEuler_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathQuaternionToEuler value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathQuaternionToEuler_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathQuaternionToEuler_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathQuaternionToEuler");
		}
	}

	public FRigUnit_MathQuaternionToEuler(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathQuaternionToEuler_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathQuaternionToEuler");
		}
	}

	static FRigUnit_MathQuaternionToEuler()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathQuaternionToEuler)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathQuaternionToEuler));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathQuaternionToEuler");
		FRigUnit_MathQuaternionToEuler_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathQuaternionToEuler_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathQuaternionToEuler", FRigUnit_MathQuaternionToEuler_IsValid);
	}
}
