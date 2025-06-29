using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_HierarchyGetParentWeights", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_HierarchyGetParentWeights
{
	private static bool FRigUnit_HierarchyGetParentWeights_IsValid;

	private static int FRigUnit_HierarchyGetParentWeights_StructSize;

	public FRigUnit_HierarchyGetParentWeights Copy()
	{
		return this;
	}

	public static FRigUnit_HierarchyGetParentWeights FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_HierarchyGetParentWeights(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_HierarchyGetParentWeights value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_HierarchyGetParentWeights FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_HierarchyGetParentWeights(nativeBuffer + arrayIndex * FRigUnit_HierarchyGetParentWeights_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_HierarchyGetParentWeights value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_HierarchyGetParentWeights_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_HierarchyGetParentWeights_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_HierarchyGetParentWeights");
		}
	}

	public FRigUnit_HierarchyGetParentWeights(IntPtr nativeStruct)
	{
		if (!FRigUnit_HierarchyGetParentWeights_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_HierarchyGetParentWeights");
		}
	}

	static FRigUnit_HierarchyGetParentWeights()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_HierarchyGetParentWeights)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_HierarchyGetParentWeights));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_HierarchyGetParentWeights");
		FRigUnit_HierarchyGetParentWeights_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_HierarchyGetParentWeights_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_HierarchyGetParentWeights", FRigUnit_HierarchyGetParentWeights_IsValid);
	}
}
