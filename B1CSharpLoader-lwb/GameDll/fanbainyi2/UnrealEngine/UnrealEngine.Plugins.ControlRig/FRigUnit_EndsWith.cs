using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_EndsWith", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_EndsWith
{
	private static bool FRigUnit_EndsWith_IsValid;

	private static int FRigUnit_EndsWith_StructSize;

	public FRigUnit_EndsWith Copy()
	{
		return this;
	}

	public static FRigUnit_EndsWith FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_EndsWith(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_EndsWith value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_EndsWith FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_EndsWith(nativeBuffer + arrayIndex * FRigUnit_EndsWith_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_EndsWith value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_EndsWith_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_EndsWith_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_EndsWith");
		}
	}

	public FRigUnit_EndsWith(IntPtr nativeStruct)
	{
		if (!FRigUnit_EndsWith_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_EndsWith");
		}
	}

	static FRigUnit_EndsWith()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_EndsWith)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_EndsWith));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_EndsWith");
		FRigUnit_EndsWith_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_EndsWith_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_EndsWith", FRigUnit_EndsWith_IsValid);
	}
}
