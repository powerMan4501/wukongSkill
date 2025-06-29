using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_TwoBoneIKFK", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_TwoBoneIKFK
{
	private static bool FRigUnit_TwoBoneIKFK_IsValid;

	private static int FRigUnit_TwoBoneIKFK_StructSize;

	public FRigUnit_TwoBoneIKFK Copy()
	{
		return this;
	}

	public static FRigUnit_TwoBoneIKFK FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_TwoBoneIKFK(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_TwoBoneIKFK value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_TwoBoneIKFK FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_TwoBoneIKFK(nativeBuffer + arrayIndex * FRigUnit_TwoBoneIKFK_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_TwoBoneIKFK value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_TwoBoneIKFK_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_TwoBoneIKFK_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_TwoBoneIKFK");
		}
	}

	public FRigUnit_TwoBoneIKFK(IntPtr nativeStruct)
	{
		if (!FRigUnit_TwoBoneIKFK_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_TwoBoneIKFK");
		}
	}

	static FRigUnit_TwoBoneIKFK()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_TwoBoneIKFK)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_TwoBoneIKFK));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_TwoBoneIKFK");
		FRigUnit_TwoBoneIKFK_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_TwoBoneIKFK_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_TwoBoneIKFK", FRigUnit_TwoBoneIKFK_IsValid);
	}
}
