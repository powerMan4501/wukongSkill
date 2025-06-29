using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/b1.EFriendsStateType", "b1", UnrealModuleType.Game)]
public enum EFriendsStateType : byte
{
	Online,
	Offline,
	Away,
	ExtendedAway,
	DoNotDisturb,
	Chat
}
