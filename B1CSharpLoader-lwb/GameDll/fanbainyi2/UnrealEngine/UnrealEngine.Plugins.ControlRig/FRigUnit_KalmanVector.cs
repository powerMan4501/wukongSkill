using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_KalmanVector", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_KalmanVector
{
	private static bool FRigUnit_KalmanVector_IsValid;

	private static int FRigUnit_KalmanVector_StructSize;

	public FRigUnit_KalmanVector Copy()
	{
		return this;
	}

	public static FRigUnit_KalmanVector FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_KalmanVector(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_KalmanVector value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_KalmanVector FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_KalmanVector(nativeBuffer + arrayIndex * FRigUnit_KalmanVector_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_KalmanVector value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_KalmanVector_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_KalmanVector_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_KalmanVector");
		}
	}

	public FRigUnit_KalmanVector(IntPtr nativeStruct)
	{
		if (!FRigUnit_KalmanVector_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_KalmanVector");
		}
	}

	static FRigUnit_KalmanVector()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_KalmanVector)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_KalmanVector));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_KalmanVector");
		FRigUnit_KalmanVector_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_KalmanVector_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_KalmanVector", FRigUnit_KalmanVector_IsValid);
	}
}
