using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_TwoBoneIKSimpleVectors", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_TwoBoneIKSimpleVectors
{
	private static bool FRigUnit_TwoBoneIKSimpleVectors_IsValid;

	private static int FRigUnit_TwoBoneIKSimpleVectors_StructSize;

	public FRigUnit_TwoBoneIKSimpleVectors Copy()
	{
		return this;
	}

	public static FRigUnit_TwoBoneIKSimpleVectors FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_TwoBoneIKSimpleVectors(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_TwoBoneIKSimpleVectors value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_TwoBoneIKSimpleVectors FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_TwoBoneIKSimpleVectors(nativeBuffer + arrayIndex * FRigUnit_TwoBoneIKSimpleVectors_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_TwoBoneIKSimpleVectors value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_TwoBoneIKSimpleVectors_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_TwoBoneIKSimpleVectors_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_TwoBoneIKSimpleVectors");
		}
	}

	public FRigUnit_TwoBoneIKSimpleVectors(IntPtr nativeStruct)
	{
		if (!FRigUnit_TwoBoneIKSimpleVectors_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_TwoBoneIKSimpleVectors");
		}
	}

	static FRigUnit_TwoBoneIKSimpleVectors()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_TwoBoneIKSimpleVectors)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_TwoBoneIKSimpleVectors));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_TwoBoneIKSimpleVectors");
		FRigUnit_TwoBoneIKSimpleVectors_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_TwoBoneIKSimpleVectors_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_TwoBoneIKSimpleVectors", FRigUnit_TwoBoneIKSimpleVectors_IsValid);
	}
}
