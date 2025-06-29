using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.CameraShakeDuration", "Engine", UnrealModuleType.Engine)]
public struct FCameraShakeDuration
{
	private static bool FCameraShakeDuration_IsValid;

	private static int FCameraShakeDuration_StructSize;

	public FCameraShakeDuration Copy()
	{
		return this;
	}

	public static FCameraShakeDuration FromNative(IntPtr nativeBuffer)
	{
		return new FCameraShakeDuration(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCameraShakeDuration value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCameraShakeDuration FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCameraShakeDuration(nativeBuffer + arrayIndex * FCameraShakeDuration_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCameraShakeDuration value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCameraShakeDuration_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCameraShakeDuration_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.CameraShakeDuration");
		}
	}

	public FCameraShakeDuration(IntPtr nativeStruct)
	{
		if (!FCameraShakeDuration_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.CameraShakeDuration");
		}
	}

	static FCameraShakeDuration()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCameraShakeDuration)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCameraShakeDuration));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.CameraShakeDuration");
		FCameraShakeDuration_StructSize = NativeReflection.GetStructSize(intPtr);
		FCameraShakeDuration_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.CameraShakeDuration", FCameraShakeDuration_IsValid);
	}
}
