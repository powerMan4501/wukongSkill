using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_DynamicHierarchyBaseMutable", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_DynamicHierarchyBaseMutable
{
	private static bool FRigUnit_DynamicHierarchyBaseMutable_IsValid;

	private static int FRigUnit_DynamicHierarchyBaseMutable_StructSize;

	public FRigUnit_DynamicHierarchyBaseMutable Copy()
	{
		return this;
	}

	public static FRigUnit_DynamicHierarchyBaseMutable FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_DynamicHierarchyBaseMutable(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_DynamicHierarchyBaseMutable value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_DynamicHierarchyBaseMutable FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_DynamicHierarchyBaseMutable(nativeBuffer + arrayIndex * FRigUnit_DynamicHierarchyBaseMutable_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_DynamicHierarchyBaseMutable value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_DynamicHierarchyBaseMutable_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_DynamicHierarchyBaseMutable_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DynamicHierarchyBaseMutable");
		}
	}

	public FRigUnit_DynamicHierarchyBaseMutable(IntPtr nativeStruct)
	{
		if (!FRigUnit_DynamicHierarchyBaseMutable_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DynamicHierarchyBaseMutable");
		}
	}

	static FRigUnit_DynamicHierarchyBaseMutable()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_DynamicHierarchyBaseMutable)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_DynamicHierarchyBaseMutable));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_DynamicHierarchyBaseMutable");
		FRigUnit_DynamicHierarchyBaseMutable_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_DynamicHierarchyBaseMutable_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_DynamicHierarchyBaseMutable", FRigUnit_DynamicHierarchyBaseMutable_IsValid);
	}
}
