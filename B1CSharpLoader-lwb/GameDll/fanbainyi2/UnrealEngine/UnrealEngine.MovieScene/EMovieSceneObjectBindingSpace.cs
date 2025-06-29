using UnrealEngine.Runtime;

namespace UnrealEngine.MovieScene;

[UEnum]
[UMetaPath("/Script/MovieScene.EMovieSceneObjectBindingSpace", "MovieScene", UnrealModuleType.Engine)]
public enum EMovieSceneObjectBindingSpace
{
	Local,
	Root,
	Unused
}
