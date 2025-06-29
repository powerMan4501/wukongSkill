using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathVectorBinaryOp", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathVectorBinaryOp
{
	private static bool FRigUnit_MathVectorBinaryOp_IsValid;

	private static int FRigUnit_MathVectorBinaryOp_StructSize;

	public FRigUnit_MathVectorBinaryOp Copy()
	{
		return this;
	}

	public static FRigUnit_MathVectorBinaryOp FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathVectorBinaryOp(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathVectorBinaryOp value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathVectorBinaryOp FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathVectorBinaryOp(nativeBuffer + arrayIndex * FRigUnit_MathVectorBinaryOp_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathVectorBinaryOp value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathVectorBinaryOp_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorBinaryOp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorBinaryOp");
		}
	}

	public FRigUnit_MathVectorBinaryOp(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorBinaryOp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorBinaryOp");
		}
	}

	static FRigUnit_MathVectorBinaryOp()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathVectorBinaryOp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathVectorBinaryOp));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathVectorBinaryOp");
		FRigUnit_MathVectorBinaryOp_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathVectorBinaryOp_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathVectorBinaryOp", FRigUnit_MathVectorBinaryOp_IsValid);
	}
}
