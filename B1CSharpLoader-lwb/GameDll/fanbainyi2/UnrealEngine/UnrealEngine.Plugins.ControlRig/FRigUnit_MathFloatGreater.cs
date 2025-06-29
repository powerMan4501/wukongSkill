using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathFloatGreater", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathFloatGreater
{
	private static bool FRigUnit_MathFloatGreater_IsValid;

	private static int FRigUnit_MathFloatGreater_StructSize;

	public FRigUnit_MathFloatGreater Copy()
	{
		return this;
	}

	public static FRigUnit_MathFloatGreater FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathFloatGreater(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathFloatGreater value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathFloatGreater FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathFloatGreater(nativeBuffer + arrayIndex * FRigUnit_MathFloatGreater_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathFloatGreater value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathFloatGreater_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatGreater_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatGreater");
		}
	}

	public FRigUnit_MathFloatGreater(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatGreater_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatGreater");
		}
	}

	static FRigUnit_MathFloatGreater()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathFloatGreater)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathFloatGreater));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathFloatGreater");
		FRigUnit_MathFloatGreater_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathFloatGreater_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathFloatGreater", FRigUnit_MathFloatGreater_IsValid);
	}
}
