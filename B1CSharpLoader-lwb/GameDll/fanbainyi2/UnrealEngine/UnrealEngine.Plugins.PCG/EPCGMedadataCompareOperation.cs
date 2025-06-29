using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.EPCGMedadataCompareOperation", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGMedadataCompareOperation
{
	Equal,
	NotEqual,
	Greater,
	GreaterOrEqual,
	Less,
	LessOrEqual
}
