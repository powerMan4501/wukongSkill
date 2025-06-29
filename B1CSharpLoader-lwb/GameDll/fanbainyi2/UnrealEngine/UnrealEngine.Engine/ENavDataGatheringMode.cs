using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ENavDataGatheringMode", "Engine", UnrealModuleType.Engine)]
public enum ENavDataGatheringMode
{
	Default,
	Instant,
	Lazy
}
