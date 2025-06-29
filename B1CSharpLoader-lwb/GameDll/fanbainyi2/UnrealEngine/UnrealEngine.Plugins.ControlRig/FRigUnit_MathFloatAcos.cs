using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathFloatAcos", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathFloatAcos
{
	private static bool FRigUnit_MathFloatAcos_IsValid;

	private static int FRigUnit_MathFloatAcos_StructSize;

	public FRigUnit_MathFloatAcos Copy()
	{
		return this;
	}

	public static FRigUnit_MathFloatAcos FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathFloatAcos(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathFloatAcos value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathFloatAcos FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathFloatAcos(nativeBuffer + arrayIndex * FRigUnit_MathFloatAcos_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathFloatAcos value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathFloatAcos_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatAcos_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatAcos");
		}
	}

	public FRigUnit_MathFloatAcos(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatAcos_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatAcos");
		}
	}

	static FRigUnit_MathFloatAcos()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathFloatAcos)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathFloatAcos));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathFloatAcos");
		FRigUnit_MathFloatAcos_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathFloatAcos_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathFloatAcos", FRigUnit_MathFloatAcos_IsValid);
	}
}
