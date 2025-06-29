using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_CollectionGetParentIndices", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_CollectionGetParentIndices
{
	private static bool FRigUnit_CollectionGetParentIndices_IsValid;

	private static int FRigUnit_CollectionGetParentIndices_StructSize;

	public FRigUnit_CollectionGetParentIndices Copy()
	{
		return this;
	}

	public static FRigUnit_CollectionGetParentIndices FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_CollectionGetParentIndices(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_CollectionGetParentIndices value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_CollectionGetParentIndices FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_CollectionGetParentIndices(nativeBuffer + arrayIndex * FRigUnit_CollectionGetParentIndices_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_CollectionGetParentIndices value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_CollectionGetParentIndices_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_CollectionGetParentIndices_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_CollectionGetParentIndices");
		}
	}

	public FRigUnit_CollectionGetParentIndices(IntPtr nativeStruct)
	{
		if (!FRigUnit_CollectionGetParentIndices_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_CollectionGetParentIndices");
		}
	}

	static FRigUnit_CollectionGetParentIndices()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_CollectionGetParentIndices)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_CollectionGetParentIndices));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_CollectionGetParentIndices");
		FRigUnit_CollectionGetParentIndices_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_CollectionGetParentIndices_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_CollectionGetParentIndices", FRigUnit_CollectionGetParentIndices_IsValid);
	}
}
