using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_CollectionChildrenArray", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_CollectionChildrenArray
{
	private static bool FRigUnit_CollectionChildrenArray_IsValid;

	private static int FRigUnit_CollectionChildrenArray_StructSize;

	public FRigUnit_CollectionChildrenArray Copy()
	{
		return this;
	}

	public static FRigUnit_CollectionChildrenArray FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_CollectionChildrenArray(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_CollectionChildrenArray value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_CollectionChildrenArray FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_CollectionChildrenArray(nativeBuffer + arrayIndex * FRigUnit_CollectionChildrenArray_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_CollectionChildrenArray value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_CollectionChildrenArray_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_CollectionChildrenArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_CollectionChildrenArray");
		}
	}

	public FRigUnit_CollectionChildrenArray(IntPtr nativeStruct)
	{
		if (!FRigUnit_CollectionChildrenArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_CollectionChildrenArray");
		}
	}

	static FRigUnit_CollectionChildrenArray()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_CollectionChildrenArray)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_CollectionChildrenArray));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_CollectionChildrenArray");
		FRigUnit_CollectionChildrenArray_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_CollectionChildrenArray_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_CollectionChildrenArray", FRigUnit_CollectionChildrenArray_IsValid);
	}
}
