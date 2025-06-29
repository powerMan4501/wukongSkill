using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_CollectionReplaceItemsArray", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_CollectionReplaceItemsArray
{
	private static bool FRigUnit_CollectionReplaceItemsArray_IsValid;

	private static int FRigUnit_CollectionReplaceItemsArray_StructSize;

	public FRigUnit_CollectionReplaceItemsArray Copy()
	{
		return this;
	}

	public static FRigUnit_CollectionReplaceItemsArray FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_CollectionReplaceItemsArray(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_CollectionReplaceItemsArray value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_CollectionReplaceItemsArray FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_CollectionReplaceItemsArray(nativeBuffer + arrayIndex * FRigUnit_CollectionReplaceItemsArray_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_CollectionReplaceItemsArray value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_CollectionReplaceItemsArray_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_CollectionReplaceItemsArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_CollectionReplaceItemsArray");
		}
	}

	public FRigUnit_CollectionReplaceItemsArray(IntPtr nativeStruct)
	{
		if (!FRigUnit_CollectionReplaceItemsArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_CollectionReplaceItemsArray");
		}
	}

	static FRigUnit_CollectionReplaceItemsArray()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_CollectionReplaceItemsArray)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_CollectionReplaceItemsArray));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_CollectionReplaceItemsArray");
		FRigUnit_CollectionReplaceItemsArray_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_CollectionReplaceItemsArray_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_CollectionReplaceItemsArray", FRigUnit_CollectionReplaceItemsArray_IsValid);
	}
}
