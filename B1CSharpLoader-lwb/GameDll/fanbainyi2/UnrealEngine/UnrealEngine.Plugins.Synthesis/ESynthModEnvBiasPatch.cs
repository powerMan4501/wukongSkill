using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Synthesis.ESynthModEnvBiasPatch", "Synthesis", UnrealModuleType.EnginePlugin)]
public enum ESynthModEnvBiasPatch : byte
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
