using UnrealEngine.Runtime;

namespace UnrealEngine.GeometryCollectionEngine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/GeometryCollectionEngine.EChaosRemovalSortMethod", "GeometryCollectionEngine", UnrealModuleType.Engine)]
public enum EChaosRemovalSortMethod : byte
{
	SortNone,
	SortByHighestMass,
	SortByNearestFirst,
	Count
}
