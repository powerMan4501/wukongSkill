using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsExp.ESmoothMeshToolSmoothType", "MeshModelingToolsExp", UnrealModuleType.EnginePlugin)]
public enum ESmoothMeshToolSmoothType
{
	Iterative,
	Implicit,
	Diffusion
}
