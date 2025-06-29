using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.EPCGDifferenceMode", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGDifferenceMode
{
	Inferred,
	Continuous,
	Discrete
}
