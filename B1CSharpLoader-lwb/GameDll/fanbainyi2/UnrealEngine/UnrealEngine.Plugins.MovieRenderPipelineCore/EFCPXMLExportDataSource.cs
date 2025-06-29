using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MovieRenderPipelineCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/MovieRenderPipelineCore.FCPXMLExportDataSource", "MovieRenderPipelineCore", UnrealModuleType.EnginePlugin)]
public enum EFCPXMLExportDataSource : byte
{
	OutputMetadata,
	SequenceData
}
