using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_HierarchyGetPose", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_HierarchyGetPose
{
	private static bool FRigUnit_HierarchyGetPose_IsValid;

	private static int FRigUnit_HierarchyGetPose_StructSize;

	public FRigUnit_HierarchyGetPose Copy()
	{
		return this;
	}

	public static FRigUnit_HierarchyGetPose FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_HierarchyGetPose(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_HierarchyGetPose value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_HierarchyGetPose FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_HierarchyGetPose(nativeBuffer + arrayIndex * FRigUnit_HierarchyGetPose_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_HierarchyGetPose value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_HierarchyGetPose_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_HierarchyGetPose_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_HierarchyGetPose");
		}
	}

	public FRigUnit_HierarchyGetPose(IntPtr nativeStruct)
	{
		if (!FRigUnit_HierarchyGetPose_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_HierarchyGetPose");
		}
	}

	static FRigUnit_HierarchyGetPose()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_HierarchyGetPose)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_HierarchyGetPose));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_HierarchyGetPose");
		FRigUnit_HierarchyGetPose_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_HierarchyGetPose_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_HierarchyGetPose", FRigUnit_HierarchyGetPose_IsValid);
	}
}
