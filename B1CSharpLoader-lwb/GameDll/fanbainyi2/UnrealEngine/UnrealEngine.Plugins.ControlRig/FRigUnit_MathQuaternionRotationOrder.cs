using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathQuaternionRotationOrder", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathQuaternionRotationOrder
{
	private static bool FRigUnit_MathQuaternionRotationOrder_IsValid;

	private static int FRigUnit_MathQuaternionRotationOrder_StructSize;

	public FRigUnit_MathQuaternionRotationOrder Copy()
	{
		return this;
	}

	public static FRigUnit_MathQuaternionRotationOrder FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathQuaternionRotationOrder(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathQuaternionRotationOrder value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathQuaternionRotationOrder FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathQuaternionRotationOrder(nativeBuffer + arrayIndex * FRigUnit_MathQuaternionRotationOrder_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathQuaternionRotationOrder value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathQuaternionRotationOrder_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathQuaternionRotationOrder_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathQuaternionRotationOrder");
		}
	}

	public FRigUnit_MathQuaternionRotationOrder(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathQuaternionRotationOrder_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathQuaternionRotationOrder");
		}
	}

	static FRigUnit_MathQuaternionRotationOrder()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathQuaternionRotationOrder)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathQuaternionRotationOrder));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathQuaternionRotationOrder");
		FRigUnit_MathQuaternionRotationOrder_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathQuaternionRotationOrder_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathQuaternionRotationOrder", FRigUnit_MathQuaternionRotationOrder_IsValid);
	}
}
