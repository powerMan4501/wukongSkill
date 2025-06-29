using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MovieRenderPipelineCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/MovieRenderPipelineCore.EMovieRenderPipelineState", "MovieRenderPipelineCore", UnrealModuleType.EnginePlugin)]
public enum EMovieRenderPipelineState : byte
{
	Uninitialized,
	ProducingFrames,
	Finalize,
	Export,
	Finished
}
