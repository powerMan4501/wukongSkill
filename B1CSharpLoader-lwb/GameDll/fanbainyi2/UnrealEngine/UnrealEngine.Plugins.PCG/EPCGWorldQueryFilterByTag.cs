using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.EPCGWorldQueryFilterByTag", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGWorldQueryFilterByTag
{
	NoTagFilter,
	IncludeTagged,
	ExcludeTagged
}
