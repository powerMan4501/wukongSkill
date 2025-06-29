using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.MediaUtils;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/MediaUtils.MediaPlayerOptions", "MediaUtils", UnrealModuleType.Engine)]
public struct FMediaPlayerOptions
{
	private static bool Tracks_IsValid;

	private static int Tracks_Offset;

	[UProperty(Flags = (PropFlags)4503668346847236uL)]
	[UMetaPath("/Script/MediaUtils.MediaPlayerOptions:Tracks")]
	public FMediaPlayerTrackOptions Tracks;

	private static bool SeekTime_IsValid;

	private static int SeekTime_Offset;

	[UProperty(Flags = (PropFlags)6755468160532996uL)]
	[UMetaPath("/Script/MediaUtils.MediaPlayerOptions:SeekTime")]
	public FTimespan SeekTime;

	private static bool PlayOnOpen_IsValid;

	private static FFieldAddress PlayOnOpen_PropertyAddress;

	private static int PlayOnOpen_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/MediaUtils.MediaPlayerOptions:PlayOnOpen")]
	public EMediaPlayerOptionBooleanOverride PlayOnOpen;

	private static bool Loop_IsValid;

	private static FFieldAddress Loop_PropertyAddress;

	private static int Loop_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/MediaUtils.MediaPlayerOptions:Loop")]
	public EMediaPlayerOptionBooleanOverride Loop;

	private static bool FMediaPlayerOptions_IsValid;

	private static int FMediaPlayerOptions_StructSize;

	public FMediaPlayerOptions Copy()
	{
		return this;
	}

	public static FMediaPlayerOptions FromNative(IntPtr nativeBuffer)
	{
		return new FMediaPlayerOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMediaPlayerOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMediaPlayerOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMediaPlayerOptions(nativeBuffer + arrayIndex * FMediaPlayerOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMediaPlayerOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FMediaPlayerOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FMediaPlayerOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MediaUtils.MediaPlayerOptions");
			return;
		}
		FMediaPlayerTrackOptions.ToNative(IntPtr.Add(nativeStruct, Tracks_Offset), Tracks);
		FTimespan.ToNative(IntPtr.Add(nativeStruct, SeekTime_Offset), SeekTime);
		EnumMarshaler<EMediaPlayerOptionBooleanOverride>.ToNative(IntPtr.Add(nativeStruct, PlayOnOpen_Offset), 0, PlayOnOpen_PropertyAddress.Address, PlayOnOpen);
		EnumMarshaler<EMediaPlayerOptionBooleanOverride>.ToNative(IntPtr.Add(nativeStruct, Loop_Offset), 0, Loop_PropertyAddress.Address, Loop);
	}

	public FMediaPlayerOptions(IntPtr nativeStruct)
	{
		if (!FMediaPlayerOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MediaUtils.MediaPlayerOptions");
			Tracks = default(FMediaPlayerTrackOptions);
			SeekTime = default(FTimespan);
			PlayOnOpen = EMediaPlayerOptionBooleanOverride.UseMediaPlayerSetting;
			Loop = EMediaPlayerOptionBooleanOverride.UseMediaPlayerSetting;
		}
		else
		{
			Tracks = FMediaPlayerTrackOptions.FromNative(IntPtr.Add(nativeStruct, Tracks_Offset));
			SeekTime = FTimespan.FromNative(IntPtr.Add(nativeStruct, SeekTime_Offset));
			PlayOnOpen = EnumMarshaler<EMediaPlayerOptionBooleanOverride>.FromNative(IntPtr.Add(nativeStruct, PlayOnOpen_Offset), 0, PlayOnOpen_PropertyAddress.Address);
			Loop = EnumMarshaler<EMediaPlayerOptionBooleanOverride>.FromNative(IntPtr.Add(nativeStruct, Loop_Offset), 0, Loop_PropertyAddress.Address);
		}
	}

	static FMediaPlayerOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMediaPlayerOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMediaPlayerOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/MediaUtils.MediaPlayerOptions");
		FMediaPlayerOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		Tracks_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Tracks");
		Tracks_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Tracks", Classes.FStructProperty);
		SeekTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SeekTime");
		SeekTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SeekTime", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayOnOpen_PropertyAddress, intPtr, "PlayOnOpen");
		PlayOnOpen_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PlayOnOpen");
		PlayOnOpen_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PlayOnOpen", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref Loop_PropertyAddress, intPtr, "Loop");
		Loop_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Loop");
		Loop_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Loop", Classes.FEnumProperty);
		FMediaPlayerOptions_IsValid = intPtr != IntPtr.Zero && Tracks_IsValid && SeekTime_IsValid && PlayOnOpen_IsValid && Loop_IsValid;
		NativeReflection.LogStructIsValid("/Script/MediaUtils.MediaPlayerOptions", FMediaPlayerOptions_IsValid);
	}
}
