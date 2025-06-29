using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_TimeOffsetVector", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_TimeOffsetVector
{
	private static bool FRigUnit_TimeOffsetVector_IsValid;

	private static int FRigUnit_TimeOffsetVector_StructSize;

	public FRigUnit_TimeOffsetVector Copy()
	{
		return this;
	}

	public static FRigUnit_TimeOffsetVector FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_TimeOffsetVector(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_TimeOffsetVector value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_TimeOffsetVector FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_TimeOffsetVector(nativeBuffer + arrayIndex * FRigUnit_TimeOffsetVector_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_TimeOffsetVector value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_TimeOffsetVector_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_TimeOffsetVector_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_TimeOffsetVector");
		}
	}

	public FRigUnit_TimeOffsetVector(IntPtr nativeStruct)
	{
		if (!FRigUnit_TimeOffsetVector_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_TimeOffsetVector");
		}
	}

	static FRigUnit_TimeOffsetVector()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_TimeOffsetVector)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_TimeOffsetVector));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_TimeOffsetVector");
		FRigUnit_TimeOffsetVector_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_TimeOffsetVector_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_TimeOffsetVector", FRigUnit_TimeOffsetVector_IsValid);
	}
}
