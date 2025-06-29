using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsExp.EGroupTopologyDeformationStrategy", "MeshModelingToolsExp", UnrealModuleType.EnginePlugin)]
public enum EGroupTopologyDeformationStrategy
{
	Linear,
	Laplacian
}
