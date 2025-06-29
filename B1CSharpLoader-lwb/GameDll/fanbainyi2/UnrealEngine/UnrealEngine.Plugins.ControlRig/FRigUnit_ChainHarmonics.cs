using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_ChainHarmonics", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_ChainHarmonics
{
	private static bool FRigUnit_ChainHarmonics_IsValid;

	private static int FRigUnit_ChainHarmonics_StructSize;

	public FRigUnit_ChainHarmonics Copy()
	{
		return this;
	}

	public static FRigUnit_ChainHarmonics FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_ChainHarmonics(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_ChainHarmonics value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_ChainHarmonics FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_ChainHarmonics(nativeBuffer + arrayIndex * FRigUnit_ChainHarmonics_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_ChainHarmonics value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_ChainHarmonics_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_ChainHarmonics_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ChainHarmonics");
		}
	}

	public FRigUnit_ChainHarmonics(IntPtr nativeStruct)
	{
		if (!FRigUnit_ChainHarmonics_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ChainHarmonics");
		}
	}

	static FRigUnit_ChainHarmonics()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_ChainHarmonics)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_ChainHarmonics));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_ChainHarmonics");
		FRigUnit_ChainHarmonics_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_ChainHarmonics_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_ChainHarmonics", FRigUnit_ChainHarmonics_IsValid);
	}
}
