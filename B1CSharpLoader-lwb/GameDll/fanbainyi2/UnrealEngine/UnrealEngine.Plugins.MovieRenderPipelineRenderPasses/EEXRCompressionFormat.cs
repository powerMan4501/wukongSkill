using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MovieRenderPipelineRenderPasses;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/MovieRenderPipelineRenderPasses.EEXRCompressionFormat", "MovieRenderPipelineRenderPasses", UnrealModuleType.EnginePlugin)]
public enum EEXRCompressionFormat : byte
{
	None,
	PIZ,
	ZIP,
	DWAA,
	DWAB
}
