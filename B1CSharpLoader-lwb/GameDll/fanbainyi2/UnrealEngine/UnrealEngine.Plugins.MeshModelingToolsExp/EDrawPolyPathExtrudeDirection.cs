using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsExp.EDrawPolyPathExtrudeDirection", "MeshModelingToolsExp", UnrealModuleType.EnginePlugin)]
public enum EDrawPolyPathExtrudeDirection
{
	SelectionNormal,
	WorldX,
	WorldY,
	WorldZ,
	LocalX,
	LocalY,
	LocalZ
}
