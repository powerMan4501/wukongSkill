using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.EPCGBoundsModifierMode", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGBoundsModifierMode
{
	Set,
	Intersect,
	Include,
	Translate,
	Scale
}
