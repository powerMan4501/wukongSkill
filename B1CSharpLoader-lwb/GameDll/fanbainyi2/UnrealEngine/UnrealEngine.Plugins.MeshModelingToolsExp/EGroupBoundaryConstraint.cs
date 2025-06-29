using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsExp.EGroupBoundaryConstraint", "MeshModelingToolsExp", UnrealModuleType.EnginePlugin)]
public enum EGroupBoundaryConstraint
{
	Fixed = 7,
	Refine = 5,
	Free = 1,
	Ignore = 0
}
