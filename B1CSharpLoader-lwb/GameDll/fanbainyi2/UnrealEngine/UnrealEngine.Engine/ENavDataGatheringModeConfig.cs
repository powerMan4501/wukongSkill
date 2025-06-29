using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ENavDataGatheringModeConfig", "Engine", UnrealModuleType.Engine)]
public enum ENavDataGatheringModeConfig
{
	Invalid,
	Instant,
	Lazy
}
