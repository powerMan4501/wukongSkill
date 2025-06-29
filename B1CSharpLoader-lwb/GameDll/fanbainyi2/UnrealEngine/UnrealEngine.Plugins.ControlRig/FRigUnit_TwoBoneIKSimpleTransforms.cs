using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_TwoBoneIKSimpleTransforms", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_TwoBoneIKSimpleTransforms
{
	private static bool FRigUnit_TwoBoneIKSimpleTransforms_IsValid;

	private static int FRigUnit_TwoBoneIKSimpleTransforms_StructSize;

	public FRigUnit_TwoBoneIKSimpleTransforms Copy()
	{
		return this;
	}

	public static FRigUnit_TwoBoneIKSimpleTransforms FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_TwoBoneIKSimpleTransforms(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_TwoBoneIKSimpleTransforms value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_TwoBoneIKSimpleTransforms FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_TwoBoneIKSimpleTransforms(nativeBuffer + arrayIndex * FRigUnit_TwoBoneIKSimpleTransforms_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_TwoBoneIKSimpleTransforms value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_TwoBoneIKSimpleTransforms_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_TwoBoneIKSimpleTransforms_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_TwoBoneIKSimpleTransforms");
		}
	}

	public FRigUnit_TwoBoneIKSimpleTransforms(IntPtr nativeStruct)
	{
		if (!FRigUnit_TwoBoneIKSimpleTransforms_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_TwoBoneIKSimpleTransforms");
		}
	}

	static FRigUnit_TwoBoneIKSimpleTransforms()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_TwoBoneIKSimpleTransforms)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_TwoBoneIKSimpleTransforms));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_TwoBoneIKSimpleTransforms");
		FRigUnit_TwoBoneIKSimpleTransforms_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_TwoBoneIKSimpleTransforms_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_TwoBoneIKSimpleTransforms", FRigUnit_TwoBoneIKSimpleTransforms_IsValid);
	}
}
