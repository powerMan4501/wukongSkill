using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathFloatMul", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathFloatMul
{
	private static bool FRigUnit_MathFloatMul_IsValid;

	private static int FRigUnit_MathFloatMul_StructSize;

	public FRigUnit_MathFloatMul Copy()
	{
		return this;
	}

	public static FRigUnit_MathFloatMul FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathFloatMul(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathFloatMul value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathFloatMul FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathFloatMul(nativeBuffer + arrayIndex * FRigUnit_MathFloatMul_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathFloatMul value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathFloatMul_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatMul_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatMul");
		}
	}

	public FRigUnit_MathFloatMul(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatMul_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatMul");
		}
	}

	static FRigUnit_MathFloatMul()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathFloatMul)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathFloatMul));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathFloatMul");
		FRigUnit_MathFloatMul_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathFloatMul_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathFloatMul", FRigUnit_MathFloatMul_IsValid);
	}
}
