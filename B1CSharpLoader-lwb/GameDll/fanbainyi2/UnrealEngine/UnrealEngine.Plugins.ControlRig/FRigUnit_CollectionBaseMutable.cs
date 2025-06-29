using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_CollectionBaseMutable", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_CollectionBaseMutable
{
	private static bool FRigUnit_CollectionBaseMutable_IsValid;

	private static int FRigUnit_CollectionBaseMutable_StructSize;

	public FRigUnit_CollectionBaseMutable Copy()
	{
		return this;
	}

	public static FRigUnit_CollectionBaseMutable FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_CollectionBaseMutable(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_CollectionBaseMutable value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_CollectionBaseMutable FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_CollectionBaseMutable(nativeBuffer + arrayIndex * FRigUnit_CollectionBaseMutable_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_CollectionBaseMutable value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_CollectionBaseMutable_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_CollectionBaseMutable_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_CollectionBaseMutable");
		}
	}

	public FRigUnit_CollectionBaseMutable(IntPtr nativeStruct)
	{
		if (!FRigUnit_CollectionBaseMutable_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_CollectionBaseMutable");
		}
	}

	static FRigUnit_CollectionBaseMutable()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_CollectionBaseMutable)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_CollectionBaseMutable));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_CollectionBaseMutable");
		FRigUnit_CollectionBaseMutable_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_CollectionBaseMutable_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_CollectionBaseMutable", FRigUnit_CollectionBaseMutable_IsValid);
	}
}
