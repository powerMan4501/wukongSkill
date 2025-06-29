using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Synthesis.ESynthStereoDelayMode", "Synthesis", UnrealModuleType.EnginePlugin)]
public enum ESynthStereoDelayMode : byte
{
	Normal,
	Cross,
	PingPong,
	Count
}
