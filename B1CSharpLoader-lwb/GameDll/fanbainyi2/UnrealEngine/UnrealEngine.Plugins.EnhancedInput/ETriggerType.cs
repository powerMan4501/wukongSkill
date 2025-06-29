using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.EnhancedInput;

[UEnum]
[UMetaPath("/Script/EnhancedInput.ETriggerType", "EnhancedInput", UnrealModuleType.EnginePlugin)]
public enum ETriggerType
{
	Explicit,
	Implicit,
	Blocker
}
