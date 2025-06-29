using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_TwoBoneIKSimplePerItem", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_TwoBoneIKSimplePerItem
{
	private static bool FRigUnit_TwoBoneIKSimplePerItem_IsValid;

	private static int FRigUnit_TwoBoneIKSimplePerItem_StructSize;

	public FRigUnit_TwoBoneIKSimplePerItem Copy()
	{
		return this;
	}

	public static FRigUnit_TwoBoneIKSimplePerItem FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_TwoBoneIKSimplePerItem(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_TwoBoneIKSimplePerItem value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_TwoBoneIKSimplePerItem FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_TwoBoneIKSimplePerItem(nativeBuffer + arrayIndex * FRigUnit_TwoBoneIKSimplePerItem_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_TwoBoneIKSimplePerItem value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_TwoBoneIKSimplePerItem_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_TwoBoneIKSimplePerItem_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_TwoBoneIKSimplePerItem");
		}
	}

	public FRigUnit_TwoBoneIKSimplePerItem(IntPtr nativeStruct)
	{
		if (!FRigUnit_TwoBoneIKSimplePerItem_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_TwoBoneIKSimplePerItem");
		}
	}

	static FRigUnit_TwoBoneIKSimplePerItem()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_TwoBoneIKSimplePerItem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_TwoBoneIKSimplePerItem));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_TwoBoneIKSimplePerItem");
		FRigUnit_TwoBoneIKSimplePerItem_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_TwoBoneIKSimplePerItem_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_TwoBoneIKSimplePerItem", FRigUnit_TwoBoneIKSimplePerItem_IsValid);
	}
}
