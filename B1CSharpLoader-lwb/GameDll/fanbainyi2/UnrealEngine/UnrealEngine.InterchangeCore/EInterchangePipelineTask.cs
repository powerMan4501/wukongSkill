using UnrealEngine.Runtime;

namespace UnrealEngine.InterchangeCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/InterchangeCore.EInterchangePipelineTask", "InterchangeCore", UnrealModuleType.Engine)]
public enum EInterchangePipelineTask : byte
{
	PreFactoryImport,
	PostFactoryImport,
	Export
}
