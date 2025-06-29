using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsEditorOnlyExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsEditorOnlyExp.EPolygonType", "MeshModelingToolsEditorOnlyExp", UnrealModuleType.EnginePlugin)]
public enum EPolygonType
{
	Circle,
	Square,
	Rectangle,
	RoundRect,
	Custom
}
