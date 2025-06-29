using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_SlideChainPerItem", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_SlideChainPerItem
{
	private static bool FRigUnit_SlideChainPerItem_IsValid;

	private static int FRigUnit_SlideChainPerItem_StructSize;

	public FRigUnit_SlideChainPerItem Copy()
	{
		return this;
	}

	public static FRigUnit_SlideChainPerItem FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_SlideChainPerItem(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_SlideChainPerItem value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_SlideChainPerItem FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_SlideChainPerItem(nativeBuffer + arrayIndex * FRigUnit_SlideChainPerItem_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_SlideChainPerItem value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_SlideChainPerItem_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_SlideChainPerItem_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SlideChainPerItem");
		}
	}

	public FRigUnit_SlideChainPerItem(IntPtr nativeStruct)
	{
		if (!FRigUnit_SlideChainPerItem_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SlideChainPerItem");
		}
	}

	static FRigUnit_SlideChainPerItem()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_SlideChainPerItem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_SlideChainPerItem));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_SlideChainPerItem");
		FRigUnit_SlideChainPerItem_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_SlideChainPerItem_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_SlideChainPerItem", FRigUnit_SlideChainPerItem_IsValid);
	}
}
