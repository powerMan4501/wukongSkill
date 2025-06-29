using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_ItemEquals", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_ItemEquals
{
	private static bool FRigUnit_ItemEquals_IsValid;

	private static int FRigUnit_ItemEquals_StructSize;

	public FRigUnit_ItemEquals Copy()
	{
		return this;
	}

	public static FRigUnit_ItemEquals FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_ItemEquals(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_ItemEquals value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_ItemEquals FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_ItemEquals(nativeBuffer + arrayIndex * FRigUnit_ItemEquals_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_ItemEquals value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_ItemEquals_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_ItemEquals_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ItemEquals");
		}
	}

	public FRigUnit_ItemEquals(IntPtr nativeStruct)
	{
		if (!FRigUnit_ItemEquals_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ItemEquals");
		}
	}

	static FRigUnit_ItemEquals()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_ItemEquals)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_ItemEquals));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_ItemEquals");
		FRigUnit_ItemEquals_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_ItemEquals_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_ItemEquals", FRigUnit_ItemEquals_IsValid);
	}
}
