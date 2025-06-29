using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsExp.EAlignObjectsBoxPoint", "MeshModelingToolsExp", UnrealModuleType.EnginePlugin)]
public enum EAlignObjectsBoxPoint
{
	Center,
	Bottom,
	Top,
	Left,
	Right,
	Front,
	Back,
	Min,
	Max
}
