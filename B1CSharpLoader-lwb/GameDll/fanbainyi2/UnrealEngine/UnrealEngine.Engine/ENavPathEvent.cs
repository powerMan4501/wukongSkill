using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ENavPathEvent", "Engine", UnrealModuleType.Engine)]
public enum ENavPathEvent
{
	Cleared,
	NewPath,
	UpdatedDueToGoalMoved,
	UpdatedDueToNavigationChanged,
	Invalidated,
	RePathFailed,
	MetaPathUpdate,
	Custom
}
