using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathFloatDiv", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathFloatDiv
{
	private static bool FRigUnit_MathFloatDiv_IsValid;

	private static int FRigUnit_MathFloatDiv_StructSize;

	public FRigUnit_MathFloatDiv Copy()
	{
		return this;
	}

	public static FRigUnit_MathFloatDiv FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathFloatDiv(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathFloatDiv value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathFloatDiv FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathFloatDiv(nativeBuffer + arrayIndex * FRigUnit_MathFloatDiv_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathFloatDiv value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathFloatDiv_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatDiv_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatDiv");
		}
	}

	public FRigUnit_MathFloatDiv(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatDiv_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatDiv");
		}
	}

	static FRigUnit_MathFloatDiv()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathFloatDiv)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathFloatDiv));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathFloatDiv");
		FRigUnit_MathFloatDiv_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathFloatDiv_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathFloatDiv", FRigUnit_MathFloatDiv_IsValid);
	}
}
