using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_CollectionChainArray", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_CollectionChainArray
{
	private static bool FRigUnit_CollectionChainArray_IsValid;

	private static int FRigUnit_CollectionChainArray_StructSize;

	public FRigUnit_CollectionChainArray Copy()
	{
		return this;
	}

	public static FRigUnit_CollectionChainArray FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_CollectionChainArray(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_CollectionChainArray value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_CollectionChainArray FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_CollectionChainArray(nativeBuffer + arrayIndex * FRigUnit_CollectionChainArray_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_CollectionChainArray value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_CollectionChainArray_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_CollectionChainArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_CollectionChainArray");
		}
	}

	public FRigUnit_CollectionChainArray(IntPtr nativeStruct)
	{
		if (!FRigUnit_CollectionChainArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_CollectionChainArray");
		}
	}

	static FRigUnit_CollectionChainArray()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_CollectionChainArray)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_CollectionChainArray));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_CollectionChainArray");
		FRigUnit_CollectionChainArray_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_CollectionChainArray_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_CollectionChainArray", FRigUnit_CollectionChainArray_IsValid);
	}
}
