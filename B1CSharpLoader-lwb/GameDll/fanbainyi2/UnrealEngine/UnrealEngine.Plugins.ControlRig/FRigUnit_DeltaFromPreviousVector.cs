using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_DeltaFromPreviousVector", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_DeltaFromPreviousVector
{
	private static bool FRigUnit_DeltaFromPreviousVector_IsValid;

	private static int FRigUnit_DeltaFromPreviousVector_StructSize;

	public FRigUnit_DeltaFromPreviousVector Copy()
	{
		return this;
	}

	public static FRigUnit_DeltaFromPreviousVector FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_DeltaFromPreviousVector(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_DeltaFromPreviousVector value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_DeltaFromPreviousVector FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_DeltaFromPreviousVector(nativeBuffer + arrayIndex * FRigUnit_DeltaFromPreviousVector_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_DeltaFromPreviousVector value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_DeltaFromPreviousVector_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_DeltaFromPreviousVector_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DeltaFromPreviousVector");
		}
	}

	public FRigUnit_DeltaFromPreviousVector(IntPtr nativeStruct)
	{
		if (!FRigUnit_DeltaFromPreviousVector_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DeltaFromPreviousVector");
		}
	}

	static FRigUnit_DeltaFromPreviousVector()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_DeltaFromPreviousVector)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_DeltaFromPreviousVector));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_DeltaFromPreviousVector");
		FRigUnit_DeltaFromPreviousVector_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_DeltaFromPreviousVector_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_DeltaFromPreviousVector", FRigUnit_DeltaFromPreviousVector_IsValid);
	}
}
