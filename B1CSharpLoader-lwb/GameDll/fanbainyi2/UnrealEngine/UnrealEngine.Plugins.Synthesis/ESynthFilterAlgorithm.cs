using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Synthesis.ESynthFilterAlgorithm", "Synthesis", UnrealModuleType.EnginePlugin)]
public enum ESynthFilterAlgorithm : byte
{
	OnePole,
	StateVariable,
	Ladder,
	Count
}
