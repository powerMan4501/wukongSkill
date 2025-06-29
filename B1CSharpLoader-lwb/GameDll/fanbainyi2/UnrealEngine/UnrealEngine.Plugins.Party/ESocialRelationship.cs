using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Party;

[UEnum]
[UMetaPath("/Script/Party.ESocialRelationship", "Party", UnrealModuleType.EnginePlugin)]
public enum ESocialRelationship
{
	Any,
	FriendInviteReceived,
	FriendInviteSent,
	PartyInvite,
	Friend,
	BlockedPlayer,
	SuggestedFriend,
	RecentPlayer,
	JoinRequest
}
