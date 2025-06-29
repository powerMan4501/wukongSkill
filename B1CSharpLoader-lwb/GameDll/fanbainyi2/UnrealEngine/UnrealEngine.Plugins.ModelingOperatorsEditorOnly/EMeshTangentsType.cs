using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ModelingOperatorsEditorOnly;

[UEnum]
[UMetaPath("/Script/ModelingOperatorsEditorOnly.EMeshTangentsType", "ModelingOperatorsEditorOnly", UnrealModuleType.EnginePlugin)]
public enum EMeshTangentsType
{
	MikkTSpace,
	FastMikkTSpace,
	PerTriangle,
	CopyExisting
}
