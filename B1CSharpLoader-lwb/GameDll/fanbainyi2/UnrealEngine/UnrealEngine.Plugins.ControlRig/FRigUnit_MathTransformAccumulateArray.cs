using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathTransformAccumulateArray", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathTransformAccumulateArray
{
	private static bool FRigUnit_MathTransformAccumulateArray_IsValid;

	private static int FRigUnit_MathTransformAccumulateArray_StructSize;

	public FRigUnit_MathTransformAccumulateArray Copy()
	{
		return this;
	}

	public static FRigUnit_MathTransformAccumulateArray FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathTransformAccumulateArray(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathTransformAccumulateArray value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathTransformAccumulateArray FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathTransformAccumulateArray(nativeBuffer + arrayIndex * FRigUnit_MathTransformAccumulateArray_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathTransformAccumulateArray value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathTransformAccumulateArray_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathTransformAccumulateArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathTransformAccumulateArray");
		}
	}

	public FRigUnit_MathTransformAccumulateArray(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathTransformAccumulateArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathTransformAccumulateArray");
		}
	}

	static FRigUnit_MathTransformAccumulateArray()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathTransformAccumulateArray)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathTransformAccumulateArray));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathTransformAccumulateArray");
		FRigUnit_MathTransformAccumulateArray_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathTransformAccumulateArray_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathTransformAccumulateArray", FRigUnit_MathTransformAccumulateArray_IsValid);
	}
}
