using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_SetRelativeTransformForItem", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_SetRelativeTransformForItem
{
	private static bool FRigUnit_SetRelativeTransformForItem_IsValid;

	private static int FRigUnit_SetRelativeTransformForItem_StructSize;

	public FRigUnit_SetRelativeTransformForItem Copy()
	{
		return this;
	}

	public static FRigUnit_SetRelativeTransformForItem FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_SetRelativeTransformForItem(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_SetRelativeTransformForItem value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_SetRelativeTransformForItem FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_SetRelativeTransformForItem(nativeBuffer + arrayIndex * FRigUnit_SetRelativeTransformForItem_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_SetRelativeTransformForItem value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_SetRelativeTransformForItem_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_SetRelativeTransformForItem_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SetRelativeTransformForItem");
		}
	}

	public FRigUnit_SetRelativeTransformForItem(IntPtr nativeStruct)
	{
		if (!FRigUnit_SetRelativeTransformForItem_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SetRelativeTransformForItem");
		}
	}

	static FRigUnit_SetRelativeTransformForItem()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_SetRelativeTransformForItem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_SetRelativeTransformForItem));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_SetRelativeTransformForItem");
		FRigUnit_SetRelativeTransformForItem_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_SetRelativeTransformForItem_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_SetRelativeTransformForItem", FRigUnit_SetRelativeTransformForItem_IsValid);
	}
}
