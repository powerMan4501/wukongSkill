using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.EPCGDifferenceDensityFunction", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGDifferenceDensityFunction
{
	Minimum,
	ClampedSubstraction,
	Binary
}
