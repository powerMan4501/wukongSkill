using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsExp.EMeshGroupPaintVisibilityType", "MeshModelingToolsExp", UnrealModuleType.EnginePlugin)]
public enum EMeshGroupPaintVisibilityType
{
	None,
	FrontFacing,
	Unoccluded
}
