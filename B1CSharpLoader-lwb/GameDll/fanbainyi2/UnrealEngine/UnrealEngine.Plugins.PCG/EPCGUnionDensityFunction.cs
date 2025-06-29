using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.EPCGUnionDensityFunction", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGUnionDensityFunction
{
	Maximum,
	ClampedAddition,
	Binary
}
