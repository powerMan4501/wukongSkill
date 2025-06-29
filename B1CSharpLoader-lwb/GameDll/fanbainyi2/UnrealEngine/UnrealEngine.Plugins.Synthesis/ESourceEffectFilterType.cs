using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Synthesis.ESourceEffectFilterType", "Synthesis", UnrealModuleType.EnginePlugin)]
public enum ESourceEffectFilterType : byte
{
	LowPass,
	HighPass,
	BandPass,
	BandStop,
	Count
}
