using UnrealEngine.Runtime;

namespace UnrealEngine.MovieScene;

[Abstract]
[UInterface(Flags = 810565793u)]
[Blueprintable]
[UMetaPath("/Script/MovieScene.MovieSceneSequenceActor", "MovieScene", UnrealModuleType.Engine, InterfaceImpl = typeof(IMovieSceneSequenceActorImpl))]
public interface IMovieSceneSequenceActor : IInterface
{
}
