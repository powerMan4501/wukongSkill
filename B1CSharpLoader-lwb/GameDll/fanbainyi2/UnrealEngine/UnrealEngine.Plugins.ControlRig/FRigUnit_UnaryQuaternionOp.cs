using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_UnaryQuaternionOp", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_UnaryQuaternionOp
{
	private static bool FRigUnit_UnaryQuaternionOp_IsValid;

	private static int FRigUnit_UnaryQuaternionOp_StructSize;

	public FRigUnit_UnaryQuaternionOp Copy()
	{
		return this;
	}

	public static FRigUnit_UnaryQuaternionOp FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_UnaryQuaternionOp(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_UnaryQuaternionOp value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_UnaryQuaternionOp FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_UnaryQuaternionOp(nativeBuffer + arrayIndex * FRigUnit_UnaryQuaternionOp_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_UnaryQuaternionOp value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_UnaryQuaternionOp_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_UnaryQuaternionOp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_UnaryQuaternionOp");
		}
	}

	public FRigUnit_UnaryQuaternionOp(IntPtr nativeStruct)
	{
		if (!FRigUnit_UnaryQuaternionOp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_UnaryQuaternionOp");
		}
	}

	static FRigUnit_UnaryQuaternionOp()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_UnaryQuaternionOp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_UnaryQuaternionOp));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_UnaryQuaternionOp");
		FRigUnit_UnaryQuaternionOp_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_UnaryQuaternionOp_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_UnaryQuaternionOp", FRigUnit_UnaryQuaternionOp_IsValid);
	}
}
