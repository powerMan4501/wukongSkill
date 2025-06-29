using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_CollectionItems", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_CollectionItems
{
	private static bool FRigUnit_CollectionItems_IsValid;

	private static int FRigUnit_CollectionItems_StructSize;

	public FRigUnit_CollectionItems Copy()
	{
		return this;
	}

	public static FRigUnit_CollectionItems FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_CollectionItems(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_CollectionItems value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_CollectionItems FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_CollectionItems(nativeBuffer + arrayIndex * FRigUnit_CollectionItems_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_CollectionItems value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_CollectionItems_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_CollectionItems_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_CollectionItems");
		}
	}

	public FRigUnit_CollectionItems(IntPtr nativeStruct)
	{
		if (!FRigUnit_CollectionItems_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_CollectionItems");
		}
	}

	static FRigUnit_CollectionItems()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_CollectionItems)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_CollectionItems));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_CollectionItems");
		FRigUnit_CollectionItems_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_CollectionItems_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_CollectionItems", FRigUnit_CollectionItems_IsValid);
	}
}
