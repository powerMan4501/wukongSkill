using UnrealEngine.Runtime;

namespace UnrealEngine.MovieScene;

[UEnum]
[UMetaPath("/Script/MovieScene.EMovieSceneKeyInterpolation", "MovieScene", UnrealModuleType.Engine)]
public enum EMovieSceneKeyInterpolation
{
	Auto,
	User,
	Break,
	Linear,
	Constant
}
