using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathMatrixMul", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathMatrixMul
{
	private static bool FRigUnit_MathMatrixMul_IsValid;

	private static int FRigUnit_MathMatrixMul_StructSize;

	public FRigUnit_MathMatrixMul Copy()
	{
		return this;
	}

	public static FRigUnit_MathMatrixMul FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathMatrixMul(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathMatrixMul value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathMatrixMul FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathMatrixMul(nativeBuffer + arrayIndex * FRigUnit_MathMatrixMul_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathMatrixMul value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathMatrixMul_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathMatrixMul_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathMatrixMul");
		}
	}

	public FRigUnit_MathMatrixMul(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathMatrixMul_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathMatrixMul");
		}
	}

	static FRigUnit_MathMatrixMul()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathMatrixMul)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathMatrixMul));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathMatrixMul");
		FRigUnit_MathMatrixMul_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathMatrixMul_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathMatrixMul", FRigUnit_MathMatrixMul_IsValid);
	}
}
