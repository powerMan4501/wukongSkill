using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathTransformUnaryOp", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathTransformUnaryOp
{
	private static bool FRigUnit_MathTransformUnaryOp_IsValid;

	private static int FRigUnit_MathTransformUnaryOp_StructSize;

	public FRigUnit_MathTransformUnaryOp Copy()
	{
		return this;
	}

	public static FRigUnit_MathTransformUnaryOp FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathTransformUnaryOp(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathTransformUnaryOp value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathTransformUnaryOp FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathTransformUnaryOp(nativeBuffer + arrayIndex * FRigUnit_MathTransformUnaryOp_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathTransformUnaryOp value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathTransformUnaryOp_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathTransformUnaryOp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathTransformUnaryOp");
		}
	}

	public FRigUnit_MathTransformUnaryOp(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathTransformUnaryOp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathTransformUnaryOp");
		}
	}

	static FRigUnit_MathTransformUnaryOp()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathTransformUnaryOp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathTransformUnaryOp));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathTransformUnaryOp");
		FRigUnit_MathTransformUnaryOp_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathTransformUnaryOp_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathTransformUnaryOp", FRigUnit_MathTransformUnaryOp_IsValid);
	}
}
