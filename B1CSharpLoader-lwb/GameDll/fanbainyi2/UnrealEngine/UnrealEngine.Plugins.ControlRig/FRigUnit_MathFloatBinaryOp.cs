using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathFloatBinaryOp", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathFloatBinaryOp
{
	private static bool FRigUnit_MathFloatBinaryOp_IsValid;

	private static int FRigUnit_MathFloatBinaryOp_StructSize;

	public FRigUnit_MathFloatBinaryOp Copy()
	{
		return this;
	}

	public static FRigUnit_MathFloatBinaryOp FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathFloatBinaryOp(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathFloatBinaryOp value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathFloatBinaryOp FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathFloatBinaryOp(nativeBuffer + arrayIndex * FRigUnit_MathFloatBinaryOp_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathFloatBinaryOp value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathFloatBinaryOp_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatBinaryOp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatBinaryOp");
		}
	}

	public FRigUnit_MathFloatBinaryOp(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatBinaryOp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatBinaryOp");
		}
	}

	static FRigUnit_MathFloatBinaryOp()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathFloatBinaryOp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathFloatBinaryOp));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathFloatBinaryOp");
		FRigUnit_MathFloatBinaryOp_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathFloatBinaryOp_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathFloatBinaryOp", FRigUnit_MathFloatBinaryOp_IsValid);
	}
}
