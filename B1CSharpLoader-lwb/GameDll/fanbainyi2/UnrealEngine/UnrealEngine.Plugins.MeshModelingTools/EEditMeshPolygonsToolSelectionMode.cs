using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingTools;

[UEnum]
[UMetaPath("/Script/MeshModelingTools.EEditMeshPolygonsToolSelectionMode", "MeshModelingTools", UnrealModuleType.EnginePlugin)]
public enum EEditMeshPolygonsToolSelectionMode
{
	Faces,
	Edges,
	Vertices,
	Loops,
	Rings,
	FacesEdgesVertices
}
