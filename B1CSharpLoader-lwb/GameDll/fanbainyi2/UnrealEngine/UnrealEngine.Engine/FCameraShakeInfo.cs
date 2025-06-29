using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.CameraShakeInfo", "Engine", UnrealModuleType.Engine)]
public struct FCameraShakeInfo
{
	private static bool FCameraShakeInfo_IsValid;

	private static int FCameraShakeInfo_StructSize;

	public FCameraShakeInfo Copy()
	{
		return this;
	}

	public static FCameraShakeInfo FromNative(IntPtr nativeBuffer)
	{
		return new FCameraShakeInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCameraShakeInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCameraShakeInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCameraShakeInfo(nativeBuffer + arrayIndex * FCameraShakeInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCameraShakeInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCameraShakeInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCameraShakeInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.CameraShakeInfo");
		}
	}

	public FCameraShakeInfo(IntPtr nativeStruct)
	{
		if (!FCameraShakeInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.CameraShakeInfo");
		}
	}

	static FCameraShakeInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCameraShakeInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCameraShakeInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.CameraShakeInfo");
		FCameraShakeInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		FCameraShakeInfo_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.CameraShakeInfo", FCameraShakeInfo_IsValid);
	}
}
