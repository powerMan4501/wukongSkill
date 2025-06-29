using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_ItemBase", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_ItemBase
{
	private static bool FRigUnit_ItemBase_IsValid;

	private static int FRigUnit_ItemBase_StructSize;

	public FRigUnit_ItemBase Copy()
	{
		return this;
	}

	public static FRigUnit_ItemBase FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_ItemBase(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_ItemBase value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_ItemBase FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_ItemBase(nativeBuffer + arrayIndex * FRigUnit_ItemBase_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_ItemBase value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_ItemBase_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_ItemBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ItemBase");
		}
	}

	public FRigUnit_ItemBase(IntPtr nativeStruct)
	{
		if (!FRigUnit_ItemBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ItemBase");
		}
	}

	static FRigUnit_ItemBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_ItemBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_ItemBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_ItemBase");
		FRigUnit_ItemBase_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_ItemBase_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_ItemBase", FRigUnit_ItemBase_IsValid);
	}
}
