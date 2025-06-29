using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsExp.ELatticeInterpolationType", "MeshModelingToolsExp", UnrealModuleType.EnginePlugin)]
public enum ELatticeInterpolationType
{
	Linear,
	Cubic
}
