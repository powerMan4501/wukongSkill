using UnrealEngine.Runtime;

namespace UnrealEngine.GeometryCollectionEngine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/GeometryCollectionEngine.EChaosCollisionSortMethod", "GeometryCollectionEngine", UnrealModuleType.Engine)]
public enum EChaosCollisionSortMethod : byte
{
	SortNone,
	SortByHighestMass,
	SortByHighestSpeed,
	SortByHighestImpulse,
	SortByNearestFirst,
	Count
}
