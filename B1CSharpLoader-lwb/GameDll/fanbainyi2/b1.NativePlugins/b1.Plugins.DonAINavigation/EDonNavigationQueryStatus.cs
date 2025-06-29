using UnrealEngine.Runtime;

namespace b1.Plugins.DonAINavigation;

[UEnum]
[UMetaPath("/Script/DonAINavigation.EDonNavigationQueryStatus", "DonAINavigation", UnrealModuleType.GamePlugin)]
public enum EDonNavigationQueryStatus
{
	Unscheduled,
	InProgress,
	Success,
	Failure,
	QueryHasNoSolution,
	TimedOut
}
