using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_RandomVector", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_RandomVector
{
	private static bool FRigUnit_RandomVector_IsValid;

	private static int FRigUnit_RandomVector_StructSize;

	public FRigUnit_RandomVector Copy()
	{
		return this;
	}

	public static FRigUnit_RandomVector FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_RandomVector(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_RandomVector value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_RandomVector FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_RandomVector(nativeBuffer + arrayIndex * FRigUnit_RandomVector_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_RandomVector value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_RandomVector_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_RandomVector_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_RandomVector");
		}
	}

	public FRigUnit_RandomVector(IntPtr nativeStruct)
	{
		if (!FRigUnit_RandomVector_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_RandomVector");
		}
	}

	static FRigUnit_RandomVector()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_RandomVector)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_RandomVector));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_RandomVector");
		FRigUnit_RandomVector_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_RandomVector_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_RandomVector", FRigUnit_RandomVector_IsValid);
	}
}
