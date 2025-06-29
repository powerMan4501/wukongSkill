using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_GetRelativeTransformForItem", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_GetRelativeTransformForItem
{
	private static bool FRigUnit_GetRelativeTransformForItem_IsValid;

	private static int FRigUnit_GetRelativeTransformForItem_StructSize;

	public FRigUnit_GetRelativeTransformForItem Copy()
	{
		return this;
	}

	public static FRigUnit_GetRelativeTransformForItem FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_GetRelativeTransformForItem(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_GetRelativeTransformForItem value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_GetRelativeTransformForItem FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_GetRelativeTransformForItem(nativeBuffer + arrayIndex * FRigUnit_GetRelativeTransformForItem_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_GetRelativeTransformForItem value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_GetRelativeTransformForItem_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_GetRelativeTransformForItem_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_GetRelativeTransformForItem");
		}
	}

	public FRigUnit_GetRelativeTransformForItem(IntPtr nativeStruct)
	{
		if (!FRigUnit_GetRelativeTransformForItem_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_GetRelativeTransformForItem");
		}
	}

	static FRigUnit_GetRelativeTransformForItem()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_GetRelativeTransformForItem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_GetRelativeTransformForItem));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_GetRelativeTransformForItem");
		FRigUnit_GetRelativeTransformForItem_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_GetRelativeTransformForItem_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_GetRelativeTransformForItem", FRigUnit_GetRelativeTransformForItem_IsValid);
	}
}
