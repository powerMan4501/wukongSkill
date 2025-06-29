using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_HierarchyGetParents", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_HierarchyGetParents
{
	private static bool FRigUnit_HierarchyGetParents_IsValid;

	private static int FRigUnit_HierarchyGetParents_StructSize;

	public FRigUnit_HierarchyGetParents Copy()
	{
		return this;
	}

	public static FRigUnit_HierarchyGetParents FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_HierarchyGetParents(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_HierarchyGetParents value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_HierarchyGetParents FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_HierarchyGetParents(nativeBuffer + arrayIndex * FRigUnit_HierarchyGetParents_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_HierarchyGetParents value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_HierarchyGetParents_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_HierarchyGetParents_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_HierarchyGetParents");
		}
	}

	public FRigUnit_HierarchyGetParents(IntPtr nativeStruct)
	{
		if (!FRigUnit_HierarchyGetParents_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_HierarchyGetParents");
		}
	}

	static FRigUnit_HierarchyGetParents()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_HierarchyGetParents)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_HierarchyGetParents));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_HierarchyGetParents");
		FRigUnit_HierarchyGetParents_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_HierarchyGetParents_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_HierarchyGetParents", FRigUnit_HierarchyGetParents_IsValid);
	}
}
