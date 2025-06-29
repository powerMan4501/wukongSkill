using UnrealEngine.Runtime;

namespace UnrealEngine.NavigationSystem;

[UEnum]
[UMetaPath("/Script/NavigationSystem.ENavCostDisplay", "NavigationSystem", UnrealModuleType.Engine)]
public enum ENavCostDisplay
{
	TotalCost,
	HeuristicOnly,
	RealCostOnly
}
