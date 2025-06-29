using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_CollectionChildren", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_CollectionChildren
{
	private static bool FRigUnit_CollectionChildren_IsValid;

	private static int FRigUnit_CollectionChildren_StructSize;

	public FRigUnit_CollectionChildren Copy()
	{
		return this;
	}

	public static FRigUnit_CollectionChildren FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_CollectionChildren(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_CollectionChildren value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_CollectionChildren FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_CollectionChildren(nativeBuffer + arrayIndex * FRigUnit_CollectionChildren_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_CollectionChildren value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_CollectionChildren_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_CollectionChildren_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_CollectionChildren");
		}
	}

	public FRigUnit_CollectionChildren(IntPtr nativeStruct)
	{
		if (!FRigUnit_CollectionChildren_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_CollectionChildren");
		}
	}

	static FRigUnit_CollectionChildren()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_CollectionChildren)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_CollectionChildren));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_CollectionChildren");
		FRigUnit_CollectionChildren_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_CollectionChildren_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_CollectionChildren", FRigUnit_CollectionChildren_IsValid);
	}
}
