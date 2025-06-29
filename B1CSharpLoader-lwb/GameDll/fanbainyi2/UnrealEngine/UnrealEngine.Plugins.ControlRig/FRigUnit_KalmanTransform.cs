using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_KalmanTransform", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_KalmanTransform
{
	private static bool FRigUnit_KalmanTransform_IsValid;

	private static int FRigUnit_KalmanTransform_StructSize;

	public FRigUnit_KalmanTransform Copy()
	{
		return this;
	}

	public static FRigUnit_KalmanTransform FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_KalmanTransform(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_KalmanTransform value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_KalmanTransform FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_KalmanTransform(nativeBuffer + arrayIndex * FRigUnit_KalmanTransform_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_KalmanTransform value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_KalmanTransform_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_KalmanTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_KalmanTransform");
		}
	}

	public FRigUnit_KalmanTransform(IntPtr nativeStruct)
	{
		if (!FRigUnit_KalmanTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_KalmanTransform");
		}
	}

	static FRigUnit_KalmanTransform()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_KalmanTransform)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_KalmanTransform));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_KalmanTransform");
		FRigUnit_KalmanTransform_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_KalmanTransform_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_KalmanTransform", FRigUnit_KalmanTransform_IsValid);
	}
}
