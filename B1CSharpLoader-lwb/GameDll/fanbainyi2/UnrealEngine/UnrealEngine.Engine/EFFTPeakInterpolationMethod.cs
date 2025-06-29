using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EFFTPeakInterpolationMethod", "Engine", UnrealModuleType.Engine)]
public enum EFFTPeakInterpolationMethod
{
	NearestNeighbor,
	Linear,
	Quadratic,
	ConstantQ
}
