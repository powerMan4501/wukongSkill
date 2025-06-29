using UnrealEngine.Runtime;

namespace UnrealEngine.InterchangeCore;

[UEnum]
[UMetaPath("/Script/InterchangeCore.EReimportStrategyFlags", "InterchangeCore", UnrealModuleType.Engine)]
public enum EReimportStrategyFlags
{
	ApplyNoProperties,
	ApplyPipelineProperties,
	ApplyEditorChangedProperties
}
