using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Synthesis.ESynth1PatchDestination", "Synthesis", UnrealModuleType.EnginePlugin)]
public enum ESynth1PatchDestination : byte
{
	Osc1Gain,
	Osc1Frequency,
	Osc1Pulsewidth,
	Osc2Gain,
	Osc2Frequency,
	Osc2Pulsewidth,
	FilterFrequency,
	FilterQ,
	Gain,
	Pan,
	LFO1Frequency,
	LFO1Gain,
	LFO2Frequency,
	LFO2Gain,
	Count
}
