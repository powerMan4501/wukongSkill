using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Synthesis.ESynth1OscType", "Synthesis", UnrealModuleType.EnginePlugin)]
public enum ESynth1OscType : byte
{
	Sine,
	Saw,
	Triangle,
	Square,
	Noise,
	Count
}
