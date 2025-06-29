using UnrealEngine.Runtime;

namespace UnrealEngine.MovieScene;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/MovieScene.EMovieScenePositionType", "MovieScene", UnrealModuleType.Engine)]
public enum EMovieScenePositionType : byte
{
	Frame,
	Time,
	MarkedFrame
}
