using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Synthesis.EPhaserLFOType", "Synthesis", UnrealModuleType.EnginePlugin)]
public enum EPhaserLFOType : byte
{
	Sine,
	UpSaw,
	DownSaw,
	Square,
	Triangle,
	Exponential,
	RandomSampleHold,
	Count
}
