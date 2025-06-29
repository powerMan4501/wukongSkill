using UnrealEngine.Runtime;

namespace UnrealEngine.NavigationSystem;

[UEnum]
[UMetaPath("/Script/NavigationSystem.ERecastPartitioning", "NavigationSystem", UnrealModuleType.Engine)]
public enum ERecastPartitioning
{
	Monotone,
	Watershed,
	ChunkyMonotone
}
