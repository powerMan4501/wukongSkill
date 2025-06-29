using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_HierarchySetPose", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_HierarchySetPose
{
	private static bool FRigUnit_HierarchySetPose_IsValid;

	private static int FRigUnit_HierarchySetPose_StructSize;

	public FRigUnit_HierarchySetPose Copy()
	{
		return this;
	}

	public static FRigUnit_HierarchySetPose FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_HierarchySetPose(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_HierarchySetPose value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_HierarchySetPose FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_HierarchySetPose(nativeBuffer + arrayIndex * FRigUnit_HierarchySetPose_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_HierarchySetPose value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_HierarchySetPose_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_HierarchySetPose_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_HierarchySetPose");
		}
	}

	public FRigUnit_HierarchySetPose(IntPtr nativeStruct)
	{
		if (!FRigUnit_HierarchySetPose_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_HierarchySetPose");
		}
	}

	static FRigUnit_HierarchySetPose()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_HierarchySetPose)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_HierarchySetPose));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_HierarchySetPose");
		FRigUnit_HierarchySetPose_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_HierarchySetPose_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_HierarchySetPose", FRigUnit_HierarchySetPose_IsValid);
	}
}
