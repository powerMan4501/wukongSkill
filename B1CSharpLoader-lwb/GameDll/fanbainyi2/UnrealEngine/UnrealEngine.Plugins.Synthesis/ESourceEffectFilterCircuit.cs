using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Synthesis.ESourceEffectFilterCircuit", "Synthesis", UnrealModuleType.EnginePlugin)]
public enum ESourceEffectFilterCircuit : byte
{
	OnePole,
	StateVariable,
	Ladder,
	Count
}
