using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathTransformMul", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathTransformMul
{
	private static bool FRigUnit_MathTransformMul_IsValid;

	private static int FRigUnit_MathTransformMul_StructSize;

	public FRigUnit_MathTransformMul Copy()
	{
		return this;
	}

	public static FRigUnit_MathTransformMul FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathTransformMul(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathTransformMul value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathTransformMul FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathTransformMul(nativeBuffer + arrayIndex * FRigUnit_MathTransformMul_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathTransformMul value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathTransformMul_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathTransformMul_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathTransformMul");
		}
	}

	public FRigUnit_MathTransformMul(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathTransformMul_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathTransformMul");
		}
	}

	static FRigUnit_MathTransformMul()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathTransformMul)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathTransformMul));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathTransformMul");
		FRigUnit_MathTransformMul_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathTransformMul_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathTransformMul", FRigUnit_MathTransformMul_IsValid);
	}
}
