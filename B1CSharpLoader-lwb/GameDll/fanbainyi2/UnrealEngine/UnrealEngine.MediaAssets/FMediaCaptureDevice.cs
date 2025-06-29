using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.MediaAssets;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/MediaAssets.MediaCaptureDevice", "MediaAssets", UnrealModuleType.Engine)]
public struct FMediaCaptureDevice
{
	private static bool DisplayName_IsValid;

	private static int DisplayName_Offset;

	[UProperty(Flags = (PropFlags)4503599627378708uL)]
	[UMetaPath("/Script/MediaAssets.MediaCaptureDevice:DisplayName")]
	public FText DisplayName;

	private static bool Url_IsValid;

	private static int Url_Offset;

	[UProperty(Flags = (PropFlags)6755399441064468uL)]
	[UMetaPath("/Script/MediaAssets.MediaCaptureDevice:Url")]
	public string Url;

	private static bool FMediaCaptureDevice_IsValid;

	private static int FMediaCaptureDevice_StructSize;

	public FMediaCaptureDevice Copy()
	{
		return this;
	}

	public static FMediaCaptureDevice FromNative(IntPtr nativeBuffer)
	{
		return new FMediaCaptureDevice(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMediaCaptureDevice value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMediaCaptureDevice FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMediaCaptureDevice(nativeBuffer + arrayIndex * FMediaCaptureDevice_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMediaCaptureDevice value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FMediaCaptureDevice_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FMediaCaptureDevice_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MediaAssets.MediaCaptureDevice");
			return;
		}
		FTextMarshaler.ToNative(IntPtr.Add(nativeStruct, DisplayName_Offset), DisplayName);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Url_Offset), Url);
	}

	public FMediaCaptureDevice(IntPtr nativeStruct)
	{
		if (!FMediaCaptureDevice_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MediaAssets.MediaCaptureDevice");
			DisplayName = null;
			Url = FStringMarshaler.DefaultString;
		}
		else
		{
			DisplayName = FTextMarshaler.FromNative(IntPtr.Add(nativeStruct, DisplayName_Offset));
			Url = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Url_Offset));
		}
	}

	static FMediaCaptureDevice()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMediaCaptureDevice)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMediaCaptureDevice));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/MediaAssets.MediaCaptureDevice");
		FMediaCaptureDevice_StructSize = NativeReflection.GetStructSize(intPtr);
		DisplayName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DisplayName");
		DisplayName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DisplayName", Classes.FTextProperty);
		Url_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Url");
		Url_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Url", Classes.FStrProperty);
		FMediaCaptureDevice_IsValid = intPtr != IntPtr.Zero && DisplayName_IsValid && Url_IsValid;
		NativeReflection.LogStructIsValid("/Script/MediaAssets.MediaCaptureDevice", FMediaCaptureDevice_IsValid);
	}
}
