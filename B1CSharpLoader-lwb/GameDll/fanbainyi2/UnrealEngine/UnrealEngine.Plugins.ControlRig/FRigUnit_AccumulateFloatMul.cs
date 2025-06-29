using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_AccumulateFloatMul", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_AccumulateFloatMul
{
	private static bool FRigUnit_AccumulateFloatMul_IsValid;

	private static int FRigUnit_AccumulateFloatMul_StructSize;

	public FRigUnit_AccumulateFloatMul Copy()
	{
		return this;
	}

	public static FRigUnit_AccumulateFloatMul FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_AccumulateFloatMul(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_AccumulateFloatMul value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_AccumulateFloatMul FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_AccumulateFloatMul(nativeBuffer + arrayIndex * FRigUnit_AccumulateFloatMul_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_AccumulateFloatMul value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_AccumulateFloatMul_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_AccumulateFloatMul_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_AccumulateFloatMul");
		}
	}

	public FRigUnit_AccumulateFloatMul(IntPtr nativeStruct)
	{
		if (!FRigUnit_AccumulateFloatMul_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_AccumulateFloatMul");
		}
	}

	static FRigUnit_AccumulateFloatMul()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_AccumulateFloatMul)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_AccumulateFloatMul));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_AccumulateFloatMul");
		FRigUnit_AccumulateFloatMul_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_AccumulateFloatMul_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_AccumulateFloatMul", FRigUnit_AccumulateFloatMul_IsValid);
	}
}
