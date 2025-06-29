using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.EPCGSelfPruningType", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGSelfPruningType
{
	LargeToSmall,
	SmallToLarge,
	AllEqual,
	None,
	RemoveDuplicates
}
