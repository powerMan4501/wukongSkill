using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_HierarchyBase", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_HierarchyBase
{
	private static bool FRigUnit_HierarchyBase_IsValid;

	private static int FRigUnit_HierarchyBase_StructSize;

	public FRigUnit_HierarchyBase Copy()
	{
		return this;
	}

	public static FRigUnit_HierarchyBase FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_HierarchyBase(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_HierarchyBase value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_HierarchyBase FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_HierarchyBase(nativeBuffer + arrayIndex * FRigUnit_HierarchyBase_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_HierarchyBase value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_HierarchyBase_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_HierarchyBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_HierarchyBase");
		}
	}

	public FRigUnit_HierarchyBase(IntPtr nativeStruct)
	{
		if (!FRigUnit_HierarchyBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_HierarchyBase");
		}
	}

	static FRigUnit_HierarchyBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_HierarchyBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_HierarchyBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_HierarchyBase");
		FRigUnit_HierarchyBase_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_HierarchyBase_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_HierarchyBase", FRigUnit_HierarchyBase_IsValid);
	}
}
