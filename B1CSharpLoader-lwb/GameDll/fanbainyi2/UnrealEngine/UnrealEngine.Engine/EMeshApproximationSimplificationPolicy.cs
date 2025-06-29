using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EMeshApproximationSimplificationPolicy", "Engine", UnrealModuleType.Engine)]
public enum EMeshApproximationSimplificationPolicy
{
	FixedTriangleCount,
	TrianglesPerArea,
	GeometricTolerance
}
