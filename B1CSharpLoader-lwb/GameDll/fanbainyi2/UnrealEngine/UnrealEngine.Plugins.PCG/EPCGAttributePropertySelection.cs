using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.EPCGAttributePropertySelection", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGAttributePropertySelection
{
	Attribute,
	PointProperty,
	ExtraProperty
}
