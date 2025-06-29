using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_ControlName", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_ControlName
{
	private static bool FRigUnit_ControlName_IsValid;

	private static int FRigUnit_ControlName_StructSize;

	public FRigUnit_ControlName Copy()
	{
		return this;
	}

	public static FRigUnit_ControlName FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_ControlName(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_ControlName value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_ControlName FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_ControlName(nativeBuffer + arrayIndex * FRigUnit_ControlName_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_ControlName value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_ControlName_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_ControlName_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ControlName");
		}
	}

	public FRigUnit_ControlName(IntPtr nativeStruct)
	{
		if (!FRigUnit_ControlName_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ControlName");
		}
	}

	static FRigUnit_ControlName()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_ControlName)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_ControlName));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_ControlName");
		FRigUnit_ControlName_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_ControlName_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_ControlName", FRigUnit_ControlName_IsValid);
	}
}
