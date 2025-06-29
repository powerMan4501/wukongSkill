using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ModelingOperatorsEditorOnly;

[UEnum]
[UMetaPath("/Script/ModelingOperatorsEditorOnly.ESimplifyTargetType", "ModelingOperatorsEditorOnly", UnrealModuleType.EnginePlugin)]
public enum ESimplifyTargetType
{
	Percentage,
	TriangleCount,
	VertexCount,
	EdgeLength,
	MinimalPlanar
}
