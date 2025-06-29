using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathFloatSqrt", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathFloatSqrt
{
	private static bool FRigUnit_MathFloatSqrt_IsValid;

	private static int FRigUnit_MathFloatSqrt_StructSize;

	public FRigUnit_MathFloatSqrt Copy()
	{
		return this;
	}

	public static FRigUnit_MathFloatSqrt FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathFloatSqrt(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathFloatSqrt value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathFloatSqrt FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathFloatSqrt(nativeBuffer + arrayIndex * FRigUnit_MathFloatSqrt_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathFloatSqrt value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathFloatSqrt_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatSqrt_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatSqrt");
		}
	}

	public FRigUnit_MathFloatSqrt(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatSqrt_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatSqrt");
		}
	}

	static FRigUnit_MathFloatSqrt()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathFloatSqrt)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathFloatSqrt));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathFloatSqrt");
		FRigUnit_MathFloatSqrt_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathFloatSqrt_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathFloatSqrt", FRigUnit_MathFloatSqrt_IsValid);
	}
}
