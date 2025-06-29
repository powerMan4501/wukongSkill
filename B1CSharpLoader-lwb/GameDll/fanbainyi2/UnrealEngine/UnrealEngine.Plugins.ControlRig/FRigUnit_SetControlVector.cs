using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_SetControlVector", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_SetControlVector
{
	private static bool FRigUnit_SetControlVector_IsValid;

	private static int FRigUnit_SetControlVector_StructSize;

	public FRigUnit_SetControlVector Copy()
	{
		return this;
	}

	public static FRigUnit_SetControlVector FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_SetControlVector(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_SetControlVector value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_SetControlVector FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_SetControlVector(nativeBuffer + arrayIndex * FRigUnit_SetControlVector_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_SetControlVector value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_SetControlVector_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_SetControlVector_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SetControlVector");
		}
	}

	public FRigUnit_SetControlVector(IntPtr nativeStruct)
	{
		if (!FRigUnit_SetControlVector_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SetControlVector");
		}
	}

	static FRigUnit_SetControlVector()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_SetControlVector)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_SetControlVector));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_SetControlVector");
		FRigUnit_SetControlVector_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_SetControlVector_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_SetControlVector", FRigUnit_SetControlVector_IsValid);
	}
}
