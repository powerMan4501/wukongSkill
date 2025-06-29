using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshPaintingToolset;

[UEnum]
[UMetaPath("/Script/MeshPaintingToolset.EMeshVertexPaintModeTarget", "MeshPaintingToolset", UnrealModuleType.EnginePlugin)]
public enum EMeshVertexPaintModeTarget
{
	ComponentInstance,
	Mesh
}
