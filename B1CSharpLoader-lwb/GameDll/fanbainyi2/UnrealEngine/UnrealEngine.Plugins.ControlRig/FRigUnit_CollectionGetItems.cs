using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_CollectionGetItems", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_CollectionGetItems
{
	private static bool FRigUnit_CollectionGetItems_IsValid;

	private static int FRigUnit_CollectionGetItems_StructSize;

	public FRigUnit_CollectionGetItems Copy()
	{
		return this;
	}

	public static FRigUnit_CollectionGetItems FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_CollectionGetItems(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_CollectionGetItems value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_CollectionGetItems FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_CollectionGetItems(nativeBuffer + arrayIndex * FRigUnit_CollectionGetItems_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_CollectionGetItems value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_CollectionGetItems_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_CollectionGetItems_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_CollectionGetItems");
		}
	}

	public FRigUnit_CollectionGetItems(IntPtr nativeStruct)
	{
		if (!FRigUnit_CollectionGetItems_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_CollectionGetItems");
		}
	}

	static FRigUnit_CollectionGetItems()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_CollectionGetItems)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_CollectionGetItems));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_CollectionGetItems");
		FRigUnit_CollectionGetItems_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_CollectionGetItems_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_CollectionGetItems", FRigUnit_CollectionGetItems_IsValid);
	}
}
