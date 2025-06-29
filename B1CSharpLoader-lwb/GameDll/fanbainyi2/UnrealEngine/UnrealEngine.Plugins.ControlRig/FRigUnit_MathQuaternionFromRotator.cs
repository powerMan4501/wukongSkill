using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathQuaternionFromRotator", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathQuaternionFromRotator
{
	private static bool FRigUnit_MathQuaternionFromRotator_IsValid;

	private static int FRigUnit_MathQuaternionFromRotator_StructSize;

	public FRigUnit_MathQuaternionFromRotator Copy()
	{
		return this;
	}

	public static FRigUnit_MathQuaternionFromRotator FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathQuaternionFromRotator(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathQuaternionFromRotator value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathQuaternionFromRotator FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathQuaternionFromRotator(nativeBuffer + arrayIndex * FRigUnit_MathQuaternionFromRotator_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathQuaternionFromRotator value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathQuaternionFromRotator_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathQuaternionFromRotator_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathQuaternionFromRotator");
		}
	}

	public FRigUnit_MathQuaternionFromRotator(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathQuaternionFromRotator_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathQuaternionFromRotator");
		}
	}

	static FRigUnit_MathQuaternionFromRotator()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathQuaternionFromRotator)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathQuaternionFromRotator));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathQuaternionFromRotator");
		FRigUnit_MathQuaternionFromRotator_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathQuaternionFromRotator_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathQuaternionFromRotator", FRigUnit_MathQuaternionFromRotator_IsValid);
	}
}
