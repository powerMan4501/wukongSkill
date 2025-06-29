using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsExp.EFlareProfileType", "MeshModelingToolsExp", UnrealModuleType.EnginePlugin)]
public enum EFlareProfileType
{
	SinMode,
	SinSquaredMode,
	TriangleMode
}
