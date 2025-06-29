using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_BinaryQuaternionOp", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_BinaryQuaternionOp
{
	private static bool FRigUnit_BinaryQuaternionOp_IsValid;

	private static int FRigUnit_BinaryQuaternionOp_StructSize;

	public FRigUnit_BinaryQuaternionOp Copy()
	{
		return this;
	}

	public static FRigUnit_BinaryQuaternionOp FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_BinaryQuaternionOp(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_BinaryQuaternionOp value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_BinaryQuaternionOp FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_BinaryQuaternionOp(nativeBuffer + arrayIndex * FRigUnit_BinaryQuaternionOp_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_BinaryQuaternionOp value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_BinaryQuaternionOp_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_BinaryQuaternionOp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_BinaryQuaternionOp");
		}
	}

	public FRigUnit_BinaryQuaternionOp(IntPtr nativeStruct)
	{
		if (!FRigUnit_BinaryQuaternionOp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_BinaryQuaternionOp");
		}
	}

	static FRigUnit_BinaryQuaternionOp()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_BinaryQuaternionOp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_BinaryQuaternionOp));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_BinaryQuaternionOp");
		FRigUnit_BinaryQuaternionOp_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_BinaryQuaternionOp_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_BinaryQuaternionOp", FRigUnit_BinaryQuaternionOp_IsValid);
	}
}
