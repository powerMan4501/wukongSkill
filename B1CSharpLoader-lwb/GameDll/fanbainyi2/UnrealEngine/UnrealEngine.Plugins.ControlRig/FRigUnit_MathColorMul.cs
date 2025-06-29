using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathColorMul", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathColorMul
{
	private static bool FRigUnit_MathColorMul_IsValid;

	private static int FRigUnit_MathColorMul_StructSize;

	public FRigUnit_MathColorMul Copy()
	{
		return this;
	}

	public static FRigUnit_MathColorMul FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathColorMul(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathColorMul value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathColorMul FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathColorMul(nativeBuffer + arrayIndex * FRigUnit_MathColorMul_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathColorMul value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathColorMul_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathColorMul_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathColorMul");
		}
	}

	public FRigUnit_MathColorMul(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathColorMul_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathColorMul");
		}
	}

	static FRigUnit_MathColorMul()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathColorMul)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathColorMul));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathColorMul");
		FRigUnit_MathColorMul_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathColorMul_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathColorMul", FRigUnit_MathColorMul_IsValid);
	}
}
