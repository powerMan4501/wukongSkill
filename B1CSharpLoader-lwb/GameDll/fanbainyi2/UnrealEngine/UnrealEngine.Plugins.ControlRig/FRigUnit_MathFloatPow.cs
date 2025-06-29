using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathFloatPow", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathFloatPow
{
	private static bool FRigUnit_MathFloatPow_IsValid;

	private static int FRigUnit_MathFloatPow_StructSize;

	public FRigUnit_MathFloatPow Copy()
	{
		return this;
	}

	public static FRigUnit_MathFloatPow FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathFloatPow(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathFloatPow value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathFloatPow FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathFloatPow(nativeBuffer + arrayIndex * FRigUnit_MathFloatPow_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathFloatPow value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathFloatPow_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatPow_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatPow");
		}
	}

	public FRigUnit_MathFloatPow(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatPow_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatPow");
		}
	}

	static FRigUnit_MathFloatPow()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathFloatPow)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathFloatPow));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathFloatPow");
		FRigUnit_MathFloatPow_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathFloatPow_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathFloatPow", FRigUnit_MathFloatPow_IsValid);
	}
}
