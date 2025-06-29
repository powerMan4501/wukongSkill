using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Synthesis.ESourceEffectMotionFilterModDestination", "Synthesis", UnrealModuleType.EnginePlugin)]
public enum ESourceEffectMotionFilterModDestination : byte
{
	FilterACutoffFrequency,
	FilterAResonance,
	FilterAOutputVolumeDB,
	FilterBCutoffFrequency,
	FilterBResonance,
	FilterBOutputVolumeDB,
	FilterMix,
	Count
}
