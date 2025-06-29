using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsExp.EMeshGroupPaintBrushType", "MeshModelingToolsExp", UnrealModuleType.EnginePlugin)]
public enum EMeshGroupPaintBrushType
{
	Paint,
	Erase,
	LastValue
}
