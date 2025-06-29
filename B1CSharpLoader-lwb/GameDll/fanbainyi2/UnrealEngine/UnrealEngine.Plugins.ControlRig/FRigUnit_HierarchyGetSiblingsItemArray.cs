using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_HierarchyGetSiblingsItemArray", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_HierarchyGetSiblingsItemArray
{
	private static bool FRigUnit_HierarchyGetSiblingsItemArray_IsValid;

	private static int FRigUnit_HierarchyGetSiblingsItemArray_StructSize;

	public FRigUnit_HierarchyGetSiblingsItemArray Copy()
	{
		return this;
	}

	public static FRigUnit_HierarchyGetSiblingsItemArray FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_HierarchyGetSiblingsItemArray(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_HierarchyGetSiblingsItemArray value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_HierarchyGetSiblingsItemArray FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_HierarchyGetSiblingsItemArray(nativeBuffer + arrayIndex * FRigUnit_HierarchyGetSiblingsItemArray_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_HierarchyGetSiblingsItemArray value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_HierarchyGetSiblingsItemArray_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_HierarchyGetSiblingsItemArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_HierarchyGetSiblingsItemArray");
		}
	}

	public FRigUnit_HierarchyGetSiblingsItemArray(IntPtr nativeStruct)
	{
		if (!FRigUnit_HierarchyGetSiblingsItemArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_HierarchyGetSiblingsItemArray");
		}
	}

	static FRigUnit_HierarchyGetSiblingsItemArray()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_HierarchyGetSiblingsItemArray)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_HierarchyGetSiblingsItemArray));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_HierarchyGetSiblingsItemArray");
		FRigUnit_HierarchyGetSiblingsItemArray_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_HierarchyGetSiblingsItemArray_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_HierarchyGetSiblingsItemArray", FRigUnit_HierarchyGetSiblingsItemArray_IsValid);
	}
}
