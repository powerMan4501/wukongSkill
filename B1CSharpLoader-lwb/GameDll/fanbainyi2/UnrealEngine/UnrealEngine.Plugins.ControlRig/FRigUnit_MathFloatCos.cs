using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathFloatCos", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathFloatCos
{
	private static bool FRigUnit_MathFloatCos_IsValid;

	private static int FRigUnit_MathFloatCos_StructSize;

	public FRigUnit_MathFloatCos Copy()
	{
		return this;
	}

	public static FRigUnit_MathFloatCos FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathFloatCos(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathFloatCos value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathFloatCos FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathFloatCos(nativeBuffer + arrayIndex * FRigUnit_MathFloatCos_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathFloatCos value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathFloatCos_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatCos_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatCos");
		}
	}

	public FRigUnit_MathFloatCos(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatCos_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatCos");
		}
	}

	static FRigUnit_MathFloatCos()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathFloatCos)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathFloatCos));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathFloatCos");
		FRigUnit_MathFloatCos_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathFloatCos_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathFloatCos", FRigUnit_MathFloatCos_IsValid);
	}
}
