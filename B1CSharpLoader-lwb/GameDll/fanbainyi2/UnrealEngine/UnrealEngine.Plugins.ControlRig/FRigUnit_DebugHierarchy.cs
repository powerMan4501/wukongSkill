using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_DebugHierarchy", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_DebugHierarchy
{
	private static bool FRigUnit_DebugHierarchy_IsValid;

	private static int FRigUnit_DebugHierarchy_StructSize;

	public FRigUnit_DebugHierarchy Copy()
	{
		return this;
	}

	public static FRigUnit_DebugHierarchy FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_DebugHierarchy(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_DebugHierarchy value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_DebugHierarchy FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_DebugHierarchy(nativeBuffer + arrayIndex * FRigUnit_DebugHierarchy_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_DebugHierarchy value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_DebugHierarchy_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_DebugHierarchy_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DebugHierarchy");
		}
	}

	public FRigUnit_DebugHierarchy(IntPtr nativeStruct)
	{
		if (!FRigUnit_DebugHierarchy_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DebugHierarchy");
		}
	}

	static FRigUnit_DebugHierarchy()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_DebugHierarchy)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_DebugHierarchy));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_DebugHierarchy");
		FRigUnit_DebugHierarchy_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_DebugHierarchy_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_DebugHierarchy", FRigUnit_DebugHierarchy_IsValid);
	}
}
