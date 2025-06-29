using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsExp.EMeshFacesColorMode", "MeshModelingToolsExp", UnrealModuleType.EnginePlugin)]
public enum EMeshFacesColorMode
{
	None,
	ByGroup,
	ByMaterialID,
	ByUVIsland
}
