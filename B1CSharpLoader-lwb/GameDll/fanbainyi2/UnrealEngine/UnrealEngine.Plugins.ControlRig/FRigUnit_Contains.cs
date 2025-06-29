using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_Contains", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_Contains
{
	private static bool FRigUnit_Contains_IsValid;

	private static int FRigUnit_Contains_StructSize;

	public FRigUnit_Contains Copy()
	{
		return this;
	}

	public static FRigUnit_Contains FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_Contains(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_Contains value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_Contains FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_Contains(nativeBuffer + arrayIndex * FRigUnit_Contains_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_Contains value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_Contains_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_Contains_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_Contains");
		}
	}

	public FRigUnit_Contains(IntPtr nativeStruct)
	{
		if (!FRigUnit_Contains_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_Contains");
		}
	}

	static FRigUnit_Contains()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_Contains)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_Contains));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_Contains");
		FRigUnit_Contains_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_Contains_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_Contains", FRigUnit_Contains_IsValid);
	}
}
