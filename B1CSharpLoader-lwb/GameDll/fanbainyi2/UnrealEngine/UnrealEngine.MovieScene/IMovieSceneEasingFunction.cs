using UnrealEngine.Runtime;

namespace UnrealEngine.MovieScene;

[Abstract]
[UInterface(Flags = 810565793u)]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/MovieScene.MovieSceneEasingFunction", "MovieScene", UnrealModuleType.Engine, InterfaceImpl = typeof(IMovieSceneEasingFunctionImpl))]
public interface IMovieSceneEasingFunction : IInterface
{
	[UFunction(Flags = 1544030208u)]
	[UMetaPath("/Script/MovieScene.MovieSceneEasingFunction:OnEvaluate")]
	float OnEvaluate(float Interp);
}
