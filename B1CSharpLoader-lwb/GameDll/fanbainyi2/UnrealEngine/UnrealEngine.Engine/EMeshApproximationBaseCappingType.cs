using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EMeshApproximationBaseCappingType", "Engine", UnrealModuleType.Engine)]
public enum EMeshApproximationBaseCappingType
{
	NoBaseCapping,
	ConvexPolygon,
	ConvexSolid
}
