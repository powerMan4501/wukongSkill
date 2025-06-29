using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_CollectionIntersection", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_CollectionIntersection
{
	private static bool FRigUnit_CollectionIntersection_IsValid;

	private static int FRigUnit_CollectionIntersection_StructSize;

	public FRigUnit_CollectionIntersection Copy()
	{
		return this;
	}

	public static FRigUnit_CollectionIntersection FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_CollectionIntersection(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_CollectionIntersection value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_CollectionIntersection FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_CollectionIntersection(nativeBuffer + arrayIndex * FRigUnit_CollectionIntersection_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_CollectionIntersection value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_CollectionIntersection_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_CollectionIntersection_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_CollectionIntersection");
		}
	}

	public FRigUnit_CollectionIntersection(IntPtr nativeStruct)
	{
		if (!FRigUnit_CollectionIntersection_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_CollectionIntersection");
		}
	}

	static FRigUnit_CollectionIntersection()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_CollectionIntersection)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_CollectionIntersection));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_CollectionIntersection");
		FRigUnit_CollectionIntersection_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_CollectionIntersection_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_CollectionIntersection", FRigUnit_CollectionIntersection_IsValid);
	}
}
