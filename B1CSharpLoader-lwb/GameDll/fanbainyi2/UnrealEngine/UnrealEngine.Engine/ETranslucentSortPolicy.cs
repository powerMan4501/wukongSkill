using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ETranslucentSortPolicy", "Engine", UnrealModuleType.Engine)]
public enum ETranslucentSortPolicy
{
	SortByDistance,
	SortByProjectedZ,
	SortAlongAxis
}
