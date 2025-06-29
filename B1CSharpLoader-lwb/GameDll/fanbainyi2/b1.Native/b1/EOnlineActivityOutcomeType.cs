using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/b1.EOnlineActivityOutcomeType", "b1", UnrealModuleType.Game)]
public enum EOnlineActivityOutcomeType : byte
{
	Completed,
	Failed,
	Cancelled
}
