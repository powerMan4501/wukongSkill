using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathQuaternionBinaryOp", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathQuaternionBinaryOp
{
	private static bool FRigUnit_MathQuaternionBinaryOp_IsValid;

	private static int FRigUnit_MathQuaternionBinaryOp_StructSize;

	public FRigUnit_MathQuaternionBinaryOp Copy()
	{
		return this;
	}

	public static FRigUnit_MathQuaternionBinaryOp FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathQuaternionBinaryOp(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathQuaternionBinaryOp value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathQuaternionBinaryOp FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathQuaternionBinaryOp(nativeBuffer + arrayIndex * FRigUnit_MathQuaternionBinaryOp_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathQuaternionBinaryOp value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathQuaternionBinaryOp_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathQuaternionBinaryOp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathQuaternionBinaryOp");
		}
	}

	public FRigUnit_MathQuaternionBinaryOp(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathQuaternionBinaryOp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathQuaternionBinaryOp");
		}
	}

	static FRigUnit_MathQuaternionBinaryOp()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathQuaternionBinaryOp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathQuaternionBinaryOp));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathQuaternionBinaryOp");
		FRigUnit_MathQuaternionBinaryOp_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathQuaternionBinaryOp_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathQuaternionBinaryOp", FRigUnit_MathQuaternionBinaryOp_IsValid);
	}
}
