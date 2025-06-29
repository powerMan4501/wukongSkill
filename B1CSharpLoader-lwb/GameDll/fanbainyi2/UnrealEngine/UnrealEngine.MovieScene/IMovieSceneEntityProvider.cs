using UnrealEngine.Runtime;

namespace UnrealEngine.MovieScene;

[Abstract]
[UInterface(Flags = 810565793u)]
[Blueprintable]
[UMetaPath("/Script/MovieScene.MovieSceneEntityProvider", "MovieScene", UnrealModuleType.Engine, InterfaceImpl = typeof(IMovieSceneEntityProviderImpl))]
public interface IMovieSceneEntityProvider : IInterface
{
}
