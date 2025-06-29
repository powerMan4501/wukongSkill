using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_ChainHarmonicsPerItem", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_ChainHarmonicsPerItem
{
	private static bool FRigUnit_ChainHarmonicsPerItem_IsValid;

	private static int FRigUnit_ChainHarmonicsPerItem_StructSize;

	public FRigUnit_ChainHarmonicsPerItem Copy()
	{
		return this;
	}

	public static FRigUnit_ChainHarmonicsPerItem FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_ChainHarmonicsPerItem(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_ChainHarmonicsPerItem value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_ChainHarmonicsPerItem FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_ChainHarmonicsPerItem(nativeBuffer + arrayIndex * FRigUnit_ChainHarmonicsPerItem_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_ChainHarmonicsPerItem value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_ChainHarmonicsPerItem_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_ChainHarmonicsPerItem_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ChainHarmonicsPerItem");
		}
	}

	public FRigUnit_ChainHarmonicsPerItem(IntPtr nativeStruct)
	{
		if (!FRigUnit_ChainHarmonicsPerItem_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ChainHarmonicsPerItem");
		}
	}

	static FRigUnit_ChainHarmonicsPerItem()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_ChainHarmonicsPerItem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_ChainHarmonicsPerItem));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_ChainHarmonicsPerItem");
		FRigUnit_ChainHarmonicsPerItem_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_ChainHarmonicsPerItem_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_ChainHarmonicsPerItem", FRigUnit_ChainHarmonicsPerItem_IsValid);
	}
}
