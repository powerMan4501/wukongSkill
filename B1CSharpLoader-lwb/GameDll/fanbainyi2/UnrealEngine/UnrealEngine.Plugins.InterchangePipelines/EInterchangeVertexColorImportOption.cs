using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.InterchangePipelines;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/InterchangePipelines.EInterchangeVertexColorImportOption", "InterchangePipelines", UnrealModuleType.EnginePlugin)]
public enum EInterchangeVertexColorImportOption : byte
{
	IVCIO_Replace,
	IVCIO_Ignore,
	IVCIO_Override
}
