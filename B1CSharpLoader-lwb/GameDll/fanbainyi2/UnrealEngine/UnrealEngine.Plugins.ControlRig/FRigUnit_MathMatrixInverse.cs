using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathMatrixInverse", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathMatrixInverse
{
	private static bool FRigUnit_MathMatrixInverse_IsValid;

	private static int FRigUnit_MathMatrixInverse_StructSize;

	public FRigUnit_MathMatrixInverse Copy()
	{
		return this;
	}

	public static FRigUnit_MathMatrixInverse FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathMatrixInverse(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathMatrixInverse value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathMatrixInverse FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathMatrixInverse(nativeBuffer + arrayIndex * FRigUnit_MathMatrixInverse_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathMatrixInverse value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathMatrixInverse_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathMatrixInverse_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathMatrixInverse");
		}
	}

	public FRigUnit_MathMatrixInverse(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathMatrixInverse_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathMatrixInverse");
		}
	}

	static FRigUnit_MathMatrixInverse()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathMatrixInverse)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathMatrixInverse));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathMatrixInverse");
		FRigUnit_MathMatrixInverse_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathMatrixInverse_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathMatrixInverse", FRigUnit_MathMatrixInverse_IsValid);
	}
}
