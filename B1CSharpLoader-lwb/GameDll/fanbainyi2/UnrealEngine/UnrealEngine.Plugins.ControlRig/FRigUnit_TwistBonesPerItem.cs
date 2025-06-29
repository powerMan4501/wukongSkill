using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_TwistBonesPerItem", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_TwistBonesPerItem
{
	private static bool FRigUnit_TwistBonesPerItem_IsValid;

	private static int FRigUnit_TwistBonesPerItem_StructSize;

	public FRigUnit_TwistBonesPerItem Copy()
	{
		return this;
	}

	public static FRigUnit_TwistBonesPerItem FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_TwistBonesPerItem(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_TwistBonesPerItem value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_TwistBonesPerItem FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_TwistBonesPerItem(nativeBuffer + arrayIndex * FRigUnit_TwistBonesPerItem_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_TwistBonesPerItem value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_TwistBonesPerItem_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_TwistBonesPerItem_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_TwistBonesPerItem");
		}
	}

	public FRigUnit_TwistBonesPerItem(IntPtr nativeStruct)
	{
		if (!FRigUnit_TwistBonesPerItem_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_TwistBonesPerItem");
		}
	}

	static FRigUnit_TwistBonesPerItem()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_TwistBonesPerItem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_TwistBonesPerItem));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_TwistBonesPerItem");
		FRigUnit_TwistBonesPerItem_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_TwistBonesPerItem_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_TwistBonesPerItem", FRigUnit_TwistBonesPerItem_IsValid);
	}
}
