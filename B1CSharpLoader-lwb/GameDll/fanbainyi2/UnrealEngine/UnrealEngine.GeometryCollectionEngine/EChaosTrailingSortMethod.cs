using UnrealEngine.Runtime;

namespace UnrealEngine.GeometryCollectionEngine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/GeometryCollectionEngine.EChaosTrailingSortMethod", "GeometryCollectionEngine", UnrealModuleType.Engine)]
public enum EChaosTrailingSortMethod : byte
{
	SortNone,
	SortByHighestMass,
	SortByHighestSpeed,
	SortByNearestFirst,
	Count
}
