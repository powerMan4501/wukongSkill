using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsEditorOnlyExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsEditorOnlyExp.EAttributeEditorElementType", "MeshModelingToolsEditorOnlyExp", UnrealModuleType.EnginePlugin)]
public enum EAttributeEditorElementType
{
	Vertex,
	VertexInstance,
	Triangle,
	Polygon,
	Edge,
	PolygonGroup
}
