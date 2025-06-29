using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsExp.EDrawPolyPathExtrudeMode", "MeshModelingToolsExp", UnrealModuleType.EnginePlugin)]
public enum EDrawPolyPathExtrudeMode
{
	Flat,
	Fixed,
	Interactive,
	RampFixed,
	RampInteractive
}
