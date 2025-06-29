using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_HierarchyGetSiblings", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_HierarchyGetSiblings
{
	private static bool FRigUnit_HierarchyGetSiblings_IsValid;

	private static int FRigUnit_HierarchyGetSiblings_StructSize;

	public FRigUnit_HierarchyGetSiblings Copy()
	{
		return this;
	}

	public static FRigUnit_HierarchyGetSiblings FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_HierarchyGetSiblings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_HierarchyGetSiblings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_HierarchyGetSiblings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_HierarchyGetSiblings(nativeBuffer + arrayIndex * FRigUnit_HierarchyGetSiblings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_HierarchyGetSiblings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_HierarchyGetSiblings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_HierarchyGetSiblings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_HierarchyGetSiblings");
		}
	}

	public FRigUnit_HierarchyGetSiblings(IntPtr nativeStruct)
	{
		if (!FRigUnit_HierarchyGetSiblings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_HierarchyGetSiblings");
		}
	}

	static FRigUnit_HierarchyGetSiblings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_HierarchyGetSiblings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_HierarchyGetSiblings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_HierarchyGetSiblings");
		FRigUnit_HierarchyGetSiblings_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_HierarchyGetSiblings_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_HierarchyGetSiblings", FRigUnit_HierarchyGetSiblings_IsValid);
	}
}
