using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_AimItem", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_AimItem
{
	private static bool FRigUnit_AimItem_IsValid;

	private static int FRigUnit_AimItem_StructSize;

	public FRigUnit_AimItem Copy()
	{
		return this;
	}

	public static FRigUnit_AimItem FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_AimItem(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_AimItem value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_AimItem FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_AimItem(nativeBuffer + arrayIndex * FRigUnit_AimItem_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_AimItem value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_AimItem_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_AimItem_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_AimItem");
		}
	}

	public FRigUnit_AimItem(IntPtr nativeStruct)
	{
		if (!FRigUnit_AimItem_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_AimItem");
		}
	}

	static FRigUnit_AimItem()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_AimItem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_AimItem));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_AimItem");
		FRigUnit_AimItem_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_AimItem_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_AimItem", FRigUnit_AimItem_IsValid);
	}
}
