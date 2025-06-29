using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_CollectionReverse", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_CollectionReverse
{
	private static bool FRigUnit_CollectionReverse_IsValid;

	private static int FRigUnit_CollectionReverse_StructSize;

	public FRigUnit_CollectionReverse Copy()
	{
		return this;
	}

	public static FRigUnit_CollectionReverse FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_CollectionReverse(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_CollectionReverse value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_CollectionReverse FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_CollectionReverse(nativeBuffer + arrayIndex * FRigUnit_CollectionReverse_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_CollectionReverse value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_CollectionReverse_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_CollectionReverse_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_CollectionReverse");
		}
	}

	public FRigUnit_CollectionReverse(IntPtr nativeStruct)
	{
		if (!FRigUnit_CollectionReverse_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_CollectionReverse");
		}
	}

	static FRigUnit_CollectionReverse()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_CollectionReverse)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_CollectionReverse));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_CollectionReverse");
		FRigUnit_CollectionReverse_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_CollectionReverse_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_CollectionReverse", FRigUnit_CollectionReverse_IsValid);
	}
}
