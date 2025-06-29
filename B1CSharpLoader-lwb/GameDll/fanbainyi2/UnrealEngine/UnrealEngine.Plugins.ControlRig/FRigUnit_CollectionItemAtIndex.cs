using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_CollectionItemAtIndex", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_CollectionItemAtIndex
{
	private static bool FRigUnit_CollectionItemAtIndex_IsValid;

	private static int FRigUnit_CollectionItemAtIndex_StructSize;

	public FRigUnit_CollectionItemAtIndex Copy()
	{
		return this;
	}

	public static FRigUnit_CollectionItemAtIndex FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_CollectionItemAtIndex(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_CollectionItemAtIndex value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_CollectionItemAtIndex FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_CollectionItemAtIndex(nativeBuffer + arrayIndex * FRigUnit_CollectionItemAtIndex_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_CollectionItemAtIndex value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_CollectionItemAtIndex_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_CollectionItemAtIndex_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_CollectionItemAtIndex");
		}
	}

	public FRigUnit_CollectionItemAtIndex(IntPtr nativeStruct)
	{
		if (!FRigUnit_CollectionItemAtIndex_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_CollectionItemAtIndex");
		}
	}

	static FRigUnit_CollectionItemAtIndex()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_CollectionItemAtIndex)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_CollectionItemAtIndex));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_CollectionItemAtIndex");
		FRigUnit_CollectionItemAtIndex_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_CollectionItemAtIndex_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_CollectionItemAtIndex", FRigUnit_CollectionItemAtIndex_IsValid);
	}
}
