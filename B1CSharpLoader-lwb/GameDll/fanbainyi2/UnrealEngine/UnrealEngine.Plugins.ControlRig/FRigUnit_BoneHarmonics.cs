using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_BoneHarmonics", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_BoneHarmonics
{
	private static bool FRigUnit_BoneHarmonics_IsValid;

	private static int FRigUnit_BoneHarmonics_StructSize;

	public FRigUnit_BoneHarmonics Copy()
	{
		return this;
	}

	public static FRigUnit_BoneHarmonics FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_BoneHarmonics(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_BoneHarmonics value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_BoneHarmonics FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_BoneHarmonics(nativeBuffer + arrayIndex * FRigUnit_BoneHarmonics_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_BoneHarmonics value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_BoneHarmonics_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_BoneHarmonics_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_BoneHarmonics");
		}
	}

	public FRigUnit_BoneHarmonics(IntPtr nativeStruct)
	{
		if (!FRigUnit_BoneHarmonics_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_BoneHarmonics");
		}
	}

	static FRigUnit_BoneHarmonics()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_BoneHarmonics)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_BoneHarmonics));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_BoneHarmonics");
		FRigUnit_BoneHarmonics_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_BoneHarmonics_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_BoneHarmonics", FRigUnit_BoneHarmonics_IsValid);
	}
}
