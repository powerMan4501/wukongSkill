using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Synthesis.ESubmixFilterAlgorithm", "Synthesis", UnrealModuleType.EnginePlugin)]
public enum ESubmixFilterAlgorithm : byte
{
	OnePole,
	StateVariable,
	Ladder,
	Count
}
