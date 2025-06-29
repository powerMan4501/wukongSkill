using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/AIModule.EPathFollowingStatus", "AIModule", UnrealModuleType.Engine)]
public enum EPathFollowingStatus : byte
{
	Idle,
	Waiting,
	Paused,
	Moving
}
