using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathQuaternionToRotator", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathQuaternionToRotator
{
	private static bool FRigUnit_MathQuaternionToRotator_IsValid;

	private static int FRigUnit_MathQuaternionToRotator_StructSize;

	public FRigUnit_MathQuaternionToRotator Copy()
	{
		return this;
	}

	public static FRigUnit_MathQuaternionToRotator FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathQuaternionToRotator(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathQuaternionToRotator value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathQuaternionToRotator FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathQuaternionToRotator(nativeBuffer + arrayIndex * FRigUnit_MathQuaternionToRotator_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathQuaternionToRotator value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathQuaternionToRotator_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathQuaternionToRotator_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathQuaternionToRotator");
		}
	}

	public FRigUnit_MathQuaternionToRotator(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathQuaternionToRotator_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathQuaternionToRotator");
		}
	}

	static FRigUnit_MathQuaternionToRotator()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathQuaternionToRotator)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathQuaternionToRotator));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathQuaternionToRotator");
		FRigUnit_MathQuaternionToRotator_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathQuaternionToRotator_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathQuaternionToRotator", FRigUnit_MathQuaternionToRotator_IsValid);
	}
}
