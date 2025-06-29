using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GameplayCameras;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/GameplayCameras.CameraAnimationHandle", "GameplayCameras", UnrealModuleType.EnginePlugin)]
public struct FCameraAnimationHandle
{
	private static bool FCameraAnimationHandle_IsValid;

	private static int FCameraAnimationHandle_StructSize;

	public FCameraAnimationHandle Copy()
	{
		return this;
	}

	public static FCameraAnimationHandle FromNative(IntPtr nativeBuffer)
	{
		return new FCameraAnimationHandle(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCameraAnimationHandle value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCameraAnimationHandle FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCameraAnimationHandle(nativeBuffer + arrayIndex * FCameraAnimationHandle_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCameraAnimationHandle value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCameraAnimationHandle_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCameraAnimationHandle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GameplayCameras.CameraAnimationHandle");
		}
	}

	public FCameraAnimationHandle(IntPtr nativeStruct)
	{
		if (!FCameraAnimationHandle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GameplayCameras.CameraAnimationHandle");
		}
	}

	static FCameraAnimationHandle()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCameraAnimationHandle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCameraAnimationHandle));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GameplayCameras.CameraAnimationHandle");
		FCameraAnimationHandle_StructSize = NativeReflection.GetStructSize(intPtr);
		FCameraAnimationHandle_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/GameplayCameras.CameraAnimationHandle", FCameraAnimationHandle_IsValid);
	}
}
