using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathTransformBinaryOp", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathTransformBinaryOp
{
	private static bool FRigUnit_MathTransformBinaryOp_IsValid;

	private static int FRigUnit_MathTransformBinaryOp_StructSize;

	public FRigUnit_MathTransformBinaryOp Copy()
	{
		return this;
	}

	public static FRigUnit_MathTransformBinaryOp FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathTransformBinaryOp(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathTransformBinaryOp value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathTransformBinaryOp FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathTransformBinaryOp(nativeBuffer + arrayIndex * FRigUnit_MathTransformBinaryOp_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathTransformBinaryOp value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathTransformBinaryOp_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathTransformBinaryOp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathTransformBinaryOp");
		}
	}

	public FRigUnit_MathTransformBinaryOp(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathTransformBinaryOp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathTransformBinaryOp");
		}
	}

	static FRigUnit_MathTransformBinaryOp()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathTransformBinaryOp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathTransformBinaryOp));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathTransformBinaryOp");
		FRigUnit_MathTransformBinaryOp_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathTransformBinaryOp_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathTransformBinaryOp", FRigUnit_MathTransformBinaryOp_IsValid);
	}
}
