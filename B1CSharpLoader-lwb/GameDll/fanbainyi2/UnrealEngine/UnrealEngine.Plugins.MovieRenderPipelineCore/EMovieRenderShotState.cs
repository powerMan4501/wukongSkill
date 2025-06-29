using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MovieRenderPipelineCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/MovieRenderPipelineCore.EMovieRenderShotState", "MovieRenderPipelineCore", UnrealModuleType.EnginePlugin)]
public enum EMovieRenderShotState : byte
{
	Uninitialized,
	WarmingUp,
	MotionBlur,
	Rendering,
	Finished
}
