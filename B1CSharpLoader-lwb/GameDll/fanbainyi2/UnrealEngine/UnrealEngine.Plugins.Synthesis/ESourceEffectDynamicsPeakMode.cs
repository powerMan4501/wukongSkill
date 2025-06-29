using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Synthesis.ESourceEffectDynamicsPeakMode", "Synthesis", UnrealModuleType.EnginePlugin)]
public enum ESourceEffectDynamicsPeakMode : byte
{
	MeanSquared,
	RootMeanSquared,
	Peak,
	Count
}
