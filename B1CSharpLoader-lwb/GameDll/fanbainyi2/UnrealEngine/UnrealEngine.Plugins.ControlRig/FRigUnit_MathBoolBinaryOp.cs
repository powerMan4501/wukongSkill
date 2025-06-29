using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathBoolBinaryOp", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathBoolBinaryOp
{
	private static bool FRigUnit_MathBoolBinaryOp_IsValid;

	private static int FRigUnit_MathBoolBinaryOp_StructSize;

	public FRigUnit_MathBoolBinaryOp Copy()
	{
		return this;
	}

	public static FRigUnit_MathBoolBinaryOp FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathBoolBinaryOp(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathBoolBinaryOp value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathBoolBinaryOp FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathBoolBinaryOp(nativeBuffer + arrayIndex * FRigUnit_MathBoolBinaryOp_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathBoolBinaryOp value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathBoolBinaryOp_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathBoolBinaryOp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathBoolBinaryOp");
		}
	}

	public FRigUnit_MathBoolBinaryOp(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathBoolBinaryOp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathBoolBinaryOp");
		}
	}

	static FRigUnit_MathBoolBinaryOp()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathBoolBinaryOp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathBoolBinaryOp));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathBoolBinaryOp");
		FRigUnit_MathBoolBinaryOp_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathBoolBinaryOp_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathBoolBinaryOp", FRigUnit_MathBoolBinaryOp_IsValid);
	}
}
