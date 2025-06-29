using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_BinaryFloatOp", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_BinaryFloatOp
{
	private static bool FRigUnit_BinaryFloatOp_IsValid;

	private static int FRigUnit_BinaryFloatOp_StructSize;

	public FRigUnit_BinaryFloatOp Copy()
	{
		return this;
	}

	public static FRigUnit_BinaryFloatOp FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_BinaryFloatOp(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_BinaryFloatOp value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_BinaryFloatOp FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_BinaryFloatOp(nativeBuffer + arrayIndex * FRigUnit_BinaryFloatOp_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_BinaryFloatOp value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_BinaryFloatOp_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_BinaryFloatOp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_BinaryFloatOp");
		}
	}

	public FRigUnit_BinaryFloatOp(IntPtr nativeStruct)
	{
		if (!FRigUnit_BinaryFloatOp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_BinaryFloatOp");
		}
	}

	static FRigUnit_BinaryFloatOp()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_BinaryFloatOp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_BinaryFloatOp));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_BinaryFloatOp");
		FRigUnit_BinaryFloatOp_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_BinaryFloatOp_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_BinaryFloatOp", FRigUnit_BinaryFloatOp_IsValid);
	}
}
