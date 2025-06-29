using UnrealEngine.Runtime;

namespace UnrealEngine.MoviePlayer;

[UEnum]
[UMetaPath("/Script/MoviePlayer.EMoviePlaybackType", "MoviePlayer", UnrealModuleType.Engine)]
public enum EMoviePlaybackType
{
	MT_Normal,
	MT_Looped,
	MT_LoadingLoop
}
