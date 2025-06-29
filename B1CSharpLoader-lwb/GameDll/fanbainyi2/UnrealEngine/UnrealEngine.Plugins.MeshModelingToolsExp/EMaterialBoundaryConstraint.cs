using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsExp.EMaterialBoundaryConstraint", "MeshModelingToolsExp", UnrealModuleType.EnginePlugin)]
public enum EMaterialBoundaryConstraint
{
	Fixed = 7,
	Refine = 5,
	Free = 1,
	Ignore = 0
}
