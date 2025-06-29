using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.EPCGSplineSamplingFill", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGSplineSamplingFill
{
	Fill,
	EdgesOnly
}
