using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Synthesis.ESubmixFilterType", "Synthesis", UnrealModuleType.EnginePlugin)]
public enum ESubmixFilterType : byte
{
	LowPass,
	HighPass,
	BandPass,
	BandStop,
	Count
}
