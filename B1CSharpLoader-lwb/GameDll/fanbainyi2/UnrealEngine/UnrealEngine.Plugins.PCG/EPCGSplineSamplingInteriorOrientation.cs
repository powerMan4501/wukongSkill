using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.EPCGSplineSamplingInteriorOrientation", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGSplineSamplingInteriorOrientation
{
	Uniform,
	FollowCurvature
}
