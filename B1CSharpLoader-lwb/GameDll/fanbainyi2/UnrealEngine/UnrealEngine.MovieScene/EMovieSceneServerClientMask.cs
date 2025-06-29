using UnrealEngine.Runtime;

namespace UnrealEngine.MovieScene;

[UEnum]
[UMetaPath("/Script/MovieScene.EMovieSceneServerClientMask", "MovieScene", UnrealModuleType.Engine)]
public enum EMovieSceneServerClientMask
{
	None,
	Server,
	Client,
	All
}
