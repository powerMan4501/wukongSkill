using UnrealEngine.Engine;
using UnrealEngine.MovieScene;

namespace UnrealEngine.LevelSequence;

public static class ULevelSequencePlayer_CsExtensions
{
	public static ULevelSequencePlayer CreateLevelSequencePlayer(this UWorld WorldContextObject, ULevelSequence LevelSequence, FMovieSceneSequencePlaybackSettings Settings, out ALevelSequenceActor OutActor)
	{
		return ULevelSequencePlayer.CreateLevelSequencePlayer(WorldContextObject, LevelSequence, Settings, out OutActor);
	}
}
