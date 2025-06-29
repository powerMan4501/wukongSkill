using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_HierarchyGetChildren", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_HierarchyGetChildren
{
	private static bool FRigUnit_HierarchyGetChildren_IsValid;

	private static int FRigUnit_HierarchyGetChildren_StructSize;

	public FRigUnit_HierarchyGetChildren Copy()
	{
		return this;
	}

	public static FRigUnit_HierarchyGetChildren FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_HierarchyGetChildren(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_HierarchyGetChildren value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_HierarchyGetChildren FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_HierarchyGetChildren(nativeBuffer + arrayIndex * FRigUnit_HierarchyGetChildren_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_HierarchyGetChildren value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_HierarchyGetChildren_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_HierarchyGetChildren_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_HierarchyGetChildren");
		}
	}

	public FRigUnit_HierarchyGetChildren(IntPtr nativeStruct)
	{
		if (!FRigUnit_HierarchyGetChildren_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_HierarchyGetChildren");
		}
	}

	static FRigUnit_HierarchyGetChildren()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_HierarchyGetChildren)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_HierarchyGetChildren));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_HierarchyGetChildren");
		FRigUnit_HierarchyGetChildren_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_HierarchyGetChildren_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_HierarchyGetChildren", FRigUnit_HierarchyGetChildren_IsValid);
	}
}
