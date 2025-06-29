using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_GetControlVector", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_GetControlVector
{
	private static bool FRigUnit_GetControlVector_IsValid;

	private static int FRigUnit_GetControlVector_StructSize;

	public FRigUnit_GetControlVector Copy()
	{
		return this;
	}

	public static FRigUnit_GetControlVector FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_GetControlVector(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_GetControlVector value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_GetControlVector FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_GetControlVector(nativeBuffer + arrayIndex * FRigUnit_GetControlVector_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_GetControlVector value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_GetControlVector_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_GetControlVector_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_GetControlVector");
		}
	}

	public FRigUnit_GetControlVector(IntPtr nativeStruct)
	{
		if (!FRigUnit_GetControlVector_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_GetControlVector");
		}
	}

	static FRigUnit_GetControlVector()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_GetControlVector)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_GetControlVector));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_GetControlVector");
		FRigUnit_GetControlVector_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_GetControlVector_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_GetControlVector", FRigUnit_GetControlVector_IsValid);
	}
}
