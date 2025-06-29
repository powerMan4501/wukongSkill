using UnrealEngine.Runtime;

namespace UnrealEngine.MovieScene;

[Abstract]
[UInterface(Flags = 810565793u)]
[Blueprintable]
[UMetaPath("/Script/MovieScene.MovieSceneBindingOwnerInterface", "MovieScene", UnrealModuleType.Engine, InterfaceImpl = typeof(IMovieSceneBindingOwnerInterfaceImpl))]
public interface IMovieSceneBindingOwnerInterface : IInterface
{
}
