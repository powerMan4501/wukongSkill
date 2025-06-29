using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.EPCGMetadataFilterMode", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGMetadataFilterMode
{
	ExcludeAttributes,
	IncludeAttributes
}
