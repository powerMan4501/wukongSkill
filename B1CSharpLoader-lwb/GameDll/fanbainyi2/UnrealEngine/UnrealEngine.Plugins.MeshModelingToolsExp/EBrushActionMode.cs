using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsExp.EBrushActionMode", "MeshModelingToolsExp", UnrealModuleType.EnginePlugin)]
public enum EBrushActionMode
{
	Paint,
	FloodFill
}
