using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.EPCGAttributeSelectOperation", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGAttributeSelectOperation
{
	Min,
	Max,
	Median
}
