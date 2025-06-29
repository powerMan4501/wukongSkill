using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EMaxConcurrentResolutionRule", "Engine", UnrealModuleType.Engine)]
public enum EMaxConcurrentResolutionRule
{
	PreventNew,
	StopOldest,
	StopFarthestThenPreventNew,
	StopFarthestThenOldest,
	StopLowestPriority,
	StopQuietest,
	StopLowestPriorityThenPreventNew,
	Count
}
