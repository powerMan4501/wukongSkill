using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AkAudio.AkWaapiSubscriptionId", "AkAudio", UnrealModuleType.GamePlugin)]
public struct FAkWaapiSubscriptionId
{
	private static bool FAkWaapiSubscriptionId_IsValid;

	private static int FAkWaapiSubscriptionId_StructSize;

	public FAkWaapiSubscriptionId Copy()
	{
		return this;
	}

	public static FAkWaapiSubscriptionId FromNative(IntPtr nativeBuffer)
	{
		return new FAkWaapiSubscriptionId(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAkWaapiSubscriptionId value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAkWaapiSubscriptionId FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAkWaapiSubscriptionId(nativeBuffer + arrayIndex * FAkWaapiSubscriptionId_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAkWaapiSubscriptionId value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAkWaapiSubscriptionId_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAkWaapiSubscriptionId_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AkAudio.AkWaapiSubscriptionId");
		}
	}

	public FAkWaapiSubscriptionId(IntPtr nativeStruct)
	{
		if (!FAkWaapiSubscriptionId_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AkAudio.AkWaapiSubscriptionId");
		}
	}

	static FAkWaapiSubscriptionId()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAkWaapiSubscriptionId)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAkWaapiSubscriptionId));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AkAudio.AkWaapiSubscriptionId");
		FAkWaapiSubscriptionId_StructSize = NativeReflection.GetStructSize(intPtr);
		FAkWaapiSubscriptionId_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/AkAudio.AkWaapiSubscriptionId", FAkWaapiSubscriptionId_IsValid);
	}
}
