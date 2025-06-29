using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MovieRenderPipelineCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/MovieRenderPipelineCore.EMoviePipelineTextureStreamingMethod", "MovieRenderPipelineCore", UnrealModuleType.EnginePlugin)]
public enum EMoviePipelineTextureStreamingMethod : byte
{
	None,
	Disabled,
	FullyLoad
}
