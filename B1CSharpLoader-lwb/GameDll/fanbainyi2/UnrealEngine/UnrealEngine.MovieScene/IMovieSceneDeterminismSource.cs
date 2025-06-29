using UnrealEngine.Runtime;

namespace UnrealEngine.MovieScene;

[Abstract]
[UInterface(Flags = 810565793u)]
[Blueprintable]
[UMetaPath("/Script/MovieScene.MovieSceneDeterminismSource", "MovieScene", UnrealModuleType.Engine, InterfaceImpl = typeof(IMovieSceneDeterminismSourceImpl))]
public interface IMovieSceneDeterminismSource : IInterface
{
}
