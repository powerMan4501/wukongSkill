using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_NoiseVector", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_NoiseVector
{
	private static bool FRigUnit_NoiseVector_IsValid;

	private static int FRigUnit_NoiseVector_StructSize;

	public FRigUnit_NoiseVector Copy()
	{
		return this;
	}

	public static FRigUnit_NoiseVector FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_NoiseVector(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_NoiseVector value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_NoiseVector FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_NoiseVector(nativeBuffer + arrayIndex * FRigUnit_NoiseVector_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_NoiseVector value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_NoiseVector_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_NoiseVector_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_NoiseVector");
		}
	}

	public FRigUnit_NoiseVector(IntPtr nativeStruct)
	{
		if (!FRigUnit_NoiseVector_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_NoiseVector");
		}
	}

	static FRigUnit_NoiseVector()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_NoiseVector)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_NoiseVector));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_NoiseVector");
		FRigUnit_NoiseVector_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_NoiseVector_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_NoiseVector", FRigUnit_NoiseVector_IsValid);
	}
}
