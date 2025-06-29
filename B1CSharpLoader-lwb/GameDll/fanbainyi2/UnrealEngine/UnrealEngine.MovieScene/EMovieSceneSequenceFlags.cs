using UnrealEngine.Runtime;

namespace UnrealEngine.MovieScene;

[UEnum]
[UMetaPath("/Script/MovieScene.EMovieSceneSequenceFlags", "MovieScene", UnrealModuleType.Engine)]
public enum EMovieSceneSequenceFlags
{
	None = 0,
	Volatile = 1,
	BlockingEvaluation = 2,
	InheritedFlags = 1
}
