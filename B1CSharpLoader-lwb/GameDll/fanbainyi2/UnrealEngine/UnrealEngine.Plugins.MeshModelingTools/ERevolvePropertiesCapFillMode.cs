using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingTools;

[UEnum]
[UMetaPath("/Script/MeshModelingTools.ERevolvePropertiesCapFillMode", "MeshModelingTools", UnrealModuleType.EnginePlugin)]
public enum ERevolvePropertiesCapFillMode
{
	None,
	CenterFan,
	Delaunay,
	EarClipping
}
