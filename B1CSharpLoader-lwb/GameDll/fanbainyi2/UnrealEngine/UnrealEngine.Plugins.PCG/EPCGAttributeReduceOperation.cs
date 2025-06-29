using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.EPCGAttributeReduceOperation", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGAttributeReduceOperation
{
	Average,
	Max,
	Min
}
