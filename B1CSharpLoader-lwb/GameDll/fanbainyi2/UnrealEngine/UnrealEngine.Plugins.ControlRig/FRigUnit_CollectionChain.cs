using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_CollectionChain", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_CollectionChain
{
	private static bool FRigUnit_CollectionChain_IsValid;

	private static int FRigUnit_CollectionChain_StructSize;

	public FRigUnit_CollectionChain Copy()
	{
		return this;
	}

	public static FRigUnit_CollectionChain FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_CollectionChain(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_CollectionChain value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_CollectionChain FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_CollectionChain(nativeBuffer + arrayIndex * FRigUnit_CollectionChain_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_CollectionChain value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_CollectionChain_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_CollectionChain_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_CollectionChain");
		}
	}

	public FRigUnit_CollectionChain(IntPtr nativeStruct)
	{
		if (!FRigUnit_CollectionChain_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_CollectionChain");
		}
	}

	static FRigUnit_CollectionChain()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_CollectionChain)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_CollectionChain));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_CollectionChain");
		FRigUnit_CollectionChain_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_CollectionChain_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_CollectionChain", FRigUnit_CollectionChain_IsValid);
	}
}
