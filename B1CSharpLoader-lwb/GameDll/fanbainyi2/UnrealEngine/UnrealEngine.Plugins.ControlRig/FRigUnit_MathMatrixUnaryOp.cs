using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathMatrixUnaryOp", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathMatrixUnaryOp
{
	private static bool FRigUnit_MathMatrixUnaryOp_IsValid;

	private static int FRigUnit_MathMatrixUnaryOp_StructSize;

	public FRigUnit_MathMatrixUnaryOp Copy()
	{
		return this;
	}

	public static FRigUnit_MathMatrixUnaryOp FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathMatrixUnaryOp(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathMatrixUnaryOp value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathMatrixUnaryOp FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathMatrixUnaryOp(nativeBuffer + arrayIndex * FRigUnit_MathMatrixUnaryOp_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathMatrixUnaryOp value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathMatrixUnaryOp_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathMatrixUnaryOp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathMatrixUnaryOp");
		}
	}

	public FRigUnit_MathMatrixUnaryOp(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathMatrixUnaryOp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathMatrixUnaryOp");
		}
	}

	static FRigUnit_MathMatrixUnaryOp()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathMatrixUnaryOp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathMatrixUnaryOp));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathMatrixUnaryOp");
		FRigUnit_MathMatrixUnaryOp_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathMatrixUnaryOp_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathMatrixUnaryOp", FRigUnit_MathMatrixUnaryOp_IsValid);
	}
}
