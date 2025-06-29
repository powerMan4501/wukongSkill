using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.PCGDistanceShape", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGDistanceShape
{
	SphereBounds,
	BoxBounds,
	Center
}
