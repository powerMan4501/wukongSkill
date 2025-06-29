using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/AIModule.EPathFollowingAction", "AIModule", UnrealModuleType.Engine)]
public enum EPathFollowingAction : byte
{
	Error,
	NoMove,
	DirectMove,
	PartialPath,
	PathToGoal
}
