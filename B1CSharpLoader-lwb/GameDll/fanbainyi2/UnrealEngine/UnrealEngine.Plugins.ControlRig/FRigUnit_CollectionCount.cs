using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_CollectionCount", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_CollectionCount
{
	private static bool FRigUnit_CollectionCount_IsValid;

	private static int FRigUnit_CollectionCount_StructSize;

	public FRigUnit_CollectionCount Copy()
	{
		return this;
	}

	public static FRigUnit_CollectionCount FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_CollectionCount(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_CollectionCount value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_CollectionCount FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_CollectionCount(nativeBuffer + arrayIndex * FRigUnit_CollectionCount_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_CollectionCount value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_CollectionCount_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_CollectionCount_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_CollectionCount");
		}
	}

	public FRigUnit_CollectionCount(IntPtr nativeStruct)
	{
		if (!FRigUnit_CollectionCount_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_CollectionCount");
		}
	}

	static FRigUnit_CollectionCount()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_CollectionCount)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_CollectionCount));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_CollectionCount");
		FRigUnit_CollectionCount_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_CollectionCount_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_CollectionCount", FRigUnit_CollectionCount_IsValid);
	}
}
