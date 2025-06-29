using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/b1.EBGWOnlineSessionType", "b1", UnrealModuleType.Game)]
public enum EBGWOnlineSessionType : byte
{
	InvalidSession,
	GameSession,
	PlayerSession,
	PartySession
}
