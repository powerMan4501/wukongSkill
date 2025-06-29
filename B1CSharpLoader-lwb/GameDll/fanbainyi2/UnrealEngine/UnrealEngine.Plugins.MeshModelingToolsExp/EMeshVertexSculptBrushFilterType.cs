using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsExp.EMeshVertexSculptBrushFilterType", "MeshModelingToolsExp", UnrealModuleType.EnginePlugin)]
public enum EMeshVertexSculptBrushFilterType
{
	None,
	Component,
	PolyGroup
}
