using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_CollectionNameSearchArray", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_CollectionNameSearchArray
{
	private static bool FRigUnit_CollectionNameSearchArray_IsValid;

	private static int FRigUnit_CollectionNameSearchArray_StructSize;

	public FRigUnit_CollectionNameSearchArray Copy()
	{
		return this;
	}

	public static FRigUnit_CollectionNameSearchArray FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_CollectionNameSearchArray(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_CollectionNameSearchArray value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_CollectionNameSearchArray FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_CollectionNameSearchArray(nativeBuffer + arrayIndex * FRigUnit_CollectionNameSearchArray_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_CollectionNameSearchArray value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_CollectionNameSearchArray_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_CollectionNameSearchArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_CollectionNameSearchArray");
		}
	}

	public FRigUnit_CollectionNameSearchArray(IntPtr nativeStruct)
	{
		if (!FRigUnit_CollectionNameSearchArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_CollectionNameSearchArray");
		}
	}

	static FRigUnit_CollectionNameSearchArray()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_CollectionNameSearchArray)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_CollectionNameSearchArray));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_CollectionNameSearchArray");
		FRigUnit_CollectionNameSearchArray_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_CollectionNameSearchArray_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_CollectionNameSearchArray", FRigUnit_CollectionNameSearchArray_IsValid);
	}
}
