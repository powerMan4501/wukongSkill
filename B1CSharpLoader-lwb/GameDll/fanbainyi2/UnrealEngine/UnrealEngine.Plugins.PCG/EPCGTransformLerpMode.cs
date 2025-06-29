using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.EPCGTransformLerpMode", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGTransformLerpMode
{
	QuatInterp,
	EulerInterp,
	DualQuatInterp
}
