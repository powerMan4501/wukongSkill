using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_ItemTypeEquals", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_ItemTypeEquals
{
	private static bool FRigUnit_ItemTypeEquals_IsValid;

	private static int FRigUnit_ItemTypeEquals_StructSize;

	public FRigUnit_ItemTypeEquals Copy()
	{
		return this;
	}

	public static FRigUnit_ItemTypeEquals FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_ItemTypeEquals(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_ItemTypeEquals value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_ItemTypeEquals FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_ItemTypeEquals(nativeBuffer + arrayIndex * FRigUnit_ItemTypeEquals_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_ItemTypeEquals value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_ItemTypeEquals_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_ItemTypeEquals_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ItemTypeEquals");
		}
	}

	public FRigUnit_ItemTypeEquals(IntPtr nativeStruct)
	{
		if (!FRigUnit_ItemTypeEquals_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ItemTypeEquals");
		}
	}

	static FRigUnit_ItemTypeEquals()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_ItemTypeEquals)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_ItemTypeEquals));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_ItemTypeEquals");
		FRigUnit_ItemTypeEquals_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_ItemTypeEquals_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_ItemTypeEquals", FRigUnit_ItemTypeEquals_IsValid);
	}
}
