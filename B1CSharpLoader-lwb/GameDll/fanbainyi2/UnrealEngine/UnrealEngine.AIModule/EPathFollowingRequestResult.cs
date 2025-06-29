using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/AIModule.EPathFollowingRequestResult", "AIModule", UnrealModuleType.Engine)]
public enum EPathFollowingRequestResult : byte
{
	Failed,
	AlreadyAtGoal,
	RequestSuccessful
}
