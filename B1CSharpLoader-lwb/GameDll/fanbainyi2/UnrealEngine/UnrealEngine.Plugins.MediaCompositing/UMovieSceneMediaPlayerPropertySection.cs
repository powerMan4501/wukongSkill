using System;
using UnrealEngine.MediaAssets;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MediaCompositing;

[UClass(Flags = (ClassFlags)812122272uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/MediaCompositing.MovieSceneMediaPlayerPropertySection", "MediaCompositing", UnrealModuleType.EnginePlugin)]
public class UMovieSceneMediaPlayerPropertySection : UMovieSceneSection
{
	private static bool MediaSource_IsValid;

	private static int MediaSource_Offset;

	private static bool Loop_IsValid;

	private static FFieldAddress Loop_PropertyAddress;

	private static int Loop_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/MediaCompositing.MovieSceneMediaPlayerPropertySection:MediaSource")]
	public UMediaSource MediaSource
	{
		get
		{
			CheckDestroyed();
			if (!MediaSource_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaCompositing.MovieSceneMediaPlayerPropertySection:MediaSource");
				return null;
			}
			return UObjectMarshaler<UMediaSource>.FromNative(IntPtr.Add(base.Address, MediaSource_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MediaSource_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaCompositing.MovieSceneMediaPlayerPropertySection:MediaSource");
			}
			else
			{
				UObjectMarshaler<UMediaSource>.ToNative(IntPtr.Add(base.Address, MediaSource_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MediaCompositing.MovieSceneMediaPlayerPropertySection:bLoop")]
	public bool Loop
	{
		get
		{
			CheckDestroyed();
			if (!Loop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaCompositing.MovieSceneMediaPlayerPropertySection:bLoop");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Loop_Offset), 0, Loop_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Loop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaCompositing.MovieSceneMediaPlayerPropertySection:bLoop");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Loop_Offset), 0, Loop_PropertyAddress.Address, value);
			}
		}
	}

	static UMovieSceneMediaPlayerPropertySection()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMovieSceneMediaPlayerPropertySection)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMovieSceneMediaPlayerPropertySection));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/MediaCompositing.MovieSceneMediaPlayerPropertySection");
		MediaSource_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MediaSource");
		MediaSource_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MediaSource", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Loop_PropertyAddress, unrealStruct, "bLoop");
		Loop_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bLoop");
		Loop_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bLoop", Classes.FBoolProperty);
	}
}
