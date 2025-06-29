using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Synthesis.ESynthModEnvPatch", "Synthesis", UnrealModuleType.EnginePlugin)]
public enum ESynthModEnvPatch : byte
{
	PatchToNone,
	PatchToOscFreq,
	PatchToFilterFreq,
	PatchToFilterQ,
	PatchToLFO1Gain,
	PatchToLFO2Gain,
	PatchToLFO1Freq,
	PatchToLFO2Freq,
	Count
}
