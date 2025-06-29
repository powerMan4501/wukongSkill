using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_BinaryVectorOp", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_BinaryVectorOp
{
	private static bool FRigUnit_BinaryVectorOp_IsValid;

	private static int FRigUnit_BinaryVectorOp_StructSize;

	public FRigUnit_BinaryVectorOp Copy()
	{
		return this;
	}

	public static FRigUnit_BinaryVectorOp FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_BinaryVectorOp(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_BinaryVectorOp value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_BinaryVectorOp FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_BinaryVectorOp(nativeBuffer + arrayIndex * FRigUnit_BinaryVectorOp_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_BinaryVectorOp value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_BinaryVectorOp_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_BinaryVectorOp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_BinaryVectorOp");
		}
	}

	public FRigUnit_BinaryVectorOp(IntPtr nativeStruct)
	{
		if (!FRigUnit_BinaryVectorOp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_BinaryVectorOp");
		}
	}

	static FRigUnit_BinaryVectorOp()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_BinaryVectorOp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_BinaryVectorOp));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_BinaryVectorOp");
		FRigUnit_BinaryVectorOp_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_BinaryVectorOp_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_BinaryVectorOp", FRigUnit_BinaryVectorOp_IsValid);
	}
}
