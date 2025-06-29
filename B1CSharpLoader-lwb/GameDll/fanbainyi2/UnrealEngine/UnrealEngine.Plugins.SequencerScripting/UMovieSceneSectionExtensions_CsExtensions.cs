using System.Collections.Generic;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.SequencerScripting;

public static class UMovieSceneSectionExtensions_CsExtensions
{
	public static void SetStartFrameSeconds(this UMovieSceneSection Section, float StartTime)
	{
		UMovieSceneSectionExtensions.SetStartFrameSeconds(Section, StartTime);
	}

	public static void SetStartFrameBounded(this UMovieSceneSection Section, bool bIsBounded)
	{
		UMovieSceneSectionExtensions.SetStartFrameBounded(Section, bIsBounded);
	}

	public static void SetStartFrame(this UMovieSceneSection Section, int StartFrame)
	{
		UMovieSceneSectionExtensions.SetStartFrame(Section, StartFrame);
	}

	public static void SetRangeSeconds(this UMovieSceneSection Section, float StartTime, float EndTime)
	{
		UMovieSceneSectionExtensions.SetRangeSeconds(Section, StartTime, EndTime);
	}

	public static void SetRange(this UMovieSceneSection Section, int StartFrame, int EndFrame)
	{
		UMovieSceneSectionExtensions.SetRange(Section, StartFrame, EndFrame);
	}

	public static void SetEndFrameSeconds(this UMovieSceneSection Section, float EndTime)
	{
		UMovieSceneSectionExtensions.SetEndFrameSeconds(Section, EndTime);
	}

	public static void SetEndFrameBounded(this UMovieSceneSection Section, bool bIsBounded)
	{
		UMovieSceneSectionExtensions.SetEndFrameBounded(Section, bIsBounded);
	}

	public static void SetEndFrame(this UMovieSceneSection Section, int EndFrame)
	{
		UMovieSceneSectionExtensions.SetEndFrame(Section, EndFrame);
	}

	public static bool HasStartFrame(this UMovieSceneSection Section)
	{
		return UMovieSceneSectionExtensions.HasStartFrame(Section);
	}

	public static bool HasEndFrame(this UMovieSceneSection Section)
	{
		return UMovieSceneSectionExtensions.HasEndFrame(Section);
	}

	public static float GetStartFrameSeconds(this UMovieSceneSection Section)
	{
		return UMovieSceneSectionExtensions.GetStartFrameSeconds(Section);
	}

	public static int GetStartFrame(this UMovieSceneSection Section)
	{
		return UMovieSceneSectionExtensions.GetStartFrame(Section);
	}

	public static int GetParentSequenceFrame(this UMovieSceneSubSection Section, int InFrame, UMovieSceneSequence ParentSequence)
	{
		return UMovieSceneSectionExtensions.GetParentSequenceFrame(Section, InFrame, ParentSequence);
	}

	public static float GetEndFrameSeconds(this UMovieSceneSection Section)
	{
		return UMovieSceneSectionExtensions.GetEndFrameSeconds(Section);
	}

	public static int GetEndFrame(this UMovieSceneSection Section)
	{
		return UMovieSceneSectionExtensions.GetEndFrame(Section);
	}

	public static List<UMovieSceneScriptingChannel> GetChannelsByType(this UMovieSceneSection Section, TSubclassOf<UMovieSceneScriptingChannel> ChannelType)
	{
		return UMovieSceneSectionExtensions.GetChannelsByType(Section, ChannelType);
	}

	public static List<UMovieSceneScriptingChannel> GetChannels(this UMovieSceneSection Section)
	{
		return UMovieSceneSectionExtensions.GetChannels(Section);
	}

	public static List<UMovieSceneScriptingChannel> GetAllChannels(this UMovieSceneSection Section)
	{
		return UMovieSceneSectionExtensions.GetAllChannels(Section);
	}

	public static List<UMovieSceneScriptingChannel> FindChannelsByType(this UMovieSceneSection Section, TSubclassOf<UMovieSceneScriptingChannel> ChannelType)
	{
		return UMovieSceneSectionExtensions.FindChannelsByType(Section, ChannelType);
	}
}
