using System;
using System.Collections.Generic;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.SequencerScripting;

public static class UMovieSceneBindingExtensions_CsExtensions
{
	public static void SetParent(this FSequencerBindingProxy InBinding, FSequencerBindingProxy InParentBinding)
	{
		UMovieSceneBindingExtensions.SetParent(InBinding, InParentBinding);
	}

	public static void SetName(this FSequencerBindingProxy InBinding, string InName)
	{
		UMovieSceneBindingExtensions.SetName(InBinding, InName);
	}

	public static void SetDisplayName(this FSequencerBindingProxy InBinding, FText InDisplayName)
	{
		UMovieSceneBindingExtensions.SetDisplayName(InBinding, InDisplayName);
	}

	public static void RemoveTrack(this FSequencerBindingProxy InBinding, UMovieSceneTrack TrackToRemove)
	{
		UMovieSceneBindingExtensions.RemoveTrack(InBinding, TrackToRemove);
	}

	public static void Remove(this FSequencerBindingProxy InBinding)
	{
		UMovieSceneBindingExtensions.Remove(InBinding);
	}

	public static void MoveBindingContents(this FSequencerBindingProxy SourceBindingId, FSequencerBindingProxy DestinationBindingId)
	{
		UMovieSceneBindingExtensions.MoveBindingContents(SourceBindingId, DestinationBindingId);
	}

	public static bool IsValid(this FSequencerBindingProxy InBinding)
	{
		return UMovieSceneBindingExtensions.IsValid(InBinding);
	}

	public static List<UMovieSceneTrack> GetTracks(this FSequencerBindingProxy InBinding)
	{
		return UMovieSceneBindingExtensions.GetTracks(InBinding);
	}

	public static TSubclassOf<UObject> GetPossessedObjectClass(this FSequencerBindingProxy InBinding)
	{
		return UMovieSceneBindingExtensions.GetPossessedObjectClass(InBinding);
	}

	public static FSequencerBindingProxy GetParent(this FSequencerBindingProxy InBinding)
	{
		return UMovieSceneBindingExtensions.GetParent(InBinding);
	}

	public static UObject GetObjectTemplate(this FSequencerBindingProxy InBinding)
	{
		return UMovieSceneBindingExtensions.GetObjectTemplate(InBinding);
	}

	public static string GetName(this FSequencerBindingProxy InBinding)
	{
		return UMovieSceneBindingExtensions.GetName(InBinding);
	}

	public static Guid GetId(this FSequencerBindingProxy InBinding)
	{
		return UMovieSceneBindingExtensions.GetId(InBinding);
	}

	public static string GetDisplayName(this FSequencerBindingProxy InBinding)
	{
		return UMovieSceneBindingExtensions.GetDisplayName(InBinding);
	}

	public static List<FSequencerBindingProxy> GetChildPossessables(this FSequencerBindingProxy InBinding)
	{
		return UMovieSceneBindingExtensions.GetChildPossessables(InBinding);
	}

	public static List<UMovieSceneTrack> FindTracksByType(this FSequencerBindingProxy InBinding, TSubclassOf<UMovieSceneTrack> TrackType)
	{
		return UMovieSceneBindingExtensions.FindTracksByType(InBinding, TrackType);
	}

	public static List<UMovieSceneTrack> FindTracksByExactType(this FSequencerBindingProxy InBinding, TSubclassOf<UMovieSceneTrack> TrackType)
	{
		return UMovieSceneBindingExtensions.FindTracksByExactType(InBinding, TrackType);
	}

	public static UMovieSceneTrack AddTrack(this FSequencerBindingProxy InBinding, TSubclassOf<UMovieSceneTrack> TrackType)
	{
		return UMovieSceneBindingExtensions.AddTrack(InBinding, TrackType);
	}
}
