using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.PCGSpatialNoiseMode", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGSpatialNoiseMode
{
	Perlin2D,
	Caustic2D,
	Voronoi2D,
	FractionalBrownian2D,
	EdgeMask2D
}
