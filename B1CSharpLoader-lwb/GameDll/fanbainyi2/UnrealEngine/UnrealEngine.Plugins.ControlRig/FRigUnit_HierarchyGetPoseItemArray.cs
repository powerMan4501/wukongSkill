using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_HierarchyGetPoseItemArray", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_HierarchyGetPoseItemArray
{
	private static bool FRigUnit_HierarchyGetPoseItemArray_IsValid;

	private static int FRigUnit_HierarchyGetPoseItemArray_StructSize;

	public FRigUnit_HierarchyGetPoseItemArray Copy()
	{
		return this;
	}

	public static FRigUnit_HierarchyGetPoseItemArray FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_HierarchyGetPoseItemArray(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_HierarchyGetPoseItemArray value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_HierarchyGetPoseItemArray FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_HierarchyGetPoseItemArray(nativeBuffer + arrayIndex * FRigUnit_HierarchyGetPoseItemArray_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_HierarchyGetPoseItemArray value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_HierarchyGetPoseItemArray_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_HierarchyGetPoseItemArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_HierarchyGetPoseItemArray");
		}
	}

	public FRigUnit_HierarchyGetPoseItemArray(IntPtr nativeStruct)
	{
		if (!FRigUnit_HierarchyGetPoseItemArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_HierarchyGetPoseItemArray");
		}
	}

	static FRigUnit_HierarchyGetPoseItemArray()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_HierarchyGetPoseItemArray)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_HierarchyGetPoseItemArray));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_HierarchyGetPoseItemArray");
		FRigUnit_HierarchyGetPoseItemArray_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_HierarchyGetPoseItemArray_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_HierarchyGetPoseItemArray", FRigUnit_HierarchyGetPoseItemArray_IsValid);
	}
}
