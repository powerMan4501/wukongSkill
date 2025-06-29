using UnrealEngine.Runtime;

namespace UnrealEngine.MovieSceneCapture;

[Abstract]
[UInterface(Flags = 810041505u)]
[Blueprintable]
[UMetaPath("/Script/MovieSceneCapture.MovieSceneCaptureInterface", "MovieSceneCapture", UnrealModuleType.Engine, InterfaceImpl = typeof(IMovieSceneCaptureInterfaceImpl))]
public interface IMovieSceneCaptureInterface : IInterface
{
}
