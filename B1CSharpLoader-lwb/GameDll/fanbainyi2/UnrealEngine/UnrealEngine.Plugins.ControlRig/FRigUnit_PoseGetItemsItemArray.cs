using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_PoseGetItemsItemArray", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_PoseGetItemsItemArray
{
	private static bool FRigUnit_PoseGetItemsItemArray_IsValid;

	private static int FRigUnit_PoseGetItemsItemArray_StructSize;

	public FRigUnit_PoseGetItemsItemArray Copy()
	{
		return this;
	}

	public static FRigUnit_PoseGetItemsItemArray FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_PoseGetItemsItemArray(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_PoseGetItemsItemArray value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_PoseGetItemsItemArray FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_PoseGetItemsItemArray(nativeBuffer + arrayIndex * FRigUnit_PoseGetItemsItemArray_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_PoseGetItemsItemArray value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_PoseGetItemsItemArray_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_PoseGetItemsItemArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_PoseGetItemsItemArray");
		}
	}

	public FRigUnit_PoseGetItemsItemArray(IntPtr nativeStruct)
	{
		if (!FRigUnit_PoseGetItemsItemArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_PoseGetItemsItemArray");
		}
	}

	static FRigUnit_PoseGetItemsItemArray()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_PoseGetItemsItemArray)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_PoseGetItemsItemArray));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_PoseGetItemsItemArray");
		FRigUnit_PoseGetItemsItemArray_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_PoseGetItemsItemArray_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_PoseGetItemsItemArray", FRigUnit_PoseGetItemsItemArray_IsValid);
	}
}
