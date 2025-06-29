using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Party;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Party.ESocialChannelType", "Party", UnrealModuleType.EnginePlugin)]
public enum ESocialChannelType : byte
{
	General,
	Founder,
	Party,
	Team,
	System,
	Private
}
