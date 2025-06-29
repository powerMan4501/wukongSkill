using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.EnhancedInput;

[UEnum]
[UMetaPath("/Script/EnhancedInput.ETriggerState", "EnhancedInput", UnrealModuleType.EnginePlugin)]
public enum ETriggerState
{
	None,
	Ongoing,
	Triggered
}
