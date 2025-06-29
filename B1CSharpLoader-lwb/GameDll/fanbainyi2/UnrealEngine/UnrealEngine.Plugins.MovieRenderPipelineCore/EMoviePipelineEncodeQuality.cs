using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MovieRenderPipelineCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/MovieRenderPipelineCore.EMoviePipelineEncodeQuality", "MovieRenderPipelineCore", UnrealModuleType.EnginePlugin)]
public enum EMoviePipelineEncodeQuality : byte
{
	Low,
	Medium,
	High,
	Epic
}
