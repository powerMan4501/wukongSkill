using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Synthesis.ESynthLFOType", "Synthesis", UnrealModuleType.EnginePlugin)]
public enum ESynthLFOType : byte
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
