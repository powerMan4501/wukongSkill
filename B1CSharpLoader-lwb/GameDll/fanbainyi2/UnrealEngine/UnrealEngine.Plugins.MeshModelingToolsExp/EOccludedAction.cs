using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsExp.EOccludedAction", "MeshModelingToolsExp", UnrealModuleType.EnginePlugin)]
public enum EOccludedAction
{
	Remove,
	SetNewGroup
}
