using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsExp.EOffsetMeshToolOffsetType", "MeshModelingToolsExp", UnrealModuleType.EnginePlugin)]
public enum EOffsetMeshToolOffsetType
{
	Iterative,
	Implicit
}
