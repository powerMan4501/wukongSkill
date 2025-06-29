using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathColorBinaryOp", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathColorBinaryOp
{
	private static bool FRigUnit_MathColorBinaryOp_IsValid;

	private static int FRigUnit_MathColorBinaryOp_StructSize;

	public FRigUnit_MathColorBinaryOp Copy()
	{
		return this;
	}

	public static FRigUnit_MathColorBinaryOp FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathColorBinaryOp(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathColorBinaryOp value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathColorBinaryOp FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathColorBinaryOp(nativeBuffer + arrayIndex * FRigUnit_MathColorBinaryOp_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathColorBinaryOp value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathColorBinaryOp_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathColorBinaryOp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathColorBinaryOp");
		}
	}

	public FRigUnit_MathColorBinaryOp(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathColorBinaryOp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathColorBinaryOp");
		}
	}

	static FRigUnit_MathColorBinaryOp()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathColorBinaryOp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathColorBinaryOp));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathColorBinaryOp");
		FRigUnit_MathColorBinaryOp_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathColorBinaryOp_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathColorBinaryOp", FRigUnit_MathColorBinaryOp_IsValid);
	}
}
