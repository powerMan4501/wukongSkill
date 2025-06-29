using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.EnhancedInput;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/EnhancedInput.ETriggerEvent", "EnhancedInput", UnrealModuleType.EnginePlugin)]
public enum ETriggerEvent : byte
{
	None,
	Triggered,
	Started,
	Ongoing,
	Canceled,
	Completed
}
