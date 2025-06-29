using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsExp.ENonlinearOperationType", "MeshModelingToolsExp", UnrealModuleType.EnginePlugin)]
public enum ENonlinearOperationType
{
	Bend,
	Flare,
	Twist
}
