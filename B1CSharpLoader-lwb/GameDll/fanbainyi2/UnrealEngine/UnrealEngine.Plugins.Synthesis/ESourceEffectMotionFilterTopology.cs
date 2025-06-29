using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Synthesis.ESourceEffectMotionFilterTopology", "Synthesis", UnrealModuleType.EnginePlugin)]
public enum ESourceEffectMotionFilterTopology : byte
{
	SerialMode,
	ParallelMode,
	Count
}
