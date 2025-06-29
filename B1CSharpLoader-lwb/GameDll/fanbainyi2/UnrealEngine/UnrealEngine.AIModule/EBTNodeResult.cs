using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/AIModule.EBTNodeResult", "AIModule", UnrealModuleType.Engine)]
public enum EBTNodeResult : byte
{
	Succeeded,
	Failed,
	Aborted,
	InProgress
}
