using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_StartsWith", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_StartsWith
{
	private static bool FRigUnit_StartsWith_IsValid;

	private static int FRigUnit_StartsWith_StructSize;

	public FRigUnit_StartsWith Copy()
	{
		return this;
	}

	public static FRigUnit_StartsWith FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_StartsWith(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_StartsWith value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_StartsWith FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_StartsWith(nativeBuffer + arrayIndex * FRigUnit_StartsWith_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_StartsWith value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_StartsWith_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_StartsWith_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_StartsWith");
		}
	}

	public FRigUnit_StartsWith(IntPtr nativeStruct)
	{
		if (!FRigUnit_StartsWith_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_StartsWith");
		}
	}

	static FRigUnit_StartsWith()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_StartsWith)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_StartsWith));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_StartsWith");
		FRigUnit_StartsWith_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_StartsWith_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_StartsWith", FRigUnit_StartsWith_IsValid);
	}
}
