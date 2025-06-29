using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_ItemHarmonics", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_ItemHarmonics
{
	private static bool FRigUnit_ItemHarmonics_IsValid;

	private static int FRigUnit_ItemHarmonics_StructSize;

	public FRigUnit_ItemHarmonics Copy()
	{
		return this;
	}

	public static FRigUnit_ItemHarmonics FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_ItemHarmonics(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_ItemHarmonics value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_ItemHarmonics FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_ItemHarmonics(nativeBuffer + arrayIndex * FRigUnit_ItemHarmonics_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_ItemHarmonics value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_ItemHarmonics_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_ItemHarmonics_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ItemHarmonics");
		}
	}

	public FRigUnit_ItemHarmonics(IntPtr nativeStruct)
	{
		if (!FRigUnit_ItemHarmonics_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ItemHarmonics");
		}
	}

	static FRigUnit_ItemHarmonics()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_ItemHarmonics)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_ItemHarmonics));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_ItemHarmonics");
		FRigUnit_ItemHarmonics_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_ItemHarmonics_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_ItemHarmonics", FRigUnit_ItemHarmonics_IsValid);
	}
}
