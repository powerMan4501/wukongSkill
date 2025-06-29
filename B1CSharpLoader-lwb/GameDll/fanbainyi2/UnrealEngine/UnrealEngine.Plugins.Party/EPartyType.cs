using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Party;

[UEnum]
[UMetaPath("/Script/Party.EPartyType", "Party", UnrealModuleType.EnginePlugin)]
public enum EPartyType
{
	Public,
	FriendsOnly,
	Private
}
