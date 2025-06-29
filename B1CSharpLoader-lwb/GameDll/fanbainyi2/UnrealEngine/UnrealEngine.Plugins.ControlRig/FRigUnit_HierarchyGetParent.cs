using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_HierarchyGetParent", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_HierarchyGetParent
{
	private static bool FRigUnit_HierarchyGetParent_IsValid;

	private static int FRigUnit_HierarchyGetParent_StructSize;

	public FRigUnit_HierarchyGetParent Copy()
	{
		return this;
	}

	public static FRigUnit_HierarchyGetParent FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_HierarchyGetParent(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_HierarchyGetParent value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_HierarchyGetParent FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_HierarchyGetParent(nativeBuffer + arrayIndex * FRigUnit_HierarchyGetParent_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_HierarchyGetParent value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_HierarchyGetParent_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_HierarchyGetParent_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_HierarchyGetParent");
		}
	}

	public FRigUnit_HierarchyGetParent(IntPtr nativeStruct)
	{
		if (!FRigUnit_HierarchyGetParent_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_HierarchyGetParent");
		}
	}

	static FRigUnit_HierarchyGetParent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_HierarchyGetParent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_HierarchyGetParent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_HierarchyGetParent");
		FRigUnit_HierarchyGetParent_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_HierarchyGetParent_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_HierarchyGetParent", FRigUnit_HierarchyGetParent_IsValid);
	}
}
