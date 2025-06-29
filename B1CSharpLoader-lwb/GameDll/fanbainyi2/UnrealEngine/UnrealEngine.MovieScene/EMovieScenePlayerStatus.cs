using UnrealEngine.Runtime;

namespace UnrealEngine.MovieScene;

[UEnum]
[UMetaPath("/Script/MovieScene.EMovieScenePlayerStatus", "MovieScene", UnrealModuleType.Engine)]
public enum EMovieScenePlayerStatus
{
	Stopped,
	Playing,
	Scrubbing,
	Jumping,
	Stepping,
	Paused
}
