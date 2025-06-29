using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.EPCGPointProperties", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGPointProperties
{
	Density,
	BoundsMin,
	BoundsMax,
	Extents,
	Color,
	Position,
	Rotation,
	Scale,
	Transform,
	Steepness,
	LocalCenter,
	Seed
}
