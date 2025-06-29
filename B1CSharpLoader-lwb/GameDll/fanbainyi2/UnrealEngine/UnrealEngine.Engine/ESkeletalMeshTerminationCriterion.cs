using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.SkeletalMeshTerminationCriterion", "Engine", UnrealModuleType.Engine)]
public enum ESkeletalMeshTerminationCriterion
{
	SMTC_NumOfTriangles,
	SMTC_NumOfVerts,
	SMTC_TriangleOrVert,
	SMTC_AbsNumOfTriangles,
	SMTC_AbsNumOfVerts,
	SMTC_AbsTriangleOrVert
}
