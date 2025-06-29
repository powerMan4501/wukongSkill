using UnrealEngine.Runtime;

namespace UnrealEngine.MovieScene;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/MovieScene.EMovieSceneCompletionMode", "MovieScene", UnrealModuleType.Engine)]
public enum EMovieSceneCompletionMode : byte
{
	KeepState,
	RestoreState,
	ProjectDefault
}
