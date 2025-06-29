using System;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace UnrealEngine.MovieSceneTracks;

[UClass(Flags = (ClassFlags)812122272uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/MovieSceneTracks.MovieSceneSkeletalAnimationSection", "MovieSceneTracks", UnrealModuleType.Engine)]
public class UMovieSceneSkeletalAnimationSection : UMovieSceneSection
{
	private static bool Params_IsValid;

	private static int Params_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/MovieSceneTracks.MovieSceneSkeletalAnimationSection:Params")]
	public FMovieSceneSkeletalAnimationParams Params
	{
		get
		{
			CheckDestroyed();
			if (!Params_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneTracks.MovieSceneSkeletalAnimationSection:Params");
				return default(FMovieSceneSkeletalAnimationParams);
			}
			return FMovieSceneSkeletalAnimationParams.FromNative(IntPtr.Add(base.Address, Params_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Params_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneTracks.MovieSceneSkeletalAnimationSection:Params");
			}
			else
			{
				FMovieSceneSkeletalAnimationParams.ToNative(IntPtr.Add(base.Address, Params_Offset), value);
			}
		}
	}

	static UMovieSceneSkeletalAnimationSection()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMovieSceneSkeletalAnimationSection)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMovieSceneSkeletalAnimationSection));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/MovieSceneTracks.MovieSceneSkeletalAnimationSection");
		Params_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Params");
		Params_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Params", Classes.FStructProperty);
	}
}
