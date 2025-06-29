using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingTools;

[UEnum]
[UMetaPath("/Script/MeshModelingTools.EDrawPolygonExtrudeMode", "MeshModelingTools", UnrealModuleType.EnginePlugin)]
public enum EDrawPolygonExtrudeMode
{
	Flat,
	Fixed,
	Interactive
}
