using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsEditorOnlyExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsEditorOnlyExp.EMeshToVolumeMode", "MeshModelingToolsEditorOnlyExp", UnrealModuleType.EnginePlugin)]
public enum EMeshToVolumeMode
{
	TriangulatePolygons,
	MinimalPolygons
}
