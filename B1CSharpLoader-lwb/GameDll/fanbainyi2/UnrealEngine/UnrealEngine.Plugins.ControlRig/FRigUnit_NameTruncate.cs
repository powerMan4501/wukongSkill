using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_NameTruncate", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_NameTruncate
{
	private static bool FRigUnit_NameTruncate_IsValid;

	private static int FRigUnit_NameTruncate_StructSize;

	public FRigUnit_NameTruncate Copy()
	{
		return this;
	}

	public static FRigUnit_NameTruncate FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_NameTruncate(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_NameTruncate value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_NameTruncate FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_NameTruncate(nativeBuffer + arrayIndex * FRigUnit_NameTruncate_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_NameTruncate value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_NameTruncate_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_NameTruncate_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_NameTruncate");
		}
	}

	public FRigUnit_NameTruncate(IntPtr nativeStruct)
	{
		if (!FRigUnit_NameTruncate_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_NameTruncate");
		}
	}

	static FRigUnit_NameTruncate()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_NameTruncate)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_NameTruncate));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_NameTruncate");
		FRigUnit_NameTruncate_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_NameTruncate_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_NameTruncate", FRigUnit_NameTruncate_IsValid);
	}
}
