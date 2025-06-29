using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_HierarchyGetParentsItemArray", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_HierarchyGetParentsItemArray
{
	private static bool FRigUnit_HierarchyGetParentsItemArray_IsValid;

	private static int FRigUnit_HierarchyGetParentsItemArray_StructSize;

	public FRigUnit_HierarchyGetParentsItemArray Copy()
	{
		return this;
	}

	public static FRigUnit_HierarchyGetParentsItemArray FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_HierarchyGetParentsItemArray(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_HierarchyGetParentsItemArray value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_HierarchyGetParentsItemArray FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_HierarchyGetParentsItemArray(nativeBuffer + arrayIndex * FRigUnit_HierarchyGetParentsItemArray_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_HierarchyGetParentsItemArray value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_HierarchyGetParentsItemArray_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_HierarchyGetParentsItemArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_HierarchyGetParentsItemArray");
		}
	}

	public FRigUnit_HierarchyGetParentsItemArray(IntPtr nativeStruct)
	{
		if (!FRigUnit_HierarchyGetParentsItemArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_HierarchyGetParentsItemArray");
		}
	}

	static FRigUnit_HierarchyGetParentsItemArray()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_HierarchyGetParentsItemArray)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_HierarchyGetParentsItemArray));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_HierarchyGetParentsItemArray");
		FRigUnit_HierarchyGetParentsItemArray_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_HierarchyGetParentsItemArray_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_HierarchyGetParentsItemArray", FRigUnit_HierarchyGetParentsItemArray_IsValid);
	}
}
