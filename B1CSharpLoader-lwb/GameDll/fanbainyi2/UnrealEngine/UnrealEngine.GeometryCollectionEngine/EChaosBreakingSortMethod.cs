using UnrealEngine.Runtime;

namespace UnrealEngine.GeometryCollectionEngine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/GeometryCollectionEngine.EChaosBreakingSortMethod", "GeometryCollectionEngine", UnrealModuleType.Engine)]
public enum EChaosBreakingSortMethod : byte
{
	SortNone,
	SortByHighestMass,
	SortByHighestSpeed,
	SortByNearestFirst,
	Count
}
