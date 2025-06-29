using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Party;

[UEnum]
[UMetaPath("/Script/Party.ESocialPartyInviteFailureReason", "Party", UnrealModuleType.EnginePlugin)]
public enum ESocialPartyInviteFailureReason
{
	Success,
	NotOnline,
	NotAcceptingMembers,
	NotFriends,
	AlreadyInParty,
	OssValidationFailed,
	PlatformInviteFailed,
	PartyInviteFailed,
	InviteRateLimitExceeded
}
