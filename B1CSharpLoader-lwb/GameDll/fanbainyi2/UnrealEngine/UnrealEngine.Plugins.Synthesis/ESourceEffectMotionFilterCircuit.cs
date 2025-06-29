using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Synthesis.ESourceEffectMotionFilterCircuit", "Synthesis", UnrealModuleType.EnginePlugin)]
public enum ESourceEffectMotionFilterCircuit : byte
{
	OnePole,
	StateVariable,
	Ladder,
	Count
}
