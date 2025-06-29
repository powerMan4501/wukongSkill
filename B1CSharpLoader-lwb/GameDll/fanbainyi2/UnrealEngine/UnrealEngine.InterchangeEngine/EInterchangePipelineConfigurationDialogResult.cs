using UnrealEngine.Runtime;

namespace UnrealEngine.InterchangeEngine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/InterchangeEngine.EInterchangePipelineConfigurationDialogResult", "InterchangeEngine", UnrealModuleType.Engine)]
public enum EInterchangePipelineConfigurationDialogResult : byte
{
	Cancel,
	Import,
	ImportAll
}
