using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AkAudio.AkWaapiUri", "AkAudio", UnrealModuleType.GamePlugin)]
public struct FAkWaapiUri
{
	private static bool Uri_IsValid;

	private static int Uri_Offset;

	[UProperty(Flags = (PropFlags)6755399441056277uL)]
	[UMetaPath("/Script/AkAudio.AkWaapiUri:Uri")]
	public string Uri;

	private static bool FAkWaapiUri_IsValid;

	private static int FAkWaapiUri_StructSize;

	public FAkWaapiUri Copy()
	{
		return this;
	}

	public static FAkWaapiUri FromNative(IntPtr nativeBuffer)
	{
		return new FAkWaapiUri(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAkWaapiUri value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAkWaapiUri FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAkWaapiUri(nativeBuffer + arrayIndex * FAkWaapiUri_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAkWaapiUri value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAkWaapiUri_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAkWaapiUri_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AkAudio.AkWaapiUri");
		}
		else
		{
			FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Uri_Offset), Uri);
		}
	}

	public FAkWaapiUri(IntPtr nativeStruct)
	{
		if (!FAkWaapiUri_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AkAudio.AkWaapiUri");
			Uri = FStringMarshaler.DefaultString;
		}
		else
		{
			Uri = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Uri_Offset));
		}
	}

	static FAkWaapiUri()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAkWaapiUri)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAkWaapiUri));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AkAudio.AkWaapiUri");
		FAkWaapiUri_StructSize = NativeReflection.GetStructSize(intPtr);
		Uri_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Uri");
		Uri_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Uri", Classes.FStrProperty);
		FAkWaapiUri_IsValid = intPtr != IntPtr.Zero && Uri_IsValid;
		NativeReflection.LogStructIsValid("/Script/AkAudio.AkWaapiUri", FAkWaapiUri_IsValid);
	}
}
