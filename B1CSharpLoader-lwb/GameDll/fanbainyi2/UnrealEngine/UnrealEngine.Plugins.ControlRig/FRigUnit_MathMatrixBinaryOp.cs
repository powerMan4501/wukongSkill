using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathMatrixBinaryOp", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathMatrixBinaryOp
{
	private static bool FRigUnit_MathMatrixBinaryOp_IsValid;

	private static int FRigUnit_MathMatrixBinaryOp_StructSize;

	public FRigUnit_MathMatrixBinaryOp Copy()
	{
		return this;
	}

	public static FRigUnit_MathMatrixBinaryOp FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathMatrixBinaryOp(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathMatrixBinaryOp value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathMatrixBinaryOp FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathMatrixBinaryOp(nativeBuffer + arrayIndex * FRigUnit_MathMatrixBinaryOp_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathMatrixBinaryOp value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathMatrixBinaryOp_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathMatrixBinaryOp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathMatrixBinaryOp");
		}
	}

	public FRigUnit_MathMatrixBinaryOp(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathMatrixBinaryOp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathMatrixBinaryOp");
		}
	}

	static FRigUnit_MathMatrixBinaryOp()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathMatrixBinaryOp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathMatrixBinaryOp));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathMatrixBinaryOp");
		FRigUnit_MathMatrixBinaryOp_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathMatrixBinaryOp_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathMatrixBinaryOp", FRigUnit_MathMatrixBinaryOp_IsValid);
	}
}
