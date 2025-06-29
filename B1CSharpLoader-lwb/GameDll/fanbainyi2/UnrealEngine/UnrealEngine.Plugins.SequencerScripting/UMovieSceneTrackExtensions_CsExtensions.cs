using System.Collections.Generic;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.SequencerScripting;

public static class UMovieSceneTrackExtensions_CsExtensions
{
	public static void SetTrackRowDisplayName(this UMovieSceneTrack Track, FText InName, int RowIndex)
	{
		UMovieSceneTrackExtensions.SetTrackRowDisplayName(Track, InName, RowIndex);
	}

	public static void SetSortingOrder(this UMovieSceneTrack Track, int SortingOrder)
	{
		UMovieSceneTrackExtensions.SetSortingOrder(Track, SortingOrder);
	}

	public static void SetSectionToKey(this UMovieSceneTrack Track, UMovieSceneSection Section)
	{
		UMovieSceneTrackExtensions.SetSectionToKey(Track, Section);
	}

	public static void SetDisplayName(this UMovieSceneTrack Track, FText InName)
	{
		UMovieSceneTrackExtensions.SetDisplayName(Track, InName);
	}

	public static void SetColorTint(this UMovieSceneTrack Track, FColor ColorTint)
	{
		UMovieSceneTrackExtensions.SetColorTint(Track, ColorTint);
	}

	public static void RemoveSection(this UMovieSceneTrack Track, UMovieSceneSection Section)
	{
		UMovieSceneTrackExtensions.RemoveSection(Track, Section);
	}

	public static string GetTrackRowDisplayName(this UMovieSceneTrack Track, int RowIndex)
	{
		return UMovieSceneTrackExtensions.GetTrackRowDisplayName(Track, RowIndex);
	}

	public static int GetSortingOrder(this UMovieSceneTrack Track)
	{
		return UMovieSceneTrackExtensions.GetSortingOrder(Track);
	}

	public static UMovieSceneSection GetSectionToKey(this UMovieSceneTrack Track)
	{
		return UMovieSceneTrackExtensions.GetSectionToKey(Track);
	}

	public static List<UMovieSceneSection> GetSections(this UMovieSceneTrack Track)
	{
		return UMovieSceneTrackExtensions.GetSections(Track);
	}

	public static string GetDisplayName(this UMovieSceneTrack Track)
	{
		return UMovieSceneTrackExtensions.GetDisplayName(Track);
	}

	public static FColor GetColorTint(this UMovieSceneTrack Track)
	{
		return UMovieSceneTrackExtensions.GetColorTint(Track);
	}

	public static UMovieSceneSection AddSection(this UMovieSceneTrack Track)
	{
		return UMovieSceneTrackExtensions.AddSection(Track);
	}
}
