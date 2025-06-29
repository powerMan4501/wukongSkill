using UnrealEngine.Engine;
using UnrealEngine.MovieScene;

namespace UnrealEngine.Plugins.TemplateSequence;

public static class UTemplateSequencePlayer_CsExtensions
{
	public static UTemplateSequencePlayer CreateTemplateSequencePlayer(this UWorld WorldContextObject, UTemplateSequence TemplateSequence, FMovieSceneSequencePlaybackSettings Settings, out ATemplateSequenceActor OutActor)
	{
		return UTemplateSequencePlayer.CreateTemplateSequencePlayer(WorldContextObject, TemplateSequence, Settings, out OutActor);
	}
}
