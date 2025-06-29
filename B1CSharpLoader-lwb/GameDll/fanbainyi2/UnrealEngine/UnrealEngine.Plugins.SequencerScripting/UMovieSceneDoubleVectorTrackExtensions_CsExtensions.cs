using UnrealEngine.MovieSceneTracks;

namespace UnrealEngine.Plugins.SequencerScripting;

public static class UMovieSceneDoubleVectorTrackExtensions_CsExtensions
{
	public static void SetNumChannelsUsed(this UMovieSceneDoubleVectorTrack Track, int InNumChannelsUsed)
	{
		UMovieSceneDoubleVectorTrackExtensions.SetNumChannelsUsed(Track, InNumChannelsUsed);
	}

	public static int GetNumChannelsUsed(this UMovieSceneDoubleVectorTrack Track)
	{
		return UMovieSceneDoubleVectorTrackExtensions.GetNumChannelsUsed(Track);
	}
}
