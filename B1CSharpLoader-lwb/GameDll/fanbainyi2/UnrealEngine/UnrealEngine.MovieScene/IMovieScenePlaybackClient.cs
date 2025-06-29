using UnrealEngine.Runtime;

namespace UnrealEngine.MovieScene;

[Abstract]
[UInterface(Flags = 810565793u)]
[Blueprintable]
[UMetaPath("/Script/MovieScene.MovieScenePlaybackClient", "MovieScene", UnrealModuleType.Engine, InterfaceImpl = typeof(IMovieScenePlaybackClientImpl))]
public interface IMovieScenePlaybackClient : IInterface
{
}
