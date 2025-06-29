using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsExp.EMeshSculptFalloffType", "MeshModelingToolsExp", UnrealModuleType.EnginePlugin)]
public enum EMeshSculptFalloffType
{
	Smooth,
	Linear,
	Inverse,
	Round,
	BoxSmooth,
	BoxLinear,
	BoxInverse,
	BoxRound,
	LastValue
}
