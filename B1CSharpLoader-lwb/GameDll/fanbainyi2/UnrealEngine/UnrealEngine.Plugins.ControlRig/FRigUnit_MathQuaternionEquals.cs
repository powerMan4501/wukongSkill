using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathQuaternionEquals", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathQuaternionEquals
{
	private static bool FRigUnit_MathQuaternionEquals_IsValid;

	private static int FRigUnit_MathQuaternionEquals_StructSize;

	public FRigUnit_MathQuaternionEquals Copy()
	{
		return this;
	}

	public static FRigUnit_MathQuaternionEquals FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathQuaternionEquals(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathQuaternionEquals value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathQuaternionEquals FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathQuaternionEquals(nativeBuffer + arrayIndex * FRigUnit_MathQuaternionEquals_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathQuaternionEquals value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathQuaternionEquals_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathQuaternionEquals_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathQuaternionEquals");
		}
	}

	public FRigUnit_MathQuaternionEquals(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathQuaternionEquals_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathQuaternionEquals");
		}
	}

	static FRigUnit_MathQuaternionEquals()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathQuaternionEquals)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathQuaternionEquals));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathQuaternionEquals");
		FRigUnit_MathQuaternionEquals_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathQuaternionEquals_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathQuaternionEquals", FRigUnit_MathQuaternionEquals_IsValid);
	}
}
