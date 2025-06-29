using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathQuaternionMul", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathQuaternionMul
{
	private static bool FRigUnit_MathQuaternionMul_IsValid;

	private static int FRigUnit_MathQuaternionMul_StructSize;

	public FRigUnit_MathQuaternionMul Copy()
	{
		return this;
	}

	public static FRigUnit_MathQuaternionMul FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathQuaternionMul(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathQuaternionMul value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathQuaternionMul FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathQuaternionMul(nativeBuffer + arrayIndex * FRigUnit_MathQuaternionMul_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathQuaternionMul value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathQuaternionMul_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathQuaternionMul_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathQuaternionMul");
		}
	}

	public FRigUnit_MathQuaternionMul(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathQuaternionMul_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathQuaternionMul");
		}
	}

	static FRigUnit_MathQuaternionMul()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathQuaternionMul)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathQuaternionMul));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathQuaternionMul");
		FRigUnit_MathQuaternionMul_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathQuaternionMul_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathQuaternionMul", FRigUnit_MathQuaternionMul_IsValid);
	}
}
