using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Synthesis.ESourceEffectMotionFilterType", "Synthesis", UnrealModuleType.EnginePlugin)]
public enum ESourceEffectMotionFilterType : byte
{
	LowPass,
	HighPass,
	BandPass,
	BandStop,
	Count
}
