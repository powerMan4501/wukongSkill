using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.EPCGIntersectionDensityFunction", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGIntersectionDensityFunction
{
	Multiply,
	Minimum
}
