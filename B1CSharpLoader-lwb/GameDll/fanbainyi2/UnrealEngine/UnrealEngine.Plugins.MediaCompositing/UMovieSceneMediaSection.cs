using System;
using UnrealEngine.MediaAssets;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MediaCompositing;

[UClass(Flags = (ClassFlags)820510880uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/MediaCompositing.MovieSceneMediaSection", "MediaCompositing", UnrealModuleType.EnginePlugin)]
public class UMovieSceneMediaSection : UMovieSceneSection
{
	private static bool MediaSource_IsValid;

	private static int MediaSource_Offset;

	private static bool Looping_IsValid;

	private static FFieldAddress Looping_PropertyAddress;

	private static int Looping_Offset;

	private static bool StartFrameOffset_IsValid;

	private static int StartFrameOffset_Offset;

	private static bool MediaTexture_IsValid;

	private static int MediaTexture_Offset;

	private static bool MediaSoundComponent_IsValid;

	private static int MediaSoundComponent_Offset;

	private static bool UseExternalMediaPlayer_IsValid;

	private static FFieldAddress UseExternalMediaPlayer_PropertyAddress;

	private static int UseExternalMediaPlayer_Offset;

	private static bool ExternalMediaPlayer_IsValid;

	private static int ExternalMediaPlayer_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/MediaCompositing.MovieSceneMediaSection:MediaSource")]
	public UMediaSource MediaSource
	{
		get
		{
			CheckDestroyed();
			if (!MediaSource_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaCompositing.MovieSceneMediaSection:MediaSource");
				return null;
			}
			return UObjectMarshaler<UMediaSource>.FromNative(IntPtr.Add(base.Address, MediaSource_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MediaSource_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaCompositing.MovieSceneMediaSection:MediaSource");
			}
			else
			{
				UObjectMarshaler<UMediaSource>.ToNative(IntPtr.Add(base.Address, MediaSource_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MediaCompositing.MovieSceneMediaSection:bLooping")]
	public bool Looping
	{
		get
		{
			CheckDestroyed();
			if (!Looping_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaCompositing.MovieSceneMediaSection:bLooping");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Looping_Offset), 0, Looping_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Looping_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaCompositing.MovieSceneMediaSection:bLooping");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Looping_Offset), 0, Looping_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/MediaCompositing.MovieSceneMediaSection:StartFrameOffset")]
	public FFrameNumber StartFrameOffset
	{
		get
		{
			CheckDestroyed();
			if (!StartFrameOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaCompositing.MovieSceneMediaSection:StartFrameOffset");
				return default(FFrameNumber);
			}
			return FFrameNumber.FromNative(IntPtr.Add(base.Address, StartFrameOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StartFrameOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaCompositing.MovieSceneMediaSection:StartFrameOffset");
			}
			else
			{
				FFrameNumber.ToNative(IntPtr.Add(base.Address, StartFrameOffset_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/MediaCompositing.MovieSceneMediaSection:MediaTexture")]
	public UMediaTexture MediaTexture
	{
		get
		{
			CheckDestroyed();
			if (!MediaTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaCompositing.MovieSceneMediaSection:MediaTexture");
				return null;
			}
			return UObjectMarshaler<UMediaTexture>.FromNative(IntPtr.Add(base.Address, MediaTexture_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MediaTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaCompositing.MovieSceneMediaSection:MediaTexture");
			}
			else
			{
				UObjectMarshaler<UMediaTexture>.ToNative(IntPtr.Add(base.Address, MediaTexture_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141641741uL)]
	[UMetaPath("/Script/MediaCompositing.MovieSceneMediaSection:MediaSoundComponent")]
	public UMediaSoundComponent MediaSoundComponent
	{
		get
		{
			CheckDestroyed();
			if (!MediaSoundComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaCompositing.MovieSceneMediaSection:MediaSoundComponent");
				return null;
			}
			return UObjectMarshaler<UMediaSoundComponent>.FromNative(IntPtr.Add(base.Address, MediaSoundComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MediaSoundComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaCompositing.MovieSceneMediaSection:MediaSoundComponent");
			}
			else
			{
				UObjectMarshaler<UMediaSoundComponent>.ToNative(IntPtr.Add(base.Address, MediaSoundComponent_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/MediaCompositing.MovieSceneMediaSection:bUseExternalMediaPlayer")]
	public bool UseExternalMediaPlayer
	{
		get
		{
			CheckDestroyed();
			if (!UseExternalMediaPlayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaCompositing.MovieSceneMediaSection:bUseExternalMediaPlayer");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseExternalMediaPlayer_Offset), 0, UseExternalMediaPlayer_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseExternalMediaPlayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaCompositing.MovieSceneMediaSection:bUseExternalMediaPlayer");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseExternalMediaPlayer_Offset), 0, UseExternalMediaPlayer_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7885767187628549uL)]
	[UMetaPath("/Script/MediaCompositing.MovieSceneMediaSection:ExternalMediaPlayer")]
	public UMediaPlayer ExternalMediaPlayer
	{
		get
		{
			CheckDestroyed();
			if (!ExternalMediaPlayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaCompositing.MovieSceneMediaSection:ExternalMediaPlayer");
				return null;
			}
			return UObjectMarshaler<UMediaPlayer>.FromNative(IntPtr.Add(base.Address, ExternalMediaPlayer_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ExternalMediaPlayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaCompositing.MovieSceneMediaSection:ExternalMediaPlayer");
			}
			else
			{
				UObjectMarshaler<UMediaPlayer>.ToNative(IntPtr.Add(base.Address, ExternalMediaPlayer_Offset), value);
			}
		}
	}

	static UMovieSceneMediaSection()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMovieSceneMediaSection)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMovieSceneMediaSection));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/MediaCompositing.MovieSceneMediaSection");
		MediaSource_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MediaSource");
		MediaSource_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MediaSource", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Looping_PropertyAddress, unrealStruct, "bLooping");
		Looping_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bLooping");
		Looping_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bLooping", Classes.FBoolProperty);
		StartFrameOffset_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "StartFrameOffset");
		StartFrameOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "StartFrameOffset", Classes.FStructProperty);
		MediaTexture_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MediaTexture");
		MediaTexture_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MediaTexture", Classes.FObjectProperty);
		MediaSoundComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MediaSoundComponent");
		MediaSoundComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MediaSoundComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref UseExternalMediaPlayer_PropertyAddress, unrealStruct, "bUseExternalMediaPlayer");
		UseExternalMediaPlayer_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUseExternalMediaPlayer");
		UseExternalMediaPlayer_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUseExternalMediaPlayer", Classes.FBoolProperty);
		ExternalMediaPlayer_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ExternalMediaPlayer");
		ExternalMediaPlayer_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ExternalMediaPlayer", Classes.FObjectProperty);
	}
}
