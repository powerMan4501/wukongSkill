using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathFloatUnaryOp", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathFloatUnaryOp
{
	private static bool FRigUnit_MathFloatUnaryOp_IsValid;

	private static int FRigUnit_MathFloatUnaryOp_StructSize;

	public FRigUnit_MathFloatUnaryOp Copy()
	{
		return this;
	}

	public static FRigUnit_MathFloatUnaryOp FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathFloatUnaryOp(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathFloatUnaryOp value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathFloatUnaryOp FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathFloatUnaryOp(nativeBuffer + arrayIndex * FRigUnit_MathFloatUnaryOp_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathFloatUnaryOp value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathFloatUnaryOp_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatUnaryOp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatUnaryOp");
		}
	}

	public FRigUnit_MathFloatUnaryOp(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatUnaryOp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatUnaryOp");
		}
	}

	static FRigUnit_MathFloatUnaryOp()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathFloatUnaryOp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathFloatUnaryOp));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathFloatUnaryOp");
		FRigUnit_MathFloatUnaryOp_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathFloatUnaryOp_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathFloatUnaryOp", FRigUnit_MathFloatUnaryOp_IsValid);
	}
}
