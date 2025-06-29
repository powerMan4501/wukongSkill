using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_ConvertQuaternionToVector", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_ConvertQuaternionToVector
{
	private static bool FRigUnit_ConvertQuaternionToVector_IsValid;

	private static int FRigUnit_ConvertQuaternionToVector_StructSize;

	public FRigUnit_ConvertQuaternionToVector Copy()
	{
		return this;
	}

	public static FRigUnit_ConvertQuaternionToVector FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_ConvertQuaternionToVector(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_ConvertQuaternionToVector value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_ConvertQuaternionToVector FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_ConvertQuaternionToVector(nativeBuffer + arrayIndex * FRigUnit_ConvertQuaternionToVector_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_ConvertQuaternionToVector value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_ConvertQuaternionToVector_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_ConvertQuaternionToVector_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ConvertQuaternionToVector");
		}
	}

	public FRigUnit_ConvertQuaternionToVector(IntPtr nativeStruct)
	{
		if (!FRigUnit_ConvertQuaternionToVector_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ConvertQuaternionToVector");
		}
	}

	static FRigUnit_ConvertQuaternionToVector()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_ConvertQuaternionToVector)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_ConvertQuaternionToVector));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_ConvertQuaternionToVector");
		FRigUnit_ConvertQuaternionToVector_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_ConvertQuaternionToVector_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_ConvertQuaternionToVector", FRigUnit_ConvertQuaternionToVector_IsValid);
	}
}
