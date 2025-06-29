using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_HierarchySetPoseItemArray", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_HierarchySetPoseItemArray
{
	private static bool FRigUnit_HierarchySetPoseItemArray_IsValid;

	private static int FRigUnit_HierarchySetPoseItemArray_StructSize;

	public FRigUnit_HierarchySetPoseItemArray Copy()
	{
		return this;
	}

	public static FRigUnit_HierarchySetPoseItemArray FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_HierarchySetPoseItemArray(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_HierarchySetPoseItemArray value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_HierarchySetPoseItemArray FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_HierarchySetPoseItemArray(nativeBuffer + arrayIndex * FRigUnit_HierarchySetPoseItemArray_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_HierarchySetPoseItemArray value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_HierarchySetPoseItemArray_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_HierarchySetPoseItemArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_HierarchySetPoseItemArray");
		}
	}

	public FRigUnit_HierarchySetPoseItemArray(IntPtr nativeStruct)
	{
		if (!FRigUnit_HierarchySetPoseItemArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_HierarchySetPoseItemArray");
		}
	}

	static FRigUnit_HierarchySetPoseItemArray()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_HierarchySetPoseItemArray)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_HierarchySetPoseItemArray));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_HierarchySetPoseItemArray");
		FRigUnit_HierarchySetPoseItemArray_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_HierarchySetPoseItemArray_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_HierarchySetPoseItemArray", FRigUnit_HierarchySetPoseItemArray_IsValid);
	}
}
