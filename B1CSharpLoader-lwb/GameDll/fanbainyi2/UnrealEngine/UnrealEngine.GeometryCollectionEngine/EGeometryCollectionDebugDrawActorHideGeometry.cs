using UnrealEngine.Runtime;

namespace UnrealEngine.GeometryCollectionEngine;

[UEnum]
[UMetaPath("/Script/GeometryCollectionEngine.EGeometryCollectionDebugDrawActorHideGeometry", "GeometryCollectionEngine", UnrealModuleType.Engine)]
public enum EGeometryCollectionDebugDrawActorHideGeometry
{
	HideNone,
	HideWithCollision,
	HideSelected,
	HideWholeCollection,
	HideAll
}
