using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_TransformConstraintPerItem", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_TransformConstraintPerItem
{
	private static bool FRigUnit_TransformConstraintPerItem_IsValid;

	private static int FRigUnit_TransformConstraintPerItem_StructSize;

	public FRigUnit_TransformConstraintPerItem Copy()
	{
		return this;
	}

	public static FRigUnit_TransformConstraintPerItem FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_TransformConstraintPerItem(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_TransformConstraintPerItem value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_TransformConstraintPerItem FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_TransformConstraintPerItem(nativeBuffer + arrayIndex * FRigUnit_TransformConstraintPerItem_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_TransformConstraintPerItem value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_TransformConstraintPerItem_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_TransformConstraintPerItem_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_TransformConstraintPerItem");
		}
	}

	public FRigUnit_TransformConstraintPerItem(IntPtr nativeStruct)
	{
		if (!FRigUnit_TransformConstraintPerItem_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_TransformConstraintPerItem");
		}
	}

	static FRigUnit_TransformConstraintPerItem()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_TransformConstraintPerItem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_TransformConstraintPerItem));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_TransformConstraintPerItem");
		FRigUnit_TransformConstraintPerItem_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_TransformConstraintPerItem_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_TransformConstraintPerItem", FRigUnit_TransformConstraintPerItem_IsValid);
	}
}
