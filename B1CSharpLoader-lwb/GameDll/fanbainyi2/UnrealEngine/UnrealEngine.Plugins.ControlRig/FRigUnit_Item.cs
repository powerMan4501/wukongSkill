using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_Item", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_Item
{
	private static bool FRigUnit_Item_IsValid;

	private static int FRigUnit_Item_StructSize;

	public FRigUnit_Item Copy()
	{
		return this;
	}

	public static FRigUnit_Item FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_Item(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_Item value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_Item FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_Item(nativeBuffer + arrayIndex * FRigUnit_Item_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_Item value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_Item_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_Item_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_Item");
		}
	}

	public FRigUnit_Item(IntPtr nativeStruct)
	{
		if (!FRigUnit_Item_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_Item");
		}
	}

	static FRigUnit_Item()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_Item)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_Item));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_Item");
		FRigUnit_Item_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_Item_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_Item", FRigUnit_Item_IsValid);
	}
}
