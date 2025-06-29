using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathQuaternionNotEquals", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathQuaternionNotEquals
{
	private static bool FRigUnit_MathQuaternionNotEquals_IsValid;

	private static int FRigUnit_MathQuaternionNotEquals_StructSize;

	public FRigUnit_MathQuaternionNotEquals Copy()
	{
		return this;
	}

	public static FRigUnit_MathQuaternionNotEquals FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathQuaternionNotEquals(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathQuaternionNotEquals value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathQuaternionNotEquals FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathQuaternionNotEquals(nativeBuffer + arrayIndex * FRigUnit_MathQuaternionNotEquals_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathQuaternionNotEquals value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathQuaternionNotEquals_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathQuaternionNotEquals_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathQuaternionNotEquals");
		}
	}

	public FRigUnit_MathQuaternionNotEquals(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathQuaternionNotEquals_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathQuaternionNotEquals");
		}
	}

	static FRigUnit_MathQuaternionNotEquals()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathQuaternionNotEquals)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathQuaternionNotEquals));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathQuaternionNotEquals");
		FRigUnit_MathQuaternionNotEquals_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathQuaternionNotEquals_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathQuaternionNotEquals", FRigUnit_MathQuaternionNotEquals_IsValid);
	}
}
