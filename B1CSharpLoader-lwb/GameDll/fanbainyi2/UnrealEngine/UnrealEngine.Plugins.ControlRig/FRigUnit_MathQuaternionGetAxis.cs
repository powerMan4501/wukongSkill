using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathQuaternionGetAxis", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathQuaternionGetAxis
{
	private static bool FRigUnit_MathQuaternionGetAxis_IsValid;

	private static int FRigUnit_MathQuaternionGetAxis_StructSize;

	public FRigUnit_MathQuaternionGetAxis Copy()
	{
		return this;
	}

	public static FRigUnit_MathQuaternionGetAxis FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathQuaternionGetAxis(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathQuaternionGetAxis value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathQuaternionGetAxis FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathQuaternionGetAxis(nativeBuffer + arrayIndex * FRigUnit_MathQuaternionGetAxis_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathQuaternionGetAxis value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathQuaternionGetAxis_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathQuaternionGetAxis_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathQuaternionGetAxis");
		}
	}

	public FRigUnit_MathQuaternionGetAxis(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathQuaternionGetAxis_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathQuaternionGetAxis");
		}
	}

	static FRigUnit_MathQuaternionGetAxis()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathQuaternionGetAxis)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathQuaternionGetAxis));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathQuaternionGetAxis");
		FRigUnit_MathQuaternionGetAxis_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathQuaternionGetAxis_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathQuaternionGetAxis", FRigUnit_MathQuaternionGetAxis_IsValid);
	}
}
