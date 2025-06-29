using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Synthesis.ESynthKnobSize", "Synthesis", UnrealModuleType.EnginePlugin)]
public enum ESynthKnobSize : byte
{
	Medium,
	Large,
	Count
}
