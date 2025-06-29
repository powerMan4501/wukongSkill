using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_CollectionBase", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_CollectionBase
{
	private static bool FRigUnit_CollectionBase_IsValid;

	private static int FRigUnit_CollectionBase_StructSize;

	public FRigUnit_CollectionBase Copy()
	{
		return this;
	}

	public static FRigUnit_CollectionBase FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_CollectionBase(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_CollectionBase value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_CollectionBase FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_CollectionBase(nativeBuffer + arrayIndex * FRigUnit_CollectionBase_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_CollectionBase value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_CollectionBase_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_CollectionBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_CollectionBase");
		}
	}

	public FRigUnit_CollectionBase(IntPtr nativeStruct)
	{
		if (!FRigUnit_CollectionBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_CollectionBase");
		}
	}

	static FRigUnit_CollectionBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_CollectionBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_CollectionBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_CollectionBase");
		FRigUnit_CollectionBase_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_CollectionBase_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_CollectionBase", FRigUnit_CollectionBase_IsValid);
	}
}
