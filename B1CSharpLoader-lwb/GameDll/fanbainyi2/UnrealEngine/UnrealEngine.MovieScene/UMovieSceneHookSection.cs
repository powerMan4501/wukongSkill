using UnrealEngine.Runtime;

namespace UnrealEngine.MovieScene;

[UClass(Flags = (ClassFlags)812646560uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/MovieScene.MovieSceneHookSection", "MovieScene", UnrealModuleType.Engine)]
public class UMovieSceneHookSection : UMovieSceneSection, IMovieSceneEntityProvider, IInterface, IMovieSceneEvaluationHook
{
}
