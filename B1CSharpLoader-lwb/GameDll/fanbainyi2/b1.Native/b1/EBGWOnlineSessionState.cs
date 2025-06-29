using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/b1.EBGWOnlineSessionState", "b1", UnrealModuleType.Game)]
public enum EBGWOnlineSessionState : byte
{
	NoSession,
	Creating,
	Pending,
	Starting,
	InProgress,
	Ending,
	Ended,
	Destroying
}
