using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.EnhancedInput;

[UEnum]
[UMetaPath("/Script/EnhancedInput.ETriggerEventsSupported", "EnhancedInput", UnrealModuleType.EnginePlugin)]
public enum ETriggerEventsSupported
{
	None = 0,
	Instant = 1,
	Uninterruptible = 2,
	Ongoing = 4,
	All = 7
}
