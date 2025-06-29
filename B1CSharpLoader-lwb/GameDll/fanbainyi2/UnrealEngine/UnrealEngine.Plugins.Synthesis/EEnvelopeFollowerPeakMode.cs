using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Synthesis.EEnvelopeFollowerPeakMode", "Synthesis", UnrealModuleType.EnginePlugin)]
public enum EEnvelopeFollowerPeakMode : byte
{
	MeanSquared,
	RootMeanSquared,
	Peak,
	Count
}
