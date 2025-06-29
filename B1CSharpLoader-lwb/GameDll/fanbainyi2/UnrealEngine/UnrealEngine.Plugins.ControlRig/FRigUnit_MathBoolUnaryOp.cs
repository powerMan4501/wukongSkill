using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathBoolUnaryOp", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathBoolUnaryOp
{
	private static bool FRigUnit_MathBoolUnaryOp_IsValid;

	private static int FRigUnit_MathBoolUnaryOp_StructSize;

	public FRigUnit_MathBoolUnaryOp Copy()
	{
		return this;
	}

	public static FRigUnit_MathBoolUnaryOp FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathBoolUnaryOp(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathBoolUnaryOp value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathBoolUnaryOp FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathBoolUnaryOp(nativeBuffer + arrayIndex * FRigUnit_MathBoolUnaryOp_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathBoolUnaryOp value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathBoolUnaryOp_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathBoolUnaryOp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathBoolUnaryOp");
		}
	}

	public FRigUnit_MathBoolUnaryOp(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathBoolUnaryOp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathBoolUnaryOp");
		}
	}

	static FRigUnit_MathBoolUnaryOp()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathBoolUnaryOp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathBoolUnaryOp));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathBoolUnaryOp");
		FRigUnit_MathBoolUnaryOp_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathBoolUnaryOp_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathBoolUnaryOp", FRigUnit_MathBoolUnaryOp_IsValid);
	}
}
