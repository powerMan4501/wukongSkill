using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.MediaUtils;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/MediaUtils.MediaPlayerTrackOptions", "MediaUtils", UnrealModuleType.Engine)]
public struct FMediaPlayerTrackOptions
{
	private static bool Audio_IsValid;

	private static int Audio_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/MediaUtils.MediaPlayerTrackOptions:Audio")]
	public int Audio;

	private static bool Caption_IsValid;

	private static int Caption_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/MediaUtils.MediaPlayerTrackOptions:Caption")]
	public int Caption;

	private static bool Metadata_IsValid;

	private static int Metadata_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/MediaUtils.MediaPlayerTrackOptions:Metadata")]
	public int Metadata;

	private static bool Script_IsValid;

	private static int Script_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/MediaUtils.MediaPlayerTrackOptions:Script")]
	public int Script;

	private static bool Subtitle_IsValid;

	private static int Subtitle_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/MediaUtils.MediaPlayerTrackOptions:Subtitle")]
	public int Subtitle;

	private static bool Text_IsValid;

	private static int Text_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/MediaUtils.MediaPlayerTrackOptions:Text")]
	public int Text;

	private static bool Video_IsValid;

	private static int Video_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/MediaUtils.MediaPlayerTrackOptions:Video")]
	public int Video;

	private static bool FMediaPlayerTrackOptions_IsValid;

	private static int FMediaPlayerTrackOptions_StructSize;

	public FMediaPlayerTrackOptions Copy()
	{
		return this;
	}

	public static FMediaPlayerTrackOptions FromNative(IntPtr nativeBuffer)
	{
		return new FMediaPlayerTrackOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMediaPlayerTrackOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMediaPlayerTrackOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMediaPlayerTrackOptions(nativeBuffer + arrayIndex * FMediaPlayerTrackOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMediaPlayerTrackOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FMediaPlayerTrackOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FMediaPlayerTrackOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MediaUtils.MediaPlayerTrackOptions");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Audio_Offset), Audio);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Caption_Offset), Caption);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Metadata_Offset), Metadata);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Script_Offset), Script);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Subtitle_Offset), Subtitle);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Text_Offset), Text);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Video_Offset), Video);
	}

	public FMediaPlayerTrackOptions(IntPtr nativeStruct)
	{
		if (!FMediaPlayerTrackOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MediaUtils.MediaPlayerTrackOptions");
			Audio = 0;
			Caption = 0;
			Metadata = 0;
			Script = 0;
			Subtitle = 0;
			Text = 0;
			Video = 0;
		}
		else
		{
			Audio = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Audio_Offset));
			Caption = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Caption_Offset));
			Metadata = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Metadata_Offset));
			Script = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Script_Offset));
			Subtitle = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Subtitle_Offset));
			Text = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Text_Offset));
			Video = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Video_Offset));
		}
	}

	static FMediaPlayerTrackOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMediaPlayerTrackOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMediaPlayerTrackOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/MediaUtils.MediaPlayerTrackOptions");
		FMediaPlayerTrackOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		Audio_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Audio");
		Audio_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Audio", Classes.FIntProperty);
		Caption_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Caption");
		Caption_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Caption", Classes.FIntProperty);
		Metadata_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Metadata");
		Metadata_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Metadata", Classes.FIntProperty);
		Script_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Script");
		Script_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Script", Classes.FIntProperty);
		Subtitle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Subtitle");
		Subtitle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Subtitle", Classes.FIntProperty);
		Text_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Text");
		Text_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Text", Classes.FIntProperty);
		Video_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Video");
		Video_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Video", Classes.FIntProperty);
		FMediaPlayerTrackOptions_IsValid = intPtr != IntPtr.Zero && Audio_IsValid && Caption_IsValid && Metadata_IsValid && Script_IsValid && Subtitle_IsValid && Text_IsValid && Video_IsValid;
		NativeReflection.LogStructIsValid("/Script/MediaUtils.MediaPlayerTrackOptions", FMediaPlayerTrackOptions_IsValid);
	}
}
