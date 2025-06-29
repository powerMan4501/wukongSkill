using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_AccumulateTransformMul", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_AccumulateTransformMul
{
	private static bool FRigUnit_AccumulateTransformMul_IsValid;

	private static int FRigUnit_AccumulateTransformMul_StructSize;

	public FRigUnit_AccumulateTransformMul Copy()
	{
		return this;
	}

	public static FRigUnit_AccumulateTransformMul FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_AccumulateTransformMul(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_AccumulateTransformMul value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_AccumulateTransformMul FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_AccumulateTransformMul(nativeBuffer + arrayIndex * FRigUnit_AccumulateTransformMul_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_AccumulateTransformMul value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_AccumulateTransformMul_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_AccumulateTransformMul_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_AccumulateTransformMul");
		}
	}

	public FRigUnit_AccumulateTransformMul(IntPtr nativeStruct)
	{
		if (!FRigUnit_AccumulateTransformMul_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_AccumulateTransformMul");
		}
	}

	static FRigUnit_AccumulateTransformMul()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_AccumulateTransformMul)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_AccumulateTransformMul));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_AccumulateTransformMul");
		FRigUnit_AccumulateTransformMul_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_AccumulateTransformMul_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_AccumulateTransformMul", FRigUnit_AccumulateTransformMul_IsValid);
	}
}
