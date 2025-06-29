using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.PCGSpatialNoiseMask2DMode", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGSpatialNoiseMask2DMode
{
	Perlin,
	Caustic,
	FractionalBrownian
}
