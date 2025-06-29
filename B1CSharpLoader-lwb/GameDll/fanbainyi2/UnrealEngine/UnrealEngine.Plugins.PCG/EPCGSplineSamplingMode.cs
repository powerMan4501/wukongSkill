using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.EPCGSplineSamplingMode", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGSplineSamplingMode
{
	Subdivision,
	Distance
}
