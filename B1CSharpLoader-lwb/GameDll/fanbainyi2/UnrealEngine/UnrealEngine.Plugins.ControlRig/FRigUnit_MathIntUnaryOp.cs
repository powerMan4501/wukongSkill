using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathIntUnaryOp", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathIntUnaryOp
{
	private static bool FRigUnit_MathIntUnaryOp_IsValid;

	private static int FRigUnit_MathIntUnaryOp_StructSize;

	public FRigUnit_MathIntUnaryOp Copy()
	{
		return this;
	}

	public static FRigUnit_MathIntUnaryOp FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathIntUnaryOp(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathIntUnaryOp value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathIntUnaryOp FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathIntUnaryOp(nativeBuffer + arrayIndex * FRigUnit_MathIntUnaryOp_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathIntUnaryOp value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathIntUnaryOp_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathIntUnaryOp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathIntUnaryOp");
		}
	}

	public FRigUnit_MathIntUnaryOp(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathIntUnaryOp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathIntUnaryOp");
		}
	}

	static FRigUnit_MathIntUnaryOp()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathIntUnaryOp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathIntUnaryOp));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathIntUnaryOp");
		FRigUnit_MathIntUnaryOp_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathIntUnaryOp_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathIntUnaryOp", FRigUnit_MathIntUnaryOp_IsValid);
	}
}
