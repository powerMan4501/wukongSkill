using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_AlphaInterpVector", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_AlphaInterpVector
{
	private static bool FRigUnit_AlphaInterpVector_IsValid;

	private static int FRigUnit_AlphaInterpVector_StructSize;

	public FRigUnit_AlphaInterpVector Copy()
	{
		return this;
	}

	public static FRigUnit_AlphaInterpVector FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_AlphaInterpVector(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_AlphaInterpVector value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_AlphaInterpVector FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_AlphaInterpVector(nativeBuffer + arrayIndex * FRigUnit_AlphaInterpVector_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_AlphaInterpVector value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_AlphaInterpVector_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_AlphaInterpVector_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_AlphaInterpVector");
		}
	}

	public FRigUnit_AlphaInterpVector(IntPtr nativeStruct)
	{
		if (!FRigUnit_AlphaInterpVector_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_AlphaInterpVector");
		}
	}

	static FRigUnit_AlphaInterpVector()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_AlphaInterpVector)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_AlphaInterpVector));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_AlphaInterpVector");
		FRigUnit_AlphaInterpVector_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_AlphaInterpVector_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_AlphaInterpVector", FRigUnit_AlphaInterpVector_IsValid);
	}
}
