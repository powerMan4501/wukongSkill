using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Synthesis.ESynth1PatchSource", "Synthesis", UnrealModuleType.EnginePlugin)]
public enum ESynth1PatchSource : byte
{
	LFO1,
	LFO2,
	Envelope,
	BiasEnvelope,
	Count
}
