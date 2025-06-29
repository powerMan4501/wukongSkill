using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_BoneName", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_BoneName
{
	private static bool FRigUnit_BoneName_IsValid;

	private static int FRigUnit_BoneName_StructSize;

	public FRigUnit_BoneName Copy()
	{
		return this;
	}

	public static FRigUnit_BoneName FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_BoneName(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_BoneName value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_BoneName FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_BoneName(nativeBuffer + arrayIndex * FRigUnit_BoneName_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_BoneName value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_BoneName_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_BoneName_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_BoneName");
		}
	}

	public FRigUnit_BoneName(IntPtr nativeStruct)
	{
		if (!FRigUnit_BoneName_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_BoneName");
		}
	}

	static FRigUnit_BoneName()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_BoneName)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_BoneName));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_BoneName");
		FRigUnit_BoneName_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_BoneName_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_BoneName", FRigUnit_BoneName_IsValid);
	}
}
