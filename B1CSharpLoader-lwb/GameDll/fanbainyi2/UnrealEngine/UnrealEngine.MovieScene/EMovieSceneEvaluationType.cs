using UnrealEngine.Runtime;

namespace UnrealEngine.MovieScene;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/MovieScene.EMovieSceneEvaluationType", "MovieScene", UnrealModuleType.Engine)]
public enum EMovieSceneEvaluationType : byte
{
	FrameLocked,
	WithSubFrames
}
