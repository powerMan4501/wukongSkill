using UnrealEngine.MovieSceneTracks;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.SequencerScripting;

public static class UMovieScenePropertyTrackExtensions_CsExtensions
{
	public static void SetPropertyNameAndPath(this UMovieScenePropertyTrack Track, FName InPropertyName, string InPropertyPath)
	{
		UMovieScenePropertyTrackExtensions.SetPropertyNameAndPath(Track, InPropertyName, InPropertyPath);
	}

	public static void SetObjectPropertyClass(this UMovieSceneObjectPropertyTrack Track, TSubclassOf<UObject> PropertyClass)
	{
		UMovieScenePropertyTrackExtensions.SetObjectPropertyClass(Track, PropertyClass);
	}

	public static FName GetUniqueTrackName(this UMovieScenePropertyTrack Track)
	{
		return UMovieScenePropertyTrackExtensions.GetUniqueTrackName(Track);
	}

	public static string GetPropertyPath(this UMovieScenePropertyTrack Track)
	{
		return UMovieScenePropertyTrackExtensions.GetPropertyPath(Track);
	}

	public static FName GetPropertyName(this UMovieScenePropertyTrack Track)
	{
		return UMovieScenePropertyTrackExtensions.GetPropertyName(Track);
	}

	public static TSubclassOf<UObject> GetObjectPropertyClass(this UMovieSceneObjectPropertyTrack Track)
	{
		return UMovieScenePropertyTrackExtensions.GetObjectPropertyClass(Track);
	}
}
