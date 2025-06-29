using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EStaticMeshReductionTerimationCriterion", "Engine", UnrealModuleType.Engine)]
public enum EStaticMeshReductionTerimationCriterion
{
	Triangles,
	Vertices,
	Any
}
