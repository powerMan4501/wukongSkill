using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_SpringInterpVector", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_SpringInterpVector
{
	private static bool FRigUnit_SpringInterpVector_IsValid;

	private static int FRigUnit_SpringInterpVector_StructSize;

	public FRigUnit_SpringInterpVector Copy()
	{
		return this;
	}

	public static FRigUnit_SpringInterpVector FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_SpringInterpVector(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_SpringInterpVector value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_SpringInterpVector FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_SpringInterpVector(nativeBuffer + arrayIndex * FRigUnit_SpringInterpVector_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_SpringInterpVector value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_SpringInterpVector_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_SpringInterpVector_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SpringInterpVector");
		}
	}

	public FRigUnit_SpringInterpVector(IntPtr nativeStruct)
	{
		if (!FRigUnit_SpringInterpVector_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SpringInterpVector");
		}
	}

	static FRigUnit_SpringInterpVector()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_SpringInterpVector)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_SpringInterpVector));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_SpringInterpVector");
		FRigUnit_SpringInterpVector_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_SpringInterpVector_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_SpringInterpVector", FRigUnit_SpringInterpVector_IsValid);
	}
}
