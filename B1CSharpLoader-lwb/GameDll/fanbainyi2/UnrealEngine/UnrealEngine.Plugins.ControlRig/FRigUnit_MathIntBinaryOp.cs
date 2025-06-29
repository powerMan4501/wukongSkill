using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathIntBinaryOp", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathIntBinaryOp
{
	private static bool FRigUnit_MathIntBinaryOp_IsValid;

	private static int FRigUnit_MathIntBinaryOp_StructSize;

	public FRigUnit_MathIntBinaryOp Copy()
	{
		return this;
	}

	public static FRigUnit_MathIntBinaryOp FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathIntBinaryOp(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathIntBinaryOp value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathIntBinaryOp FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathIntBinaryOp(nativeBuffer + arrayIndex * FRigUnit_MathIntBinaryOp_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathIntBinaryOp value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathIntBinaryOp_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathIntBinaryOp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathIntBinaryOp");
		}
	}

	public FRigUnit_MathIntBinaryOp(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathIntBinaryOp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathIntBinaryOp");
		}
	}

	static FRigUnit_MathIntBinaryOp()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathIntBinaryOp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathIntBinaryOp));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathIntBinaryOp");
		FRigUnit_MathIntBinaryOp_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathIntBinaryOp_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathIntBinaryOp", FRigUnit_MathIntBinaryOp_IsValid);
	}
}
