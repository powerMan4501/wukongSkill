using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.SkeletalMeshOptimizationType", "Engine", UnrealModuleType.Engine)]
public enum ESkeletalMeshOptimizationType
{
	SMOT_NumOfTriangles,
	SMOT_MaxDeviation,
	SMOT_TriangleOrDeviation
}
