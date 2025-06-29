using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathQuaternionUnit", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathQuaternionUnit
{
	private static bool FRigUnit_MathQuaternionUnit_IsValid;

	private static int FRigUnit_MathQuaternionUnit_StructSize;

	public FRigUnit_MathQuaternionUnit Copy()
	{
		return this;
	}

	public static FRigUnit_MathQuaternionUnit FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathQuaternionUnit(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathQuaternionUnit value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathQuaternionUnit FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathQuaternionUnit(nativeBuffer + arrayIndex * FRigUnit_MathQuaternionUnit_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathQuaternionUnit value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathQuaternionUnit_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathQuaternionUnit_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathQuaternionUnit");
		}
	}

	public FRigUnit_MathQuaternionUnit(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathQuaternionUnit_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathQuaternionUnit");
		}
	}

	static FRigUnit_MathQuaternionUnit()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathQuaternionUnit)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathQuaternionUnit));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathQuaternionUnit");
		FRigUnit_MathQuaternionUnit_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathQuaternionUnit_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathQuaternionUnit", FRigUnit_MathQuaternionUnit_IsValid);
	}
}
