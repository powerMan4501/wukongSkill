using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Synthesis.ESourceEffectMotionFilterModSource", "Synthesis", UnrealModuleType.EnginePlugin)]
public enum ESourceEffectMotionFilterModSource : byte
{
	DistanceFromListener,
	SpeedRelativeToListener,
	SpeedOfSourceEmitter,
	SpeedOfListener,
	SpeedOfAngleDelta,
	Count
}
