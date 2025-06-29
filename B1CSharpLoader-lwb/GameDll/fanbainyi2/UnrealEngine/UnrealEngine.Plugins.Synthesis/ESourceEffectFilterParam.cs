using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Synthesis.ESourceEffectFilterParam", "Synthesis", UnrealModuleType.EnginePlugin)]
public enum ESourceEffectFilterParam : byte
{
	FilterFrequency,
	FilterResonance,
	Count
}
