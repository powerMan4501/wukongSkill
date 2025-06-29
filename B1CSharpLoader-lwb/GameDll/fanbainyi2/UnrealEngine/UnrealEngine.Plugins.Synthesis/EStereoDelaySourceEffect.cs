using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Synthesis.EStereoDelaySourceEffect", "Synthesis", UnrealModuleType.EnginePlugin)]
public enum EStereoDelaySourceEffect : byte
{
	Normal,
	Cross,
	PingPong,
	Count
}
