using System;
using System.Collections.Generic;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.SequencerScripting;

public static class UMovieSceneSequenceExtensions_CsExtensions
{
	public static void SortMarkedFrames(this UMovieSceneSequence Sequence)
	{
		UMovieSceneSequenceExtensions.SortMarkedFrames(Sequence);
	}

	public static void SetWorkRangeStart(this UMovieSceneSequence InSequence, float StartTimeInSeconds)
	{
		UMovieSceneSequenceExtensions.SetWorkRangeStart(InSequence, StartTimeInSeconds);
	}

	public static void SetWorkRangeEnd(this UMovieSceneSequence InSequence, float EndTimeInSeconds)
	{
		UMovieSceneSequenceExtensions.SetWorkRangeEnd(InSequence, EndTimeInSeconds);
	}

	public static void SetViewRangeStart(this UMovieSceneSequence InSequence, float StartTimeInSeconds)
	{
		UMovieSceneSequenceExtensions.SetViewRangeStart(InSequence, StartTimeInSeconds);
	}

	public static void SetViewRangeEnd(this UMovieSceneSequence InSequence, float EndTimeInSeconds)
	{
		UMovieSceneSequenceExtensions.SetViewRangeEnd(InSequence, EndTimeInSeconds);
	}

	public static void SetTickResolutionDirectly(this UMovieSceneSequence Sequence, FFrameRate TickResolution)
	{
		UMovieSceneSequenceExtensions.SetTickResolutionDirectly(Sequence, TickResolution);
	}

	public static void SetTickResolution(this UMovieSceneSequence Sequence, FFrameRate TickResolution)
	{
		UMovieSceneSequenceExtensions.SetTickResolution(Sequence, TickResolution);
	}

	public static void SetReadOnly(this UMovieSceneSequence Sequence, bool bInReadOnly)
	{
		UMovieSceneSequenceExtensions.SetReadOnly(Sequence, bInReadOnly);
	}

	public static void SetPlaybackStartSeconds(this UMovieSceneSequence Sequence, float StartTime)
	{
		UMovieSceneSequenceExtensions.SetPlaybackStartSeconds(Sequence, StartTime);
	}

	public static void SetPlaybackStart(this UMovieSceneSequence Sequence, int StartFrame)
	{
		UMovieSceneSequenceExtensions.SetPlaybackStart(Sequence, StartFrame);
	}

	public static void SetPlaybackEndSeconds(this UMovieSceneSequence Sequence, float EndTime)
	{
		UMovieSceneSequenceExtensions.SetPlaybackEndSeconds(Sequence, EndTime);
	}

	public static void SetPlaybackEnd(this UMovieSceneSequence Sequence, int EndFrame)
	{
		UMovieSceneSequenceExtensions.SetPlaybackEnd(Sequence, EndFrame);
	}

	public static void SetMarkedFrame(this UMovieSceneSequence Sequence, int InMarkIndex, FFrameNumber InFrameNumber)
	{
		UMovieSceneSequenceExtensions.SetMarkedFrame(Sequence, InMarkIndex, InFrameNumber);
	}

	public static void SetEvaluationType(this UMovieSceneSequence InSequence, EMovieSceneEvaluationType InEvaluationType)
	{
		UMovieSceneSequenceExtensions.SetEvaluationType(InSequence, InEvaluationType);
	}

	public static void SetDisplayRate(this UMovieSceneSequence Sequence, FFrameRate DisplayRate)
	{
		UMovieSceneSequenceExtensions.SetDisplayRate(Sequence, DisplayRate);
	}

	public static void SetClockSource(this UMovieSceneSequence InSequence, EUpdateClockSource InClockSource)
	{
		UMovieSceneSequenceExtensions.SetClockSource(InSequence, InClockSource);
	}

	public static FSequencerBindingProxy ResolveBindingID(this UMovieSceneSequence MasterSequence, FMovieSceneObjectBindingID InObjectBindingID)
	{
		return UMovieSceneSequenceExtensions.ResolveBindingID(MasterSequence, InObjectBindingID);
	}

	public static bool RemoveMasterTrack(this UMovieSceneSequence Sequence, UMovieSceneTrack MasterTrack)
	{
		return UMovieSceneSequenceExtensions.RemoveMasterTrack(Sequence, MasterTrack);
	}

	public static FSequencerScriptingRange MakeRangeSeconds(this UMovieSceneSequence Sequence, float StartTime, float Duration)
	{
		return UMovieSceneSequenceExtensions.MakeRangeSeconds(Sequence, StartTime, Duration);
	}

	public static FSequencerScriptingRange MakeRange(this UMovieSceneSequence Sequence, int StartFrame, int Duration)
	{
		return UMovieSceneSequenceExtensions.MakeRange(Sequence, StartFrame, Duration);
	}

	public static List<UObject> LocateBoundObjects(this UMovieSceneSequence Sequence, FSequencerBindingProxy InBinding, UObject Context)
	{
		return UMovieSceneSequenceExtensions.LocateBoundObjects(Sequence, InBinding, Context);
	}

	public static bool IsReadOnly(this UMovieSceneSequence Sequence)
	{
		return UMovieSceneSequenceExtensions.IsReadOnly(Sequence);
	}

	public static float GetWorkRangeStart(this UMovieSceneSequence InSequence)
	{
		return UMovieSceneSequenceExtensions.GetWorkRangeStart(InSequence);
	}

	public static float GetWorkRangeEnd(this UMovieSceneSequence InSequence)
	{
		return UMovieSceneSequenceExtensions.GetWorkRangeEnd(InSequence);
	}

	public static float GetViewRangeStart(this UMovieSceneSequence InSequence)
	{
		return UMovieSceneSequenceExtensions.GetViewRangeStart(InSequence);
	}

	public static float GetViewRangeEnd(this UMovieSceneSequence InSequence)
	{
		return UMovieSceneSequenceExtensions.GetViewRangeEnd(InSequence);
	}

	public static FFrameRate GetTickResolution(this UMovieSceneSequence Sequence)
	{
		return UMovieSceneSequenceExtensions.GetTickResolution(Sequence);
	}

	public static List<FSequencerBindingProxy> GetSpawnables(this UMovieSceneSequence Sequence)
	{
		return UMovieSceneSequenceExtensions.GetSpawnables(Sequence);
	}

	public static List<UMovieSceneFolder> GetRootFoldersInSequence(this UMovieSceneSequence Sequence)
	{
		return UMovieSceneSequenceExtensions.GetRootFoldersInSequence(Sequence);
	}

	public static List<FSequencerBindingProxy> GetPossessables(this UMovieSceneSequence Sequence)
	{
		return UMovieSceneSequenceExtensions.GetPossessables(Sequence);
	}

	public static FMovieSceneObjectBindingID GetPortableBindingID(this UMovieSceneSequence MasterSequence, UMovieSceneSequence DestinationSequence, FSequencerBindingProxy InBinding)
	{
		return UMovieSceneSequenceExtensions.GetPortableBindingID(MasterSequence, DestinationSequence, InBinding);
	}

	public static float GetPlaybackStartSeconds(this UMovieSceneSequence Sequence)
	{
		return UMovieSceneSequenceExtensions.GetPlaybackStartSeconds(Sequence);
	}

	public static int GetPlaybackStart(this UMovieSceneSequence Sequence)
	{
		return UMovieSceneSequenceExtensions.GetPlaybackStart(Sequence);
	}

	public static FSequencerScriptingRange GetPlaybackRange(this UMovieSceneSequence Sequence)
	{
		return UMovieSceneSequenceExtensions.GetPlaybackRange(Sequence);
	}

	public static float GetPlaybackEndSeconds(this UMovieSceneSequence Sequence)
	{
		return UMovieSceneSequenceExtensions.GetPlaybackEndSeconds(Sequence);
	}

	public static int GetPlaybackEnd(this UMovieSceneSequence Sequence)
	{
		return UMovieSceneSequenceExtensions.GetPlaybackEnd(Sequence);
	}

	public static UMovieScene GetMovieScene(this UMovieSceneSequence Sequence)
	{
		return UMovieSceneSequenceExtensions.GetMovieScene(Sequence);
	}

	public static List<UMovieSceneTrack> GetMasterTracks(this UMovieSceneSequence Sequence)
	{
		return UMovieSceneSequenceExtensions.GetMasterTracks(Sequence);
	}

	public static List<FMovieSceneMarkedFrame> GetMarkedFrames(this UMovieSceneSequence Sequence)
	{
		return UMovieSceneSequenceExtensions.GetMarkedFrames(Sequence);
	}

	public static EMovieSceneEvaluationType GetEvaluationType(this UMovieSceneSequence InSequence)
	{
		return UMovieSceneSequenceExtensions.GetEvaluationType(InSequence);
	}

	public static FFrameRate GetDisplayRate(this UMovieSceneSequence Sequence)
	{
		return UMovieSceneSequenceExtensions.GetDisplayRate(Sequence);
	}

	public static EUpdateClockSource GetClockSource(this UMovieSceneSequence InSequence)
	{
		return UMovieSceneSequenceExtensions.GetClockSource(InSequence);
	}

	public static List<FSequencerBindingProxy> GetBindings(this UMovieSceneSequence Sequence)
	{
		return UMovieSceneSequenceExtensions.GetBindings(Sequence);
	}

	public static FMovieSceneObjectBindingID GetBindingID(this FSequencerBindingProxy InBinding)
	{
		return UMovieSceneSequenceExtensions.GetBindingID(InBinding);
	}

	public static int FindNextMarkedFrame(this UMovieSceneSequence Sequence, FFrameNumber InFrameNumber, bool bForward)
	{
		return UMovieSceneSequenceExtensions.FindNextMarkedFrame(Sequence, InFrameNumber, bForward);
	}

	public static List<UMovieSceneTrack> FindMasterTracksByType(this UMovieSceneSequence Sequence, TSubclassOf<UMovieSceneTrack> TrackType)
	{
		return UMovieSceneSequenceExtensions.FindMasterTracksByType(Sequence, TrackType);
	}

	public static List<UMovieSceneTrack> FindMasterTracksByExactType(this UMovieSceneSequence Sequence, TSubclassOf<UMovieSceneTrack> TrackType)
	{
		return UMovieSceneSequenceExtensions.FindMasterTracksByExactType(Sequence, TrackType);
	}

	public static int FindMarkedFrameByLabel(this UMovieSceneSequence Sequence, string InLabel)
	{
		return UMovieSceneSequenceExtensions.FindMarkedFrameByLabel(Sequence, InLabel);
	}

	public static int FindMarkedFrameByFrameNumber(this UMovieSceneSequence Sequence, FFrameNumber InFrameNumber)
	{
		return UMovieSceneSequenceExtensions.FindMarkedFrameByFrameNumber(Sequence, InFrameNumber);
	}

	public static FSequencerBindingProxy FindBindingByName(this UMovieSceneSequence Sequence, string Name)
	{
		return UMovieSceneSequenceExtensions.FindBindingByName(Sequence, Name);
	}

	public static FSequencerBindingProxy FindBindingById(this UMovieSceneSequence Sequence, Guid BindingId)
	{
		return UMovieSceneSequenceExtensions.FindBindingById(Sequence, BindingId);
	}

	public static void DeleteMarkedFrames(this UMovieSceneSequence Sequence)
	{
		UMovieSceneSequenceExtensions.DeleteMarkedFrames(Sequence);
	}

	public static void DeleteMarkedFrame(this UMovieSceneSequence Sequence, int DeleteIndex)
	{
		UMovieSceneSequenceExtensions.DeleteMarkedFrame(Sequence, DeleteIndex);
	}

	public static FSequencerBindingProxy AddSpawnableFromInstance(this UMovieSceneSequence Sequence, UObject ObjectToSpawn)
	{
		return UMovieSceneSequenceExtensions.AddSpawnableFromInstance(Sequence, ObjectToSpawn);
	}

	public static FSequencerBindingProxy AddSpawnableFromClass(this UMovieSceneSequence Sequence, TSubclassOf<UObject> ClassToSpawn)
	{
		return UMovieSceneSequenceExtensions.AddSpawnableFromClass(Sequence, ClassToSpawn);
	}

	public static UMovieSceneFolder AddRootFolderToSequence(this UMovieSceneSequence Sequence, string NewFolderName)
	{
		return UMovieSceneSequenceExtensions.AddRootFolderToSequence(Sequence, NewFolderName);
	}

	public static FSequencerBindingProxy AddPossessable(this UMovieSceneSequence Sequence, UObject ObjectToPossess)
	{
		return UMovieSceneSequenceExtensions.AddPossessable(Sequence, ObjectToPossess);
	}

	public static UMovieSceneTrack AddMasterTrack(this UMovieSceneSequence Sequence, TSubclassOf<UMovieSceneTrack> TrackType)
	{
		return UMovieSceneSequenceExtensions.AddMasterTrack(Sequence, TrackType);
	}

	public static int AddMarkedFrame(this UMovieSceneSequence Sequence, FMovieSceneMarkedFrame InMarkedFrame)
	{
		return UMovieSceneSequenceExtensions.AddMarkedFrame(Sequence, InMarkedFrame);
	}
}
