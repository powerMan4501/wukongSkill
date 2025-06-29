using UnrealEngine.MovieSceneTracks;

namespace UnrealEngine.Plugins.SequencerScripting;

public static class UMovieSceneFloatVectorTrackExtensions_CsExtensions
{
	public static void SetNumChannelsUsed(this UMovieSceneFloatVectorTrack Track, int InNumChannelsUsed)
	{
		UMovieSceneFloatVectorTrackExtensions.SetNumChannelsUsed(Track, InNumChannelsUsed);
	}

	public static int GetNumChannelsUsed(this UMovieSceneFloatVectorTrack Track)
	{
		return UMovieSceneFloatVectorTrackExtensions.GetNumChannelsUsed(Track);
	}
}
