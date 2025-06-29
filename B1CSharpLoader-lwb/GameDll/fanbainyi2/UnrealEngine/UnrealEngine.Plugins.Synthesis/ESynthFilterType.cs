using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Synthesis.ESynthFilterType", "Synthesis", UnrealModuleType.EnginePlugin)]
public enum ESynthFilterType : byte
{
	LowPass,
	HighPass,
	BandPass,
	BandStop,
	Count
}
