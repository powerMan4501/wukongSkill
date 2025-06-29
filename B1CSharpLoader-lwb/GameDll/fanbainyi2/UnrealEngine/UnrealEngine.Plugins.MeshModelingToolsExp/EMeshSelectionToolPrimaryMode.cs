using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsExp.EMeshSelectionToolPrimaryMode", "MeshModelingToolsExp", UnrealModuleType.EnginePlugin)]
public enum EMeshSelectionToolPrimaryMode
{
	Brush,
	VolumetricBrush,
	AngleFiltered,
	Visible,
	AllConnected,
	AllInGroup,
	ByMaterial,
	ByUVIsland,
	AllWithinAngle
}
