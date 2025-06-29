using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.EnhancedInput;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/EnhancedInput.EMappingQueryResult", "EnhancedInput", UnrealModuleType.EnginePlugin)]
public enum EMappingQueryResult : byte
{
	Error_EnhancedInputNotEnabled,
	Error_InputContextNotInActiveContexts,
	Error_InvalidAction,
	NotMappable,
	MappingAvailable
}
