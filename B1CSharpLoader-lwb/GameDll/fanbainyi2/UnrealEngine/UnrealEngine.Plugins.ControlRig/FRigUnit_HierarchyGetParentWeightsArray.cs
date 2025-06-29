using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_HierarchyGetParentWeightsArray", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_HierarchyGetParentWeightsArray
{
	private static bool FRigUnit_HierarchyGetParentWeightsArray_IsValid;

	private static int FRigUnit_HierarchyGetParentWeightsArray_StructSize;

	public FRigUnit_HierarchyGetParentWeightsArray Copy()
	{
		return this;
	}

	public static FRigUnit_HierarchyGetParentWeightsArray FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_HierarchyGetParentWeightsArray(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_HierarchyGetParentWeightsArray value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_HierarchyGetParentWeightsArray FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_HierarchyGetParentWeightsArray(nativeBuffer + arrayIndex * FRigUnit_HierarchyGetParentWeightsArray_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_HierarchyGetParentWeightsArray value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_HierarchyGetParentWeightsArray_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_HierarchyGetParentWeightsArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_HierarchyGetParentWeightsArray");
		}
	}

	public FRigUnit_HierarchyGetParentWeightsArray(IntPtr nativeStruct)
	{
		if (!FRigUnit_HierarchyGetParentWeightsArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_HierarchyGetParentWeightsArray");
		}
	}

	static FRigUnit_HierarchyGetParentWeightsArray()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_HierarchyGetParentWeightsArray)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_HierarchyGetParentWeightsArray));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_HierarchyGetParentWeightsArray");
		FRigUnit_HierarchyGetParentWeightsArray_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_HierarchyGetParentWeightsArray_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_HierarchyGetParentWeightsArray", FRigUnit_HierarchyGetParentWeightsArray_IsValid);
	}
}
