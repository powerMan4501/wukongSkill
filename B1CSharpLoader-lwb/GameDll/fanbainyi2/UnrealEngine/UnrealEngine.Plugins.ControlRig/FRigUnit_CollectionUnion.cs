using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_CollectionUnion", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_CollectionUnion
{
	private static bool FRigUnit_CollectionUnion_IsValid;

	private static int FRigUnit_CollectionUnion_StructSize;

	public FRigUnit_CollectionUnion Copy()
	{
		return this;
	}

	public static FRigUnit_CollectionUnion FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_CollectionUnion(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_CollectionUnion value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_CollectionUnion FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_CollectionUnion(nativeBuffer + arrayIndex * FRigUnit_CollectionUnion_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_CollectionUnion value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_CollectionUnion_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_CollectionUnion_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_CollectionUnion");
		}
	}

	public FRigUnit_CollectionUnion(IntPtr nativeStruct)
	{
		if (!FRigUnit_CollectionUnion_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_CollectionUnion");
		}
	}

	static FRigUnit_CollectionUnion()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_CollectionUnion)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_CollectionUnion));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_CollectionUnion");
		FRigUnit_CollectionUnion_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_CollectionUnion_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_CollectionUnion", FRigUnit_CollectionUnion_IsValid);
	}
}
