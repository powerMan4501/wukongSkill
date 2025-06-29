using UnrealEngine.Runtime;

namespace UnrealEngine.MovieScene;

[Abstract]
[UInterface(Flags = 810565793u)]
[Blueprintable]
[UMetaPath("/Script/MovieScene.MovieSceneCustomClockSource", "MovieScene", UnrealModuleType.Engine, InterfaceImpl = typeof(IMovieSceneCustomClockSourceImpl))]
public interface IMovieSceneCustomClockSource : IInterface
{
}
