using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.EnhancedInput;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/EnhancedInput.EModifierExecutionPhase", "EnhancedInput", UnrealModuleType.EnginePlugin)]
public enum EModifierExecutionPhase : byte
{
	PerInput,
	FinalValue,
	NumPhases
}
