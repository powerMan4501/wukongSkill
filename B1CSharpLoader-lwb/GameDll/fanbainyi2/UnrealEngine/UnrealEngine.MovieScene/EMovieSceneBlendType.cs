using UnrealEngine.Runtime;

namespace UnrealEngine.MovieScene;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/MovieScene.EMovieSceneBlendType", "MovieScene", UnrealModuleType.Engine)]
public enum EMovieSceneBlendType : byte
{
	Invalid = 0,
	Absolute = 1,
	Additive = 2,
	Relative = 4,
	AdditiveFromBase = 8
}
