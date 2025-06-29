using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/b1.EOnlinePresenceStateType", "b1", UnrealModuleType.Game)]
public enum EOnlinePresenceStateType : byte
{
	Online,
	Offline,
	Away,
	ExtendedAway,
	DoNotDisturb,
	Chat
}
