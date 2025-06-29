using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/AIModule.EPathFollowingResult", "AIModule", UnrealModuleType.Engine)]
public enum EPathFollowingResult : byte
{
	Success,
	Blocked,
	OffPath,
	Aborted,
	Skipped_DEPRECATED,
	Invalid
}
