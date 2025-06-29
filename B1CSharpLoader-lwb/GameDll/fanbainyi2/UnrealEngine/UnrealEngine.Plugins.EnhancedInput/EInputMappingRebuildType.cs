using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.EnhancedInput;

[UEnum]
[UMetaPath("/Script/EnhancedInput.EInputMappingRebuildType", "EnhancedInput", UnrealModuleType.EnginePlugin)]
public enum EInputMappingRebuildType
{
	None,
	Rebuild,
	RebuildWithFlush
}
