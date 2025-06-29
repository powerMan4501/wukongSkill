using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_AccumulateVectorMul", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_AccumulateVectorMul
{
	private static bool FRigUnit_AccumulateVectorMul_IsValid;

	private static int FRigUnit_AccumulateVectorMul_StructSize;

	public FRigUnit_AccumulateVectorMul Copy()
	{
		return this;
	}

	public static FRigUnit_AccumulateVectorMul FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_AccumulateVectorMul(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_AccumulateVectorMul value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_AccumulateVectorMul FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_AccumulateVectorMul(nativeBuffer + arrayIndex * FRigUnit_AccumulateVectorMul_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_AccumulateVectorMul value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_AccumulateVectorMul_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_AccumulateVectorMul_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_AccumulateVectorMul");
		}
	}

	public FRigUnit_AccumulateVectorMul(IntPtr nativeStruct)
	{
		if (!FRigUnit_AccumulateVectorMul_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_AccumulateVectorMul");
		}
	}

	static FRigUnit_AccumulateVectorMul()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_AccumulateVectorMul)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_AccumulateVectorMul));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_AccumulateVectorMul");
		FRigUnit_AccumulateVectorMul_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_AccumulateVectorMul_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_AccumulateVectorMul", FRigUnit_AccumulateVectorMul_IsValid);
	}
}
