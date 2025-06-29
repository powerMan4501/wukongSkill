using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_BinaryTransformOp", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_BinaryTransformOp
{
	private static bool FRigUnit_BinaryTransformOp_IsValid;

	private static int FRigUnit_BinaryTransformOp_StructSize;

	public FRigUnit_BinaryTransformOp Copy()
	{
		return this;
	}

	public static FRigUnit_BinaryTransformOp FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_BinaryTransformOp(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_BinaryTransformOp value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_BinaryTransformOp FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_BinaryTransformOp(nativeBuffer + arrayIndex * FRigUnit_BinaryTransformOp_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_BinaryTransformOp value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_BinaryTransformOp_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_BinaryTransformOp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_BinaryTransformOp");
		}
	}

	public FRigUnit_BinaryTransformOp(IntPtr nativeStruct)
	{
		if (!FRigUnit_BinaryTransformOp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_BinaryTransformOp");
		}
	}

	static FRigUnit_BinaryTransformOp()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_BinaryTransformOp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_BinaryTransformOp));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_BinaryTransformOp");
		FRigUnit_BinaryTransformOp_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_BinaryTransformOp_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_BinaryTransformOp", FRigUnit_BinaryTransformOp_IsValid);
	}
}
