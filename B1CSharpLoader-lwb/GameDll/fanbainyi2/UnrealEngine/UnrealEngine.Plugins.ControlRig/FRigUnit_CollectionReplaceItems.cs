using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_CollectionReplaceItems", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_CollectionReplaceItems
{
	private static bool FRigUnit_CollectionReplaceItems_IsValid;

	private static int FRigUnit_CollectionReplaceItems_StructSize;

	public FRigUnit_CollectionReplaceItems Copy()
	{
		return this;
	}

	public static FRigUnit_CollectionReplaceItems FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_CollectionReplaceItems(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_CollectionReplaceItems value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_CollectionReplaceItems FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_CollectionReplaceItems(nativeBuffer + arrayIndex * FRigUnit_CollectionReplaceItems_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_CollectionReplaceItems value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_CollectionReplaceItems_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_CollectionReplaceItems_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_CollectionReplaceItems");
		}
	}

	public FRigUnit_CollectionReplaceItems(IntPtr nativeStruct)
	{
		if (!FRigUnit_CollectionReplaceItems_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_CollectionReplaceItems");
		}
	}

	static FRigUnit_CollectionReplaceItems()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_CollectionReplaceItems)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_CollectionReplaceItems));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_CollectionReplaceItems");
		FRigUnit_CollectionReplaceItems_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_CollectionReplaceItems_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_CollectionReplaceItems", FRigUnit_CollectionReplaceItems_IsValid);
	}
}
