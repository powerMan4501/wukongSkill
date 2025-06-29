using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsExp.EMeshBoundaryConstraint", "MeshModelingToolsExp", UnrealModuleType.EnginePlugin)]
public enum EMeshBoundaryConstraint
{
	Fixed = 7,
	Refine = 5,
	Free = 1
}
