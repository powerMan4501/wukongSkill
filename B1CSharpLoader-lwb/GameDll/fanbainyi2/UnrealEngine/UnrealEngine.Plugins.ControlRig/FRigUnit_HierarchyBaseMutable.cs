using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_HierarchyBaseMutable", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_HierarchyBaseMutable
{
	private static bool FRigUnit_HierarchyBaseMutable_IsValid;

	private static int FRigUnit_HierarchyBaseMutable_StructSize;

	public FRigUnit_HierarchyBaseMutable Copy()
	{
		return this;
	}

	public static FRigUnit_HierarchyBaseMutable FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_HierarchyBaseMutable(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_HierarchyBaseMutable value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_HierarchyBaseMutable FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_HierarchyBaseMutable(nativeBuffer + arrayIndex * FRigUnit_HierarchyBaseMutable_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_HierarchyBaseMutable value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_HierarchyBaseMutable_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_HierarchyBaseMutable_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_HierarchyBaseMutable");
		}
	}

	public FRigUnit_HierarchyBaseMutable(IntPtr nativeStruct)
	{
		if (!FRigUnit_HierarchyBaseMutable_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_HierarchyBaseMutable");
		}
	}

	static FRigUnit_HierarchyBaseMutable()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_HierarchyBaseMutable)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_HierarchyBaseMutable));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_HierarchyBaseMutable");
		FRigUnit_HierarchyBaseMutable_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_HierarchyBaseMutable_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_HierarchyBaseMutable", FRigUnit_HierarchyBaseMutable_IsValid);
	}
}
