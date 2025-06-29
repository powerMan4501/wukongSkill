using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Synthesis.ESynthLFOPatchType", "Synthesis", UnrealModuleType.EnginePlugin)]
public enum ESynthLFOPatchType : byte
{
	PatchToNone,
	PatchToGain,
	PatchToOscFreq,
	PatchToFilterFreq,
	PatchToFilterQ,
	PatchToOscPulseWidth,
	PatchToOscPan,
	PatchLFO1ToLFO2Frequency,
	PatchLFO1ToLFO2Gain,
	Count
}
