using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ModelingOperatorsEditorOnly;

[UEnum]
[UMetaPath("/Script/ModelingOperatorsEditorOnly.EEmbeddedPolygonOpMethod", "ModelingOperatorsEditorOnly", UnrealModuleType.EnginePlugin)]
public enum EEmbeddedPolygonOpMethod
{
	TrimOutside,
	TrimInside,
	InsertPolygon,
	CutThrough
}
