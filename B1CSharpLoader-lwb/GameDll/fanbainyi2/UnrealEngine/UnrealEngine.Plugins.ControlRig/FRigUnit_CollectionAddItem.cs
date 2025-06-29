using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_CollectionAddItem", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_CollectionAddItem
{
	private static bool FRigUnit_CollectionAddItem_IsValid;

	private static int FRigUnit_CollectionAddItem_StructSize;

	public FRigUnit_CollectionAddItem Copy()
	{
		return this;
	}

	public static FRigUnit_CollectionAddItem FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_CollectionAddItem(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_CollectionAddItem value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_CollectionAddItem FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_CollectionAddItem(nativeBuffer + arrayIndex * FRigUnit_CollectionAddItem_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_CollectionAddItem value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_CollectionAddItem_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_CollectionAddItem_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_CollectionAddItem");
		}
	}

	public FRigUnit_CollectionAddItem(IntPtr nativeStruct)
	{
		if (!FRigUnit_CollectionAddItem_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_CollectionAddItem");
		}
	}

	static FRigUnit_CollectionAddItem()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_CollectionAddItem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_CollectionAddItem));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_CollectionAddItem");
		FRigUnit_CollectionAddItem_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_CollectionAddItem_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_CollectionAddItem", FRigUnit_CollectionAddItem_IsValid);
	}
}
