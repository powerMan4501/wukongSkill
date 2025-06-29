using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathQuaternionUnaryOp", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathQuaternionUnaryOp
{
	private static bool FRigUnit_MathQuaternionUnaryOp_IsValid;

	private static int FRigUnit_MathQuaternionUnaryOp_StructSize;

	public FRigUnit_MathQuaternionUnaryOp Copy()
	{
		return this;
	}

	public static FRigUnit_MathQuaternionUnaryOp FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathQuaternionUnaryOp(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathQuaternionUnaryOp value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathQuaternionUnaryOp FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathQuaternionUnaryOp(nativeBuffer + arrayIndex * FRigUnit_MathQuaternionUnaryOp_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathQuaternionUnaryOp value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathQuaternionUnaryOp_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathQuaternionUnaryOp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathQuaternionUnaryOp");
		}
	}

	public FRigUnit_MathQuaternionUnaryOp(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathQuaternionUnaryOp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathQuaternionUnaryOp");
		}
	}

	static FRigUnit_MathQuaternionUnaryOp()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathQuaternionUnaryOp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathQuaternionUnaryOp));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathQuaternionUnaryOp");
		FRigUnit_MathQuaternionUnaryOp_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathQuaternionUnaryOp_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathQuaternionUnaryOp", FRigUnit_MathQuaternionUnaryOp_IsValid);
	}
}
