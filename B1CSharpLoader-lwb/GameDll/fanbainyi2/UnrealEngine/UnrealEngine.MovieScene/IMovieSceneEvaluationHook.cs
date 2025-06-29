using UnrealEngine.Runtime;

namespace UnrealEngine.MovieScene;

[Abstract]
[UInterface(Flags = 810565793u)]
[Blueprintable]
[UMetaPath("/Script/MovieScene.MovieSceneEvaluationHook", "MovieScene", UnrealModuleType.Engine, InterfaceImpl = typeof(IMovieSceneEvaluationHookImpl))]
public interface IMovieSceneEvaluationHook : IInterface
{
}
