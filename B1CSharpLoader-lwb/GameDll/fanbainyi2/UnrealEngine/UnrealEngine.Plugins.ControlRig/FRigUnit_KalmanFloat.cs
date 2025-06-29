using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_KalmanFloat", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_KalmanFloat
{
	private static bool FRigUnit_KalmanFloat_IsValid;

	private static int FRigUnit_KalmanFloat_StructSize;

	public FRigUnit_KalmanFloat Copy()
	{
		return this;
	}

	public static FRigUnit_KalmanFloat FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_KalmanFloat(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_KalmanFloat value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_KalmanFloat FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_KalmanFloat(nativeBuffer + arrayIndex * FRigUnit_KalmanFloat_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_KalmanFloat value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_KalmanFloat_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_KalmanFloat_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_KalmanFloat");
		}
	}

	public FRigUnit_KalmanFloat(IntPtr nativeStruct)
	{
		if (!FRigUnit_KalmanFloat_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_KalmanFloat");
		}
	}

	static FRigUnit_KalmanFloat()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_KalmanFloat)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_KalmanFloat));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_KalmanFloat");
		FRigUnit_KalmanFloat_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_KalmanFloat_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_KalmanFloat", FRigUnit_KalmanFloat_IsValid);
	}
}
