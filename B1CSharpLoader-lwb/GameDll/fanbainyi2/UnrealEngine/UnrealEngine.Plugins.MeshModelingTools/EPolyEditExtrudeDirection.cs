using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingTools;

[UEnum]
[UMetaPath("/Script/MeshModelingTools.EPolyEditExtrudeDirection", "MeshModelingTools", UnrealModuleType.EnginePlugin)]
public enum EPolyEditExtrudeDirection
{
	SelectionNormal,
	WorldX,
	WorldY,
	WorldZ,
	LocalX,
	LocalY,
	LocalZ
}
