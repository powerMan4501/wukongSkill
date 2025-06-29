using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_DynamicHierarchyBase", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_DynamicHierarchyBase
{
	private static bool FRigUnit_DynamicHierarchyBase_IsValid;

	private static int FRigUnit_DynamicHierarchyBase_StructSize;

	public FRigUnit_DynamicHierarchyBase Copy()
	{
		return this;
	}

	public static FRigUnit_DynamicHierarchyBase FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_DynamicHierarchyBase(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_DynamicHierarchyBase value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_DynamicHierarchyBase FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_DynamicHierarchyBase(nativeBuffer + arrayIndex * FRigUnit_DynamicHierarchyBase_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_DynamicHierarchyBase value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_DynamicHierarchyBase_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_DynamicHierarchyBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DynamicHierarchyBase");
		}
	}

	public FRigUnit_DynamicHierarchyBase(IntPtr nativeStruct)
	{
		if (!FRigUnit_DynamicHierarchyBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DynamicHierarchyBase");
		}
	}

	static FRigUnit_DynamicHierarchyBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_DynamicHierarchyBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_DynamicHierarchyBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_DynamicHierarchyBase");
		FRigUnit_DynamicHierarchyBase_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_DynamicHierarchyBase_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_DynamicHierarchyBase", FRigUnit_DynamicHierarchyBase_IsValid);
	}
}
