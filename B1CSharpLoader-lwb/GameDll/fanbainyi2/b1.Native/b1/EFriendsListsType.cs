using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/b1.EFriendsListsType", "b1", UnrealModuleType.Game)]
public enum EFriendsListsType : byte
{
	Default,
	OnlinePlayers,
	InGamePlayers,
	InGameAndSessionPlayers
}
