using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Synthesis.EStereoChannelMode", "Synthesis", UnrealModuleType.EnginePlugin)]
public enum EStereoChannelMode : byte
{
	MidSide,
	LeftRight,
	Count
}
