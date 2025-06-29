using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.EPCGAttributeFilterOperation", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGAttributeFilterOperation
{
	KeepSelectedAttributes,
	DeleteSelectedAttributes
}
