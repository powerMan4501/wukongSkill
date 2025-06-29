using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathMatrixBase", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathMatrixBase
{
	private static bool FRigUnit_MathMatrixBase_IsValid;

	private static int FRigUnit_MathMatrixBase_StructSize;

	public FRigUnit_MathMatrixBase Copy()
	{
		return this;
	}

	public static FRigUnit_MathMatrixBase FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathMatrixBase(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathMatrixBase value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathMatrixBase FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathMatrixBase(nativeBuffer + arrayIndex * FRigUnit_MathMatrixBase_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathMatrixBase value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathMatrixBase_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathMatrixBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathMatrixBase");
		}
	}

	public FRigUnit_MathMatrixBase(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathMatrixBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathMatrixBase");
		}
	}

	static FRigUnit_MathMatrixBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathMatrixBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathMatrixBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathMatrixBase");
		FRigUnit_MathMatrixBase_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathMatrixBase_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathMatrixBase", FRigUnit_MathMatrixBase_IsValid);
	}
}
