using UnrealEngine.Runtime;

namespace UnrealEngine.MovieSceneCapture;

[UEnum]
[UMetaPath("/Script/MovieSceneCapture.EMovieSceneCaptureProtocolState", "MovieSceneCapture", UnrealModuleType.Engine)]
public enum EMovieSceneCaptureProtocolState
{
	Idle,
	Initialized,
	Capturing,
	Finalizing
}
