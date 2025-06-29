using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_CollectionGetParentIndicesItemArray", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_CollectionGetParentIndicesItemArray
{
	private static bool FRigUnit_CollectionGetParentIndicesItemArray_IsValid;

	private static int FRigUnit_CollectionGetParentIndicesItemArray_StructSize;

	public FRigUnit_CollectionGetParentIndicesItemArray Copy()
	{
		return this;
	}

	public static FRigUnit_CollectionGetParentIndicesItemArray FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_CollectionGetParentIndicesItemArray(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_CollectionGetParentIndicesItemArray value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_CollectionGetParentIndicesItemArray FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_CollectionGetParentIndicesItemArray(nativeBuffer + arrayIndex * FRigUnit_CollectionGetParentIndicesItemArray_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_CollectionGetParentIndicesItemArray value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_CollectionGetParentIndicesItemArray_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_CollectionGetParentIndicesItemArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_CollectionGetParentIndicesItemArray");
		}
	}

	public FRigUnit_CollectionGetParentIndicesItemArray(IntPtr nativeStruct)
	{
		if (!FRigUnit_CollectionGetParentIndicesItemArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_CollectionGetParentIndicesItemArray");
		}
	}

	static FRigUnit_CollectionGetParentIndicesItemArray()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_CollectionGetParentIndicesItemArray)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_CollectionGetParentIndicesItemArray));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_CollectionGetParentIndicesItemArray");
		FRigUnit_CollectionGetParentIndicesItemArray_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_CollectionGetParentIndicesItemArray_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_CollectionGetParentIndicesItemArray", FRigUnit_CollectionGetParentIndicesItemArray_IsValid);
	}
}
