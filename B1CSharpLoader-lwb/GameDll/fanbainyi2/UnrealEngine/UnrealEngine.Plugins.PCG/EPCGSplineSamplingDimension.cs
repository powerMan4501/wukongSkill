using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.EPCGSplineSamplingDimension", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGSplineSamplingDimension
{
	OnSpline,
	OnHorizontal,
	OnVertical,
	OnVolume,
	OnInterior
}
