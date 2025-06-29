using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit
{
	private static bool FRigUnit_IsValid;

	private static int FRigUnit_StructSize;

	public FRigUnit Copy()
	{
		return this;
	}

	public static FRigUnit FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit(nativeBuffer + arrayIndex * FRigUnit_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit");
		}
	}

	public FRigUnit(IntPtr nativeStruct)
	{
		if (!FRigUnit_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit");
		}
	}

	static FRigUnit()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit");
		FRigUnit_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit", FRigUnit_IsValid);
	}
}
