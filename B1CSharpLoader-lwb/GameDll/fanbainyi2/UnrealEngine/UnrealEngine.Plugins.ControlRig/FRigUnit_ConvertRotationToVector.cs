using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_ConvertRotationToVector", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_ConvertRotationToVector
{
	private static bool FRigUnit_ConvertRotationToVector_IsValid;

	private static int FRigUnit_ConvertRotationToVector_StructSize;

	public FRigUnit_ConvertRotationToVector Copy()
	{
		return this;
	}

	public static FRigUnit_ConvertRotationToVector FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_ConvertRotationToVector(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_ConvertRotationToVector value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_ConvertRotationToVector FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_ConvertRotationToVector(nativeBuffer + arrayIndex * FRigUnit_ConvertRotationToVector_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_ConvertRotationToVector value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_ConvertRotationToVector_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_ConvertRotationToVector_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ConvertRotationToVector");
		}
	}

	public FRigUnit_ConvertRotationToVector(IntPtr nativeStruct)
	{
		if (!FRigUnit_ConvertRotationToVector_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ConvertRotationToVector");
		}
	}

	static FRigUnit_ConvertRotationToVector()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_ConvertRotationToVector)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_ConvertRotationToVector));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_ConvertRotationToVector");
		FRigUnit_ConvertRotationToVector_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_ConvertRotationToVector_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_ConvertRotationToVector", FRigUnit_ConvertRotationToVector_IsValid);
	}
}
