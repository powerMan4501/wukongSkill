using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingTools;

[UEnum]
[UMetaPath("/Script/MeshModelingTools.EDrawPolygonDrawMode", "MeshModelingTools", UnrealModuleType.EnginePlugin)]
public enum EDrawPolygonDrawMode
{
	Freehand,
	Circle,
	Square,
	Rectangle,
	RoundedRectangle,
	Ring
}
