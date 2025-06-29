using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_CCDIK", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_CCDIK
{
	private static bool FRigUnit_CCDIK_IsValid;

	private static int FRigUnit_CCDIK_StructSize;

	public FRigUnit_CCDIK Copy()
	{
		return this;
	}

	public static FRigUnit_CCDIK FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_CCDIK(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_CCDIK value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_CCDIK FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_CCDIK(nativeBuffer + arrayIndex * FRigUnit_CCDIK_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_CCDIK value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_CCDIK_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_CCDIK_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_CCDIK");
		}
	}

	public FRigUnit_CCDIK(IntPtr nativeStruct)
	{
		if (!FRigUnit_CCDIK_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_CCDIK");
		}
	}

	static FRigUnit_CCDIK()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_CCDIK)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_CCDIK));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_CCDIK");
		FRigUnit_CCDIK_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_CCDIK_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_CCDIK", FRigUnit_CCDIK_IsValid);
	}
}
