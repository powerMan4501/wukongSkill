using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_OffsetTransformForItem", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_OffsetTransformForItem
{
	private static bool FRigUnit_OffsetTransformForItem_IsValid;

	private static int FRigUnit_OffsetTransformForItem_StructSize;

	public FRigUnit_OffsetTransformForItem Copy()
	{
		return this;
	}

	public static FRigUnit_OffsetTransformForItem FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_OffsetTransformForItem(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_OffsetTransformForItem value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_OffsetTransformForItem FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_OffsetTransformForItem(nativeBuffer + arrayIndex * FRigUnit_OffsetTransformForItem_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_OffsetTransformForItem value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_OffsetTransformForItem_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_OffsetTransformForItem_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_OffsetTransformForItem");
		}
	}

	public FRigUnit_OffsetTransformForItem(IntPtr nativeStruct)
	{
		if (!FRigUnit_OffsetTransformForItem_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_OffsetTransformForItem");
		}
	}

	static FRigUnit_OffsetTransformForItem()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_OffsetTransformForItem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_OffsetTransformForItem));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_OffsetTransformForItem");
		FRigUnit_OffsetTransformForItem_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_OffsetTransformForItem_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_OffsetTransformForItem", FRigUnit_OffsetTransformForItem_IsValid);
	}
}
