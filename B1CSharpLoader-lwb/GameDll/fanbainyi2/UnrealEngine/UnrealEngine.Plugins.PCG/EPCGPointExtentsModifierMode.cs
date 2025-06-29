using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.EPCGPointExtentsModifierMode", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGPointExtentsModifierMode
{
	Set,
	Minimum,
	Maximum,
	Add,
	Multiply
}
