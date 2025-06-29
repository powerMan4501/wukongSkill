using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathFloatGreaterEqual", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathFloatGreaterEqual
{
	private static bool FRigUnit_MathFloatGreaterEqual_IsValid;

	private static int FRigUnit_MathFloatGreaterEqual_StructSize;

	public FRigUnit_MathFloatGreaterEqual Copy()
	{
		return this;
	}

	public static FRigUnit_MathFloatGreaterEqual FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathFloatGreaterEqual(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathFloatGreaterEqual value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathFloatGreaterEqual FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathFloatGreaterEqual(nativeBuffer + arrayIndex * FRigUnit_MathFloatGreaterEqual_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathFloatGreaterEqual value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathFloatGreaterEqual_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatGreaterEqual_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatGreaterEqual");
		}
	}

	public FRigUnit_MathFloatGreaterEqual(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatGreaterEqual_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatGreaterEqual");
		}
	}

	static FRigUnit_MathFloatGreaterEqual()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathFloatGreaterEqual)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathFloatGreaterEqual));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathFloatGreaterEqual");
		FRigUnit_MathFloatGreaterEqual_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathFloatGreaterEqual_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathFloatGreaterEqual", FRigUnit_MathFloatGreaterEqual_IsValid);
	}
}
