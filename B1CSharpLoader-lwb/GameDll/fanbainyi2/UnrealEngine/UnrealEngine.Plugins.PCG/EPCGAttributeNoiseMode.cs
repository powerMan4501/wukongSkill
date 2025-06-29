using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.EPCGAttributeNoiseMode", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGAttributeNoiseMode
{
	Set,
	Minimum,
	Maximum,
	Add,
	Multiply
}
