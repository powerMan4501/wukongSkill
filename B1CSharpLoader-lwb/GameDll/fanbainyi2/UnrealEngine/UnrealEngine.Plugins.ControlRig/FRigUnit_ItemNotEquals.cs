using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_ItemNotEquals", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_ItemNotEquals
{
	private static bool FRigUnit_ItemNotEquals_IsValid;

	private static int FRigUnit_ItemNotEquals_StructSize;

	public FRigUnit_ItemNotEquals Copy()
	{
		return this;
	}

	public static FRigUnit_ItemNotEquals FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_ItemNotEquals(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_ItemNotEquals value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_ItemNotEquals FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_ItemNotEquals(nativeBuffer + arrayIndex * FRigUnit_ItemNotEquals_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_ItemNotEquals value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_ItemNotEquals_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_ItemNotEquals_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ItemNotEquals");
		}
	}

	public FRigUnit_ItemNotEquals(IntPtr nativeStruct)
	{
		if (!FRigUnit_ItemNotEquals_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ItemNotEquals");
		}
	}

	static FRigUnit_ItemNotEquals()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_ItemNotEquals)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_ItemNotEquals));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_ItemNotEquals");
		FRigUnit_ItemNotEquals_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_ItemNotEquals_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_ItemNotEquals", FRigUnit_ItemNotEquals_IsValid);
	}
}
