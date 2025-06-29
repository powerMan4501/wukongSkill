using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathQuaternionBase", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathQuaternionBase
{
	private static bool FRigUnit_MathQuaternionBase_IsValid;

	private static int FRigUnit_MathQuaternionBase_StructSize;

	public FRigUnit_MathQuaternionBase Copy()
	{
		return this;
	}

	public static FRigUnit_MathQuaternionBase FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathQuaternionBase(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathQuaternionBase value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathQuaternionBase FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathQuaternionBase(nativeBuffer + arrayIndex * FRigUnit_MathQuaternionBase_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathQuaternionBase value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathQuaternionBase_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathQuaternionBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathQuaternionBase");
		}
	}

	public FRigUnit_MathQuaternionBase(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathQuaternionBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathQuaternionBase");
		}
	}

	static FRigUnit_MathQuaternionBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathQuaternionBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathQuaternionBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathQuaternionBase");
		FRigUnit_MathQuaternionBase_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathQuaternionBase_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathQuaternionBase", FRigUnit_MathQuaternionBase_IsValid);
	}
}
