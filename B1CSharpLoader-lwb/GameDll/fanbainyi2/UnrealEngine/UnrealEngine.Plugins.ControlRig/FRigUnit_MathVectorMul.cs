using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathVectorMul", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathVectorMul
{
	private static bool FRigUnit_MathVectorMul_IsValid;

	private static int FRigUnit_MathVectorMul_StructSize;

	public FRigUnit_MathVectorMul Copy()
	{
		return this;
	}

	public static FRigUnit_MathVectorMul FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathVectorMul(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathVectorMul value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathVectorMul FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathVectorMul(nativeBuffer + arrayIndex * FRigUnit_MathVectorMul_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathVectorMul value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathVectorMul_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorMul_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorMul");
		}
	}

	public FRigUnit_MathVectorMul(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorMul_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorMul");
		}
	}

	static FRigUnit_MathVectorMul()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathVectorMul)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathVectorMul));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathVectorMul");
		FRigUnit_MathVectorMul_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathVectorMul_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathVectorMul", FRigUnit_MathVectorMul_IsValid);
	}
}
