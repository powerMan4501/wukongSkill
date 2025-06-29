using UnrealEngine.MovieSceneTracks;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.SequencerScripting;

public static class UMovieSceneEventTrackExtensions_CsExtensions
{
	public static TSubclassOf<UObject> GetBoundObjectPropertyClass(this FMovieSceneEvent EventKey)
	{
		return UMovieSceneEventTrackExtensions.GetBoundObjectPropertyClass(EventKey);
	}

	public static UMovieSceneEventTriggerSection AddEventTriggerSection(this UMovieSceneEventTrack InTrack)
	{
		return UMovieSceneEventTrackExtensions.AddEventTriggerSection(InTrack);
	}

	public static UMovieSceneEventRepeaterSection AddEventRepeaterSection(this UMovieSceneEventTrack InTrack)
	{
		return UMovieSceneEventTrackExtensions.AddEventRepeaterSection(InTrack);
	}
}
