using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsExp.EMeshGroupPaintInteractionType", "MeshModelingToolsExp", UnrealModuleType.EnginePlugin)]
public enum EMeshGroupPaintInteractionType
{
	Brush,
	Fill,
	GroupFill,
	PolyLasso,
	LastValue
}
