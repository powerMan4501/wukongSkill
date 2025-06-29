using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathFloatCeil", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathFloatCeil
{
	private static bool FRigUnit_MathFloatCeil_IsValid;

	private static int FRigUnit_MathFloatCeil_StructSize;

	public FRigUnit_MathFloatCeil Copy()
	{
		return this;
	}

	public static FRigUnit_MathFloatCeil FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathFloatCeil(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathFloatCeil value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathFloatCeil FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathFloatCeil(nativeBuffer + arrayIndex * FRigUnit_MathFloatCeil_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathFloatCeil value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathFloatCeil_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatCeil_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatCeil");
		}
	}

	public FRigUnit_MathFloatCeil(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatCeil_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatCeil");
		}
	}

	static FRigUnit_MathFloatCeil()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathFloatCeil)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathFloatCeil));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathFloatCeil");
		FRigUnit_MathFloatCeil_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathFloatCeil_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathFloatCeil", FRigUnit_MathFloatCeil_IsValid);
	}
}
