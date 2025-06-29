using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_HierarchySetParentWeights", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_HierarchySetParentWeights
{
	private static bool FRigUnit_HierarchySetParentWeights_IsValid;

	private static int FRigUnit_HierarchySetParentWeights_StructSize;

	public FRigUnit_HierarchySetParentWeights Copy()
	{
		return this;
	}

	public static FRigUnit_HierarchySetParentWeights FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_HierarchySetParentWeights(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_HierarchySetParentWeights value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_HierarchySetParentWeights FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_HierarchySetParentWeights(nativeBuffer + arrayIndex * FRigUnit_HierarchySetParentWeights_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_HierarchySetParentWeights value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_HierarchySetParentWeights_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_HierarchySetParentWeights_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_HierarchySetParentWeights");
		}
	}

	public FRigUnit_HierarchySetParentWeights(IntPtr nativeStruct)
	{
		if (!FRigUnit_HierarchySetParentWeights_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_HierarchySetParentWeights");
		}
	}

	static FRigUnit_HierarchySetParentWeights()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_HierarchySetParentWeights)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_HierarchySetParentWeights));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_HierarchySetParentWeights");
		FRigUnit_HierarchySetParentWeights_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_HierarchySetParentWeights_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_HierarchySetParentWeights", FRigUnit_HierarchySetParentWeights_IsValid);
	}
}
