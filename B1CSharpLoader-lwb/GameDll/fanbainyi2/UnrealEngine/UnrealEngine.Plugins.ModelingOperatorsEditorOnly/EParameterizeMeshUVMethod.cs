using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ModelingOperatorsEditorOnly;

[UEnum]
[UMetaPath("/Script/ModelingOperatorsEditorOnly.EParameterizeMeshUVMethod", "ModelingOperatorsEditorOnly", UnrealModuleType.EnginePlugin)]
public enum EParameterizeMeshUVMethod
{
	PatchBuilder,
	UVAtlas,
	XAtlas
}
