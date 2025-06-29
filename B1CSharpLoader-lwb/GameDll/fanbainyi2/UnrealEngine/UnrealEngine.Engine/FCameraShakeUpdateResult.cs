using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.CameraShakeUpdateResult", "Engine", UnrealModuleType.Engine)]
public struct FCameraShakeUpdateResult
{
	private static bool FCameraShakeUpdateResult_IsValid;

	private static int FCameraShakeUpdateResult_StructSize;

	public FCameraShakeUpdateResult Copy()
	{
		return this;
	}

	public static FCameraShakeUpdateResult FromNative(IntPtr nativeBuffer)
	{
		return new FCameraShakeUpdateResult(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCameraShakeUpdateResult value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCameraShakeUpdateResult FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCameraShakeUpdateResult(nativeBuffer + arrayIndex * FCameraShakeUpdateResult_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCameraShakeUpdateResult value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCameraShakeUpdateResult_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCameraShakeUpdateResult_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.CameraShakeUpdateResult");
		}
	}

	public FCameraShakeUpdateResult(IntPtr nativeStruct)
	{
		if (!FCameraShakeUpdateResult_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.CameraShakeUpdateResult");
		}
	}

	static FCameraShakeUpdateResult()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCameraShakeUpdateResult)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCameraShakeUpdateResult));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.CameraShakeUpdateResult");
		FCameraShakeUpdateResult_StructSize = NativeReflection.GetStructSize(intPtr);
		FCameraShakeUpdateResult_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.CameraShakeUpdateResult", FCameraShakeUpdateResult_IsValid);
	}
}
