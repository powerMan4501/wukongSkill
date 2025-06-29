using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_ItemTypeNotEquals", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_ItemTypeNotEquals
{
	private static bool FRigUnit_ItemTypeNotEquals_IsValid;

	private static int FRigUnit_ItemTypeNotEquals_StructSize;

	public FRigUnit_ItemTypeNotEquals Copy()
	{
		return this;
	}

	public static FRigUnit_ItemTypeNotEquals FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_ItemTypeNotEquals(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_ItemTypeNotEquals value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_ItemTypeNotEquals FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_ItemTypeNotEquals(nativeBuffer + arrayIndex * FRigUnit_ItemTypeNotEquals_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_ItemTypeNotEquals value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_ItemTypeNotEquals_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_ItemTypeNotEquals_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ItemTypeNotEquals");
		}
	}

	public FRigUnit_ItemTypeNotEquals(IntPtr nativeStruct)
	{
		if (!FRigUnit_ItemTypeNotEquals_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ItemTypeNotEquals");
		}
	}

	static FRigUnit_ItemTypeNotEquals()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_ItemTypeNotEquals)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_ItemTypeNotEquals));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_ItemTypeNotEquals");
		FRigUnit_ItemTypeNotEquals_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_ItemTypeNotEquals_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_ItemTypeNotEquals", FRigUnit_ItemTypeNotEquals_IsValid);
	}
}
