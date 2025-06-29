using UnrealEngine.Runtime;

namespace UnrealEngine.MovieSceneTracks;

[Abstract]
[UInterface(Flags = 810565793u)]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/MovieSceneTracks.MovieSceneTransformOrigin", "MovieSceneTracks", UnrealModuleType.Engine, InterfaceImpl = typeof(IMovieSceneTransformOriginImpl))]
public interface IMovieSceneTransformOrigin : IInterface
{
	[UFunction(Flags = 1552418816u)]
	[UMetaPath("/Script/MovieSceneTracks.MovieSceneTransformOrigin:BP_GetTransformOrigin")]
	FTransform BP_GetTransformOrigin();
}
