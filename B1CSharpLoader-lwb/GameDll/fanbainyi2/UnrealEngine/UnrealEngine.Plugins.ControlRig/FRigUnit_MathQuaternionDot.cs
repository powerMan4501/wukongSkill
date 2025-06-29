using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathQuaternionDot", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathQuaternionDot
{
	private static bool FRigUnit_MathQuaternionDot_IsValid;

	private static int FRigUnit_MathQuaternionDot_StructSize;

	public FRigUnit_MathQuaternionDot Copy()
	{
		return this;
	}

	public static FRigUnit_MathQuaternionDot FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathQuaternionDot(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathQuaternionDot value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathQuaternionDot FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathQuaternionDot(nativeBuffer + arrayIndex * FRigUnit_MathQuaternionDot_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathQuaternionDot value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathQuaternionDot_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathQuaternionDot_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathQuaternionDot");
		}
	}

	public FRigUnit_MathQuaternionDot(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathQuaternionDot_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathQuaternionDot");
		}
	}

	static FRigUnit_MathQuaternionDot()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathQuaternionDot)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathQuaternionDot));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathQuaternionDot");
		FRigUnit_MathQuaternionDot_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathQuaternionDot_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathQuaternionDot", FRigUnit_MathQuaternionDot_IsValid);
	}
}
