using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Party;

[UEnum]
[UMetaPath("/Script/Party.EPartyInviteRestriction", "Party", UnrealModuleType.EnginePlugin)]
public enum EPartyInviteRestriction
{
	AnyMember,
	LeaderOnly,
	NoInvites
}
