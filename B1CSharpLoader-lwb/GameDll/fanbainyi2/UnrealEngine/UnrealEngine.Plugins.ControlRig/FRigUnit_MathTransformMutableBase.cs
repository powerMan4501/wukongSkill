using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathTransformMutableBase", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathTransformMutableBase
{
	private static bool FRigUnit_MathTransformMutableBase_IsValid;

	private static int FRigUnit_MathTransformMutableBase_StructSize;

	public FRigUnit_MathTransformMutableBase Copy()
	{
		return this;
	}

	public static FRigUnit_MathTransformMutableBase FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathTransformMutableBase(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathTransformMutableBase value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathTransformMutableBase FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathTransformMutableBase(nativeBuffer + arrayIndex * FRigUnit_MathTransformMutableBase_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathTransformMutableBase value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathTransformMutableBase_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathTransformMutableBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathTransformMutableBase");
		}
	}

	public FRigUnit_MathTransformMutableBase(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathTransformMutableBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathTransformMutableBase");
		}
	}

	static FRigUnit_MathTransformMutableBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathTransformMutableBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathTransformMutableBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathTransformMutableBase");
		FRigUnit_MathTransformMutableBase_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathTransformMutableBase_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathTransformMutableBase", FRigUnit_MathTransformMutableBase_IsValid);
	}
}
