using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingTools;

[UEnum]
[UMetaPath("/Script/MeshModelingTools.ESetMeshMaterialMode", "MeshModelingTools", UnrealModuleType.EnginePlugin)]
public enum ESetMeshMaterialMode
{
	Original,
	Checkerboard,
	Override
}
