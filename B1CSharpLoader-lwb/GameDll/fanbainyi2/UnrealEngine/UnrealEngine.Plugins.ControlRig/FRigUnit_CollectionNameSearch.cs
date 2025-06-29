using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_CollectionNameSearch", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_CollectionNameSearch
{
	private static bool FRigUnit_CollectionNameSearch_IsValid;

	private static int FRigUnit_CollectionNameSearch_StructSize;

	public FRigUnit_CollectionNameSearch Copy()
	{
		return this;
	}

	public static FRigUnit_CollectionNameSearch FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_CollectionNameSearch(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_CollectionNameSearch value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_CollectionNameSearch FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_CollectionNameSearch(nativeBuffer + arrayIndex * FRigUnit_CollectionNameSearch_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_CollectionNameSearch value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_CollectionNameSearch_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_CollectionNameSearch_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_CollectionNameSearch");
		}
	}

	public FRigUnit_CollectionNameSearch(IntPtr nativeStruct)
	{
		if (!FRigUnit_CollectionNameSearch_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_CollectionNameSearch");
		}
	}

	static FRigUnit_CollectionNameSearch()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_CollectionNameSearch)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_CollectionNameSearch));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_CollectionNameSearch");
		FRigUnit_CollectionNameSearch_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_CollectionNameSearch_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_CollectionNameSearch", FRigUnit_CollectionNameSearch_IsValid);
	}
}
