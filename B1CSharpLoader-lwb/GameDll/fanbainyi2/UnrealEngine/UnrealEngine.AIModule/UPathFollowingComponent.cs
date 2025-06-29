using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/AIModule.PathFollowingComponent", "AIModule", UnrealModuleType.Engine)]
public class UPathFollowingComponent : UActorComponent, IAIResourceInterface, IInterface, IPathFollowingAgentInterface
{
}
