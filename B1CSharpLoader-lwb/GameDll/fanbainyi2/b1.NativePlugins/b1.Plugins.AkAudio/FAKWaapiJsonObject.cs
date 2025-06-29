using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AkAudio.AKWaapiJsonObject", "AkAudio", UnrealModuleType.GamePlugin)]
public struct FAKWaapiJsonObject
{
	private static bool FAKWaapiJsonObject_IsValid;

	private static int FAKWaapiJsonObject_StructSize;

	public FAKWaapiJsonObject Copy()
	{
		return this;
	}

	public static FAKWaapiJsonObject FromNative(IntPtr nativeBuffer)
	{
		return new FAKWaapiJsonObject(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAKWaapiJsonObject value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAKWaapiJsonObject FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAKWaapiJsonObject(nativeBuffer + arrayIndex * FAKWaapiJsonObject_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAKWaapiJsonObject value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAKWaapiJsonObject_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAKWaapiJsonObject_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AkAudio.AKWaapiJsonObject");
		}
	}

	public FAKWaapiJsonObject(IntPtr nativeStruct)
	{
		if (!FAKWaapiJsonObject_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AkAudio.AKWaapiJsonObject");
		}
	}

	static FAKWaapiJsonObject()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAKWaapiJsonObject)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAKWaapiJsonObject));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AkAudio.AKWaapiJsonObject");
		FAKWaapiJsonObject_StructSize = NativeReflection.GetStructSize(intPtr);
		FAKWaapiJsonObject_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/AkAudio.AKWaapiJsonObject", FAKWaapiJsonObject_IsValid);
	}
}
