using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathTransformBase", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathTransformBase
{
	private static bool FRigUnit_MathTransformBase_IsValid;

	private static int FRigUnit_MathTransformBase_StructSize;

	public FRigUnit_MathTransformBase Copy()
	{
		return this;
	}

	public static FRigUnit_MathTransformBase FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathTransformBase(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathTransformBase value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathTransformBase FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathTransformBase(nativeBuffer + arrayIndex * FRigUnit_MathTransformBase_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathTransformBase value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathTransformBase_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathTransformBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathTransformBase");
		}
	}

	public FRigUnit_MathTransformBase(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathTransformBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathTransformBase");
		}
	}

	static FRigUnit_MathTransformBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathTransformBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathTransformBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathTransformBase");
		FRigUnit_MathTransformBase_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathTransformBase_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathTransformBase", FRigUnit_MathTransformBase_IsValid);
	}
}
