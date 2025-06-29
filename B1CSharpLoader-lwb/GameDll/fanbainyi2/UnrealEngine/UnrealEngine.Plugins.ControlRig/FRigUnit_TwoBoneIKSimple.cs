using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_TwoBoneIKSimple", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_TwoBoneIKSimple
{
	private static bool FRigUnit_TwoBoneIKSimple_IsValid;

	private static int FRigUnit_TwoBoneIKSimple_StructSize;

	public FRigUnit_TwoBoneIKSimple Copy()
	{
		return this;
	}

	public static FRigUnit_TwoBoneIKSimple FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_TwoBoneIKSimple(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_TwoBoneIKSimple value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_TwoBoneIKSimple FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_TwoBoneIKSimple(nativeBuffer + arrayIndex * FRigUnit_TwoBoneIKSimple_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_TwoBoneIKSimple value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_TwoBoneIKSimple_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_TwoBoneIKSimple_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_TwoBoneIKSimple");
		}
	}

	public FRigUnit_TwoBoneIKSimple(IntPtr nativeStruct)
	{
		if (!FRigUnit_TwoBoneIKSimple_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_TwoBoneIKSimple");
		}
	}

	static FRigUnit_TwoBoneIKSimple()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_TwoBoneIKSimple)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_TwoBoneIKSimple));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_TwoBoneIKSimple");
		FRigUnit_TwoBoneIKSimple_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_TwoBoneIKSimple_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_TwoBoneIKSimple", FRigUnit_TwoBoneIKSimple_IsValid);
	}
}
