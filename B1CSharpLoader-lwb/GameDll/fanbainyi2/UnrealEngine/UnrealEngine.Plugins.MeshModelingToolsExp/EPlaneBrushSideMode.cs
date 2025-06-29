using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsExp.EPlaneBrushSideMode", "MeshModelingToolsExp", UnrealModuleType.EnginePlugin)]
public enum EPlaneBrushSideMode
{
	BothSides,
	PushDown,
	PullTowards
}
