using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsExp.EPlaneCutToolActions", "MeshModelingToolsExp", UnrealModuleType.EnginePlugin)]
public enum EPlaneCutToolActions
{
	NoAction,
	Cut,
	FlipPlane
}
